using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgencia03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            



         

            Console.ReadLine();
        }
        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ContaCorrente03 contaDoGui = new ContaCorrente03(546, 567908);

            lista.Adicionar(contaDoGui);
            lista.Adicionar(new ContaCorrente03(874, 5679787));
            lista.Adicionar(new ContaCorrente03(874, 5679754));

            ContaCorrente03[] contas = new ContaCorrente03[]
            {
                contaDoGui,
                new ContaCorrente03(874, 5679787),
                new ContaCorrente03(874, 5679754)
            };

            lista.AdicionaVarios(contas);

            lista.AdicionaVarios(
                contaDoGui,
                new ContaCorrente03(874, 5679787),
                new ContaCorrente03(874, 5679754)
            );


            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente03 itemAtual = lista[i];
                Console.WriteLine($"Item na posicao {i} = {itemAtual.numero}");
            }
            lista.Remover(contaDoGui);
        }
        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach(int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaArrayDeContaCorrrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
{
                new ContaCorrente(876, 345777),
                new ContaCorrente(123, 123123),
                new ContaCorrente(456, 123987)
};
            //contas[0] = new ContaCorrente(876, 345777);
            //contas[1] = new ContaCorrente(123, 123123);
            //contas[2] = new ContaCorrente(456, 123987);

            for (int indice = 0; indice < contas.Length; indice++)
            {
                Console.WriteLine($"Conta {indice} {contas[indice].Numero}");
            }
        }
        static void TestaArrayInt()
        {
            int[] idades = new int[6];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;
            idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];
                Console.WriteLine($"Acessando o array idades no indice {indice}");
                Console.WriteLine($"Valor de idades{indice} =  {idade}");
                acumulador += idade;
            }
            int media = acumulador / idades.Length;
            Console.WriteLine($"Media de idades = {media}");




            //int[] outroArray = idades;
            //Console.WriteLine(outroArray[3]);
        }
    }
}
/*01
 * Sintaxe de criação de variaveis de array
 * O valor padrao é utilizado em todas as posições de um array ao ser criado
 * A propriedade Lenght de arrays
 * A sintaxe de inicialização de array new int[]{5,12,64};8/
 */
/*02
 * Mais logica com arrays
 * Argumentos opcionais
 * Argumentos nomeados*/
/*03
 * Mais logica com arrays
 * Como implementar o metodo Remover
 * Como iterar por intervalos especificos de um array
 */
/*04
 * Como criar indexadores
 * Como criar um argumento params
 * O foreach*/