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

            Funcionario carlos = new Funcionario(2000,"546.879.157-20");
            carlos.Nome = "Carlos";
            carlos.AumentarSalario();
            Console.WriteLine("Novo salario:" + carlos.Salario);
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            //Funcionario pedro = new Diretor();

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
            roberta.AumentarSalario();
            Console.WriteLine("Novo salario Roberta:" + roberta.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Funcionario robertaTeste = roberta;
            Console.WriteLine("Bonificacao de uma referencia de Diretori:" + roberta.GetBonificacao());
            Console.WriteLine("Bonificacao de uma referencia de Funcionario:" + robertaTeste.GetBonificacao());

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);
            
            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificacoes..." + gerenciador.GetTotalBonificacao());


            Console.ReadLine();
        }
    }
}

/*Podemos criar diretórios na raiz de nosso projeto para organizar melhor o codigo
 * o recurso de possiveis soluções do visual studio,acessivel pelo ayalho CONTROL + PONTO
 * Podemos ter varios metodos com o mesmo nme , desde que possuam lista de argumentos diferentes ,SOBRECARGAS
 aaaaaaaaaaaa
 */

/*
 * Herança - Aprendemos herança e vimos que com sua sintaxe bastante simples
 *      ela é mportantissima em qualquer projeto
 * Polimorfismo - Com isso foi possivel tratar objetos do tipo diretor como funcionario e evitar
 *      repetição de codigo e varias sobrecargas iguais
 * Modificadores v,Ov - alguns componentes possuem implementação diferentes nas classes derivaddas para
 *      resolver este problema basta usarmos metodos virtuais e sobrescrita
 * base - A classe filha pode fazer referencia aos membros da classe base com uso desta palavra reservada
 * */