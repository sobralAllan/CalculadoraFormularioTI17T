using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFormulario
{
    public partial class Form1 : Form
    {
        ModelCalculadora modelo;
        //Conectando a Control com a Modelo
        public Form1()
        {
            InitializeComponent();
            this.modelo = new ModelCalculadora();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.Somar(Convert.ToDouble(maskedTextBox1.Text));
        }//fim do botão somar

        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.Subtrair(Convert.ToDouble(maskedTextBox1.Text));
        }//fim do botão subtrair

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
