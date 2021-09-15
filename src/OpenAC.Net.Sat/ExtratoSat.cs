// ***********************************************************************
// Assembly         : OpenAC.Net.Sat
// Author           : RFTD
// Created          : 03-31-2016
//
// Last Modified By : RFTD
// Last Modified On : 02-16-2017
// ***********************************************************************
// <copyright file="ExtratoSat.cs" company="OpenAC .Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Projeto OpenAC .Net
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
using System.Drawing;
using System.Globalization;
using OpenAC.Net.Core.Extensions;
using OpenAC.Net.DFe.Core.Common;

namespace OpenAC.Net.Sat
{
    public abstract class ExtratoSat : DFeReportClass<OpenSat>
    {
        #region Propriedades

        public ExtratoLayOut LayOut { get; set; }

#if NETFULL
        public Image Logo { get; set; }

#else
        public byte[] Logo { get; set; }
#endif

        #endregion Propriedades

        #region Methods

        public string CalcularConteudoQRCode(string id, DateTime dhEmissao, decimal valor, string cpfcnpj, string assinaturaQrcode)
        {
            return $"{id}|{dhEmissao:yyyyMMddHHmmss}|{valor.ToString(CultureInfo.InvariantCulture)}" +
                   $"|{cpfcnpj.OnlyNumbers()}|{assinaturaQrcode}";
        }

        public abstract void ImprimirExtrato(CFe cfe);

        public abstract void ImprimirExtratoResumido(CFe cfe);

        public abstract void ImprimirExtratoCancelamento(CFeCanc cFeCanc, DFeTipoAmbiente ambiente);

        /// <inheritdoc />
        protected override void ParentChanged(OpenSat oldParent, OpenSat newParent)
        {
            if (oldParent != null && oldParent.Extrato == this) oldParent.Extrato = null;
            if (newParent != null && newParent.Extrato != this) newParent.Extrato = this;
        }

        #endregion Methods
    }
}