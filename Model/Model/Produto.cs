using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class Produto
    {

        public string CodBarras { get; set; } = string.Empty;
        public Guid IdProduto { get; set; } = Guid.Empty;
        public Guid IdFornecedor { get; set; } = Guid.Empty;
        public string NomeProduto { get; set; } = string.Empty;
        public string DescricaoProduto { get; set; } = string.Empty;
        public decimal PrecoCusto { get; set; } 
        public decimal PrecoVenda { get; set; } 
        public decimal MargemLucro { get; set; } 
        public DateTime DataFabricacao { get; set; } 
        public DateTime DataVencimento { get; set; } 
        public int QuantidadeEstoqueProduto { get; set; } 
        public string Categoria { get; set; } = string.Empty;
        public int StatusAtivo { get; set; } 
    }
}
