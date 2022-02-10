using System.IO;
using System.Linq;
using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace WebApp.Models

{
    public class EstudoRepositorioCVS
    {
        private static readonly string nomeArquivoCSV = "Models\\estudos.csv";
        private ListaDeEstudos _paraEstudar;
        private ListaDeEstudos _estudando;
        
        public EstudoRepositorioCVS()
        {
            var arrayParaEstudar = new List<Estudo>(); //cria variavel para armazenar a lista de Estudp paraEstudar
            var arrayEstudando = new List<Estudo>();

            using (var file = File.OpenText(EstudoRepositorioCVS.nomeArquivoCSV))
            {
                while (!file.EndOfStream)
                {
                    var textoEstudo = file.ReadLine();
                    if (string.IsNullOrEmpty(textoEstudo))
                    {
                        continue;
                    }
                    var infoEstudo = textoEstudo.Split(';');
                    var estudo = new Estudo
                    {
                        Id = Convert.ToInt32(infoEstudo[1]),
                        Nome = infoEstudo[2],
                        Tipo = infoEstudo[3]
                    };
                    switch (infoEstudo[0])
                    {
                        case "para-estudar":
                            arrayParaEstudar.Add(estudo);
                            break;
                        case "estudando":
                            arrayEstudando.Add(estudo);
                            break;
                        default:
                            break;
                    }
                }
            }

            _paraEstudar = new ListaDeEstudos("Para Estudar", arrayParaEstudar.ToArray());
            _estudando = new ListaDeEstudos("Estudando", arrayEstudando.ToArray());


        }

        public ListaDeEstudos ParaEstudar => _paraEstudar;
        public ListaDeEstudos Estudando => _estudando;

        public IEnumerable<Estudo> todos => _paraEstudar.Estudos.Union(_estudando.Estudos);

        public void Incluir(Estudo estudo)
        {
            var id = todos.Select(l => l.Id).Max();
            using(var file = File.AppendText(EstudoRepositorioCVS.nomeArquivoCSV))
            {
                file.WriteLine($"para-estudar;{id + 1};{estudo.Nome};{estudo.Tipo}");
            }
        }


    }   
}
