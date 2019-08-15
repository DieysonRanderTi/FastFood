using FastFood.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Cep)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(u => u.DataPedido)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(u => u.DataPrevisaoEntrega)
                .IsRequired()
                .HasMaxLength(50);
           
            builder
                .Property(u => u.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Estado)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(u => u.FormaPagamento)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(u => u.ItensPedido)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
