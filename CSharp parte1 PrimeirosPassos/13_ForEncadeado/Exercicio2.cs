using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ForEncadeado
{
    internal class Exercicio2
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
