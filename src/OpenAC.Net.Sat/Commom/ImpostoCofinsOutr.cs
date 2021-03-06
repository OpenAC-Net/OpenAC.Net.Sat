// ***********************************************************************
// Assembly         : OpenAC.Net.Sat
// Author           : RFTD
// Created          : 04-29-2016
//
// Last Modified By : RFTD
// Last Modified On : 05-02-2016
// ***********************************************************************
// <copyright file="ImpostoCOFINSOutr.cs" company="OpenAC .Net">
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

using System.ComponentModel;
using OpenAC.Net.Core.Generics;
using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;
using OpenAC.Net.Sat.Interfaces;

namespace OpenAC.Net.Sat
{
    /// <summary>
    /// Class ImpostoCOFINSOutr. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="ICFeCofins" />
    public sealed class ImpostoCofinsOutr : GenericClone<ImpostoCofinsOutr>, ICFeCofins
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Propriedades

        /// <summary>
        /// Gets or sets the Cst.
        /// </summary>
        /// <value>The Cst.</value>
        [DFeElement(TipoCampo.Str, "CST", Id = "Q07", Min = 2, Max = 2, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string CST { get; set; }

        /// <summary>
        /// Gets or sets the q bc product.
        /// </summary>
        /// <value>The q bc product.</value>
        [DFeElement(TipoCampo.De4, "qBCProd", Id = "S11", Min = 1, Max = 16, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal QBcProd { get; set; }

        /// <summary>
        /// Gets or sets the v aliq product.
        /// </summary>
        /// <value>The v aliq product.</value>
        [DFeElement(TipoCampo.De4, "vAliqProd", Id = "S12", Min = 5, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VAliqProd { get; set; }

        /// <summary>
        /// Gets or sets the v bc.
        /// </summary>
        /// <value>The v bc.</value>
        [DFeElement(TipoCampo.De2, "vBC", Id = "S08", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VBc { get; set; }

        /// <summary>
        /// Gets or sets the p pis.
        /// </summary>
        /// <value>The p pis.</value>
        [DFeElement(TipoCampo.De4, "pCOFINS", Id = "S09", Min = 5, Max = 5, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal PCofins { get; set; }

        /// <summary>
        /// Gets or sets the v pis.
        /// </summary>
        /// <value>The v pis.</value>
        [DFeElement(TipoCampo.De2, "vCOFINS", Id = "S10", Min = 1, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VCofins { get; set; }

        #endregion Propriedades

        #region Methods

        /// <summary>
        /// Shoulds the serialize v bc.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool ShouldSerializeVBc()
        {
            return VAliqProd == 0;
        }

        /// <summary>
        /// Shoulds the serialize ppis.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool ShouldSerializePCofins()
        {
            return VAliqProd == 0;
        }

        #endregion Methods
    }
}