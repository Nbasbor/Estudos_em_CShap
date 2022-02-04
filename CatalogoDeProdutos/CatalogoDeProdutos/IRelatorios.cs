
namespace CatalogoDeProdutos
{
    public interface IRelatorios
    {
        Task Imprimir(HttpContext context);
    }
}