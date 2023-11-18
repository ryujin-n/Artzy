using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class frmCadastro : KryptonForm
    {

        string stringConexao = frmLogin.stringConexao;

        public frmCadastro()
        {
            InitializeComponent();

            if (txtSenha.Text =="Senha")
            {
                txtSenha.PasswordChar = '\0';
            }

        }
        string user;
        string senha;
        string email;
        string name;
        string subname;

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
                txtUser.Text = "Usuário";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = email;
            }
            else
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            email = txtEmail.Text;

            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                txtSenha.Text = senha;
                txtSenha.PasswordChar = '*';
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
                txtSenha.Text = "Senha";
            }

            if (txtSenha.Text == "Senha")
            {
                txtSenha.PasswordChar = '\0';
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Text = name;
            }
            else
            {
                txtName.Text = "";
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            name = txtName.Text;

            if (txtName.Text == "")
            {
                txtName.Text = "Nome";
            }
        }
       


        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblarea.Visible = false;
        }

        private void lblarea_Click(object sender, EventArgs e)
        {
            cboArea.DroppedDown = !cboArea.DroppedDown;
        }

        private void btoEntrar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuário" || txtUser.Text == "")
            {
                MessageBox.Show("Deve conter um Usuário!");
                txtUser.Focus();
                return;

            }
            else if (txtName.Text == "Nome" || txtName.Text == "")
            {
                MessageBox.Show("Deve conter um Nome!");
                txtName.Focus();
                return;
            }
            else if (txtEmail.Text == "Email" || txtEmail.Text == "")
            {
                MessageBox.Show("Deve conter um Email!");
                txtEmail.Focus();
                return;

            }
            else if (txtSobr.Text == "Sobrenome")
            {
                MessageBox.Show("Deve conter um Sobrenome!");
                txtSobr.Focus();
                return;
            }
            else if (txtSenha.Text == "Senha" || txtSenha.Text == "")
            {
                MessageBox.Show("Deve conter uma Senha!");
                txtSenha.Focus();
                return;

            }
            else if (lblarea.Visible == true)
            {
                MessageBox.Show("Deve conter uma Profissão!");
                return;
            }

            Image imagemPadrao = Properties.Resources._21;
            byte[] imagemPadraoB = ImageToByteArray(imagemPadrao);

            string sql = "set dateformat dmy insert into art (nome_artista, sobrenome_artista, user_artista, senha_artista, email_artista, prof_artista, fotoP_artista)" +
                "values" +
                    "(" +
                    "'" + txtName.Text + "'" + "," +
                    "'" + txtSobr.Text + "'" + "," +
                    "'" + txtUser.Text + "'" + "," +
                    "'" + txtSenha.Text + "'" + "," +
                    "'" + txtEmail.Text + "'" + "," +
                    "'" + cboArea.Text +  "'" + "," +
                    "@ImagemPadrao)";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@ImagemPadrao", imagemPadraoB);

            conn.Open();

            try
            {

                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Conta criada com sucesso, Seja bem vindo(a)! :)");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Hide();
            }

            
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
       
        private void btoLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();

            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();

            this.Close();
        }

        private void txtSobr_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSobr.Text))
            {
                txtSobr.Text = subname;
            }
            else
            {
                txtSobr.Text = "";
            }
        }

        private void txtSobr_Leave(object sender, EventArgs e)
        {
            subname = txtSobr.Text;

            if (txtSobr.Text == "")
            {
                txtSobr.Text = "Sobrenome";
            }
        }


        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string eemail = txtEmail.Text;

            if (!IsValidEmail(eemail))
            {
                MessageBox.Show("Insira um email válido!");
                e.Cancel = true;
            }
          
        }

        private bool IsValidEmail(string eemail)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(pattern);
            return regex.IsMatch(eemail);
        }

    }
}
    

 