using WebApp.Models;

namespace WebApp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {               //Request => response é configurada no IAplicationBuilder ( Request pipeline)
            app.Run(EstudosParaEstudar); 
        }
        public Task EstudosParaEstudar(HttpContext contexto)
        {                         //Objeto tipo httpcontex que contém informações encapsuladas em Http
                                  //Task método de paralelismo
                        
            var _repo = new EstudoRepositorioCVS();

            return contexto.Response.WriteAsync(_repo.ParaEstudar.ToString());//Escreve como resposta asyncrona a lista Para estudar
           
        }
    }
}
