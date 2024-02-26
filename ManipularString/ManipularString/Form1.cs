using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region Contains / ToString
            //string texto = "Este tipo de variável é alfanumérica.";

            //if (texto.Contains("tipo de v"))
            //{
            //    label1.Text = "Contém!";
            //} 
            //else
            //{
            //    label1.Text = "Não Contém!";
            //}

            //int num = 5400;
            //bool res = true;

            //label1.Text = num.ToString();
            //label1.Text = res.ToString();
            #endregion

            #region ToUpper / ToLower
            //string nome = "Luciano HENRIQUE";

            //label1.Text = nome.ToUpper();
            //label1.Text = nome.ToLower();
            #endregion

            #region IndexOf / LastIndexOf
            //string nome = "Luciano Henrique";

            //int indice = nome.IndexOf("ri");
            //int indice = nome.IndexOf("i",5);
            //int indice = nome.IndexOf("i", 5, 8);
            //int indice = nome.LastIndexOf('i');

            //label1.Text = "Indice " + indice;
            #endregion

            #region Insert / Replace 
            //string nome = "Luciano Henrique";

            //string nomeFinal = nome.Insert(7, " Lucas");

            //string nomeFinal = nome.Replace("Henrique","Santos");
            //string nomeFinal = nome.Replace('i', 'I');
            //string nomeFinal = nome.Replace("que", "santos");

            //label1.Text = nomeFinal;
            #endregion

            #region Length / SubString
            //string nome = "Lilian Lourenço";

            //label1.Text = "O nome " + nome + " contem " + nome.Length + " letras";

            //label1.Text = "";
            //for (int i = 0; i < nome.Length; i++) 
            //{
            //    label1.Text += nome[i] + "\n";
            //}

            //string parte = nome.Substring(0,7);
            //string parte = nome.Substring(7);
            //string parte = nome.Substring(nome.IndexOf(" "));

            //label1.Text = parte;

            #endregion

            #region Split
            //string nomes = "Luciano Lilian-Luana_Lucas";

            //string[] separador = { "_+_" };
            //char[] separador = { ' ', '-', '_' };

            //string[] resultado = nomes.Split(separador,StringSplitOptions.None);
            //string[] resultado = nomes.Split(separador);

            //label1.Text = "";
            //foreach (string nome in resultado) 
            // {
            //    label1.Text += nome + "\n";
            //}

            #endregion

            #region StarsWith/EndsWith 
            //string nome = "Luciano";

            //bool res = nome.StartsWith("luc");
            //bool res = nome.StartsWith("luc", StringComparison.OrdinalIgnoreCase);
            //bool res = nome.EndsWith("Ano");
            //bool res = nome.EndsWith("Ano", StringComparison.OrdinalIgnoreCase);


            //if ( res )
            //{
            //    label1.Text = "Positivo!";    
            //}
            //else
            //{
            //    label1.Text = "Negativo!";
            //}

            #endregion

            #region Trim/TrimStart/TrimEnd
            //string mensagem = "   Ola Luciano!     ";
            //string mensagem = " -5 Ola Luciano!_ --";


            //char[] c = { ' ', '-', '_', '5' };

            //label1.Text = ">" + mensagem.Trim() + "<";
            //label1.Text = ">" + mensagem.Trim(c) + "<";
            //label1.Text = ">" + mensagem.TrimStart() + "<";
            //label1.Text = ">" + mensagem.TrimEnd() + "<";

            #endregion

            #region CompareTo / Equals
            //string nome = "Luciano";

            //string nome2 = "Lilian";

            //if (nome.Equals("LucianO"))
            //if (nome.Equals("LucianO",StringComparison.OrdinalIgnoreCase))
            //{
            //    label1.Text = "Verdadeiro!";
            //}
            //else
            //{
            //    label1.Text = "Falso!";
            //}

            //label1.Text = nome.CompareTo(nome2).ToString(); // copara as string por ordem alfabética

            #endregion

            #region Format
            //decimal valor = 19.95m;
            //int temp = 32;

            //string s = string.Format("O valor do produto é {0} e a temperatura é {1}", valor, temp);
            //string s = string.Format("O valor do produto é {1} e a temperatura é {0}", valor, temp);
            //string s = string.Format("O valor do produto é {0:N3} e a temperatura é {1}", valor, temp);
            //string s = string.Format("O valor do produto é {0:C2} e a temperatura é {1}", valor, temp);

            //string s = String.Format("Hoje é {0:d} e são {0:t}", DateTime.Now);
            //string s = String.Format("Hoje é {0:D} e são {0:T}", DateTime.Now);

            //string s = $"O valor do produto é {valor:C4} e a temperatura é {temp} graus!";
            //string s = $"Data: {DateTime.Now:D} e hora {DateTime.Now:T}";

            label1.Text = s;    

            #endregion
        }
    }
}
