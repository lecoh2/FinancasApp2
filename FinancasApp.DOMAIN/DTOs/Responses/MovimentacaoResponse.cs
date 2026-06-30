using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.DOMAIN.DTOs.Responses
{
    public record MovimentacaoResponse
    (
        Guid Id, //Id da Movimentação
        string Nome, // Nome da Movimentação
        string Data, // Data da Movimentação
        decimal Valor, //Valor da Movimentação
        int Tipo, // Tipo da Movimentação
        CategoriaResponse Categoria // Dados da Categoria

    );
    
}
