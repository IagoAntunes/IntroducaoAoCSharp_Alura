
using System;

namespace ByteBankExcecao02
{
    class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public Cliente titular { get; set; }
        public static int TotalDeContasCriadas { get;private set; }//Faz parte da CLASSE
        public int Agencia { get;}
        public int Numero { get; }

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
            if(agencia <= 0)
            {
                string teste = nameof(agencia);//String numeroAgencia
                throw new ArgumentException("A agencia deve ser maior que 0",nameof(agencia));
            }if(numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0",nameof(numero));
            }
            Agencia = agencia;
            Numero = numero;

            TaxaOperacao = 30 / TotalDeContasCriadas;

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
/*01
 * como definir metodos com parametros e retornos
 * como retornar algo usando a palavra chave return antes da expressao do resultado;
 * o uso do return para retornar antecipadamente a execução de um metodo
 * como usar a referencia this para acessar um atributo
 * qque podemos passar uma referencia como parametro do metodo
 * metodos soa chamadas a partir da referencia usando o operador
 */
/*
 * 02
 * O bloco try pode acompanhar varios blocos catch
 * A CLR visita os blocos catch em ordem , de cima para baixo.Por esta razaão
 * os tipos de exceção mais especificos devem estar no começo
 * A instrução throw dentro de um bloc ocatch relança uma exceção*/

/*03
 * Capos somente leitura com o modificador readonly;
 * Propriedades somente leitura , com omissao do setter
 * O operador nameof();
 * A classe de exceção ArgumentException , seus construtores e propriedades
 */