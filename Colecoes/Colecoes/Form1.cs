using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            // Array
            string[] nomes = new string[3];
            nomes[0] = "Luciano";
            nomes[1] = "Lilian";
            nomes[2] = "Luana";

            // Lista Generica
            List<string> nomes2 = new List<string>();
            nomes2.AddRange(nomes);
            nomes2.Add("Lucas");
            nomes2.Add("Princesa");

            //if (nomes2.Remove("Lucas"))
            //{
            //    MessageBox.Show("Lucas removido!");
            //}
            //else
            //{
            //    MessageBox.Show("Não foi possível remover Lucas da lista!");
            //}

            //if (nomes2.Contains("Lilian"))
            //{
            //    MessageBox.Show("Lilian esta na lista!");
            //}
            //else
            //{
            //    MessageBox.Show("Lilian não esta na lista!");
            //}

            //int quantidade = nomes2.Count;
            //MessageBox.Show("A lista contem " + quantidade + " elementos.");
            //nomes2.Sort();

            //MessageBox.Show("Lilian esta no indice " + nomes2.IndexOf("Lilian"));
            //MessageBox.Show("João esta no indice " + nomes2.IndexOf("João"));

            //nomes2.Insert(2, "João");

            //nomes2.RemoveAt(1);

            //nomes2.Clear();

            //nomes2.Add("Lucas");

            //lista.Items.Add(nomes2[0]);
            //lista.Items.Add(nomes2[1]);
            //lista.Items.Add(nomes2[2]);
            //lista.Items.Add(nomes2[3]);
            //lista.Items.Add(nomes2[4]);
            foreach (string nome in nomes2)
            {
                lista.Items.Add(nome);
            }
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            HashSet<string> veiculos = new HashSet<string>()
            {
                "Carro", "Moto", "Avião", "Helicoptero", "Barco"
            };

            //MessageBox.Show(veiculos.ElementAt(2));

            //if (veiculos.Add(txtValor.Text))
            //{
            //    MessageBox.Show("Item adicionado");
            //}
            //else
            //{
            //    MessageBox.Show("Item não adicionado");
            //}

            //if (veiculos.Contains(txtValor.Text))
            //{
            //    MessageBox.Show("Item " + txtValor.Text + " contem na lista");
            //}
            //else
            //{
            //    MessageBox.Show("Item " + txtValor.Text + " não contem na lista");
            //}

            //if (veiculos.Remove(txtValor.Text)) 
            //{
            //    MessageBox.Show("Item " + txtValor.Text + " removido na lista");
            //}
            //else
            //{
            //    MessageBox.Show("Item " + txtValor.Text + " não foi removido na lista");
            //}

            //MessageBox.Show("A lista contem " + veiculos.Count() + " itens.");

            //veiculos.Clear();

            //txtValor.Text = veiculos.First();

            //txtValor.Text = veiculos.Last();

            foreach (string item in veiculos)
            {
                lista.Items.Add(item);
            }
        }
    }
}
