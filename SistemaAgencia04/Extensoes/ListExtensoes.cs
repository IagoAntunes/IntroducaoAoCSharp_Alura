using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgencia04.Extensoes
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }
        public static void TesteGenerico<T2>(this string texto)
        {

        }

        static void Teste()
        {
            List<int> idades = new List<int>();

            idades.Add(14);
            idades.Add(15);
            idades.Add(19);

            idades.AdicionarVarios<int>(23,12,28);

            string guilherme = "Guilherme";
            guilherme.TesteGenerico<int>();

            //ListExtensoes<int>.AdicionarVarios(idades,12,4,5,12);

            List<string> nomes = new List<string>();
            nomes.Add("Guilherme");
            //ListExtensoes<string>.AdicionarVarios(nomes, "jOAO", "lUCAS");

            //nomes.ad
        }


    }
}
