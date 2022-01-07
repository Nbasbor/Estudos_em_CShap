using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CurriculoCadastroBD
{
    public class Curriculo
    {
        string strCon;
        SqlConnection con;

        public Curriculo()
        {
            strCon = "Data Source=WINAP0KZ3IOST0R\\SQLEXPRESS;  " + //servidor sqlserver \\ para especificar que tem uma barra invertida e não é \n
                            "Initial Catalog=curriculo; " + //banco que será conectado
                            "Integrated Security=True";//ativando a segurança integrada do windows
        }
        public SqlConnection GetConnection()
        {
            con = new SqlConnection(strCon);
            try
            {
                con.Open(); // tenta abrir o Banco de dados
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao conectar o banco\n" + ex.Message);
            }
            return con;
        }
    }
}
