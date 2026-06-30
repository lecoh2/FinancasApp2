using FinancasApp.DOMAIN.DTOs.Requests;
using FinancasApp.DOMAIN.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.DOMAIN.Interfaces.Services
{
    /// <summary>
    /// Interface especifica pra serviços de categoria
    /// </summary>
    public interface ICategoriaService : IBaseService<CategoriaRequest, CategoriaResponse, Guid>
    {
    }
}
