using WebApp.Models;

namespace WebApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }
        public void Configure(IApplicationBuilder app)
        {               //Request => response é configurada no IAplicationBuilder ( Request pipeline)

            //criar coleção de objetos que representam rotas 
            var builder = new RouteBuilder(app);
            builder.MapRoute("Estudos/ParaEstudar", EstudosParaEstudar);//cria cada rota
            builder.MapRoute("Estudos/Estudando", EstudosEstudando);
            builder.MapRoute("Cadastro/NovoEstudo/{nome}/{tipo}", NovoEstudoParaEstudar);

            //Rotas com Template Cadastro/NovoEstudo/{nome}/{tipo}
            
            //controi as rotas
            var rotas = builder.Build();

            app.UseRouter(rotas);

           // app.Run(Roteamento); 
        }

        private Task NovoEstudoParaEstudar(HttpContext context)
        {
            throw new NotImplementedException();
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
