using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CurriculoCadastroBD
{
    public class UsuarioCurriculo
    {
        public UsuarioCurriculo()
        {

        }

        public int CadastrarUsuarios(Usuario user)
        {
            int gravou;
            SqlCommand comando = new SqlCommand();
            SqlConnection conexaoBD = new SqlConnection();
            Curriculo dadosCurriculo = new Curriculo();

            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "CadastrarUsuarios";

            comando.Parameters.AddWithValue("@nome", user.Nome);
            comando.Parameters.AddWithValue("@email", user.Email);
            comando.Parameters.AddWithValue("@cpf", user.CPF);
            comando.Parameters.AddWithValue("@profissao", user.Profissao);
            comando.Parameters.AddWithValue("@area", user.Area);
            comando.Parameters.AddWithValue("@estado", user.Estado);
            comando.Parameters.AddWithValue("@nascionalidade", user.Nascionalidade);
            comando.Parameters.AddWithValue("@cidade", user.Cidade);
            comando.Parameters.AddWithValue("@senha", user.Senha);
            comando.Parameters.AddWithValue("@endereco", user.Endereco);
            dadosCurriculo = new Curriculo();

            conexaoBD = dadosCurriculo.GetConnection();

            comando.Connection = conexaoBD;


            try
            {
                gravou = comando.ExecuteNonQuery();//Não retorna dados 

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível cadastrar novo usuario\n" + ex.Message);
            }
            finally
            {


                conexaoBD.Close();
            }

            return gravou;
        }

        public DataTable LocalizarPorEmail(string email,string senha)
        {
            DataTable dadosUser = new DataTable();
            SqlDataAdapter adptUsuarios;

            Curriculo dadosCurriculo = new Curriculo();
            SqlConnection conexaoBD = new SqlConnection();
            conexaoBD = dadosCurriculo.GetConnection();

            adptUsuarios = new SqlDataAdapter("usuarioPorEmail", conexaoBD);
            adptUsuarios.SelectCommand.CommandType = CommandType.StoredProcedure;
            adptUsuarios.SelectCommand.Parameters.AddWithValue("@email", email);
            adptUsuarios.SelectCommand.Parameters.AddWithValue("@senha", senha);

            try
            {
                adptUsuarios.Fill(dadosUser);
            }
            catch (Exception e)
            {
                throw new Exception("Login ou senha errados\n" + e.Message);
            }
            return dadosUser;

        }
    }
    }

