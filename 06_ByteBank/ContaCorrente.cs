
namespace _06_ByteBank
{
    class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100;



        public void DefinirSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }
            this.saldo = saldo;
        }
        public double ObterSaldo()
        {
            return saldo;
        }

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }


    }
}
/*
 * como definir metodos com parametros e retornos
 * como retornar algo usando a palavra chave return antes da expressao do resultado;
 * o uso do return para retornar antecipadamente a execução de um metodo
 * como usar a referencia this para acessar um atributo
 * qque podemos passar uma referencia como parametro do metodo
 * metodos soa chamadas a partir da referencia usando o operador
 */