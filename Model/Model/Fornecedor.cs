using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class Fornecedor
    {

        
        public Guid IdFornecedor { get; set; } = Guid.Empty;
        public string InscricaoEstadual { get; set; } = string.Empty;
        public string NomeFantasia { get; set; } = string.Empty;
        public string UfPessoa { get; set; } = string.Empty;
        public string NumeroPessoa { get; set; } = string.Empty;
        public string ComplementoPessoa { get; set; } = string.Empty;

        public string BairroPessoa { get; set; } = string.Empty;
        public string CidadePessoa { get; set; } = string.Empty;
        public int CepFornecedor { get; set; } 

        public int StatusAtivo { get; set; }
        public string CnpjFornecedor { get; set; } = string.Empty;
        public string Rua { get; set; } = string.Empty;


    }
}
