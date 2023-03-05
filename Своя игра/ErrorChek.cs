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
    public partial class ErrorChek : Form
    {
        string[,] names;
        int[] chek;
        string questionsss = "1   2   3   4   5\r\n6   7   8   9   10\r\n11 12 13 14 15\r\n16 17 18 19 20";
        public ErrorChek(string[,] names, int[] chek)
        {
            InitializeComponent();
            this.names = names;
            this.chek = chek;
            label4.Text = questionsss;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(textBox1.Text);
                int x = int.Parse(textBox2.Text);
                if (radioButton1.Checked == true)
                {
                    names[1, i-1] = (int.Parse(names[1, i-1]) - x).ToString();
                }
                else if(radioButton2.Checked == true)
                {
                    names[1, i-1] = (int.Parse(names[1, i - 1]) + x).ToString();
                }
                this.Close();
                Form2 f = new Form2(names, chek);
                f.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели не целое число либо вовсе не число", "Error");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(textBox3.Text);
                chek[i - 1] = 0;
                Form2 f = new Form2(names, chek);
                f.Show();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели не целое число либо вовсе не число", "Error");
            }
        }
    }
}
