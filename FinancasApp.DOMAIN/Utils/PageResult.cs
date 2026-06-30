using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.DOMAIN.Utils
{
    /// <summary>
    /// Representa o resultado paginado de uma consuta.
    /// </summary>
    public class PageResult<T> 
    {
        /// <summary>
        /// Coleção de itens (entidades) retornados na página atual da consulta
        /// </summary>
        public IEnumerable<T> Items { get; set; } = new List<T>();
        /// <summary>
        /// Número da pagina atual da consulta
        /// </summary>
        public int PageNumber { get; set; }
        /// <summary>
        /// Quantidade de registros exibidos por página
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// Quantidade total de registros encotrados na consulta(em paginação)
        /// </summary>
        public int TotalCount { get; set; }
        /// <summary>
        /// quantidade total de págianas, calculando com base  TotalCount e PageSize
        /// </summary>

        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
        /// <summary>
        /// Indica se existe uma página anterior  à atual
        /// </summary>
        public bool HasPreviusPage => PageNumber > 1;

    }
}
