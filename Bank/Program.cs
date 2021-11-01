using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Funcionario;
using Bank.Sistemas;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            Console.ReadLine();
        }

        //Sistemas de senha 
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor diretor = new Diretor("32145698701");
            diretor.Nome = "Ana";
            diretor.Senha = "123";

            sistemaInterno.Logar(diretor, "123");
        }

        //Calculador de total gasto com bonificações
        public static void CalcularBonificacao()
            // Transformar em estático para ser possível utiliza-lo no Main
        {
            Diretor diretor = new Diretor("32145698701");
            diretor.Nome = "Ana";
            //diretor.CPF = "32145698701";
            //diretor.Salario = 10000.00;

            Designer designer = new Designer("34138299791");
            designer.Nome = "João";

            GerenteDeConta gerente = new GerenteDeConta("75390428437");
            gerente.Nome = "Sandra";

            Auxiliar auxiliar = new Auxiliar("43884847609");
            auxiliar.Nome = "Diego";

            //Registro no gerenciador de bonificação
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            gerenciador.Registrar(auxiliar);
            gerenciador.Registrar(funcionario);
            gerenciador.Registrar(gerente);
            gerenciador.Registrar(designer);
            gerenciador.Registrar(diretor);
            Console.WriteLine("Bonificação Total do Mes: " + gerenciador.GetTotalBonificacao());


            Console.WriteLine("Funcionario: " + funcionario.Nome);
            Console.WriteLine("Diretor: " + diretor.Nome);
            Console.WriteLine("Designer: " + designer.Nome);
            Console.WriteLine("Auxiliar: " + auxiliar.Nome);
            Console.WriteLine("Gerente de Conta: " + gerente.Nome);
            //Console.WriteLine(funcionario.GetBonificacao());
            //Console.WriteLine(diretor.GetBonificacao());
            //polimorfismo =  quando há um método especializado
            //de nomes iguais para cada classe devivada evocando comportamentos diferentes



            //obs: stackoverflow = estouro de pilha :
            //quando muitos métodos são empilhados em cima do outro e acaba a capacidade da memória


            //Criando Funcionarios ( classe abstrata)
            //Funcionario funcionario = new Funcionario(2000.00, "12346578910");
            //funcionario.Nome = "Carla";
            //funcionario.Salario = 2000.00;

            //carla.AumentarSalario();
            //Console.WriteLine("Novo Salario de Carla: " + carla.Salario);
        }
    }
}
