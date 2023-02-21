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

        public Form2(string[,] names,int g)
        {
            InitializeComponent();
            names2 = names;
            k=g+1;
            if (k == names.GetLength(1))
            {
                k = 0;
            }
            string str = "";
            for (int i = 0; i < names.GetLength(1); i++)
            {
                if (k == i)
                {
                    str += "-> "+ names[0, i] + " - " + names[1, i] + "\r\n";
                }
                else
                {
                    str += "     "+names[0, i] + " - " + names[1, i] + "\r\n";
                }
            }
            label1.Text = str;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
