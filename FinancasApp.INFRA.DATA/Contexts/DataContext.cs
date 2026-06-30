using FinancasApp.INFRA.DATA.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.INFRA.DATA.Contexts
{
    public class DataContext : DbContext
    {
        //Método Contrutor para recebere  por meio de injeção de dependência    
        //as  configurações do banco de dados, como conexão, tipo, etc..

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new MovimentacaoMap());
        }
    }
}
