using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class Pedido
    {
        [Key]
        public Guid IdPedido { get; set; } = Guid.Empty;
        public Guid IdColaborador { get; set; } = Guid.Empty;
        public Guid IdCli { get; set; } = Guid.Empty;
        public int Status { get; set; }
        public string DataDoPedido { get; set; } = string.Empty;
        public string FormaDePagamento { get; set; } = string.Empty;
        public decimal TotalPedido { get; set; }
    }
}
