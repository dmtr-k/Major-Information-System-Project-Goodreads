using Goodreads;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Goodreads
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }
        private void userNameTxt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (usernameTextBox.Text.Length <= 4)
            {
                MessageBox.Show("Username should be at least 5 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                length.Focus();
                e.Cancel = true;
            }
        }

        private void passwordTxt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(passwordTextBox.Text.Length > 8 && passwordTextBox.Text.Any(char.IsUpper) && passwordTextBox.Text.Any(char.IsLower) && passwordTextBox.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("One or more password criteria(s) hasn't been met", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.SelectAll();
                e.Cancel = true;
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            length.Show(); //label for length
            upperCase.Show(); // label for the uppercase letter requirement
            lowerCase.Show(); // label for the lowercase letter requirement
            digit.Show(); // label for the digit requirement
            //specialCharacter.Show(); // label for the special character requirement

            if (passwordTextBox.Text.Length > 8) //check if a string includes any uppercase letter
                length.ForeColor = Color.Green; //change the color property of capital label
            else
                length.ForeColor = Color.Red;

            if (passwordTextBox.Text.Any(char.IsUpper)) //check if a string includes any uppercase letter
                upperCase.ForeColor = Color.Green; //change the color property of capital label
            else
                upperCase.ForeColor = Color.Red;

            if (passwordTextBox.Text.Any(char.IsLower)) //check if a string includes any lowercase letter
                lowerCase.ForeColor = Color.Green; //change the color property of capital label
            else
                lowerCase.ForeColor = Color.Red;

            if (passwordTextBox.Text.Any(char.IsNumber)) //check if a string includes any uppercase letter
                digit.ForeColor = Color.Green; //change the color property of capital label
            else
                digit.ForeColor = Color.Red;

            /*if (passwordTxt.Text.Any(c => c == '*' || c == '_' || c == '-'))
                upperCase.ForeColor = Color.Green;
            else
                upperCase.ForeColor = Color.Red;
            */

        }

        private void emailTxt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string email = emailTextBox.Text.Trim();

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                length.Focus();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(emailTextBox, "");
            }
        }

        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"; // REGEX pattern for acceptable email.

            if (string.IsNullOrEmpty(email)) // return false if email is empty.
                return false;

            Regex regex = new Regex(emailPattern); // create an instance of Regex class.
            return regex.IsMatch(email); // call ismatch method and return boolean value.
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            this.Hide();
            form2.ShowDialog();
        }
        */

        private void logIn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.ShowDialog();

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=LAB109PC10\SQLEXPRESS; Initial Catalog=Goodreads; Integrated Security=True;");
            cn.Open();

            if (passwordTextBox.Text != string.Empty || reTypePasswordTextBox.Text != string.Empty)
            {
                if (passwordTextBox.Text == reTypePasswordTextBox.Text)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM UserInfo WHERE UserName ='" + usernameTextBox.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username already exist! Please, try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();

                        using (cmd = new SqlCommand("INSERT INTO UserInfo (UserName, Password, Email) VALUES (@username, @password, @email)", cn))
                        {
                            cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                            cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                            cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Your Account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                            LogIn login = new LogIn();
                            login.Show();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Passwords do not match! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter values in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

