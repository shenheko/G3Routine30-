namespace G3Routine30_
{
    partial class Progress
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
            addNewPlanButton = new Button();
            plansFlowLayoutPanel = new FlowLayoutPanel();
            planListView = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(387, 65);
            label1.TabIndex = 1;
            label1.Text = "Progress Tracker";
            // 
            // addNewPlanButton
            // 
            addNewPlanButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addNewPlanButton.Location = new Point(720, 65);
            addNewPlanButton.Name = "addNewPlanButton";
            addNewPlanButton.Size = new Size(283, 52);
            addNewPlanButton.TabIndex = 2;
            addNewPlanButton.Text = "Add New Plan";
            addNewPlanButton.UseVisualStyleBackColor = true;
            addNewPlanButton.Click += addNewPlanButton_Click;
            // 
            // plansFlowLayoutPanel
            // 
            plansFlowLayoutPanel.AutoScroll = true;
            plansFlowLayoutPanel.Location = new Point(12, 123);
            plansFlowLayoutPanel.Name = "plansFlowLayoutPanel";
            plansFlowLayoutPanel.Size = new Size(991, 926);
            plansFlowLayoutPanel.TabIndex = 3;
            // 
            // planListView
            // 
            planListView.Location = new Point(1036, 123);
            planListView.Name = "planListView";
            planListView.Size = new Size(862, 926);
            planListView.TabIndex = 4;
            planListView.UseCompatibleStateImageBehavior = false;
            planListView.SelectedIndexChanged += planListView_SelectedIndexChanged_1;
            // 
            // Progress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(planListView);
            Controls.Add(plansFlowLayoutPanel);
            Controls.Add(addNewPlanButton);
            Controls.Add(label1);
            Name = "Progress";
            Text = "Progress";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button addNewPlanButton;
        private FlowLayoutPanel plansFlowLayoutPanel;
        private ListView planListView;
    }
}