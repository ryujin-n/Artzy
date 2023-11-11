using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            if (txtSenha.Text == "Senha")
            {
                txtSenha.PasswordChar = '\0';
            }
        }

            public static string stringConexao = "Data Source=localhost;Initial Catalog=Artzy;User ID=sa;Password=123456";
            public static string idUser;
            public static string LoginUser;
            public static string NomeUser;

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void txtUser_Leave_1(object sender, EventArgs e)
        {
            user = txtUser.Text;

            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuário";
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
        }


        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCadastro frm = new frmCadastro();
            frm.Show();
            
        }
        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btoEntrar_Click(object sender, EventArgs e)
        {
            string sql = "select * from art where " +
                "user_artista = '" + txtUser.Text + "' or email_artista = '" + txtUser.Text + "' and " +
                "senha_artista = '" + txtSenha.Text + "'";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    idUser = reader[0].ToString();
                    NomeUser = reader[2].ToString();
                    LoginUser = reader[3].ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha incorretos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                this.Hide();
            }
        }

    }
}
