using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using SistemaAgencia04.Extensoes;

namespace SistemaAgencia04
{
    public class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(123,456789),
                new ContaCorrente(345,456789),
                new ContaCorrente(164,456789),
                new ContaCorrente(986,456789)
            };
            contas.Sort();

            foreach (var conta in contas)
            {
                Console.WriteLine($"Conta numero {conta.Numero},ag:{conta.Agencia}");
            }


    

            Console.ReadLine();
        }
        static void TestaSorte()
        {
            var idades = new List<int>();
            var nomes = new List<string>()
            {
                "Joao,"
                + "Luana,"
                + "Wellington,"
                + "Ana"
            };


            idades.Add(5);
            idades.Add(23);

            idades.AdicionarVarios(23, 40, 52, 12);
            idades.AdicionarVarios(99, -1);

            idades.Sort();
            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }


            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine($"Idade Atual:{idades[i]}");
            }
        }
    }
    
}
/*public static void EscreverNaTela(this object obj){
 * Console.WriteLine(obj)
 * }
 * 1.EscreverNaTela()
 * "teste".EscreverNaTela()
 */
/*01
 * O tipo List<T> do .NEet
 * Como criar metodos da Extensao
 */
/*02
 * Como criar metodos genericos
 * como criar metodos de extensao genericos
 * como o compilar encontra os metodos de xtensao
 */
/*03
 * A interferencia de variaveis locais com o var
 * Sintaxe de inicialização de listas
 * O metodo Sort*/
