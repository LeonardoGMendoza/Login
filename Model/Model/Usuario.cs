﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class Usuario
    {
        
        public string Login { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public bool StatusAtivo { get; set; }
    }
}
