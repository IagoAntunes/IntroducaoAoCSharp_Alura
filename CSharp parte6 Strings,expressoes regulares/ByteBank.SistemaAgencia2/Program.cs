using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("TamanhoString" + nomeArgumento.Length);
            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length + 1));
            Console.ReadLine();


            //
            string textoVazio = "";
            string textoNull = null;

            Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            Console.WriteLine(string.IsNullOrEmpty(textoNull));
            Console.ReadLine();
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";
            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);

            string argumentos = url.Substring(indiceInterrogacao + 1);

            Console.WriteLine(argumentos);



            Console.ReadLine();
        }
    }
}
/*01
 * No c# e .NET strings sao imutaveis
 * Podemos criar uma nova string a partir da porção de outra , com o metodo Substring;
 */

/*02
 * Metodo IndexOF
 * Metodo estatico IsNullOrEmpty
 * A palavra reservada string é , na verdade o tipo String
 * A palavra reservada int é , na verdade o tipo int32
 * A palavra reservada double é na verdade o tipo Double
 * A sobrecarga String::IndexOf(string)
 * A propriedade String::Length*/