using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.DOMAIN.DTOs.Requests
{
    /// <summary>
    /// Registro para entrada de dados de movimentação
    /// </summary>
    public record MovimentacaoRequest
    (
        string Nome,  //Nome da movimentação
        string Data,  //Dada da movimentação
        decimal Valor,  //  Valor da moviemntação
        Guid CategoriaId,  //Id da Categoria
        int Tipo  //Tipo da categoria
    );
}
