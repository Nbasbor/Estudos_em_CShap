using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace netGram2
{
    public class Publicacao
    {
        public string Titulo { get; set; }
        public int Data { get; set; }
        public string Motivo { get; set; }
        public string Texto { get; set; }   

        public Publicacao()
        {

            Console.WriteLine("Titulo da publicação:");
            this.Titulo = Console.ReadLine();

            Console.WriteLine("Data da publicação:");
            this.Data = int.Parse(Console.ReadLine());


            Console.WriteLine("Genero da publicação:");
            Motivo = Console.ReadLine();

            Console.WriteLine("Texto da publicação:");
            Texto = Console.ReadLine();


        }

    }
}
