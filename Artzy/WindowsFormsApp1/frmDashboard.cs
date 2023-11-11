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

            btoHome.MouseEnter += BtoHome_MouseEnter;
            btoHome.MouseLeave += BtoHome_MouseLeave;
        }

        private void InitializeTimers()
        {
            slideTimer = new Timer();
            slideTimer.Interval = 16; // Aproximadamente 60 FPS
            slideTimer.Tick += SlideTimer_Tick;

            slideTimer1 = new Timer();
            slideTimer1.Interval = 16;
            slideTimer1.Tick += SlideTimer1_Tick;

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

        private void BtoHome_MouseEnter(object sender, EventArgs e)
        {
            slideTimer.Start();
        }

        private void BtoHome_MouseLeave(object sender, EventArgs e)
        {
            StopAllTimers();
            // reinicia a posição 
            btoHome.Location = new Point(-73, 215);
        }

        private void StopAllTimers()
        {
            slideTimer.Stop();
            slideTimer1.Stop();
            slideTimer2.Stop();
            slideTimer3.Stop();
            slideTimer4.Stop();
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            AnimateButton(btoHome, slideTimer);
        }

        private void SlideTimer1_Tick(object sender, EventArgs e)
        {
            AnimateButton(btoLista, slideTimer1);
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
  
            AnimateButton(btoChat, slideTimer4);
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
            pnSla.BackColor = Color.Transparent;
            pnSla.Parent = pictureBox1;
            pnSla.Location = new Point(-4, -3);
            pnSla.BringToFront();

        }

        private void btoLista_MouseEnter(object sender, EventArgs e)
        {
            slideTimer1.Start();
        }

        private void btoLista_MouseLeave(object sender, EventArgs e)
        {
            StopAllTimers();
            btoLista.Location = new Point(-73,281);
        }

        private void btoChat_MouseEnter(object sender, EventArgs e)
        {
            slideTimer4.Start();
        }

        private void btoChat_MouseLeave(object sender, EventArgs e)
        {
            StopAllTimers();
            btoChat.Location = new Point(-73, 347);
        }

        private void btoLoja_MouseEnter(object sender, EventArgs e)
        {
            slideTimer2.Start();
        }

        private void btoLoja_MouseLeave(object sender, EventArgs e)
        {
            StopAllTimers();
            btoLoja.Location = new Point(-73, 413);

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
    }

}
