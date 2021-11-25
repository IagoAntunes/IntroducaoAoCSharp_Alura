using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    internal class Estagiario : Funcionario
    {
        public Estagiario(double salario,string cpf)
            : base(salario, cpf)
        {
            //
        }
        public override void AumentarSalario()
        {
            //Qualquer codigo
        }
        
        protected override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
/*
 * O modificador de acesso internal
 * O modificador de acesso internal protected
 * Revisamos todos os outros modificadores de acesso;
 */ 
