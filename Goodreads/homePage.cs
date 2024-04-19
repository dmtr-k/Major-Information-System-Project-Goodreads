using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Goodreads.authenticate;  // Importing static members from the authenticate class
using Goodreads;  // Importing the entire WinFormsDemo namespace
using System.Diagnostics;
using System.Data.SqlClient;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace Goodreads
{
    // Declaration of a partial class named Form5, which inherits from Form
    public partial class homePage : Form
    {

        private authenticate.User authenticatedUser;  // Declaration of a private variable to store authenticated user information

        // Constructor for Form5, taking a User object as a parameter
        public homePage(authenticate.User authenticatedUser)
        {
            InitializeComponent();  // Initializing the components of the form

            this.authenticatedUser = authenticatedUser; // Assign the authenticated user to the local variable

            // Additional initialization or actions based on the authenticated user can be added here
            // For example, you can set labels or perform other operations.
            userNameLabel.Text = $"Welcome, {authenticatedUser.Username}!";  // Setting the text of a label
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the DataGridViewRow corresponding to the clicked cell
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Extract book information from the row
                string title = row.Cells["Title"].Value.ToString();
                string author = row.Cells["Author"].Value.ToString();
                string genre = row.Cells["Genre"].Value.ToString();
                int publishYear = Convert.ToInt32(row.Cells["PublishYear"].Value);
                string publisher = row.Cells["Publisher"].Value.ToString();
                string imageUrl = row.Cells["Image"].Value.ToString();

                int bookID = Convert.ToInt32(row.Cells["BookID"].Value);

                int userID = authenticatedUser.UserID;

                // Extract other book information similarly

                // Now, you can open a dialog window to display the book info
                // Create an instance of the dialog window
                BookInfo bookInfo = new BookInfo(bookID, userID, title, author, genre, publishYear, publisher, imageUrl);

                // Show the dialog window
                bookInfo.ShowDialog();
            }

        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            genreComboBox.SelectedIndex = 0;
            publisherComboBox.SelectedIndex = 0;
            publishYearComboBox.SelectedIndex = 0;
            priceRangeComboBox.SelectedIndex = 0;
            titleTextBox.Text = "";
            authorTextBox.Text = "";

        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC10\SQLEXPRESS; Initial Catalog=Goodreads; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Start with a base SQL query
                string query = "SELECT * FROM Books WHERE 1 = 1";
                // Create a list to store the conditions for filtering
                List<string> conditions = new List<string>();

                // Check each ComboBox and add a condition if an item is selected
                if (genreComboBox.SelectedItem != "Genre")
                {
                    conditions.Add("Genre = @genre");
                }

                if (publisherComboBox.SelectedItem != "Publisher")
                {
                    conditions.Add("Publisher = @publisher");
                }

                if (publishYearComboBox.SelectedItem != "Published Year")
                {
                    switch (publishYearComboBox.SelectedItem.ToString())
                    {
                        case "1800 - 1849":
                            conditions.Add("PublishYear BETWEEN 1800 AND 1849");
                            break;
                        case "1850 - 1899":
                            conditions.Add("PublishYear BETWEEN 1850 AND 1899");
                            break;
                        case "1900 - 1949":
                            conditions.Add("PublishYear BETWEEN 1900 AND 1949");
                            break;
                        case "1950 - 1999":
                            conditions.Add("PublishYear BETWEEN 1950 AND 1999");
                            break;
                        case "2000 - 2024":
                            conditions.Add("PublishYear BETWEEN 2000 AND 2024");
                            break;

                            // Add more cases for other price ranges if needed
                    }
                }
                if (priceRangeComboBox.SelectedItem != "Price")
                {
                    switch (priceRangeComboBox.SelectedItem.ToString())
                    {
                        case "0 - 9.99":
                            conditions.Add("Price BETWEEN 0 AND 9.99");
                            break;
                        case "10 - 19.99":
                            conditions.Add("Price BETWEEN 10 AND 19.99");
                            break;
                            // Add more cases for other price ranges if needed
                    }
                }

                // Add search criteria for title and author
                if (!string.IsNullOrEmpty(titleTextBox.Text))
                {
                    conditions.Add("Title LIKE @title");
                }

                if (!string.IsNullOrEmpty(authorTextBox.Text))
                {
                    conditions.Add("Author LIKE @author");
                }

                // Combine the conditions into the SQL query
                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                // Set parameters based on selected values, handling the case where ComboBox is empty
                if (genreComboBox.SelectedItem != "Genre")
                {
                    cmd.Parameters.AddWithValue("@genre", genreComboBox.SelectedItem.ToString());
                }

                if (publisherComboBox.SelectedItem != "Publisher")
                {
                    cmd.Parameters.AddWithValue("@publisher", publisherComboBox.SelectedItem.ToString());
                }

                if (priceRangeComboBox.SelectedItem != "Price")
                {
                    cmd.Parameters.AddWithValue("@price", priceRangeComboBox.SelectedItem.ToString());
                }

                // Set parameters for title and author
                if (!string.IsNullOrEmpty(titleTextBox.Text))
                {
                    cmd.Parameters.AddWithValue("@title", "%" + titleTextBox.Text + "%");
                }

                if (!string.IsNullOrEmpty(authorTextBox.Text))
                {
                    cmd.Parameters.AddWithValue("@author", "%" + authorTextBox.Text + "%");
                }

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }

        private void homePage_Load(object sender, EventArgs e)
        {
            genreComboBox.SelectedIndex = 0;
            publisherComboBox.SelectedIndex = 0;
            publishYearComboBox.SelectedIndex = 0;
            priceRangeComboBox.SelectedIndex = 0;
        }
    }
}
