using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente04
{
   public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        //propriedades com set readonly
        public SaldoInsuficienteException()
            // construtor que não recebe mensagem
        {

        }
        public SaldoInsuficienteException(double saldo, double valorSaque) 
            : this("Saldo insuficiente para o saque no valor de: " + valorSaque + "em uma conta com saldo de: " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
            //case sensitive , propriedade Saldo com S maiusculo;
            //E argumento saldo com s em minusculo
        }
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
             //construtor que recebe mensagem
        {
        
        }
        
    }
}
