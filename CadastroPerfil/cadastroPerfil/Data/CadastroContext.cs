using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace cadastroPerfil.Data
{
    public class CadastroContext : DbContext //herda da classe DbContext
    {
        //public CadastroContext(DbContextOptions<CadastroContext> options) : base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WINAP0KZ3IOST0R\\SQLEXPRESS;Database=receitasDb;Trusted_Connection=True");
        }
        public DbSet<PerfilUsuario> Usuarios { get; set; }  
        //cria tabela alunos


    }
}
