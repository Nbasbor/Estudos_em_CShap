using System.Text;

namespace WebApp.Models
{
    public class Estudo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public ListaDeEstudos Lista { get; set; }

        public string Detalhes()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Detalhes do Estudo");
            stringBuilder.AppendLine("======");
            stringBuilder.AppendLine($"Nome: {Nome}");
            stringBuilder.AppendLine($"Tipo: {Tipo}");
            stringBuilder.AppendLine($"Lista: {Lista.Nome}");
            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return $"{Nome} - {Tipo}";
        }
    }


}
