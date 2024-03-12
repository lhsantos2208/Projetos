using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            checkList.Items.Clear();
            checkList.Items.Add("Carro", true);
            checkList.Items.Add("Moto", false);
            checkList.Items.Add("Barco");
            checkList.Items.Add("Avião");

            int qtdItens = checkList.Items.Count;
            //MessageBox.Show("Quantidade de itens " + qtdItens);
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //checkList.Items.Clear();
            //checkList.Items.AddRange(new string[] { "Carro", "Moto", "Avião", "Bicicleta" });

            //bool res =  checkList.Items.Contains("Moto");
            //if (res)
            //{
            //    MessageBox.Show("O item Moto esta na lista.");
            //}

            //checkList.Items.Remove("Moto");
            //checkList.Items.RemoveAt(2);
            //checkList.Items.Insert(1, "Cavalo");
            //var itens = checkList.CheckedItems;
            var itens = checkList.SelectedItems;

            foreach (var item in itens)
            {
                MessageBox.Show(item.ToString());
            }

        }

        private void checkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = checkList.SelectedItems.ToString();
        }
    }
}
