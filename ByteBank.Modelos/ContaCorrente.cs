using System;

namespace ByteBank.Modelos
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public Cliente Titular { get; set; }
        
        public static int TotalDeContasCriadas { get;private set; }//Faz parte da CLASSE
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }
        
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

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }
        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor invalido para o SAQUE.",nameof(valor));
            }
            if (saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            else
            {
                saldo -= valor;      
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferencia.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação nao realizada",ex);
            }
            contaDestino.Depositar(valor);
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