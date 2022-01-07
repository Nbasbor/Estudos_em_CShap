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
                MessageBox.Show("Entrando...");
            }
            else
            {
                MessageBox.Show("Login ou Senha errados!");
            }
                
        }
    }
}
