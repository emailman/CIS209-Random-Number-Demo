using System;
using System.Windows.Forms;

namespace CIS209_Random_Number_Demo
{
    public partial class Form1 : Form
    {
        Random rand;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int flip = rand.Next(2);
            if (flip == 0)
                MessageBox.Show("Heads");
            else
                MessageBox.Show("Tails");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();
        }
    }
}
