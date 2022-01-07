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
    public partial class FrmCadastro : Form
    {
        
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();   
            UsuarioCurriculo userCurriculo = new UsuarioCurriculo();
            int gravou;
            user.Nome = txtNome.Text;
            user.Email = txtEmail.Text;
            user.CPF = txtCPF.Text; 
            user.Profissao = txtProfissao.Text;
            user.Area = txtArea.Text;
            user.Estado = txtEstado.Text;
            user.Nascionalidade = txtNascionalidade.Text;
            user.Cidade = txtCidade.Text;
            user.Senha = txtSenha.Text;
            user.Endereco = txtEndereco.Text;
            try
            {
                gravou = userCurriculo.CadastrarUsuarios(user);
                MessageBox.Show("Usuario cadastrato com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao cadastrar cliente" + ex.Message);
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
