using FinancasApp.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.INFRA.DATA.Mappings
{
    public class MovimentacaoMap : IEntityTypeConfiguration<Movimentacao>
    {
        public void Configure(EntityTypeBuilder<Movimentacao> builder)
        {
            builder.ToTable("MOVIMENTACAO");//nome da tabela
            builder.Property(m => m.Id).HasColumnName("ID");
            builder.Property(m => m.Nome).HasColumnName("NOME").HasMaxLength(150);
            builder.Property(m => m.Data).HasColumnName("DATA").HasColumnType("date");
            builder.Property(m => m.Valor).HasColumnName("VALOR").HasColumnType("decimal(10,2)");
            builder.Property(m => m.Tipo).HasColumnName("TIPO");
            builder.Property(m => m.CategoriaId).HasColumnName("CATEGORIA_ID");

            //Mapeamento do relacionamento

            builder.HasOne(m => m.Categoria)//Movimentacao TEM 1 Categegoria
                .WithMany(c => c.Movimentacao)//Categoria TEM MUITAS movimentações

                .HasForeignKey(m => m.CategoriaId)//Chave Estrangeira
                .OnDelete(DeleteBehavior.Restrict);
            //Não Permite excluir de houver registros ralacionados
        }
    }
}
