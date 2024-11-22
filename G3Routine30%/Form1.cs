using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace G3Routine30_
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=C:\Users\xzarr\source\repos\G3Routine30%\G3Routine30%\bin\Debug\net8.0-windows\users.db;Version=3;";
        private Dictionary<string, string> userData = new Dictionary<string, string>(); // You can remove this if not needed.

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(Form1_Load);
            this.ClientSize = new Size(900, 600);
            this.LogInButton = new System.Windows.Forms.Button();
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            InitializeDatabase();

            // Removed hardcoded userData if it's not necessary.
            // userData.Add("admin", "password123");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            AdjustPanelLayout();
            StyleTextBoxes();
            StyleButtons();
        }

        private void StyleTextBoxes()
        {
            // UsernameTextBox
            UsernameTextBox.BackColor = Color.LightGray;
            UsernameTextBox.ForeColor = Color.Gray;
            UsernameTextBox.Font = new Font("Arial", 10);
            UsernameTextBox.BorderStyle = BorderStyle.None;
            UsernameTextBox.Padding = new Padding(10, 5, 10, 5);
            UsernameTextBox.Text = "Username";

            UsernameTextBox.GotFocus += (s, e) =>
            {
                if (UsernameTextBox.Text == "Username")
                {
                    UsernameTextBox.Text = "";
                    UsernameTextBox.ForeColor = Color.Black;
                }
            };

            UsernameTextBox.LostFocus += (s, e) =>
            {
                if (UsernameTextBox.Text == "")
                {
                    UsernameTextBox.Text = "Username";
                    UsernameTextBox.ForeColor = Color.Gray;
                }
            };

            // PasswordTextBox (Fix visibility issue)
            PasswordTextBox.BackColor = Color.LightGray;
            PasswordTextBox.ForeColor = Color.Gray;
            PasswordTextBox.Font = new Font("Arial", 10);
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Padding = new Padding(10, 5, 10, 5);
            PasswordTextBox.Text = "Password";
            PasswordTextBox.PasswordChar = '*';  // Set password character for hidden text

            PasswordTextBox.GotFocus += (s, e) =>
            {
                if (PasswordTextBox.Text == "Password")
                {
                    PasswordTextBox.Text = "";
                    PasswordTextBox.ForeColor = Color.Black;
                }
            };

            PasswordTextBox.LostFocus += (s, e) =>
            {
                if (PasswordTextBox.Text == "")
                {
                    PasswordTextBox.Text = "Password";
                    PasswordTextBox.ForeColor = Color.Gray;
                }
            };
        }

        private void AdjustPanelLayout()
        {
            int panelWidth = panel1.ClientSize.Width / 2;
            int panelHeight = panel1.ClientSize.Height;

            panel2.Size = new Size(panelWidth, panelHeight);
            panel2.Location = new Point(0, 0);

            panel3.Size = new Size(panelWidth, panelHeight);
            panel3.Location = new Point(panelWidth, 0);
        }

        private int currentUserId;
        private bool ValidateLogin(string username, string password)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ID, Password FROM Users WHERE Username = @username";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["Password"].ToString() == password)
                            {
                                currentUserId = Convert.ToInt32(reader["ID"]); // Store the UserID
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private void OpenDashboard()
        {
            DashboardForm dashboard = new DashboardForm(currentUserId); // Pass the UserID to the dashboard
            dashboard.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void ForgotPasswordLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Forgot Password clicked!");
        }

        private void StyleButtons()
        {
            StyleButton(LogInButton, Color.Pink, Color.Black, "Log In");
            StyleButton(SignUpButton, Color.Transparent, Color.Black, "Sign Up");
        }

        private void StyleButton(Button button, Color bgColor, Color textColor, string buttonText)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.BorderColor = Color.Black;
            button.BackColor = bgColor;
            button.ForeColor = textColor;
            button.Text = buttonText;
            button.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            if (ValidateLogin(username, password))
            {
                OpenDashboard();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeDatabase()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string createUsersTableQuery = @"
                CREATE TABLE IF NOT EXISTS Users (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT UNIQUE,
                    Email TEXT,
                    Password TEXT
                );";
                using (var cmd = new SQLiteCommand(createUsersTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                string createTasksTableQuery = @"
                CREATE TABLE IF NOT EXISTS Tasks (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    TaskName TEXT,
                    Category TEXT,
                    Deadline DATE,
                    UserID INTEGER,
                    FOREIGN KEY (UserID) REFERENCES Users(ID)
                );";
                using (var cmd = new SQLiteCommand(createTasksTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }



    }
}
