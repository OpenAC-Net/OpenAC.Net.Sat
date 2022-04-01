// ***********************************************************************
// Assembly         : OpenAC.Net.Sat
// Author           : RFTD
// Created          : 06-28-2016
//
// Last Modified By : RFTD
// Last Modified On : 10-26-2018
// ***********************************************************************
// <copyright file="CodigoMPExtensions.cs" company="OpenAC .Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2014 - 2021 Projeto OpenAC .Net
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

namespace OpenAC.Net.Sat.Extensions
{
    public static class CodigoMPExtensions
    {
        public static string Descricao(this CodigoMP codigo)
        {
            switch (codigo)
            {
                case CodigoMP.Dinheiro: return "Dinheiro";
                case CodigoMP.Cheque: return "Cheque";
                case CodigoMP.CartaodeCredito: return "Cartão de Crédito";
                case CodigoMP.CartaodeDebito: return "Cartão de Débito";
                case CodigoMP.CreditoLoja: return "Crédito Loja";
                case CodigoMP.ValeAlimentacao: return "Vale Alimentação";
                case CodigoMP.ValeRefeicao: return "Vale Refeição";
                case CodigoMP.ValePresente: return "Vale Presente";
                case CodigoMP.ValeCombustivel: return "Vale Combustível";
                case CodigoMP.BoletoBancario: return "Boleto Bancário";
                case CodigoMP.DepositoBancario: return "Depósito Bancário";
                case CodigoMP.PIX: return "PIX";
                case CodigoMP.TransferenciaBancaria: return "Transferência Bancária";
                case CodigoMP.ProgramaFidelidade: return "Programa Fidelidade";
                case CodigoMP.SemPagamento: return "Sem Pagamento";
                default: return "Outros";
            }
        }
    }
}