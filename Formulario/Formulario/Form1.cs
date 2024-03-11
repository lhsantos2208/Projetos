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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSegunda_Click(object sender, EventArgs e)
        {
            Hide();
            FormSegunda f = new FormSegunda("Bem Vindo.");
            //f.Show();
            //f.Mensagem = "Segunda form aberta por Luciano";
            f.ShowDialog();
            if (f.Mensagem != null)
            {
                lblPrincipal.Text = f.Mensagem;
            }
            Show();
        }

        private void btnSegundaFormThread_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new FormSegunda()));
            t.Start();
        }

        private void mArquivoNovo_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new FormMain())).Start();
        }

        private void mArquivoAbrir_Click(object sender, EventArgs e)
        {
            Hide();
            FormSegunda f = new FormSegunda();
            f.ShowDialog();
            Show();
        }

        private void mArquivoSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mAjudaSobreDes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Luciano Henrique");
        }

        private void mAjudaSobreVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0");
        }

        private void ComboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboMenu.SelectedIndex == 0) 
            {
                MenuArquivos.Text = "File";
                menuAjuda.Text = "Help";
            }
            else if (ComboMenu.SelectedIndex == 1)
            {
                MenuArquivos.Text = "Arquivos";
                menuAjuda.Text = "Ajuda";
            }
        }

        private void mPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblPrincipal.Text = mPesquisar.Text;
                mPesquisar.Clear();
            }
        }
    }
}
