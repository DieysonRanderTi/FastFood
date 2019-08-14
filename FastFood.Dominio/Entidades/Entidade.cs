using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastFood.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagemValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
        }

        public abstract void Validate();

        protected bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }

        protected void LimparMensagemDeValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarMensagem(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }
    }
}
