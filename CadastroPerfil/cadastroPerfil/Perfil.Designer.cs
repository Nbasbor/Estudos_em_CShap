namespace cadastroPerfil
{
    public partial class FormPerfil 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public virtual void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtProfissão = new System.Windows.Forms.Label();
            this.txtHobbies = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.Label();
            this.lstPublicacao = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Location = new System.Drawing.Point(12, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(51, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(12, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(48, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "Email";
            // 
            // txtProfissão
            // 
            this.txtProfissão.AutoSize = true;
            this.txtProfissão.Location = new System.Drawing.Point(12, 192);
            this.txtProfissão.Name = "txtProfissão";
            this.txtProfissão.Size = new System.Drawing.Size(75, 20);
            this.txtProfissão.TabIndex = 2;
            this.txtProfissão.Text = "Profissão";
            // 
            // txtHobbies
            // 
            this.txtHobbies.AutoSize = true;
            this.txtHobbies.Location = new System.Drawing.Point(12, 264);
            this.txtHobbies.Name = "txtHobbies";
            this.txtHobbies.Size = new System.Drawing.Size(68, 20);
            this.txtHobbies.TabIndex = 3;
            this.txtHobbies.Text = "Hobbies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Profissão:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hobbies:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSair.Location = new System.Drawing.Point(0, 425);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(525, 44);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPublicar
            // 
            this.btnPublicar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPublicar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPublicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPublicar.Location = new System.Drawing.Point(0, 379);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(525, 46);
            this.btnPublicar.TabIndex = 15;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = false;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sexo:";
            // 
            // txtSexo
            // 
            this.txtSexo.AutoSize = true;
            this.txtSexo.Location = new System.Drawing.Point(12, 337);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(45, 20);
            this.txtSexo.TabIndex = 17;
            this.txtSexo.Text = "Sexo";
            // 
            // lstPublicacao
            // 
            this.lstPublicacao.FormattingEnabled = true;
            this.lstPublicacao.ItemHeight = 20;
            this.lstPublicacao.Location = new System.Drawing.Point(200, 9);
            this.lstPublicacao.Name = "lstPublicacao";
            this.lstPublicacao.Size = new System.Drawing.Size(313, 364);
            this.lstPublicacao.TabIndex = 19;
            // 
            // FormPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(525, 469);
            this.Controls.Add(this.lstPublicacao);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHobbies);
            this.Controls.Add(this.txtProfissão);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Name = "FormPerfil";
            this.Text = "Perfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label txtNome;
        public System.Windows.Forms.Label txtEmail;
        public System.Windows.Forms.Label txtProfissão;
        public System.Windows.Forms.Label txtHobbies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label txtSexo;
        public System.Windows.Forms.ListBox lstPublicacao;
    }
}