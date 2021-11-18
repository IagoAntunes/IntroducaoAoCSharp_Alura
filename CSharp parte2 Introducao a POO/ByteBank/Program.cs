using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "454.658.148-3";
            roberta.Salario = 5000;

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);
            
            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine("Total de bonificacoes:" + gerenciador.GetTotalBonificacao());


            Console.ReadLine();
        }
    }
}

/*Podemos criar diretórios na raiz de nosso projeto para organizar melhor o codigo
 * o recurso de possiveis soluções do visual studio,acessivel pelo ayalho CONTROL + PONTO
 * Podemos ter varios metodos com o mesmo nme , desde que possuam lista de argumentos diferentes ,SOBRECARGAS
 aaaaaaaaaaaa
 */