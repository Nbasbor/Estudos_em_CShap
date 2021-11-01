using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Funcionario
{
   public class Funcionario
        //cria o funcionario
    {
        public static int TotaldeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        //protected é possivel acessar da classe base e da classe hererditária

        public Funcionario(double salario, string cpf)
            //construtor da classe de total de funcionarios
        {
            Console.WriteLine("Criando Funcionário");
            Salario = Salario;
            CPF = cpf;
            TotaldeFuncionarios ++;
        }

        public virtual void AumentarSalario()
            // virtual porque é possíel sobrescreve-lo
            //void porque não tem retorno
        {
            //Salario = Salario + (Salario * 0.1)
            //Salario = Salario * 1.1;
            Salario *= 1.1;
        }
        public virtual double GetBonificacao()
            // virtual pode ser sobrescrevito nas classes filhas
        {
            return Salario * 0.10;
        }

    }
}
