namespace WindowsFormsApp1
{
    partial class frmConf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConf));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.seg = new System.Windows.Forms.Panel();
            this.btoSalvar = new System.Windows.Forms.Button();
            this.txtMnome = new System.Windows.Forms.TextBox();
            this.txtMemail = new System.Windows.Forms.TextBox();
            this.txtMsenha = new System.Windows.Forms.TextBox();
            this.pbPref = new System.Windows.Forms.PictureBox();
            this.pbSec = new System.Windows.Forms.PictureBox();
            this.pbConta = new System.Windows.Forms.PictureBox();
            this.pref = new System.Windows.Forms.Panel();
            this.btoConf = new System.Windows.Forms.PictureBox();
            this.pbClebio = new System.Windows.Forms.PictureBox();
            this.btoSair = new System.Windows.Forms.PictureBox();
            this.btoLoja = new System.Windows.Forms.PictureBox();
            this.btoHome = new System.Windows.Forms.PictureBox();
            this.cont = new System.Windows.Forms.Panel();
            this.txtapeli = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.seg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConta)).BeginInit();
            this.pref.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btoConf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClebio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btoSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btoLoja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btoHome)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 26;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Width = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cont);
            this.panel1.Controls.Add(this.pbPref);
            this.panel1.Controls.Add(this.pbSec);
            this.panel1.Controls.Add(this.pbConta);
            this.panel1.Location = new System.Drawing.Point(209, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 791);
            this.panel1.TabIndex = 15;
            // 
            // seg
            // 
            this.seg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("seg.BackgroundImage")));
            this.seg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seg.Controls.Add(this.btoSalvar);
            this.seg.Controls.Add(this.txtMnome);
            this.seg.Controls.Add(this.txtMemail);
            this.seg.Controls.Add(this.txtMsenha);
            this.seg.Location = new System.Drawing.Point(668, 65);
            this.seg.Name = "seg";
            this.seg.Size = new System.Drawing.Size(508, 711);
            this.seg.TabIndex = 2;
            // 
            // btoSalvar
            // 
            this.btoSalvar.Location = new System.Drawing.Point(372, 663);
            this.btoSalvar.Name = "btoSalvar";
            this.btoSalvar.Size = new System.Drawing.Size(75, 23);
            this.btoSalvar.TabIndex = 1;
            this.btoSalvar.Text = "Salvar";
            this.btoSalvar.UseVisualStyleBackColor = true;
            // 
            // txtMnome
            // 
            this.txtMnome.Location = new System.Drawing.Point(34, 608);
            this.txtMnome.Name = "txtMnome";
            this.txtMnome.Size = new System.Drawing.Size(291, 20);
            this.txtMnome.TabIndex = 0;
            this.txtMnome.Text = "Mudar Nome";
            this.txtMnome.Enter += new System.EventHandler(this.txtMnome_Enter);
            this.txtMnome.Leave += new System.EventHandler(this.txtMnome_Leave);
            // 
            // txtMemail
            // 
            this.txtMemail.Location = new System.Drawing.Point(34, 411);
            this.txtMemail.Name = "txtMemail";
            this.txtMemail.Size = new System.Drawing.Size(291, 20);
            this.txtMemail.TabIndex = 0;
            this.txtMemail.Text = "Mudar Email";
            this.txtMemail.Enter += new System.EventHandler(this.txtMemail_Enter);
            this.txtMemail.Leave += new System.EventHandler(this.txtMemail_Leave);
            // 
            // txtMsenha
            // 
            this.txtMsenha.Location = new System.Drawing.Point(34, 141);
            this.txtMsenha.Name = "txtMsenha";
            this.txtMsenha.Size = new System.Drawing.Size(291, 20);
            this.txtMsenha.TabIndex = 0;
            this.txtMsenha.Text = "Mudar Senha";
            this.txtMsenha.Enter += new System.EventHandler(this.txtMsenha_Enter);
            this.txtMsenha.Leave += new System.EventHandler(this.txtMsenha_Leave);
            // 
            // pbPref
            // 
            this.pbPref.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPref.BackgroundImage")));
            this.pbPref.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPref.Location = new System.Drawing.Point(45, 262);
            this.pbPref.Name = "pbPref";
            this.pbPref.Size = new System.Drawing.Size(372, 64);
            this.pbPref.TabIndex = 0;
            this.pbPref.TabStop = false;
            this.pbPref.Click += new System.EventHandler(this.pbPref_Click);
            // 
            // pbSec
            // 
            this.pbSec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSec.BackgroundImage")));
            this.pbSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSec.Location = new System.Drawing.Point(45, 195);
            this.pbSec.Name = "pbSec";
            this.pbSec.Size = new System.Drawing.Size(372, 64);
            this.pbSec.TabIndex = 0;
            this.pbSec.TabStop = false;
            this.pbSec.Click += new System.EventHandler(this.pbSec_Click);
            // 
            // pbConta
            // 
            this.pbConta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbConta.BackgroundImage")));
            this.pbConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbConta.Location = new System.Drawing.Point(45, 128);
            this.pbConta.Name = "pbConta";
            this.pbConta.Size = new System.Drawing.Size(372, 64);
            this.pbConta.TabIndex = 0;
            this.pbConta.TabStop = false;
            this.pbConta.Click += new System.EventHandler(this.pbConta_Click);
            // 
            // pref
            // 
            this.pref.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pref.BackgroundImage")));
            this.pref.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pref.Controls.Add(this.txtapeli);
            this.pref.Location = new System.Drawing.Point(662, 65);
            this.pref.Name = "pref";
            this.pref.Size = new System.Drawing.Size(509, 711);
            this.pref.TabIndex = 3;
            // 
            // btoConf
            // 
            this.btoConf.BackColor = System.Drawing.Color.Transparent;
            this.btoConf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btoConf.BackgroundImage")));
            this.btoConf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btoConf.Location = new System.Drawing.Point(-73, 281);
            this.btoConf.Name = "btoConf";
            this.btoConf.Size = new System.Drawing.Size(191, 60);
            this.btoConf.TabIndex = 14;
            this.btoConf.TabStop = false;
            this.btoConf.MouseEnter += new System.EventHandler(this.btoConf_MouseEnter);
            this.btoConf.MouseLeave += new System.EventHandler(this.btoConf_MouseLeave);
            // 
            // pbClebio
            // 
            this.pbClebio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbClebio.BackgroundImage")));
            this.pbClebio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbClebio.Location = new System.Drawing.Point(11, 65);
            this.pbClebio.Name = "pbClebio";
            this.pbClebio.Size = new System.Drawing.Size(191, 88);
            this.pbClebio.TabIndex = 10;
            this.pbClebio.TabStop = false;
            // 
            // btoSair
            // 
            this.btoSair.BackColor = System.Drawing.Color.Transparent;
            this.btoSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btoSair.BackgroundImage")));
            this.btoSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btoSair.Location = new System.Drawing.Point(-73, 713);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(191, 60);
            this.btoSair.TabIndex = 11;
            this.btoSair.TabStop = false;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            this.btoSair.MouseEnter += new System.EventHandler(this.btoSair_MouseEnter);
            this.btoSair.MouseLeave += new System.EventHandler(this.btoSair_MouseLeave);
            // 
            // btoLoja
            // 
            this.btoLoja.BackColor = System.Drawing.Color.Transparent;
            this.btoLoja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btoLoja.BackgroundImage")));
            this.btoLoja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btoLoja.Location = new System.Drawing.Point(-73, 347);
            this.btoLoja.Name = "btoLoja";
            this.btoLoja.Size = new System.Drawing.Size(191, 60);
            this.btoLoja.TabIndex = 12;
            this.btoLoja.TabStop = false;
            this.btoLoja.Click += new System.EventHandler(this.btoLoja_Click);
            this.btoLoja.MouseEnter += new System.EventHandler(this.btoLoja_MouseEnter);
            this.btoLoja.MouseLeave += new System.EventHandler(this.btoLoja_MouseLeave);
            // 
            // btoHome
            // 
            this.btoHome.BackColor = System.Drawing.Color.Transparent;
            this.btoHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btoHome.BackgroundImage")));
            this.btoHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btoHome.Location = new System.Drawing.Point(-73, 215);
            this.btoHome.Name = "btoHome";
            this.btoHome.Size = new System.Drawing.Size(191, 60);
            this.btoHome.TabIndex = 13;
            this.btoHome.TabStop = false;
            this.btoHome.Click += new System.EventHandler(this.btoHome_Click);
            this.btoHome.MouseEnter += new System.EventHandler(this.btoHome_MouseEnter);
            this.btoHome.MouseLeave += new System.EventHandler(this.btoHome_MouseLeave);
            // 
            // cont
            // 
            this.cont.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cont.BackgroundImage")));
            this.cont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cont.Location = new System.Drawing.Point(457, 31);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(508, 711);
            this.cont.TabIndex = 1;
            // 
            // txtapeli
            // 
            this.txtapeli.Location = new System.Drawing.Point(40, 347);
            this.txtapeli.Name = "txtapeli";
            this.txtapeli.Size = new System.Drawing.Size(310, 20);
            this.txtapeli.TabIndex = 0;
            this.txtapeli.Text = "Adicionar Apelido";
            this.txtapeli.Enter += new System.EventHandler(this.txtapeli_Enter);
            this.txtapeli.Leave += new System.EventHandler(this.txtapeli_Leave);
            // 
            // frmConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1226, 825);
            this.Controls.Add(this.pref);
            this.Controls.Add(this.seg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btoConf);
            this.Controls.Add(this.pbClebio);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.btoLoja);
            this.Controls.Add(this.btoHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConf";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConf";
            this.panel1.ResumeLayout(false);
            this.seg.ResumeLayout(false);
            this.seg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConta)).EndInit();
            this.pref.ResumeLayout(false);
            this.pref.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btoConf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClebio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btoSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btoLoja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btoHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.PictureBox btoConf;
        private System.Windows.Forms.PictureBox pbClebio;
        private System.Windows.Forms.PictureBox btoSair;
        private System.Windows.Forms.PictureBox btoLoja;
        private System.Windows.Forms.PictureBox btoHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbPref;
        private System.Windows.Forms.PictureBox pbSec;
        private System.Windows.Forms.PictureBox pbConta;
        private System.Windows.Forms.Panel seg;
        private System.Windows.Forms.Panel pref;
        private System.Windows.Forms.Button btoSalvar;
        private System.Windows.Forms.TextBox txtMnome;
        private System.Windows.Forms.TextBox txtMemail;
        private System.Windows.Forms.TextBox txtMsenha;
        private System.Windows.Forms.Panel cont;
        private System.Windows.Forms.TextBox txtapeli;
    }
}