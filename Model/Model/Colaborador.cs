using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class Colaborador
    {

        [Key]
        public Guid IdColaborador { get; set; } = Guid.Empty;
        public string NomeColaborador { get; set; } = string.Empty;

        public int CodDepartamento { get; set; } 

        public string CpfColaborador { get; set; } = string.Empty;

        public int StatusAtivo { get; set; } 
        public string CargoColaborador { get; set; } = string.Empty;
        public string TelefoneColaborador { get; set; } = string.Empty;

        public string EmailPessoalColaborador { get; set; } = string.Empty;
        public string EmailCorporativo { get; set; } = string.Empty;


    }
}
