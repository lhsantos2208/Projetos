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

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            //lblResultado.Text = TimeSpan.FromMinutes(90.5).ToString();
            //lblResultado.Text = TimeSpan.FromDays(7.25).ToString();
            //lblResultado.Text = TimeSpan.FromTicks(1000000000).ToString();
            //lblResultado.Text = TimeSpan.TicksPerMinute.ToString();
            TimeSpan inicio = new TimeSpan(1, 0, 0);

            TimeSpan fim = new TimeSpan(3, 30, 0);

            TimeSpan intervalo = fim - inicio;

            TimeSpan somar = fim + inicio;

            TimeSpan adicao = inicio.Add(fim);

            TimeSpan subtrair = fim.Subtract (inicio);

            //lblResultado.Text = intervalo.TotalHours.ToString();
            lblResultado.Text = subtrair.ToString();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //lblResultado.Text = DateTime.Now.ToString();
            //lblResultado.Text = DateTime.Today.ToString();
            //lblResultado.Text = DateTime.DaysInMonth(2024,07).ToString();
            //lblResultado.Text = DateTime.IsLeapYear(2054).ToString();
            //lblResultado.Text = DateTime.Now.ToLongDateString();
            //lblResultado.Text = DateTime.Now.ToShortDateString();
            //lblResultado.Text = DateTime.Now.ToLongTimeString();
            //lblResultado.Text = DateTime.Now.ToShortTimeString();
            //lblResultado.Text = DateTime.Now.ToUniversalTime().ToString();  
            //lblResultado.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"); 

            DateTime data = new DateTime(1985,01,10,14,35,30);

            //lblResultado.Text =  data.AddYears(2).ToString();

            //TimeSpan tempo = new TimeSpan(5,10,5,20);
            //lblResultado.Text = data.Add(tempo).ToString();

            //lblResultado.Text = data.DayOfWeek.ToString();

            lblResultado.Text = data.DayOfYear.ToString();
        }
    }
}
