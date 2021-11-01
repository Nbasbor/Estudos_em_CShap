﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Sistemas;

namespace Bank.Funcionario
{
    public string Senha { get; set; }
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {
            
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}
