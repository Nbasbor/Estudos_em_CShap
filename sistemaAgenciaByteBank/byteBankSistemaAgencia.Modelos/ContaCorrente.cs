﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankSistemaAgencia.Modelos
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public int Agencia { get; private set; }

        private readonly int _numero;
        //privado e somente leitura 
        public int Conta
        {
            get
            {
                return _numero;
                //retorna numero privado 
            }

        }
        //public int Conta { get; }
        //Igual a versão de cima, porém simplificada


        public Cliente Titular { get; set; }
        // simplificação do método abaixo,
        // não precisa abrir as chaves já que não existe verificação no método 
        // classe cliente no namespace ContaConrrente03

        private double _saldo;
        //pode ser acessado somente nesse escopo 
        // _saldo " _ " no inicio do nome da variável para definir que é privado

        public double Saldo
        {
            get
            {
                return _saldo;
                //método get saldo
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                    //valor da classe saldo 
                }
            }
        }

        public static int TotalContasCriadas { get; private set; }
        //static é uma caracteristica estática da classe;
        //private set : privado para impossibilitar modificação externa


        public ContaCorrente(int agencia, int conta)
        //Construtor da Classe ContaCorrente (Agencia e Conta)
        {
            if (agencia <= 0)
            {

                throw new ArgumentException("O argumento da agência deve ser maiores que 0.", nameof(agencia));
                //lança uma nova excessão do tipo argumento com o parametro definido agencia
                //nameof() se referen ao nome do parametro
                //Terminar as frases com a pontuação correta é uma boa pratica
            }
            else if (conta <= 0)
            {
                throw new ArgumentException("O argumento da conta deve ser maiores que 0.", nameof(conta));
                //lança uma nova excessão do tipo argumento com o parametro definido "conta"
            }

            Agencia = agencia;
            _numero = conta;

            ContaCorrente.TotalContasCriadas++;
            //incrementa o total de contascriadas

            try
            //tentativa de execução do código
            {
                TaxaOperacao = 30 / TotalContasCriadas;
                //calculo da taxa de operação
                Console.WriteLine("A taxa de operações é: " + TaxaOperacao);
            }
            catch (DivideByZeroException ex)
            //pega a excessão (erro) e realiza uma ação
            //ex nomenclatura convencional de erro
            {
                Console.WriteLine("Não é possível dividir por 0");
                Console.WriteLine(ex.Message);
                //mensagem do erro
                Console.WriteLine(ex.StackTrace);
                //rota do erro 
                throw;
                //throw passa a exceção a diante
            }

        }


        public void Sacar(double valor)
        //função de verificação para sacar saldo
        // todo nome de função começa com letra maiuscula
        //Convenção da nomeação de verbo em infinitivo
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para saque. ", nameof(valor));
            }
            if (this._saldo < valor)
            //this.saldo faz verificação na propriedade saldo da própria classe
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this._saldo -= valor;

            }

        }

        public void Depositar(double valor)
        //função void é uma função sem retorno que apenas faz uma ação
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        // tipo ContaCorrente variável contaDestino
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para tranferência. ", nameof(valor));
            }
            if (this._saldo < valor)
            {
                return false;
                // depois do retorno o método para
                // Uma boa prática é retorna uma condição que não permite que a função seja executada
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
                // método despositar o valor 
            }

        }
        /*
 * public void SetSaldo(double saldo)
 * {
 *    if(saldo < 0)
 *    {
 *       return;
 *        // return no método void não retorna nada apenas para de executar o método;
 *    }
 *    else
 *    {
 *        this.saldo = saldo;
 *        //aqui nesse escopo existe o saldo do escopo e o saldo da classe;
 *    }
 * }
 * Ctrl+k+c comenta o códido


 * public double GetSaldo()
 * {
 *    return saldo;
 *    // dentro deste escopo o único saldo que existe é o private double saldo.
 * }
 */
    }
}