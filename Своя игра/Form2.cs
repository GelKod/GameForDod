using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Своя_игра
{
    public partial class Form2 : Form
    {
        string[,] names2;
        int k;

        public Form2(string[,] names, int g)
        {
            InitializeComponent();
            names2 = names;
            k = g;
            string str = "";
            for (int i = 0; i < names.GetLength(1); i++)
            {
                str += "     " + names[0, i] + " - " + names[1, i] + "\r\n";
            }
            label1.Text = str;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Enabled = false;
            this.Hide();
            int g = int.Parse(button1.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button2.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button6.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button3.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button4.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button5.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button7.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button8.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button9.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button10.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button11.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button12.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button13.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button14.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button15.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button16.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button17.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button18.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button19.Text);
            Question question = new Question(g, names2);
            question.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            int g = int.Parse(button20.Text);
            Question question = new Question(g, names2);
            question.Show();
        }
    }
}
