using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 frm =new Form2();
            frm.pasado += Frm_pasado;
            frm.Show();
        }

        private void Frm_pasado(string texto)
        {
            textBox1.Text += texto + Environment.NewLine;
        }

        private void agregarTexto(string texto) {
            textBox1.Text = Text + Environment.NewLine;
        }
    }
}
