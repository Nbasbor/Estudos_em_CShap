using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Funcionario;

namespace Bank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;
        public void Registrar(Funcionario funcionario)
            // retorna vazio, não precisa de retorno
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }
        public void Registrar(Diretor diretor)
            // dois métodos com mesmo nome são válidos quando tem argumentos diferentes, exemplo diretor/funcionario
            //um método que recebe várias cargas 
        {
            _totalBonificacao += diretor.GetBonificacao();
        }
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
