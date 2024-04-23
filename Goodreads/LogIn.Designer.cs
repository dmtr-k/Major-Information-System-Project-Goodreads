namespace Goodreads
{
    partial class LogIn
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
            label2 = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            logInButton = new Button();
            checkBox1 = new CheckBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(266, 121);
            label1.Name = "label1";
            label1.Size = new Size(268, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome back!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(203, 167);
            label2.Name = "label2";
            label2.Size = new Size(395, 27);
            label2.TabIndex = 1;
            label2.Text = "Log in to continue to your account";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(304, 216);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Username";
            usernameTextBox.Size = new Size(193, 23);
            usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(304, 261);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(193, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // logInButton
            // 
            logInButton.Location = new Point(422, 307);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(75, 23);
            logInButton.TabIndex = 4;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(304, 310);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(325, 342);
            label3.Name = "label3";
            label3.Size = new Size(150, 15);
            label3.TabIndex = 15;
            label3.Text = "Don't have an account yet?";
            label3.Click += label3_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(logInButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button logInButton;
        private CheckBox checkBox1;
        private Label label3;
    }
}