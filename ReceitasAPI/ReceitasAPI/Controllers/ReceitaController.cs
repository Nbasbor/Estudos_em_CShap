using Microsoft.AspNetCore.Mvc;
using ReceitasAPI.Models;
using System;


namespace ReceitasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")] //rota com o nome do controller "genérico"

    public class ReceitaController : ControllerBase //Herda do ControllerBase
    {
        private static List<Receita> receitas = new List<Receita>();
        private static int id = 1;

        //cria uma lista tipo Receita


        /*------------ Para criar um recuro -----------*/
        [HttpPost] 
        public IActionResult AdicionaReceita([FromBody] Receita receita)//recebe filme tipo Filme 
                                                               //FromBody quer dizer que vem do corpo da requisição
        {
            // if(!string.IsNullOrEmpty(receita.Nome))
            receita.Id = id++;
            receitas.Add(receita);//adiciona a receitas o parametro receita 
            return CreatedAtAction(nameof(RecuperaReceitaPorId), new {Id = receita.Id}, receita);
                                    //Mostra o Location para retornar o recurso (nome da action + id =  id da receita + object)

            Console.WriteLine(receita.Nome); //Garantia/verificação
        }


        /*------------ Retorna as receitas -----------*/
        [HttpGet]  
        public IEnumerable<Receita> RecuperaReceitas()
            //IEnumerable permite que o método não quebre caso mude algo na lista
        {
            return receitas;
        }


        /*------------ Get retornará um id -----------*/
        [HttpGet("{id}")] 
        public IActionResult RecuperaReceitaPorId(int id)
            //IActionResult retorno de ação
        {
            Receita receita =  receitas.FirstOrDefault(receita => receita.Id == id);
                //retorna o primeiro elemento que encontrar ou default(null)
                //no qual o elemento é um receita e o id da receita é igual ao id passado
            if (receita != null)
            {
               return Ok(receita);
            }
            else
            {
               return NotFound();
            }   
            

            /*foreach (Receita receita in receitas)
            *{
            *    if(receita.Id == id)
            *    {
            *        return receita;
            *    }
            *}
            *return null;
            */
        }
    }
}
