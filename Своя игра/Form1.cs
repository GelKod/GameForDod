namespace Своя_игра
{
    public partial class Form1 : Form
    {
        int numberTeam;
        string[,] teamNames;
        string[] defoltNames = { "Почему...", "Кто-то", "Настойки", "Чебупели", "Крокодилы" };

        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            numberTeam = 0;
            button2.Enabled = false;
            dataGridView1.RowCount = 1;
            dataGridView1[0, 0].Value = defoltNames[rnd.Next(0, 5)];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            button2.Enabled = true;
            numberTeam += 1;
            if (numberTeam == 4)
            {
                button1.Enabled = false;
            }
            dataGridView1.RowCount = numberTeam + 1;
            dataGridView1[0, numberTeam].Value = defoltNames[rnd.Next(0, 5)];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            numberTeam -= 1;
            if (numberTeam == 0)
            {
                button2.Enabled = false;
            }
            dataGridView1.RowCount = numberTeam + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teamNames = new string[2, dataGridView1.RowCount];
            int j = -1;
            for (int i = 0; i < teamNames.GetLength(1); i++)
            {
                if (dataGridView1[0, i].Value != null)
                {
                    teamNames[0, i] = dataGridView1[0, i].Value.ToString();
                    teamNames[1, i] = "0";
                }
                else
                {
                    j = 5;
                }
            }
            if (j != 5)
            {
                //новое окно или что то для самой игры 

                Form2 game = new Form2(teamNames,j);
                this.Hide();
                game.Show();

                //form.Close();

                //Проверка ввода названия команд


                //for (int i = 0; i < teamNames.GetLength(1); i++)
                //{
                //    str += teamNames[0, i] + " " + teamNames[1, i] + "\r\n";
                //}
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}