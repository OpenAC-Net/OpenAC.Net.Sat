// ***********************************************************************
// Assembly         : OpenAC.Net.Sat.Extrato.FastReport
// Author           : RFTD
// Created          : 06-28-2016
//
// Last Modified By : RFTD
// Last Modified On : 10-26-2018
// ***********************************************************************
// <copyright file="ExtratoEventArgs.cs" company="OpenAC .Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2014 - 2022 Projeto OpenAC .Net
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

namespace OpenAC.Net.Sat.Extrato.FastReport
{
    public class ExtratoEventArgs : EventArgs
    {
        #region Constructors

        public ExtratoEventArgs(ExtratoLayOut tipo)
        {
            Tipo = tipo;
            FilePath = string.Empty;
        }

        #endregion Constructors

        #region Propriedades

        /// <summary>
        /// Retorna o tipo de arquivo necessario.
        /// </summary>
        /// <value>The tipo.</value>
        public ExtratoLayOut Tipo { get; internal set; }

        /// <summary>
        /// Define ou retorna o caminho para o arquivo do FastReport.
        /// </summary>
        /// <value>The file path.</value>
        public string FilePath { get; set; }

        #endregion Propriedades
    }
}