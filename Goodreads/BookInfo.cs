using System;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;

namespace Goodreads
{
    public partial class BookInfo : Form
    {
        private SqlConnection sqlConnection;
        private const string connectionString = @"Data Source=LAB109PC10\SQLEXPRESS; Initial Catalog=Goodreads; Integrated Security=True;";

        // Properties to hold book information
        private int bookID;
        private string title;
        private string author;
        private string genre;
        private int publishYear;
        private string publisher;
        private string imageUrl;

        private int userID;

        public BookInfo(int bookID, int userID, string title, string author, string genre, int publishYear, string publisher, string imageUrl)
        {
            InitializeComponent();

            // Set the book information
            this.bookID = bookID;
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.publishYear = publishYear;
            this.publisher = publisher;
            this.imageUrl = imageUrl;

            this.userID = userID;

            // Initialize database connection
            InitializeDatabase();

            // Display book information
            DisplayBookInfo();

            LoadBookImage();

            // Load reviews for the book
            LoadReviews();
        }

        private void InitializeDatabase()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database: " + ex.Message);
            }
        }

        private void DisplayBookInfo()
        {
            // Display book details
            titleLabel.Text = title;
            authorLabel.Text = author;
            genreLabel.Text = $"Genre: {genre}";
            publishYearLabel.Text = $"Publish Year: {publishYear.ToString()}";
            publisherLabel.Text = $"Publisher: {publisher}";
        }
        private void LoadBookImage()
        {
            try
            {
                // Check if the imageUrl is not empty
                if (!string.IsNullOrEmpty(imageUrl))
                {
                    // Create a WebClient to download the image
                    using (WebClient webClient = new WebClient())
                    {
                        // Download the image bytes from the internet location
                        byte[] imageBytes = webClient.DownloadData(imageUrl);

                        // Create a MemoryStream from the image bytes
                        using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                        {
                            // Set the PictureBox image from the MemoryStream
                            bookPictureBox.Image = Image.FromStream(memoryStream);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading book image: " + ex.Message);
            }
        }

        private void LoadReviews()
        {
            try
            {
                dataGridViewReviews.Rows.Clear();

                if (dataGridViewReviews.Columns.Count == 0)
                {
                    dataGridViewReviews.Columns.Add("ReviewerColumn", "User");
                }

                SqlCommand command = new SqlCommand("SELECT UserName FROM UserInfo INNER JOIN Review ON UserInfo.UserID = Review.UserID WHERE Review.BookID = @BookID", sqlConnection);
                command.Parameters.AddWithValue("@BookID", bookID);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string username = reader["UserName"].ToString();
                    dataGridViewReviews.Rows.Add(username);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reviews: " + ex.Message);
            }
        }
        private void dataGridViewReviews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string username = dataGridViewReviews.Rows[e.RowIndex].Cells["ReviewerColumn"].Value.ToString();
                string review = GetReviewFromUsername(username);
                reviewRichTextBox.Text = review;
            }
        }


        private void newButton_Click(object sender, EventArgs e)
        {
            reviewRichTextBox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string review = reviewRichTextBox.Text;

                // Check if the user has already reviewed this book
                if (UserHasReviewed(userID))
                {
                    MessageBox.Show("You have already reviewed this book.");
                    return; // Exit the method
                }

                SqlCommand command = new SqlCommand("INSERT INTO Review (BookID, UserID, Content) VALUES (@BookID, @UserID, @Content)", sqlConnection);
                command.Parameters.AddWithValue("@BookID", bookID);
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@Content", review);
                command.ExecuteNonQuery();
                MessageBox.Show("Review saved successfully.");
                LoadReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving review: " + ex.Message);
            }
        }

        private bool UserHasReviewed(int userID)
        {
            try
            {
                // Check if the user has already reviewed this book
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Review WHERE UserID = @UserID AND BookID = @BookID", sqlConnection);
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@BookID", bookID);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking review: " + ex.Message);
                return false;
            }
        }
        private void openButton_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the dataGridViewReviews
            if (dataGridViewReviews.SelectedCells.Count > 0)
            {
                // Get the index of the selected row
                int selectedRowIndex = dataGridViewReviews.SelectedCells[0].RowIndex;

                // Ensure the selected index is valid
                if (selectedRowIndex >= 0)
                {
                    // Get the username from the selected row
                    string username = dataGridViewReviews.Rows[selectedRowIndex].Cells["ReviewerColumn"].Value.ToString();

                    // Get the review associated with the username
                    string review = GetReviewFromUsername(username);

                    // Display the review in the reviewRichTextBox
                    reviewRichTextBox.Text = review;
                }
            }
            else
            {
                MessageBox.Show("Please select a user from the reviews.");
            }
        }
        private string GetReviewFromUsername(string username)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT Content FROM Review WHERE UserID = (SELECT UserID FROM UserInfo WHERE UserName = @Username) AND BookID = @BookID", sqlConnection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@BookID", bookID);
                SqlDataReader reader = command.ExecuteReader();
                string review = "";
                if (reader.Read())
                {
                    review = reader["Content"].ToString();
                }
                reader.Close();
                return review;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving review: " + ex.Message);
                return "";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any cell is selected in the dataGridViewReviews
                if (dataGridViewReviews.SelectedCells.Count >= 0)
                {
                    // Get the index of the selected cell
                    int selectedRowIndex = dataGridViewReviews.SelectedCells[0].RowIndex;

                    // Get the username from the selected row
                    string username = dataGridViewReviews.Rows[selectedRowIndex].Cells["ReviewerColumn"].Value.ToString();

                    // Delete the review associated with the username
                    DeleteReview(username, selectedRowIndex);

                    // Refresh the dataGridViewReviews to reflect the changes
                    LoadReviews();

                }
                else
                {
                    MessageBox.Show("Please select a user from the reviews.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting review: " + ex.Message);
            }
        }
        private void DeleteReview(string username, int rowIndex)
        {
            try
            {
                // Check if the rowIndex is valid
                if (rowIndex >= 0)
                {
                    // Get the review ID from the selected row
                    int reviewID = GetReviewID(username, rowIndex);

                    // Check if the review ID is valid (greater than 0)
                    if (reviewID > 0)
                    {
                        // Delete the review associated with the review ID and book ID
                        SqlCommand command = new SqlCommand("DELETE FROM Review WHERE UserID = @UserID AND ReviewID = @ReviewID AND BookID = @BookID", sqlConnection);
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@ReviewID", reviewID);
                        command.Parameters.AddWithValue("@BookID", bookID);
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any rows were affected by the delete operation
                        if (rowsAffected > 0)
                        {
                            // Refresh the dataGridViewReviews to reflect the changes
                            LoadReviews();
                            MessageBox.Show("Review deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("You can only delete your own reviews.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a review to delete.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting review: " + ex.Message);
            }
        }


        private int GetReviewID(string username, int rowIndex)
        {
            try
            {
                // Get the review ID from the selected row
                string selectedUsername = dataGridViewReviews.Rows[rowIndex].Cells["ReviewerColumn"].Value.ToString();
                int reviewID = 0;

                // Check if the selected review belongs to the current user
                if (selectedUsername == username)
                {
                    // Get the review ID from the database based on the selected username and book ID
                    SqlCommand command = new SqlCommand("SELECT ReviewID FROM Review WHERE UserID = (SELECT UserID FROM UserInfo WHERE UserName = @Username) AND BookID = @BookID", sqlConnection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@BookID", bookID);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        reviewID = Convert.ToInt32(reader["ReviewID"]);
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("You can only delete your own reviews.");
                }

                return reviewID;
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting review ID: " + ex.Message);
            }
        }

    }
}
