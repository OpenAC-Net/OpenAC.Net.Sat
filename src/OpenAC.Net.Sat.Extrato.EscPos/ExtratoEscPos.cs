// ***********************************************************************
// Assembly         : OpenAC.Net.Sat.Extrato.EscPos
// Author           : Rafael Dias
// Created          : 03-04-2022
//
// Last Modified By : Rafael Dias
// Last Modified On : 03-04-2022
// ***********************************************************************
// <copyright file="ExtratoEscPos.cs" company="OpenAC .Net">
//		        		   The MIT License (MIT)
// 		    Copyright (c) 2016 - 2022 Projeto OpenAC .Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using OpenAC.Net.Core.Extensions;
using OpenAC.Net.DFe.Core.Common;
using OpenAC.Net.EscPos;
using OpenAC.Net.EscPos.Commom;

namespace OpenAC.Net.Sat.Extrato.EscPos
{
    public sealed class ExtratoEscPos : ExtratoSat
    {
        #region Events

        public EventHandler<EspPosprintEventArgs> GetPrinter;
        private EscPosPrinter printer;

        #endregion Events

        #region Properties

        public new FiltroDFeReport Filtro
        {
            get => FiltroDFeReport.Nenhum;
            set => throw new NotSupportedException("Filtro não é suportado no extrato EscPos");
        }

        public EscPosPrinter Printer
        {
            get
            {
                if (printer != null) return printer;

                var e = new EspPosprintEventArgs();
                GetPrinter.Raise(this, e);
                printer = e.Printer;

                return printer;
            }
            set => printer = value;
        }

        public bool DescricaoUmaLinha { get; set; } = true;

        public bool UsarBarrasComoCodigo { get; set; } = true;

        public int CasasDecimaisQuantidade { get; set; } = 2;

        public bool ImprimirDeOlhoNoImposto { get; set; } = true;

        public bool CortarPapel { get; set; } = true;

        #endregion Properties

        #region Methods

        public override void ImprimirExtrato(CFe cfe) => Imprimir(ExtratoLayOut.Completo, cfe.InfCFe.Ide.TpAmb ?? DFeTipoAmbiente.Homologacao, cfe, null);

        public override void ImprimirExtratoResumido(CFe cfe) => Imprimir(ExtratoLayOut.Resumido, cfe.InfCFe.Ide.TpAmb ?? DFeTipoAmbiente.Homologacao, cfe, null);

        public override void ImprimirExtratoCancelamento(CFe cfe, CFeCanc cFeCanc) => Imprimir(ExtratoLayOut.Cancelamento, cfe.InfCFe.Ide.TpAmb ?? DFeTipoAmbiente.Homologacao, cfe, cFeCanc);

