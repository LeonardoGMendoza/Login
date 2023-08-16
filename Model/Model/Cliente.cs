using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    #region Clase Cliente 
    public class Cliente
    {
        [Key]
        public Guid IdCli { get; set; } = Guid.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Cnpj{ get; set; } = string.Empty;

        public string TipoCliente{ get; set; } = string.Empty;
        
    }
    #endregion
}
