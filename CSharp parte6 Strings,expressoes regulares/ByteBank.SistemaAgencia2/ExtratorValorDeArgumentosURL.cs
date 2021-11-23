using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia2
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }
        public ExtratorValorDeArgumentosURL(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argument URL nao pode ser nula ou vazia",nameof(url));
            }
    
            URL = url;

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
            

        }
        //MoedaOrigem=real&moedaDestino=dolar
        public string getValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string argumentoEmCaixaAlta = _argumentos.ToUpper();


            string termo = nomeParametro + "=";
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo);
            
            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');
            if(indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);

        }
    }
}
