using CatalogoDeProdutos;
using CatalogoDeProdutos.Models;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
IServiceProvider serviceProvider = (IServiceProvider)builder.Services; //Adiciona o IServiceProvider
var app = builder.Build();

IServiceProvider service = app.Services;
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<ICatalogo, Catalogo>();//Cria um serviço
    services.AddTransient<IRelatorios, Relatorios>();   
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

ICatalogo catalogo = serviceProvider.GetService<ICatalogo>();     //Injeção de dependencia
IRelatorios relatorio = serviceProvider.GetService<IRelatorios>();//o catalogo como parametro

app.Run(async (context) =>
{
   await relatorio.Imprimir(context); // método await espera a execução do método

});
