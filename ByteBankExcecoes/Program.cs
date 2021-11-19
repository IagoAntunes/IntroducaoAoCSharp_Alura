using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }catch (NullReferenceException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Aconteceu um erro!");
            }
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
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisao de 10 por " + divisor + " =" + resultado);
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Nao e possivel fazer divisao por 0");
            }

        }
        private static int Dividir(int numero,int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.saldo);
            return numero / divisor;
        }
    }
}
/*01
 * Como funciona a pilha de chamadas (CallStack) no .NET
 * Propagar erros com retorno de metodos nao é correto
 * Pordemos usar as exceções do .NET
 * Para tratar exceções do .NET , basta usar os blocos try/catch
 * As exceções sao representadas por objetos e duas propriedades importantes sao
 * a Message e StackTrace*/
