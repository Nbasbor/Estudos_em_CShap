using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using byteBankSistemaAgencia.Modelos.funcionarios;

namespace byteBankSistemaAgencia.Modelos.Sistemas
{
    public interface IAutenticavel
    //IAutentificavel = nomemclatura convencional com I maiúsculo na frente para Identificar Interface
    //interfaces possuem métodos vazios(sem implementação) e podem ser herdados junto com classes principais
    {

        bool Autenticar(string senha);
   
            //Autenticavel quando Classe Abstrata
        /*  public string Senha { get; set; }

          public Autenticavel(double salario, string cpf)
              :base(salario, cpf)
          {

          }
          public bool Autenticar(string senha)
          {
             return Senha == senha;
          }
        */

    }
}
