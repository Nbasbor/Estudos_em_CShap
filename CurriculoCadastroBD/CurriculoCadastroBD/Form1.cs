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
   
    public partial class Form1 : Form
    {
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastro cadastro = new FrmCadastro();
            cadastro.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FrmEntrar entrar = new FrmEntrar();
            entrar.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
