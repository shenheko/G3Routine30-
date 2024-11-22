namespace G3Routine30_
{
    partial class CreateTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTask));
            TaskNameTextBox = new TextBox();
            CategoryComboBox = new ComboBox();
            DeadlinePicker = new DateTimePicker();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            SaveTaskButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // TaskNameTextBox
            // 
            TaskNameTextBox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaskNameTextBox.Location = new Point(30, 89);
            TaskNameTextBox.Name = "TaskNameTextBox";
            TaskNameTextBox.PlaceholderText = "Add title";
            TaskNameTextBox.Size = new Size(507, 35);
            TaskNameTextBox.TabIndex = 0;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Items.AddRange(new object[] { "Work", "Study", "Gym", "Chores", "Important" });
            CategoryComboBox.Location = new Point(64, 145);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(288, 29);
            CategoryComboBox.TabIndex = 1;
            CategoryComboBox.Text = "Category";
            CategoryComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // DeadlinePicker
            // 
            DeadlinePicker.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeadlinePicker.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeadlinePicker.Location = new Point(64, 196);
            DeadlinePicker.Name = "DeadlinePicker";
            DeadlinePicker.Size = new Size(288, 29);
            DeadlinePicker.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(30, 196);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // SaveTaskButton
            // 
            SaveTaskButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveTaskButton.Location = new Point(413, 261);
            SaveTaskButton.Name = "SaveTaskButton";
            SaveTaskButton.Size = new Size(124, 42);
            SaveTaskButton.TabIndex = 5;
            SaveTaskButton.Text = "Save Task";
            SaveTaskButton.UseVisualStyleBackColor = true;
            SaveTaskButton.Click += SaveTaskButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 22);
            label1.Name = "label1";
            label1.Size = new Size(190, 45);
            label1.TabIndex = 6;
            label1.Text = "Create Task";
            label1.Click += label1_Click;
            // 
            // CreateTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(565, 327);
            Controls.Add(label1);
            Controls.Add(SaveTaskButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(DeadlinePicker);
            Controls.Add(CategoryComboBox);
            Controls.Add(TaskNameTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateTask";
            Text = "CreateTask";
            Load += CreateTask_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TaskNameTextBox;
        private ComboBox CategoryComboBox;
        private DateTimePicker DeadlinePicker;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button SaveTaskButton;
        private Label label1;
    }
}