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
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("CATEGORIA");//nome da tabela

            builder.HasKey(c => c.Id); // chave primary
            builder.Property(c => c.Id).HasColumnName("ID"); // nome do campo
            builder.Property(c => c.Nome).HasColumnName("NOME").HasMaxLength(50); // Nome do campo

            builder.HasIndex(c => c.Nome).IsUnique();//indice de para campo unico
        }
    }
}
