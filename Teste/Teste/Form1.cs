using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Carregando a Form";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = "Clicando na Form";
            //this.Size = new Size(450, 200);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Você clicou no botão!";
        }

        private void btn1_MouseEnter(object sender, EventArgs e)
        {
            lblTitulo.Text = "Você posicionou o mouse no botão!";
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            lblTitulo.Text = "Você não esta mais posicionado com o mouse no botão!";
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            btn1.Size = new Size(300, 150);
        }
    }
}
