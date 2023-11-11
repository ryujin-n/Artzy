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
    public partial class testse : Form
    {
        private Label btohome;
        private Timer slideTimer;

        public testse()
        {
            InitializeComponent();
            InitializeSlideLabel();
            InitializeTimer();
        }

        private void InitializeSlideLabel()
        {
            btohome = new Label();
            btohome.Size = new Size(100, 40);
            btohome.Location = new Point(50, 50);
            btohome.Text = "Home";
            btohome.BorderStyle = BorderStyle.FixedSingle;

            // Manipular os eventos MouseEnter e MouseLeave
            btohome.MouseEnter += Btohome_MouseEnter;
            btohome.MouseLeave += Btohome_MouseLeave;

            Controls.Add(btohome);
        }

        private void InitializeTimer()
        {
            slideTimer = new Timer();
            slideTimer.Interval = 16; // Aproximadamente 60 FPS
            slideTimer.Tick += SlideTimer_Tick;
        }

        private void Btohome_MouseEnter(object sender, EventArgs e)
        {
            slideTimer.Start();
        }

        private void Btohome_MouseLeave(object sender, EventArgs e)
        {
            slideTimer.Stop();
            // Reiniciar a posição quando o mouse deixa a label
            btohome.Location = new Point(50, 50);
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            // Gradualmente ajustar a posição da label durante o hover
            int targetX = 60; // Posição final desejada
            int speed = 1; // Ajuste a velocidade da animação

            if (btohome.Location.X < targetX)
            {
                btohome.Location = new Point(btohome.Location.X + speed, btohome.Location.Y);
            }
            else
            {
                slideTimer.Stop();
            }
        }

        private void testse_Load(object sender, EventArgs e)
        {

        }
    }
}
