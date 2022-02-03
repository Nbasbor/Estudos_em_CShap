﻿using Microsoft.AspNetCore.Mvc;
using ReceitasAPI.Data;
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
        public IActionResult AdicionaReceita([FromBody] Receita receita)//recebe filme tipo Filme 
                                                               //FromBody quer dizer que vem do corpo da requisição
        {
            // if(!string.IsNullOrEmpty(receita.Nome))
            //receita.Id = id++;
            //receitas.Add(receita);//adiciona a receitas o parametro receita 

            //adiciona ao contexto a receita
            _context.Receitas.Add(receita);
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
    }
}