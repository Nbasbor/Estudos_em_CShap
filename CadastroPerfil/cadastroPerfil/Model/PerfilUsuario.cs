using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace cadastroPerfil
{
    public class PerfilUsuario
    {
        [Key]
        [Required]
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public string Senha { private get; set; }
        public string Profissao { get; set; }
        public string Hobbies { get; set; } 
        public string Sexo { get; set; }

        //public PerfilUsuario(string email, string nome, string senha, int idade)
        //{
        //    this.Email = email;
        //    this.Nome = nome;
        //    this.Senha = senha;
        //    this.Idade = idade;
        //    this.Sexo = "";
        //    this.Hobbies = "";
        //    this.Profissao = "";
        //}

        public PerfilUsuario()
        {
        //    //this.Sexo = "";
        //    //this.Hobbies = "";
        //    //this.Profissao = "";
        //    //this.Nome = "";
        //    //this.Email = "";
        //    //this.Senha = "";
        //    //this.Idade = 0;
        }

    }
}
