using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormSegunda : Form
    {
        public String Mensagem { get; set; }

        public FormSegunda()
        {
            InitializeComponent();
        }

        public FormSegunda(string mensagem)
        {
            InitializeComponent();
            this.Mensagem = mensagem;
        }

        private void FormSegunda_Load(object sender, EventArgs e)
        {
            txtMensagem.Text = Mensagem;
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new FormMain()));
            t.Start();
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            if (txtMensagem.Text == "" || txtMensagem.Text == null)
            {
                this.Mensagem = null;
            }
            else
            {
                this.Mensagem = txtMensagem.Text;   
            }

            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Mensagem = null;
            Close();
        }
    }
}
