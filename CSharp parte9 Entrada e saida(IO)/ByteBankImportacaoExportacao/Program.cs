using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Input , Output

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var enderecoDoArquivo = "contas.txt";

            using(var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                using (var leitor = new StreamReader(fluxoDeArquivo))
                {
                    while (!leitor.EndOfStream)//Enquanto nao chegou ao FIM
                    {
                        var linha = leitor.ReadLine();
                        Console.WriteLine(linha);
                    }
                }

            }

            
            Console.ReadLine();
        }
        
    }
}
/*01
 * Como lidar com arquivos grandes e maiores que a RAM do computador
 * O que sao Streams
 * Como usar o metodo Read e Buffers
 * Endereco de arquivo relativo
 * Unicode e encoding UTF*/
/*02
 * O modificador partial
 * O metodo Close de um stream
 * Como usar o StreamReader
 * Os metodos Read,ReadLine e ReadToEnd
 * A propriedade EndOfStream*/