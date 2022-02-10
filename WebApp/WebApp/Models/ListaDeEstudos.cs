using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApp.Models
{
    public class ListaDeEstudos
    {
        private List<Estudo> _estudos;
        public ListaDeEstudos(string nome, params Estudo[] estudos)
        {
            Nome = nome;
            _estudos = estudos.ToList();//trnasforma estudos em lista
            _estudos.ForEach(estudo => estudo.Lista = this); // para cada estudo na lista9propriedade do obj Estudo) de estudo é igual a esse
        }
        public string Nome { get; set; } //Nome da lista (estudando/ estudado)
        public IEnumerable<Estudo> Estudos
        {
            get { return _estudos; }   
        }

        public override string ToString()
        {
            var linhas = new StringBuilder();
            linhas.AppendLine(Nome);
            linhas.AppendLine("=======");
            foreach(var estudo in Estudos)
            {
                linhas.AppendLine(estudo.ToString());   
            }
            return linhas.ToString();   
            //torna string o objeto

        }
    }
}
