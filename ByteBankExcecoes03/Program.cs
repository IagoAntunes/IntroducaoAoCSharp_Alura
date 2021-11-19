using ByteBankExcecao03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankExcecoes03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(456,4578420);
                ContaCorrente conta2 = new ContaCorrente(123, 345678);
                conta2.Transferir(-10, conta);

                conta.Depositar(50);
                Console.WriteLine(conta.saldo);
                conta.Sacar(-500);
            }
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "numero") { }
                Console.WriteLine("Argumento com problema:" + ex.ParamName);
                Console.WriteLine("Ocorre uma excecao do tipo Argument");
                Console.WriteLine(ex.Message);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Excecao do tipo SaldoInsuficienteException");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("QUER VE");
            }
            //Metodo();

            Console.WriteLine("Execução realizada com sucesso");
            Console.ReadLine();
        }
        private static void Metodo()
        {
            TestaDivisao(0);
        }
        private static void TestaDivisao(int divisor)
        {
            try
            {
                Dividir(10, divisor);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Fui capturea pelo");
                Console.WriteLine(ex.StackTrace);
            }
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisao de 10 por " + divisor + " =" + resultado);
        }
        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Fazendo o calculo" + numero + "/ " + divisor);
                throw;
                Console.WriteLine("Depois do throw");
            }
        }
    }
}
/*04
 * Convenções de nomeação de exceções
 * Construtores comuns de exceções
 * Como criar uma excecção mais rica.
 */
