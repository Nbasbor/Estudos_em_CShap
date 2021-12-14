using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetGram.Usuario

namespace NetGram
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario novo = new usuario("nan", "nan@");
                novo.Profissao = "dev";

            Console.WriteLine(novo.Nome);
            Console.WriteLine(novo.Email);
            Console.WriteLine(novo.Profissao);
            Console.ReadLine();
        }
    }
}
