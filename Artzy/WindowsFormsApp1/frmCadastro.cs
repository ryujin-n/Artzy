using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        string stringConexao = frmLogin.stringConexao;

        public frmCadastro()
        {
            InitializeComponent();

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            //string[] i = new string[]{"Animador", "Produtor musical", "Artista Digital", "Artista Tradicional", "Escritor"};
            //string[] j = new string[]{"@gmail.com", "@hotmail.com", "@outlook.com", "@yahoo.com"};
            //cboProf.Items.Add(i);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();

            this.Close();
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
        string email;

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
        string name;

        private void kryptonRichTextBox1_Enter(object sender, EventArgs e)
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
                txtName.Text = "Name";
            }
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            string sql = "set dateformat dmy insert into art (nome_artista,user_artista,senha_artista,email_artista,prof_artista)" +
                "values" +
                    "(" +
                    "'" + txtName.Text + "'" + "," +
                    "'" + txtUser.Text + "'" + "," +
                    "'" + txtSenha.Text + "'" + "," +
                    "'" + txtEmail.Text + "'" + "," +
                    "'" + cboArea.Text + "')";
                
            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
     
            conn.Open();

            try
            {
                if (txtName.Text == "Name" || txtName.Text == "")
                {
                    MessageBox.Show("Must have a Name!");
                    return;
                }
                else if (txtUser.Text == "User" || txtUser.Text == "")
                {
                    MessageBox.Show("Must have an User!");
                    return;

                }
                else if (txtSenha.Text == "Password" || txtSenha.Text == "")
                {
                    MessageBox.Show("Must have a Password!");
                    return;

                }
                else if (txtEmail.Text == "Email" || txtEmail.Text == "")
                {
                    MessageBox.Show("Must have an Email!");
                    return;

                }

                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Conta criada com sucesso, Seja bem vindo(a)!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
