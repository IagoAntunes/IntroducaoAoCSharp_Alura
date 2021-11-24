using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAgencia04.Extensoes;

namespace SistemaAgencia04
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            idades.Add(5);
            idades.Add(23);


            idades.AdicionarVarios(23, 40, 52, 12);
            

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine($"Idade Atual:{idades[i]}");
            }

            Console.ReadLine();
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
