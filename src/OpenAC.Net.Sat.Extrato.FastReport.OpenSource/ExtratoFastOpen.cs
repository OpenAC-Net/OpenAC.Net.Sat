// ***********************************************************************
// Assembly         : OpenAC.Net.Sat.Extrato.FastReport.OpenSource
// Author           : RFTD
// Created          : 06-28-2016
//
// Last Modified By : RFTD
// Last Modified On : 10-26-2018
// ***********************************************************************
// <copyright file="ExtratoFastOpen.cs" company="OpenAC .Net">
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
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using FastReport;
using FastReport.Export.Html;
using FastReport.Export.PdfSimple;
using OpenAC.Net.Core;
using OpenAC.Net.Core.Extensions;
using OpenAC.Net.DFe.Core;
using OpenAC.Net.DFe.Core.Common;

namespace OpenAC.Net.Sat.Extrato.FastReport.OpenSource
{
    public sealed class ExtratoFastOpen : ExtratoSat<ExtratoFastOpentOptions>
    {
        #region Fields

        private Report internalReport;
        private PrinterSettings settings;

        #endregion Fields

        #region Constructors

        public ExtratoFastOpen()
        {
            Configuracoes = new ExtratoFastOpentOptions();
        }

        #endregion Constructors

        #region Events

        public event EventHandler<ExtratoEventArgs> OnGetExtrato;

        #endregion Events

        #region Methods

        public override void ImprimirExtrato(CFe cfe)
        {
            PrepararImpressao(ExtratoLayOut.Completo, cfe.InfCFe.Ide.TpAmb ?? DFeTipoAmbiente.Homologacao);
            internalReport.RegisterData(new[] { cfe }, "CFe");
            Imprimir();
        }

        public override void ImprimirExtratoResumido(CFe cfe)
        {
            PrepararImpressao(ExtratoLayOut.Resumido, cfe.InfCFe.Ide.TpAmb ?? DFeTipoAmbiente.Homologacao);
            internalReport.RegisterData(new[] { cfe }, "CFe");
            Imprimir();
        }

        public override void ImprimirExtratoCancelamento(CFe cfe, CFeCanc cFeCanc)
        {
            PrepararImpressao(ExtratoLayOut.Cancelamento, cfe.InfCFe.Ide.TpAmb ?? DFeTipoAmbiente.Homologacao);
            internalReport.RegisterData(new[] { cfe }, "CFe");
            internalReport.RegisterData(new[] { cFeCanc }, "CFeCanc");
            Imprimir();
        }

        private void Imprimir()
        {
            internalReport.Prepare();

            switch (Configuracoes.Filtro)
            {
                case FiltroDFeReport.Nenhum:
                    if (Configuracoes.MostrarPreview)
                        internalReport.Show();
                    else if (Configuracoes.MostrarSetup)
                        internalReport.PrintWithDialog();
                    else
                        internalReport.Print(settings);
                    break;

                case FiltroDFeReport.PDF:
                    var pdfExport = new PDFSimpleExport()
                    {
                        ShowProgress = Configuracoes.MostrarSetup,
                        OpenAfterExport = Configuracoes.MostrarPreview
                    };

                    internalReport.Export(pdfExport, Configuracoes.NomeArquivo);
                    break;

                case FiltroDFeReport.HTML:
                    var htmlExport = new HTMLExport
                    {
                        Format = HTMLExportFormat.MessageHTML,
                        EmbedPictures = true,
                        Preview = Configuracoes.MostrarPreview,
                        ShowProgress = Configuracoes.MostrarSetup
                    };

                    internalReport.Export(htmlExport, Configuracoes.NomeArquivo);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            internalReport.Dispose();
            internalReport = null;
        }

        private void PrepararImpressao(ExtratoLayOut tipo, DFeTipoAmbiente ambiente)
        {
            internalReport = new Report();

            var e = new ExtratoEventArgs(tipo);
            OnGetExtrato.Raise(this, e);
            if (e.FilePath.IsEmpty() || !File.Exists(e.FilePath))
            {
                var assembly = Assembly.GetExecutingAssembly();

                Stream ms;
                switch (tipo)
                {
                    case ExtratoLayOut.Completo:
                    case ExtratoLayOut.Resumido:
                        ms = assembly.GetManifestResourceStream("OpenAC.Net.Sat.Extrato.FastReport.OpenSource.Extrato.ExtratoSat.frx");
                        break;

                    case ExtratoLayOut.Cancelamento:
                        ms = assembly.GetManifestResourceStream("OpenAC.Net.Sat.Extrato.FastReport.OpenSource.Extrato.ExtratoSatCancelamento.frx");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(tipo), tipo, null);
                }

                Guard.Against<OpenDFeException>(ms == null, "N�o foi possivel carregar o relatorio para impress�o.");

                internalReport.Load(ms);
            }
            else
            {
                internalReport.Load(e.FilePath);
            }

            internalReport.SetParameterValue("Logo", Configuracoes.Logo);
            internalReport.SetParameterValue("IsResumido", tipo == ExtratoLayOut.Resumido);
            internalReport.SetParameterValue("IsOneLine", Configuracoes.DescricaoUmaLinha);
            internalReport.SetParameterValue("EspacoFinal", Configuracoes.EspacoFinal);
            internalReport.SetParameterValue("Ambiente", ambiente);

            settings = new PrinterSettings { Copies = (short)Math.Max(Configuracoes.NumeroCopias, 1) };

            if (!Configuracoes.Impressora.IsEmpty())
                settings.PrinterName = Configuracoes.Impressora;
        }

        #endregion Methods
    }
}