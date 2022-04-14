// ***********************************************************************
// Assembly         : OpenAC.Net.Sat.Extrato.EscPos
// Author           : Rafael Dias
// Created          : 03-04-2022
//
// Last Modified By : Rafael Dias
// Last Modified On : 03-04-2022
// ***********************************************************************
// <copyright file="StringExtensions.cs" company="OpenAC .Net">
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
using System.Linq;
using OpenAC.Net.Core.Extensions;
using OpenAC.Net.EscPos;
using OpenAC.Net.EscPos.Commom;

namespace OpenAC.Net.Sat.Extrato.EscPos
{
    internal static class StringExtensions
    {
        public static string[] WrapText(this string text, int max)
        {
            if (string.IsNullOrEmpty(text))
                return new[] { text };

            if (max == 0)
                return new[] { text };

            var charCount = 0;
            var lines = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return lines.GroupBy(w => (charCount += (charCount % max + w.Length + 1 >= max
                    ? max - charCount % max : 0) + w.Length + 1) / max)
                .Select(g => string.Join(" ", g.ToArray()))
                .ToArray();
        }

        public static string LimitarString(this string txt, int length)
        {
            if (txt.IsEmpty())
                return string.Empty;

            return txt.Length < length ? txt : txt.Substring(0, length);
        }

        public static void ImprimirSeparador(this EscPosPrinter printer, char charLinha = '-') => printer.ImprimirTexto(new string(charLinha, printer.ColunasCondensada), CmdTamanhoFonte.Condensada);
    }
}