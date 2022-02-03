using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using ReceitasAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

////Add AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());//Especificar onde ser� usado no c�digo o automapper
//Add string de connec��o
builder.Services.AddDbContext<ReceitaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ReceitaConnection")));
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();