using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenAC.Net.Sat.Extrato.FastReport.OpenSource;
using NLog;
using NLog.Config;
using NLog.Targets;
using NLog.Windows.Forms;
using OpenAC.Net.Core.Extensions;
using OpenAC.Net.Devices;
using OpenAC.Net.DFe.Core.Common;
using OpenAC.Net.EscPos;
using OpenAC.Net.EscPos.Commom;
using OpenAC.Net.EscPos.Extensions;
using OpenAC.Net.Integrador;
using OpenAC.Net.Sat.Demo.Commom;
using OpenAC.Net.Sat.Extrato.EscPos;

namespace OpenAC.Net.Sat.Demo
{
    public partial class FrmMain : Form
    {
        #region Fields

        private ILogger logger;
        private CFe cfeAtual;
        private CFeCanc cfeCancAtual;
        private SatRede redeAtual;
        private readonly OpenConfig config;
        private OpenSat openSat;
        private ExtratoFastOpen extrato;
        private ExtratoEscPos escpos;
        private OpenIntegrador openIntegrador;

        #endregion Fields

        #region Constructors

        public FrmMain()
        {
            InitializeComponent();

            // .Net 5 e 6 não tem todos os CodePages.
            // Então tem que instalar o pacote System.Text.Encoding.CodePages.
            // Adiciona esta linha ao programa antes de usar o EscPos.
            // Isso so precisa ser feito 1 vez então faça na inialização do seu programa.
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            config = OpenConfig.CreateOrLoad(Path.Combine(Application.StartupPath, "sat.config"));
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            InitializeLog();
            Initialize();
        }

        #endregion Constructors

        #region Methods

        private void Initialize()
        {
            openIntegrador = new OpenIntegrador();
            openSat = new OpenSat();
            extrato = new ExtratoFastOpen();

            escpos = new ExtratoEscPos();

            cmbAmbiente.EnumDataSource(DFeTipoAmbiente.Homologacao);
            cmbModeloSat.EnumDataSource(ModeloSat.StdCall);
            cmbEmiRegTrib.EnumDataSource(RegTrib.Normal);
            cmbEmiRegTribISSQN.EnumDataSource(RegTribIssqn.Nenhum);
            cmbEmiRatIISQN.EnumDataSource(RatIssqn.Nao);
            cmbFiltro.EnumDataSource(FiltroDFeReport.Nenhum);
            cmbExtrato.EnumDataSource(TipoExtrato.FastReport);

            //EscPos
            cbbConexao.EnumDataSource(TipoConexao.Serial);
            cbbProtocolo.EnumDataSource(ProtocoloEscPos.EscPos);
            cbbEnconding.EnumDataSource(PaginaCodigo.pc850);
            cbbPortas.SetDataSource(SerialPort.GetPortNames());
            cbbImpressoras.SetDataSource(PrinterSettings.InstalledPrinters.Cast<string>().ToArray());
            cbbVelocidade.EnumDataSource(SerialBaud.Bd9600);
            cbbDataBits.EnumDataSource(SerialDataBits.Db8);
            cbbParity.EnumDataSource(Parity.None);
            cbbStopBits.EnumDataSource(StopBits.None);
            cbbHandshake.EnumDataSource(Handshake.None);

            tbcDeviceConfig.HideTabHeaders();
        }

        private void InitializeLog()
        {
            var config = new LoggingConfiguration();
            var target = new RichTextBoxTarget
            {
                UseDefaultRowColoringRules = true,
                Layout = @"${date:format=dd/MM/yyyy HH\:mm\:ss} - ${message}",
                FormName = Name,
                ControlName = rtbLog.Name,
                AutoScroll = true
            };

            config.AddTarget("RichTextBox", target);
            config.LoggingRules.Add(new LoggingRule("*", LogLevel.Debug, target));

            var infoTarget = new FileTarget
            {
                FileName = "${basedir:dir=Logs:file=OpenSat.log}",
                Layout = "${processid}|${longdate}|${level:uppercase=true}|" +
                         "${event-context:item=Context}|${logger}|${message}",
                CreateDirs = true,
                Encoding = Encoding.UTF8,
                MaxArchiveFiles = 93,
                ArchiveEvery = FileArchivePeriod.Day,
                ArchiveNumbering = ArchiveNumberingMode.Date,
                ArchiveFileName = "${basedir}/Logs/Archive/${date:format=yyyy}/${date:format=MM}/ACBrSat_{{#}}.log",
                ArchiveDateFormat = "dd.MM.yyyy"
            };

            config.AddTarget("infoFile", infoTarget);
            config.LoggingRules.Add(new LoggingRule("*", LogLevel.Debug, infoTarget));
            LogManager.Configuration = config;
            logger = LogManager.GetLogger("OpenSAT");
        }

