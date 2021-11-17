using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            //valores ate 32bits int -2^31   <-->   2^31
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;//CAST
            Console.WriteLine(salarioEmInteiro);

            
            long idade;//64bits
            idade = 100000000000;
            Console.WriteLine(idade);

            short quantidadeProdutos;//16bits
            quantidadeProdutos = 17000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);


            Console.ReadLine();
        }
    }
}
