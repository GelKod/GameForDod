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
    public partial class Question : Form
    {
        string[,] txt = new string[4, 5];
        string[,] name;
        int[] cheked;
        int g = 0;
        public Question(int a, string[,] names, int[] cheked, int b)
        {
            InitializeComponent();

            name = names;
            this.cheked = cheked;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            button1.Text = "-";
            button2.Text = "+";
            button3.Text = "-";
            button4.Text = "+";
            button5.Text = "-";
            button6.Text = "+";
            button7.Text = "-";
            button8.Text = "+";
            button9.Text = "-";
            button10.Text = "+";

            int j = (a / 100) - 1;
            label1.Text = txt[b, j];
            txt = Text2();
            g = a;

            if (names.GetLength(1) == 1)
            {
                button1.Visible = true;
                button2.Visible = true;

                label2.Visible = true;

                label2.Text = "     " + names[0, 0] + " - " + names[1, 0] + "\r\n";
            }
            else if (names.GetLength(1) == 2)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;

                label2.Visible = true;
                label3.Visible = true;

                label2.Text = "     " + names[0, 0] + " - " + names[1, 0] + "\r\n";
                label3.Text = "     " + names[0, 1] + " - " + names[1, 1] + "\r\n";
            }
            else if (names.GetLength(1) == 3)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;

                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;

                label2.Text = "     " + names[0, 0] + " - " + names[1, 0] + "\r\n";
                label3.Text = "     " + names[0, 1] + " - " + names[1, 1] + "\r\n";
                label4.Text = "     " + names[0, 2] + " - " + names[1, 2] + "\r\n";
            }
            else if (names.GetLength(1) == 4)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;

                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;

                label2.Text = "     " + names[0, 0] + " - " + names[1, 0] + "\r\n";
                label3.Text = "     " + names[0, 1] + " - " + names[1, 1] + "\r\n";
                label4.Text = "     " + names[0, 2] + " - " + names[1, 2] + "\r\n";
                label5.Text = "     " + names[0, 3] + " - " + names[1, 3] + "\r\n";
            }
            else if (names.GetLength(1) == 5)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;

                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;

                label2.Text = "     " + names[0, 0] + " - " + names[1, 0] + "\r\n";
                label3.Text = "     " + names[0, 1] + " - " + names[1, 1] + "\r\n";
                label4.Text = "     " + names[0, 2] + " - " + names[1, 2] + "\r\n";
                label5.Text = "     " + names[0, 3] + " - " + names[1, 3] + "\r\n";
                label6.Text = "     " + names[0, 4] + " - " + names[1, 4] + "\r\n";
            }
        }

        private string[,] Text2()
        {
            string[,] text = new string[4, 5];
            text[0, 0] = "";
            text[0, 1] = "";
            text[0, 2] = "";
            text[0, 3] = "";
            text[0, 4] = "";
            text[1, 0] = "";
            text[1, 1] = "";
            text[1, 2] = "";
            text[1, 3] = "";
            text[1, 4] = "";
            text[2, 0] = "";
            text[2, 1] = "";
            text[2, 2] = "";
            text[2, 3] = "";
            text[2, 4] = "";
            text[3, 0] = "";
            text[3, 1] = "";
            text[3, 2] = "";
            text[3, 3] = "";
            text[3, 4] = "";
            return text;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j = int.Parse(name[1, 0]) - g;
            name[1, 0] = j.ToString();

            label2.Text = "     " + name[0, 0] + " - " + name[1, 0] + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int j = int.Parse(name[1, 0]) + g;
            name[1, 0] = j.ToString();
            this.Close();
            Form2 fr = new Form2(name, g, cheked);
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int j = int.Parse(name[1, 1]) - g;
            name[1, 1] = j.ToString();

            label3.Text = "     " + name[0, 1] + " - " + name[1, 1] + "\r\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int j = int.Parse(name[1, 1]) + g;
            name[1, 1] = j.ToString();
            this.Close();
            Form2 fr = new Form2(name, g, cheked);
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int j = int.Parse(name[1, 2]) - g;
            name[1, 2] = j.ToString();

            label4.Text = "     " + name[0, 2] + " - " + name[1, 2] + "\r\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int j = int.Parse(name[1, 2]) + g;
            name[1, 2] = j.ToString();
            this.Close();
            Form2 fr = new Form2(name, g, cheked);
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int j = int.Parse(name[1, 3]) - g;
            name[1, 3] = j.ToString();

            label5.Text = "     " + name[0, 3] + " - " + name[1, 3] + "\r\n";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int j = int.Parse(name[1, 3]) + g;
            name[1, 3] = j.ToString();
            this.Close();
            Form2 fr = new Form2(name, g, cheked);
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int j = int.Parse(name[1, 4]) - g;
            name[1, 4] = j.ToString();

            label6.Text = "     " + name[0, 4] + " - " + name[1, 4] + "\r\n";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int j = int.Parse(name[1, 4]) + g;
            name[1, 4] = j.ToString();
            this.Close();
            Form2 fr = new Form2(name, g, cheked);
            fr.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 fr = new Form2(name, g, cheked);
            fr.Show();
        }
    }
}
