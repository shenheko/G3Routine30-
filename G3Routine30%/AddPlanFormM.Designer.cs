namespace G3Routine30_
{
    partial class AddPlanFormM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addSubtaskButton = new Button();
            label6 = new Label();
            selectPlanComboBox = new ComboBox();
            label5 = new Label();
            priorityComboBox = new ComboBox();
            subtaskNameTextBox = new TextBox();
            label4 = new Label();
            planDeadlineDateTimePicker = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            planNameTextBox = new TextBox();
            addPlanButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // addSubtaskButton
            // 
            addSubtaskButton.Font = new Font("Segoe UI", 16F);
            addSubtaskButton.Location = new Point(566, 688);
            addSubtaskButton.Name = "addSubtaskButton";
            addSubtaskButton.Size = new Size(217, 48);
            addSubtaskButton.TabIndex = 24;
            addSubtaskButton.Text = "Add Subtask";
            addSubtaskButton.UseVisualStyleBackColor = true;
            addSubtaskButton.Click += addSubtaskButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(23, 578);
            label6.Name = "label6";
            label6.Size = new Size(274, 30);
            label6.TabIndex = 23;
            label6.Text = "Set to Already Existing Plan";
            // 
            // selectPlanComboBox
            // 
            selectPlanComboBox.Font = new Font("Segoe UI", 16F);
            selectPlanComboBox.FormattingEnabled = true;
            selectPlanComboBox.Location = new Point(23, 611);
            selectPlanComboBox.Name = "selectPlanComboBox";
            selectPlanComboBox.Size = new Size(760, 38);
            selectPlanComboBox.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(23, 489);
            label5.Name = "label5";
            label5.Size = new Size(119, 30);
            label5.TabIndex = 21;
            label5.Text = "Set Priority";
            // 
            // priorityComboBox
            // 
            priorityComboBox.Font = new Font("Segoe UI", 16F);
            priorityComboBox.FormattingEnabled = true;
            priorityComboBox.Items.AddRange(new object[] { "Low", "Medium", "High" });
            priorityComboBox.Location = new Point(23, 522);
            priorityComboBox.Name = "priorityComboBox";
            priorityComboBox.Size = new Size(760, 38);
            priorityComboBox.TabIndex = 20;
            // 
            // subtaskNameTextBox
            // 
            subtaskNameTextBox.Font = new Font("Segoe UI", 16F);
            subtaskNameTextBox.Location = new Point(23, 440);
            subtaskNameTextBox.Name = "subtaskNameTextBox";
            subtaskNameTextBox.PlaceholderText = "Enter subtask name";
            subtaskNameTextBox.Size = new Size(760, 36);
            subtaskNameTextBox.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(23, 407);
            label4.Name = "label4";
            label4.Size = new Size(157, 30);
            label4.TabIndex = 18;
            label4.Text = "Subtask Name:";
            // 
            // planDeadlineDateTimePicker
            // 
            planDeadlineDateTimePicker.Font = new Font("Segoe UI", 16F);
            planDeadlineDateTimePicker.Location = new Point(23, 241);
            planDeadlineDateTimePicker.Name = "planDeadlineDateTimePicker";
            planDeadlineDateTimePicker.Size = new Size(760, 36);
            planDeadlineDateTimePicker.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label3.Location = new Point(23, 198);
            label3.Name = "label3";
            label3.Size = new Size(107, 30);
            label3.TabIndex = 16;
            label3.Text = "Deadline:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label2.Location = new Point(23, 103);
            label2.Name = "label2";
            label2.Size = new Size(126, 30);
            label2.TabIndex = 15;
            label2.Text = "Plan Name:";
            // 
            // planNameTextBox
            // 
            planNameTextBox.Font = new Font("Segoe UI", 16F);
            planNameTextBox.Location = new Point(23, 145);
            planNameTextBox.Name = "planNameTextBox";
            planNameTextBox.PlaceholderText = "Enter plan name";
            planNameTextBox.Size = new Size(760, 36);
            planNameTextBox.TabIndex = 14;
            // 
            // addPlanButton
            // 
            addPlanButton.Font = new Font("Segoe UI", 16F);
            addPlanButton.Location = new Point(566, 314);
            addPlanButton.Name = "addPlanButton";
            addPlanButton.Size = new Size(217, 48);
            addPlanButton.TabIndex = 13;
            addPlanButton.Text = "Add New Plan";
            addPlanButton.UseVisualStyleBackColor = true;
            addPlanButton.Click += addPlanButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(187, 45);
            label1.TabIndex = 25;
            label1.Text = "Create Plan";
            // 
            // AddPlanFormM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 789);
            Controls.Add(label1);
            Controls.Add(addSubtaskButton);
            Controls.Add(label6);
            Controls.Add(selectPlanComboBox);
            Controls.Add(label5);
            Controls.Add(priorityComboBox);
            Controls.Add(subtaskNameTextBox);
            Controls.Add(label4);
            Controls.Add(planDeadlineDateTimePicker);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(planNameTextBox);
            Controls.Add(addPlanButton);
            Name = "AddPlanFormM";
            Text = "AddPlanFormM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addSubtaskButton;
        private Label label6;
        private ComboBox selectPlanComboBox;
        private Label label5;
        private ComboBox priorityComboBox;
        private TextBox subtaskNameTextBox;
        private Label label4;
        private DateTimePicker planDeadlineDateTimePicker;
        private Label label3;
        private Label label2;
        private TextBox planNameTextBox;
        private Button addPlanButton;
        private Label label1;
    }
}