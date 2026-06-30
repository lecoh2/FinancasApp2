using FinancasApp.DOMAIN.Entities;
using FinancasApp.DOMAIN.Interfaces.Repositories;
using FinancasApp.INFRA.DATA.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.INFRA.DATA.Repositories
{
    public class CategoriaRepository(DataContext dataContext)
        : BaseRepository<Categoria, Guid>(dataContext), ICategoriaRepository
    {

    }
}
