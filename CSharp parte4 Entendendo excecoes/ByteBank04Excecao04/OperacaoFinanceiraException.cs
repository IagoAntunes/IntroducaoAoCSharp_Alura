using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankExcecao04
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {

        }
        public OperacaoFinanceiraException(string mensagem)
            : base(mensagem)
        {

        }
        public OperacaoFinanceiraException(string mensagem, Exception excecaoInerna)
            : base(mensagem, excecaoInerna)
        {

        }
    }
}
