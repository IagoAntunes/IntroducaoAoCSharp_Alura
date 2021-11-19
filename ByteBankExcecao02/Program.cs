using ByteBankExcecao02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankExcecao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(0,0);
            }
            catch (ArgumentException ex)
            {
                if(ex.ParamName == "numero") { }
                Console.WriteLine("Argumentocom problema:" + ex.ParamName);
                Console.WriteLine("Ocorre uma excecao do tipo Argument");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
            }catch(NullReferenceException ex)
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
