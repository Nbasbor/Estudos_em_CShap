namespace cadastroPerfil
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbMas = new System.Windows.Forms.RadioButton();
            this.rdbOutro = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmdDia = new System.Windows.Forms.ComboBox();
            this.cmbAno = new System.Windows.Forms.TextBox();
            this.txtHobbies = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProfissao = new System.Windows.Forms.ComboBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEntrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEntrar.Location = new System.Drawing.Point(0, 229);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(612, 52);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Criar Cadastro";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(290, 26);
            this.txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(336, 46);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email:";
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Location = new System.Drawing.Point(16, 111);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(99, 24);
            this.rdbFem.TabIndex = 7;
            this.rdbFem.TabStop = true;
            this.rdbFem.Text = "Feminino";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gênero:";
            // 
            // rdbMas
            // 
            this.rdbMas.AutoSize = true;
            this.rdbMas.Location = new System.Drawing.Point(121, 111);
            this.rdbMas.Name = "rdbMas";
            this.rdbMas.Size = new System.Drawing.Size(105, 24);
            this.rdbMas.TabIndex = 9;
            this.rdbMas.TabStop = true;
            this.rdbMas.Text = "Masculino";
            this.rdbMas.UseVisualStyleBackColor = true;
            // 
            // rdbOutro
            // 
            this.rdbOutro.AutoSize = true;
            this.rdbOutro.Location = new System.Drawing.Point(232, 111);
            this.rdbOutro.Name = "rdbOutro";
            this.rdbOutro.Size = new System.Drawing.Size(74, 24);
            this.rdbOutro.TabIndex = 10;
            this.rdbOutro.TabStop = true;
            this.rdbOutro.Text = "Outro";
            this.rdbOutro.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data de Nascimento:";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMes.Location = new System.Drawing.Point(336, 111);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(62, 28);
            this.cmbMes.TabIndex = 12;
            // 
            // cmdDia
            // 
            this.cmdDia.FormattingEnabled = true;
            this.cmdDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmdDia.Location = new System.Drawing.Point(404, 111);
            this.cmdDia.Name = "cmdDia";
            this.cmdDia.Size = new System.Drawing.Size(62, 28);
            this.cmdDia.TabIndex = 13;
            // 
            // cmbAno
            // 
            this.cmbAno.Location = new System.Drawing.Point(472, 111);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(116, 26);
            this.cmbAno.TabIndex = 14;
            // 
            // txtHobbies
            // 
            this.txtHobbies.Location = new System.Drawing.Point(168, 177);
            this.txtHobbies.Name = "txtHobbies";
            this.txtHobbies.Size = new System.Drawing.Size(145, 26);
            this.txtHobbies.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hobbies:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Profissão:";
            // 
            // cmbProfissao
            // 
            this.cmbProfissao.FormattingEnabled = true;
            this.cmbProfissao.Items.AddRange(new object[] {
            "Design",
            "Desenvolvimento",
            "Gerente de Projeto",
            "Gestor",
            "Marketing",
            "Negócios",
            "Analise de Dados",
            "Segurança",
            "Infraestrutura"});
            this.cmbProfissao.Location = new System.Drawing.Point(336, 175);
            this.cmbProfissao.Name = "cmbProfissao";
            this.cmbProfissao.Size = new System.Drawing.Size(252, 28);
            this.cmbProfissao.TabIndex = 18;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(16, 177);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(145, 26);
            this.txtSenha.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Senha:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(612, 281);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbProfissao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHobbies);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.cmdDia);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbOutro);
            this.Controls.Add(this.rdbMas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbFem);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEntrar);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbMas;
        private System.Windows.Forms.RadioButton rdbOutro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmdDia;
        private System.Windows.Forms.TextBox cmbAno;
        private System.Windows.Forms.TextBox txtHobbies;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProfissao;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label7;
    }
}