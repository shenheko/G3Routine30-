using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G3Routine30_
{
    public partial class Tasks : Form
    {
        private int currentUserId;
        public Tasks(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadTasks();
        }

        public void LoadTasks()
        {
            tasksFlowLayoutPanel.Controls.Clear(); // Clear existing tasks

            using (var conn = new SQLiteConnection(@"Data Source=C:\Users\xzarr\source\repos\G3Routine30%\G3Routine30%\bin\Debug\net8.0-windows\users.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT id, TaskName, Category, Deadline, Completed FROM Tasks WHERE UserID = @userID";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", currentUserId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int taskId = Convert.ToInt32(reader["id"]);
                            string taskName = reader["TaskName"].ToString();
                            string category = reader["Category"].ToString();
                            DateTime deadline = Convert.ToDateTime(reader["Deadline"]);
                            bool isCompleted = Convert.ToBoolean(reader["Completed"]);

                            // Calculate remaining time
                            TimeSpan timeRemaining = deadline - DateTime.Now;
                            string timeRemainingText = GetTimeRemainingText(timeRemaining);

                            // Create a panel for each task
                            Panel taskPanel = new Panel
                            {
                                Width = tasksFlowLayoutPanel.Width - 20, // Adjust for margins
                                Height = 150, // Increased height to fit everything properly
                                Margin = new Padding(10), // More spacing between tasks
                                BorderStyle = BorderStyle.None, // No border
                                BackColor = isCompleted ? Color.LightGreen : Color.LightBlue, // Change color if completed
                                Padding = new Padding(10) // Padding inside each task panel
                            };

                            // Task Name Label
                            Label taskNameLabel = new Label
                            {
                                Text = taskName,
                                AutoSize = true,
                                Font = new Font("Segoe UI", 14, FontStyle.Bold), // More modern font and size
                                Location = new Point(10, 10)
                            };
                            taskPanel.Controls.Add(taskNameLabel);

                            // Category Label
                            Label categoryLabel = new Label
                            {
                                Text = "Category: " + category,
                                AutoSize = true,
                                Location = new Point(10, 40),
                                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                                ForeColor = Color.DarkSlateGray // Color for better contrast
                            };
                            taskPanel.Controls.Add(categoryLabel);

                            // Deadline Label
                            Label deadlineLabel = new Label
                            {
                                Text = "Deadline: " + deadline.ToString("MM/dd/yyyy"),
                                AutoSize = true,
                                Location = new Point(10, 70),
                                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                                ForeColor = Color.DarkSlateGray
                            };
                            taskPanel.Controls.Add(deadlineLabel);

                            // Time Remaining Label
                            Label timeRemainingLabel = new Label
                            {
                                Text = "Time Left: " + timeRemainingText,
                                AutoSize = true,
                                Location = new Point(10, 90),
                                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                                ForeColor = Color.Red // You can adjust the color for emphasis
                            };
                            taskPanel.Controls.Add(timeRemainingLabel);

                            // Complete Button
                            Button completeButton = new Button
                            {
                                Text = "Complete",
                                Width = 80,
                                Height = 30,
                                Location = new Point(10, 120), // Position the button properly at the bottom of the panel
                                BackColor = Color.LightGreen,
                                FlatStyle = FlatStyle.Flat
                            };
                            completeButton.Click += (sender, e) => MarkAsCompleted(taskId, taskPanel);
                            taskPanel.Controls.Add(completeButton);

                            // If the task is completed, hide the "Complete" button
                            if (isCompleted)
                            {
                                completeButton.Visible = false; // Hide the button for completed tasks
                            }

                            // Add the taskPanel to the FlowLayoutPanel
                            tasksFlowLayoutPanel.Controls.Add(taskPanel);
                        }
                    }
                }
            }
        }



        private void NewTaskButton_Click(object sender, EventArgs e)
        {
            // Check if the form is already open
            foreach (Form form in Application.OpenForms)
            {
                if (form is CreateTask)
                {
                    form.Focus();
                    return; // Exit if the form is already open
                }
            }

            // If the form is not open, create a new instance
            CreateTask createTaskForm = new CreateTask(currentUserId); // Pass currentUserId
            createTaskForm.TaskCreated -= CreateTaskForm_TaskCreated; // Unsubscribe if it's subscribed from a previous form instance
            createTaskForm.TaskCreated += CreateTaskForm_TaskCreated; // Subscribe to the event
            createTaskForm.Show();
        }

        private string GetTimeRemainingText(TimeSpan timeRemaining)
        {
            if (timeRemaining.TotalDays > 1)
                return $"{timeRemaining.Days} days remaining";
            if (timeRemaining.TotalDays > 0)
                return $"{timeRemaining.Hours} hours and {timeRemaining.Minutes} minutes remaining";
            if (timeRemaining.TotalMinutes > 0)
                return $"{timeRemaining.Minutes} minutes remaining";
            if (timeRemaining.TotalSeconds > 0)
                return $"{timeRemaining.Seconds} seconds remaining";

            // If deadline is passed (negative timeRemaining)
            TimeSpan lateBy = timeRemaining.Duration(); // Convert negative TimeSpan to positive duration
            if (lateBy.TotalDays > 1)
                return $"Late by {lateBy.Days} days";
            if (lateBy.TotalHours > 1)
                return $"Late by {lateBy.Hours} hours";
            if (lateBy.TotalMinutes > 1)
                return $"Late by {lateBy.Minutes} minutes";

            return "Deadline has passed";
        }

        private void MarkAsCompleted(int taskId, Panel taskPanel)
        {
            // Update the database to mark the task as completed
            using (var conn = new SQLiteConnection(@"Data Source=C:\Users\xzarr\source\repos\G3Routine30%\G3Routine30%\bin\Debug\net8.0-windows\users.db;Version=3;"))
            {
                conn.Open();
                string query = "UPDATE Tasks SET Completed = 1 WHERE id = @taskId"; // Mark task as completed
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@taskId", taskId);
                    cmd.ExecuteNonQuery();
                }
            }

            // Update the taskPanel to reflect the completion
            taskPanel.BackColor = Color.LightGreen; // Change color to indicate completion
            taskPanel.Controls.OfType<Button>().First().Visible = false; // Hide the "Complete" button
        }


        private void CreateTaskForm_TaskCreated()
        {
            // Refresh the tasks when a new task is created
            LoadTasks();
        }
        private void tasksFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
