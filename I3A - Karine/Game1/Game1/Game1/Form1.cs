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
    public partial class Form1 : Form
    {
    
        Random random = new Random();
        int sorteio;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(progressBar1.Step);
            label1.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                sorteio = random.Next(100);
                Game game = new Game(sorteio);

                this.Hide();
                game.Show();
              
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
