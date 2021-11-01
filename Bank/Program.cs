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
            Funcionario funcionario = new Funcionario(1500.00, "12346578910");

            funcionario.Nome = "Carlos";
            //funcionario.Salario = 1500.00;

            carlos.AumentarSalario();
            Console.WriteLine("Novo Salario de Carlos: " + carlos.Salario);

            gerenciador.Registrar(funcionario);



            Funcionario diretor = new Funcionario( "32145698701");
            diretor.Nome = "Ana";
            //diretor.CPF = "32145698701";
            //diretor.Salario = 10000.00;

            gerenciador.Registrar(diretor);

            Console.WriteLine(funcionario);
            Console.WriteLine(diretor);
            Console.WriteLine(funcionario.GetBonificacao());
            Console.WriteLine(diretor.GetBonificacao());
            //polimorfismo =  quando há um método especializado
            //de nomes iguais para cada classe devivada evocando comportamentos diferentes
            Console.WriteLine(gerenciador.GetTotalBonificacao());


            //obs: stackoverflow = estouro de pilha :
            //quando muitos métodos são empilhados em cima do outro e acaba a capacidade da memória

        }
    }
}