        private void GerarCFe()
        {
            logger.Info("Gerando CFe");

            var totalGeral = 0M;
            cfeAtual = openSat.NewCFe();
            cfeAtual.InfCFe.Ide.NumeroCaixa = 1;
            cfeAtual.InfCFe.Dest.CPF = "";
            cfeAtual.InfCFe.Dest.Nome = "CONSUMIDOR";
            cfeAtual.InfCFe.Entrega.XLgr = "logradouro";
            cfeAtual.InfCFe.Entrega.Nro = "112233";
            cfeAtual.InfCFe.Entrega.XCpl = "complemento";
            cfeAtual.InfCFe.Entrega.XBairro = "bairro";
            cfeAtual.InfCFe.Entrega.XMun = "municipio";
            cfeAtual.InfCFe.Entrega.UF = "MS";
            for (var i = 0; i < 3; i++)
            {
                var det = cfeAtual.InfCFe.Det.AddNew();
                det.NItem = 1 + i;
                det.Prod.CProd = $"OPENAC{det.NItem:000}";
                det.Prod.CEAN = "6291041500213";
                det.Prod.XProd = "Assinatura SAC";
                det.Prod.NCM = "99";
                det.Prod.CFOP = "5120";
                det.Prod.UCom = "UN";
                det.Prod.QCom = 1;
                det.Prod.VUnCom = 120.00M;
                det.Prod.IndRegra = IndRegra.Truncamento;
                det.Prod.VDesc = i != 1 ? 1 : 0;

                var obs = new ProdObsFisco
                {
                    XCampoDet = "campo",
                    XTextoDet = "texto"
                };
                det.Prod.ObsFiscoDet.Add(obs);

                var totalItem = det.Prod.QCom * det.Prod.VUnCom;
                totalGeral += totalItem;
                det.Imposto.VItem12741 = totalItem * 0.12M;

                det.Imposto.Imposto = new ImpostoIcms
                {
                    Icms = new ImpostoIcms00
                    {
                        Orig = OrigemMercadoria.Nacional,
                        Cst = "00",
                        PIcms = 18
                    }
                };

                det.Imposto.Pis.Pis = new ImpostoPisAliq
                {
                    Cst = "01",
                    VBc = totalItem,
                    PPis = 0.0065M
                };

                det.Imposto.Cofins.Cofins = new ImpostoCofinsAliq
                {
                    Cst = "01",
                    VBc = totalItem,
                    PCofins = 0.0065M
                };

                det.InfAdProd = "Informacoes adicionais";
            }

            cfeAtual.InfCFe.Total.DescAcrEntr.VDescSubtot = 2;
            cfeAtual.InfCFe.Total.VCFeLei12741 = 1.23M;

            var pgto1 = cfeAtual.InfCFe.Pagto.Pagamentos.AddNew();
            pgto1.CMp = CodigoMP.CartaodeCredito;
            pgto1.VMp = totalGeral / 2;
            pgto1.CAdmC = 999;

            var pgto2 = cfeAtual.InfCFe.Pagto.Pagamentos.AddNew();
            pgto2.CMp = CodigoMP.Dinheiro;
            pgto2.VMp = totalGeral / 2 + 10;

            cfeAtual.InfCFe.InfAdic.InfCpl = "Acesse https://acbrnet.github.io/ para obter mais;informações sobre o componente ACBrSAT;";

            wbrXmlGerado.LoadXml(cfeAtual.GetXml());
            tbcXml.SelectedTab = tpgXmlGerado;
            logger.Info("CFe gerado com sucesso !");
        }

        private void ToogleInitialize()
        {
            if (openSat.Ativo)
            {
                openSat.Desativar();
                btnIniDesini.Text = @"Inicializar";
            }
            else
            {
                openSat.Ativar();
                btnIniDesini.Text = @"Desinicializar";
            }
        }

