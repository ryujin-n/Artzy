namespace WindowsFormsApp1
{
    partial class testse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testse));
            this.pbPref = new System.Windows.Forms.PictureBox();
            this.pbSec = new System.Windows.Forms.PictureBox();
            this.pbConta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConta)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPref
            // 
            this.pbPref.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPref.BackgroundImage")));
            this.pbPref.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbPref.Location = new System.Drawing.Point(170, 269);
            this.pbPref.Name = "pbPref";
            this.pbPref.Size = new System.Drawing.Size(372, 64);
            this.pbPref.TabIndex = 1;
            this.pbPref.TabStop = false;
            // 
            // pbSec
            // 
            this.pbSec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSec.BackgroundImage")));
            this.pbSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSec.Location = new System.Drawing.Point(170, 190);
            this.pbSec.Name = "pbSec";
            this.pbSec.Size = new System.Drawing.Size(372, 64);
            this.pbSec.TabIndex = 2;
            this.pbSec.TabStop = false;
            // 
            // pbConta
            // 
            this.pbConta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbConta.BackgroundImage")));
            this.pbConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbConta.Location = new System.Drawing.Point(170, 111);
            this.pbConta.Name = "pbConta";
            this.pbConta.Size = new System.Drawing.Size(372, 64);
            this.pbConta.TabIndex = 3;
            this.pbConta.TabStop = false;
            // 
            // testse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 451);
            this.Controls.Add(this.pbPref);
            this.Controls.Add(this.pbSec);
            this.Controls.Add(this.pbConta);
            this.Name = "testse";
            ((System.ComponentModel.ISupportInitialize)(this.pbPref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPref;
        private System.Windows.Forms.PictureBox pbSec;
        private System.Windows.Forms.PictureBox pbConta;
    }
}