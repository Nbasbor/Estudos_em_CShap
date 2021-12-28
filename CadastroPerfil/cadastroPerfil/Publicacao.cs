using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroPerfil
{
    public class Publicacao : PerfilUsuario
    {
        FormPerfil fConta = new FormPerfil();
        public string Titulo { get; set; }
        public string Tema { get; set; }
        public string Texto { get; set; }

        public string Autor { get; private set; }

        public Publicacao(string titulo, string tema, string texto) 
        {
            this.Titulo = titulo;
            this.Tema = tema;
            this.Texto = texto;
            this.Autor = Nome;
        }


    }
}
