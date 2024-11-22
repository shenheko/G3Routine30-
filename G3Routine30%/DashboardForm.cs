using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.ApplicationServices;

namespace G3Routine30_
{

    public partial class DashboardForm : Form
    {

        private TasksDatabaseHelper tasksDbHelper;
        DatabaseHelper dbHelper = new DatabaseHelper();

        private string connectionString = @"Data Source=C:\Users\xzarr\source\repos\G3Routine30%\G3Routine30%\bin\Debug\net8.0-windows\users.db;Version=3;";
        private int currentUserId;
        public DashboardForm(int userId)
        {
            InitializeComponent();
            tasksDbHelper = new TasksDatabaseHelper(@"Data Source=C:\Users\xzarr\source\repos\G3Routine30%\G3Routine30%\bin\Debug\net8.0-windows\users.db;Version=3;");
            currentUserId = userId;
        }

        private void NewTaskButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void HighlightActiveTab(Button activeButton)
        {
            foreach (Control control in sidebarPanel.Controls)
            {
                if (control is Button) // Check if the control is a Button
                {
                    Button btn = (Button)control; // Explicit cast
                    btn.BackColor = Color.PeachPuff;
                }
            }

            // Highlight the active button
            activeButton.BackColor = Color.BurlyWood;  // Change color when active
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ProgressButton_Click_1(object sender, EventArgs e)
        {
            Progress progress = new Progress(currentUserId);
            progress.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TasksButton_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks(currentUserId);
            tasks.Show();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }

}