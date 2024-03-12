using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
           
            Lista.Items.Add(nome);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            object item = Lista.SelectedItem;
            Lista.Items.Remove(item);
        }

        private void btnRemoverIndice_Click(object sender, EventArgs e)
        {
            int indice = Lista.SelectedIndex;
            Lista.Items.RemoveAt(indice);
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = Lista.SelectedItem.ToString();
            txtNome.Text = nome;
        }

        private void BtnQuatidadeItens_Click(object sender, EventArgs e)
        {
            int qtdItens = Lista.Items.Count;
            MessageBox.Show("A quantidade de itens na lista é: " + qtdItens);
        }
    }
}
