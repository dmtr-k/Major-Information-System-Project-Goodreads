using System;
using System.Data;
using System.Data.SqlClient;

namespace Goodreads
{
    public class authenticate
    {
        public class User
        {
            public string Username { get; set; }
            public string Email { get; set; }
            public int UserID { get; set; } // Change from userID to UserID
        }

        public class DatabaseManager
        {
            public static User AuthenticateUser(string username, string password)
            {
                User user = RetrieveUserInformation(username, password);
                return user;
            }

            private static User RetrieveUserInformation(string username, string password)
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC10\SQLEXPRESS; Initial Catalog=Goodreads; Integrated Security=True;"))
                {
                    sqlCon.Open();

                    string loginQuery = "SELECT UserID FROM UserInfo WHERE UserName=@Username AND Password=@Password"; // Query to retrieve UserID
                    string infoQuery = "SELECT * FROM UserInfo WHERE UserName=@Username AND Password=@Password";

                    using (SqlCommand loginCmd = new SqlCommand(loginQuery, sqlCon))
                    {
                        using (SqlCommand infoCmd = new SqlCommand(infoQuery, sqlCon))
                        {
                            loginCmd.CommandType = CommandType.Text;
                            infoCmd.CommandType = CommandType.Text;

                            loginCmd.Parameters.AddWithValue("@Username", username);
                            loginCmd.Parameters.AddWithValue("@Password", password);
                            infoCmd.Parameters.AddWithValue("@Username", username);
                            infoCmd.Parameters.AddWithValue("@Password", password);

                            int userID = Convert.ToInt32(loginCmd.ExecuteScalar()); // Retrieve UserID

                            if (userID != 0) // Check if UserID is valid
                            {
                                using (SqlDataReader reader = infoCmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        return new User
                                        {
                                            Username = username,
                                            Email = reader["Email"].ToString(),
                                            UserID = userID // Set the UserID in the User object
                                        };
                                    }
                                }
                            }
                            return null;
                        }
                    }
                }
            }
        }
    }
}
