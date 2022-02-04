using CatalogoDeProdutos.Models;

namespace CatalogoDeProdutos
{
    public interface ICatalogo
    {
        List<Livro> GetLivros();
    }
}