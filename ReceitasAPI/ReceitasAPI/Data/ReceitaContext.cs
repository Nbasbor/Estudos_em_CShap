using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using ReceitasAPI.Models;


namespace ReceitasAPI.Data
{
    public class ReceitaContext : DbContext //Contexto de comunicação com o banco de dados
    {
        public ReceitaContext(DbContextOptions<ReceitaContext> options) : base(options) 
            //o Constutor recebe como parametro as opções do Contexto ReceitaContext 
        {

        }

        public DbSet<Receita> Receitas { get; set; }    
            //Objeto Receita e propeiredade Receitas
            //Após isso necessário cria a string de conexão no appsettings.json


    }
}
