using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jokenpo
{
    public partial class frmJokenpo : Form
    {
        int nemp = 0;
        int ngan = 0;
        int nper = 0;

        public frmJokenpo()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void StartGame(int opcao)
        {
            labelResultado.Visible = false; 
            Game jogo = new Game();
            
            switch (jogo.Jogar(opcao))
            {
                case Game.Resultado.Ganhar:
                    ngan ++;
                    lbVitUsu.Text = "Vitórias do Usuário: " + ngan;
                    picResultado.BackgroundImage = Image.FromFile("imagens/Ganhar.png");
                    goto default;
                case Game.Resultado.Perder:
                    nper ++;
                    lbVitPC.Text = "Vitórias do PC: " + nper;
                    picResultado.BackgroundImage = Image.FromFile("imagens/Perder.png");
                    goto default; 
                case Game.Resultado.Empatar:
                    nemp ++;
                    lbEmpatar.Text = "Empates:" + nemp; 
                    picResultado.BackgroundImage = Image.FromFile("imagens/Empatar.png");
                    goto default; 
                default:
                    pictureBox1.Image = jogo.ImgJogador;
                    pictureBox2.Image = jogo.ImgPC;
                    break;
            }
        }
    }
}
