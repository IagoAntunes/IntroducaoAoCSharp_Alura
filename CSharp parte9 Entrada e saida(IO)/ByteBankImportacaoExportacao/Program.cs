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
            File.WriteAllText("escrevendoComAClasseFile.txt","Testando file");
            Console.WriteLine($"Arquivo criado");


            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine(bytesArquivo.Length);


            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            foreach(var linha in linhas)
            {
                Console.WriteLine(linha);
            }


            Console.ReadLine();

            var nome = Console.ReadLine();

            Console.WriteLine(nome);


            //UsarStreamDeEntrada();


            //CriarArquivoComWriter();
            //TestaEscrita();
            Console.WriteLine("Aplicacao finalizada");


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
/*03
 * Os metodos int.Parse e double.Parse
 * O formato de arquivo .csv
 * Como escrever diretamente no stream
 * Diferença entre FileMode.Create e FileMode.CreateNew;
 * Como usar o StreamWriter
 */
/*04 
 * O metodo Flush
 * BinaryReader e BinaryWriter*/
/*05
 * Como a Console funciona com streams
 * O metodo Console.OpenStandardInput()
 * Metodos auxiliares na classe File*/