using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exeutando projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;
            while(contadorMes <= 12)
            {//teste
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após "+contadorMes+" mes, você tera R$" + valorInvestido);
                contadorMes++;
                Console.WriteLine("Testeee");
            }
            

            /*0,36 = 0,0036%
            valorInvestido = valorInvestido + (valorInvestido * 0.0036);
            Console.WriteLine("Após 1 mes, você tera R$" + valorInvestido);

            valorInvestido = valorInvestido + (valorInvestido * 0.0036);
            Console.WriteLine("Apos 2 mes , voce tera " + valorInvestido);
            */
            Console.ReadLine();
        }
    }
}
