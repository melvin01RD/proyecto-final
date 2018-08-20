using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_Melvin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double circunferencia;
        double radio;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            radio = Convert.ToDouble(textBox1.Text);
            circunferencia = 2 * Math.PI * radio;
            label2.Text = Convert.ToString("La circunferencia del circulo es: " + circunferencia);

        }
    }
}
