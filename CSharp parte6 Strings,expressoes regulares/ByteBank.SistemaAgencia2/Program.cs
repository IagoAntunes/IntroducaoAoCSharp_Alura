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
            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");
            urlTeste.StartsWith("https://www.bytebank.com");



            Console.WriteLine(indiceByteBank == 0);
            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio/"));
            Console.WriteLine(urlTeste.Contains("BYtebank".ToLower()));



            string termoBusca = "ra";
            string mensagemOrigem = "PALAVRA";

            Console.WriteLine(termoBusca.ToUpper());
            Console.WriteLine(mensagemOrigem.ToLower());

            string urlParametro = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametro);
            
            string valor = extratorDeValores.getValor("moedaDestino");
            Console.WriteLine("valor de moeda destino:" + valor);

            string valor2 = extratorDeValores.getValor("moedaOrigem");
            Console.WriteLine("valor de moeda Origem:" + valor2);

            Console.WriteLine(extratorDeValores.getValor("valor"));


            Console.ReadLine();


            //Testando metodo remove
            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial,4));



            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

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

/*O IndexOf retorna sempre o indice da primeira ocorrencia que buscamos
 * O metodo Remove(char)
 * O metodo Remove(char,int)
 * Seleção quadrada no Visual Studio com o 'Shift + Alt'
 * O IndexOf retorna -1 quando o valor nao é encontrado
 * O método Replace
 * O método ToUpper e ToLower
 * O metodo StartsWith, EndsWith Contains*/