using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CaracteresETextos
{
    internal class Exercicio
    {
        static void Main(string[] args)
        {
            char letra = 'a';
            Console.WriteLine(letra);

            char valor = 65;//Nao compila
            Console.WriteLine(valor);

            valor = (char)(valor + 1);//Compila
            Console.WriteLine(valor);

            string palavra = "alura cursos online de tecnologia";
            Console.WriteLine(palavra);

            palavra = palavra + 2020;
            Console.WriteLine(palavra);

        }
    }
}
