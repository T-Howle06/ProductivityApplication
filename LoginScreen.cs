using System;
// Allow connection to database
using System.Data.SqlClient;
// Allow for hashing
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ProductivityApplication
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        // Function to add user to log
        private bool addToLog(string username)
        {
            // Create connection string variable
            string connectionString = "Data Source=DESKTOP-RVQ5B1D\\SQLEXPRESS;Initial Catalog=MyProductivity;Integrated Security=True";

            // Create query to insert new log for current user
            string query = "INSERT INTO log (username, time) VALUES (@Username, @Time)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open database connection
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Time", DateTime.Now.TimeOfDay);

                    // Execute command and get rows affected
                    int rowsAffected = command.ExecuteNonQuery();

                    // If rows are affected, registration is successful
                    return rowsAffected > 0;
                }
            }
        }

        // Function to check if login is valid
        private bool validLogin(string username, string password)
        {
            if (username == string.Empty)
            {
                // Output an error message and return false as username is empty
                MessageBox.Show("Invalid username.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (password == string.Empty)
            {
                // Output an error message and return false as password is empty
                MessageBox.Show("Invalid password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Return true as username and password must not be empty
            return true;
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

        // Function to check if login is correct
        private bool correctLogin(string username, string hashedPassword)
        {
            // Create connectionString variable using database connection string
            string connectionString = "Data Source=DESKTOP-RVQ5B1D\\SQLEXPRESS;Initial Catalog=MyProductivity;Integrated Security=True";

            // Create SQL query to check if entered login details exist
            string query = "SELECT * FROM logins WHERE username = @Username AND password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the database connection
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", hashedPassword);

                    // Execute query and read results
                    SqlDataReader reader = command.ExecuteReader();

                    // If there are rows, the login is correct
                    if (reader.HasRows)
                    {
                        reader.Close();
                        return true;
                    }
                    else
                    {
                        // If no rows are returned, login is incorrect
                        reader.Close();

                        // Display error message
                        MessageBox.Show("Incorrect login.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Return true as login must be correct
                    return false;
                }
            }
        }

        // Handing register login link press
        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Opens registration form
            LoginRegistration loginRegistration = new LoginRegistration();
            this.Hide();
            loginRegistration.Show();
        }

        // Handling login button press
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Set username and password variables based on user input
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            // Hashed the password
            string hashedPassword = hashPassword(password);

            // Check if the login is valid and correct
            if (validLogin(username, password) && correctLogin(username, hashedPassword))
            {
                addToLog(username);

                HomeScreen homeScreen = new HomeScreen();
                this.Hide();
                homeScreen.Show();
            }
        }

        // Handling reset button press
        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                usernameTextBox.Clear();
                passwordTextBox.Clear();
            }
        }

        // Handling exit button press
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
