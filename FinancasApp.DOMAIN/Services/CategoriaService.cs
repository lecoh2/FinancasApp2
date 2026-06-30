using AutoMapper;
using FinancasApp.DOMAIN.DTOs.Requests;
using FinancasApp.DOMAIN.DTOs.Responses;
using FinancasApp.DOMAIN.Interfaces.Repositories;
using FinancasApp.DOMAIN.Interfaces.Services;
using FinancasApp.DOMAIN.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.DOMAIN.Services
{
    /// <summary>
    /// Implementação ds serviços de dominio da entidade Categoria
    /// </summary>
    public class CategoriaService(IUnitOfWork unitOfWork, IMapper mapper) : ICategoriaService
    {         
        public Task<CategoriaResponse> Adicionar(CategoriaRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<CategoriaResponse>> ConsultarAsync(int pageNumer, int pageSize)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaResponse> Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaResponse> Modificar(Guid id, CategoriaRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaResponse?> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
