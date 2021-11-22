using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(456, 123321);
            Console.WriteLine(conta.saldo);

            Console.ReadLine();
        }
    }
}
/*Como referenciar .DLLS e nao depender do codigo fonte de outras bibliotecas*/
