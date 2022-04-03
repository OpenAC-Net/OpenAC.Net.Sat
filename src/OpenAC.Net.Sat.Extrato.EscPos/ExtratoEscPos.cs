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
using OpenAC.Net.DFe.Core.Common;
using OpenAC.Net.EscPos;

namespace OpenAC.Net.Sat.Extrato.EscPos
{
    public sealed class ExtratoEscPos : ExtratoSat
    {
        #region Events

        public EventHandler<EspPosprintEventArgs> GetPrinter;

        #endregion Events

        #region Properties

        public new FiltroDFeReport Filtro
        {
            get => FiltroDFeReport.Nenhum;
            set => throw new NotSupportedException("Filtro não é suportado no extrato EscPos");
        }

        public EscPosPrinter Printer { get; set; }

        public bool DescricaoUmaLinha { get; set; }

        public decimal EspacoFinal { get; set; }

        #endregion Properties

        #region Methods

        public override void ImprimirExtrato(CFe cfe) => throw new NotImplementedException();

        public override void ImprimirExtratoResumido(CFe cfe) => throw new NotImplementedException();

        public override void ImprimirExtratoCancelamento(CFeCanc cFeCanc, DFeTipoAmbiente ambiente) => throw new NotImplementedException();

        #endregion Methods
    }
}