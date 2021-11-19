using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankExcecao04
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();

            Console.WriteLine("Execução realizada com sucesso");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            LeitorDeArquivos leitor = null;
            try
            {
                leitor = new LeitorDeArquivos("contasç.txt");
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }catch (IOException)
            {
                Console.WriteLine("Excecao do tipo IOExcepton capturada e tratada");
            }
            finally
            {
                if(leitor != null)
                {
                    leitor.Fechar();
                }
                   
            }
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(1234, 667890);
                ContaCorrente conta2 = new ContaCorrente(3456, 67890);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER");
                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }
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
