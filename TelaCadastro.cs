using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Artzy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string stringConexao = "" +
            "Data Source=localhost;" +
            "Initial Catalog=artzy;" +
            "User ID=sa;" +
            "Password=123456";
        private void TestarConexao()
        {
            SqlConnection conexao = new SqlConnection(stringConexao);

            try
            {
                conexao.Open();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
                Application.Exit();
            }
        }
 
        private void btoCriarConta_Click(object sender, EventArgs e)
        {
            string sql = "insert into cadastro" +
            "(usuario_cadastro,email_cadastro,senha_cadastro,novaSenha_cadastro,profissao_cadastro)" +
            "values" +
            "('" + txtUsuario.Text + "','" + txtEmail.Text + "','" + txtSenha.Text + "','" + txtSenhaNovamente.Text + "','" + cboProfissao.Text + "')" +
            "select scope_identity()";

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conexao.Open();

            try
            {

                leitura = cmd.ExecuteReader();

                if (leitura.Read())
                {
                    txtUsuario.Text = leitura[0].ToString();
                    MessageBox.Show("Cadastro realizado com sucesso");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }
    }
}