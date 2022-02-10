namespace WebApp.Models
{
    public class EstudoRepositorioFake
    {
        private ListaDeEstudos _paraEstudar;
        private ListaDeEstudos _Estudando;

        public EstudoRepositorioFake()
        {
            var e1 = new Estudo { Nome = "ASP.NET Core MVC", Tipo = "Programação Back-end" };
            var e2 = new Estudo { Nome = "ASP.NET Web Api", Tipo = "Programação Back-end" };
            var e3 = new Estudo { Nome = "Html e CSS", Tipo = "Desenvolvimento Front-end" };
            var e4 = new Estudo { Nome = "Programação Orientada a Objetos", Tipo = "Desenvolvimento Back-end" };
            var e5 = new Estudo { Nome = "Azure fundamentals", Tipo = "Centificação/Conceitos de Cloud" };
            var e6 = new Estudo { Nome = "Azure database", Tipo = "Certificação/Conceitos de Cloud" };

            _paraEstudar = new ListaDeEstudos("Para Estudar", e2, e5);
            _Estudando = new ListaDeEstudos("Estudando", e1, e3, e4, e6);
        }
        public ListaDeEstudos ParaEstudar => _paraEstudar;
        public ListaDeEstudos Estudando => _Estudando;

        public IEnumerable<Estudo> Todos => throw new System.NotImplementedException();

        public void Incluir(Estudo estudo)
        {
            throw new System.NotImplementedException();
        }
    }
}
