﻿using System;
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
            FormSegunda f = new FormSegunda();
            //f.Show();
            f.ShowDialog();
            Show();
        }

        private void btnSegundaFormThread_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new FormSegunda()));
            t.Start();
        }
    }
}
