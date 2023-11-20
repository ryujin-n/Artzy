using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmConf : KryptonForm
    {

        private Timer slideTimer;
        private Timer slideTimer2;
        private Timer slideTimer3;
        private Timer slideTimer4;

        public frmConf()
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

        private void btoConf_MouseEnter(object sender, EventArgs e)
        {
            slideTimer4.Start();
        }

        private void btoConf_MouseLeave(object sender, EventArgs e)
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

        private void btoHome_Click(object sender, EventArgs e)
        {
            frmDashboard frm = new frmDashboard();
            frm.Show();

            this.Close();
        }

        private void btoLoja_Click(object sender, EventArgs e)
        {
            frmLoja frm = new frmLoja();
            frm.Show();

            this.Close();

        }

        private void btoSair_Click_1(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();

            this.Close();
        }

        private void pbSec_Click(object sender, EventArgs e)
        {
            cont.Visible = false;
            preff.Visible = false;
            secc.Visible = true;
        }

        private void pbPref_Click(object sender, EventArgs e)
        {
            cont.Visible = false;
            secc.Visible = false;
            preff.Visible=true;
        }

        private void pbConta_Click(object sender, EventArgs e)
        {
            cont.Visible = true;
            secc.Visible = false;
            preff.Visible=false;

        }

        private void frmConf_Load(object sender, EventArgs e)
        {
            cont.Visible = true;
            secc.Visible = false;
            preff.Visible = false;
        }

        //string nome;
        //string sobr;
        //string prof;
        //string user;
        //string senha;
        //string novasenha;

        string teste;


        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                txtNome.Text = teste;
            }
            else
            {
                txtNome.Text = "";
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            teste = txtNome.Text;

            if (txtNome.Text == "")
            {
                txtNome.Text = "Novo Nome";
            }
        }

        private void txtSobr_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSobr.Text))
            {
                txtSobr.Text = teste;
            }
            else
            {
                txtSobr.Text = "";
            }
        }

        private void txtSobr_Leave(object sender, EventArgs e)
        {
            teste = txtSobr.Text;

            if (txtSobr.Text == "")
            {
                txtSobr.Text = "Novo Sobrenome";
            }
        }

        private void txtProf_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtProf.Text))
            {
                txtProf.Text = teste;
            }
            else
            {
                txtProf.Text = "";
            }
        }

        private void txtProf_Leave(object sender, EventArgs e)
        {
            teste = txtProf.Text;

            if (txtProf.Text == "")
            {
                txtProf.Text = "Nova Profissão";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                txtSenha.Text = teste;
            }
            else
            {
                txtSenha.Text = "";
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            teste = txtSenha.Text;

            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Nova Senha";
            }
        }

        private void txtSenha2_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSenha2.Text))
            {
                txtSenha2.Text = teste;
            }
            else
            {
                txtSenha2.Text = "";
            }
        }

        private void txtSenha2_Leave(object sender, EventArgs e)
        {
            teste = txtSenha2.Text;

            if (txtSenha2.Text == "")
            {
                txtSenha2.Text = "Digite Novamente";
            }
        }

        private void txtNovaSenha_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNovaSenha.Text))
            {
                txtNovaSenha.Text = teste;
            }
            else
            {
                txtNovaSenha.Text = "";
            }
        }

        private void txtNovaSenha_Leave(object sender, EventArgs e)
        {
            teste = txtNovaSenha.Text;

            if (txtNovaSenha.Text == "")
            {
                txtNovaSenha.Text = "Senha Atual";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = teste;
            }
            else
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            teste = txtEmail.Text;

            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Novo Email";
            }
        }

        private void txtConfirm_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                txtConfirm.Text = teste;
            }
            else
            {
                txtConfirm.Text = "";
            }
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            teste = txtConfirm.Text;

            if (txtConfirm.Text == "")
            {
                txtConfirm.Text = "Digite sua Senha";
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUser.Text))
            {
                txtUser.Text = teste;
            }
            else
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            teste = txtUser.Text;

            if (txtUser.Text == "")
            {
                txtUser.Text = "Novo Nome de Usuário";
            }
        }
    }
}
