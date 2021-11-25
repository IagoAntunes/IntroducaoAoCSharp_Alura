using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void EscritaBinaria()
        {
            using(var fs = new FileStream("contaCorrente.txt",FileMode.Create))
                using(var escritor = new BinaryWriter(fs))
            {
                escritor.Write(134);//Agencia
                escritor.Write(451314);//Numero
                escritor.Write(1411.50);//Saldo
                escritor.Write("Gustavo Silva");
            }
        }
        static void LeituraBinaria()
        {
            using(var fs = new FileStream("contaCorrente.txt",FileMode.Open))
                using(var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numero = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"{agencia}/{numero} {titular}  {saldo}");
            }
        }
    }
}
