using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank;
using Bank.Sistemas;
using Bank.Funcionario

namespace Bank.Funcionario
{
    public class Diretor : FuncionarioAutenticavel
        //cria diretor que herda funcionario
    {
        public Diretor(string cpf) : base(10000, cpf)
            //construtor herda da classe base
            // construtor herda argumento cpf da classe 
        {
            
            Console.WriteLine("Criando Diretor");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao()
            //override sobrescreve o método da classe mãe 
            // para que seja possível sobrescrever o método
            // se usa a palavra virtual na classe mãe e override na classe filho

        {
            return Salario * 0.5;
            // return Salario + base.GetBonificacao();
            // base.GetBonificacao() = referencia a classe Base(mãe)
        }
    }
}
