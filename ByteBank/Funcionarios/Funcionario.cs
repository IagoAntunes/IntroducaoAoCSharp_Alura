using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        // 0 - Funcionario
        // 1 - Diretor
        // 2 - Designer
        // 3 - Gerente de conta corrente
        // 4 - Coordenador
        // N - . . . 
       // private int _tipo;

        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        
        public Funcionario(double salario,string cpf)
        {
            Console.WriteLine("Criando funcionario..");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }
        
        public virtual void AumentarSalario()
        {
            //Salario = Salario + (Salario * 0.10);
            //Salario = Salario * 1.1;
            Salario *= 1.1;
        }
        
        public virtual double GetBonificacao()
         {
             return Salario * 0.10;
         }
        /*public Funcionario(int tipo)
        {
            this._tipo = tipo;
        }*/


        /*public double GetBonificacao()
        {
            if (_tipo == 1)
                return Salario;



            return Salario * 0.10;
        }*/



    }
}
