namespace WindowsFormsApp1
{
    partial class frmCadastro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btoEntrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboEmail = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btoLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSenha = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtUser = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblarea = new System.Windows.Forms.Label();
            this.cboArea = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboArea)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 26;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Width = 1;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 26;
            // 
            // btoEntrar
            // 
            this.btoEntrar.Location = new System.Drawing.Point(250, 271);
            this.btoEntrar.Name = "btoEntrar";
            this.btoEntrar.Size = new System.Drawing.Size(68, 31);
            this.btoEntrar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btoEntrar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btoEntrar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btoEntrar.StateCommon.Border.ColorAngle = 135F;
            this.btoEntrar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btoEntrar.StateCommon.Border.Rounding = 10;
            this.btoEntrar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 4, -1, -1);
            this.btoEntrar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.btoEntrar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoEntrar.TabIndex = 0;
            this.btoEntrar.Values.Text = "Entrar";
            this.btoEntrar.Click += new System.EventHandler(this.btoEntrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.cboEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btoLogin);
            this.panel1.Controls.Add(this.btoEntrar);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.lblarea);
            this.panel1.Controls.Add(this.cboArea);
            this.panel1.Location = new System.Drawing.Point(99, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 358);
            this.panel1.TabIndex = 7;
            // 
            // cboEmail
            // 
            this.cboEmail.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.cboEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmail.DropDownWidth = 243;
            this.cboEmail.Items.AddRange(new object[] {
            "@gmail.com",
            "@outlook.com",
            "@yahoo.com",
            "@hotmail.com"});
            this.cboEmail.Location = new System.Drawing.Point(154, 164);
            this.cboEmail.Name = "cboEmail";
            this.cboEmail.Size = new System.Drawing.Size(124, 47);
            this.cboEmail.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.Azure;
            this.cboEmail.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboEmail.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboEmail.StateCommon.ComboBox.Border.Rounding = 43;
            this.cboEmail.StateCommon.ComboBox.Border.Width = 3;
            this.cboEmail.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.DarkGray;
            this.cboEmail.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("KG Red Hands", 6.75F);
            this.cboEmail.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(30, 5, 10, 3);
            this.cboEmail.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.cboEmail.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("KG Red Hands", 6.75F);
            this.cboEmail.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("KG Red Hands", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(237, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Já um membro?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(45, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 21);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(45, 178);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 21);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(45, 125);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 21);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(294, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(203, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 48);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btoLogin
            // 
            this.btoLogin.Location = new System.Drawing.Point(250, 322);
            this.btoLogin.Name = "btoLogin";
            this.btoLogin.Size = new System.Drawing.Size(68, 30);
            this.btoLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btoLogin.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btoLogin.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btoLogin.StateCommon.Border.ColorAngle = 135F;
            this.btoLogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btoLogin.StateCommon.Border.Rounding = 10;
            this.btoLogin.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 4, -1, -1);
            this.btoLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.btoLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Bebas Neue", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoLogin.TabIndex = 0;
            this.btoLogin.Values.Text = "Login";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(284, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 47);
            this.txtName.StateCommon.Back.Color1 = System.Drawing.Color.Azure;
            this.txtName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtName.StateCommon.Border.Rounding = 32;
            this.txtName.StateCommon.Border.Width = 3;
            this.txtName.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.txtName.StateCommon.Content.Font = new System.Drawing.Font("KG Red Hands", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(30, 5, 10, 3);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "Nome";
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(35, 216);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(243, 47);
            this.txtSenha.StateCommon.Back.Color1 = System.Drawing.Color.Azure;
            this.txtSenha.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSenha.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSenha.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSenha.StateCommon.Border.Rounding = 32;
            this.txtSenha.StateCommon.Border.Width = 3;
            this.txtSenha.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.txtSenha.StateCommon.Content.Font = new System.Drawing.Font("KG Red Hands", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.StateCommon.Content.Padding = new System.Windows.Forms.Padding(30, 5, 10, 3);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(35, 164);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 47);
            this.txtEmail.StateCommon.Back.Color1 = System.Drawing.Color.Azure;
            this.txtEmail.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.txtEmail.StateCommon.Border.Rounding = 32;
            this.txtEmail.StateCommon.Border.Width = 3;
            this.txtEmail.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.txtEmail.StateCommon.Content.Font = new System.Drawing.Font("KG Red Hands", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.StateCommon.Content.Padding = new System.Windows.Forms.Padding(30, 5, 10, 3);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Text = "Email";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(35, 112);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(243, 47);
            this.txtUser.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUser.StateActive.Border.Rounding = 32;
            this.txtUser.StateActive.Border.Width = 3;
            this.txtUser.StateActive.Content.Font = new System.Drawing.Font("KG Red Hands", 6.75F);
            this.txtUser.StateActive.Content.Padding = new System.Windows.Forms.Padding(30, 5, 10, 3);
            this.txtUser.StateCommon.Back.Color1 = System.Drawing.Color.Azure;
            this.txtUser.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUser.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUser.StateCommon.Border.Rounding = 32;
            this.txtUser.StateCommon.Border.Width = 3;
            this.txtUser.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
            this.txtUser.StateCommon.Content.Font = new System.Drawing.Font("KG Red Hands", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.StateCommon.Content.Padding = new System.Windows.Forms.Padding(30, 5, 10, 3);
            this.txtUser.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUser.StateNormal.Border.Rounding = 32;
            this.txtUser.StateNormal.Border.Width = 3;
            this.txtUser.TabIndex = 9;
            this.txtUser.Text = "Usuário";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.BackColor = System.Drawing.Color.MintCream;
            this.lblarea.Font = new System.Drawing.Font("KG Red Hands", 6.75F);
            this.lblarea.ForeColor = System.Drawing.Color.DarkGray;
            this.lblarea.Location = new System.Drawing.Point(323, 182);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(31, 13);
            this.lblarea.TabIndex = 11;
            this.lblarea.Text = "Area";
            this.lblarea.Click += new System.EventHandler(this.lblarea_Click);
            // 
            // cboArea
            // 
            this.cboArea.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.cboArea.DropDownHeight = 90;
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.DropDownWidth = 243;
            this.cboArea.Items.AddRange(new object[] {
            "Artista Digital",
            "Artista Tradicional",
            "Editor de Vídeos",
            "Escritor",
            "Músico",
            "Dublador",
            "Outro (adicionar no perfil depois)"});
            this.cboArea.Location = new System.Drawing.Point(284, 164);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(243, 47);
            this.cboArea.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.Azure;
            this.cboArea.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboArea.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboArea.StateCommon.ComboBox.Border.Rounding = 41;
            this.cboArea.StateCommon.ComboBox.Border.Width = 3;
            this.cboArea.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.DarkGray;
            this.cboArea.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("KG Red Hands", 6.75F);
            this.cboArea.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(30, 5, 10, 3);
            this.cboArea.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.cboArea.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("KG Red Hands", 6.75F);
            this.cboArea.TabIndex = 10;
            this.cboArea.SelectedIndexChanged += new System.EventHandler(this.cboArea_SelectedIndexChanged);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("KG Red Hands", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClose.Location = new System.Drawing.Point(14, 21);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(24, 26);
            this.lblClose.TabIndex = 8;
            this.lblClose.Text = "<";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btoEntrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btoLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUser;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSenha;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboEmail;
        private System.Windows.Forms.Label lblarea;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboArea;
    }
}