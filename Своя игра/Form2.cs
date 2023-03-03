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
        int[] chek;

        public Form2(string[,] names, int g, int[] chek)
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
            this.chek = chek;
            Block(chek);
        }

        private void Block(int[] a)
        {
            if (a[0] > 0)
                button1.Enabled = false;
            if (a[1] > 0)
                button2.Enabled = false;
            if (a[2] > 0)
                button3.Enabled = false;
            if (a[3] >0)
                button4.Enabled = false;
            if (a[4] > 0)
                button5.Enabled = false;
            if (a[5] > 0)
                button6.Enabled = false;
            if (a[6] > 0)
                button7.Enabled = false;
            if (a[7] > 0)
                button8.Enabled = false;
            if (a[8] > 0)
                button9.Enabled = false;
            if (a[9] > 0)
                button10.Enabled = false;
            if (a[10] > 0)
                button11.Enabled = false;
            if (a[11] > 0)
                button12.Enabled = false;
            if (a[12] > 0)
                button13.Enabled = false;
            if (a[13] > 0)
                button14.Enabled = false;
            if (a[14] > 0)
                button15.Enabled = false;
            if (a[15] > 0)
                button16.Enabled = false;
            if (a[16] > 0)
                button17.Enabled = false;
            if (a[17] > 0)
                button18.Enabled = false;
            if (a[18] > 0)
                button19.Enabled = false;
            if (a[19] > 0)
                button20.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chek[0] = 1;
            this.Hide();
            int g = int.Parse(button1.Text);
            Question question = new Question(g, names2, chek,0);
            question.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chek[1] = 1;
            this.Hide();
            int g = int.Parse(button2.Text);
            Question question = new Question(g, names2, chek, 0);
            question.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chek[5] = 1;
            this.Hide();
            int g = int.Parse(button6.Text);
            Question question = new Question(g, names2, chek,1);
            question.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chek[2] = 1;
            this.Hide();
            int g = int.Parse(button3.Text);
            Question question = new Question(g, names2, chek, 0);
            question.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chek[3] = 1;

            this.Hide();
            int g = int.Parse(button4.Text);
            Question question = new Question(g, names2, chek, 0);
            question.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chek[4] = 1;

            this.Hide();
            int g = int.Parse(button5.Text);
            Question question = new Question(g, names2, chek, 0);
            question.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chek[6] = 1;

            this.Hide();
            int g = int.Parse(button7.Text);
            Question question = new Question(g, names2, chek, 1);
            question.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            chek[7] = 1;

            this.Hide();
            int g = int.Parse(button8.Text);
            Question question = new Question(g, names2, chek, 1);
            question.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            chek[8] = 1;

            this.Hide();
            int g = int.Parse(button9.Text);
            Question question = new Question(g, names2, chek, 1);
            question.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            chek[9] = 1;

            this.Hide();
            int g = int.Parse(button10.Text);
            Question question = new Question(g, names2, chek, 1);
            question.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            chek[10] = 1;

            this.Hide();
            int g = int.Parse(button11.Text);
            Question question = new Question(g, names2, chek, 2);
            question.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            chek[11] = 1;

            this.Hide();
            int g = int.Parse(button12.Text);
            Question question = new Question(g, names2, chek, 2);
            question.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            chek[12] = 1;

            this.Hide();
            int g = int.Parse(button13.Text);
            Question question = new Question(g, names2, chek, 2);
            question.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            chek[13] = 1;

            this.Hide();
            int g = int.Parse(button14.Text);
            Question question = new Question(g, names2, chek, 2);
            question.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            chek[14] = 1;

            this.Hide();
            int g = int.Parse(button15.Text);
            Question question = new Question(g, names2, chek, 2);
            question.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            chek[15] = 1;

            this.Hide();
            int g = int.Parse(button16.Text);
            Question question = new Question(g, names2, chek, 3);
            question.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            chek[16] = 1;

            this.Hide();
            int g = int.Parse(button17.Text);
            Question question = new Question(g, names2, chek, 3);
            question.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            chek[17] = 1;

            this.Hide();
            int g = int.Parse(button18.Text);
            Question question = new Question(g, names2, chek, 3);
            question.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            chek[18] = 1;

            this.Hide();
            int g = int.Parse(button19.Text);
            Question question = new Question(g, names2, chek, 3);
            question.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            chek[19] = 1;
            this.Hide();
            int g = int.Parse(button20.Text);
            Question question = new Question(g, names2, chek, 3);
            question.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
