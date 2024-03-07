using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Olá meus amigos !!");
            //MessageBox.Show("Mensagem a ser impressa","Título da mensagem");
            //DialogResult res = MessageBox.Show("Texto da mensagem", "Título da mensagem", MessageBoxButtons.YesNo);
            //MessageBox.Show("Texto da mensagem", "Título da mensagem", MessageBoxButtons.YesNoCancel);
            //DialogResult res = MessageBox.Show("Texto da mensagem", "Título da mensagem", MessageBoxButtons.OKCancel);

            //if (res == DialogResult.OK) 
            //{
            //    lblResultado.Text = "O usuário clicou em OK!";
            //}
            //else if (res == DialogResult.Cancel)
            //{
            //    lblResultado.Text = "O usuário clicou em Cancelar!";
            //}

            //MessageBox.Show("Texto da mensagem", "Título da mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            MessageBox.Show("Texto da mensagem", "Título da mensagem", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information,MessageBoxDefaultButton.Button3);
        }

        private void btAleatorio_Click(object sender, EventArgs e)
        {
            Random r = new Random(DateTime.Now.Millisecond);

            int valor = r.Next(100);
            double valor2 = r.NextDouble() * 100;
            //int valor = r.Next(1, 1000);

            lblResultado.Text = "O número escolhido foi: " + valor2;
        }
    }
}
