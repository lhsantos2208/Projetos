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
    public partial class FormSegunda : Form
    {
        public FormSegunda()
        {
            InitializeComponent();
        }

        private void FormSegunda_Load(object sender, EventArgs e)
        {

        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new FormMain()));
            t.Start();
        }
    }
}
