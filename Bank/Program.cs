using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Funcionario;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario funcionario = new Funcionario();

            funcionario.Nome = "Carlos";
            funcionario.CPF = "12346578910";
            funcionario.Salario = 1500.00
        }
    }
}
