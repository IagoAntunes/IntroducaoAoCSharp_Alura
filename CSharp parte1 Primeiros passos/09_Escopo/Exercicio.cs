using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Escopo
{
    internal class Exercicio
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario < 2600.0)
                Console.WriteLine("A sua aliquota é de 15%");
                Console.WriteLine("Voce pode reduzir ate R$ 350");
           
            if (salario < 3750.0)
                Console.WriteLine("A sua aliquota é de 22,5%");
                Console.WriteLine("Voce pode deduzir ate R$636");

            //Como usar o if
            //Como usar as operações logicas AND
            //Trabalhar com o escopo de variaveis
        }
    }
}
   
