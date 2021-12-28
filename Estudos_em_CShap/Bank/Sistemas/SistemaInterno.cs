using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Funcionario;

namespace Bank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if(usuarioAutenticado)
            {
                Console.WriteLine("Bem Vindo");
                return true;
            }

            else
            {
                Console.WriteLine("Senha Incorreta");
                return false;
            }
        }

    }
}
