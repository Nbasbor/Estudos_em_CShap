using Microsoft.AspNetCore.Mvc;
using ReceitasAPI.Data;
using ReceitasAPI.Data.DTOs;
using ReceitasAPI.Models;
using System;


namespace ReceitasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")] //rota com o nome do controller "genérico"

    public class ReceitaController : ControllerBase //Herda do ControllerBase
    {
        //cria uma lista tipo Receita
        //private static List<Receita> receitas = new List<Receita>();
        //private static int id = 1;


        //Recupera dados pelo BD
        private ReceitaContext _context;

        public ReceitaController(ReceitaContext context)
        {
            _context = context; 
        }

        /*------------ Para criar um recuro -----------*/
        [HttpPost] 
        public IActionResult AdicionaReceita([FromBody] CreateReceitaDTOs receitaDTOs)//recebe filme tipo Filme 
                                                               //FromBody quer dizer que vem do corpo da requisição
        {
            // if(!string.IsNullOrEmpty(receita.Nome))
            //receita.Id = id++;
            //receitas.Add(receita);//adiciona a receitas o parametro receita 

            //Cria um objeto com as propeirdades de filme
            Receita receita = new Receita
            {
                Nome = receitaDTOs.Nome,
                Tipo = receitaDTOs.Tipo,
                Porcao = receitaDTOs.Porcao,
                Ingredientes = receitaDTOs.Ingredientes,
                Preparo = receitaDTOs.Preparo
            };

            //adiciona ao contexto a receita
            //_context.Receitas.Add(receita);


            _context.SaveChanges();//Salva as alteração (adição ao Banco)
            return CreatedAtAction(nameof(RecuperaReceitaPorId), new {Id = receita.Id}, receita);
                                    //Mostra o Location para retornar o recurso (nome da action + id =  id da receita + object)

            Console.WriteLine(receita.Nome); //Garantia/verificação
        }


        /*------------ Retorna as receitas -----------*/
        [HttpGet]  
        public IEnumerable<Receita> RecuperaReceitas()
            //IEnumerable permite que o método não quebre caso mude algo na lista
        {
            //return receitas;
            return (_context.Receitas);
        }


        /*------------ Get retornará um id -----------*/
        [HttpGet("{id}")] 
        public IActionResult RecuperaReceitaPorId(int id)
            //IActionResult retorno de ação
        {
            Receita receita =  _context.Receitas.FirstOrDefault(receita => receita.Id == id);
                //retorna o primeiro elemento que encontrar ou default(null)
                //no qual o elemento é um receita e o id da receita é igual ao id passado

            if (receita != null)
            {
               //return Ok(receita);
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

        [HttpPut("{id}")]
        public IActionResult AtualizaReceita(int id, [FromBody] Receita receitaAtualizado)// a partir do corpo da requisição receberá uma receita atualizada
        {
            Receita receita = _context.Receitas.FirstOrDefault(receita => receita.Id == id);
            if(receita == null)
            {
                return NotFound();
            }
            else
            {
                receita.Nome = receitaAtualizado.Nome;   
                receita.Porcao = receitaAtualizado.Porcao;  
                receita.Ingredientes = receitaAtualizado.Ingredientes;
                receita.Preparo = receitaAtualizado.Preparo;  
                receita.Tipo = receitaAtualizado.Tipo;
                _context.SaveChanges();
                return NoContent();//Boas práticas de retorno de atualização
            }
        }

        [HttpDelete("{id")]
        public IActionResult DeletaReceita(int id)
        {
            Receita receita = _context.Receitas.FirstOrDefault(receita => receita.Id == id);
            {
                if(receita == null)
                {
                    return NotFound();
                }
                _context.Remove(receita);//Delete Receita
                _context.SaveChanges();
                return NoContent();

            }
        }
    }
}
