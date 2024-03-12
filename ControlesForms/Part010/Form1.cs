using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ListViewItem item1 = new ListViewItem("Luciano");
            item1.SubItems.Add("41 99206-8170");
            item1.SubItems.Add("lhsantos@gmail.com");

            ListViewItem item2 = new ListViewItem("Lilian");
            item2.SubItems.Add("41 99191-4194");
            item2.SubItems.Add("liliansantos_3@gmail.com");

            ListViewItem item3 = new ListViewItem("Luana");
            item3.SubItems.Add("41 99999-9999");
            item3.SubItems.Add("luana.filha@gmail.com");

            ListViewItem item4 = new ListViewItem(new string[] { "Lucas", "41 88888-8888", "lucas.filho@gmail.com" });

            lista.Items.Clear();
            lista.Items.Add(item1);
            lista.Items.Add(item2);
            lista.Items.Add(item3);
            lista.Items.Add(item4);
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //lista.Items.Clear();
            //lista.Items.Remove(lista.SelectedItems[0]);
            lista.Items.RemoveAt(1);
        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(lista.SelectedItems[0].Text);
        }
    }
}
