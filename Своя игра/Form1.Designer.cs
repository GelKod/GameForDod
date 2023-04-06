using System.Configuration;

namespace Своя_игра
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            menu_team1_name = new TextBox();
            menu_team1_buttonAdd = new Button();
            menu_team1_buttonDel = new Button();
            menu_team2_buttonDel = new Button();
            menu_team2_buttonAdd = new Button();
            menu_team2_name = new TextBox();
            menu_team4_buttonDel = new Button();
            menu_team4_buttonAdd = new Button();
            menu_team4_name = new TextBox();
            menu_team3_buttonDel = new Button();
            menu_team3_buttonAdd = new Button();
            menu_team3_name = new TextBox();
            menu_team5_buttonDel = new Button();
            menu_team5_buttonAdd = new Button();
            menu_team5_name = new TextBox();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Tahoma", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 50, 0, 0);
            label1.Size = new Size(1258, 165);
            label1.TabIndex = 0;
            label1.Text = "Меню";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.Dock = DockStyle.Left;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Gold;
            button3.Location = new Point(0, 0);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(119, 379);
            button3.TabIndex = 11;
            button3.Text = "СТАРТ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.Dock = DockStyle.Right;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Gold;
            button4.Location = new Point(81, 0);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(119, 379);
            button4.TabIndex = 13;
            button4.Text = "ВЫХОД";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 165);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 379);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1058, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 379);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(200, 444);
            panel3.Name = "panel3";
            panel3.Size = new Size(858, 100);
            panel3.TabIndex = 16;
            // 
            // menu_team1_name
            // 
            menu_team1_name.BackColor = Color.Blue;
            menu_team1_name.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            menu_team1_name.ForeColor = Color.Gold;
            menu_team1_name.Location = new Point(67, 18);
            menu_team1_name.Name = "menu_team1_name";
            menu_team1_name.Size = new Size(132, 26);
            menu_team1_name.TabIndex = 17;
            // 
            // menu_team1_buttonAdd
            // 
            menu_team1_buttonAdd.Location = new Point(204, 21);
            menu_team1_buttonAdd.Margin = new Padding(2);
            menu_team1_buttonAdd.Name = "menu_team1_buttonAdd";
            menu_team1_buttonAdd.Size = new Size(24, 20);
            menu_team1_buttonAdd.TabIndex = 18;
            menu_team1_buttonAdd.Text = "+";
            menu_team1_buttonAdd.UseVisualStyleBackColor = true;
            menu_team1_buttonAdd.Click += menu_team1_buttonAdd_Click;
            // 
            // menu_team1_buttonDel
            // 
            menu_team1_buttonDel.Location = new Point(38, 20);
            menu_team1_buttonDel.Margin = new Padding(2);
            menu_team1_buttonDel.Name = "menu_team1_buttonDel";
            menu_team1_buttonDel.Size = new Size(24, 20);
            menu_team1_buttonDel.TabIndex = 19;
            menu_team1_buttonDel.Text = "-";
            menu_team1_buttonDel.UseVisualStyleBackColor = true;
            menu_team1_buttonDel.Visible = false;
            menu_team1_buttonDel.Click += menu_team1_buttonDel_Click;
            // 
            // menu_team2_buttonDel
            // 
            menu_team2_buttonDel.Location = new Point(38, 52);
            menu_team2_buttonDel.Margin = new Padding(2);
            menu_team2_buttonDel.Name = "menu_team2_buttonDel";
            menu_team2_buttonDel.Size = new Size(24, 20);
            menu_team2_buttonDel.TabIndex = 22;
            menu_team2_buttonDel.Text = "-";
            menu_team2_buttonDel.UseVisualStyleBackColor = true;
            menu_team2_buttonDel.Visible = false;
            menu_team2_buttonDel.Click += menu_team2_buttonDel_Click;
            // 
            // menu_team2_buttonAdd
            // 
            menu_team2_buttonAdd.Location = new Point(204, 53);
            menu_team2_buttonAdd.Margin = new Padding(2);
            menu_team2_buttonAdd.Name = "menu_team2_buttonAdd";
            menu_team2_buttonAdd.Size = new Size(24, 20);
            menu_team2_buttonAdd.TabIndex = 21;
            menu_team2_buttonAdd.Text = "+";
            menu_team2_buttonAdd.UseVisualStyleBackColor = true;
            menu_team2_buttonAdd.Visible = false;
            menu_team2_buttonAdd.Click += menu_team2_buttonAdd_Click;
            // 
            // menu_team2_name
            // 
            menu_team2_name.BackColor = Color.Blue;
            menu_team2_name.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            menu_team2_name.ForeColor = Color.Gold;
            menu_team2_name.Location = new Point(67, 50);
            menu_team2_name.Name = "menu_team2_name";
            menu_team2_name.Size = new Size(132, 26);
            menu_team2_name.TabIndex = 20;
            menu_team2_name.Visible = false;
            // 
            // menu_team4_buttonDel
            // 
            menu_team4_buttonDel.Location = new Point(38, 116);
            menu_team4_buttonDel.Margin = new Padding(2);
            menu_team4_buttonDel.Name = "menu_team4_buttonDel";
            menu_team4_buttonDel.Size = new Size(24, 20);
            menu_team4_buttonDel.TabIndex = 28;
            menu_team4_buttonDel.Text = "-";
            menu_team4_buttonDel.UseVisualStyleBackColor = true;
            menu_team4_buttonDel.Visible = false;
            menu_team4_buttonDel.Click += menu_team4_buttonDel_Click;
            // 
            // menu_team4_buttonAdd
            // 
            menu_team4_buttonAdd.Location = new Point(204, 117);
            menu_team4_buttonAdd.Margin = new Padding(2);
            menu_team4_buttonAdd.Name = "menu_team4_buttonAdd";
            menu_team4_buttonAdd.Size = new Size(24, 20);
            menu_team4_buttonAdd.TabIndex = 27;
            menu_team4_buttonAdd.Text = "+";
            menu_team4_buttonAdd.UseVisualStyleBackColor = true;
            menu_team4_buttonAdd.Visible = false;
            menu_team4_buttonAdd.Click += menu_team4_buttonAdd_Click;
            // 
            // menu_team4_name
            // 
            menu_team4_name.BackColor = Color.Blue;
            menu_team4_name.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            menu_team4_name.ForeColor = Color.Gold;
            menu_team4_name.Location = new Point(67, 114);
            menu_team4_name.Name = "menu_team4_name";
            menu_team4_name.Size = new Size(132, 26);
            menu_team4_name.TabIndex = 26;
            menu_team4_name.Visible = false;
            // 
            // menu_team3_buttonDel
            // 
            menu_team3_buttonDel.Location = new Point(38, 84);
            menu_team3_buttonDel.Margin = new Padding(2);
            menu_team3_buttonDel.Name = "menu_team3_buttonDel";
            menu_team3_buttonDel.Size = new Size(24, 20);
            menu_team3_buttonDel.TabIndex = 25;
            menu_team3_buttonDel.Text = "-";
            menu_team3_buttonDel.UseVisualStyleBackColor = true;
            menu_team3_buttonDel.Visible = false;
            menu_team3_buttonDel.Click += menu_team3_buttonDel_Click;
            // 
            // menu_team3_buttonAdd
            // 
            menu_team3_buttonAdd.Location = new Point(204, 85);
            menu_team3_buttonAdd.Margin = new Padding(2);
            menu_team3_buttonAdd.Name = "menu_team3_buttonAdd";
            menu_team3_buttonAdd.Size = new Size(24, 20);
            menu_team3_buttonAdd.TabIndex = 24;
            menu_team3_buttonAdd.Text = "+";
            menu_team3_buttonAdd.UseVisualStyleBackColor = true;
            menu_team3_buttonAdd.Visible = false;
            menu_team3_buttonAdd.Click += menu_team3_buttonAdd_Click;
            // 
            // menu_team3_name
            // 
            menu_team3_name.BackColor = Color.Blue;
            menu_team3_name.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            menu_team3_name.ForeColor = Color.Gold;
            menu_team3_name.Location = new Point(67, 82);
            menu_team3_name.Name = "menu_team3_name";
            menu_team3_name.Size = new Size(132, 26);
            menu_team3_name.TabIndex = 23;
            menu_team3_name.Visible = false;
            // 
            // menu_team5_buttonDel
            // 
            menu_team5_buttonDel.Location = new Point(38, 148);
            menu_team5_buttonDel.Margin = new Padding(2);
            menu_team5_buttonDel.Name = "menu_team5_buttonDel";
            menu_team5_buttonDel.Size = new Size(24, 20);
            menu_team5_buttonDel.TabIndex = 31;
            menu_team5_buttonDel.Text = "-";
            menu_team5_buttonDel.UseVisualStyleBackColor = true;
            menu_team5_buttonDel.Visible = false;
            menu_team5_buttonDel.Click += menu_team5_buttonDel_Click;
            // 
            // menu_team5_buttonAdd
            // 
            menu_team5_buttonAdd.Location = new Point(204, 149);
            menu_team5_buttonAdd.Margin = new Padding(2);
            menu_team5_buttonAdd.Name = "menu_team5_buttonAdd";
            menu_team5_buttonAdd.Size = new Size(24, 20);
            menu_team5_buttonAdd.TabIndex = 30;
            menu_team5_buttonAdd.Text = "+";
            menu_team5_buttonAdd.UseVisualStyleBackColor = true;
            menu_team5_buttonAdd.Visible = false;
            menu_team5_buttonAdd.Click += menu_team5_buttonAdd_Click;
            // 
            // menu_team5_name
            // 
            menu_team5_name.BackColor = Color.Blue;
            menu_team5_name.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            menu_team5_name.ForeColor = Color.Gold;
            menu_team5_name.Location = new Point(67, 146);
            menu_team5_name.Name = "menu_team5_name";
            menu_team5_name.Size = new Size(132, 26);
            menu_team5_name.TabIndex = 29;
            menu_team5_name.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(menu_team5_buttonAdd);
            panel4.Controls.Add(menu_team5_buttonDel);
            panel4.Controls.Add(menu_team1_name);
            panel4.Controls.Add(menu_team1_buttonAdd);
            panel4.Controls.Add(menu_team5_name);
            panel4.Controls.Add(menu_team1_buttonDel);
            panel4.Controls.Add(menu_team4_buttonDel);
            panel4.Controls.Add(menu_team2_name);
            panel4.Controls.Add(menu_team4_buttonAdd);
            panel4.Controls.Add(menu_team2_buttonAdd);
            panel4.Controls.Add(menu_team4_name);
            panel4.Controls.Add(menu_team2_buttonDel);
            panel4.Controls.Add(menu_team3_buttonDel);
            panel4.Controls.Add(menu_team3_name);
            panel4.Controls.Add(menu_team3_buttonAdd);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(200, 165);
            panel4.Name = "panel4";
            panel4.Size = new Size(858, 279);
            panel4.TabIndex = 32;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1258, 544);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(2);
            MinimumSize = new Size(897, 411);
            Name = "Form1";
            Text = "Своя игра";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox menu_team1_name;
        private Button menu_team1_buttonAdd;
        private Button menu_team1_buttonDel;
        private Button menu_team2_buttonDel;
        private Button menu_team2_buttonAdd;
        private TextBox menu_team2_name;
        private Button menu_team4_buttonDel;
        private Button menu_team4_buttonAdd;
        private TextBox menu_team4_name;
        private Button menu_team3_buttonDel;
        private Button menu_team3_buttonAdd;
        private TextBox menu_team3_name;
        private Button menu_team5_buttonDel;
        private Button menu_team5_buttonAdd;
        private TextBox menu_team5_name;
        private Panel panel4;
    }
}