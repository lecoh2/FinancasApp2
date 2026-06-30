using FinancasApp.DOMAIN.Entities;
using FinancasApp.DOMAIN.Interfaces.Repositories;
using FinancasApp.INFRA.DATA.Contexts;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.INFRA.DATA.Repositories
{
    public class UnitOfWork(DataContext dataContext) : IUnitOfWork
    {
        private IDbContextTransaction? transaction;
        public void BeginTransaction()
        {
            if (transaction != null)
                return;
            transaction = dataContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            if (transaction != null)
                transaction.Commit();
        }

        public void Rollback()
        {
            if (transaction != null)
                transaction.Rollback();
        }

        public ICategoriaRepository CategoriaRepository=> new CategoriaRepository(dataContext);

        public IMovimentacaoRepository MovimentacaoRepository =>  new MovimentacaoRepository(dataContext);
    }
}
