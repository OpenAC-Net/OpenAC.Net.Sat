// ***********************************************************************
// Assembly         : OpenAC.Net.Sat
// Author           : RFTD
// Created          : 21-10-2021
//
// Last Modified By : RFTD
// Last Modified On : 21-10-2021
// ***********************************************************************
// <copyright file="IExtratoOptions.cs" company="OpenAC .Net">
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

using System.Drawing;
using OpenAC.Net.DFe.Core.Common;

namespace OpenAC.Net.Sat
{
    public interface IExtratoOptions
    {
#if NETFULL
        Image Logo { get; set; }
#else
        byte[] Logo { get; set; }
#endif

        FiltroDFeReport Filtro { get; set; }

        bool MostrarPreview { get; set; }

        bool MostrarSetup { get; set; }

        bool UsarPathPDF { get; set; }

        string Impressora { get; set; }

        int NumeroCopias { get; set; }

        string NomeArquivo { get; set; }

        string SoftwareHouse { get; set; }

        string Site { get; set; }
    }
}