namespace G3Routine30_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label DontHaveAccountLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ForgotPasswordLabel;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.Button ExitButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            ForgotPasswordLabel = new Label();
            LogInButton = new Button();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            UsernameTextBox = new TextBox();
            UsernameLabel = new Label();
            LogInLabel = new Label();
            ExitButton = new Button();
            panel3 = new Panel();
            SignUpButton = new Button();
            DontHaveAccountLabel = new Label();
            WelcomeLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(159, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 400);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ForgotPasswordLabel);
            panel2.Controls.Add(LogInButton);
            panel2.Controls.Add(PasswordTextBox);
            panel2.Controls.Add(PasswordLabel);
            panel2.Controls.Add(UsernameTextBox);
            panel2.Controls.Add(UsernameLabel);
            panel2.Controls.Add(LogInLabel);
            panel2.Controls.Add(ExitButton);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 400);
            panel2.TabIndex = 3;
            // 
            // ForgotPasswordLabel
            // 
            ForgotPasswordLabel.AutoSize = true;
            ForgotPasswordLabel.Location = new Point(25, 291);
            ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            ForgotPasswordLabel.Size = new Size(117, 17);
            ForgotPasswordLabel.TabIndex = 6;
            ForgotPasswordLabel.Text = "Forgot Password?";
            ForgotPasswordLabel.Click += ForgotPasswordLabel_Click;
            // 
            // LogInButton
            // 
            LogInButton.Location = new Point(25, 237);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(250, 40);
            LogInButton.TabIndex = 5;
            LogInButton.Text = "Log In";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(25, 195);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(250, 25);
            PasswordTextBox.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(25, 175);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(66, 17);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(25, 131);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(250, 25);
            UsernameTextBox.TabIndex = 2;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(25, 111);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(69, 17);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username";
            // 
            // LogInLabel
            // 
            LogInLabel.AutoSize = true;
            LogInLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LogInLabel.Location = new Point(25, 55);
            LogInLabel.Name = "LogInLabel";
            LogInLabel.Size = new Size(86, 32);
            LogInLabel.TabIndex = 0;
            LogInLabel.Text = "Log In";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(25, 350);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(250, 40);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PeachPuff;
            panel3.Controls.Add(SignUpButton);
            panel3.Controls.Add(DontHaveAccountLabel);
            panel3.Controls.Add(WelcomeLabel);
            panel3.Location = new Point(297, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(327, 400);
            panel3.TabIndex = 0;
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(100, 212);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(125, 40);
            SignUpButton.TabIndex = 2;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // DontHaveAccountLabel
            // 
            DontHaveAccountLabel.AutoSize = true;
            DontHaveAccountLabel.Location = new Point(88, 175);
            DontHaveAccountLabel.Name = "DontHaveAccountLabel";
            DontHaveAccountLabel.Size = new Size(150, 17);
            DontHaveAccountLabel.TabIndex = 1;
            DontHaveAccountLabel.Text = "Don't have an account?";
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            WelcomeLabel.Location = new Point(100, 139);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(119, 32);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(921, 559);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Log In Form";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }
    }
}
