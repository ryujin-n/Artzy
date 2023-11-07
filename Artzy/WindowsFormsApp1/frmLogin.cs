using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace WindowsFormsApp1
{
    public partial class frmLogin : KryptonForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        string user;
        string senha;

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUser.Text))
            {
                txtUser.Text = user;
            }
            else
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {

            user = txtUser.Text;

            if (txtUser.Text == "")
            {
                txtUser.Text = "User";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUser.Text))
            {
                txtSenha.Text = senha;
            }
            else
            {
                txtSenha.Text = "";
            }

        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            senha = txtSenha.Text;

            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Password";
            }
        }
        string mask;

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
                    

             mask = new string('*', txtSenha.Text.Length);
           

            if (txtSenha.Text != "Password")
            {
                txtSenha.Text = mask;
            }

            
            txtSenha.SelectionStart = txtSenha.Text.Length;
            txtSenha.ScrollToCaret();
        }

        bool oio = true;

        private void pbOlho_Click(object sender, EventArgs e)
        {


            if (oio)
            {
                pbOlho.BackgroundImage = Image.FromFile("C:\\Users\\miles\\Source\\Repos\\Artzy\\WindowsFormsApp1\\WindowsFormsApp1\\ref\\closedd.png");
                oio = false;
            }
            else
            {
                pbOlho.BackgroundImage = Image.FromFile("C:\\Users\\miles\\Source\\Repos\\Artzy\\WindowsFormsApp1\\WindowsFormsApp1\\ref\\openn.png");
                oio = true;

            }

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
           
        }

    }
}
