using System;

namespace windowsforms
{
    public partial class Form1 : Form
    {
        int tempo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal soma = numericUpDown1.Value + numericUpDown2.Value;
            MessageBox.Show(soma.ToString());
        }
        int contadorDeCliques = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            contadorDeCliques++;

            label1.Text = "" + contadorDeCliques;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numeroDeCaracteres = textBox1.Text.Length;

            // Mostra o número de caracteres numa MessageBox
            MessageBox.Show("" + numeroDeCaracteres.ToString());
        }


        Random ra = new Random();
        private void button5_Click(object sender, EventArgs e)
        {
            int numeroAleatorio = ra.Next(1, 100);
            label2.Text = "" + numeroAleatorio;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo++;
            label3.Text = tempo.ToString();
        }
    }
}
