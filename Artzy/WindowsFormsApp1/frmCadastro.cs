using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class frmCadastro : KryptonForm
    {
        public frmCadastro()
        {
            InitializeComponent();

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            string[] i = new string[]{ "Animador", "Produtor musical", "Artista Digital", "Artista Tradicional", "Escritor" };
            cboProf.Items.Add(i);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();

            this.Close();
        }

  

        string user;
        string senha;
        string senha2;

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
            if (!string.IsNullOrWhiteSpace(txtSenha.Text))
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

        private void btoLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmLogin frm = new frmLogin();
            frm.Show();

        }
    }
}
