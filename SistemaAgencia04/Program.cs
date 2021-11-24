using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgencia04
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            idades.Add(5);
            idades.Add(23);

            int idadeSoma = 0;

            //ListExtensoes.AdicionarVarios(idades, 1, 6, 23, 52, 13, 5);

            idades.AdicionarVarios( 123, 234);
            idades.EscreverNaTela();
            //ListExtensoes.AdicionarVarios(idades,123,234);
            for (int i = 0; i < idades.Count; i++)
            {
                //Console.WriteLine($"Idade Atual:{idades[i]}");
            }
            1.EscreverNaTela();

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
