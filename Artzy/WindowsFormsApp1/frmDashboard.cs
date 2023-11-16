using System;
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

namespace WindowsFormsApp1
{
    public partial class frmDashboard : KryptonForm
    {
        private Timer slideTimer;
        private Timer slideTimer1;
        private Timer slideTimer2;
        private Timer slideTimer3;
        private Timer slideTimer4;

        public frmDashboard()
        {
            InitializeComponent();
            InitializeTimers();

        }

        private void InitializeTimers()
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

            pbClebio.Focus();
            pnSla.BackColor = Color.Transparent;
            pnSla.Parent = pictureBox1;

            int x = 0;
            int y = -4; 

            pnSla.Location = new Point(x, y);
            pnSla.BringToFront();

            //////////////////////////////////////////////////////////////////

            //btoConf.BackColor = Color.Transparent;
            //btoConf.Parent = pictureBox1;

            //int offsetX = -10; 
            //int offsetY = -10; 

            //int x1 = pictureBox1.Width - btoConf.Width + offsetX;
            //int y1 = pictureBox1.Height - btoConf.Height + offsetY;

            //btoConf.Location = new Point(x1, y1);
            //btoConf.BringToFront();

            lstTodo.ContextMenuStrip = contextMenuStrip1;
            lstDoing.ContextMenuStrip = contextMenuStrip1;
            lstDone.ContextMenuStrip = contextMenuStrip1;

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
           this.Hide();

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

        private void ItemMove(KryptonListBox sourceListBox, KryptonListBox destinationListBox)
        {
            foreach (int selectedIndex in sourceListBox.SelectedIndices)
            {
                if (selectedIndex >= 0 && selectedIndex < sourceListBox.Items.Count)
                {
                    object selectedItem = sourceListBox.Items[selectedIndex];

                    // próximo index disponivel
                    int nextIndex = destinationListBox.Items.Count;

                    // adiciona no doing
                    destinationListBox.Items.Insert(nextIndex, selectedItem);
                }
            }

                    
            for (int i = sourceListBox.SelectedIndices.Count - 1; i >= 0; i--) 
                //remove do todo
            {
                int selectedIndex = sourceListBox.SelectedIndices[i];
                if (selectedIndex >= 0 && selectedIndex < sourceListBox.Items.Count)
                {
                    sourceListBox.Items.RemoveAt(selectedIndex);
                }
            }
        }

        private void btnTodoToDoing_Click(object sender, EventArgs e)
        {
            ItemMove(lstTodo, lstDoing);
        }

        private void btnDoingToTodo_Click(object sender, EventArgs e)
        {
            ItemMove(lstDoing,lstTodo );
        }

        private void btnTodoToDone_Click(object sender, EventArgs e)
        {
            ItemMove(lstTodo, lstDone);
        }

        private void btnDoneToTodo_Click(object sender, EventArgs e)
        {
            ItemMove(lstDone,lstTodo );
        }

        private void btnDoingToDone_Click(object sender, EventArgs e)
        {
            ItemMove(lstDoing, lstDone );
        }

        private void btnDoneToDoing_Click(object sender, EventArgs e)
        {
            ItemMove(lstDone,lstDoing );
        }


        string bloco1;
        string bloco2;
        string bloco3;

        private void txtBloco1_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBloco1.Text))
            {
                txtBloco1.Text = bloco1;
            }
            else
            {
                txtBloco1.Text = "";
            }
        }

        private void txtBloco1_Leave(object sender, EventArgs e)
        {
            bloco1 = txtBloco1.Text;

            if (txtBloco1.Text == "")
            {
                txtBloco1.Text = "Título";
            }
        }

        private void txtBloco2_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBloco2.Text))
            {
                txtBloco2.Text = bloco2;
            }
            else
            {
                txtBloco2.Text = "";
            }
        }

        private void txtBloco2_Leave(object sender, EventArgs e)
        {
            bloco2 = txtBloco2.Text;

            if (txtBloco2.Text == "")
            {
                txtBloco2.Text = "Título";
            }
            
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
            if (!string.IsNullOrWhiteSpace(txtToDo.Text) & txtToDo.Text.Trim().ToLower() != "adicionar")
            {
                lstTodo.Items.Add(txtToDo.Text);
                txtToDo.Text = "";
                txtToDo.Focus();
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
                lstTodo.Items.RemoveAt(lstTodo.SelectedIndex);
            }
            else if (lstDoing.SelectedIndex != -1)
            {
                lstDoing.Items.RemoveAt(lstDoing.SelectedIndex);
            }
            else if (lstDone.SelectedIndex != -1)
            {
                lstDone.Items.RemoveAt(lstDone.SelectedIndex);
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

        private void btoOK2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDoing.Text) & txtDoing.Text.Trim().ToLower() != "adicionar")
            {
                lstDoing.Items.Add(txtDoing.Text);
                txtDoing.Text = "";
                txtDoing.Focus();
            }
        }

        private void btoOK3_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtDone.Text) & txtDone.Text.Trim().ToLower() != "adicionar")
            {
                lstDone.Items.Add(txtDone.Text);
                txtDone.Text = "";
                txtDone.Focus();
            }
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

        private void txtBloco3_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBloco3.Text))
            {
                txtBloco3.Text = bloco3;
            }
            else
            {
                txtBloco3.Text = "";
            }
        }

        private void txtBloco3_Enter(object sender, EventArgs e)
        {
            bloco3 = txtBloco3.Text;

            if (txtBloco3.Text == "")
            {
                txtBloco3.Text = "Título";
            }
        }

        private void btoHome_Click(object sender, EventArgs e)
        {
            pnDashboard.Visible = true;
        }

        private void btoLoja_Click(object sender, EventArgs e)
        {
            frmLoja frm = new frmLoja();
            frm.Show();
            this.Hide();
        }

        private void btoConf_Click(object sender, EventArgs e)
        {
            frmConf frm = new frmConf();
            frm.Show();

            this.Hide();
        }
    }

}
