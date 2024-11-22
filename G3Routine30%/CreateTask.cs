using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G3Routine30_
{
    public partial class CreateTask : Form
    {
        private DashboardForm dashboard;
        private int currentUserId;
        private Tasks tasksForm;

        public event Action TaskCreated;
        // Add a constructor that accepts the userId
        public CreateTask(int userId)
        {
            InitializeComponent();
            currentUserId = userId; // Store the userId
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void SaveTaskButton_Click(object sender, EventArgs e)
        {
            string taskName = TaskNameTextBox.Text;
            string category = CategoryComboBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please select a category.");
                return; // Exit the method if no category is selected
            }

            DateTime deadline = DeadlinePicker.Value;

            // Insert task into the database
            using (var conn = new SQLiteConnection("Data Source=users.db;Version=3;"))
            {
                conn.Open();
                string query = "INSERT INTO Tasks (TaskName, Category, Deadline, UserID) VALUES (@taskName, @category, @deadline, @userID)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@taskName", taskName);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@deadline", deadline);
                    cmd.Parameters.AddWithValue("@userID", currentUserId); // Use the correct user ID
                    cmd.ExecuteNonQuery();
                }
            }

            // Close the CreateTask form after saving the task
            TaskCreated?.Invoke(); // Raise the event

            MessageBox.Show("Task added successfully!");
            TaskNameTextBox.Clear();
            CategoryComboBox.SelectedIndex = -1;

            this.Close();


        }



        private void CreateTask_Load(object sender, EventArgs e)
        {

        }
    }
}
