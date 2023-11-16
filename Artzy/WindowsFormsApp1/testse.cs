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
    public partial class testse : Form
    {
        private int clickCount = 0;

        public testse()
        {
            InitializeComponent();
            //ConfigurarEventos();

        }

        //private void ConfigurarEventos()
        //{
        //    lstTodo.SelectedIndexChanged += ListaSelectedIndexChanged;
        //    lstTodo.Click += ListaClick;
        //}

        //private void ListaSelectedIndexChanged(object sender, EventArgs e)
        //{
        //    // Reseta o contador quando a seleção muda
        //    clickCount = 0;
        //}

        //private void ListaClick(object sender, EventArgs e)
        //{
        //    KryptonListBox lista = sender as KryptonListBox;

        //    if (lista != null)
        //    {
        //        clickCount++;

        //        if (clickCount == 2 && lista.SelectedIndex != -1)
        //        {
        //            // Exibe a TextBox para a entrada da descrição para o item selecionado
        //            ExibirTextBoxDescricao(lista.SelectedItem.ToString());
        //            clickCount = 0; // Reseta o contador após um clique duplo
        //        }
        //    }
        //}

        //private void ExibirTextBoxDescricao(string tarefaSelecionada)
        //{
        //    //using (frmDesc formDescricao = new frmDesc())
        //    {
        //        formDescricao.desc = tarefaSelecionada;

        //        if (formDescricao.ShowDialog() == DialogResult.OK)
        //        {
        //            // A descrição foi inserida, faça algo com a descrição (por exemplo, salve no banco de dados)
        //            string descricaoInserida = formDescricao.desc;

        //        }
        //    }
        //}
    }
}
