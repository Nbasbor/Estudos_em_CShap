using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netGram2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criar um perfil na NetGram - " +
                "Redesocial para profissionais de tecnologia");

            Console.WriteLine("A NetGram é uma rede no qual profissionais de tecnologia " +
                "possam interarir e conversar sobre diversas coisas.");
              Console.WriteLine("Incentivamos uma conexão com pessoas diversas e assunos diferentes " +
                "*Juntos contra o burnout*");
            Console.WriteLine("Deseja criar perfil?");
            Console.WriteLine("Digite: 1 para SIM | 2 para NÂO");
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Entrando...");
                    // novo.Nome = "nan";
                    break;

                case 2:
                   Console.WriteLine("Tecle 0 para sair");
                   Console.ReadLine();
                   Environment.Exit(0);
                   break;
            }

            Usuario novo = new Usuario();
            Console.WriteLine("Seu nome é: " + novo.Nome);
            Console.WriteLine("Seu ID de conta é: " + novo.ID);
            Console.WriteLine("Seu email é: " + novo.Email);
            Console.WriteLine("Sua idade é: " + novo.Idade);
            Console.WriteLine("Seu gênero é: " + novo.Genero);
            Console.WriteLine("Sua profissão é: " + novo.Profissao);
            Console.WriteLine("Seus hobbies são: " + novo.Hobbies);

            Console.ReadLine();

        }
    }
}
