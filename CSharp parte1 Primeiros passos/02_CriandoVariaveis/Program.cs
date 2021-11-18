using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {//03 Variaveis Numericas
            Console.WriteLine("Executando projeto 2 - Criando variaveis");

            int idade;
            idade = 32;

            Console.WriteLine(idade);
            idade = 10;
            Console.WriteLine(idade);
            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.Write("Sua idade é: " + idade + "!");//Concatenação


            Console.WriteLine("Execicação finalizada.Tecle enter para sair. . .");
            Console.ReadLine();
        }
    }
}
