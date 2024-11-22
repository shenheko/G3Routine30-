using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G3Routine30_
{
    public partial class AddPlanFormM : Form
    {
        private int currentUserId;

        public AddPlanFormM(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void AddPlanForm_Load(object sender, EventArgs e)
        {
            PopulatePlansComboBox();
        }

        private void PopulatePlansComboBox()
        {
            Progress progress = new Progress(currentUserId);
            var plans = progress.GetPlansForUser(currentUserId); // Fetch plans for the logged-in user

            selectPlanComboBox.Items.Clear();

            foreach (var plan in plans)
            {
                selectPlanComboBox.Items.Add(new PlanComboBoxItem
                {
                    Text = plan.PlanName,
                    Value = plan.PlanId
                });
            }

            selectPlanComboBox.DisplayMember = "Text";
            selectPlanComboBox.ValueMember = "Value";
        }

        private void addPlanButton_Click(object sender, EventArgs e)
        {
            string planName = planNameTextBox.Text;
            DateTime deadline = planDeadlineDateTimePicker.Value;

            if (string.IsNullOrWhiteSpace(planName))
            {
                MessageBox.Show("Please provide a name for the plan.", "Error");
                return;
            }

            // Add the plan to the database
            Progress progress = new Progress(currentUserId);
            progress.AddPlan(planName, deadline, currentUserId);

            // Optionally refresh the ComboBox
            PopulatePlansComboBox();

            // Clear inputs
            planNameTextBox.Clear();
            planDeadlineDateTimePicker.Value = DateTime.Now;
        }

        private void addSubtaskButton_Click(object sender, EventArgs e)
        {
            string subtaskName = subtaskNameTextBox.Text;
            string priority = priorityComboBox.SelectedItem?.ToString();
            int planId = GetSelectedPlanId();

            if (string.IsNullOrWhiteSpace(subtaskName) || string.IsNullOrWhiteSpace(priority) || planId == 0)
            {
                MessageBox.Show("Please fill in all fields before adding a subtask.", "Error");
                return;
            }

            // Save the subtask to the database
            Progress progress = new Progress(currentUserId);
            progress.AddSubtask(planId, subtaskName, priority);

            // Clear inputs
            subtaskNameTextBox.Clear();
            priorityComboBox.SelectedIndex = -1;
        }

        private int GetSelectedPlanId()
        {
            if (selectPlanComboBox.SelectedItem is PlanComboBoxItem selectedItem)
            {
                return selectedItem.Value;
            }

            return 0; // No plan selected
        }
    }

    // Strongly-typed class for ComboBox items
    public class PlanComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString() => Text; // For display purposes
    }
}