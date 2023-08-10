﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    internal class Colaborador
    {

        public int idColaborador;
        string nomeColaborador;
        public int codDepartamneto;
        public string cpfColaborador;
        public int statusAtivo;
        public string cargoColaborador;
        public string telefoneColaborador;
        public string emailPessoalColaborador;
        public string emailCorporativo;

        public int IdColaborador { get { return idColaborador; } set { idColaborador = value; } }
        public string NomeColaborador { get { return nomeColaborador; } set { nomeColaborador = value; } }

        public int CodDepartamento { get { return codDepartamneto; } set { codDepartamneto = value; } }

        public string CpfColaborador { get { return cpfColaborador; } set { cpfColaborador = value; } }

        public int StatusAtivo { get { return statusAtivo; } set { statusAtivo = value; } }
        public string CargoColaborador { get { return cargoColaborador; } set { cargoColaborador = value; } }
        public string TelefoneColaborador { get { return telefoneColaborador; } set { telefoneColaborador = value; } }
        public string EmailPessoalColaborador { get { return emailPessoalColaborador; } set { emailPessoalColaborador = value; } }
        public string EmailCorporativo { get { return emailCorporativo; } set { emailCorporativo = value; } }


    }
}
