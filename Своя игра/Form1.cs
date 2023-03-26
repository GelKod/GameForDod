namespace Своя_игра
{
    public partial class Form1 : Form
    {
        
        int numberTeam;
        string[,] teamNames;
        //Список с рандомными названиями которые будут рандомно заполнятся при добавления new команды.
        string[] defoltNames = { "Почему...", "Кто-то", "Настойки", "Чебупели", "Крокодилы" };
        string[] selectedNames = {};
        int[] chek = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            numberTeam = 0;
            button2.Enabled = false;
            dataGridView1.RowCount = 1;
            int r = rnd.Next(0, defoltNames.Length);
            dataGridView1[0, 0].Value = defoltNames[r];
            selectedNames = Add_elem(selectedNames, defoltNames[r]);

            defoltNames = defoltNames.Where(e => e != defoltNames[r]).ToArray();
        }

        static void Insert(ref string[] array, string value)
        {
            string[] temp = new string[array.Length + 1];
            temp[array.Length] = value;
            array = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int r = rnd.Next(0, defoltNames.Length);

            button2.Enabled = true;
            numberTeam += 1;
            if (numberTeam == 4)
            {
                button1.Enabled = false;
            }
            dataGridView1.RowCount = numberTeam + 1;
            dataGridView1[0, numberTeam].Value = defoltNames[r];
            selectedNames = Add_elem(selectedNames, defoltNames[r]);

            defoltNames = defoltNames.Where(e => e != defoltNames[r]).ToArray();
        }

        static string[] Add_elem(string[] arr, string elem)
        {
            string[] newArr = new string[arr.Length + 1];
            for(int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[newArr.Length - 1] = elem;
            return newArr;
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

            defoltNames = Add_elem(defoltNames, selectedNames[selectedNames.Length - 1]);

            selectedNames = selectedNames.Where(e => e != selectedNames[selectedNames.Length - 1]).ToArray();

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

                Form2 game = new Form2(teamNames,chek);
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

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}