        private void LoadConfig()
        {
            if (openSat.Ativo) ToogleInitialize();

            cmbModeloSat.SetSelectedValue(config.Get("ModeloSat", ModeloSat.Cdecl));
            txtDllPath.Text = config.Get("DllPath", @"C:\SAT\SAT.dll");
            cmbAmbiente.SetSelectedValue(config.Get("Ambiente", DFeTipoAmbiente.Homologacao));
            txtAtivacao.Text = config.Get("Ativacao", "12345678");
            txtCodUF.Text = config.Get("CodUF", "35");
            nunPaginaCodigo.Value = config.Get("PaginaCodigo", 1252M);
            nunCaixa.Value = config.Get("Caixa", 1M);

            nunVersaoCFe.Value = config.Get("VersaoCFe", 0.08M);
            chkUTF8_CheckedChanged(nunVersaoCFe, EventArgs.Empty);

            chkUTF8.Checked = config.Get("UTF8", false);
            chkRemoveAcentos.Checked = config.Get("RemoveAcentos", false);
            chkSaveEnvio.Checked = config.Get("SaveEnvio", true);
            chkSaveCFe.Checked = config.Get("SaveCFe", true);
            chkSaveCFeCanc.Checked = config.Get("SaveCFeCanc", true);
            chkSepararCNPJ.Checked = config.Get("SepararCNPJ", true);
            chkSepararData.Checked = config.Get("SepararData", true);
            txtEmitCNPJ.Text = config.Get("EmitCNPJ", "11111111111111");
            txtEmitIE.Text = config.Get("EmitIE", string.Empty);
            txtEmitIM.Text = config.Get("EmitIM", string.Empty);
            cmbEmiRegTrib.SetSelectedValue(config.Get("EmiRegTrib", RegTrib.SimplesNacional));
            cmbEmiRegTribISSQN.SetSelectedValue(config.Get("EmiRegTribISSQN", RegTribIssqn.Nenhum));
            cmbEmiRatIISQN.SetSelectedValue(config.Get("EmiRatIISQN", RatIssqn.Sim));
            txtIdeCNPJ.Text = config.Get("IdeCNPJ", "22222222222222");
            txtSignAC.Text = config.Get("SignAC", "1111111111111222222222222221111111111111122222222222222111111111111112222222222222211111" +
                                                  "111111111222222222222221111111111111122222222222222111111111111112222222222222211111111" +
                                                  "111111222222222222221111111111111122222222222222111111111111112222222222222211111111111" +
                                                  "1112222222222222211111111111111222222222222221111111111111122222222222222111111111");

            txtMFeEnvio.Text = config.Get("MFePathEnvio", @"C:\Integrador\Input\");
            txtMFeResposta.Text = config.Get("MFePathResposta", @"C:\Integrador\Output\");
            nunMFeTimeout.Value = config.Get("MFeTimeOut", 45000M);
            txtChaveAcessoValidador.Text = config.Get("ChaveAcessoValidador", @"25CFE38D-3B92-46C0-91CA-CFF751A82D3D");

            //Extrato
            var img = config.Get("ExtratoLogo", string.Empty);
            if (img.IsEmpty())
            {
                pctLogo.Image?.Dispose();
                pctLogo.Image = null;

                extrato.Logo = null;
            }
            else
            {
                var imgBytes = Convert.FromBase64String(img);
                pctLogo.Image = imgBytes.ToImage();
                extrato.Logo = pctLogo.Image;
            }

            chkPreview.Checked = config.Get("ExtratoPreview", false);
            chkSetup.Checked = config.Get("ExtratoSetup", false);
            cmbFiltro.SetSelectedValue(config.Get("ExtratoFiltro", FiltroDFeReport.Nenhum));
            txtExportacao.Text = config.Get("ExtratoFiltroArquivo", string.Empty);
            nudEspacoFinal.Value = config.Get("ExtratoEspacoFinal", 0M);
            cmbExtrato.SetSelectedValue(config.Get("ExtratoTipo", TipoExtrato.FastReport));

            //EscPos
            cbbProtocolo.SetSelectedValue(config.Get("ProtocoloEscPos", ProtocoloEscPos.EscPos));
            cbbConexao.SetSelectedValue(config.Get("TipoConexao", TipoConexao.Serial));
            cbbEnconding.SetSelectedValue(config.Get("PaginaCodigo", PaginaCodigo.pc850));
            chkControlePortas.Checked = config.Get("ControlePorta", true);
            nudEspacos.Value = config.Get("EspacoEntreLinhas", 0M);
            nudLinhas.Value = config.Get("LinhasEntreCupom", 0M);

            //Serial
            cbbPortas.SetSelectedValue(config.Get("SerialPorta", cbbPortas.GetSelectedValue<string>()));
            cbbVelocidade.SetSelectedValue(config.Get("SerialVelocidade", SerialBaud.Bd9600));
            cbbDataBits.SetSelectedValue(config.Get("SerialDataBits", SerialDataBits.Db8));
            cbbParity.SetSelectedValue(config.Get("SerialParaty", Parity.None));
            cbbStopBits.SetSelectedValue(config.Get("SerialStopBits", StopBits.None));
            cbbHandshake.SetSelectedValue(config.Get("SerialHandhsake", Handshake.None));

            //TCP
            txtIP.Text = config.Get("TCPIP", "");
            nudPorta.Value = config.Get("TCPPorta", 9100M);

            //Raw
            cbbImpressoras.SetSelectedValue(config.Get("RawImpressora", cbbImpressoras.GetSelectedValue<string>()));

            //File
            txtArquivo.Text = config.Get("FileArquivo", "");

            MessageBox.Show(this, @"Configurações Carregada com sucesso !", @"S@T Demo");
        }

        private void SaveConfig(bool msg = true)
        {
            config.Set("ModeloSat", cmbModeloSat.GetSelectedValue<ModeloSat>());
            config.Set("DllPath", txtDllPath.Text);
            config.Set("Ambiente", cmbAmbiente.GetSelectedValue<DFeTipoAmbiente>());
            config.Set("Ativacao", txtAtivacao.Text);
            config.Set("CodUF", txtCodUF.Text);
            config.Set("PaginaCodigo", nunPaginaCodigo.Value);
            config.Set("Caixa", nunCaixa.Value);
            config.Set("VersaoCFe", nunVersaoCFe.Value);
            config.Set("UTF8", chkUTF8.Checked);
            config.Set("RemoveAcentos", chkRemoveAcentos.Checked);
            config.Set("SaveEnvio", chkSaveEnvio.Checked);
            config.Set("SaveCFe", chkSaveCFe.Checked);
            config.Set("SaveCFeCanc", chkSaveCFeCanc.Checked);
            config.Set("SepararCNPJ", chkSepararCNPJ.Checked);
            config.Set("SepararData", chkSepararData.Checked);
            config.Set("EmitCNPJ", txtEmitCNPJ.Text);
            config.Set("EmitIE", txtEmitIE.Text);
            config.Set("EmitIM", txtEmitIM.Text);
            config.Set("EmiRegTrib", cmbEmiRegTrib.GetSelectedValue<RegTrib>());
            config.Set("EmiRegTribISSQN", cmbEmiRegTribISSQN.GetSelectedValue<RegTribIssqn>());
            config.Set("EmiRatIISQN", cmbEmiRatIISQN.GetSelectedValue<RatIssqn>());
            config.Set("IdeCNPJ", txtIdeCNPJ.Text);
            config.Set("SignAC", txtSignAC.Text);
            config.Set("MFePathEnvio", txtMFeEnvio.Text);
            config.Set("MFePathResposta", txtMFeResposta.Text);
            config.Set("MFeTimeOut", nunMFeTimeout.Value);
            config.Set("ChaveAcessoValidador", txtChaveAcessoValidador.Text);

            //Extrato
            config.Set("ExtratoLogo", Helpers.ToBase64(pctLogo.Image));
            config.Set("ExtratoPreview", chkPreview.Checked);
            config.Set("ExtratoSetup", chkSetup.Checked);
            config.Set("ExtratoFiltro", cmbFiltro.GetSelectedValue<FiltroDFeReport>());
            config.Set("ExtratoFiltroArquivo", txtExportacao.Text);
            config.Set("ExtratoEspacoFinal", nudEspacoFinal.Value);
            config.Set("ExtratoTipo", cmbExtrato.GetSelectedValue<TipoExtrato>());

            //EscPos
            config.Set("ProtocoloEscPos", cbbProtocolo.GetSelectedValue<ProtocoloEscPos>());
            config.Set("TipoConexao", cbbConexao.GetSelectedValue<TipoConexao>());
            config.Set("PaginaCodigo", cbbEnconding.GetSelectedValue<PaginaCodigo>());
            config.Set("ControlePorta", chkControlePortas.Checked);
            config.Set("EspacoEntreLinhas", nudEspacos.Value);
            config.Set("LinhasEntreCupom", nudLinhas.Value);

            //Serial
            config.Set("SerialPorta", cbbPortas.GetSelectedValue<string>());
            config.Set("SerialVelocidade", cbbVelocidade.GetSelectedValue<SerialBaud>());
            config.Set("SerialDataBits", cbbDataBits.GetSelectedValue<SerialDataBits>());
            config.Set("SerialParaty", cbbParity.GetSelectedValue<Parity>());
            config.Set("SerialStopBits", cbbStopBits.GetSelectedValue<StopBits>());
            config.Set("SerialHandhsake", cbbHandshake.GetSelectedValue<Handshake>());

            //TCP
            config.Set("TCPIP", txtIP.Text);
            config.Set("TCPPorta", nudPorta.Value);

            //Raw
            config.Set("RawImpressora", cbbImpressoras.GetSelectedValue<string>());

            //File
            config.Set("FileArquivo", txtArquivo.Text);

            config.Save();

            if (msg)
                MessageBox.Show(this, @"Configurações Salva com sucesso !", @"S@T Demo");
        }

        private void ConsultarStatusOperacional()
        {
            var ret = openSat.ConsultarStatusOperacional();
            logger.Info($"NSERIE.........: {ret.Status.NSerie}");
            logger.Info($"LAN_MAC........: {ret.Status.LanMac}");
            logger.Info($"STATUS_LAN.....: {ret.Status.StatusLan}");
            logger.Info($"NIVEL_BATERIA..: {ret.Status.NivelBateria}");
            logger.Info($"MT_TOTAL.......: {ret.Status.MTTotal}");
            logger.Info($"MT_USADA.......: {ret.Status.MTUsada}");
            logger.Info($"DH_ATUAL.......: {ret.Status.DhAtual}");
            logger.Info($"VER_SB.........: {ret.Status.VerSb}");
            logger.Info($"VER_LAYOUT.....: {ret.Status.VerLayout}");
            logger.Info($"ULTIMO_CFe.....: {ret.Status.UltimoCFe}");
            logger.Info($"LISTA_INICIAL..: {ret.Status.ListaInicial}");
            logger.Info($"LISTA_FINAL....: {ret.Status.ListaFinal}");
            logger.Info($"DH_CFe.........: {ret.Status.DhCFe}");
            logger.Info($"DH_ULTIMA......: {ret.Status.DhUltima}");
            logger.Info($"CERT_EMISSAO...: {ret.Status.CertEmissao}");
            logger.Info($"ESTADO_OPERACAO: {ret.Status.EstadoOperacao}");
        }

        private EscPosPrinter GetPosPrinter()
        {
            var tipo = cbbConexao.GetSelectedValue<TipoConexao>();

            EscPosPrinter ret = tipo switch
            {
                TipoConexao.Serial => new EscPosPrinter<SerialConfig>()
                {
                    Device =
                    {
                        Porta = cbbPortas.GetSelectedValue<string>(),
                        Baud = (int)cbbVelocidade.GetSelectedValue<SerialBaud>(),
                        DataBits = (int)cbbDataBits.GetSelectedValue<SerialDataBits>(),
                        Parity = cbbParity.GetSelectedValue<Parity>(),
                        StopBits = cbbStopBits.GetSelectedValue<StopBits>(),
                        Handshake = cbbHandshake.GetSelectedValue<Handshake>(),
                    }
                },
                TipoConexao.TCP => new EscPosPrinter<TCPConfig>()
                {
                    Device =
                    {
                        IP = txtIP.Text,
                        Porta = (int)nudPorta.Value
                    }
                },
                TipoConexao.RAW => new EscPosPrinter<RawConfig>()
                {
                    Device =
                    {
                        Impressora = cbbImpressoras.GetSelectedValue<string>(),
                    }
                },
                TipoConexao.File => new EscPosPrinter<FileConfig>()
                {
                    Device =
                    {
                        CreateIfNotExits = true,
                        File = txtArquivo.Text,
                    }
                },
                _ => throw new ArgumentOutOfRangeException()
            };

            ret.Protocolo = cbbProtocolo.GetSelectedValue<ProtocoloEscPos>();
            ret.PaginaCodigo = cbbEnconding.GetSelectedValue<PaginaCodigo>();
            ret.Device.ControlePorta = chkControlePortas.Checked;
            ret.EspacoEntreLinhas = (byte)nudEspacos.Value;
            ret.LinhasEntreCupons = (byte)nudLinhas.Value;

            return ret;
        }

        #endregion Methods

        #region EventHandlers

        #region Menu

        private void ativarSATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!openSat.Ativo) ToogleInitialize();
            openSat.AtivarSAT(1, txtEmitCNPJ.Text, txtCodUF.Text.ToInt32());
        }

