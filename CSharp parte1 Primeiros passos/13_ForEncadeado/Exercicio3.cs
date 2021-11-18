using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ForEncadeado
{
    internal class Exercicio3
    {
        static void Main(string[] args)
        {
            int sum=0;
            for(int n = 1; n < 10; n++)
            {
                for(int i = n; i > 1; i--)
                {
                    sum = sum * i;
                    Console.WriteLine(sum);
                }
            }
            //A sintaxe do while e for
            // o operador +=
            //O operador ++;
            //Laços aninhados;
            //A funcionalidade do break


        }
    }
}
