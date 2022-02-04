namespace CatalogoDeProdutos
{
    public class Relatorios : IRelatorios
    {
        private readonly ICatalogo catalogo;

        public Relatorios(ICatalogo catalogo)
        {
            this.catalogo = catalogo;
        }
        public async Task Imprimir(HttpContext context) // Usa parametro HttpContext , método asyncrono tipo tarefa
        {
            foreach (var livro in catalogo.GetLivros())
            {
                await context.Response.WriteAsync($"{livro.Id,-10} {livro.Título,-20} {livro.Autor,-40} {livro.Preco.ToString("C"),10}\r\n");//\r return
            }
        }
    }
}
