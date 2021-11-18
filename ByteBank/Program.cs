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
            CalcularBonificacao();



            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvovledor guilherme = new Desenvovledor("123.456.789-12");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonficações do mês:" + gerenciadorBonificacao.GetTotalBonificacao());

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

/*
 * O modificador de acesso protected
 * Preenchendo construtores da classe base a partir da classe derivada
 * com a sintaxe public Diretor(string cpf) : base(5000,cpf)
 * Classes e metodos abstreatos
 */