﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMDI
{
    public partial class Form3 : Form
    {
        public Form3(Form parent)
        {
            InitializeComponent();
            MdiParent = parent; 
        }

        private void bntForm2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(MdiParent);
            f.Show();
            Close();
        }
    }
}
