using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class Game : Form
    {
        int numerosorteado;
        int palpite;
        int tentativa=1;

        public Game(int numero)
        {
            InitializeComponent();
            numerosorteado = numero;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {
           label1.Text ="Tente adivinhar o número\r\n \r\n Digite um valor :";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            palpite = Convert.ToInt32(textBox1.Text);
            if (palpite==numerosorteado)
            {
                MessageBox.Show("Parabéns você acertou o número com " + tentativa + " tentativas!");
            }
            else
            {
                MessageBox.Show("Você errou, tente novamente!");
                if (palpite > numerosorteado)
                {
                    label1.Text = "O número é menor que " + palpite;
                }
                else
                {
                    label1.Text = "O número é maior que " + palpite;
                }
               
                tentativa = tentativa + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
