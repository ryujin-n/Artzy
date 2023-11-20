using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frmDashboard : KryptonForm
    {
        private Timer slideTimer;
        private Timer slideTimer1;
        private Timer slideTimer2;
        private Timer slideTimer3;
        private Timer slideTimer4;

        string stringConexao = frmLogin.stringConexao;
        int id = int.Parse(frmLogin.idUser);

        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Descricao { get; set; }
        public string Estado { get; set; }

        public frmDashboard()
        {
            InitializeComponent();
            InitializeTimers();

        }

        private void InitializeTimers() // miles do passado: NAO APAGA OS OUTROS TIMERS Q ELES SAO IMPORTANTES
        {
            slideTimer = new Timer();
            slideTimer.Interval = 16; // +- 60 FPS
            slideTimer.Tick += SlideTimer_Tick;

            slideTimer2 = new Timer();
            slideTimer2.Interval = 16;
            slideTimer2.Tick += SlideTimer2_Tick;

            slideTimer3 = new Timer();
            slideTimer3.Interval = 16;
            slideTimer3.Tick += SlideTimer3_Tick;

            slideTimer4 = new Timer();
            slideTimer4.Interval = 16;
            slideTimer4.Tick += SlideTimer4_Tick;
        }



        private void StopAllTimers()
        {
            slideTimer.Stop();
            slideTimer2.Stop();
            slideTimer3.Stop();
            slideTimer4.Stop();
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            AnimateButton(btoHome, slideTimer);
        }

        private void SlideTimer2_Tick(object sender, EventArgs e)
        {
            AnimateButton(btoLoja, slideTimer2);
        }

        private void SlideTimer3_Tick(object sender, EventArgs e)
        {
            AnimateButton(btoSair, slideTimer3);
        }

        private void SlideTimer4_Tick(object sender, EventArgs e)
        {

            AnimateButton(btoConf, slideTimer4);
        }

        private void AnimateButton(PictureBox pictureBox, Timer timer)
        {
            int targetX = -45; // posição final
            int speed = 10; // velocidade

            if (pictureBox.Location.X < targetX)
            {
                pictureBox.Location = new Point(pictureBox.Location.X + speed, pictureBox.Location.Y);
            }
            else
            {
                timer.Stop();
            }
        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {

            lblNome.Text = "Olá, " + frmLogin.NomeUser.ToString();
            lblname.Text = frmLogin.NomeUser.ToUpper() + " " + frmLogin.SobrenomeUser.ToUpper();
            lblprof.Text = frmLogin.ProfUser.ToString();
            this.Text = frmLogin.NomeUser + " - Artzy";

            CarregarTarefasDoBanco(lstTodo, "ToDo");
            CarregarTarefasDoBanco(lstDoing, "Doing");
            CarregarTarefasDoBanco(lstDone, "Done");

            CriarAnotacaoInicial();
            CarregarAnotacaoDoBanco();



            /////////////////////////////////////////

            byte[] imagemBinaria = imagemDoBanco(id);

            if (imagemBinaria != null && imagemBinaria.Length > 0)
            {
                pbFotoP.Image = ByteArrayParaImagem(imagemBinaria);
            }
            else
            {
                // Se não houver imagem no banco, carrega a imagem padrão
                pbFotoP.Image = CarregarImagemPadrao();
            }

            ////////////////////////////////////////

            pbClebio.Focus();
            pnSla.BackColor = Color.Transparent;
            pnSla.Parent = header;
         
            int x = 0;
            int y = -4; 

            pnSla.Location = new Point(x, y);
            pnSla.BringToFront();

            lstTodo.ContextMenuStrip = contextMenuStrip1;
            lstDoing.ContextMenuStrip = contextMenuStrip1;
            lstDone.ContextMenuStrip = contextMenuStrip1;

        }


        private byte[] imagemDoBanco(int idUsuario)
        {
            byte[] imagemBinaria = null;

            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                conn.Open();

                // obter a imagem do banco
                string sql = "select fotoP_artista from art where id_artista = @UsuarioID";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioID", idUsuario);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // obtem a imagem binária da coluna do banco
                            imagemBinaria = (byte[])reader["fotoP_artista"];
                        }
                    }
                }

                return imagemBinaria;
            }
        }

        private Image CarregarImagemPadrao()
        {
            // Carrega a imagem padrão como PNG
            return Properties.Resources._21;
        }

        private Image ByteArrayParaImagem(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                // Carrega a imagem mantendo a transparência
                Image imagem = Image.FromStream(ms);
                return imagem;
            }
        }

        private void btoLista_MouseEnter(object sender, EventArgs e)
        {
            slideTimer1.Start();
        }

        private void btoHome_MouseEnter(object sender, EventArgs e)
        {
            slideTimer.Start();
        }

        private void btoHome_MouseLeave(object sender, EventArgs e)
        {
            StopAllTimers();
            // reinicia a posição 
            btoHome.Location = new Point(-73, 215);
        }

        private void btoChat_MouseEnter(object sender, EventArgs e)
        {
            slideTimer4.Start();
        }

        private void btoChat_MouseLeave(object sender, EventArgs e)
        {
            StopAllTimers();
            btoConf.Location = new Point(-73, 281);
        }

        private void btoLoja_MouseEnter(object sender, EventArgs e)
        {
            slideTimer2.Start();
        }

        private void btoLoja_MouseLeave(object sender, EventArgs e)
        {
            StopAllTimers();
            btoLoja.Location = new Point(-73, 347);

        }

        private void btoSair_MouseEnter(object sender, EventArgs e)
        {
            slideTimer3.Start();
        }

        private void btoSair_MouseLeave(object sender, EventArgs e)
        {
            StopAllTimers();
            btoSair.Location = new Point(-73, 713);
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
           this.Close();

            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void btoConf_MouseEnter(object sender, EventArgs e)
        {
            slideTimer4.Start();
        }

        private void btoConf_MouseLeave(object sender, EventArgs e)
        {
            StopAllTimers();
            btoConf.Location = new Point(-73, 281);
        }


        private void ItemMove(KryptonListBox sourceListBox, KryptonListBox destinationListBox, string novoStatus)
        {
            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                conn.Open();

                for (int i = 0; i < sourceListBox.SelectedIndices.Count; i++)
                {
                    int selectedIndex = sourceListBox.SelectedIndices[i];

                    if (selectedIndex >= 0 && selectedIndex < sourceListBox.Items.Count)
                    {
                        object selectedItem = sourceListBox.Items[selectedIndex];

                        // Atualiza os índices na lista de origem
                        AtualizarIndices(conn, sourceListBox, selectedIndex, sourceListBox.Items.Count - 1);

                        // Adiciona ao Doing ou Done
                        destinationListBox.Items.Add(selectedItem);

                        // Obtém o novo índice na lista de destino
                        int novoIndice = destinationListBox.Items.Count - 1;

                        // Move a tarefa no banco de dados
                        MoverTarefaNoBanco(conn, selectedItem.ToString(), novoStatus, novoIndice);

                        // Remove da lista de origem
                        sourceListBox.Items.RemoveAt(selectedIndex);
                    }
                }
            }
        }

        private void AtualizarIndices(SqlConnection conn, KryptonListBox listBox, int indiceRemovido, int ultimoIndice)
        {
            for (int i = indiceRemovido + 1; i <= ultimoIndice; i++)
            {
                // Atualiza o índice no banco de dados
                AtualizarIndiceNoBanco(conn, listBox.Items[i].ToString(), i - 1);
            }
        }

        private void AtualizarIndiceNoBanco(SqlConnection conn, string nomeTarefa, int novoIndice)
        {
            string sql = "UPDATE tarefa SET ordem_tarefa = @NovoIndice " +
                         "WHERE nome_tarefa = @NomeTarefa AND id_usuario_tarefa = @UsuarioID";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@NovoIndice", novoIndice);
                cmd.Parameters.AddWithValue("@NomeTarefa", nomeTarefa);
                cmd.Parameters.AddWithValue("@UsuarioID", id);

                cmd.ExecuteNonQuery();
            }
        }


        private void MoverTarefaNoBanco(SqlConnection conn, string nomeTarefa, string novoStatus, int novoIndice)
        {
            // Atualiza o status e a ordem da tarefa no banco
            string sql = "UPDATE tarefa SET status_tarefa = @NovoStatus, ordem_tarefa = @NovaOrdem " +
                         "WHERE nome_tarefa = @NomeTarefa AND id_usuario_tarefa = @UsuarioID";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@NovoStatus", novoStatus);
                cmd.Parameters.AddWithValue("@NomeTarefa", nomeTarefa);
                cmd.Parameters.AddWithValue("@UsuarioID", id);
                cmd.Parameters.AddWithValue("@NovaOrdem", novoIndice);  // Use o novo índice diretamente

                cmd.ExecuteNonQuery();
            }
        }


        private void btnTodoToDoing_Click(object sender, EventArgs e)
        {
            ItemMove(lstTodo, lstDoing, "Doing");
        }

        private void btnDoingToTodo_Click(object sender, EventArgs e)
        {
            ItemMove(lstDoing, lstTodo, "ToDo");
        }

        private void btnTodoToDone_Click(object sender, EventArgs e)
        {
            ItemMove(lstTodo, lstDone, "Done");
        }

        private void btnDoneToTodo_Click(object sender, EventArgs e)
        {
            ItemMove(lstDone,lstTodo, "ToDo" );
        }

        private void btnDoingToDone_Click(object sender, EventArgs e)
        {
            ItemMove(lstDoing, lstDone, "Done" );
        }

        private void btnDoneToDoing_Click(object sender, EventArgs e)
        {
            ItemMove(lstDone,lstDoing , "Doing");
        }


        string todo;
        string doing;
        string done;

        private void txtToDo_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtToDo.Text))
            {
                txtToDo.Text = todo;
            }
            else
            {
                txtToDo.Text = "";
            }
        }

        private void txtToDo_Leave(object sender, EventArgs e)
        {

            todo = txtToDo.Text;

            if (txtToDo.Text == "")
            {
                txtToDo.Text = "Adicionar";
            }
        }

        private void btoOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtToDo.Text) && txtToDo.Text.Trim().ToLower() != "adicionar")
            {
                AdicionarTarefa(txtToDo.Text, lstTodo, StatusToDo);
                LimparEAtualizar(txtToDo);
            }
        }

        private int ObterProximaOrdemTarefa(SqlConnection conn, int idUsuario, string status)
        {
            string sql = "SELECT MAX(ordem_tarefa) FROM tarefa WHERE id_usuario_tarefa = @idUsuario AND status_tarefa = @status";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@status", status);

                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    int maxOrdem = Convert.ToInt32(result);
                    return maxOrdem + 1;
                }
                else
                {
                    return 0; // Comece a partir do índice 0 se não houver tarefas existentes
                }
            }
        }

        private void lstTodo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = lstTodo.IndexFromPoint(e.Location);
                if (index != -1)
                {
                    lstTodo.SelectedIndex = index;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                int index = lstDoing.IndexFromPoint(e.Location);
                if (index != -1)
                {
                    lstDoing.SelectedIndex = index;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                int index = lstDone.IndexFromPoint(e.Location);
                if (index != -1)
                {
                    lstDone.SelectedIndex = index;
                }
            }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            if (lstTodo.SelectedIndex != -1)
            {
                RemoverTarefa(lstTodo, "ToDo");
            }
            else if (lstDoing.SelectedIndex != -1)
            {
                RemoverTarefa(lstDoing, "Doing");
            }
            else if (lstDone.SelectedIndex != -1)
            {
                RemoverTarefa(lstDone, "Done");
            }
        }

        private void RemoverTarefa(KryptonListBox listBox, string status)
        {
            if (listBox.SelectedIndex != -1)
            {
                string nomeTarefa = listBox.SelectedItem.ToString();

                using (SqlConnection conn = new SqlConnection(stringConexao))
                {
                    conn.Open();

                    string sql = "delete from tarefa where nome_tarefa = @NomeTarefa and id_usuario_tarefa = @UsuarioID and status_tarefa = @Status";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@NomeTarefa", nomeTarefa);
                        cmd.Parameters.AddWithValue("@UsuarioID", id);
                        cmd.Parameters.AddWithValue("@Status", status);

                        cmd.ExecuteNonQuery();
                    }
                }

                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
        }

        private void txtDoing_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDoing.Text))
            {
                txtDoing.Text = doing;
            }
            else
            {
                txtDoing.Text = "";
            }
        }

        private void txtDoing_Leave(object sender, EventArgs e)
        {

            doing = txtDoing.Text;

            if (txtDoing.Text == "")
            {
                txtDoing.Text = "Adicionar";
            }
        }

        private const string StatusToDo = "ToDo";
        private const string StatusDoing = "Doing";
        private const string StatusDone = "Done";

        private void btoOK2_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtDoing.Text) && txtDoing.Text.Trim().ToLower() != "adicionar")
            {
                AdicionarTarefa(txtDoing.Text, lstDoing, StatusDoing);
                LimparEAtualizar(txtDoing);
            }
        }

        private void btoOK3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDone.Text) && txtDone.Text.Trim().ToLower() != "adicionar")
            {
                AdicionarTarefa(txtDone.Text, lstDone, StatusDone);
                LimparEAtualizar(txtDone);
            }
               
        }

        private void AdicionarTarefa(string nomeTarefa, KryptonListBox lista, string status)
        {
            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                conn.Open();

                int novaOrdem = ObterProximaOrdemTarefa(conn, id, status);

                string sql = "INSERT INTO tarefa (status_tarefa, id_usuario_tarefa, nome_tarefa, ordem_tarefa) " +
                             "VALUES (@status, @idUsuario, @nomeTarefa, @ordemTarefa)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@idUsuario", id);
                    cmd.Parameters.AddWithValue("@nomeTarefa", nomeTarefa);
                    cmd.Parameters.AddWithValue("@ordemTarefa", novaOrdem);

                    cmd.ExecuteNonQuery();
                }

                lista.Items.Add(nomeTarefa);
            }
        }

        private void LimparEAtualizar(KryptonTextBox textBox)
        {
            textBox.Text = "";
            textBox.Focus();
        }

        private void txtDone_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDone.Text))
            {
                txtDone.Text = done;
            }
            else
            {
                txtDone.Text = "";
            }
        }

        private void txtDone_Leave(object sender, EventArgs e)
        {
            done = txtDone.Text;

            if (txtDone.Text == "")
            {
                txtDone.Text = "Adicionar";
            }
        }

        private void btoLoja_Click(object sender, EventArgs e)
        {
            frmLoja frm = new frmLoja();
            frm.Show();
            this.Close();

        }

        private void btoConf_Click(object sender, EventArgs e)
        {
            frmConf frm = new frmConf();
            frm.Show();
            this.Close();
        }


        private void pbFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp|Todos os arquivos|*.*";
            openFileDialog.Title = "Escolha uma imagem";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoDaImagem = openFileDialog.FileName;

                // atualiza a imagem 
                if (File.Exists(caminhoDaImagem))
                {
                    Image imagem = Image.FromFile(caminhoDaImagem);
                    pbFotoP.Image = imagem;
                }
                ////////////////////////////////////
                
                // converte 
                byte[] image;

                MemoryStream stream = new MemoryStream();
                pbFotoP.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                image = stream.ToArray();
                
                //////////////////////////////////
                
                // atualiza no banco de dados
                caminho(id, image);
            }

        }

        private void caminho(int perfilID, byte[] perfil)
        {

            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                conn.Open();

                // atualiza o caminho da imagem na tabela
                string sql = "update art set fotoP_artista = @fotoP_artista where id_artista = @PerfilID";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@fotoP_artista", perfil);
                        cmd.Parameters.AddWithValue("@PerfilID", perfilID);
                        cmd.ExecuteNonQuery();
                    }
            }

        }

        private void CarregarTarefasDoBanco(KryptonListBox listBox, string status)
        {
            listBox.Items.Clear(); // limpa a lista antes de recarregar

            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                conn.Open();

                string sql = "SELECT nome_tarefa FROM tarefa WHERE status_tarefa = @Status AND id_usuario_tarefa = @UsuarioID ORDER BY ordem_tarefa";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@UsuarioID", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nomeTarefa = reader["nome_tarefa"].ToString();
                            listBox.Items.Add(nomeTarefa);
                        }
                    }
                }
            }
        }

        private void CriarAnotacaoInicial()
        {
            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                conn.Open();

                // Verifica se já existe uma anotação para o usuário
                string sqlVerificar = "SELECT COUNT(*) FROM anotacoes WHERE id_usuario_anotacao = @idUsuario";
                using (SqlCommand cmdVerificar = new SqlCommand(sqlVerificar, conn))
                {
                    cmdVerificar.Parameters.AddWithValue("@idUsuario", id);

                    int count = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                    if (count == 0)
                    {
                        // Se não existir, cria uma anotação inicial
                        string sqlCriar = "INSERT INTO anotacoes (id_usuario_anotacao, titulo_anotacao, bloco_anotacao) " +
                                          "VALUES (@idUsuario, @titulo, @bloco)";
                        using (SqlCommand cmdCriar = new SqlCommand(sqlCriar, conn))
                        {
                            cmdCriar.Parameters.AddWithValue("@idUsuario", id);
                            cmdCriar.Parameters.AddWithValue("@titulo", "Título");
                            cmdCriar.Parameters.AddWithValue("@bloco", string.Empty);

                            cmdCriar.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void CarregarAnotacaoDoBanco()
        {
            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                conn.Open();

                string sql = "SELECT titulo_anotacao, bloco_anotacao FROM anotacoes " +
                             "WHERE id_usuario_anotacao = @idUsuario";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string titulo = reader["titulo_anotacao"].ToString();
                            string bloco = reader["bloco_anotacao"].ToString();

                            // Atualiza os campos correspondentes com as anotações carregadas
                            txtBloco1.Text = titulo;
                            txtAnot1.Text = bloco;
                        }
                    }
                }
            }
        }

        private void AtualizarAnotacaoNoBanco(string titulo, string bloco)
        {
            using (SqlConnection conn = new SqlConnection(stringConexao))
            {
                conn.Open();

                string sql = "UPDATE anotacoes SET titulo_anotacao = @titulo, bloco_anotacao = @bloco " +
                             "WHERE id_usuario_anotacao = @idUsuario";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@bloco", bloco);
                    cmd.Parameters.AddWithValue("@idUsuario", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtBloco1.Text.Trim() != "Título")
            {
                // Realize ações antes do fechamento, como salvar dados
                AtualizarAnotacaoNoBanco(txtBloco1.Text, txtAnot1.Text);
            }
        }
    }

}
