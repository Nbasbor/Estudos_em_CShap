using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netGram2
{
    public class Usuario 
    {
        public string Nome { get; set; }
        public string Senha { get; private set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public string Profissao { get; set; }
        public string Hobbies { get; set; }
        public string ID { get; set; }

        public int ncontas;
        public static int TotalContasCriadas { get; private set; }


        public Usuario()
       {
            Console.WriteLine("Digite seu nome: ");
            this.Nome = Console.ReadLine();
             

            Console.WriteLine("Digite seu email: ");
            this.Email = Console.ReadLine();
            

            Console.WriteLine("Digite sua idade: ");
            this.Idade = Convert.ToInt32(Console.ReadLine());
               //this.Idade = idade;

            Console.WriteLine("Escolha os seguintes números para gênero: ");
            Console.WriteLine("1 - Feminino | 2 - Masculino | 3 - Outro");
            //this.Genero = Console.ReadLine();
            int genero = Convert.ToInt32(Console.ReadLine());
            switch (genero)
            {
                case 1:
                    this.Genero = "Feminino";
                    break;
                case 2:
                    this.Genero = "Masculino";
                    break;
                case 3:
                    this.Genero = "Outro";
                    break;
                case 0:
                    Console.WriteLine("Escolha um número válido");
                    break;
            }

            //this.Genero = genero;

            Console.WriteLine("Digite sua profissão: ");
            this.Profissao = Console.ReadLine();
            //this.Profissao = profissao;

            Console.WriteLine("Digite seus hobbies: ");
            this.Hobbies = Console.ReadLine();
            //this.Hobbies = hobbies;

            Console.WriteLine("Digite sua Senha: ");
            this.Senha = Console.ReadLine();
            //this.Senha = senha;

            ncontas = 1 ;

            Usuario.TotalContasCriadas += ncontas;
            
           this.ID = "#" + Usuario.TotalContasCriadas; 
       }
    }
}
