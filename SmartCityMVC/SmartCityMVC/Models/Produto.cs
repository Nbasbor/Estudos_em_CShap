namespace SmartCityMVC.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Caracteristicas { get; set; }
        public double Preco { get; set; }
        public string Logotipo { get; set; }
        public bool Ativo { get; set; }

        //refeência para a classe TipoProduto
        public TipoProduto tipo { get; set; }   
    }
}
