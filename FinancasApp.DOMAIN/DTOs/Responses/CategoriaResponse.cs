using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.DOMAIN.DTOs.Responses
{
    public record CategoriaResponse
    (
        Guid Id, //Id Categoria
        string Nome //Nome da categoria
            );


}
