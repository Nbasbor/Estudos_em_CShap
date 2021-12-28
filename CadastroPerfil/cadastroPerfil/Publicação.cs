using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace cadastroPerfil
{
    public partial class FormPublicação : Form
    {
        List<Publicacao> publicar = new List<Publicacao>();
        public FormPublicação()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Publicar();
            
            int escolha = int.Parse(Interaction.InputBox("Deseja fazer outra publicação ?\n\n" + "Digite (1 - Sim | 2 - Sair) "));
            switch (escolha)
            {
                case 1:
                    //criar publicação nova
                    Publicar();
                    
                    txtTema.Clear();
                    txtTitulo.Clear();
                    rctTexto.Clear();   
                    break;
                case 2:
                    Environment.Exit(0);
                //    //Ver publicações
                //    FormPerfil fperfil = new FormPerfil();
                //    fperfil.Show();
                //    this.Hide();
                   break;
                default:
                    MessageBox.Show("Escolha uma opção válida!");
                    break;
            }
        }
        public void Publicar()
        {
                
            string titulo = txtTitulo.Text;
            string tema = txtTema.Text;
            string texto = rctTexto.Text;

            DialogResult dialogresult = MessageBox.Show($"Sua publicação: \n\n" + $"Título: {titulo}\nTema: {tema}\nTexto: {texto}", "Publicar", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                publicar.Add(new Publicacao(titulo, tema, texto)
                {
                    Titulo = titulo,
                    Tema = tema,
                    Texto = texto,
                });

                MessageBox.Show("Publicação Concluida!\n\n");
            }
            else
            {
                MessageBox.Show("Publicação Cancelada!\n\n");
            }

            //Listar Publicação
            FormPerfil fConta = new FormPerfil();
            fConta.lstPublicacao.Items.Add(titulo.ToString());
            fConta.lstPublicacao.Items.Add(tema.ToString());
            fConta.lstPublicacao.Items.Add(texto.ToString());
            //Publicacao publicacao = new Publicacao;
           

    
        }

    }
}
