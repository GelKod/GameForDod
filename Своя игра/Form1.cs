namespace Своя_игра
{
    public partial class Form1 : Form
    {
        int numberTeam;
        int numberTeam_forEdit;
        public Form1()
        {
            InitializeComponent();
            numberTeam = 0;
            button2.Enabled = false;
            dataGridView1.RowCount = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            numberTeam += 1;
            label4.Text = "Кол-во: " + (numberTeam + 1);
            if (numberTeam == 4)
            {
                button1.Enabled = false;
            }
            dataGridView1.RowCount = numberTeam+1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            numberTeam -= 1;
            label4.Text = "Кол-во: " + (numberTeam + 1);
            if (numberTeam == 0)
            {
                button2.Enabled = false;
            }
            dataGridView1.RowCount = numberTeam+1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}