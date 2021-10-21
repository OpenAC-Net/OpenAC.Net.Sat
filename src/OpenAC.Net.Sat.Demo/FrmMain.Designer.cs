namespace OpenAC.Net.Sat.Demo
{
	partial class FrmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tpgLog = new System.Windows.Forms.TabPage();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tbcXml = new System.Windows.Forms.TabControl();
            this.tpgXmlGerado = new System.Windows.Forms.TabPage();
            this.wbrXmlGerado = new System.Windows.Forms.WebBrowser();
            this.tpgXmlRecebido = new System.Windows.Forms.TabPage();
            this.wbrXmlRecebido = new System.Windows.Forms.WebBrowser();
            this.tpgXmlCancelamento = new System.Windows.Forms.TabPage();
            this.wbrXmlCancelamento = new System.Windows.Forms.WebBrowser();
            this.tpgXmlRede = new System.Windows.Forms.TabPage();
            this.wbrXmlRede = new System.Windows.Forms.WebBrowser();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ativaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ativarSATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comunicarCertificadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associarAssinaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bloquearSATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desbloquearSATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trocarCódigoDeAtivaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirExtratoVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirExtratoVendaResumidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.carregarXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarXMLCancelamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarCancelamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirExtratoCancelamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarStatusOperacionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarSATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarNumeroDeSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarSATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lerXMLConfiguraçãoDeInterfaceDeRedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravarXmlDeInterfaceDeRedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.configurarInterfaceDeRedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diversosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeFimAFimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrairLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcDados = new System.Windows.Forms.TabControl();
            this.tpgConfig = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSepararData = new System.Windows.Forms.CheckBox();
            this.chkSepararCNPJ = new System.Windows.Forms.CheckBox();
            this.chkSaveCFeCanc = new System.Windows.Forms.CheckBox();
            this.chkSaveEnvio = new System.Windows.Forms.CheckBox();
            this.chkSaveCFe = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkRemoveAcentos = new System.Windows.Forms.CheckBox();
            this.nunVersaoCFe = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUTF8 = new System.Windows.Forms.CheckBox();
            this.nunPaginaCodigo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nunCaixa = new System.Windows.Forms.NumericUpDown();
            this.txtCodUF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAtivacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAmbiente = new System.Windows.Forms.ComboBox();
            this.txtDllPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelDll = new System.Windows.Forms.Button();
            this.tpgEmitente = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbEmiRatIISQN = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbEmiRegTribISSQN = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEmiRegTrib = new System.Windows.Forms.ComboBox();
            this.txtEmitIM = new System.Windows.Forms.TextBox();
            this.txtEmitIE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmitCNPJ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tpgSwHouse = new System.Windows.Forms.TabPage();
            this.txtSignAC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIdeCNPJ = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tpgRede = new System.Windows.Forms.TabPage();
            this.tpgImpressao = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.nudEspacoFinal = new System.Windows.Forms.NumericUpDown();
            this.groupBoxExportacao = new System.Windows.Forms.GroupBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtExportacao = new System.Windows.Forms.TextBox();
            this.btnExportacao = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.chkSetup = new System.Windows.Forms.CheckBox();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.contextMenuStripImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.carregarImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparLogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpgMFe = new System.Windows.Forms.TabPage();
            this.txtChaveAcessoValidador = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnRespostaFiscal = new System.Windows.Forms.Button();
            this.btnVerificarStatusValidador = new System.Windows.Forms.Button();
            this.btnEnviarStatusPagamento = new System.Windows.Forms.Button();
            this.btnEnviarPagamento = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.nunMFeTimeout = new System.Windows.Forms.NumericUpDown();
            this.txtMFeResposta = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMFeEnvio = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbModeloSat = new System.Windows.Forms.ComboBox();
            this.btnIniDesini = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnParamSave = new System.Windows.Forms.Button();
            this.btnParamLoad = new System.Windows.Forms.Button();
            this.tpgLog.SuspendLayout();
            this.tbcXml.SuspendLayout();
            this.tpgXmlGerado.SuspendLayout();
            this.tpgXmlRecebido.SuspendLayout();
            this.tpgXmlCancelamento.SuspendLayout();
            this.tpgXmlRede.SuspendLayout();
            this.stsStatus.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tbcDados.SuspendLayout();
            this.tpgConfig.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nunVersaoCFe)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nunPaginaCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nunCaixa)).BeginInit();
            this.tpgEmitente.SuspendLayout();
            this.tpgSwHouse.SuspendLayout();
            this.tpgImpressao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEspacoFinal)).BeginInit();
            this.groupBoxExportacao.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.contextMenuStripImage.SuspendLayout();
            this.tpgMFe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nunMFeTimeout)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpgLog
            // 
            this.tpgLog.Controls.Add(this.rtbLog);
            this.tpgLog.Location = new System.Drawing.Point(4, 29);
            this.tpgLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgLog.Name = "tpgLog";
            this.tpgLog.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgLog.Size = new System.Drawing.Size(1081, 330);
            this.tpgLog.TabIndex = 0;
            this.tpgLog.Text = "Log de Comando";
            this.tpgLog.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.White;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Location = new System.Drawing.Point(4, 5);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(1073, 320);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // tbcXml
            // 
            this.tbcXml.Controls.Add(this.tpgLog);
            this.tbcXml.Controls.Add(this.tpgXmlGerado);
            this.tbcXml.Controls.Add(this.tpgXmlRecebido);
            this.tbcXml.Controls.Add(this.tpgXmlCancelamento);
            this.tbcXml.Controls.Add(this.tpgXmlRede);
            this.tbcXml.Location = new System.Drawing.Point(0, 331);
            this.tbcXml.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcXml.Name = "tbcXml";
            this.tbcXml.SelectedIndex = 0;
            this.tbcXml.Size = new System.Drawing.Size(1089, 363);
            this.tbcXml.TabIndex = 0;
            // 
            // tpgXmlGerado
            // 
            this.tpgXmlGerado.Controls.Add(this.wbrXmlGerado);
            this.tpgXmlGerado.Location = new System.Drawing.Point(4, 29);
            this.tpgXmlGerado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgXmlGerado.Name = "tpgXmlGerado";
            this.tpgXmlGerado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgXmlGerado.Size = new System.Drawing.Size(1081, 330);
            this.tpgXmlGerado.TabIndex = 1;
            this.tpgXmlGerado.Text = "Xml Gerado";
            this.tpgXmlGerado.UseVisualStyleBackColor = true;
            // 
            // wbrXmlGerado
            // 
            this.wbrXmlGerado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbrXmlGerado.Location = new System.Drawing.Point(4, 5);
            this.wbrXmlGerado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wbrXmlGerado.MinimumSize = new System.Drawing.Size(30, 31);
            this.wbrXmlGerado.Name = "wbrXmlGerado";
            this.wbrXmlGerado.Size = new System.Drawing.Size(1073, 320);
            this.wbrXmlGerado.TabIndex = 0;
            // 
            // tpgXmlRecebido
            // 
            this.tpgXmlRecebido.Controls.Add(this.wbrXmlRecebido);
            this.tpgXmlRecebido.Location = new System.Drawing.Point(4, 29);
            this.tpgXmlRecebido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgXmlRecebido.Name = "tpgXmlRecebido";
            this.tpgXmlRecebido.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgXmlRecebido.Size = new System.Drawing.Size(1081, 330);
            this.tpgXmlRecebido.TabIndex = 2;
            this.tpgXmlRecebido.Text = "Xml Recebido";
            this.tpgXmlRecebido.UseVisualStyleBackColor = true;
            // 
            // wbrXmlRecebido
            // 
            this.wbrXmlRecebido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbrXmlRecebido.Location = new System.Drawing.Point(4, 5);
            this.wbrXmlRecebido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wbrXmlRecebido.MinimumSize = new System.Drawing.Size(30, 31);
            this.wbrXmlRecebido.Name = "wbrXmlRecebido";
            this.wbrXmlRecebido.Size = new System.Drawing.Size(1073, 320);
            this.wbrXmlRecebido.TabIndex = 0;
            // 
            // tpgXmlCancelamento
            // 
            this.tpgXmlCancelamento.Controls.Add(this.wbrXmlCancelamento);
            this.tpgXmlCancelamento.Location = new System.Drawing.Point(4, 29);
            this.tpgXmlCancelamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgXmlCancelamento.Name = "tpgXmlCancelamento";
            this.tpgXmlCancelamento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgXmlCancelamento.Size = new System.Drawing.Size(1081, 330);
            this.tpgXmlCancelamento.TabIndex = 3;
            this.tpgXmlCancelamento.Text = "Xml Cancelamento";
            this.tpgXmlCancelamento.UseVisualStyleBackColor = true;
            // 
            // wbrXmlCancelamento
            // 
            this.wbrXmlCancelamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbrXmlCancelamento.Location = new System.Drawing.Point(4, 5);
            this.wbrXmlCancelamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wbrXmlCancelamento.MinimumSize = new System.Drawing.Size(30, 31);
            this.wbrXmlCancelamento.Name = "wbrXmlCancelamento";
            this.wbrXmlCancelamento.Size = new System.Drawing.Size(1073, 320);
            this.wbrXmlCancelamento.TabIndex = 0;
            // 
            // tpgXmlRede
            // 
            this.tpgXmlRede.Controls.Add(this.wbrXmlRede);
            this.tpgXmlRede.Location = new System.Drawing.Point(4, 29);
            this.tpgXmlRede.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgXmlRede.Name = "tpgXmlRede";
            this.tpgXmlRede.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgXmlRede.Size = new System.Drawing.Size(1081, 330);
            this.tpgXmlRede.TabIndex = 4;
            this.tpgXmlRede.Text = "Xml Rede";
            this.tpgXmlRede.UseVisualStyleBackColor = true;
            // 
            // wbrXmlRede
            // 
            this.wbrXmlRede.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbrXmlRede.Location = new System.Drawing.Point(4, 5);
            this.wbrXmlRede.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wbrXmlRede.MinimumSize = new System.Drawing.Size(30, 31);
            this.wbrXmlRede.Name = "wbrXmlRede";
            this.wbrXmlRede.Size = new System.Drawing.Size(1073, 320);
            this.wbrXmlRede.TabIndex = 0;
            // 
            // stsStatus
            // 
            this.stsStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.stsStatus.Location = new System.Drawing.Point(0, 710);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.stsStatus.Size = new System.Drawing.Size(1083, 22);
            this.stsStatus.TabIndex = 1;
            this.stsStatus.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1060, 15);
            this.lblStatus.Spring = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ativaçãoToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.cancelamentoToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.configuraçãoToolStripMenuItem,
            this.diversosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 35);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ativaçãoToolStripMenuItem
            // 
            this.ativaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ativarSATToolStripMenuItem,
            this.comunicarCertificadoToolStripMenuItem,
            this.associarAssinaturaToolStripMenuItem,
            this.toolStripSeparator1,
            this.bloquearSATToolStripMenuItem,
            this.desbloquearSATToolStripMenuItem,
            this.toolStripSeparator2,
            this.trocarCódigoDeAtivaçãoToolStripMenuItem});
            this.ativaçãoToolStripMenuItem.Name = "ativaçãoToolStripMenuItem";
            this.ativaçãoToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.ativaçãoToolStripMenuItem.Text = "Ativação";
            // 
            // ativarSATToolStripMenuItem
            // 
            this.ativarSATToolStripMenuItem.Name = "ativarSATToolStripMenuItem";
            this.ativarSATToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.ativarSATToolStripMenuItem.Text = "Ativar SAT";
            this.ativarSATToolStripMenuItem.Click += new System.EventHandler(this.ativarSATToolStripMenuItem_Click);
            // 
            // comunicarCertificadoToolStripMenuItem
            // 
            this.comunicarCertificadoToolStripMenuItem.Name = "comunicarCertificadoToolStripMenuItem";
            this.comunicarCertificadoToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.comunicarCertificadoToolStripMenuItem.Text = "Comunicar Certificado";
            this.comunicarCertificadoToolStripMenuItem.Click += new System.EventHandler(this.comunicarCertificadoToolStripMenuItem_Click);
            // 
            // associarAssinaturaToolStripMenuItem
            // 
            this.associarAssinaturaToolStripMenuItem.Name = "associarAssinaturaToolStripMenuItem";
            this.associarAssinaturaToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.associarAssinaturaToolStripMenuItem.Text = "Associar Assinatura";
            this.associarAssinaturaToolStripMenuItem.Click += new System.EventHandler(this.associarAssinaturaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(320, 6);
            // 
            // bloquearSATToolStripMenuItem
            // 
            this.bloquearSATToolStripMenuItem.Name = "bloquearSATToolStripMenuItem";
            this.bloquearSATToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.bloquearSATToolStripMenuItem.Text = "Bloquear SAT";
            this.bloquearSATToolStripMenuItem.Click += new System.EventHandler(this.bloquearSATToolStripMenuItem_Click);
            // 
            // desbloquearSATToolStripMenuItem
            // 
            this.desbloquearSATToolStripMenuItem.Name = "desbloquearSATToolStripMenuItem";
            this.desbloquearSATToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.desbloquearSATToolStripMenuItem.Text = "Desbloquear SAT";
            this.desbloquearSATToolStripMenuItem.Click += new System.EventHandler(this.desbloquearSATToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(320, 6);
            // 
            // trocarCódigoDeAtivaçãoToolStripMenuItem
            // 
            this.trocarCódigoDeAtivaçãoToolStripMenuItem.Name = "trocarCódigoDeAtivaçãoToolStripMenuItem";
            this.trocarCódigoDeAtivaçãoToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.trocarCódigoDeAtivaçãoToolStripMenuItem.Text = "Trocar Código de Ativação";
            this.trocarCódigoDeAtivaçãoToolStripMenuItem.Click += new System.EventHandler(this.trocarCódigoDeAtivaçãoToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarVendaToolStripMenuItem,
            this.enviarVendaToolStripMenuItem,
            this.imprimirExtratoVendaToolStripMenuItem,
            this.imprimirExtratoVendaResumidoToolStripMenuItem,
            this.toolStripSeparator3,
            this.carregarXMLToolStripMenuItem});
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // gerarVendaToolStripMenuItem
            // 
            this.gerarVendaToolStripMenuItem.Name = "gerarVendaToolStripMenuItem";
            this.gerarVendaToolStripMenuItem.Size = new System.Drawing.Size(380, 34);
            this.gerarVendaToolStripMenuItem.Text = "Gerar Venda";
            this.gerarVendaToolStripMenuItem.Click += new System.EventHandler(this.gerarVendaToolStripMenuItem_Click);
            // 
            // enviarVendaToolStripMenuItem
            // 
            this.enviarVendaToolStripMenuItem.Name = "enviarVendaToolStripMenuItem";
            this.enviarVendaToolStripMenuItem.Size = new System.Drawing.Size(380, 34);
            this.enviarVendaToolStripMenuItem.Text = "Enviar Venda";
            this.enviarVendaToolStripMenuItem.Click += new System.EventHandler(this.enviarVendaToolStripMenuItem_Click);
            // 
            // imprimirExtratoVendaToolStripMenuItem
            // 
            this.imprimirExtratoVendaToolStripMenuItem.Name = "imprimirExtratoVendaToolStripMenuItem";
            this.imprimirExtratoVendaToolStripMenuItem.Size = new System.Drawing.Size(380, 34);
            this.imprimirExtratoVendaToolStripMenuItem.Text = "Imprimir Extrato Venda";
            this.imprimirExtratoVendaToolStripMenuItem.Click += new System.EventHandler(this.imprimirExtratoVendaToolStripMenuItem_Click);
            // 
            // imprimirExtratoVendaResumidoToolStripMenuItem
            // 
            this.imprimirExtratoVendaResumidoToolStripMenuItem.Name = "imprimirExtratoVendaResumidoToolStripMenuItem";
            this.imprimirExtratoVendaResumidoToolStripMenuItem.Size = new System.Drawing.Size(380, 34);
            this.imprimirExtratoVendaResumidoToolStripMenuItem.Text = "Imprimir Extrato Venda Resumido";
            this.imprimirExtratoVendaResumidoToolStripMenuItem.Click += new System.EventHandler(this.imprimirExtratoVendaResumidoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(377, 6);
            // 
            // carregarXMLToolStripMenuItem
            // 
            this.carregarXMLToolStripMenuItem.Name = "carregarXMLToolStripMenuItem";
            this.carregarXMLToolStripMenuItem.Size = new System.Drawing.Size(380, 34);
            this.carregarXMLToolStripMenuItem.Text = "Carregar XML";
            this.carregarXMLToolStripMenuItem.Click += new System.EventHandler(this.carregarXMLToolStripMenuItem_Click);
            // 
            // cancelamentoToolStripMenuItem
            // 
            this.cancelamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarXMLCancelamentoToolStripMenuItem,
            this.enviarCancelamentoToolStripMenuItem,
            this.imprimirExtratoCancelamentoToolStripMenuItem});
            this.cancelamentoToolStripMenuItem.Name = "cancelamentoToolStripMenuItem";
            this.cancelamentoToolStripMenuItem.Size = new System.Drawing.Size(140, 29);
            this.cancelamentoToolStripMenuItem.Text = "Cancelamento";
            // 
            // gerarXMLCancelamentoToolStripMenuItem
            // 
            this.gerarXMLCancelamentoToolStripMenuItem.Name = "gerarXMLCancelamentoToolStripMenuItem";
            this.gerarXMLCancelamentoToolStripMenuItem.Size = new System.Drawing.Size(359, 34);
            this.gerarXMLCancelamentoToolStripMenuItem.Text = "Gerar XML Cancelamento";
            this.gerarXMLCancelamentoToolStripMenuItem.Click += new System.EventHandler(this.gerarXMLCancelamentoToolStripMenuItem_Click);
            // 
            // enviarCancelamentoToolStripMenuItem
            // 
            this.enviarCancelamentoToolStripMenuItem.Name = "enviarCancelamentoToolStripMenuItem";
            this.enviarCancelamentoToolStripMenuItem.Size = new System.Drawing.Size(359, 34);
            this.enviarCancelamentoToolStripMenuItem.Text = "Enviar Cancelamento";
            this.enviarCancelamentoToolStripMenuItem.Click += new System.EventHandler(this.enviarCancelamentoToolStripMenuItem_Click);
            // 
            // imprimirExtratoCancelamentoToolStripMenuItem
            // 
            this.imprimirExtratoCancelamentoToolStripMenuItem.Name = "imprimirExtratoCancelamentoToolStripMenuItem";
            this.imprimirExtratoCancelamentoToolStripMenuItem.Size = new System.Drawing.Size(359, 34);
            this.imprimirExtratoCancelamentoToolStripMenuItem.Text = "Imprimir Extrato Cancelamento";
            this.imprimirExtratoCancelamentoToolStripMenuItem.Click += new System.EventHandler(this.imprimirExtratoCancelamentoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarStatusOperacionalToolStripMenuItem,
            this.consultarSATToolStripMenuItem,
            this.consultarNumeroDeSessãoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarStatusOperacionalToolStripMenuItem
            // 
            this.consultarStatusOperacionalToolStripMenuItem.Name = "consultarStatusOperacionalToolStripMenuItem";
            this.consultarStatusOperacionalToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
            this.consultarStatusOperacionalToolStripMenuItem.Text = "Consultar Status Operacional";
            this.consultarStatusOperacionalToolStripMenuItem.Click += new System.EventHandler(this.consultarStatusOperacionalToolStripMenuItem_Click);
            // 
            // consultarSATToolStripMenuItem
            // 
            this.consultarSATToolStripMenuItem.Name = "consultarSATToolStripMenuItem";
            this.consultarSATToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
            this.consultarSATToolStripMenuItem.Text = "Consultar SAT";
            this.consultarSATToolStripMenuItem.Click += new System.EventHandler(this.consultarSATToolStripMenuItem_Click);
            // 
            // consultarNumeroDeSessãoToolStripMenuItem
            // 
            this.consultarNumeroDeSessãoToolStripMenuItem.Name = "consultarNumeroDeSessãoToolStripMenuItem";
            this.consultarNumeroDeSessãoToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
            this.consultarNumeroDeSessãoToolStripMenuItem.Text = "Consultar Numero de Sessão";
            this.consultarNumeroDeSessãoToolStripMenuItem.Click += new System.EventHandler(this.consultarNumeroDeSessãoToolStripMenuItem_Click);
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarSATToolStripMenuItem,
            this.toolStripSeparator5,
            this.lerXMLConfiguraçãoDeInterfaceDeRedeToolStripMenuItem,
            this.gravarXmlDeInterfaceDeRedeToolStripMenuItem,
            this.toolStripSeparator4,
            this.configurarInterfaceDeRedeToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // atualizarSATToolStripMenuItem
            // 
            this.atualizarSATToolStripMenuItem.Name = "atualizarSATToolStripMenuItem";
            this.atualizarSATToolStripMenuItem.Size = new System.Drawing.Size(368, 34);
            this.atualizarSATToolStripMenuItem.Text = "Atualizar SAT";
            this.atualizarSATToolStripMenuItem.Click += new System.EventHandler(this.atualizarSATToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(365, 6);
            // 
            // lerXMLConfiguraçãoDeInterfaceDeRedeToolStripMenuItem
            // 
            this.lerXMLConfiguraçãoDeInterfaceDeRedeToolStripMenuItem.Name = "lerXMLConfiguraçãoDeInterfaceDeRedeToolStripMenuItem";
            this.lerXMLConfiguraçãoDeInterfaceDeRedeToolStripMenuItem.Size = new System.Drawing.Size(368, 34);
            this.lerXMLConfiguraçãoDeInterfaceDeRedeToolStripMenuItem.Text = "Ler Xml de Interface de Rede";
            this.lerXMLConfiguraçãoDeInterfaceDeRedeToolStripMenuItem.Click += new System.EventHandler(this.lerXMLConfiguraçãoDeInterfaceDeRedeToolStripMenuItem_Click);
            // 
            // gravarXmlDeInterfaceDeRedeToolStripMenuItem
            // 
            this.gravarXmlDeInterfaceDeRedeToolStripMenuItem.Name = "gravarXmlDeInterfaceDeRedeToolStripMenuItem";
            this.gravarXmlDeInterfaceDeRedeToolStripMenuItem.Size = new System.Drawing.Size(368, 34);
            this.gravarXmlDeInterfaceDeRedeToolStripMenuItem.Text = "Gravar Xml de Interface de Rede";
            this.gravarXmlDeInterfaceDeRedeToolStripMenuItem.Click += new System.EventHandler(this.gravarXmlDeInterfaceDeRedeToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(365, 6);
            // 
            // configurarInterfaceDeRedeToolStripMenuItem
            // 
            this.configurarInterfaceDeRedeToolStripMenuItem.Name = "configurarInterfaceDeRedeToolStripMenuItem";
            this.configurarInterfaceDeRedeToolStripMenuItem.Size = new System.Drawing.Size(368, 34);
            this.configurarInterfaceDeRedeToolStripMenuItem.Text = "Configurar Interface de Rede";
            this.configurarInterfaceDeRedeToolStripMenuItem.Click += new System.EventHandler(this.configurarInterfaceDeRedeToolStripMenuItem_Click);
            // 
            // diversosToolStripMenuItem
            // 
            this.diversosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeFimAFimToolStripMenuItem,
            this.extrairLogsToolStripMenuItem});
            this.diversosToolStripMenuItem.Name = "diversosToolStripMenuItem";
            this.diversosToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.diversosToolStripMenuItem.Text = "Diversos";
            // 
            // testeFimAFimToolStripMenuItem
            // 
            this.testeFimAFimToolStripMenuItem.Name = "testeFimAFimToolStripMenuItem";
            this.testeFimAFimToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.testeFimAFimToolStripMenuItem.Text = "Teste Fim a Fim";
            this.testeFimAFimToolStripMenuItem.Click += new System.EventHandler(this.testeFimAFimToolStripMenuItem_Click);
            // 
            // extrairLogsToolStripMenuItem
            // 
            this.extrairLogsToolStripMenuItem.Name = "extrairLogsToolStripMenuItem";
            this.extrairLogsToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.extrairLogsToolStripMenuItem.Text = "Extrair Logs";
            this.extrairLogsToolStripMenuItem.Click += new System.EventHandler(this.extrairLogsToolStripMenuItem_Click);
            // 
            // tbcDados
            // 
            this.tbcDados.Controls.Add(this.tpgConfig);
            this.tbcDados.Controls.Add(this.tpgEmitente);
            this.tbcDados.Controls.Add(this.tpgSwHouse);
            this.tbcDados.Controls.Add(this.tpgRede);
            this.tbcDados.Controls.Add(this.tpgImpressao);
            this.tbcDados.Controls.Add(this.tpgMFe);
            this.tbcDados.Location = new System.Drawing.Point(195, 37);
            this.tbcDados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcDados.Name = "tbcDados";
            this.tbcDados.SelectedIndex = 0;
            this.tbcDados.Size = new System.Drawing.Size(894, 285);
            this.tbcDados.TabIndex = 3;
            // 
            // tpgConfig
            // 
            this.tpgConfig.Controls.Add(this.groupBox2);
            this.tpgConfig.Controls.Add(this.label7);
            this.tpgConfig.Controls.Add(this.chkRemoveAcentos);
            this.tpgConfig.Controls.Add(this.nunVersaoCFe);
            this.tpgConfig.Controls.Add(this.groupBox1);
            this.tpgConfig.Controls.Add(this.label5);
            this.tpgConfig.Controls.Add(this.nunCaixa);
            this.tpgConfig.Controls.Add(this.txtCodUF);
            this.tpgConfig.Controls.Add(this.label4);
            this.tpgConfig.Controls.Add(this.txtAtivacao);
            this.tpgConfig.Controls.Add(this.label3);
            this.tpgConfig.Controls.Add(this.label2);
            this.tpgConfig.Controls.Add(this.cmbAmbiente);
            this.tpgConfig.Controls.Add(this.txtDllPath);
            this.tpgConfig.Controls.Add(this.label1);
            this.tpgConfig.Controls.Add(this.btnSelDll);
            this.tpgConfig.Location = new System.Drawing.Point(4, 29);
            this.tpgConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgConfig.Name = "tpgConfig";
            this.tpgConfig.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgConfig.Size = new System.Drawing.Size(886, 252);
            this.tpgConfig.TabIndex = 0;
            this.tpgConfig.Text = "Dados CFe";
            this.tpgConfig.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSepararData);
            this.groupBox2.Controls.Add(this.chkSepararCNPJ);
            this.groupBox2.Controls.Add(this.chkSaveCFeCanc);
            this.groupBox2.Controls.Add(this.chkSaveEnvio);
            this.groupBox2.Controls.Add(this.chkSaveCFe);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(645, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(219, 217);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salvar XMLs";
            // 
            // chkSepararData
            // 
            this.chkSepararData.AutoSize = true;
            this.chkSepararData.Checked = true;
            this.chkSepararData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSepararData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSepararData.Location = new System.Drawing.Point(15, 171);
            this.chkSepararData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSepararData.Name = "chkSepararData";
            this.chkSepararData.Size = new System.Drawing.Size(182, 24);
            this.chkSepararData.TabIndex = 4;
            this.chkSepararData.Text = "Separar Por Data";
            this.chkSepararData.UseVisualStyleBackColor = true;
            this.chkSepararData.CheckedChanged += new System.EventHandler(this.chkSepararData_CheckedChanged);
            // 
            // chkSepararCNPJ
            // 
            this.chkSepararCNPJ.AutoSize = true;
            this.chkSepararCNPJ.Checked = true;
            this.chkSepararCNPJ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSepararCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSepararCNPJ.Location = new System.Drawing.Point(15, 137);
            this.chkSepararCNPJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSepararCNPJ.Name = "chkSepararCNPJ";
            this.chkSepararCNPJ.Size = new System.Drawing.Size(190, 24);
            this.chkSepararCNPJ.TabIndex = 3;
            this.chkSepararCNPJ.Text = "Separar Por CNPJ";
            this.chkSepararCNPJ.UseVisualStyleBackColor = true;
            this.chkSepararCNPJ.CheckedChanged += new System.EventHandler(this.chkSepararCNPJ_CheckedChanged);
            // 
            // chkSaveCFeCanc
            // 
            this.chkSaveCFeCanc.AutoSize = true;
            this.chkSaveCFeCanc.Checked = true;
            this.chkSaveCFeCanc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveCFeCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSaveCFeCanc.Location = new System.Drawing.Point(15, 103);
            this.chkSaveCFeCanc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSaveCFeCanc.Name = "chkSaveCFeCanc";
            this.chkSaveCFeCanc.Size = new System.Drawing.Size(171, 24);
            this.chkSaveCFeCanc.TabIndex = 2;
            this.chkSaveCFeCanc.Text = "Salvar CFeCanc";
            this.chkSaveCFeCanc.UseVisualStyleBackColor = true;
            this.chkSaveCFeCanc.CheckedChanged += new System.EventHandler(this.chkSaveCFeCanc_CheckedChanged);
            // 
            // chkSaveEnvio
            // 
            this.chkSaveEnvio.AutoSize = true;
            this.chkSaveEnvio.Checked = true;
            this.chkSaveEnvio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSaveEnvio.Location = new System.Drawing.Point(15, 68);
            this.chkSaveEnvio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSaveEnvio.Name = "chkSaveEnvio";
            this.chkSaveEnvio.Size = new System.Drawing.Size(140, 24);
            this.chkSaveEnvio.TabIndex = 1;
            this.chkSaveEnvio.Text = "Salvar Envio";
            this.chkSaveEnvio.UseVisualStyleBackColor = true;
            this.chkSaveEnvio.CheckedChanged += new System.EventHandler(this.chkSaveEnvio_CheckedChanged);
            // 
            // chkSaveCFe
            // 
            this.chkSaveCFe.AutoSize = true;
            this.chkSaveCFe.Checked = true;
            this.chkSaveCFe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveCFe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSaveCFe.Location = new System.Drawing.Point(15, 34);
            this.chkSaveCFe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSaveCFe.Name = "chkSaveCFe";
            this.chkSaveCFe.Size = new System.Drawing.Size(128, 24);
            this.chkSaveCFe.TabIndex = 0;
            this.chkSaveCFe.Text = "Salvar CFe";
            this.chkSaveCFe.UseVisualStyleBackColor = true;
            this.chkSaveCFe.CheckedChanged += new System.EventHandler(this.chkSaveCFe_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(522, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Versão";
            // 
            // chkRemoveAcentos
            // 
            this.chkRemoveAcentos.AutoSize = true;
            this.chkRemoveAcentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemoveAcentos.Location = new System.Drawing.Point(309, 198);
            this.chkRemoveAcentos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRemoveAcentos.Name = "chkRemoveAcentos";
            this.chkRemoveAcentos.Size = new System.Drawing.Size(183, 24);
            this.chkRemoveAcentos.TabIndex = 13;
            this.chkRemoveAcentos.Text = "Remover Acentos";
            this.chkRemoveAcentos.UseVisualStyleBackColor = true;
            this.chkRemoveAcentos.CheckedChanged += new System.EventHandler(this.chkRemoveAcentos_CheckedChanged);
            // 
            // nunVersaoCFe
            // 
            this.nunVersaoCFe.DecimalPlaces = 2;
            this.nunVersaoCFe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nunVersaoCFe.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nunVersaoCFe.Location = new System.Drawing.Point(530, 198);
            this.nunVersaoCFe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nunVersaoCFe.Name = "nunVersaoCFe";
            this.nunVersaoCFe.Size = new System.Drawing.Size(106, 26);
            this.nunVersaoCFe.TabIndex = 13;
            this.nunVersaoCFe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nunVersaoCFe.Value = new decimal(new int[] {
            8,
            0,
            0,
            131072});
            this.nunVersaoCFe.ValueChanged += new System.EventHandler(this.nunVersaoCFe_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUTF8);
            this.groupBox1.Controls.Add(this.nunPaginaCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 142);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(284, 88);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagina de Codigo";
            // 
            // chkUTF8
            // 
            this.chkUTF8.AutoSize = true;
            this.chkUTF8.Location = new System.Drawing.Point(174, 38);
            this.chkUTF8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkUTF8.Name = "chkUTF8";
            this.chkUTF8.Size = new System.Drawing.Size(80, 24);
            this.chkUTF8.TabIndex = 12;
            this.chkUTF8.Text = "UTF8";
            this.chkUTF8.UseVisualStyleBackColor = true;
            this.chkUTF8.CheckedChanged += new System.EventHandler(this.chkUTF8_CheckedChanged);
            // 
            // nunPaginaCodigo
            // 
            this.nunPaginaCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nunPaginaCodigo.Location = new System.Drawing.Point(9, 38);
            this.nunPaginaCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nunPaginaCodigo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nunPaginaCodigo.Name = "nunPaginaCodigo";
            this.nunPaginaCodigo.Size = new System.Drawing.Size(156, 26);
            this.nunPaginaCodigo.TabIndex = 11;
            this.nunPaginaCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nunPaginaCodigo.ValueChanged += new System.EventHandler(this.nunPaginaCodigo_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(530, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Num. Caixa";
            // 
            // nunCaixa
            // 
            this.nunCaixa.Location = new System.Drawing.Point(530, 102);
            this.nunCaixa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nunCaixa.Name = "nunCaixa";
            this.nunCaixa.Size = new System.Drawing.Size(106, 26);
            this.nunCaixa.TabIndex = 9;
            this.nunCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nunCaixa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nunCaixa.ValueChanged += new System.EventHandler(this.nunCaixa_ValueChanged);
            // 
            // txtCodUF
            // 
            this.txtCodUF.Location = new System.Drawing.Point(426, 102);
            this.txtCodUF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodUF.Name = "txtCodUF";
            this.txtCodUF.Size = new System.Drawing.Size(92, 26);
            this.txtCodUF.TabIndex = 8;
            this.txtCodUF.Text = "35";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Codigo UF";
            // 
            // txtAtivacao
            // 
            this.txtAtivacao.Location = new System.Drawing.Point(14, 102);
            this.txtAtivacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAtivacao.Name = "txtAtivacao";
            this.txtAtivacao.Size = new System.Drawing.Size(402, 26);
            this.txtAtivacao.TabIndex = 6;
            this.txtAtivacao.Text = "123456";
            this.txtAtivacao.TextChanged += new System.EventHandler(this.txtAtivacao_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo Ativação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ambiente";
            // 
            // cmbAmbiente
            // 
            this.cmbAmbiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmbiente.Location = new System.Drawing.Point(474, 38);
            this.cmbAmbiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAmbiente.Name = "cmbAmbiente";
            this.cmbAmbiente.Size = new System.Drawing.Size(160, 28);
            this.cmbAmbiente.TabIndex = 3;
            this.cmbAmbiente.SelectedIndexChanged += new System.EventHandler(this.cmbAmbiente_SelectedIndexChanged);
            // 
            // txtDllPath
            // 
            this.txtDllPath.Location = new System.Drawing.Point(14, 37);
            this.txtDllPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDllPath.Name = "txtDllPath";
            this.txtDllPath.Size = new System.Drawing.Size(402, 26);
            this.txtDllPath.TabIndex = 2;
            this.txtDllPath.Text = "C:\\SAT\\SAT.dll";
            this.txtDllPath.TextChanged += new System.EventHandler(this.txtDllPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Dll";
            // 
            // btnSelDll
            // 
            this.btnSelDll.Location = new System.Drawing.Point(426, 37);
            this.btnSelDll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelDll.Name = "btnSelDll";
            this.btnSelDll.Size = new System.Drawing.Size(39, 31);
            this.btnSelDll.TabIndex = 0;
            this.btnSelDll.Text = "...";
            this.btnSelDll.UseVisualStyleBackColor = true;
            this.btnSelDll.Click += new System.EventHandler(this.btnSelDll_Click);
            // 
            // tpgEmitente
            // 
            this.tpgEmitente.Controls.Add(this.label12);
            this.tpgEmitente.Controls.Add(this.cmbEmiRatIISQN);
            this.tpgEmitente.Controls.Add(this.label11);
            this.tpgEmitente.Controls.Add(this.cmbEmiRegTribISSQN);
            this.tpgEmitente.Controls.Add(this.label10);
            this.tpgEmitente.Controls.Add(this.cmbEmiRegTrib);
            this.tpgEmitente.Controls.Add(this.txtEmitIM);
            this.tpgEmitente.Controls.Add(this.txtEmitIE);
            this.tpgEmitente.Controls.Add(this.label9);
            this.tpgEmitente.Controls.Add(this.txtEmitCNPJ);
            this.tpgEmitente.Controls.Add(this.label8);
            this.tpgEmitente.Controls.Add(this.label6);
            this.tpgEmitente.Location = new System.Drawing.Point(4, 29);
            this.tpgEmitente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgEmitente.Name = "tpgEmitente";
            this.tpgEmitente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgEmitente.Size = new System.Drawing.Size(886, 252);
            this.tpgEmitente.TabIndex = 1;
            this.tpgEmitente.Text = "Dados Emitente";
            this.tpgEmitente.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(586, 80);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Ind.Rat.ISSQN";
            // 
            // cmbEmiRatIISQN
            // 
            this.cmbEmiRatIISQN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmiRatIISQN.Items.AddRange(new object[] {
            "Homologação",
            "Produção"});
            this.cmbEmiRatIISQN.Location = new System.Drawing.Point(591, 105);
            this.cmbEmiRatIISQN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEmiRatIISQN.Name = "cmbEmiRatIISQN";
            this.cmbEmiRatIISQN.Size = new System.Drawing.Size(277, 28);
            this.cmbEmiRatIISQN.TabIndex = 14;
            this.cmbEmiRatIISQN.SelectedIndexChanged += new System.EventHandler(this.cmbEmiRatIISQN_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(333, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Regime Trib. ISSQN";
            // 
            // cmbEmiRegTribISSQN
            // 
            this.cmbEmiRegTribISSQN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmiRegTribISSQN.Items.AddRange(new object[] {
            "Homologação",
            "Produção"});
            this.cmbEmiRegTribISSQN.Location = new System.Drawing.Point(303, 105);
            this.cmbEmiRegTribISSQN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEmiRegTribISSQN.Name = "cmbEmiRegTribISSQN";
            this.cmbEmiRegTribISSQN.Size = new System.Drawing.Size(277, 28);
            this.cmbEmiRegTribISSQN.TabIndex = 12;
            this.cmbEmiRegTribISSQN.SelectedIndexChanged += new System.EventHandler(this.cmbEmiRegTribISSQN_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Regime Tributario";
            // 
            // cmbEmiRegTrib
            // 
            this.cmbEmiRegTrib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmiRegTrib.Items.AddRange(new object[] {
            "Homologação",
            "Produção"});
            this.cmbEmiRegTrib.Location = new System.Drawing.Point(15, 105);
            this.cmbEmiRegTrib.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEmiRegTrib.Name = "cmbEmiRegTrib";
            this.cmbEmiRegTrib.Size = new System.Drawing.Size(277, 28);
            this.cmbEmiRegTrib.TabIndex = 10;
            this.cmbEmiRegTrib.SelectedIndexChanged += new System.EventHandler(this.cmbEmiRegTrib_SelectedIndexChanged);
            // 
            // txtEmitIM
            // 
            this.txtEmitIM.Location = new System.Drawing.Point(591, 42);
            this.txtEmitIM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmitIM.Name = "txtEmitIM";
            this.txtEmitIM.Size = new System.Drawing.Size(277, 26);
            this.txtEmitIM.TabIndex = 9;
            this.txtEmitIM.TextChanged += new System.EventHandler(this.txtEmitIM_TextChanged);
            // 
            // txtEmitIE
            // 
            this.txtEmitIE.Location = new System.Drawing.Point(303, 42);
            this.txtEmitIE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmitIE.Name = "txtEmitIE";
            this.txtEmitIE.Size = new System.Drawing.Size(277, 26);
            this.txtEmitIE.TabIndex = 8;
            this.txtEmitIE.TextChanged += new System.EventHandler(this.txtEmitIE_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(298, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Inscrição Estadual";
            // 
            // txtEmitCNPJ
            // 
            this.txtEmitCNPJ.Location = new System.Drawing.Point(15, 42);
            this.txtEmitCNPJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmitCNPJ.Name = "txtEmitCNPJ";
            this.txtEmitCNPJ.Size = new System.Drawing.Size(277, 26);
            this.txtEmitCNPJ.TabIndex = 6;
            this.txtEmitCNPJ.Text = "11111111111111";
            this.txtEmitCNPJ.TextChanged += new System.EventHandler(this.txtEmitCNPJ_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "CNPJ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(586, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Inscrição Municipal";
            // 
            // tpgSwHouse
            // 
            this.tpgSwHouse.Controls.Add(this.txtSignAC);
            this.tpgSwHouse.Controls.Add(this.label14);
            this.tpgSwHouse.Controls.Add(this.txtIdeCNPJ);
            this.tpgSwHouse.Controls.Add(this.label13);
            this.tpgSwHouse.Location = new System.Drawing.Point(4, 29);
            this.tpgSwHouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgSwHouse.Name = "tpgSwHouse";
            this.tpgSwHouse.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgSwHouse.Size = new System.Drawing.Size(886, 252);
            this.tpgSwHouse.TabIndex = 2;
            this.tpgSwHouse.Text = "Dados Sw.House";
            this.tpgSwHouse.UseVisualStyleBackColor = true;
            // 
            // txtSignAC
            // 
            this.txtSignAC.Location = new System.Drawing.Point(12, 105);
            this.txtSignAC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSignAC.MaxLength = 344;
            this.txtSignAC.Name = "txtSignAC";
            this.txtSignAC.Size = new System.Drawing.Size(859, 26);
            this.txtSignAC.TabIndex = 10;
            this.txtSignAC.TextChanged += new System.EventHandler(this.txtSignAC_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 78);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(335, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Assinatura Sw.House (344 caracteres)";
            // 
            // txtIdeCNPJ
            // 
            this.txtIdeCNPJ.Location = new System.Drawing.Point(12, 38);
            this.txtIdeCNPJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdeCNPJ.Name = "txtIdeCNPJ";
            this.txtIdeCNPJ.Size = new System.Drawing.Size(312, 26);
            this.txtIdeCNPJ.TabIndex = 8;
            this.txtIdeCNPJ.Text = "11111111111111";
            this.txtIdeCNPJ.TextChanged += new System.EventHandler(this.txtIdeCNPJ_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "CNPJ";
            // 
            // tpgRede
            // 
            this.tpgRede.Location = new System.Drawing.Point(4, 29);
            this.tpgRede.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgRede.Name = "tpgRede";
            this.tpgRede.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgRede.Size = new System.Drawing.Size(886, 252);
            this.tpgRede.TabIndex = 3;
            this.tpgRede.Text = "Rede";
            this.tpgRede.UseVisualStyleBackColor = true;
            // 
            // tpgImpressao
            // 
            this.tpgImpressao.Controls.Add(this.label20);
            this.tpgImpressao.Controls.Add(this.nudEspacoFinal);
            this.tpgImpressao.Controls.Add(this.groupBoxExportacao);
            this.tpgImpressao.Controls.Add(this.chkSetup);
            this.tpgImpressao.Controls.Add(this.chkPreview);
            this.tpgImpressao.Controls.Add(this.groupBox4);
            this.tpgImpressao.Location = new System.Drawing.Point(4, 29);
            this.tpgImpressao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgImpressao.Name = "tpgImpressao";
            this.tpgImpressao.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgImpressao.Size = new System.Drawing.Size(886, 252);
            this.tpgImpressao.TabIndex = 4;
            this.tpgImpressao.Text = "Impressão";
            this.tpgImpressao.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(668, 37);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 20);
            this.label20.TabIndex = 14;
            this.label20.Text = "Espaço Final";
            // 
            // nudEspacoFinal
            // 
            this.nudEspacoFinal.DecimalPlaces = 2;
            this.nudEspacoFinal.Location = new System.Drawing.Point(778, 34);
            this.nudEspacoFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudEspacoFinal.Name = "nudEspacoFinal";
            this.nudEspacoFinal.Size = new System.Drawing.Size(90, 26);
            this.nudEspacoFinal.TabIndex = 13;
            this.nudEspacoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudEspacoFinal.ValueChanged += new System.EventHandler(this.nudEspacoFinal_ValueChanged);
            // 
            // groupBoxExportacao
            // 
            this.groupBoxExportacao.Controls.Add(this.cmbFiltro);
            this.groupBoxExportacao.Controls.Add(this.label21);
            this.groupBoxExportacao.Controls.Add(this.txtExportacao);
            this.groupBoxExportacao.Controls.Add(this.btnExportacao);
            this.groupBoxExportacao.Controls.Add(this.label22);
            this.groupBoxExportacao.Location = new System.Drawing.Point(261, 69);
            this.groupBoxExportacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxExportacao.Name = "groupBoxExportacao";
            this.groupBoxExportacao.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxExportacao.Size = new System.Drawing.Size(608, 166);
            this.groupBoxExportacao.TabIndex = 12;
            this.groupBoxExportacao.TabStop = false;
            this.groupBoxExportacao.Text = "Exportação";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.Location = new System.Drawing.Point(9, 65);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(246, 28);
            this.cmbFiltro.TabIndex = 8;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(9, 40);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 20);
            this.label21.TabIndex = 6;
            this.label21.Text = "Filtro";
            // 
            // txtExportacao
            // 
            this.txtExportacao.Enabled = false;
            this.txtExportacao.Location = new System.Drawing.Point(9, 126);
            this.txtExportacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExportacao.Name = "txtExportacao";
            this.txtExportacao.Size = new System.Drawing.Size(520, 26);
            this.txtExportacao.TabIndex = 4;
            this.txtExportacao.TextChanged += new System.EventHandler(this.txtExportacao_TextChanged);
            // 
            // btnExportacao
            // 
            this.btnExportacao.Enabled = false;
            this.btnExportacao.Location = new System.Drawing.Point(540, 126);
            this.btnExportacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportacao.Name = "btnExportacao";
            this.btnExportacao.Size = new System.Drawing.Size(36, 31);
            this.btnExportacao.TabIndex = 5;
            this.btnExportacao.Text = "...";
            this.btnExportacao.UseVisualStyleBackColor = true;
            this.btnExportacao.Click += new System.EventHandler(this.btnExportacao_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(9, 102);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(172, 20);
            this.label22.TabIndex = 3;
            this.label22.Text = "Arquivo Exportação";
            // 
            // chkSetup
            // 
            this.chkSetup.AutoSize = true;
            this.chkSetup.Location = new System.Drawing.Point(423, 34);
            this.chkSetup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSetup.Name = "chkSetup";
            this.chkSetup.Size = new System.Drawing.Size(136, 24);
            this.chkSetup.TabIndex = 11;
            this.chkSetup.Text = "Mostrar Setup";
            this.chkSetup.UseVisualStyleBackColor = true;
            this.chkSetup.CheckedChanged += new System.EventHandler(this.chkSetup_CheckedChanged);
            // 
            // chkPreview
            // 
            this.chkPreview.AutoSize = true;
            this.chkPreview.Location = new System.Drawing.Point(261, 34);
            this.chkPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(147, 24);
            this.chkPreview.TabIndex = 10;
            this.chkPreview.Text = "Mostrar Preview";
            this.chkPreview.UseVisualStyleBackColor = true;
            this.chkPreview.CheckedChanged += new System.EventHandler(this.chkPreview_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pctLogo);
            this.groupBox4.Location = new System.Drawing.Point(14, 9);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(238, 226);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logo";
            // 
            // pctLogo
            // 
            this.pctLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctLogo.ContextMenuStrip = this.contextMenuStripImage;
            this.pctLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctLogo.Location = new System.Drawing.Point(4, 24);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(230, 197);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // contextMenuStripImage
            // 
            this.contextMenuStripImage.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carregarImagemToolStripMenuItem,
            this.limparLogoToolStripMenuItem});
            this.contextMenuStripImage.Name = "contextMenuStripImage";
            this.contextMenuStripImage.Size = new System.Drawing.Size(198, 68);
            // 
            // carregarImagemToolStripMenuItem
            // 
            this.carregarImagemToolStripMenuItem.Name = "carregarImagemToolStripMenuItem";
            this.carregarImagemToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.carregarImagemToolStripMenuItem.Text = "Carregar Logo";
            this.carregarImagemToolStripMenuItem.Click += new System.EventHandler(this.carregarImagemToolStripMenuItem_Click);
            // 
            // limparLogoToolStripMenuItem
            // 
            this.limparLogoToolStripMenuItem.Name = "limparLogoToolStripMenuItem";
            this.limparLogoToolStripMenuItem.Size = new System.Drawing.Size(197, 32);
            this.limparLogoToolStripMenuItem.Text = "Limpar Logo";
            this.limparLogoToolStripMenuItem.Click += new System.EventHandler(this.limparLogoToolStripMenuItem_Click);
            // 
            // tpgMFe
            // 
            this.tpgMFe.Controls.Add(this.txtChaveAcessoValidador);
            this.tpgMFe.Controls.Add(this.label19);
            this.tpgMFe.Controls.Add(this.btnRespostaFiscal);
            this.tpgMFe.Controls.Add(this.btnVerificarStatusValidador);
            this.tpgMFe.Controls.Add(this.btnEnviarStatusPagamento);
            this.tpgMFe.Controls.Add(this.btnEnviarPagamento);
            this.tpgMFe.Controls.Add(this.label18);
            this.tpgMFe.Controls.Add(this.nunMFeTimeout);
            this.tpgMFe.Controls.Add(this.txtMFeResposta);
            this.tpgMFe.Controls.Add(this.label17);
            this.tpgMFe.Controls.Add(this.txtMFeEnvio);
            this.tpgMFe.Controls.Add(this.label16);
            this.tpgMFe.Location = new System.Drawing.Point(4, 29);
            this.tpgMFe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgMFe.Name = "tpgMFe";
            this.tpgMFe.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgMFe.Size = new System.Drawing.Size(886, 252);
            this.tpgMFe.TabIndex = 5;
            this.tpgMFe.Text = "MFE";
            this.tpgMFe.UseVisualStyleBackColor = true;
            // 
            // txtChaveAcessoValidador
            // 
            this.txtChaveAcessoValidador.Location = new System.Drawing.Point(12, 182);
            this.txtChaveAcessoValidador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChaveAcessoValidador.Name = "txtChaveAcessoValidador";
            this.txtChaveAcessoValidador.Size = new System.Drawing.Size(402, 26);
            this.txtChaveAcessoValidador.TabIndex = 19;
            this.txtChaveAcessoValidador.TextChanged += new System.EventHandler(this.txtChaveAcessoValidador_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(8, 152);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(261, 20);
            this.label19.TabIndex = 18;
            this.label19.Text = "Chave de acesso ao validador";
            // 
            // btnRespostaFiscal
            // 
            this.btnRespostaFiscal.Location = new System.Drawing.Point(650, 91);
            this.btnRespostaFiscal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRespostaFiscal.Name = "btnRespostaFiscal";
            this.btnRespostaFiscal.Size = new System.Drawing.Size(207, 37);
            this.btnRespostaFiscal.TabIndex = 17;
            this.btnRespostaFiscal.Text = "Resposta Fiscal";
            this.btnRespostaFiscal.UseVisualStyleBackColor = true;
            this.btnRespostaFiscal.Click += new System.EventHandler(this.btnRespostaFiscal_Click);
            // 
            // btnVerificarStatusValidador
            // 
            this.btnVerificarStatusValidador.Location = new System.Drawing.Point(438, 91);
            this.btnVerificarStatusValidador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerificarStatusValidador.Name = "btnVerificarStatusValidador";
            this.btnVerificarStatusValidador.Size = new System.Drawing.Size(207, 37);
            this.btnVerificarStatusValidador.TabIndex = 16;
            this.btnVerificarStatusValidador.Text = "Verificar Status Validador";
            this.btnVerificarStatusValidador.UseVisualStyleBackColor = true;
            this.btnVerificarStatusValidador.Click += new System.EventHandler(this.btnVerificarStatusValidador_Click);
            // 
            // btnEnviarStatusPagamento
            // 
            this.btnEnviarStatusPagamento.Location = new System.Drawing.Point(650, 37);
            this.btnEnviarStatusPagamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnviarStatusPagamento.Name = "btnEnviarStatusPagamento";
            this.btnEnviarStatusPagamento.Size = new System.Drawing.Size(207, 37);
            this.btnEnviarStatusPagamento.TabIndex = 15;
            this.btnEnviarStatusPagamento.Text = "Enviar Status Pagamento";
            this.btnEnviarStatusPagamento.UseVisualStyleBackColor = true;
            this.btnEnviarStatusPagamento.Click += new System.EventHandler(this.btnEnviarStatusPagamento_Click);
            // 
            // btnEnviarPagamento
            // 
            this.btnEnviarPagamento.Location = new System.Drawing.Point(438, 37);
            this.btnEnviarPagamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnviarPagamento.Name = "btnEnviarPagamento";
            this.btnEnviarPagamento.Size = new System.Drawing.Size(207, 37);
            this.btnEnviarPagamento.TabIndex = 14;
            this.btnEnviarPagamento.Text = "MFE Enviar Pagamento";
            this.btnEnviarPagamento.UseVisualStyleBackColor = true;
            this.btnEnviarPagamento.Click += new System.EventHandler(this.btnEnviarPagamento_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(423, 151);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(237, 20);
            this.label18.TabIndex = 13;
            this.label18.Text = "Timeout (em milisegundos)";
            // 
            // nunMFeTimeout
            // 
            this.nunMFeTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nunMFeTimeout.Location = new System.Drawing.Point(428, 180);
            this.nunMFeTimeout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nunMFeTimeout.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nunMFeTimeout.Name = "nunMFeTimeout";
            this.nunMFeTimeout.Size = new System.Drawing.Size(126, 26);
            this.nunMFeTimeout.TabIndex = 12;
            this.nunMFeTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nunMFeTimeout.Value = new decimal(new int[] {
            45000,
            0,
            0,
            0});
            this.nunMFeTimeout.ValueChanged += new System.EventHandler(this.nunMFeTimeout_ValueChanged);
            // 
            // txtMFeResposta
            // 
            this.txtMFeResposta.Location = new System.Drawing.Point(12, 109);
            this.txtMFeResposta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMFeResposta.Name = "txtMFeResposta";
            this.txtMFeResposta.Size = new System.Drawing.Size(402, 26);
            this.txtMFeResposta.TabIndex = 6;
            this.txtMFeResposta.Text = "C:\\Integrador\\Output";
            this.txtMFeResposta.TextChanged += new System.EventHandler(this.txtMFeResposta_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 85);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(142, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Pasta Resposta";
            // 
            // txtMFeEnvio
            // 
            this.txtMFeEnvio.Location = new System.Drawing.Point(12, 40);
            this.txtMFeEnvio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMFeEnvio.Name = "txtMFeEnvio";
            this.txtMFeEnvio.Size = new System.Drawing.Size(402, 26);
            this.txtMFeEnvio.TabIndex = 4;
            this.txtMFeEnvio.Text = "C:\\Integrador\\Input";
            this.txtMFeEnvio.TextChanged += new System.EventHandler(this.txtMFeEnvio_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 15);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Pasta Envio";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 46);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Modelo";
            // 
            // cmbModeloSat
            // 
            this.cmbModeloSat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModeloSat.Location = new System.Drawing.Point(18, 71);
            this.cmbModeloSat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbModeloSat.Name = "cmbModeloSat";
            this.cmbModeloSat.Size = new System.Drawing.Size(160, 28);
            this.cmbModeloSat.TabIndex = 18;
            this.cmbModeloSat.SelectedIndexChanged += new System.EventHandler(this.cmbModeloSat_SelectedIndexChanged);
            // 
            // btnIniDesini
            // 
            this.btnIniDesini.Location = new System.Drawing.Point(18, 117);
            this.btnIniDesini.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniDesini.Name = "btnIniDesini";
            this.btnIniDesini.Size = new System.Drawing.Size(168, 35);
            this.btnIniDesini.TabIndex = 1;
            this.btnIniDesini.Text = "Inicializar";
            this.btnIniDesini.UseVisualStyleBackColor = true;
            this.btnIniDesini.Click += new System.EventHandler(this.btnIniDesini_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnParamSave);
            this.groupBox3.Controls.Add(this.btnParamLoad);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 162);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(168, 154);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parâmetros";
            // 
            // btnParamSave
            // 
            this.btnParamSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParamSave.Location = new System.Drawing.Point(24, 89);
            this.btnParamSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParamSave.Name = "btnParamSave";
            this.btnParamSave.Size = new System.Drawing.Size(120, 35);
            this.btnParamSave.TabIndex = 3;
            this.btnParamSave.Text = "Gravar";
            this.btnParamSave.UseVisualStyleBackColor = true;
            this.btnParamSave.Click += new System.EventHandler(this.btnParamSave_Click);
            // 
            // btnParamLoad
            // 
            this.btnParamLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParamLoad.Location = new System.Drawing.Point(24, 45);
            this.btnParamLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParamLoad.Name = "btnParamLoad";
            this.btnParamLoad.Size = new System.Drawing.Size(120, 35);
            this.btnParamLoad.TabIndex = 2;
            this.btnParamLoad.Text = "Ler";
            this.btnParamLoad.UseVisualStyleBackColor = true;
            this.btnParamLoad.Click += new System.EventHandler(this.btnParamLoad_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 732);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnIniDesini);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbModeloSat);
            this.Controls.Add(this.tbcDados);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbcXml);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S@T Demo";
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.tpgLog.ResumeLayout(false);
            this.tbcXml.ResumeLayout(false);
            this.tpgXmlGerado.ResumeLayout(false);
            this.tpgXmlRecebido.ResumeLayout(false);
            this.tpgXmlCancelamento.ResumeLayout(false);
            this.tpgXmlRede.ResumeLayout(false);
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbcDados.ResumeLayout(false);
            this.tpgConfig.ResumeLayout(false);
            this.tpgConfig.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nunVersaoCFe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nunPaginaCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nunCaixa)).EndInit();
            this.tpgEmitente.ResumeLayout(false);
            this.tpgEmitente.PerformLayout();
            this.tpgSwHouse.ResumeLayout(false);
            this.tpgSwHouse.PerformLayout();
            this.tpgImpressao.ResumeLayout(false);
            this.tpgImpressao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEspacoFinal)).EndInit();
            this.groupBoxExportacao.ResumeLayout(false);
            this.groupBoxExportacao.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.contextMenuStripImage.ResumeLayout(false);
            this.tpgMFe.ResumeLayout(false);
            this.tpgMFe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nunMFeTimeout)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabPage tpgLog;
		private System.Windows.Forms.TabControl tbcXml;
		private System.Windows.Forms.RichTextBox rtbLog;
		private System.Windows.Forms.StatusStrip stsStatus;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ativaçãoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ativarSATToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem comunicarCertificadoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem associarAssinaturaToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem bloquearSATToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem desbloquearSATToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem trocarCódigoDeAtivaçãoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cancelamentoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem diversosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem testeFimAFimToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem extrairLogsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gerarVendaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem enviarVendaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imprimirExtratoVendaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imprimirExtratoVendaResumidoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem carregarXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.ToolStripMenuItem gerarXMLCancelamentoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem enviarCancelamentoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imprimirExtratoCancelamentoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarStatusOperacionalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarSATToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultarNumeroDeSessãoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem atualizarSATToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem lerXMLConfiguraçãoDeInterfaceDeRedeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gravarXmlDeInterfaceDeRedeToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem configurarInterfaceDeRedeToolStripMenuItem;
		private System.Windows.Forms.TabControl tbcDados;
		private System.Windows.Forms.TabPage tpgConfig;
		private System.Windows.Forms.TabPage tpgEmitente;
		private System.Windows.Forms.TabPage tpgSwHouse;
		private System.Windows.Forms.TabPage tpgRede;
		private System.Windows.Forms.TabPage tpgImpressao;
		private System.Windows.Forms.TextBox txtDllPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSelDll;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbAmbiente;
		private System.Windows.Forms.TextBox txtCodUF;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAtivacao;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown nunCaixa;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkUTF8;
		private System.Windows.Forms.NumericUpDown nunPaginaCodigo;
		private System.Windows.Forms.CheckBox chkRemoveAcentos;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown nunVersaoCFe;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkSepararData;
		private System.Windows.Forms.CheckBox chkSepararCNPJ;
		private System.Windows.Forms.CheckBox chkSaveCFeCanc;
		private System.Windows.Forms.CheckBox chkSaveEnvio;
		private System.Windows.Forms.CheckBox chkSaveCFe;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtEmitCNPJ;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtEmitIM;
		private System.Windows.Forms.TextBox txtEmitIE;
		private System.Windows.Forms.TabPage tpgXmlGerado;
		private System.Windows.Forms.WebBrowser wbrXmlGerado;
		private System.Windows.Forms.TabPage tpgXmlRecebido;
		private System.Windows.Forms.WebBrowser wbrXmlRecebido;
		private System.Windows.Forms.TabPage tpgXmlCancelamento;
		private System.Windows.Forms.WebBrowser wbrXmlCancelamento;
		private System.Windows.Forms.TabPage tpgXmlRede;
		private System.Windows.Forms.WebBrowser wbrXmlRede;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cmbEmiRatIISQN;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cmbEmiRegTribISSQN;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmbEmiRegTrib;
		private System.Windows.Forms.TextBox txtSignAC;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtIdeCNPJ;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox cmbModeloSat;
		private System.Windows.Forms.Button btnIniDesini;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnParamSave;
		private System.Windows.Forms.Button btnParamLoad;
        private System.Windows.Forms.TabPage tpgMFe;
        private System.Windows.Forms.TextBox txtMFeResposta;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMFeEnvio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nunMFeTimeout;
        private System.Windows.Forms.Button btnRespostaFiscal;
        private System.Windows.Forms.Button btnVerificarStatusValidador;
        private System.Windows.Forms.Button btnEnviarStatusPagamento;
        private System.Windows.Forms.Button btnEnviarPagamento;
        private System.Windows.Forms.TextBox txtChaveAcessoValidador;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nudEspacoFinal;
        private System.Windows.Forms.GroupBox groupBoxExportacao;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtExportacao;
        private System.Windows.Forms.Button btnExportacao;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox chkSetup;
        private System.Windows.Forms.CheckBox chkPreview;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImage;
        private System.Windows.Forms.ToolStripMenuItem carregarImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparLogoToolStripMenuItem;
    }
}

