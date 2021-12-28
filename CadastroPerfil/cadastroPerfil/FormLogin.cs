using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroPerfil
{
    public partial class FormLogin : Form
    {
        //iniciando o formulario perfil
        FormPerfil fConta = new FormPerfil();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
            fConta.Show();
            this.Hide();



        }
        public void Cadastrar()
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            string email = txtEmail.Text;
            string diaString = cmdDia.SelectedItem.ToString();
            int dia = int.Parse(diaString);
            string mesString = cmbMes.SelectedItem.ToString();
            int mes = int.Parse(mesString);
            int ano = int.Parse(cmbAno.Text);
            int idade = 2021 - ano;

            //criando objeto usuario
            PerfilUsuario usuario = new PerfilUsuario(email, nome, senha, idade);
            usuario.Hobbies = txtHobbies.Text;
            usuario.Profissao = cmbProfissao.SelectedItem.ToString();

            //radio button
            string sexo;
            if (rdbFem.Checked)
            {
                sexo = "Feminino";
            }
            else if (rdbMas.Checked)
            {
                sexo = "Masculino";
            }
            else if (rdbOutro.Checked)
            {
                sexo = "Outro";
            }
            else
            {
                sexo = "";
            }
            usuario.Sexo = sexo;

            //criando perfil
            fConta.txtNome.Text = usuario.Nome;
            fConta.txtHobbies.Text = usuario.Hobbies;
            fConta.txtProfissão.Text = usuario.Profissao;
            fConta.txtEmail.Text = usuario.Email;
            fConta.txtSexo.Text = usuario.Sexo;
        }




    }
}
