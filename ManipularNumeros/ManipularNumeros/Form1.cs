using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region TryParse
            //int num;
            //bool res =  int.TryParse(txtValor.Text, out num);

            //if (int.TryParse(txtValor.Text, out num))
            //{
            //    lblResultado.Text = num.ToString();
            //}
            //else
            //{
            //    lblResultado.Text = "Erro na conversão!";
            //}
            #endregion

            #region ToString/Convert.ToString
            //double num = double.Parse(txtValor.Text);

            //lblResultado.Text = num.ToString("00000.00");
            //lblResultado.Text = num.ToString("#.00");

            //int num = int.Parse(txtValor.Text);
            //lblResultado.Text = num.ToString("X"); // Hex
            //lblResultado.Text = num.ToString("X5"); // Hex definindo digitos
            //lblResultado.Text = num.ToString("D"); // Dec
            //lblResultado.Text = num.ToString("D5"); // Dec definindo digitos
            //lblResultado.Text = num.ToString("C"); // Monetario

            //lblResultado.Text = Convert.ToString(num, 16); // Hex
            //lblResultado.Text = Convert.ToString(num, 10); // Dec
            //lblResultado.Text = Convert.ToString(num, 8); // Octal

            #endregion

            #region Classe Math
            //double pi = Math.PI;
            //double E =  Math.E;
            //double seno = Math.Sin(double.Parse(txtValor.Text));
            //double conseno = Math.Cos(double.Parse(txtValor.Text));
            //double potencia = Math.Pow(double.Parse(txtValor.Text), 3);
            //double raizQuadrada = Math.Sqrt(double.Parse(txtValor.Text));
            //double arredonda = Math.Round(double.Parse(txtValor.Text));
            //double inteiro = Math.Truncate(double.Parse(txtValor.Text));
            //double floor = Math.Floor(double.Parse(txtValor.Text));
            //double ceil = Math.Ceiling(double.Parse(txtValor.Text));

            //lblResultado.Text = pi.ToString("#.00");
            //lblResultado.Text = E.ToString("#.00");
            //lblResultado.Text = seno.ToString("#.00");
            //lblResultado.Text = conseno.ToString("#.00");
            //lblResultado.Text = potencia.ToString("#.00");
            //lblResultado.Text = raizQuadrada.ToString("#.00");
            //lblResultado.Text = arredonda.ToString("#.00");
            //lblResultado.Text = inteiro.ToString("#.00");
            //lblResultado.Text = floor.ToString("#.00");
            //lblResultado.Text = ceil.ToString("#.00");

            #endregion
        }
    }
}
