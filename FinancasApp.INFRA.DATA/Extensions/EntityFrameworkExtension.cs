
using FinancasApp.DOMAIN.Interfaces.Repositories;
using FinancasApp.INFRA.DATA.Contexts;
using FinancasApp.INFRA.DATA.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.INFRA.DATA.Extensions
{
    /// <summary>
    /// Classe de extenção para configurar as injeções de dependência do entityframework
    /// </summary>
    public static class EntityFrameworkExtension
    {
        public static IServiceCollection AddEntityFramework
            (this IServiceCollection services,
                  IConfiguration configuration)
        {
            //ler a connectionstring do banco de dados
            var connectionString = configuration.GetConnectionString("FinancasApp");
            //injetar as configurações da classe DataContext
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));

            //Injeção de dependência da classe DataContext
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
