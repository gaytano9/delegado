﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegado
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public delegate void pasar(string texto);
        public event pasar pasado;
        private void button1_Click(object sender, EventArgs e)
        {
            pasado(textBox1.Text);
            textBox1.Clear();
        }
    }
}
