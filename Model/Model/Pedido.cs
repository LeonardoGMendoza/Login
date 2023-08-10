using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class Pedido
    {

        public int idPedido;
        public int idColaborador;
        public int? codCliente;
        public int status;
        public string dataDoPedido;
        public string formaPagamento;
        public decimal totalPedido;

        public int IdPedido { get { return idPedido; } set { idPedido = value; } }
        public int IdColaborador { get { return idColaborador; } set { idColaborador = value; } }
        public int? CodCliente { get { return codCliente; } set { codCliente = value; } }
        public int Status { get { return status; } set { status = value; } }
        public string DataDoPedido { get { return dataDoPedido; } set { dataDoPedido = value; } }
        public string FormaDePagamento { get { return formaPagamento; } set { formaPagamento = value; } }
        public decimal TotalPedido { get { return totalPedido; } set { totalPedido = value; } }

    }
}
