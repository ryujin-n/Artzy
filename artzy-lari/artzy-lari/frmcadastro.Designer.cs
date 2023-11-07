namespace artzy_lari
{
    partial class frmcadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btocriarconta = new System.Windows.Forms.Button();
            this.cboprof = new System.Windows.Forms.ComboBox();
            this.txtnovsenha = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btocriarconta);
            this.groupBox1.Controls.Add(this.cboprof);
            this.groupBox1.Controls.Add(this.txtnovsenha);
            this.groupBox1.Controls.Add(this.txtsenha);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Digite a senha novamente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usúario";
            // 
            // btocriarconta
            // 
            this.btocriarconta.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btocriarconta.Location = new System.Drawing.Point(156, 300);
            this.btocriarconta.Name = "btocriarconta";
            this.btocriarconta.Size = new System.Drawing.Size(104, 41);
            this.btocriarconta.TabIndex = 6;
            this.btocriarconta.Text = "Criar conta";
            this.btocriarconta.UseVisualStyleBackColor = true;
            this.btocriarconta.Click += new System.EventHandler(this.btocriarconta_Click);
            // 
            // cboprof
            // 
            this.cboprof.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboprof.ForeColor = System.Drawing.Color.Black;
            this.cboprof.FormattingEnabled = true;
            this.cboprof.Items.AddRange(new object[] {
            "Produtor musical",
            "Professor de música",
            "Bailarino profissional",
            "Coreógrafo",
            "Produtor audiovisual",
            "Animador",
            "Artista plástico",
            "Diretor de cena",
            "Diretor de imagem",
            "Roteirista",
            "Escritor",
            "Revisor",
            "Ator",
            "Fotógrafo",
            "Editor de imagens",
            "Editor de vídeos"});
            this.cboprof.Location = new System.Drawing.Point(224, 107);
            this.cboprof.Name = "cboprof";
            this.cboprof.Size = new System.Drawing.Size(170, 29);
            this.cboprof.TabIndex = 5;
            this.cboprof.Text = "Insira uma profissão";
            // 
            // txtnovsenha
            // 
            this.txtnovsenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnovsenha.ForeColor = System.Drawing.Color.Black;
            this.txtnovsenha.Location = new System.Drawing.Point(224, 232);
            this.txtnovsenha.Name = "txtnovsenha";
            this.txtnovsenha.Size = new System.Drawing.Size(189, 29);
            this.txtnovsenha.TabIndex = 4;
            this.txtnovsenha.TextChanged += new System.EventHandler(this.txtnovsenha_TextChanged);
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtsenha.ForeColor = System.Drawing.Color.Black;
            this.txtsenha.Location = new System.Drawing.Point(24, 232);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(166, 29);
            this.txtsenha.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.Location = new System.Drawing.Point(224, 168);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(189, 29);
            this.txtemail.TabIndex = 2;
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtusuario.ForeColor = System.Drawing.Color.Black;
            this.txtusuario.Location = new System.Drawing.Point(24, 168);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(166, 29);
            this.txtusuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(120, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "C A D A S T R O";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnome.ForeColor = System.Drawing.Color.Black;
            this.txtnome.Location = new System.Drawing.Point(24, 107);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(166, 29);
            this.txtnome.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nome";
            // 
            // frmcadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 423);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmcadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmcadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btocriarconta;
        private ComboBox cboprof;
        private TextBox txtsenha;
        private TextBox txtemail;
        private TextBox txtusuario;
        private TextBox txtnovsenha;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox txtnome;
    }
}