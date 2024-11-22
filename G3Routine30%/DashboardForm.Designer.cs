namespace G3Routine30_
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            sidebarPanel = new Panel();
            panel2 = new Panel();
            ProgressButton = new Button();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            btnSettings = new Button();
            TasksButton = new Button();
            btnProfile = new Button();
            panel1 = new Panel();
            label2 = new Label();
            WelcomeLabel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            sidebarPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.PeachPuff;
            sidebarPanel.Controls.Add(panel2);
            sidebarPanel.Controls.Add(panel1);
            sidebarPanel.Controls.Add(label1);
            sidebarPanel.Controls.Add(pictureBox1);
            sidebarPanel.Location = new Point(0, -1);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(1023, 768);
            sidebarPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ProgressButton);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(btnSettings);
            panel2.Controls.Add(TasksButton);
            panel2.Controls.Add(btnProfile);
            panel2.Location = new Point(778, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 768);
            panel2.TabIndex = 9;
            // 
            // ProgressButton
            // 
            ProgressButton.FlatAppearance.BorderSize = 0;
            ProgressButton.FlatStyle = FlatStyle.Flat;
            ProgressButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProgressButton.Location = new Point(0, 106);
            ProgressButton.Name = "ProgressButton";
            ProgressButton.Size = new Size(245, 41);
            ProgressButton.TabIndex = 6;
            ProgressButton.Text = "Progress";
            ProgressButton.UseVisualStyleBackColor = true;
            ProgressButton.Click += ProgressButton_Click_1;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 153);
            button3.Name = "button3";
            button3.Size = new Size(245, 41);
            button3.TabIndex = 7;
            button3.Text = "Statistics";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 53);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackgroundImage = (Image)resources.GetObject("btnSettings.BackgroundImage");
            btnSettings.BackgroundImageLayout = ImageLayout.Stretch;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Location = new Point(190, 0);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(55, 53);
            btnSettings.TabIndex = 3;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // TasksButton
            // 
            TasksButton.FlatAppearance.BorderSize = 0;
            TasksButton.FlatStyle = FlatStyle.Flat;
            TasksButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TasksButton.Location = new Point(0, 59);
            TasksButton.Name = "TasksButton";
            TasksButton.Size = new Size(245, 41);
            TasksButton.TabIndex = 5;
            TasksButton.Text = "Tasks";
            TasksButton.UseVisualStyleBackColor = true;
            TasksButton.Click += TasksButton_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.White;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            btnProfile.ImageAlign = ContentAlignment.BottomLeft;
            btnProfile.Location = new Point(0, 0);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(245, 53);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "      Profile";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(WelcomeLabel);
            panel1.Location = new Point(9, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 160);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 71);
            label2.Name = "label2";
            label2.Size = new Size(414, 50);
            label2.TabIndex = 1;
            label2.Text = "Let’s get organized and make today productive. \r\nReady to tackle your tasks?";
            label2.Click += label2_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 24F);
            WelcomeLabel.Location = new Point(19, 15);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(237, 45);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome back!";
            WelcomeLabel.Click += label2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 42F, FontStyle.Bold);
            label1.Location = new Point(97, 17);
            label1.Name = "label1";
            label1.Size = new Size(266, 74);
            label1.TabIndex = 1;
            label1.Text = "ROUTINE";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Snow;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1024, 768);
            Controls.Add(sidebarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarPanel;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox3;
        private Button btnProfile;
        private Button btnSettings;
        private Button button3;
        private Button ProgressButton;
        private Button TasksButton;
        private Panel panel2;
        private Panel panel1;
        private Label WelcomeLabel;
        private Label label2;
    }
}