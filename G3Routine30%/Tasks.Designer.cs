namespace G3Routine30_
{
    partial class Tasks
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
            label1 = new Label();
            tasksFlowLayoutPanel = new FlowLayoutPanel();
            NewTaskButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 45);
            label1.TabIndex = 0;
            label1.Text = "Tasks";
            // 
            // tasksFlowLayoutPanel
            // 
            tasksFlowLayoutPanel.AutoScroll = true;
            tasksFlowLayoutPanel.BackColor = Color.Pink;
            tasksFlowLayoutPanel.Location = new Point(12, 57);
            tasksFlowLayoutPanel.Name = "tasksFlowLayoutPanel";
            tasksFlowLayoutPanel.Size = new Size(1900, 892);
            tasksFlowLayoutPanel.TabIndex = 1;
            tasksFlowLayoutPanel.Paint += tasksFlowLayoutPanel_Paint;
            // 
            // NewTaskButton
            // 
            NewTaskButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NewTaskButton.BackColor = Color.LightPink;
            NewTaskButton.FlatAppearance.BorderSize = 0;
            NewTaskButton.FlatStyle = FlatStyle.Flat;
            NewTaskButton.Location = new Point(1714, 12);
            NewTaskButton.Name = "NewTaskButton";
            NewTaskButton.Size = new Size(198, 39);
            NewTaskButton.TabIndex = 2;
            NewTaskButton.Text = "New Task";
            NewTaskButton.UseVisualStyleBackColor = false;
            NewTaskButton.Click += NewTaskButton_Click;
            // 
            // Tasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1924, 961);
            Controls.Add(NewTaskButton);
            Controls.Add(tasksFlowLayoutPanel);
            Controls.Add(label1);
            Name = "Tasks";
            Text = "Tasks";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel tasksFlowLayoutPanel;
        private Button NewTaskButton;
    }
}