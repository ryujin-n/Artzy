﻿using ComponentFactory.Krypton.Toolkit;
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
    public partial class frmLoja : KryptonForm
    {
        private Timer slideTimer;
        private Timer slideTimer2;
        private Timer slideTimer3;
        private Timer slideTimer4;

        public frmLoja()
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

        private void btoLoja_MouseEnter(object sender, EventArgs e)
        {
            slideTimer2.Start();
        }

        private void btoLoja_MouseLeave(object sender, EventArgs e)
        {
            StopAllTimers();
            btoLoja.Location = new Point(-73, 347);

        }

        private void btoHome_Click(object sender, EventArgs e)
        {
            frmDashboard frm = new frmDashboard();
            frm.Show();
            this.Close();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();

            frmLogin frm = new frmLogin();
            frm.Show();
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

        private void btoConf_MouseEnter(object sender, EventArgs e)
        {
            slideTimer4.Start();
        }

        private void btoConf_MouseLeave(object sender, EventArgs e)
        {
            StopAllTimers();
            btoConf.Location = new Point(-73, 281);
        }

        private void btoConf_Click(object sender, EventArgs e)
        {
            frmConf frm = new frmConf();
            frm.Show();

            this.Close();
        }

        private void btoVal_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmValores frm = new frmValores();
            frm.Show();
        }
        public static float preco;

        private void bto7_Click(object sender, EventArgs e)
        {
            preco = 16;

            frmPag frm = new frmPag();
            frm.Show();

            this.Hide();
        }

        private void bto8_Click(object sender, EventArgs e)
        {
            preco = 30;
            frmPag frm = new frmPag();
            frm.Show();

            this.Hide();
        }

        private void bto9_Click(object sender, EventArgs e)
        {
            preco = 50.90F;

            frmPag frm = new frmPag();
            frm.Show();

            this.Hide();
        }
    }
}