        private void Imprimir(ExtratoLayOut tipo, DFeTipoAmbiente ambiente, CFe cfe, CFeCanc cFeCanc)
        {
            if (!Printer.Conectado)
                Printer.Conectar();

            var centralizado = Printer.Colunas < 48 ? CmdAlinhamento.Esquerda : CmdAlinhamento.Centro;
            var cultura = new CultureInfo("pt-Br");
            var numeroExtrato = ambiente == DFeTipoAmbiente.Homologacao ? "000000" : cfe.InfCFe.Ide.NCFe.ToString();

            #region Cabecalho

            #region Logotipo

            if (Logo != null)
                Printer.ImprimirImagem(Logo, centralizado);

            #endregion Logotipo

            #region Dados do Emitente

            Printer.ImprimirTexto(!cfe.InfCFe.Emit.XFant.IsEmpty() ? cfe.InfCFe.Emit.XFant.FillRight(Printer.Colunas) :
                                                                     cfe.InfCFe.Emit.XNome.LimitarString(Printer.Colunas), centralizado, CmdEstiloFonte.Negrito);

            Printer.ImprimirTexto(cfe.InfCFe.Emit.XNome.LimitarString(Printer.Colunas));
            Printer.ImprimirTexto(AjustarTextoColunas($"Cnpj: {cfe.InfCFe.Emit.CNPJ.FormataCPFCNPJ()}", $"I.E.: {cfe.InfCFe.Emit.IE}", Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);
            Printer.ImprimirTexto($"End.: {cfe.InfCFe.Emit.EnderEmit.XLgr},{cfe.InfCFe.Emit.EnderEmit.Nro} {cfe.InfCFe.Emit.EnderEmit.XCpl}", CmdTamanhoFonte.Condensada);
            Printer.ImprimirTexto($"Bairro: {cfe.InfCFe.Emit.EnderEmit.XBairro} - {cfe.InfCFe.Emit.EnderEmit.XMun} - {cfe.InfCFe.Emit.EnderEmit.CEP.FormataCEP()}", CmdTamanhoFonte.Condensada);
            Printer.ImprimirSeparador();

            #endregion Dados do Emitente

            #region Dados do extrato

            Printer.ImprimirTexto($"Extrato No. {numeroExtrato}", centralizado, CmdEstiloFonte.Negrito);
            Printer.ImprimirTexto("CUPOM FISCAL ELETRÔNICO SAT", centralizado, CmdEstiloFonte.Negrito);
            if (cFeCanc != null)
                Printer.ImprimirTexto("CANCELAMENTO", centralizado, CmdEstiloFonte.Negrito);

            #endregion Dados do extrato

            #region Homologação

            if (ambiente == DFeTipoAmbiente.Homologacao)
            {
                Printer.ImprimirSeparador();

                Printer.ImprimirTexto("=   T E S T E   =", CmdTamanhoFonte.Expandida, CmdAlinhamento.Centro, CmdEstiloFonte.Negrito);
                Printer.ImprimirTexto(new string('>', Printer.Colunas), CmdEstiloFonte.Negrito);
                Printer.ImprimirTexto(new string('>', Printer.Colunas), CmdEstiloFonte.Negrito);
                Printer.ImprimirTexto(new string('>', Printer.Colunas), CmdEstiloFonte.Negrito);

                Printer.ImprimirSeparador();
            }

            #endregion Homologação

            #endregion Cabecalho

            switch (tipo)
            {
                case ExtratoLayOut.Completo:

                    #region Consumidor

                    var cpfcnpj = cfe.InfCFe.Dest?.CPF.IsEmpty() == true ? cfe.InfCFe.Dest.CPF.FormataCPF() :
                        cfe.InfCFe.Dest?.CNPJ.IsEmpty() == true ? cfe.InfCFe.Dest.CNPJ.FormataCNPJ() :
                        "000.000.000-00";

                    Printer.ImprimirTexto($"CPF/CNPJ do Consumidor: {cpfcnpj}", CmdTamanhoFonte.Condensada);
                    Printer.ImprimirTexto($"Razão Social/Nome: {(cfe.InfCFe.Dest?.Nome ?? "CONSUMIDOR")}".LimitarString(Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);

                    Printer.ImprimirSeparador();

                    #endregion Consumidor

                    #region Detalhes

                    if (Printer.Colunas >= 48)
                        Printer.ImprimirTexto("#|COD|DESC|QTD|UN|VL UN|DESC|VL ITEM", CmdAlinhamento.Centro,
                            CmdEstiloFonte.Negrito);
                    else
                        Printer.ImprimirTexto("COD|DESC|QTD|UN|VL UN|DESC|VL ITEM", CmdEstiloFonte.Negrito);

                    Printer.ImprimirSeparador();

                    #region Produtos

                    foreach (var det in cfe.InfCFe.Det)
                    {
                        var codProd =
                            $"{(UsarBarrasComoCodigo && det.Prod.CEAN.IsEmpty() ? det.Prod.CEAN : det.Prod.CProd),-13}";
                        var textoE = DescricaoUmaLinha
                            ? $"{det.NItem:D3} | {codProd} {det.Prod.XProd}"
                            : $"{det.NItem:D3} | {codProd}";

                        var textoR =
                            $"{det.Prod.QCom.ToString($"N{CasasDecimaisQuantidade}")} {det.Prod.UCom} x {det.Prod.VUnCom:N2} = {det.Prod.VItem:N2}";

                        Printer.ImprimirTexto(AjustarTextoColunas(textoE, textoR, Printer.ColunasCondensada),
                            CmdTamanhoFonte.Condensada);

                        if (!DescricaoUmaLinha)
                            Printer.ImprimirTexto(det.Prod.XProd.LimitarString(Printer.ColunasCondensada),
                                CmdTamanhoFonte.Condensada);

                        if (det.Prod.VOutro > 0)
                            Printer.ImprimirTexto(
                                AjustarTextoColunas("Acréscimos:", det.Prod.VDesc.ToString("C2", cultura),
                                    Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);

                        if (det.Prod.VDesc > 0)
                            Printer.ImprimirTexto(
                                AjustarTextoColunas("Descontos:", det.Prod.VDesc.ToString("C2", cultura),
                                    Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);
                    }

                    Printer.ImprimirSeparador();

                    #region Totais

                    Printer.ImprimirTexto(
                        AjustarTextoColunas("Qtde. total de itens:", cfe.InfCFe.Det.Count.ToString("N0", cultura),
                            Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);
                    Printer.ImprimirTexto(
                        AjustarTextoColunas("Subtotal:", cfe.InfCFe.Total.ICMSTot.VProd.ToString("C2", cultura),
                            Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);

                    if (cfe.InfCFe.Total.ICMSTot.VOutro > 0)
                        Printer.ImprimirTexto(
                            AjustarTextoColunas("Acréscimos:", cfe.InfCFe.Total.ICMSTot.VOutro.ToString("C2", cultura),
                                Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);

                    if (cfe.InfCFe.Total.ICMSTot.VDesc > 0)
                        Printer.ImprimirTexto(
                            AjustarTextoColunas("Descontos:", cfe.InfCFe.Total.ICMSTot.VDesc.ToString("C2", cultura),
                                Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);

                    Printer.ImprimirTexto(
                        AjustarTextoColunas("Valor TOTAL:", cfe.InfCFe.Total.VCFe.ToString("C2", cultura), Printer.Colunas),
                        CmdEstiloFonte.Negrito);

                    #endregion Totais

                    #endregion Produtos

                    Printer.PularLinhas(1);

                    #region Pagamentos

                    foreach (var pagto in cfe.InfCFe.Pagto.Pagamentos)
                        Printer.ImprimirTexto(
                            AjustarTextoColunas(pagto.CMp.GetDescription(), pagto.VMp.ToString("C2", cultura),
                                Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);

                    Printer.ImprimirTexto(AjustarTextoColunas("Troco:", cfe.InfCFe.Pagto.VTroco.ToString("C2", cultura),
                        Printer.Colunas));
                    Printer.PularLinhas(1);

                    #endregion Pagamentos

                    #endregion Detalhes

                    #region Rodape

                    #region Dados da entrega

                    if (cfe.InfCFe.Entrega != null && !cfe.InfCFe.Entrega.XLgr.IsNull())
                    {
                        Printer.ImprimirTexto("DADOS PARA ENTREGA", centralizado, CmdEstiloFonte.Negrito);
                        Printer.ImprimirTexto($"End.: {cfe.InfCFe.Entrega.XLgr}, {cfe.InfCFe.Entrega.Nro} {cfe.InfCFe.Entrega.XCpl}", CmdTamanhoFonte.Condensada);
                        Printer.ImprimirTexto($"Bairro: {cfe.InfCFe.Entrega.XBairro} - {cfe.InfCFe.Entrega.XMun}/{cfe.InfCFe.Entrega.UF}", CmdTamanhoFonte.Condensada);
                        Printer.ImprimirSeparador();
                    }

                    #endregion Dados da entrega

                    #region Observações do Fisco

                    if (cfe.InfCFe.InfAdic.ObsFisco.Any())
                    {
                        Printer.ImprimirTexto("Observações do Fisco", CmdTamanhoFonte.Condensada, CmdEstiloFonte.Negrito);

                        foreach (var txt in cfe.InfCFe.InfAdic.ObsFisco.Select(fisco => $"{fisco.XCampo} - {fisco.XTexto}").SelectMany(texto => texto.WrapText(Printer.Colunas)))
                        {
                            Printer.ImprimirTexto(txt, CmdTamanhoFonte.Condensada);
                        }

                        Printer.PularLinhas(1);
                    }

                    #endregion Observações do Fisco

                    #region Observações do Contribuinte

                    Printer.ImprimirTexto("Observações do Contribuinte", CmdTamanhoFonte.Condensada, CmdEstiloFonte.Negrito);

                    if (!cfe.InfCFe.InfAdic.InfCpl.IsNull())
                        foreach (var txt in cfe.InfCFe.InfAdic.InfCpl.WrapText(Printer.Colunas))
                            Printer.ImprimirTexto(txt, CmdTamanhoFonte.Condensada);

                    Printer.PularLinhas(1);

                    #endregion Observações do Contribuinte

                    #region Tributos

                    if (ImprimirDeOlhoNoImposto)
                    {
                        Printer.ImprimirTexto(AjustarTextoColunas("Valor aproximado dos Tributos deste Cupom", cfe.InfCFe.Total.VCFeLei12741.ToString("C2", cultura), Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);
                        Printer.ImprimirTexto("(Conforme Lei Fed. 12.741/2012)", CmdTamanhoFonte.Condensada);

                        Printer.ImprimirSeparador();
                    }

                    #endregion Tributos

                    #region Número do extrato

                    Printer.ImprimirTexto($"SAT No. {numeroExtrato}", centralizado);
                    Printer.ImprimirTexto($"Data e Hora {cfe.InfCFe.Ide.DEmi:dd/MM/yyyy} {cfe.InfCFe.Ide.HEmi:HH:mm:ss}", CmdTamanhoFonte.Condensada, centralizado);

                    #endregion Número do extrato

                    #region Chave de Acesso

                    var chave = Regex.Replace(cfe.InfCFe.Id.OnlyNumbers(), ".{4}", "$0 ");

                    if (Printer.Colunas >= 48)
                        Printer.ImprimirTexto(chave, CmdTamanhoFonte.Condensada, CmdAlinhamento.Centro, CmdEstiloFonte.Negrito);
                    else
                    {
                        Printer.ImprimirTexto(chave.Substring(0, 24).Trim(), CmdTamanhoFonte.Condensada, CmdEstiloFonte.Negrito);
                        Printer.ImprimirTexto(chave.Substring(24).Trim(), CmdTamanhoFonte.Condensada, CmdEstiloFonte.Negrito);
                    }

                    if (Printer.Colunas >= 48)
                    {
                        Printer.ImprimirBarcode(cfe.InfCFe.Id.OnlyNumbers().Substring(0, 22), CmdBarcode.CODE128c, CmdAlinhamento.Centro);
                        Printer.ImprimirBarcode(cfe.InfCFe.Id.OnlyNumbers().Substring(22), CmdBarcode.CODE128c, CmdAlinhamento.Centro);
                    }
                    else
                    {
                        Printer.ImprimirBarcode(cfe.InfCFe.Id.OnlyNumbers().Substring(0, 11), CmdBarcode.CODE128c);
                        Printer.ImprimirBarcode(cfe.InfCFe.Id.OnlyNumbers().Substring(11, 11), CmdBarcode.CODE128c);
                        Printer.ImprimirBarcode(cfe.InfCFe.Id.OnlyNumbers().Substring(22, 11), CmdBarcode.CODE128c);
                        Printer.ImprimirBarcode(cfe.InfCFe.Id.OnlyNumbers().Substring(33), CmdBarcode.CODE128c);
                    }

                    if (Printer.Colunas >= 48)
                        Printer.PularLinhas(1);

                    #endregion Chave de Acesso

                    #region QrCode

                    var qrCode = $"{cfe.InfCFe.Id.OnlyNumbers()}|" +
                                 $"{cfe.InfCFe.Ide.DhEmissao:yyyyMMddHHmmss}|" +
                                 $"{cfe.InfCFe.Total.VCFe:0.00}|" +
                                 $"{(cfe.InfCFe.Dest?.CNPJ.IsEmpty() == false ? cfe.InfCFe.Dest.CNPJ : cfe.InfCFe.Dest?.CPF)}|" +
                                 $"{cfe.InfCFe.Ide.AssinaturaQrcode}";

                    Printer.ImprimirQrCode(qrCode, aAlinhamento: centralizado, tamanho: Printer.Colunas >= 48 ? QrCodeModSize.Normal : QrCodeModSize.Pequeno);

                    if (Printer.Colunas >= 48)
                        Printer.PularLinhas(1);

                    #endregion QrCode

                    #region App

                    if (Printer.Colunas >= 48)
                    {
                        Printer.ImprimirTexto("Consulte o QR Code pelo aplicativo \"De olho na nota\"", CmdTamanhoFonte.Condensada, CmdAlinhamento.Centro);
                        Printer.ImprimirTexto("disponível na AppStore (Apple) e PlayStore (Android)", CmdTamanhoFonte.Condensada, CmdAlinhamento.Centro);
                    }
                    else
                    {
                        Printer.ImprimirTexto("Consulte o QR Code pelo aplicativo", CmdTamanhoFonte.Condensada);
                        Printer.ImprimirTexto("\"De olho na nota\" disponível na", CmdTamanhoFonte.Condensada);
                        Printer.ImprimirTexto("AppStore (Apple) e PlayStore (Android)", CmdTamanhoFonte.Condensada);
                    }

                    #endregion App

                    #endregion Rodape

                    break;

                case ExtratoLayOut.Resumido:

                    #region Consumidor

                    var cpofCnpjR = cfe.InfCFe.Dest?.CPF.IsEmpty() == true ? cfe.InfCFe.Dest.CPF.FormataCPF() :
                        cfe.InfCFe.Dest?.CNPJ.IsEmpty() == true ? cfe.InfCFe.Dest.CNPJ.FormataCNPJ() :
                        "000.000.000-00";

                    Printer.ImprimirTexto($"CPF/CNPJ do Consumidor: {cpofCnpjR}", CmdTamanhoFonte.Condensada);
                    Printer.ImprimirTexto($"Razão Social/Nome: {(cfe.InfCFe.Dest?.Nome ?? "CONSUMIDOR")}".LimitarString(Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);

                    Printer.ImprimirSeparador();

                    #endregion Consumidor

                    #region Totais

                    Printer.ImprimirTexto(
                        AjustarTextoColunas("Qtde. total de itens:", cfe.InfCFe.Det.Count.ToString("N0", cultura),
                            Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);
                    Printer.ImprimirTexto(
                        AjustarTextoColunas("Subtotal:", cfe.InfCFe.Total.ICMSTot.VProd.ToString("C2", cultura),
                            Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);

                    if (cfe.InfCFe.Total.ICMSTot.VOutro > 0)
                        Printer.ImprimirTexto(
                            AjustarTextoColunas("Acréscimos:", cfe.InfCFe.Total.ICMSTot.VOutro.ToString("C2", cultura),
                                Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);

                    if (cfe.InfCFe.Total.ICMSTot.VDesc > 0)
                        Printer.ImprimirTexto(
                            AjustarTextoColunas("Descontos:", cfe.InfCFe.Total.ICMSTot.VDesc.ToString("C2", cultura),
                                Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);

                    Printer.ImprimirTexto(
                        AjustarTextoColunas("Valor TOTAL:", cfe.InfCFe.Total.VCFe.ToString("C2", cultura), Printer.Colunas),
                        CmdEstiloFonte.Negrito);

                    #endregion Totais

                    Printer.PularLinhas(1);

                    #region Pagamentos

                    foreach (var pagto in cfe.InfCFe.Pagto.Pagamentos)
                        Printer.ImprimirTexto(
                            AjustarTextoColunas(pagto.CMp.GetDescription(), pagto.VMp.ToString("C2", cultura),
                                Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);

                    Printer.ImprimirTexto(AjustarTextoColunas("Troco:", cfe.InfCFe.Pagto.VTroco.ToString("C2", cultura),
                        Printer.Colunas));
                    Printer.PularLinhas(1);

                    #endregion Pagamentos

                    #region Rodape

                    #region Dados da entrega

                    if (cfe.InfCFe.Entrega != null && !cfe.InfCFe.Entrega.XLgr.IsNull())
                    {
                        Printer.ImprimirTexto("DADOS PARA ENTREGA", centralizado, CmdEstiloFonte.Negrito);
                        Printer.ImprimirTexto($"End.: {cfe.InfCFe.Entrega.XLgr}, {cfe.InfCFe.Entrega.Nro} {cfe.InfCFe.Entrega.XCpl}", CmdTamanhoFonte.Condensada);
                        Printer.ImprimirTexto($"Bairro: {cfe.InfCFe.Entrega.XBairro} - {cfe.InfCFe.Entrega.XMun}/{cfe.InfCFe.Entrega.UF}", CmdTamanhoFonte.Condensada);
                        Printer.ImprimirSeparador();
                    }

                    #endregion Dados da entrega

                    #region Observações do Fisco

                    if (cfe.InfCFe.InfAdic.ObsFisco.Any())
                    {
                        Printer.ImprimirTexto("Observações do Fisco", CmdTamanhoFonte.Condensada, CmdEstiloFonte.Negrito);

                        foreach (var txt in cfe.InfCFe.InfAdic.ObsFisco.Select(fisco => $"{fisco.XCampo} - {fisco.XTexto}").SelectMany(texto => texto.WrapText(Printer.Colunas)))
                        {
                            Printer.ImprimirTexto(txt, CmdTamanhoFonte.Condensada);
                        }

                        Printer.PularLinhas(1);
                    }

                    #endregion Observações do Fisco

                    #region Observações do Contribuinte

                    Printer.ImprimirTexto("Observações do Contribuinte", CmdTamanhoFonte.Condensada, CmdEstiloFonte.Negrito);

                    if (!cfe.InfCFe.InfAdic.InfCpl.IsNull())
                        foreach (var txt in cfe.InfCFe.InfAdic.InfCpl.WrapText(Printer.Colunas))
                            Printer.ImprimirTexto(txt, CmdTamanhoFonte.Condensada);

                    Printer.PularLinhas(1);

                    #endregion Observações do Contribuinte

                    #region Tributos

                    if (ImprimirDeOlhoNoImposto)
                    {
                        Printer.ImprimirTexto(AjustarTextoColunas("Valor aproximado dos Tributos deste Cupom", cfe.InfCFe.Total.VCFeLei12741.ToString("C2", cultura), Printer.ColunasCondensada), CmdTamanhoFonte.Condensada);
                        Printer.ImprimirTexto("(Conforme Lei Fed. 12.741/2012)", CmdTamanhoFonte.Condensada);

                        Printer.ImprimirSeparador();
                    }

                    #endregion Tributos

                    #region Número do extrato

                    Printer.ImprimirTexto($"SAT No. {numeroExtrato}", centralizado);
                    Printer.ImprimirTexto($"Data e Hora {cfe.InfCFe.Ide.DEmi:dd/MM/yyyy} {cfe.InfCFe.Ide.HEmi:HH:mm:ss}", CmdTamanhoFonte.Condensada, centralizado);

                    #endregion Número do extrato

                    #region Chave de Acesso

                    var chaveResumido = Regex.Replace(cfe.InfCFe.Id.OnlyNumbers(), ".{4}", "$0 ");

                    if (Printer.Colunas >= 48)
                        Printer.ImprimirTexto(chaveResumido, CmdTamanhoFonte.Condensada, CmdAlinhamento.Centro, CmdEstiloFonte.Negrito);
                    else
                    {
                        Printer.ImprimirTexto(chaveResumido.Substring(0, 24).Trim(), CmdTamanhoFonte.Condensada, CmdEstiloFonte.Negrito);
                        Printer.ImprimirTexto(chaveResumido.Substring(24).Trim(), CmdTamanhoFonte.Condensada, CmdEstiloFonte.Negrito);
                    }

                    if (Printer.Colunas >= 48)
                    {
                        Printer.ImprimirBarcode(cfe.InfCFe.Id.OnlyNumbers().Substring(0, 22), CmdBarcode.CODE128c, CmdAlinhamento.Centro);
                        Printer.ImprimirBarcode(cfe.InfCFe.Id.OnlyNumbers().Substring(22), CmdBarcode.CODE128c, CmdAlinhamento.Centro);
                    }
                    else
                    {
                        Printer.ImprimirBarcode(cfe.InfCFe.Id.OnlyNumbers().Substring(0, 11), CmdBarcode.CODE128c);
                        Printer.ImprimirBarcode(cfe.InfCFe.Id.OnlyNumbers().Substring(11, 11), CmdBarcode.CODE128c);
                        Printer.ImprimirBarcode(cfe.InfCFe.Id.OnlyNumbers().Substring(22, 11), CmdBarcode.CODE128c);
                        Printer.ImprimirBarcode(cfe.InfCFe.Id.OnlyNumbers().Substring(33), CmdBarcode.CODE128c);
                    }

                    if (Printer.Colunas >= 48)
                        Printer.PularLinhas(1);

                    #endregion Chave de Acesso

                    #region QrCode

                    var qrCodeResumido = $"{cfe.InfCFe.Id.OnlyNumbers()}|" +
                                 $"{cfe.InfCFe.Ide.DhEmissao:yyyyMMddHHmmss}|" +
                                 $"{cfe.InfCFe.Total.VCFe:0.00}|" +
                                 $"{(cfe.InfCFe.Dest?.CNPJ.IsEmpty() == false ? cfe.InfCFe.Dest.CNPJ : cfe.InfCFe.Dest?.CPF)}|" +
                                 $"{cfe.InfCFe.Ide.AssinaturaQrcode}";

                    Printer.ImprimirQrCode(qrCodeResumido, aAlinhamento: centralizado, tamanho: Printer.Colunas >= 48 ? QrCodeModSize.Normal : QrCodeModSize.Pequeno);

                    if (Printer.Colunas >= 48)
                        Printer.PularLinhas(1);

                    #endregion QrCode

                    #region App

                    if (Printer.Colunas >= 48)
                    {
                        Printer.ImprimirTexto("Consulte o QR Code pelo aplicativo \"De olho na nota\"", CmdTamanhoFonte.Condensada, CmdAlinhamento.Centro);
                        Printer.ImprimirTexto("disponível na AppStore (Apple) e PlayStore (Android)", CmdTamanhoFonte.Condensada, CmdAlinhamento.Centro);
                    }
                    else
                    {
                        Printer.ImprimirTexto("Consulte o QR Code pelo aplicativo", CmdTamanhoFonte.Condensada);
                        Printer.ImprimirTexto("\"De olho na nota\" disponível na", CmdTamanhoFonte.Condensada);
                        Printer.ImprimirTexto("AppStore (Apple) e PlayStore (Android)", CmdTamanhoFonte.Condensada);
                    }

                    #endregion App

                    #endregion Rodape

                    break;

                case ExtratoLayOut.Cancelamento:

                    #region Dados do cupom cancelado

                    Printer.ImprimirSeparador();

                    var cpfCNPJCancelado = cFeCanc.InfCFe.Dest?.CPF.IsEmpty() == false ? cFeCanc.InfCFe.Dest.CPF.FormataCPF() :
                                    cFeCanc.InfCFe.Dest?.CNPJ.IsEmpty() == false ? cFeCanc.InfCFe.Dest.CNPJ.FormataCNPJ() :
                                    "000.000.000-00";

                    if (Printer.Colunas >= 48)
                        Printer.ImprimirTexto("DADOS DO CUPOM FISCAL ELETRONICO CANCELADO", CmdAlinhamento.Centro, CmdEstiloFonte.Negrito);
                    else
                    {
                        Printer.ImprimirTexto("DADOS DO CUPOM FISCAL", CmdEstiloFonte.Negrito);
                        Printer.ImprimirTexto("ELETRONICO CANCELADO", CmdEstiloFonte.Negrito);
                    }

                    Printer.ImprimirTexto($"CPF/CNPJ do Consumidor: {cpfCNPJCancelado}", CmdTamanhoFonte.Condensada);
                    Printer.ImprimirTexto(AjustarTextoColunas("Valor total:", cFeCanc.InfCFe.Total.VCFe.ToString("C2", cultura), Printer.ColunasCondensada), CmdTamanhoFonte.Condensada, CmdEstiloFonte.Negrito);

                    if (Printer.Colunas >= 48)
                        Printer.PularLinhas(1);

                    Printer.ImprimirTexto($"SAT No. {cFeCanc.InfCFe.Ide.NSerieSAT:D9}", centralizado);
                    Printer.ImprimirTexto($"Data e Hora {cFeCanc.InfCFe.Ide.DEmi:dd/MM/yyyy} {cFeCanc.InfCFe.Ide.HEmi:HH:mm:ss}", centralizado);

                    #region Chave de Acesso

                    if (Printer.Colunas >= 48)
                        Printer.PularLinhas(1);

                    var chaveCancelado = Regex.Replace(cFeCanc.InfCFe.ChCanc.OnlyNumbers(), ".{4}", "$0 ");

                    if (Printer.Colunas >= 48)
                        Printer.ImprimirTexto(chaveCancelado, CmdTamanhoFonte.Condensada, CmdEstiloFonte.Negrito);
                    else
                    {
                        Printer.ImprimirTexto(chaveCancelado.Substring(0, 24).Trim(), CmdTamanhoFonte.Condensada, CmdEstiloFonte.Negrito);
                        Printer.ImprimirTexto(chaveCancelado.Substring(24).Trim(), CmdTamanhoFonte.Condensada, CmdEstiloFonte.Negrito);
                    }

                    if (Printer.Colunas >= 48)
                    {
                        Printer.ImprimirBarcode(cFeCanc.InfCFe.ChCanc.OnlyNumbers().Substring(0, 22), CmdBarcode.CODE128c, CmdAlinhamento.Centro);
                        Printer.ImprimirBarcode(cFeCanc.InfCFe.ChCanc.OnlyNumbers().Substring(22), CmdBarcode.CODE128c, CmdAlinhamento.Centro);
                    }
                    else
                    {
                        Printer.ImprimirBarcode(cFeCanc.InfCFe.ChCanc.OnlyNumbers().Substring(0, 11), CmdBarcode.CODE128c);
                        Printer.ImprimirBarcode(cFeCanc.InfCFe.ChCanc.OnlyNumbers().Substring(11, 11), CmdBarcode.CODE128c);
                        Printer.ImprimirBarcode(cFeCanc.InfCFe.ChCanc.OnlyNumbers().Substring(22, 11), CmdBarcode.CODE128c);
                        Printer.ImprimirBarcode(cFeCanc.InfCFe.ChCanc.OnlyNumbers().Substring(33), CmdBarcode.CODE128c);
                    }

                    Printer.PularLinhas(1);

                    #endregion Chave de Acesso

                    #region QrCode

                    var qrCodeCancelado = $"{cFeCanc.InfCFe.ChCanc.OnlyNumbers()}|" +
                                  $"{cFeCanc.InfCFe.Ide.DhEmissao:yyyyMMddHHmmss}|" +
                                  $"{cFeCanc.InfCFe.Ide.DhEmissao:0.00}|" +
                                  $"{(cFeCanc.InfCFe.Dest?.CNPJ.IsEmpty() == false ? cFeCanc.InfCFe.Dest.CNPJ : cFeCanc.InfCFe.Dest.CPF)}|" +
                                  $"{cFeCanc.InfCFe.Ide.AssinaturaQrcode}";

                    Printer.ImprimirQrCode(qrCodeCancelado, aAlinhamento: centralizado, tamanho: Printer.Colunas >= 48 ? QrCodeModSize.Normal : QrCodeModSize.Pequeno);

                    if (Printer.Colunas >= 48)
                        Printer.PularLinhas(1);

                    #endregion QrCode

                    #endregion Dados do cupom cancelado

                    #region Dados do cupom cancelado

                    Printer.ImprimirSeparador();

                    if (Printer.Colunas >= 48)
                        Printer.ImprimirTexto("DADOS DO CUPOM FISCAL ELETRONICO DE CANCELAMENTO", CmdEstiloFonte.Negrito);
                    else
                    {
                        Printer.ImprimirTexto("DADOS DO CUPOM FISCAL", CmdEstiloFonte.Negrito);
                        Printer.ImprimirTexto("ELETRONICO DE CANCELAMENTO", CmdEstiloFonte.Negrito);
                    }

                    Printer.ImprimirTexto($"SAT No. {cFeCanc.InfCFe.Ide.NSerieSAT:D9}", centralizado);
                    Printer.ImprimirTexto($"Data e Hora {cFeCanc.InfCFe.Ide.DEmi:dd/MM/yyyy} {cFeCanc.InfCFe.Ide.HEmi:HH:mm:ss}", centralizado);

                    #region Chave de Acesso

                    var chaveCancelada2 = Regex.Replace(cFeCanc.InfCFe.Id.OnlyNumbers(), ".{4}", "$0 ");

                    if (Printer.Colunas >= 48)
                        Printer.ImprimirTexto(chaveCancelada2, CmdTamanhoFonte.Condensada, CmdAlinhamento.Centro, CmdEstiloFonte.Negrito);
                    else
                    {
                        Printer.ImprimirTexto(chaveCancelada2.Substring(0, 22).Trim(), CmdTamanhoFonte.Condensada, CmdEstiloFonte.Negrito);
                        Printer.ImprimirTexto(chaveCancelada2.Substring(22).Trim(), CmdTamanhoFonte.Condensada, CmdEstiloFonte.Negrito);
                    }

                    if (Printer.Colunas >= 48)
                    {
                        Printer.ImprimirBarcode(cFeCanc.InfCFe.Id.OnlyNumbers().Substring(0, 22), CmdBarcode.CODE128c, CmdAlinhamento.Centro);
                        Printer.ImprimirBarcode(cFeCanc.InfCFe.Id.OnlyNumbers().Substring(22), CmdBarcode.CODE128c, CmdAlinhamento.Centro);
                    }
                    else
                    {
                        Printer.ImprimirBarcode(cFeCanc.InfCFe.Id.OnlyNumbers().Substring(0, 11), CmdBarcode.CODE128c);
                        Printer.ImprimirBarcode(cFeCanc.InfCFe.Id.OnlyNumbers().Substring(11, 11), CmdBarcode.CODE128c);
                        Printer.ImprimirBarcode(cFeCanc.InfCFe.Id.OnlyNumbers().Substring(22, 11), CmdBarcode.CODE128c);
                        Printer.ImprimirBarcode(cFeCanc.InfCFe.Id.OnlyNumbers().Substring(33), CmdBarcode.CODE128c);
                    }

                    if (Printer.Colunas >= 48)
                        Printer.PularLinhas(1);

                    #endregion Chave de Acesso

                    #region QrCode

                    var qrCodeCancelado2 = $"{cFeCanc.InfCFe.Id.OnlyNumbers()}|" +
                                        $"{cFeCanc.InfCFe.Ide.DhEmissao:yyyyMMddHHmmss}|" +
                                        $"{cFeCanc.InfCFe.Total.VCFe:0.00}|" +
                                        $"{(cFeCanc.InfCFe.Dest?.CNPJ.IsEmpty() == false ? cFeCanc.InfCFe.Dest.CNPJ : cFeCanc.InfCFe.Dest.CPF)}|" +
                                        $"{cFeCanc.InfCFe.Ide.AssinaturaQrcode}";

                    Printer.ImprimirQrCode(qrCodeCancelado2, aAlinhamento: centralizado, tamanho: Printer.Colunas >= 48 ? QrCodeModSize.Normal : QrCodeModSize.Pequeno);

                    Printer.PularLinhas(1);

                    #endregion QrCode

                    #endregion Dados do cupom cancelado

                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(tipo), tipo, null);
            }

            #region Desenvolvedor

            if (!SoftwareHouse.IsEmpty())
            {
                Printer.ImprimirTexto(SoftwareHouse, Printer.Colunas >= 48 ? CmdAlinhamento.Direita : CmdAlinhamento.Esquerda);
                Printer.PularLinhas(1);
            }

            #endregion Desenvolvedor

            if (CortarPapel)
                Printer.CortarPapel(true);

            Printer.Imprimir(NumeroCopias);
        }

        private static string AjustarTextoColunas(string textoE, string textoR, int colunas)
        {
            var padLenght = colunas - (textoR.Length + 1);
            var textoENew = textoE.Length + 3 >= padLenght ? textoE.Substring(0, padLenght - 3).PadRight(padLenght) : textoE.PadRight(padLenght);
            return textoENew + textoR;
        }

        #endregion Methods
    }
}