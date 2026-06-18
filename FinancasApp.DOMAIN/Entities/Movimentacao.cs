using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.DOMAIN.Entities
{
    public class Movimentacao
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public DateOnly? Data { get; set; }
        public Double? Valor { get; set; } = 0.0;
        public Guid? CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
        public TipoMovimentacao Tipo { get; set; }

        public enum TipoMovimentacao
        {
            Receber = 1,
            Pagar = 2
        }

    }
}
