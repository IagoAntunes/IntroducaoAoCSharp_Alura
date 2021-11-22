using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "paginas?argumentos";
            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);

            string argumentos = url.Substring(indiceInterrogacao);

            Console.WriteLine(argumentos);


            Console.ReadLine();
        }
    }
}
/*
 * No c# e .NET strings sao imutaveis
 * Podemos criar uma nova string a partir da porção de outra , com o metodo Substring;
 */