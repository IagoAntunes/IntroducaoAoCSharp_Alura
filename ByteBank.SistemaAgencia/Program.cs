using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dataFimPagamento = new DateTime(2018, 8, 17);
            DateTime dataCorrente = DateTime.Now;
            //TimeSpan diferenca = dataFimPagamento - dataCorrente;
            TimeSpan diferenca2= TimeSpan.FromMinutes(60);
            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca2);

            //string mensagem = "Vencimento em "+ GetIntervaloDeTempoLegivel(diferenca);
            Console.WriteLine(mensagem);




            Console.ReadLine();
        }
        /*static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {
            if(timeSpan.Days > 30 || timeSpan.Days < 0)
            {
                int quantidadeMeses = timeSpan.Days / 30;
                if(quantidadeMeses == 1)
                {
                    return "1 mes";
                }
                return quantidadeMeses + "meses";
            }else if(timeSpan.Days > 7)
            {
                int quantidadeSemanas = timeSpan.Days / 7;

            }
            return timeSpan.Days + "dias";
        }*/
    }
}
/*
 * Como criar biblioteca de classes
 * Como adicionar referencias de um projeto para outro
 * A diferença entre bibliotecas de classes e aplicativo de console
 * a extensao de arquivo .dll
 * como o .net busca as bibliotecas na execucao de um programa
 */

/*04
 * Os comentarios de documentação ///
 * O elemento de documentação <sumary/>
 * O elemento <param/>
 * O elemento <paramref/>
 * O elemento <exception/>
 * O elemento <see/>
 */

/*05
 * Oque é Nuget
 * O comando Install-Package
 * O tipo DateTime
 * O tipo TimeSpan
 * Conhecendo a bblioteca humanizer */