        private void comunicarCertificadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!openSat.Ativo) ToogleInitialize();
            logger.Info("Comunicar certificado.");
            var file = Helpers.OpenFile(@"Certificado|*.cer|Arquivo Texto|*.txt");
            if (file.IsEmpty())
            {
                logger.Info("Comunicar certificado Cancelado.");
                return;
            }

            openSat.ComunicarCertificadoIcpBrasil(File.ReadAllText(file));
        }

        private void associarAssinaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!openSat.Ativo) ToogleInitialize();
            openSat.AssociarAssinatura(txtIdeCNPJ.Text + txtEmitCNPJ.Text, txtSignAC.Text);
        }

        private void bloquearSATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!openSat.Ativo) ToogleInitialize();
            openSat.BloquearSAT();
        }

        private void desbloquearSATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!openSat.Ativo) ToogleInitialize();
            openSat.DesbloquearSAT();
        }

        private void trocarCódigoDeAtivaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!openSat.Ativo) ToogleInitialize();

            var codigo = txtAtivacao.Text;
            if (InputBox.Show("Trocar Código de Ativação", "Entre com o Código de Ativação ou de Emergência:", ref codigo).Equals(DialogResult.Cancel))
                return;

            var tipoCodigo = "1";
            if (InputBox.Show("Trocar Código de Ativação",
                              "Qual o Tipo do Código Informado anteriormente ?" + Environment.NewLine +
                              "1 – Código de Ativação" + Environment.NewLine +
                              "2 – Código de Ativação de Emergência", ref tipoCodigo).Equals(DialogResult.Cancel))
                return;

            var novoCodigo = string.Empty;
            if (InputBox.Show("Trocar Código de Ativação", "Entre com o Número do Novo Código de Ativação:", ref novoCodigo).Equals(DialogResult.Cancel))
                return;

            var ret = openSat.TrocarCodigoDeAtivacao(codigo, tipoCodigo.ToInt32(1), novoCodigo);
            if (ret.CodigoDeRetorno != 1800)
                return;

            txtAtivacao.Text = novoCodigo;
            logger.Info("Codigo de Ativação trocado com sucesso");
            SaveConfig(false);
        }

        private void gerarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerarCFe();
        }

        private void enviarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!openSat.Ativo) ToogleInitialize();
            var ret = openSat.EnviarDadosVenda(cfeAtual);
            if (ret.CodigoDeRetorno != 6000)
                return;

            cfeAtual = ret.Venda;
            wbrXmlRecebido.LoadXml(ret.Venda.GetXml());
            tbcXml.SelectedTab = tpgXmlRecebido;
        }

        private void imprimirExtratoVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cfeAtual.IsNull()) return;
            var tipo = cmbExtrato.GetSelectedValue<TipoExtrato>();
            switch (tipo)
            {
                case TipoExtrato.FastReport:
                    if (extrato.Filtro != FiltroDFeReport.Nenhum && extrato.NomeArquivo.IsEmpty()) return;
                    extrato.ImprimirExtrato(cfeAtual);

                    if (extrato.Filtro == FiltroDFeReport.Nenhum) return;
                    MessageBox.Show(this, @"Extrato impresso com sucesso !", @"S@T Demo");
                    break;

                case TipoExtrato.EscPos:
                    using (var posprinter = GetPosPrinter())
                    {
                        if (pctLogo.Image != null)
                            escpos.Logo = pctLogo.Image.ResizeImage(300, 300);
                        escpos.Printer = posprinter;
                        escpos.ImprimirExtrato(cfeAtual);
                    }
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void imprimirExtratoVendaResumidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cfeAtual.IsNull()) return;
            if (extrato.Filtro != FiltroDFeReport.Nenhum && extrato.NomeArquivo.IsEmpty()) return; ;

            extrato.ImprimirExtratoResumido(cfeAtual);

            if (extrato.Filtro == FiltroDFeReport.Nenhum) return;
            MessageBox.Show(this, @"Extrato impresso com sucesso !", @"S@T Demo");
        }

        private void carregarXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Info("Carregar XML CFe.");
            var file = Helpers.OpenFile(@"CFe Xml | *.xml");
            if (file.IsEmpty())
            {
                logger.Info("Carregar XML CFe Cancelado.");
                return;
            }

            cfeAtual = CFe.Load(file);
            wbrXmlGerado.LoadXml(cfeAtual.GetXml());
            tbcXml.SelectedTab = tpgXmlGerado;
            logger.Info("XML CFe carregado com sucesso.");
        }

        private void gerarXMLCancelamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Info("Gerando XML de Cancelamento !");

            if (cfeAtual == null)
            {
                logger.Warn("Nenhum Xml de Venda carregado !");
                return;
            }

            cfeCancAtual = new CFeCanc(cfeAtual);
            wbrXmlCancelamento.LoadXml(cfeCancAtual.GetXml());
            tbcXml.SelectedTab = tpgXmlCancelamento;
            logger.Info("CFe de Cancelamento gerado com sucesso !");
        }

        private void enviarCancelamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!openSat.Ativo) ToogleInitialize();
            var ret = cfeCancAtual != null ? openSat.CancelarUltimaVenda(cfeCancAtual) : openSat.CancelarUltimaVenda(cfeAtual);
            if (ret.CodigoDeRetorno != 7000)
                return;

            cfeCancAtual = ret.Cancelamento;
            wbrXmlRecebido.LoadXml(ret.Cancelamento.GetXml());
            tbcXml.SelectedTab = tpgXmlRecebido;
        }

        private void imprimirExtratoCancelamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cfeAtual.IsNull() || cfeCancAtual.IsNull()) return;
            extrato.ImprimirExtratoCancelamento(cfeAtual, cfeCancAtual);
        }

        private void consultarStatusOperacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!openSat.Ativo) ToogleInitialize();
            ConsultarStatusOperacional();
        }

        private void consultarSATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!openSat.Ativo) ToogleInitialize();
            openSat.ConsultarSAT();
        }

        private void consultarNumeroDeSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!openSat.Ativo) ToogleInitialize();

            var sessao = string.Empty;
            if (InputBox.Show("Consultar Sessão", "Digite o número da sessão", ref sessao).Equals(DialogResult.Cancel))
                return;

            if (!sessao.IsNumeric())
                return;

            var ret = openSat.ConsultarNumeroSessao(sessao.ToInt32());

            switch (ret.CodigoDeRetorno)
            {
                case 6000:
                    wbrXmlRecebido.LoadXml(ret.Venda.GetXml());
                    break;

                case 7000:
                    wbrXmlRecebido.LoadXml(ret.Cancelamento.GetXml());
                    break;

                default:
                    return;
            }

            tbcXml.SelectedTab = tpgXmlRecebido;
        }

        private void atualizarSATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!openSat.Ativo) ToogleInitialize();
            openSat.AtualizarSoftwareSAT();
        }

        private void lerXMLConfiguraçãoDeInterfaceDeRedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Info("Carregar XML Rede.");
            var file = Helpers.OpenFile(@"Xml Rede | *.xml");
            if (file.IsEmpty())
            {
                logger.Info("Carregar XML Rede Cancelado.");
                return;
            }

            redeAtual = SatRede.Load(file);
            wbrXmlRede.LoadXml(redeAtual.GetXml());
            tbcXml.SelectedTab = tpgRede;
            logger.Info("XML Rede carregado com sucesso.");
        }

        private void gravarXmlDeInterfaceDeRedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void configurarInterfaceDeRedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void testeFimAFimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!openSat.Ativo) ToogleInitialize();

            if (cfeAtual == null)
                GerarCFe();

            var ret = openSat.TesteFimAFim(cfeAtual);
            if (ret.CodigoDeRetorno != 9000)
                return;

            wbrXmlRecebido.LoadXml(ret.VendaTeste.GetXml());
            tbcXml.SelectedTab = tpgXmlRecebido;
        }

        private void extrairLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!openSat.Ativo) ToogleInitialize();
            var resposta = openSat.ExtrairLogs();
            var pathLog = Path.Combine(Application.StartupPath, "logSat.txt");
            File.WriteAllText(pathLog, resposta.Log);
            Process.Start(pathLog);
        }

        #endregion Menu

        #region ValueChanged

        private void cmbModeloSat_SelectedIndexChanged(object sender, EventArgs e)
        {
            openSat.Modelo = cmbModeloSat.GetSelectedValue<ModeloSat>();
        }

        private void txtDllPath_TextChanged(object sender, EventArgs e)
        {
            if (!File.Exists(txtDllPath.Text))
                return;

            openSat.PathDll = txtDllPath.Text;
        }

        private void txtAtivacao_TextChanged(object sender, EventArgs e)
        {
            if (txtAtivacao.Text.IsEmpty()) return;

            openSat.CodigoAtivacao = txtAtivacao.Text;
        }

        private void cmbAmbiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            openSat.Configuracoes.IdeTpAmb = cmbAmbiente.GetSelectedValue<DFeTipoAmbiente>();
        }

        private void nunCaixa_ValueChanged(object sender, EventArgs e)
        {
            openSat.Configuracoes.IdeNumeroCaixa = (int)nunCaixa.Value;
        }

        private void nunPaginaCodigo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var encoder = Encoding.GetEncoding((int)nunPaginaCodigo.Value);
                openSat.Encoding = encoder;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                nunPaginaCodigo.ValueChanged -= nunPaginaCodigo_ValueChanged;

                nunPaginaCodigo.Value = 65001M;
                openSat.Encoding = Encoding.UTF8;

                nunPaginaCodigo.ValueChanged += nunPaginaCodigo_ValueChanged;
            }
        }

        private void chkUTF8_CheckedChanged(object sender, EventArgs e)
        {
            nunPaginaCodigo.Value = chkUTF8.Checked ? 65001M : 0;
        }

        private void chkRemoveAcentos_CheckedChanged(object sender, EventArgs e)
        {
            openSat.Configuracoes.RemoverAcentos = chkRemoveAcentos.Checked;
        }

        private void nunVersaoCFe_ValueChanged(object sender, EventArgs e)
        {
            openSat.Configuracoes.InfCFeVersaoDadosEnt = nunVersaoCFe.Value;
        }

        private void chkSaveCFe_CheckedChanged(object sender, EventArgs e)
        {
            openSat.Arquivos.SalvarCFe = chkSaveCFe.Checked;
        }

        private void chkSaveEnvio_CheckedChanged(object sender, EventArgs e)
        {
            openSat.Arquivos.SalvarEnvio = chkSaveEnvio.Checked;
        }

        private void chkSaveCFeCanc_CheckedChanged(object sender, EventArgs e)
        {
            openSat.Arquivos.SalvarCFeCanc = chkSaveCFeCanc.Checked;
        }

        private void chkSepararCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            openSat.Arquivos.SepararPorCNPJ = chkSepararCNPJ.Checked;
        }

        private void chkSepararData_CheckedChanged(object sender, EventArgs e)
        {
            openSat.Arquivos.SepararPorMes = chkSepararData.Checked;
        }

        private void txtEmitCNPJ_TextChanged(object sender, EventArgs e)
        {
            openSat.Configuracoes.EmitCNPJ = txtEmitCNPJ.Text.OnlyNumbers();
        }

        private void txtEmitIE_TextChanged(object sender, EventArgs e)
        {
            openSat.Configuracoes.EmitIE = txtEmitIE.Text.OnlyNumbers();
        }

        private void txtEmitIM_TextChanged(object sender, EventArgs e)
        {
            openSat.Configuracoes.EmitIM = txtEmitIM.Text.OnlyNumbers();
        }

        private void cmbEmiRegTrib_SelectedIndexChanged(object sender, EventArgs e)
        {
            openSat.Configuracoes.EmitCRegTrib = cmbEmiRegTrib.GetSelectedValue<RegTrib>();
        }

        private void cmbEmiRegTribISSQN_SelectedIndexChanged(object sender, EventArgs e)
        {
            openSat.Configuracoes.EmitCRegTribISSQN = cmbEmiRegTribISSQN.GetSelectedValue<RegTribIssqn>();
        }

        private void cmbEmiRatIISQN_SelectedIndexChanged(object sender, EventArgs e)
        {
            openSat.Configuracoes.EmitIndRatISSQN = cmbEmiRatIISQN.GetSelectedValue<RatIssqn>();
        }

        private void txtIdeCNPJ_TextChanged(object sender, EventArgs e)
        {
            openSat.Configuracoes.IdeCNPJ = txtIdeCNPJ.Text.OnlyNumbers();
        }

        private void txtSignAC_TextChanged(object sender, EventArgs e)
        {
            openSat.SignAC = txtSignAC.Text;
        }

        private void txtMFeEnvio_TextChanged(object sender, EventArgs e)
        {
            openIntegrador.Configuracoes.PastaInput = txtMFeEnvio.Text;
        }

        private void txtMFeResposta_TextChanged(object sender, EventArgs e)
        {
            openIntegrador.Configuracoes.PastaOutput = txtMFeResposta.Text;
        }

        private void nunMFeTimeout_ValueChanged(object sender, EventArgs e)
        {
            openIntegrador.Configuracoes.TimeOut = (int)nunMFeTimeout.Value;
        }

        private void txtChaveAcessoValidador_TextChanged(object sender, EventArgs e)
        {
            openIntegrador.Configuracoes.ChaveAcessoValidador = txtChaveAcessoValidador.Text;
        }

        private void chkPreview_CheckedChanged(object sender, EventArgs e)
        {
            extrato.MostrarPreview = chkPreview.Checked;
        }

        private void chkSetup_CheckedChanged(object sender, EventArgs e)
        {
            extrato.MostrarSetup = chkSetup.Checked;
        }

        private void nudEspacoFinal_ValueChanged(object sender, EventArgs e)
        {
            extrato.EspacoFinal = nudEspacoFinal.Value;
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            extrato.Filtro = cmbFiltro.GetSelectedValue<FiltroDFeReport>();

            txtExportacao.Enabled = extrato.Filtro != FiltroDFeReport.Nenhum;
            btnExportacao.Enabled = extrato.Filtro != FiltroDFeReport.Nenhum;
        }

        private void txtExportacao_TextChanged(object sender, EventArgs e)
        {
            extrato.NomeArquivo = txtExportacao.Text;
        }

        private void cbbConexao_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipo = cbbConexao.GetSelectedValue<TipoConexao>();
            tbcDeviceConfig.SelectedTab = tipo switch
            {
                TipoConexao.Serial => tbpSerial,
                TipoConexao.TCP => tbpTCP,
                TipoConexao.RAW => tbpRAW,
                TipoConexao.File => tbpFile,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        #endregion ValueChanged

        #region Botoes

        private void btnIniDesini_Click(object sender, EventArgs e)
        {
            ToogleInitialize();
        }

        private void btnParamLoad_Click(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void btnParamSave_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void btnSelDll_Click(object sender, EventArgs e)
        {
            var file = Helpers.OpenFile(@"Sat Library | *.dll");
            if (!file.IsEmpty())
                txtDllPath.Text = file;
        }

        private void btnEnviarPagamento_Click(object sender, EventArgs e)
        {
            var chaveRequisicao = Guid.NewGuid().ToString();
            var resposta = openIntegrador.EnviarPagamento(
                chaveRequisicao: chaveRequisicao,
                estabelecimento: "10",
                serialPOS: new Random().Next(10000000, 99999999).ToString(),
                cnpj: txtEmitCNPJ.Text,
                icmsBase: 0.23m,
                valorTotalVenda: 1530,
                origemPagamento: "Mesa 1234",
                habilitarMultiplosPagamentos: true,
                habilitarControleAntiFraude: false,
                codigoMoeda: "BRL",
                emitirCupomNFCE: false
            );

            wbrXmlRecebido.LoadXml(resposta.GetXml());
        }

        private void btnEnviarStatusPagamento_Click(object sender, EventArgs e)
        {
            var idfila = "00000000";
            InputBox.Show("ID da fila", "Informe o if da fila", ref idfila);
            var resposta = openIntegrador.EnviarStatusPagamento(
                codigoAutorizacao: "20551",
                bin: "123456",
                donoCartao: "Teste",
                dataExpiracao: "01/18",
                instituicaoFinanceira: "STONE",
                parcelas: 1,
                codigoPagamento: "12846",
                valorPagamento: 1530,
                idFila: int.Parse(idfila),
                tipo: "1",
                ultimosQuatroDigitos: 1234
             );

            wbrXmlRecebido.LoadXml(resposta.GetXml());
        }

        private void btnVerificarStatusValidador_Click(object sender, EventArgs e)
        {
            var idfila = "00000000";
            InputBox.Show("ID da fila", "Informe o if da fila", ref idfila);
            var resposta = openIntegrador.VerificarStatusValidador(
                idFila: int.Parse(idfila),
                cnpj: txtEmitCNPJ.Text
            );

            wbrXmlRecebido.LoadXml(resposta.GetXml());
        }

        private void btnRespostaFiscal_Click(object sender, EventArgs e)
        {
            var idfila = "00000000";
            InputBox.Show("ID da fila", "Id da fila", ref idfila);

            var chaveAcesso = "35170408723218000186599000113100000279731880";
            InputBox.Show("Chave de acesso", "Chave de acesso do CFe", ref chaveAcesso);

            var resposta = openIntegrador.RespostaFiscal(
                idFila: int.Parse(idfila),
                chaveAcesso: chaveAcesso,
                nsu: idfila.ToString(),
                numeroAprovacao: "1234",
                bandeira: "VISA",
                adquirinte: "STONE",
                impressaofiscal: "",
                numeroDocumento: idfila.ToString(),
                cnpj: txtEmitCNPJ.Text
            );

            wbrXmlRecebido.LoadXml(resposta.GetXml());
        }

        private void carregarImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var file = Helpers.OpenFile(@"Images(*.BMP; *.JPG; *.GIF,*.PNG,*.TIFF)| *.BMP; *.JPG; *.GIF; *.PNG; *.TIFF");
            if (file.IsEmpty()) return;

            var img = Image.FromFile(file);
            pctLogo.Image = img;
            extrato.Logo = img;
        }

        private void limparLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pctLogo.Image?.Dispose();
            pctLogo.Image = null;
            extrato.Logo = null;
        }

        private void btnExportacao_Click(object sender, EventArgs e)
        {
            var extensao = extrato.Filtro == FiltroDFeReport.HTML ? ".html" : ".pdf";
            var file = Helpers.SaveFile($"ExtratoSat", $"Extrato Sat (*{extensao}) | *{extensao}");
            txtExportacao.Text = file;
        }

        #endregion Botoes

        #endregion EventHandlers
    }
}