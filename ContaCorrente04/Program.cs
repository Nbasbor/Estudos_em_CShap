using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();
            // gabriela é uma referência a um objeto
            // conta.titular = new Cliente();
            // conta.titula.nome = "gabriela";
            // conta.titular.profissao = "Desenvolvedora";
            // conta.titular.cpf = "12345678910";




            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora";
            gabriela.cpf = "12345678910"


            ContaCorrente conta = new ContaCorrente();

            conta.Titular = gabriela;
            conta.Agencia = 863;
            conta.Conta = 863452;
            conta.Saldo = 200;
;           

            Console.WriteLine(conta.titular.nome);
            Console.ReadLine();
        }
    }
}
