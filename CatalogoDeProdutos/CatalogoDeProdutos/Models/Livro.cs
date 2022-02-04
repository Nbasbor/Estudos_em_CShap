
namespace CatalogoDeProdutos.Models
{
    public class Livro
    {
        public Livro(int id,string título, string autor, double preco) //Select+Ctrl+. cria contrutor com propriedades
        {
            Id = id;
            Título = título;
            Autor = autor;
            Preco = preco;
        }
        public int Id { get; set; }
        public string Título { get; set; }
        public string Autor { get; set; }
        public double Preco { get; set; }
       
    }
}
