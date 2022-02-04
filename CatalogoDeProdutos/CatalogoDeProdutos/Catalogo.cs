using CatalogoDeProdutos.Models;

namespace CatalogoDeProdutos
{
    public class Catalogo : ICatalogo //Ctrl+. Extract Interface
    {
        public List<Livro> GetLivros()
        {
            var livro = new List<Livro>();
            livro.Add(new Livro(00, "Quem Mexeu na minha Query?", "MC Sharp", 30.00));
            livro.Add(new Livro(01, "Café com Java", "Oraclo", 29.90));
            livro.Add(new Livro(02, "Fique Rico Com React", "Jay S", 19.00));
            return livro;
        }

        //        async(context) =>
        //{
        //    foreach (var livro in livros)
        //    {
        //        await context.Response.WriteAsync($"{livro.Id,-10} {livro.Título,-20} {livro.Autor,-40} {livro.Preco.ToString("C"),10}\r\n");//\r return
        //    }

        //}

    }
}
