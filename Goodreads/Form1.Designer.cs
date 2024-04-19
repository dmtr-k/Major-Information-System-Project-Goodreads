namespace Goodreads
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            checkBox1 = new CheckBox();
            signUpButton = new Button();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            reTypePasswordTextBox = new TextBox();
            emailTextBox = new TextBox();
            logIn = new Label();
            digit = new Label();
            upperCase = new Label();
            lowerCase = new Label();
            length = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(298, 326);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(205, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "I agree with Terms and Conditions";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // signUpButton
            // 
            signUpButton.Location = new Point(422, 353);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(75, 23);
            signUpButton.TabIndex = 10;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(304, 251);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(193, 23);
            passwordTextBox.TabIndex = 9;
            passwordTextBox.TextChanged += passwordTxt_TextChanged;
            passwordTextBox.Validating += passwordTxt_Validating;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(304, 213);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Username";
            usernameTextBox.Size = new Size(193, 23);
            usernameTextBox.TabIndex = 8;
            usernameTextBox.Validating += userNameTxt_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(233, 127);
            label2.Name = "label2";
            label2.Size = new Size(335, 27);
            label2.TabIndex = 7;
            label2.Text = "Sign up to create an account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(311, 81);
            label1.Name = "label1";
            label1.Size = new Size(179, 38);
            label1.TabIndex = 6;
            label1.Text = "Welcome!";
            // 
            // reTypePasswordTextBox
            // 
            reTypePasswordTextBox.Location = new Point(304, 289);
            reTypePasswordTextBox.Name = "reTypePasswordTextBox";
            reTypePasswordTextBox.PasswordChar = '*';
            reTypePasswordTextBox.PlaceholderText = "Re-type Password";
            reTypePasswordTextBox.Size = new Size(193, 23);
            reTypePasswordTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(304, 175);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Email Address";
            emailTextBox.Size = new Size(193, 23);
            emailTextBox.TabIndex = 13;
            emailTextBox.Validating += emailTxt_Validating;
            // 
            // logIn
            // 
            logIn.AutoSize = true;
            logIn.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            logIn.Location = new Point(304, 357);
            logIn.Name = "logIn";
            logIn.Size = new Size(86, 15);
            logIn.TabIndex = 14;
            logIn.Text = "Log in instead?";
            logIn.Click += logIn_Click_1;
            // 
            // digit
            // 
            digit.AutoSize = true;
            digit.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            digit.Location = new Point(514, 278);
            digit.Margin = new Padding(4, 0, 4, 0);
            digit.Name = "digit";
            digit.Size = new Size(120, 16);
            digit.TabIndex = 18;
            digit.Text = "• At least one digit";
            digit.Visible = false;
            // 
            // upperCase
            // 
            upperCase.AutoSize = true;
            upperCase.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            upperCase.Location = new Point(514, 246);
            upperCase.Margin = new Padding(4, 0, 4, 0);
            upperCase.Name = "upperCase";
            upperCase.Size = new Size(188, 16);
            upperCase.TabIndex = 17;
            upperCase.Text = "• At leastone uppercase letter";
            upperCase.Visible = false;
            // 
            // lowerCase
            // 
            lowerCase.AutoSize = true;
            lowerCase.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lowerCase.Location = new Point(514, 214);
            lowerCase.Margin = new Padding(4, 0, 4, 0);
            lowerCase.Name = "lowerCase";
            lowerCase.Size = new Size(190, 16);
            lowerCase.TabIndex = 16;
            lowerCase.Text = "• At least one lowercase letter";
            lowerCase.Visible = false;
            // 
            // length
            // 
            length.AutoSize = true;
            length.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            length.Location = new Point(514, 182);
            length.Margin = new Padding(4, 0, 4, 0);
            length.Name = "length";
            length.Size = new Size(171, 16);
            length.TabIndex = 15;
            length.Text = "• At least 8 characters long";
            length.Visible = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(digit);
            Controls.Add(upperCase);
            Controls.Add(lowerCase);
            Controls.Add(length);
            Controls.Add(logIn);
            Controls.Add(emailTextBox);
            Controls.Add(reTypePasswordTextBox);
            Controls.Add(checkBox1);
            Controls.Add(signUpButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Button signUpButton;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Label label2;
        private Label label1;
        private TextBox reTypePasswordTextBox;
        private TextBox emailTextBox;
        private Label logIn;
        private Label digit;
        private Label upperCase;
        private Label lowerCase;
        private Label length;
        private ErrorProvider errorProvider1;
    }
}