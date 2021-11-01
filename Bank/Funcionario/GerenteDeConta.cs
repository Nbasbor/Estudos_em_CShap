using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Sistemas

namespace Bank.Funcionario
{
    public class GerenteDeConta : Autenticavel
    {
        public GerenteDeConta(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando Gerente de Conta");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
