using WebApp.Models;

namespace WebApp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {               //Request => response é configurada no IAplicationBuilder ( Request pipeline)
            app.Run(Roteamento); 
        }
        public Task Roteamento(HttpContext contexto)
        {
            //Estudos/ParaEstudar
            //Estudos//Estudando

            //Dicionario dos caminhos
            var _repo = new EstudoRepositorioCVS();
            var caminhosAtendidos = new Dictionary<string, string> //configura os caminhos da request
            {
                { "/Estudos/ParaEstudar", _repo.ParaEstudar.ToString()},
                { "/Estudos/Estudando", _repo.Estudando.ToString()}
            };

            if (caminhosAtendidos.ContainsKey(contexto.Request.Path))
            {
                return contexto.Response.WriteAsync(caminhosAtendidos[contexto.Request.Path]);//da como resposta o valor que esta nos caminhos
            }
            return contexto.Response.WriteAsync("Caminho inexistente");//Metódo de caminho da requisição
        }
        public Task EstudosParaEstudar(HttpContext contexto)    
        {                         //Objeto tipo httpcontex que contém informações encapsuladas em Http
                                  //Task método de paralelismo
                        
            var _repo = new EstudoRepositorioCVS();

            return contexto.Response.WriteAsync(_repo.ParaEstudar.ToString());//Escreve como resposta asyncrona a lista Para estudar
           
        }
    }
}
