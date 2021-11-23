using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgencia03
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;
        public ListaDeContaCorrente(int capacidadeInicial=5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }
        public void Adicionar(ContaCorrente item)
        {
            VerificaCapacidade(_proximaPosicao + 1);

            Console.WriteLine($"Adicionando item na posicao {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }
        private void VerificaCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length >= tamanhoNecessario) { 
                return ;
            }

            int novoTamanho = _itens.Length * 2;
            if(novoTamanho< tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            Console.WriteLine("Aumentando capacidade da lista");
            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            for(int indice = 0;indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
            }
            _itens = novoArray;


        }
    }
}
