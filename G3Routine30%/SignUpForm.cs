using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;

namespace G3Routine30_
{
    public partial class SignUpForm : Form
    {

        public SignUpForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new EventHandler(SignUpForm_Load);

            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            UsernameTextBox.Clear();
            EmailTextBox.Clear();
            PasswordTextBox.Clear();
            ConfirmPasswordTextBox.Clear();
            TermsAndConditionsCheckBox.Checked = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;

            // Validate fields
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm Password Validation
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Terms and Conditions Validation
            if (!TermsAndConditionsCheckBox.Checked)
            {
                MessageBox.Show("You must agree to the Terms and Conditions to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the user already exists
            if (UserExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save user to database
            SaveUser(username, email, password);

            MessageBox.Show("Sign Up successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private bool UserExists(string username)
        {
            using (var conn = new SQLiteConnection("Data Source=users.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    var result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result) > 0;
                }
            }
        }

        private void SaveUser(string username, string email, string password)
        {
            using (var conn = new SQLiteConnection("Data Source=users.db;Version=3;"))
            {
                conn.Open();
                string query = "INSERT INTO Users (Username, Email, Password) VALUES (@username, @email, @password)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filePath = @"C:\Users\xzarr\source\repos\G3Routine30%\G3Routine30%\Terms.txt";
            System.Diagnostics.Process.Start("notepad.exe", filePath);
        }
    }
}
