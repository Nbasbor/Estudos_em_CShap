using WebApp.Models;

namespace WebApp
{
    public interface ILivroRepositorio
    {
        ListaDeEstudos ParaEstudar { get; } 
        ListaDeEstudos Estudando { get; }   
        IEnumerable<Estudo> Todos { get; }
        void Incluir(Estudo estudo);

        

    }
}
