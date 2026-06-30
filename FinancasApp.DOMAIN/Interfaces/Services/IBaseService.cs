using FinancasApp.DOMAIN.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.DOMAIN.Interfaces.Services
{
    /// <summary>
    /// Interface genérica para os serviços  do dominio
    /// </summary>
    public interface IBaseService<TRequest, TResponse, TKey> : IDisposable
    {
        Task<TResponse> Adicionar(TRequest request);
        Task<TResponse>Modificar(TKey id, TRequest request);
        Task<TResponse>Excluir(TKey id);
        Task<PageResult<TResponse>> ConsultarAsync(int pageNumer, int pageSize);
        Task<TResponse?> ObterPorIdAsync(TKey id);
    }
}
