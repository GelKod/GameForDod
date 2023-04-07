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
        int numberOfTeams;
        int price = 0;
        int control = 0;

        // вопросы
        string question_1 = "bfkvdfkgvdfkjgavfljjabf";
        string question_2 = "";
        string question_3 = "";
        string question_4 = "";
        string question_5 = "";
        string question_6 = "";
        string question_7 = "";
        string question_8 = "";
        string question_9 = "";
        string question_10 = "";
        string question_11 = "";
        string question_12 = "";
        string question_13 = "";
        string question_14 = "";
        string question_15 = "";
        string question_16 = "";
        string question_17 = "";
        string question_18 = "";
        string question_19 = "";
        string question_20 = "";

        // счёт
        int score1 = 0;
        int score2 = 0;
        int score3 = 0;
        int score4 = 0;
        int score5 = 0;


        public Form2(string[] names, int numberOfTeams)
        {
            InitializeComponent();
            this.numberOfTeams = numberOfTeams;

            team1_name.Text = names[0];
            team2_name.Text = names[1];
            team3_name.Text = names[2];
            team4_name.Text = names[3];
            team5_name.Text = names[4];

            question_panel_team1_name.Text = names[0];
            question_panel_team2_name.Text = names[1];
            question_panel_team3_name.Text = names[2];
            question_panel_team4_name.Text = names[3];
            question_panel_team5_name.Text = names[4];

            team1_score.Text = Convert.ToString(score1);
            team2_score.Text = Convert.ToString(score2);
            team3_score.Text = Convert.ToString(score3);
            team4_score.Text = Convert.ToString(score4);
            team5_score.Text = Convert.ToString(score5);
            switch (numberOfTeams)
            {
                case 1:
                    //team1_name.Text = names[0];
                    team1_name.Visible = true;
                    team1_score.Visible = true;
                    question_panel_team1_win.Visible = true;
                    question_panel_team1_name.Visible = true;
                    question_panel_team1_score.Visible = true;
                    question_panel_team1_lose.Visible = true;
                    break;
                case 2:
                    team1_name.Visible = true;
                    team1_score.Visible = true;

                    question_panel_team1_win.Visible = true;
                    question_panel_team1_name.Visible = true;
                    question_panel_team1_score.Visible = true;
                    question_panel_team1_lose.Visible = true;

                    question_panel_team2_win.Visible = true;
                    question_panel_team2_name.Visible = true;
                    question_panel_team2_score.Visible = true;
                    question_panel_team2_lose.Visible = true;
                    //team1_name.Text = names[0];
                    team2_name.Visible = true;
                    team2_score.Visible = true;
                    //team2_name.Text = names[1];
                    break;
                case 3:
                    team1_name.Visible = true;
                    team1_score.Visible = true;
                    //team1_name.Text = names[0];
                    team2_name.Visible = true;
                    team2_score.Visible = true;
                    //team2_name.Text = names[1];
                    team3_name.Visible = true;
                    team3_score.Visible = true;
                    //team3_name.Text = names[2];

                    question_panel_team1_win.Visible = true;
                    question_panel_team1_name.Visible = true;
                    question_panel_team1_score.Visible = true;
                    question_panel_team1_lose.Visible = true;

                    question_panel_team2_win.Visible = true;
                    question_panel_team2_name.Visible = true;
                    question_panel_team2_score.Visible = true;
                    question_panel_team2_lose.Visible = true;

                    question_panel_team3_win.Visible = true;
                    question_panel_team3_name.Visible = true;
                    question_panel_team3_score.Visible = true;
                    question_panel_team3_lose.Visible = true;

                    break;
                case 4:
                    team1_name.Visible = true;
                    team1_score.Visible = true;
                    //team1_name.Text = names[0];
                    team2_name.Visible = true;
                    team2_score.Visible = true;
                    //team2_name.Text = names[1];
                    team3_name.Visible = true;
                    team3_score.Visible = true;
                    //team3_name.Text = names[2];
                    team4_name.Visible = true;
                    team4_score.Visible = true;
                    //team4_name.Text = names[3];

                    question_panel_team1_win.Visible = true;
                    question_panel_team1_name.Visible = true;
                    question_panel_team1_score.Visible = true;
                    question_panel_team1_lose.Visible = true;

                    question_panel_team2_win.Visible = true;
                    question_panel_team2_name.Visible = true;
                    question_panel_team2_score.Visible = true;
                    question_panel_team2_lose.Visible = true;

                    question_panel_team3_win.Visible = true;
                    question_panel_team3_name.Visible = true;
                    question_panel_team3_score.Visible = true;
                    question_panel_team3_lose.Visible = true;

                    question_panel_team4_win.Visible = true;
                    question_panel_team4_name.Visible = true;
                    question_panel_team4_score.Visible = true;
                    question_panel_team4_lose.Visible = true;
                    break;
                case 5:
                    team1_name.Visible = true;
                    team1_score.Visible = true;
                    //team1_name.Text = names[0];
                    team2_name.Visible = true;
                    team2_score.Visible = true;
                    //team2_name.Text = names[1];
                    team3_name.Visible = true;
                    team3_score.Visible = true;
                    //team3_name.Text = names[2];
                    team4_name.Visible = true;
                    team4_score.Visible = true;
                    //team4_name.Text = names[3];
                    team5_name.Visible = true;
                    team5_score.Visible = true;
                    //team5_name.Text = names[4];

                    question_panel_team1_win.Visible = true;
                    question_panel_team1_name.Visible = true;
                    question_panel_team1_score.Visible = true;
                    question_panel_team1_lose.Visible = true;

                    question_panel_team2_win.Visible = true;
                    question_panel_team2_name.Visible = true;
                    question_panel_team2_score.Visible = true;
                    question_panel_team2_lose.Visible = true;

                    question_panel_team3_win.Visible = true;
                    question_panel_team3_name.Visible = true;
                    question_panel_team3_score.Visible = true;
                    question_panel_team3_lose.Visible = true;

                    question_panel_team4_win.Visible = true;
                    question_panel_team4_name.Visible = true;
                    question_panel_team4_score.Visible = true;
                    question_panel_team4_lose.Visible = true;

                    question_panel_team5_win.Visible = true;
                    question_panel_team5_name.Visible = true;
                    question_panel_team5_score.Visible = true;
                    question_panel_team5_lose.Visible = true;

                    break;
            }

        }

        public void ShowTeams(int k)
        {
            switch (k)
            {
                case 1:
                    question_panel_team1_win.Visible = true;
                    question_panel_team1_name.Visible = true;
                    question_panel_team1_score.Visible = true;
                    question_panel_team1_lose.Visible = true;
                    break;
                case 2:
                    question_panel_team1_win.Visible = true;
                    question_panel_team1_name.Visible = true;
                    question_panel_team1_score.Visible = true;
                    question_panel_team1_lose.Visible = true;

                    question_panel_team2_win.Visible = true;
                    question_panel_team2_name.Visible = true;
                    question_panel_team2_score.Visible = true;
                    question_panel_team2_lose.Visible = true;
                    break;
                case 3:
                    question_panel_team1_win.Visible = true;
                    question_panel_team1_name.Visible = true;
                    question_panel_team1_score.Visible = true;
                    question_panel_team1_lose.Visible = true;

                    question_panel_team2_win.Visible = true;
                    question_panel_team2_name.Visible = true;
                    question_panel_team2_score.Visible = true;
                    question_panel_team2_lose.Visible = true;

                    question_panel_team3_win.Visible = true;
                    question_panel_team3_name.Visible = true;
                    question_panel_team3_score.Visible = true;
                    question_panel_team3_lose.Visible = true;
                    break;
                case 4:
                    question_panel_team1_win.Visible = true;
                    question_panel_team1_name.Visible = true;
                    question_panel_team1_score.Visible = true;
                    question_panel_team1_lose.Visible = true;

                    question_panel_team2_win.Visible = true;
                    question_panel_team2_name.Visible = true;
                    question_panel_team2_score.Visible = true;
                    question_panel_team2_lose.Visible = true;

                    question_panel_team3_win.Visible = true;
                    question_panel_team3_name.Visible = true;
                    question_panel_team3_score.Visible = true;
                    question_panel_team3_lose.Visible = true;

                    question_panel_team4_win.Visible = true;
                    question_panel_team4_name.Visible = true;
                    question_panel_team4_score.Visible = true;
                    question_panel_team4_lose.Visible = true;
                    break;
                case 5:
                    question_panel_team1_win.Visible = true;
                    question_panel_team1_name.Visible = true;
                    question_panel_team1_score.Visible = true;
                    question_panel_team1_lose.Visible = true;

                    question_panel_team2_win.Visible = true;
                    question_panel_team2_name.Visible = true;
                    question_panel_team2_score.Visible = true;
                    question_panel_team2_lose.Visible = true;

                    question_panel_team3_win.Visible = true;
                    question_panel_team3_name.Visible = true;
                    question_panel_team3_score.Visible = true;
                    question_panel_team3_lose.Visible = true;

                    question_panel_team4_win.Visible = true;
                    question_panel_team4_name.Visible = true;
                    question_panel_team4_score.Visible = true;
                    question_panel_team4_lose.Visible = true;

                    question_panel_team5_win.Visible = true;
                    question_panel_team5_name.Visible = true;
                    question_panel_team5_score.Visible = true;
                    question_panel_team5_lose.Visible = true;
                    break;
            }
        }
        private void Block(int a)
        {
            switch (a)
            {
                case 11:
                    question_button_11.Text = "";
                    question_button_11.Enabled = false;
                    break;
                case 12:
                    question_button_12.Text = "";
                    question_button_12.Enabled = false;
                    break;
                case 13:
                    question_button_13.Text = "";
                    question_button_13.Enabled = false;
                    break;
                case 14:
                    question_button_14.Text = "";
                    question_button_14.Enabled = false;
                    break;
                case 15:
                    question_button_15.Text = "";
                    question_button_15.Enabled = false;
                    break;
                case 21:
                    question_button_21.Text = "";
                    question_button_21.Enabled = false;
                    break;
                case 22:
                    question_button_22.Text = "";
                    question_button_22.Enabled = false;
                    break;
                case 23:
                    question_button_23.Text = "";
                    question_button_23.Enabled = false;
                    break;
                case 24:
                    question_button_24.Text = "";
                    question_button_24.Enabled = false;
                    break;
                case 25:
                    question_button_25.Text = "";
                    question_button_25.Enabled = false;
                    break;
                case 31:
                    question_button_31.Text = "";
                    question_button_31.Enabled = false;
                    break;
                case 32:
                    question_button_32.Text = "";
                    question_button_32.Enabled = false;
                    break;
                case 33:
                    question_button_33.Text = "";
                    question_button_33.Enabled = false;
                    break;
                case 34:
                    question_button_34.Text = "";
                    question_button_34.Enabled = false;
                    break;
                case 35:
                    question_button_35.Text = "";
                    question_button_35.Enabled = false;
                    break;
                case 41:
                    question_button_41.Text = "";
                    question_button_41.Enabled = false;
                    break;
                case 42:
                    question_button_42.Text = "";
                    question_button_42.Enabled = false;
                    break;
                case 43:
                    question_button_43.Text = "";
                    question_button_43.Enabled = false;
                    break;
                case 44:
                    question_button_44.Text = "";
                    question_button_44.Enabled = false;
                    break;
                case 45:
                    question_button_45.Text = "";
                    question_button_45.Enabled = false;
                    break;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void SetScore1()
        {
            question_panel_team1_score.Text = Convert.ToString(score1);
            question_panel_team2_score.Text = Convert.ToString(score2);
            question_panel_team3_score.Text = Convert.ToString(score3);
            question_panel_team4_score.Text = Convert.ToString(score4);
            question_panel_team5_score.Text = Convert.ToString(score5);

            team1_score.Text = Convert.ToString(score1);
            team2_score.Text = Convert.ToString(score2);
            team3_score.Text = Convert.ToString(score3);
            team4_score.Text = Convert.ToString(score4);
            team5_score.Text = Convert.ToString(score5);
        }


        // 1 - тема
        private void question_button_11_Click(object sender, EventArgs e)
        {
            this.price = 100;
            this.control = 11;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_1;
            Block(control);

        }

        private void question_button_12_Click(object sender, EventArgs e)
        {
            this.price = 200;
            this.control = 12;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_2;
            Block(control);
        }

        private void question_button_13_Click(object sender, EventArgs e)
        {
            this.price = 300;
            this.control = 13;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_3;
            Block(control);
        }

        private void question_button_14_Click(object sender, EventArgs e)
        {
            this.price = 400;
            this.control = 14;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_4;
            Block(control);
        }

        private void question_button_15_Click(object sender, EventArgs e)
        {
            this.price = 500;
            this.control = 15;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_5;
            Block(control);
        }

        // 2 - тема
        private void question_button_21_Click(object sender, EventArgs e)
        {
            this.price = 100;
            this.control = 21;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_6;
            Block(control);
        }

        private void question_button_22_Click(object sender, EventArgs e)
        {
            this.price = 200;
            this.control = 22;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_7;
            Block(control);
        }

        private void question_button_23_Click(object sender, EventArgs e)
        {
            this.price = 300;
            this.control = 23;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_8;
            Block(control);
        }

        private void question_button_24_Click(object sender, EventArgs e)
        {
            this.price = 400;
            this.control = 24;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_9;
            Block(control);
        }

        private void question_button_25_Click(object sender, EventArgs e)
        {
            this.price = 500;
            this.control = 25;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_10;
            Block(control);
        }

        // 3 - тема
        private void question_button_31_Click(object sender, EventArgs e)
        {
            this.price = 100;
            this.control = 31;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_11;
            Block(control);
        }

        private void question_button_32_Click(object sender, EventArgs e)
        {
            this.price = 200;
            this.control = 32;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_12;
            Block(control);
        }

        private void question_button_33_Click(object sender, EventArgs e)
        {
            this.price = 300;
            this.control = 33;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_13;
            Block(control);
        }

        private void question_button_34_Click(object sender, EventArgs e)
        {
            this.price = 400;
            this.control = 34;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_14;
            Block(control);
        }

        private void question_button_35_Click(object sender, EventArgs e)
        {
            this.price = 500;
            this.control = 35;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_15;
            Block(control);
        }

        // 4 - тема
        private void question_button_41_Click(object sender, EventArgs e)
        {
            this.price = 100;
            this.control = 41;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_16;
            Block(control);
        }

        private void question_button_42_Click(object sender, EventArgs e)
        {
            this.price = 200;
            this.control = 42;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_17;
            Block(control);
        }

        private void question_button_43_Click(object sender, EventArgs e)
        {
            this.price = 300;
            this.control = 43;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_18;
            Block(control);
        }

        private void question_button_44_Click(object sender, EventArgs e)
        {
            this.price = 400;
            this.control = 44;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_19;
            Block(control);
        }

        private void question_button_45_Click(object sender, EventArgs e)
        {
            this.price = 500;
            this.control = 45;
            ShowTeams(numberOfTeams);
            SetScore1();
            panel_question.Visible = true;
            question_label.Text = question_20;
            Block(control);
        }

        private void question_panel_team1_lose_Click(object sender, EventArgs e)
        {
            score1 -= price;
            SetScore1();
        }

        private void question_panel_team2_lose_Click(object sender, EventArgs e)
        {
            score2 -= price;
            SetScore1();
        }

        private void question_panel_team3_lose_Click(object sender, EventArgs e)
        {
            score3 -= price;
            SetScore1();
        }

        private void question_panel_team4_lose_Click(object sender, EventArgs e)
        {
            score4 -= price;
            SetScore1();
        }

        private void question_panel_team5_lose_Click(object sender, EventArgs e)
        {
            score5 -= price;
            SetScore1();
        }

        private void question_panel_team1_win_Click(object sender, EventArgs e)
        {
            score1 += price;
            SetScore1();
            panel_question.Visible = false;
        }

        private void question_panel_team2_win_Click(object sender, EventArgs e)
        {
            score2 += price;
            SetScore1();
            panel_question.Visible = false;
        }

        private void question_panel_team3_win_Click(object sender, EventArgs e)
        {
            score3 += price;
            SetScore1();
            panel_question.Visible = false;
        }

        private void question_panel_team4_win_Click(object sender, EventArgs e)
        {
            score4 += price;
            SetScore1();
            panel_question.Visible = false;
        }

        private void question_panel_team5_win_Click(object sender, EventArgs e)
        {
            score5 += price;
            SetScore1();
            panel_question.Visible = false;
        }
    }
}
