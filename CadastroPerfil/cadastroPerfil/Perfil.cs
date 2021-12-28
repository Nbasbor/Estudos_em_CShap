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
    public partial class FormPerfil : Form
    {
        public FormPerfil()
        {
            InitializeComponent();
            

        }
        public void Abrir()
        {
            this.Show();
        }


        private void btnPublicar_Click(object sender, EventArgs e)
        {
            FormPublicação fpublicacao = new FormPublicação();
            fpublicacao.Show();
            this.Hide();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
