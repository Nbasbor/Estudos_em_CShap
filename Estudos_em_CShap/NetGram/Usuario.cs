using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetGram.GerarID;

namespace NetGram
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Idade { get; set; }
        public string Genero { get; set; }
        public string Profissao { get; set; }
        public string Hobbies { get; set; }

        public Usuario(string nome, string email)
        {
            Nome = nome;
            Email = email;


        }


    }
}
