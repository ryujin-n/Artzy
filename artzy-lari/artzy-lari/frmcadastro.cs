using System.Data.SqlClient;

namespace artzy_lari
{
    public partial class frmcadastro : Form
    {
        public frmcadastro()
        {
            InitializeComponent();
        }
        string stringCon = "" +
            "Data Source=localhost;" +
            "Initial Catalog=Artzy;" +
            "user ID=sa;" +
            "password=123456";
        private void TestarConexão()
        {
            SqlConnection con = new SqlConnection(stringCon);

            try
            {
                con.Open();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
                Application.Exit();
            }
        }

        private void frmcadastro_Load(object sender, EventArgs e)
        {
            TestarConexão();
        }

        private void btocriarconta_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == ""||txtusuario.Text == "" || txtemail.Text == "" || txtsenha.Text == ""|| cboprof.Text == "")
            {
                MessageBox.Show("Erro, preencha os campos corretamente!");
                return;
            }

            string sql = "insert into logn" +
                       "(" +
                          "nome_logn," +
                          "user_logn," +
                          "senha_logn," +
                          "email_logn," +
                          "prof_logn" +
                       ")" +
                       "values" +
                       "(" +
                         "'"+txtnome.Text+"',"+
                         "'" + txtusuario.Text + "'," +
                         "'" + txtsenha.Text + "'," +
                         "'" + txtemail.Text + "'," +
                         "'" + cboprof.Text + "'" +
                       ") select SCOPE_IDENTITY()";
                         
            SqlConnection con = new SqlConnection(stringCon);
            SqlCommand  cmd = new SqlCommand(sql, con);
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Conta criada com sucesso, Seja bem vindo(a)!");                      
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void txtnovsenha_TextChanged(object sender, EventArgs e)
        {
            txtnovsenha.Text = txtsenha.Text.Trim();
        }
    }
}

