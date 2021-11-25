﻿using ByteBank.Modelos;
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
            CriarArquivoComWriter();
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