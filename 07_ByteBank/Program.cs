using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            //ContaCorrente.TotalDeContasCriadas = 1000;

            ContaCorrente conta = new ContaCorrente(867,86712540);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            //ContaCorrente.TotalDeContasCriadas++;

            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);
            //ContaCorrente.TotalDeContasCriadas++;

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
