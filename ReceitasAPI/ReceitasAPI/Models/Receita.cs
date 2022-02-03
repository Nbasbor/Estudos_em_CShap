using System;
using System.ComponentModel.DataAnnotations;

namespace ReceitasAPI.Models
{
    public class Receita
    {
        [Required(ErrorMessage = "Campo Nome obrigatório")]
        public string Nome { get; set; }
        [Key]
        [Required]
        public int Id { get; set; } 
        public string Tipo { get; set; }
        public string Porcao { get; set; }  
        [Required(ErrorMessage = "Campo Ingrediente obrigatório")]
        public string Ingredientes { get; set; } 
        [StringLength(1000, ErrorMessage = "Tamanho máximo é de 1000 caracteres")]
        [Required(ErrorMessage = "Campo Preparo obrigatório")]
        public string Preparo { get; set; }





    }
}
