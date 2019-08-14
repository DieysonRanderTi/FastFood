using FastFood.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemDeValidacao();

            if (!ItensPedido.Any())
                AdicionarMensagem("Erro - Pedido não pode ficar sem itens!");

            if (string.IsNullOrEmpty(Cep))
                AdicionarMensagem("Erro - Cep deve estar preenchido.");

            if (FormaPagamentoId == 0)
            {
                AdicionarMensagem("Erro - Não foi informado a forma de pagamento");
            }
        }
    }
}
