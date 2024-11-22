namespace G3Routine30_
{
    partial class SignUpForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox UsernameTextBox;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
        private Button SignUpButton;
        private Button CancelButton;

        private void InitializeComponent()
        {
            UsernameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SignUpButton = new Button();
            CancelButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ConfirmPasswordTextBox = new TextBox();
            TermsAndConditionsCheckBox = new CheckBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(45, 104);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(285, 23);
            UsernameTextBox.TabIndex = 0;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(45, 160);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(285, 23);
            EmailTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(45, 218);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(285, 23);
            PasswordTextBox.TabIndex = 2;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.Pink;
            SignUpButton.FlatAppearance.BorderSize = 0;
            SignUpButton.FlatStyle = FlatStyle.Flat;
            SignUpButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpButton.Location = new Point(45, 357);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(285, 44);
            SignUpButton.TabIndex = 3;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Location = new Point(45, 407);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(285, 23);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 59);
            label1.TabIndex = 5;
            label1.Text = "Sign Up";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 80);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 136);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 194);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 253);
            label5.Name = "label5";
            label5.Size = new Size(137, 21);
            label5.TabIndex = 10;
            label5.Text = "Confirm Password";
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Location = new Point(45, 277);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.PasswordChar = '*';
            ConfirmPasswordTextBox.Size = new Size(285, 23);
            ConfirmPasswordTextBox.TabIndex = 9;
            // 
            // TermsAndConditionsCheckBox
            // 
            TermsAndConditionsCheckBox.AutoSize = true;
            TermsAndConditionsCheckBox.Font = new Font("Segoe UI", 12F);
            TermsAndConditionsCheckBox.Location = new Point(45, 317);
            TermsAndConditionsCheckBox.Name = "TermsAndConditionsCheckBox";
            TermsAndConditionsCheckBox.Size = new Size(79, 25);
            TermsAndConditionsCheckBox.TabIndex = 11;
            TermsAndConditionsCheckBox.Text = "Accept ";
            TermsAndConditionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(112, 318);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(160, 21);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Terms and Conditions";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // SignUpForm
            // 
            ClientSize = new Size(384, 461);
            Controls.Add(linkLabel1);
            Controls.Add(TermsAndConditionsCheckBox);
            Controls.Add(label5);
            Controls.Add(ConfirmPasswordTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UsernameTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(SignUpButton);
            Controls.Add(CancelButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUpForm";
            Text = "Sign Up Form";
            Load += SignUpForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ConfirmPasswordTextBox;
        private CheckBox TermsAndConditionsCheckBox;
        private LinkLabel linkLabel1;
    }
}
