
namespace _07_ByteBank
{
    class ContaCorrente
    {
        public Cliente titular { get; set; }
        public static int TotalDeContasCriadas { get;private set; }//Faz parte da CLASSE
        
        public int agencia { get; set; }
        public int numero { get; set; }
        public double saldo = 100;

        public double Saldo
        {
            get 
            { 
                return saldo; 
            }
            set 
            {
                if (value < 0)
                {
                    return;
                }
                saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)//Construtor
        {
            this.agencia = agencia;
            this.numero = numero;

            TotalDeContasCriadas++;
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