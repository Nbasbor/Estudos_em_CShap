//using ContaCorrente03;


namespace ContaCorrente04
{
    public class ContaCorrente
    {
        
       
        public int Agencia { get; set; };
        public int Conta { get; set; };
        private double _saldo;
        //pode ser acessado somente nesse escopo 
        // _saldo " _ " no inicio do nome da variável para definir que é privado

        public Cliente Titular { get; set; }
        // simplificação do método abaixo,
        // não precisa abrir as chaves já que não existe verificação no método 
        // classe cliente no namespace ContaConrrente03

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
        *        //aqui nesse escopo exixte o saldo do escopo e o saldo da classe;
        *    }
        * }


        * public doulbe GetSaldo()
        * {
        *    return saldo;
        *    // dentro deste escopo o único saldo que existe é o private double saldo.
        * }
        */

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
    }
}
