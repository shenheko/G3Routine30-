using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G3Routine30_
{
    public partial class Progress : Form
    {


        private int currentUserId;
        public Progress(int userId)
        {
            InitializeComponent();
            this.Load += Progress_Load;
            currentUserId = userId;


        }

        private void Progress_Load(object sender, EventArgs e)
        {
            // Set up ListView columns
            planListView.View = View.Details;
            planListView.Columns.Add("Plan Name", 150); // Width in pixels
            planListView.Columns.Add("Deadline", 100); // Width in pixels
            planListView.Columns.Add("Time Left", 200);

            // Load plans into ListView (this will fill the ListView with data)
            LoadPlans();
            LoadPlansToListView();
        }

        public class Subtask
        {
            public string SubtaskName { get; set; }
            public string Priority { get; set; }
        }

        public class Plan
        {
            public int PlanId { get; set; }
            public string PlanName { get; set; }
            public DateTime Deadline { get; set; }
            public List<Subtask> Subtasks { get; set; }
        }

        private List<T> ExecuteQuery<T>(string query, Func<SQLiteDataReader, T> readerFunc, params SQLiteParameter[] parameters)
        {
            List<T> results = new List<T>();
            using (var conn = new SQLiteConnection(@"Data Source=C:\Users\xzarr\source\repos\G3Routine30%\G3Routine30%\bin\Debug\net8.0-windows\users.db;Version=3;"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(readerFunc(reader));
                        }
                    }
                }
            }
            return results;
        }

        public List<Plan> GetPlansForUser(int userId)
        {
            var plans = new List<Plan>();
            string query = "SELECT PlanId, PlanName, Deadline FROM Plans WHERE UserId = @UserId";

            using (var conn = new SQLiteConnection(@"Data Source=C:\Users\xzarr\source\repos\G3Routine30%\G3Routine30%\bin\Debug\net8.0-windows\users.db;Version=3;"))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var planId = reader.GetInt32(0);
                            var plan = new Plan
                            {
                                PlanId = planId,
                                PlanName = reader.GetString(1),
                                Deadline = reader.GetDateTime(2),
                                Subtasks = GetSubtasksForPlan(planId) // Fetch the subtasks here
                            };

                            plans.Add(plan);
                        }
                    }
                }
            }

            return plans;
        }



        private List<Subtask> GetSubtasksForPlan(int planId)
        {
            List<Subtask> subtasks = new List<Subtask>();

            using (var conn = new SQLiteConnection(@"Data Source=C:\Users\xzarr\source\repos\G3Routine30%\G3Routine30%\bin\Debug\net8.0-windows\users.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT SubtaskName, Priority FROM Subtasks WHERE PlanId = @PlanId";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PlanId", planId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subtasks.Add(new Subtask
                            {
                                SubtaskName = reader.GetString(0),
                                Priority = reader.GetString(1)
                            });
                        }
                    }
                }
            }

            return subtasks;
        }


        public void AddPlan(string planName, DateTime deadline, int userId)
        {
            using (var conn = new SQLiteConnection(@"Data Source=C:\Users\xzarr\source\repos\G3Routine30%\G3Routine30%\bin\Debug\net8.0-windows\users.db;Version=3;"))
            {
                conn.Open();
                string query = "INSERT INTO Plans (PlanName, Deadline, UserId) VALUES (@PlanName, @Deadline, @UserId)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PlanName", planName);
                    cmd.Parameters.AddWithValue("@Deadline", deadline);
                    cmd.Parameters.AddWithValue("@UserId", userId); // Dynamically set user ID
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadPlans()
        {
            plansFlowLayoutPanel.Controls.Clear(); // Clear existing controls

            // Get the plans with subtasks for the current user
            List<Plan> plans = GetPlansForUser(currentUserId);

            foreach (var plan in plans)
            {
                // Create a panel for each plan
                Panel planPanel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Width = plansFlowLayoutPanel.Width - 20,
                    Padding = new Padding(15),
                    Margin = new Padding(5),
                    BackColor = Color.LightSkyBlue, // Light background color
                    ForeColor = Color.Black, // Text color
                };

                // Add a label for the plan name
                Label planNameLabel = new Label
                {
                    Text = $"Plan: {plan.PlanName}",
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    AutoSize = true,
                    Dock = DockStyle.Top,
                    Margin = new Padding(0, 0, 0, 5),
                    ForeColor = Color.DarkSlateGray
                };
                planPanel.Controls.Add(planNameLabel);

                // Add a label for the deadline
                Label deadlineLabel = new Label
                {
                    Text = $"Deadline: {plan.Deadline.ToShortDateString()}",
                    Font = new Font("Arial", 12),
                    AutoSize = true,
                    Dock = DockStyle.Top,
                    Margin = new Padding(0, 5, 0, 5),
                    ForeColor = Color.DarkSlateGray
                };
                planPanel.Controls.Add(deadlineLabel);

                // Create a FlowLayoutPanel to hold the subtasks
                FlowLayoutPanel subtasksFlowLayout = new FlowLayoutPanel
                {
                    AutoSize = true,  // Allows dynamic resizing
                    Dock = DockStyle.Top,
                    Margin = new Padding(0, 5, 0, 5),
                };

                // Add subtasks if available
                if (plan.Subtasks.Count > 0)
                {
                    Label subtasksLabel = new Label
                    {
                        Text = "Subtasks:",
                        Font = new Font("Arial", 12, FontStyle.Underline),
                        AutoSize = true,
                        ForeColor = Color.DarkOrange
                    };
                    subtasksFlowLayout.Controls.Add(subtasksLabel);

                    // Loop through each subtask and add them to the flow panel
                    foreach (var subtask in plan.Subtasks)
                    {
                        Label subtaskLabel = new Label
                        {
                            Text = $"- {subtask.SubtaskName} (Priority: {subtask.Priority})",
                            Font = new Font("Arial", 11),
                            AutoSize = true,
                            ForeColor = Color.Black
                        };
                        subtasksFlowLayout.Controls.Add(subtaskLabel);
                    }
                }
                else
                {
                    Label noSubtasksLabel = new Label
                    {
                        Text = "No subtasks available.",
                        Font = new Font("Arial", 11, FontStyle.Italic),
                        AutoSize = true,
                        ForeColor = Color.Gray
                    };
                    subtasksFlowLayout.Controls.Add(noSubtasksLabel);
                }

                // Add the FlowLayoutPanel of subtasks to the main plan panel
                planPanel.Controls.Add(subtasksFlowLayout);

                // Add hover effect to the plan panel
                planPanel.MouseEnter += (sender, e) =>
                {
                    planPanel.BackColor = Color.LightGreen; // Change color on hover
                };
                planPanel.MouseLeave += (sender, e) =>
                {
                    planPanel.BackColor = Color.LightSkyBlue; // Revert back to original color
                };

                // Add the plan panel to the FlowLayoutPanel
                plansFlowLayoutPanel.Controls.Add(planPanel);
            }
        }

        private void LoadPlansToListView()
        {
            // Clear existing items
            planListView.Items.Clear();

            // Get all plans for the current user
            List<Plan> plans = GetPlansForUser(currentUserId);

            foreach (var plan in plans)
            {
                // Calculate time left
                TimeSpan timeLeft = plan.Deadline - DateTime.Now;
                string timeLeftString = timeLeft > TimeSpan.Zero
                    ? $"{timeLeft.Days} days, {timeLeft.Hours} hours, {timeLeft.Minutes} minutes left"
                    : "Deadline passed";

                // Create and add ListViewItem for each plan
                ListViewItem item = new ListViewItem(plan.PlanName);
                item.SubItems.Add(plan.Deadline.ToShortDateString());
                item.SubItems.Add(timeLeftString);
                item.Tag = plan;

                planListView.Items.Add(item);
            }
        }

        private void planListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (planListView.SelectedItems.Count > 0)
            {
                var selectedPlan = (Plan)planListView.SelectedItems[0].Tag;
                string planDetails = $"Plan Name: {selectedPlan.PlanName}\n" +
                                     $"Deadline: {selectedPlan.Deadline.ToShortDateString()}\n";

                // Calculate time left
                TimeSpan timeLeft = selectedPlan.Deadline - DateTime.Now;
                string timeLeftString = timeLeft > TimeSpan.Zero
                    ? $"{timeLeft.Days} days, {timeLeft.Hours} hours, {timeLeft.Minutes} minutes left"
                    : "Deadline passed";

                // Build subtasks details
                StringBuilder subtasksDetails = new StringBuilder("Subtasks:\n");

                foreach (var subtask in selectedPlan.Subtasks)
                {
                    subtasksDetails.AppendLine($"- {subtask.SubtaskName} (Priority: {subtask.Priority})");
                }

                // Show the plan details with subtasks and time left
                MessageBox.Show(planDetails + subtasksDetails.ToString() + $"\nTime Left: {timeLeftString}", "Plan Details");
            }
        }



        public void AddSubtask(int planId, string subtaskName, string priority)
        {
            using (var conn = new SQLiteConnection(@"Data Source=C:\Users\xzarr\source\repos\G3Routine30%\G3Routine30%\bin\Debug\net8.0-windows\users.db;Version=3;"))
            {
                conn.Open();
                string query = "INSERT INTO Subtasks (SubtaskName, Priority, PlanId) VALUES (@SubtaskName, @Priority, @PlanId)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SubtaskName", subtaskName);
                    cmd.Parameters.AddWithValue("@Priority", priority);
                    cmd.Parameters.AddWithValue("@PlanId", planId); // Associate subtask with the plan
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<(string PlanName, DateTime Deadline, List<(string Subtask, string Priority)>)> GetPlansWithSubtasks(int userId)
        {
            List<(string PlanName, DateTime Deadline, List<(string Subtask, string Priority)>)> plans = new List<(string, DateTime, List<(string, string)>)>();

            using (var conn = new SQLiteConnection(@"Data Source=C:\Users\xzarr\source\repos\G3Routine30%\G3Routine30%\bin\Debug\net8.0-windows\users.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT PlanId, PlanName, Deadline FROM Plans WHERE UserId = @UserId";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int planId = reader.GetInt32(0);
                            string planName = reader.GetString(1);
                            DateTime deadline = reader.GetDateTime(2);

                            // Now, get subtasks for the current plan
                            List<(string Subtask, string Priority)> subtasks = new List<(string, string)>();
                            string subtaskQuery = "SELECT SubtaskName, Priority FROM Subtasks WHERE PlanId = @PlanId";
                            using (var subtaskCmd = new SQLiteCommand(subtaskQuery, conn))
                            {
                                subtaskCmd.Parameters.AddWithValue("@PlanId", planId);
                                using (var subtaskReader = subtaskCmd.ExecuteReader())
                                {
                                    while (subtaskReader.Read())
                                    {
                                        subtasks.Add((subtaskReader.GetString(0), subtaskReader.GetString(1)));
                                    }
                                }
                            }

                            plans.Add((planName, deadline, subtasks));
                        }
                    }
                }
            }

            return plans;
        }


        private void LoadPlanDetailsToFlowLayoutPanel(Plan selectedPlan)
        {
            // Clear the FlowLayoutPanel to prepare for new content
            plansFlowLayoutPanel.Controls.Clear();

            // Add a label for the plan name
            Label planNameLabel = new Label
            {
                Text = $"Plan Name: {selectedPlan.PlanName}",
                AutoSize = true,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Margin = new Padding(10)
            };
            plansFlowLayoutPanel.Controls.Add(planNameLabel);

            // Add a label for the deadline
            Label deadlineLabel = new Label
            {
                Text = $"Deadline: {selectedPlan.Deadline.ToShortDateString()}",
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Regular),
                Margin = new Padding(10)
            };
            plansFlowLayoutPanel.Controls.Add(deadlineLabel);

            // Fetch and display subtasks for the selected plan
            List<Subtask> subtasks = GetSubtasksForPlan(selectedPlan.PlanId);
            if (subtasks.Count > 0)
            {
                Label subtasksHeader = new Label
                {
                    Text = "Subtasks:",
                    AutoSize = true,
                    Font = new Font("Arial", 11, FontStyle.Bold),
                    Margin = new Padding(10)
                };
                plansFlowLayoutPanel.Controls.Add(subtasksHeader);

                foreach (var subtask in subtasks)
                {
                    Label subtaskLabel = new Label
                    {
                        Text = $"- {subtask}",
                        AutoSize = true,
                        Margin = new Padding(20, 5, 10, 5)
                    };
                    plansFlowLayoutPanel.Controls.Add(subtaskLabel);
                }
            }
            else
            {
                Label noSubtasksLabel = new Label
                {
                    Text = "No subtasks for this plan.",
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Italic),
                    Margin = new Padding(10)
                };
                plansFlowLayoutPanel.Controls.Add(noSubtasksLabel);
            }
        }


        public void MarkSubtaskAsCompleted(int subtaskId)
        {
            using (var conn = new SQLiteConnection(@"Data Source=C:\Users\xzarr\source\repos\G3Routine30%\G3Routine30%\bin\Debug\net8.0-windows\users.db;Version=3;"))
            {
                conn.Open();
                string query = "UPDATE Subtasks SET IsCompleted = 1 WHERE SubtaskId = @SubtaskId";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SubtaskId", subtaskId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void addNewPlanButton_Click(object sender, EventArgs e)
        {
            AddPlanFormM addPlanForm = new AddPlanFormM(currentUserId);
            addPlanForm.ShowDialog(); // Opens the AddPlanForm
            LoadPlans(); // Refreshes the list of plans
        }

        private void planListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (planListView.SelectedItems.Count > 0)
            {
                var selectedPlan = (Plan)planListView.SelectedItems[0].Tag;
                LoadPlanDetailsToFlowLayoutPanel(selectedPlan);
            }
        }
    }
}
