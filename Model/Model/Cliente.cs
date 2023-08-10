using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class Cliente
    {

        public string cpfCnpj;
        public string tipoCliente;

        public string CpfCnpj
        {
            get { return cpfCnpj; }
            set { cpfCnpj = value; }
        }
        public string TipoCliente { get { return tipoCliente; } set { tipoCliente = value; } }

    }
}
    