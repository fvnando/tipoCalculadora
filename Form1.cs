using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipoCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt16(textBox1.Text);
            valor2 = Convert.ToInt16(textBox2.Text);

            resultado = valor1 + valor2;
            label4.Text = Convert.ToString(resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt16(textBox1.Text);
            valor2 = Convert.ToInt16(textBox2.Text);

            resultado = valor1 - valor2;
            label4.Text = Convert.ToString(resultado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float valor1, valor2, resultado;

            valor1 = Convert.ToInt16(textBox1.Text);
            valor2 = Convert.ToInt16(textBox2.Text);

            resultado = valor1 / valor2;
            label4.Text = Convert.ToString(resultado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;

            valor1 = Convert.ToInt16(textBox1.Text);
            valor2 = Convert.ToInt16(textBox2.Text);

            resultado = valor1 * valor2;
            label4.Text = Convert.ToString(resultado);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
        }
    }
}
