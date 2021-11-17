using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais2");

            int idadeJoao = 18;
            //int quantidadePessoas = 2;
            //bool acompanhado = quantidadePessoas >= 2;

            bool acompanhado = true;

            if (idadeJoao >= 18 && acompanhado)
            {
                Console.WriteLine("Joao Pode entrar");
            }
            else
            {
                Console.WriteLine("Joao nao pode entrar");
            }



            Console.ReadLine();
        }
    }
}
