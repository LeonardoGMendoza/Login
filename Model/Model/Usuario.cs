using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class Usuario
    {
        public string login;
        public string senha;
        public bool statusAtivo;
        public string Login { get { return login; } set { login = value; } }
        public string Senha { get { return senha; } set { senha = value; } }
        public bool StatusAtivo { get { return statusAtivo; } set { statusAtivo = value; } }
    }
}
