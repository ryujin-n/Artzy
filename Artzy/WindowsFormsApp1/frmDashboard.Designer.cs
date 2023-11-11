namespace WindowsFormsApp1
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnSla = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btoSair = new System.Windows.Forms.PictureBox();
            this.btoLoja = new System.Windows.Forms.PictureBox();
            this.btoChat = new System.Windows.Forms.PictureBox();
            this.btoLista = new System.Windows.Forms.PictureBox();
            this.btoHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btoSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btoLoja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btoChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btoLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btoHome)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 26;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Width = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(11, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 88);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(208, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 779);
            this.panel1.TabIndex = 1;
            // 
            // pnSla
            // 
            this.pnSla.BackColor = System.Drawing.Color.Transparent;
            this.pnSla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnSla.BackgroundImage")));
            this.pnSla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnSla.Location = new System.Drawing.Point(854, -1);
            this.pnSla.Name = "pnSla";
            this.pnSla.Size = new System.Drawing.Size(308, 368);
            this.pnSla.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(854, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 826);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btoSair
            // 
            this.btoSair.BackColor = System.Drawing.Color.Transparent;
            this.btoSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btoSair.BackgroundImage")));
            this.btoSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btoSair.Location = new System.Drawing.Point(-73, 713);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(223, 60);
            this.btoSair.TabIndex = 5;
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
            this.btoLoja.Location = new System.Drawing.Point(-73, 413);
            this.btoLoja.Name = "btoLoja";
            this.btoLoja.Size = new System.Drawing.Size(223, 60);
            this.btoLoja.TabIndex = 5;
            this.btoLoja.TabStop = false;
            this.btoLoja.MouseEnter += new System.EventHandler(this.btoLoja_MouseEnter);
            this.btoLoja.MouseLeave += new System.EventHandler(this.btoLoja_MouseLeave);
            // 
            // btoChat
            // 
            this.btoChat.BackColor = System.Drawing.Color.Transparent;
            this.btoChat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btoChat.BackgroundImage")));
            this.btoChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btoChat.Location = new System.Drawing.Point(-73, 347);
            this.btoChat.Name = "btoChat";
            this.btoChat.Size = new System.Drawing.Size(223, 60);
            this.btoChat.TabIndex = 5;
            this.btoChat.TabStop = false;
            this.btoChat.MouseEnter += new System.EventHandler(this.btoChat_MouseEnter);
            this.btoChat.MouseLeave += new System.EventHandler(this.btoChat_MouseLeave);
            // 
            // btoLista
            // 
            this.btoLista.BackColor = System.Drawing.Color.Transparent;
            this.btoLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btoLista.BackgroundImage")));
            this.btoLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btoLista.Location = new System.Drawing.Point(-73, 281);
            this.btoLista.Name = "btoLista";
            this.btoLista.Size = new System.Drawing.Size(223, 60);
            this.btoLista.TabIndex = 5;
            this.btoLista.TabStop = false;
            this.btoLista.MouseEnter += new System.EventHandler(this.btoLista_MouseEnter);
            this.btoLista.MouseLeave += new System.EventHandler(this.btoLista_MouseLeave);
            // 
            // btoHome
            // 
            this.btoHome.BackColor = System.Drawing.Color.Transparent;
            this.btoHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btoHome.BackgroundImage")));
            this.btoHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btoHome.Location = new System.Drawing.Point(-73, 215);
            this.btoHome.Name = "btoHome";
            this.btoHome.Size = new System.Drawing.Size(223, 60);
            this.btoHome.TabIndex = 5;
            this.btoHome.TabStop = false;
            this.btoHome.MouseEnter += new System.EventHandler(this.btoHome_MouseEnter);
            this.btoHome.MouseLeave += new System.EventHandler(this.btoHome_MouseLeave);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 825);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnSla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.btoLoja);
            this.Controls.Add(this.btoChat);
            this.Controls.Add(this.btoLista);
            this.Controls.Add(this.btoHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboard";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Width = 3;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btoSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btoLoja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btoChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btoLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btoHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnSla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btoHome;
        private System.Windows.Forms.PictureBox btoLista;
        private System.Windows.Forms.PictureBox btoChat;
        private System.Windows.Forms.PictureBox btoSair;
        private System.Windows.Forms.PictureBox btoLoja;
    }
}