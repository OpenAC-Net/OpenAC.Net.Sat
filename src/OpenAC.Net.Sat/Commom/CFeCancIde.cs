// ***********************************************************************
// Assembly         : OpenAC.Net.Sat
// Author           : RFTD
// Created          : 05-11-2016
//
// Last Modified By : RFTD
// Last Modified On : 05-11-2016
// ***********************************************************************
// <copyright file="CFeCancIde.cs" company="OpenAC .Net">
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
using System.ComponentModel;
using OpenAC.Net.Core.Extensions;
using OpenAC.Net.Core.Generics;
using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Common;
using OpenAC.Net.DFe.Core.Serializer;

namespace OpenAC.Net.Sat
{
    /// <summary>
    /// Class CFeCancIde. This class cannot be inherited.
    /// </summary>
    public sealed class CFeCancIde : GenericClone<CFeCancIde>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CFeIde" /> class.
        /// </summary>
        public CFeCancIde()
        {
            DhEmissao = null;
            SignAC = string.Empty;
        }

        #endregion Constructors

        #region Propriedades

        /// <summary>
        /// Gets or sets the c uf.
        /// </summary>
        /// <value>The c uf.</value>
        [DFeElement(TipoCampo.Enum, "cUF", Id = "B02", Min = 2, Max = 2, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public DFeCodUF? UF { get; set; }

        /// <summary>
        /// Gets or sets the c nf.
        /// </summary>
        /// <value>The c nf.</value>
        [DFeElement(TipoCampo.Int, "cNF", Id = "B03", Min = 6, Max = 6, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public int CNf { get; set; }

        /// <summary>
        /// Gets or sets the modelo.
        /// </summary>
        /// <value>The modelo.</value>
        [DFeElement(TipoCampo.Int, "mod", Id = "B04", Min = 2, Max = 2, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public int Modelo { get; set; }

        /// <summary>
        /// Gets or sets the nserie sat.
        /// </summary>
        /// <value>The nserie sat.</value>
        [DFeElement(TipoCampo.Int, "nserieSAT", Id = "B05", Min = 9, Max = 9, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public int NSerieSAT { get; set; }

        /// <summary>
        /// Gets or sets the n c fe.
        /// </summary>
        /// <value>The n c fe.</value>
        [DFeElement(TipoCampo.Int, "nCFe", Id = "B06", Min = 6, Max = 6, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public int NCFe { get; set; }

        /// <summary>
        /// A data e a hora da emiss�o na CFe
        /// </summary>
        /// <value>The dh emissao.</value>
        [DFeIgnore]
        public DateTime? DhEmissao { get; set; }

        /// <summary>
        /// Gets or sets the d emi.
        /// </summary>
        /// <value>The d emi.</value>
        [DFeElement(TipoCampo.DatCFe, "dEmi", Id = "B07", Min = 8, Max = 8, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public DateTime DEmi
        {
            get => DhEmissao ?? DateTime.MinValue;
            set => DhEmissao = value.Date + (DhEmissao?.TimeOfDay ?? DateTime.MinValue.TimeOfDay);
        }

        /// <summary>
        /// Gets or sets the h emi.
        /// </summary>
        /// <value>The h emi.</value>
        [DFeElement(TipoCampo.HorCFe, "hEmi", Id = "B08", Min = 6, Max = 6, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public DateTime HEmi
        {
            get => DhEmissao ?? DateTime.MinValue;
            set => DhEmissao = (DhEmissao?.Date ?? DateTime.MinValue.Date) + value.TimeOfDay;
        }

        /// <summary>
        /// Gets or sets the c dv.
        /// </summary>
        /// <value>The c dv.</value>
        [DFeElement(TipoCampo.Int, "cDV", Id = "B09", Min = 1, Max = 1, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public int CDv { get; set; }

        /// <summary>
        /// Gets or sets the CNPJ.
        /// </summary>
        /// <value>The CNPJ.</value>
        [DFeElement(TipoCampo.StrNumberFill, "CNPJ", Id = "B11", Min = 14, Max = 14, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string CNPJ { get; set; }

        /// <summary>
        /// Gets or sets the sign ac.
        /// </summary>
        /// <value>The sign ac.</value>
        [DFeElement(TipoCampo.Str, "signAC", Id = "B12", Min = 1, Max = 344, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string SignAC { get; set; }

        /// <summary>
        /// Gets or sets the assinatura qrcode.
        /// </summary>
        /// <value>The assinatura qrcode.</value>
        [DFeElement(TipoCampo.Str, "assinaturaQRCODE", Id = "B13", Min = 344, Max = 344, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string AssinaturaQrcode { get; set; }

        /// <summary>
        /// Gets or sets the numero caixa.
        /// </summary>
        /// <value>The numero caixa.</value>
        [DFeElement(TipoCampo.Int, "numeroCaixa", Id = "B14", Min = 3, Max = 3, Ocorrencia = Ocorrencia.Obrigatoria)]
        public int NumeroCaixa { get; set; }

        #endregion Propriedades

        #region Methods

        /// <summary>
        /// Shoulds the serialize d emi.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool ShouldSerializeDEmi()
        {
            return DhEmissao.HasValue;
        }

        /// <summary>
        /// Shoulds the serialize h emi.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool ShouldSerializeHEmi()
        {
            return DhEmissao.HasValue;
        }

        /// <summary>
        /// Shoulds the serialize assinatura qrcode.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool ShouldSerializeAssinaturaQrcode()
        {
            return !AssinaturaQrcode.IsEmpty();
        }

        #endregion Methods
    }
}