namespace Своя_игра
{
    public partial class Form1 : Form
    {
        int numberOfTeams = 0;
        string[] teams = {"", "", "", "", ""};
        public Form1()
        {
            InitializeComponent();
        }
        static string[] Add_elem(string[] arr, string elem)
        {
            string[] newArr = new string[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[newArr.Length - 1] = elem;
            return newArr;
        }

        static void Insert_elem(ref string[] arr, int index, string elem)
        {
            arr[index] = elem;
        }

        static void Del_elem(ref string[] arr, string elem)
        {
            arr = arr.Where(e => e != elem).ToArray();
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (numberOfTeams > 0)
            {
                Form2 game = new Form2(teams, numberOfTeams);
                game.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void menu_team1_buttonAdd_Click(object sender, EventArgs e)
        {
            menu_team2_name.Visible = true;
            menu_team2_buttonAdd.Visible = true;
            menu_team1_name.Enabled = false;
            menu_team1_buttonDel.Visible = true;
            menu_team1_buttonAdd.Visible = false;
            numberOfTeams++;
            Insert_elem(ref teams, 0, menu_team1_name.Text);
        }

        private void menu_team1_buttonDel_Click(object sender, EventArgs e)
        {
            switch (numberOfTeams)
            {
                case 1:
                    teams[0] = "";
                    menu_team1_name.Text = "";
                    menu_team2_name.Visible = false;
                    menu_team2_buttonAdd.Visible = false;
                    menu_team1_name.Enabled = true;
                    menu_team1_buttonDel.Visible = false;
                    menu_team1_buttonAdd.Visible = true;
                    break;
                case 2:
                    menu_team1_name.Text = menu_team2_name.Text;
                    teams[0] = teams[1];
                    teams[1] = "";
                    menu_team2_name.Text = "";
                    menu_team3_name.Visible = false;
                    menu_team3_buttonAdd.Visible = false;
                    menu_team2_name.Enabled = true;
                    menu_team2_buttonDel.Visible = false;
                    menu_team2_buttonAdd.Visible = true;
                    break;
                case 3:
                    menu_team1_name.Text = menu_team2_name.Text;
                    menu_team2_name.Text = menu_team3_name.Text;
                    teams[0] = teams[1];
                    teams[1] = teams[2];
                    teams[2] = "";
                    menu_team3_name.Text = "";
                    menu_team4_name.Visible = false;
                    menu_team4_buttonAdd.Visible = false;
                    menu_team3_name.Enabled = true;
                    menu_team3_buttonDel.Visible = false;
                    menu_team3_buttonAdd.Visible = true;
                    break;
                case 4:
                    menu_team1_name.Text = menu_team2_name.Text;
                    menu_team2_name.Text = menu_team3_name.Text;
                    menu_team3_name.Text = menu_team4_name.Text;
                    teams[0] = teams[1];
                    teams[1] = teams[2];
                    teams[2] = teams[3];
                    teams[3] = "";
                    menu_team4_name.Text = "";
                    menu_team5_name.Visible = false;
                    menu_team5_buttonAdd.Visible = false;
                    menu_team4_name.Enabled = true;
                    menu_team4_buttonDel.Visible = false;
                    menu_team4_buttonAdd.Visible = true;
                    break;
                case 5:
                    menu_team1_name.Text = menu_team2_name.Text;
                    menu_team2_name.Text = menu_team3_name.Text;
                    menu_team3_name.Text = menu_team4_name.Text;
                    menu_team4_name.Text = menu_team5_name.Text;
                    teams[0] = teams[1];
                    teams[1] = teams[2];
                    teams[2] = teams[3];
                    teams[3] = teams[4];
                    teams[4] = "";
                    menu_team5_name.Text = "";
                    menu_team5_name.Enabled = true;
                    menu_team5_buttonDel.Visible = false;
                    menu_team5_buttonAdd.Visible = true;
                    break;
            }
            numberOfTeams--;
        }

        private void menu_team2_buttonAdd_Click(object sender, EventArgs e)
        {
            menu_team3_name.Visible = true;
            menu_team3_buttonAdd.Visible = true;
            menu_team2_name.Enabled = false;
            menu_team2_buttonDel.Visible = true;
            menu_team2_buttonAdd.Visible = false;
            numberOfTeams++;
            Insert_elem(ref teams, 1, menu_team2_name.Text);
        }

        private void menu_team2_buttonDel_Click(object sender, EventArgs e)
        {
            switch (numberOfTeams)
            {
                case 2:
                    teams[2] = "";
                    menu_team2_name.Text = "";
                    menu_team3_name.Visible = false;
                    menu_team3_buttonAdd.Visible = false;
                    menu_team2_name.Enabled = true;
                    menu_team2_buttonDel.Visible = false;
                    menu_team2_buttonAdd.Visible = true;
                    break;
                case 3:
                    teams[1] = teams[2];
                    teams[2] = "";
                    menu_team2_name.Text = menu_team3_name.Text;
                    menu_team3_name.Text = "";
                    menu_team4_name.Visible = false;
                    menu_team4_buttonAdd.Visible = false;
                    menu_team3_name.Enabled = true;
                    menu_team3_buttonDel.Visible = false;
                    menu_team3_buttonAdd.Visible = true;
                    break;
                case 4:
                    teams[1] = teams[2];
                    teams[2] = teams[3];
                    teams[3] = "";
                    menu_team2_name.Text = menu_team3_name.Text;
                    menu_team3_name.Text = menu_team4_name.Text;
                    menu_team4_name.Text = "";
                    menu_team5_name.Visible = false;
                    menu_team5_buttonAdd.Visible = false;
                    menu_team4_name.Enabled = true;
                    menu_team4_buttonDel.Visible = false;
                    menu_team4_buttonAdd.Visible = true;
                    break;
                case 5:
                    teams[1] = teams[2];
                    teams[2] = teams[3];
                    teams[3] = teams[4];
                    teams[4] = "";
                    menu_team2_name.Text = menu_team3_name.Text;
                    menu_team3_name.Text = menu_team4_name.Text;
                    menu_team4_name.Text = menu_team5_name.Text;
                    menu_team5_name.Text = "";
                    menu_team5_name.Enabled = true;
                    menu_team5_buttonDel.Visible = false;
                    menu_team5_buttonAdd.Visible = true;
                    break;
            }
            numberOfTeams--;
        }

        private void menu_team3_buttonDel_Click(object sender, EventArgs e)
        {
            switch (numberOfTeams)
            {
                case 3:
                    teams[2] = "";
                    menu_team3_name.Text = "";
                    menu_team4_name.Visible = false;
                    menu_team4_buttonAdd.Visible = false;
                    menu_team3_name.Enabled = true;
                    menu_team3_buttonDel.Visible = false;
                    menu_team3_buttonAdd.Visible = true;
                    break;
                case 4:
                    teams[2] = teams[3];
                    teams[3] = "";
                    menu_team3_name.Text = menu_team4_name.Text;
                    menu_team4_name.Text = "";
                    menu_team5_name.Visible = false;
                    menu_team5_buttonAdd.Visible = false;
                    menu_team4_name.Enabled = true;
                    menu_team4_buttonDel.Visible = false;
                    menu_team4_buttonAdd.Visible = true;
                    break;
                case 5:
                    teams[2] = teams[3];
                    teams[3] = teams[4];
                    teams[4] = "";
                    menu_team3_name.Text = menu_team4_name.Text;
                    menu_team4_name.Text = menu_team5_name.Text;
                    menu_team5_name.Text = "";
                    menu_team5_name.Enabled = true;
                    menu_team5_buttonDel.Visible = false;
                    menu_team5_buttonAdd.Visible = true;
                    break;
            }
            numberOfTeams--;
        }

        private void menu_team4_buttonDel_Click(object sender, EventArgs e)
        {
            switch (numberOfTeams)
            {
                case 4:
                    teams[3] = "";
                    menu_team4_name.Text = "";
                    menu_team5_name.Visible = false;
                    menu_team5_buttonAdd.Visible = false;
                    menu_team4_name.Enabled = true;
                    menu_team4_buttonDel.Visible = false;
                    menu_team4_buttonAdd.Visible = true;
                    break;
                case 5:
                    teams[3] = teams[4];
                    teams[4] = "";
                    menu_team4_name.Text = menu_team5_name.Text;
                    menu_team5_name.Text = "";
                    menu_team5_name.Enabled = true;
                    menu_team5_buttonDel.Visible = false;
                    menu_team5_buttonAdd.Visible = true;
                    break;
            }
            numberOfTeams--;
        }

        private void menu_team5_buttonDel_Click(object sender, EventArgs e)
        {
            switch (numberOfTeams)
            {
                case 5:
                    teams[4] = "";
                    menu_team5_name.Text = "";
                    menu_team5_name.Enabled = true;
                    menu_team5_buttonDel.Visible = false;
                    menu_team5_buttonAdd.Visible = true;
                    break;
            }
            numberOfTeams--;
        }

        private void menu_team3_buttonAdd_Click(object sender, EventArgs e)
        {
            menu_team4_name.Visible = true;
            menu_team4_buttonAdd.Visible = true;
            menu_team3_name.Enabled = false;
            menu_team3_buttonDel.Visible = true;
            menu_team3_buttonAdd.Visible = false;
            numberOfTeams++;
            Insert_elem(ref teams, 2, menu_team3_name.Text);
        }

        private void menu_team4_buttonAdd_Click(object sender, EventArgs e)
        {
            menu_team5_name.Visible = true;
            menu_team5_buttonAdd.Visible = true;
            menu_team4_name.Enabled = false;
            menu_team4_buttonDel.Visible = true;
            menu_team4_buttonAdd.Visible = false;
            numberOfTeams++;
            Insert_elem(ref teams, 3, menu_team4_name.Text);
        }

        private void menu_team5_buttonAdd_Click(object sender, EventArgs e)
        {
            menu_team5_name.Enabled = false;
            menu_team5_buttonDel.Visible = true;
            menu_team5_buttonAdd.Visible = false;
            numberOfTeams++;
            Insert_elem(ref teams, 4, menu_team5_name.Text);
        }
    }
}