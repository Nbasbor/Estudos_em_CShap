using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoCadastroBD
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }
        public string Area { get; set; }
        public string Nascionalidade { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        
        public Usuario()
        {

        }

        public Usuario(int id, string nome, string email, string senha, string cpf, string profissao, string area, string nacionalidade, string estado, string cidade, string endereco)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            CPF = cpf;
            Profissao = profissao;
            Area = area;
            Nascionalidade = nacionalidade;
            Estado = estado;
            Cidade = cidade;
            Endereco = endereco;
        }
    }
}
