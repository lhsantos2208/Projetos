using System;
using System.Collections;
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

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                { 150, "Lilian" },
                { 200, "Luana" },
                { 250, "Lucas" }
            };

            alunos.Add(100, "Luciano");

            //alunos.Remove(250);
            //alunos.Clear();
            
            

            foreach (KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item.Key + " = " + item.Value);
            }

            //txtValor.Text = "Quantidade de alunos: " + alunos.Count.ToString();
            //txtValor.Text = "Primeiro item: " + alunos.First().Value;
            //txtValor.Text = "Último item: " + alunos.Last().Value;
            //if (alunos.ContainsKey(800))
            if (alunos.ContainsValue("Davi"))
            {
                txtValor.Text = "Contém o aluno Davi";
            }
            else
            {
                txtValor.Text = "Não contém o aluno Davi";
            }
        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                { 27, "Lilian" },
                { 10, "Lucas" },
                { 17, "Luana" }
            };

            alunos.Add(14, "Luciano");
            //alunos.Remove(10);
            //alunos.RemoveAt(0);
            //alunos.ContainsKey(10);
            //alunos.ContainsValue("Lucas");
            
            lista.Items.Clear();
            //foreach (KeyValuePair<int, string> item in alunos.Reverse())
            foreach (KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item.Key + " " + item.Value);
            }
            txtValor.Text = "A lista contem " + alunos.Count() + " alunos.";
        }

        private void btnSortedDictionary_Click(object sender, EventArgs e)
        {
            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>()
            //SortedDictionary<string, string> alunos = new SortedDictionary<string, string>()
            {
                { 4512, "Lilian" },
                { 1542, "Lucas" },
                { 2145, "Luana" }
            };

            alunos.Add(5478, "Luciano");

            //alunos.Remove(5478);
            //alunos.Count();
            //alunos.Clear();
            //alunos.ContainsKey(4512);
            //alunos.ContainsValue("Lilian");
            txtValor.Text = "A lista contem o indice " + alunos.ElementAt(0).ToString();

            //foreach (KeyValuePair<int, string> item in alunos.Reverse())
            foreach (KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item.Key + " " + item.Value);
            }
        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            SortedSet<string> nomes = new SortedSet<string>()
            {
                { "Luciano" },
                { "Lilian" },
                { "Luana" }
            };

            nomes.Add("Lucas");

            //nomes.Remove("Luana");
            //txtValor.Text = nomes.ElementAt(0);
            //txtValor.Text = nomes.First();
            //txtValor.Text = nomes.Last();
            //nomes.Contains("Lilian");
            txtValor.Text = nomes.Count().ToString();
            //nomes.Clear();

            //foreach(string nome in nomes.Reverse())
            foreach (string nome in nomes)
            {
                lista.Items.Add(nome);
            }
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Luciano");
            fila.Enqueue("Lilian");
            fila.Enqueue("Luana");

            //txtValor.Text = fila.Count.ToString();

            foreach(string item in fila)
            {
                lista.Items.Add(item);
            }

            //txtValor.Text = "O primeiro da fila é: " + fila.Peek();
            //txtValor.Text = "O primeiro da fila a ser removido é: " + fila.Dequeue();
            txtValor.Text = "O último elemento da fila é: " + fila.Last();
            //fila.Clear();
            //lista.Items.Clear();
            //foreach (string item in fila)
            //{
            //    lista.Items.Add(item);
            //}
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            Stack<string> pilha = new Stack<string>();

            pilha.Push("Luciano");
            pilha.Push("Lilian");
            pilha.Push("Luana");
            pilha.Push("Lucas");

            txtValor.Text= pilha.Count.ToString();

            foreach(string item in pilha)
            {
                lista.Items.Add(item);
            }

            //txtValor.Text = "Elemento no topo: " + pilha.Peek();

            //pilha.Clear();
            
            while (pilha.Count > 0)
            {
                txtValor.Text = "O primeiro elemento a ser removido é: " + pilha.Pop();
                lista.Items.Clear();
                foreach (string item in pilha)
                {
                    lista.Items.Add(item);
                }
            }
        }
    }
}
