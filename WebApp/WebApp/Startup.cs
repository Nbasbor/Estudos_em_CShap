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
            var caminhosAtendidos = new Dictionary<string, RequestDelegate> //configura os caminhos da request como string e requesteDelegate
            {
                { "/Estudos/ParaEstudar", EstudosParaEstudar },
                { "/Estudos/Estudando", EstudosEstudando }
            };

            if (caminhosAtendidos.ContainsKey(contexto.Request.Path))
            {
                var metodo = caminhosAtendidos[contexto.Request.Path];//da como resposta o valor que esta nos caminhos
                return metodo.Invoke(contexto);//retorna uma variavel request delegate
            }
            contexto.Response.StatusCode = 404;
            return contexto.Response.WriteAsync("Caminho inexistente");//Metódo de caminho da requisição
        }
        public Task EstudosParaEstudar(HttpContext contexto)    
        {                         //Objeto tipo httpcontex que contém informações encapsuladas em Http
                                  //Task método de paralelismo
                        
            var _repo = new EstudoRepositorioCVS();

            return contexto.Response.WriteAsync(_repo.ParaEstudar.ToString());//Escreve como resposta asyncrona a lista Para estudar
           
        }
        public Task EstudosEstudando(HttpContext contexto)
        {
            var _repo = new EstudoRepositorioCVS();
            return contexto.Response.WriteAsync(_repo.Estudando.ToString());
        }
    }
}
