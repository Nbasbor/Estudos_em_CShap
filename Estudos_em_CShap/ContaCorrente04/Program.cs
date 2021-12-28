﻿using System;
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




            gabriela.Nome = "Gabriela";
            gabriela.Profissao = "Desenvolvedora";
            gabriela.CPF = "12345678910"


            try
            {
                ContaCorrente conta = new ContaCorrente(863, 863452);
                // agencia = 863, conta = 863452
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Saldo);
                Console.WriteLine(ex.ValorSaque);
                Console.WriteLine(ex.Message);
                //Exibe a mensage padrão da exceção
                Console.WriteLine("Exceção do tipo SaldoInsuficiente.");
            }
            //finally
            //{
            //Sempre será realizado, tendo erro ou não!
            //}



            conta.Titular = gabriela;
            //conta.Agencia = 863;
            //conta.Conta = 863452;
            conta.Saldo = 200;
;           

            Console.WriteLine(conta.Titular.Nome);
            Console.ReadLine();


            ContaCorrente contaRafael = new ContaCorrente(863, 863451);
            contaRafael.Titular = "Rafael";

            contaGabriela.Transferir(100, contaRafael);
            Console.WriteLine($"Saldo de Rafael: {contaRafael.saldo}");
 
            Console.ReadLine();
        }

    }
}