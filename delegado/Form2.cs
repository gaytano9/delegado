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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public delegate void pasar(string texto);
        public event pasar pasado;

        public delegate void incrementar(int val);
        public event incrementar incrementando;
        private void button1_Click(object sender, EventArgs e)
        {
            pasado(textBox1.Text);
            textBox1.Clear();
            timer1.Start();


        }
        int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            incrementando(cont);
            if (cont == 60)
            {
                timer1.Stop();
            }
            cont++;
        }
    }
}
