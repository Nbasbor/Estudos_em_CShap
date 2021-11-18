//using ContaCorrente03;


namespace ContaCorrente04
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
       
        public int Agencia { get; private set; }

        private readonly int _numero;
        //privado e somente leitura 
        public int Conta { 
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
                if(value < 0)
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

        private static int TotalContasCriadas { get; private set; };
        //static é uma caracteristica estática da classe;
        //private set : privado para impossibilitar modificação externa


        public ContaCorrente(int agencia, int conta)
            //Construtor da Classe ContaCorrente (Agencia e Conta)
        {
            Agencia = Agencia;
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
            catch(DivideByZeroException e)
            //pega a excessão (erro) e realiza uma ação
            {
                Console.WriteLine("Não é possível dividir por 0");
                Console.WriteLine(e.Message);
                //mensagem do erro
                Console.WriteLine(e.StackTrace);
                //rota do erro 
                throw;
                //throw passa a exceção a diante
            }

        }


        public bool Sacar(double valor)
        //função de verificação para sacar saldo
        // todo nome de função começa com letra maiuscula
        //Convenção da nomeação de verbo em infinitivo
        {
            if (this._saldo < valor)
            //this.saldo faz verificação na propriedade saldo da própria classe
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
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


    * public double GetSaldo()
    * {
    *    return saldo;
    *    // dentro deste escopo o único saldo que existe é o private double saldo.
    * }
    */
    }
}
