using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combo.Items.Clear();
            combo.Items.Add("Carro");
            combo.Items.Add("Moto");
            combo.Items.Add("Barco");
            combo.Items.Add("Avião");

            combo.Items.AddRange(new string[] { "Cavalo", "Elevador", "Bicicleta" });
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int qtdItens = combo.Items.Count;
            //MessageBox.Show("A quantidade de intens é " + qtdItens);
            //object item = combo.SelectedItem;
            //int indice = combo.SelectedIndex;
            //MessageBox.Show("O Indice é " + indice + " e o item é o " + item);

            //combo.Items.Clear();

            //combo.Items.Remove("Cavalo");

            //combo.Items.RemoveAt(1);

            //combo.Items.Insert(2, "Ovni");

            //int indice = combo.Items.IndexOf("Barco");
            //MessageBox.Show("O indice do item Barco é " + indice);
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(combo.SelectedItem.ToString());
        }
    }
}
