using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgencia03
{
    public class ContaCorrente03
    {
        public static double TaxaOperacao { get; private set; }

        public Cliente titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }//Faz parte da CLASSE

        public int agencia;
        public int Agencia
        {
            get { return agencia; }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                agencia = value;
            }
        }

        public int numero { get; set; }
        public double saldo = 100;

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                saldo = value;
            }
        }


        public ContaCorrente03(int agencia, int numero)//Construtor
        {
            this.agencia = agencia;
            this.numero = numero;

            //TaxaOperacao = 30 / TotalDeContasCriadas;

            TotalDeContasCriadas++;
        }
        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

        public override bool Equals(object obj)
        {
            ContaCorrente outraConta = obj as ContaCorrente;

            if (outraConta == null)
            {
                return false;
            }
            return numero == outraConta.Numero && agencia == outraConta.Agencia;

        }
    }
}
