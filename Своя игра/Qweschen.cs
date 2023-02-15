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
    public partial class Qweschen : Form
    {
        string[,] names;
        int k, summ;
        public Qweschen(string[,] str, int k, int sum)
        {
            InitializeComponent();
            names = str;
            this.k = k;
            summ = sum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            names[1,k]= (int.Parse(names[1, k]) + summ).ToString();
            Form2 form2 = new Form2(names,k);
            form2.Show();
        }
    }
}
