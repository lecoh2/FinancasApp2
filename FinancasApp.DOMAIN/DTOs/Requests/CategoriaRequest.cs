using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.DOMAIN.DTOs.Requests
{
    /// <summary>
    /// Registro para entrada de dados da categoria
    /// </summary>
    /// <param name="Nome"></param>
    public record CategoriaRequest
    (
        string Nome //Nome da categoria
    );
}
