
using System.Collections;
using System.Collections.Generic;

namespace FastFood.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string sobreNome { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AdicionarMensagem("Erro - Email não foi informado.");
            }
            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarMensagem("Erro - Senha não infomada.");
            }
        }
    }
}
