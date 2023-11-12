using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Droplabel
    {
        public static void AdicionarLabelComSombra(Form form, string texto, Point localizacao)
        {
            // Cria uma Label para o texto principal
            Label labelPrincipal = new Label();
            labelPrincipal.Text = texto;
            labelPrincipal.AutoSize = true;
            form.Controls.Add(labelPrincipal);

            // Cria uma Label para a sombra
            Label labelSombra = new Label();
            labelSombra.Text = texto;
            labelSombra.AutoSize = true;
            labelSombra.Location = new Point(labelPrincipal.Left + 2, labelPrincipal.Top + 2); // Ajuste a posição conforme necessário
            labelSombra.ForeColor = Color.Gray; // Cor da sombra
            form.Controls.Add(labelSombra);
        }
    }
}
