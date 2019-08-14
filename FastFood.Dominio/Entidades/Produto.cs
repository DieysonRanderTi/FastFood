using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarMensagem("Erro - Infome uma Descrição de Produto");
            }
            if (Preco == 0)
            {
                AdicionarMensagem("Erro - Informe um preço de Produto");
            }
        }
    }
}
