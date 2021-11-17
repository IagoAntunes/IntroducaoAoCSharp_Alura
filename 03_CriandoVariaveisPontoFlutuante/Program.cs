using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Executando projeto 3 Criando variaveis ponto flutuante");

            Double salario;
            salario = 1200.70;

            Console.WriteLine(salario);

            double idade;
            idade = 15 / 2.0;
            Console.WriteLine(idade);

            idade = 5 / 3;//resto Inteiro
            Console.WriteLine("5 / 3 = "+ idade);

            idade = 5.0 / 3;//resto Double
            Console.WriteLine("5 / 3 = " + idade);

            Console.WriteLine("A execução terminou tecle 'Enter' para sair. . .");
            Console.ReadLine();
        }
    }
}
