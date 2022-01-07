using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurriculoCadastroBD
{
    public partial class FrmEntrar : Form
    {
        FrmPerfil perfilUser = new FrmPerfil();

        public FrmEntrar()
        {
            InitializeComponent();
        }



        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioCurriculo userCurriculo = new UsuarioCurriculo();
            DataTable dadosUsuario;

            dadosUsuario = userCurriculo.LocalizarPorEmail(txtEmail.Text, txtSenha.Text);
            if(dadosUsuario.Rows.Count > 0)
            {
                if(dadosUsuario.Rows[0][8].ToString()==txtSenha.Text)
                txtEmail.Text = dadosUsuario.Rows[0][1].ToString();
                txtSenha.Text = dadosUsuario.Rows[0][8].ToString();
                perfilUser.lblNome.Text = dadosUsuario.Rows[0][1].ToString();
                perfilUser.lblCPF.Text = dadosUsuario.Rows[0][2].ToString();
                perfilUser.lblProfissao.Text = dadosUsuario.Rows[0][3].ToString();
                perfilUser.lblArea.Text = dadosUsuario.Rows[0][4].ToString();
                perfilUser.lblEstado.Text = dadosUsuario.Rows[0][5].ToString();
                perfilUser.lblNascionalidade.Text = dadosUsuario.Rows[0][6].ToString();
                perfilUser.lblCidade.Text = dadosUsuario.Rows[0][7].ToString();
                perfilUser.lblEndereco.Text = dadosUsuario.Rows[0][9].ToString();


                MessageBox.Show("Entrando...");
                perfilUser.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou Senha errados!");
            }
                
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
