using AutoMapper;
using FinancasApp.DOMAIN.DTOs.Requests;
using FinancasApp.DOMAIN.DTOs.Responses;
using FinancasApp.DOMAIN.Interfaces.Repositories;
using FinancasApp.DOMAIN.Interfaces.Services;
using FinancasApp.DOMAIN.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.DOMAIN.Services
{
    public class MovimentacaoService(IUnitOfWork unitOfWork, IMapper mapper) : IMovimentacaoService
    {
        public Task<MovimentacaoResponse> Adicionar(MovimentacaoRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<MovimentacaoResponse>> ConsultarAsync(int pageNumer, int pageSize)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<MovimentacaoResponse> Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<MovimentacaoResponse> Modificar(Guid id, MovimentacaoRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<MovimentacaoResponse?> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
