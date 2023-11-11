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
        string email;
        string name;

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
            string sql = "set dateformat dmy insert into art (nome_artista,user_artista,senha_artista,email_artista,prof_artista)" +
                "values" +
                    "(" +
                    "'" + txtName.Text + "'" + "," +
                    "'" + txtUser.Text + "'" + "," +
                    "'" + txtSenha.Text + "'" + "," +
                    "'" + txtEmail.Text + cboEmail.Text + "'" + "," +
                    "'" + cboArea.Text + "')";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            conn.Open();

            try
            {
                if (txtUser.Text == "Usuário" || txtUser.Text == "")
                {
                    MessageBox.Show("Deve conter um Usuário!");
                    return;

                }
                else if (txtName.Text == "Nome" || txtName.Text == "")
                {
                    MessageBox.Show("Deve conter um Nome!");
                    return;
                }
                else if (txtEmail.Text == "Email" || txtEmail.Text == "" || cboEmail.Text == "")
                {
                    MessageBox.Show("Deve conter um Email!");
                    return;

                }
                else if (txtSenha.Text == "Senha" || txtSenha.Text == "")
                {
                    MessageBox.Show("Deve conter uma Senha!");
                    return;

                }
                else if (cboArea.Text == "")
                {
                    MessageBox.Show("Deve conter uma Profissão!");
                    return;
                }

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
                frmDashboard frm = new frmDashboard();
                frm.Show();
                this.Hide();
            }
        }

        private void btoLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();

            this.Hide();
        }
    }
}
