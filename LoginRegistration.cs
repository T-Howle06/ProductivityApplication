using System;
// Allow connection to database
using System.Data.SqlClient;
// Allow for hashing
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ProductivityApplication
{
    public partial class LoginRegistration : Form
    {
        public LoginRegistration()
        {
            InitializeComponent();
        }

        // Function to hash the password using SHA256
        private string hashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // ComputeHash returns byte array, convert it to a hex string
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        // Check if username is available
        private bool usernameAvailable(string username)
        {
            // Create connectionString variable using database connection string
            string connectionString = "Data Source=DESKTOP-RVQ5B1D\\SQLEXPRESS;Initial Catalog=MyProductivity;Integrated Security=True";

            // Create SQL query to check if username exists
            string query = "SELECT COUNT(*) FROM logins WHERE username = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the database connection
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute query and check if any rows are returned
                    int userCount = (int)command.ExecuteScalar();

                    // If userCount is 0 the username is available
                    return userCount == 0;
                }
            }
        }

        // Function to handle registration process
        private bool registerUser(string username, string hashedPassword)
        {
            // Create connectionString variable using database connection string
            string connectionString = "Data Source=DESKTOP-RVQ5B1D\\SQLEXPRESS;Initial Catalog=MyProductivity;Integrated Security=True";

            // Check if username is available
            if (usernameAvailable(username))
            {
                // Insert the new user into the table
                string insertQuery = "INSERT INTO logins (username, password) VALUES (@Username, @Password)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the database connection
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Use parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", hashedPassword);

                        // Execute query and get rows affected
                        int rowsAffected = command.ExecuteNonQuery();

                        // If rows are affected, registration is successful
                        return rowsAffected > 0;
                    }
                }
            }

            // If username is not available the registration has failed
            return false;
        }

        // Handling submit button pressed
        private void submitButton_Click(object sender, EventArgs e)
        {
            // Set username and password as entered
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            // Hash the password
            string hashedPassword = hashPassword(password);

            // Perform registration
            if (registerUser(username, hashedPassword))
            {
                // Display success message if successful registration
                DialogResult result = MessageBox.Show("Registration Successful!\nWould you like to login?", "Registration Successful", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    LoginScreen loginScreen = new LoginScreen();
                    this.Hide();
                    loginScreen.Show();
                }
            }
        }

        // Handing reset button pressed
        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                usernameTextBox.Clear();
                passwordTextBox.Clear();
            }
        }

        // Handing exit button pressed
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
