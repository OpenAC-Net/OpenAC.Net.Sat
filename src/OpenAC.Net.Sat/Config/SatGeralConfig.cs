﻿// ***********************************************************************
// Assembly         : OpenAC.Net.Sat
// Author           : RFTD
// Created          : 31-03-2016
//
// Last Modified By : RFTD
// Last Modified On : 23-10-2021
// ***********************************************************************
// <copyright file="SatGeralConfig.cs" company="OpenAC .Net">
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

using OpenAC.Net.DFe.Core.Common;

namespace OpenAC.Net.Sat
{
    /// <summary>
    /// Classe com as configurações do SAT.
    /// </summary>
    public sealed class SatGeralConfig
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SatGeralConfig"/> class.
        /// </summary>
        public SatGeralConfig()
        {
            InfCFeVersaoDadosEnt = 0.07M;
            IdeCNPJ = @"11111111111111";
            IdeNumeroCaixa = 1;
            IdeTpAmb = DFeTipoAmbiente.Homologacao;
            EmitCNPJ = @"11111111111111";
            EmitIE = string.Empty;
            EmitIM = string.Empty;
            EmitCRegTrib = RegTrib.Normal;
            EmitCRegTribISSQN = RegTribIssqn.Nenhum;
            EmitIndRatISSQN = RatIssqn.Nao;
            IsUtf8 = false;
            ValidarNumeroSessaoResposta = false;
            NumeroTentativasValidarSessao = 1;
        }

        #endregion Constructor

        #region Propriedades
        
        public decimal InfCFeVersaoDadosEnt { get; set; }

        public string IdeCNPJ { get; set; }

        public int IdeNumeroCaixa { get; set; }

        public DFeTipoAmbiente IdeTpAmb { get; set; }

        public string EmitCNPJ { get; set; }

        public string EmitIE { get; set; }

        public string EmitIM { get; set; }

        public RegTrib EmitCRegTrib { get; set; }

        public RegTribIssqn EmitCRegTribISSQN { get; set; }

        public RatIssqn EmitIndRatISSQN { get; set; }

        public bool IsUtf8 { get; set; }

        public bool ValidarNumeroSessaoResposta { get; set; }

        public int NumeroTentativasValidarSessao { get; set; }

        public bool RemoverAcentos { get; set; }

        #endregion Propriedades
    }
}