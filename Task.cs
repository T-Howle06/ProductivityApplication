using System.Data.SqlClient;

namespace ProductivityApplication
{
    internal class Task
    {
        string _username;
        string _title;
        string _due;

        public Task(string title, string due)
        {
            _title = title;
            _due = due;
        }

        // Function to add task to database
        public bool addToDatabase()
        {
            // Check if due date is null
            if (_due == null)
            {
                _due = "No Due Date";
            }

            // Create connection string variable
            string connectionString = "Data Source=DESKTOP-RVQ5B1D\\SQLEXPRESS;Initial Catalog=MyProductivity;Integrated Security=True";

            // Query to get the username from the log table of logged in users
            string query = "SELECT username FROM log WHERE id=(SELECT max(id) FROM log)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the database connection
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the data reader
                    SqlDataReader reader = command.ExecuteReader();

                    // While the reader is reading values
                    while (reader.Read())
                    {
                        // Set the username attribute to the last username read
                        _username = reader.GetString(0);
                        break;
                    }
                }
            }

            // Query to insert a new task into tasks table
            query = "INSERT INTO tasks (username, title, due) VALUES (@Username, @Title, @Due)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the database connection
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use paramaters to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", _username);
                    command.Parameters.AddWithValue("@Title", _title);
                    command.Parameters.AddWithValue("@Due", _due);

                    // Get rows affected
                    int rowsAffected = command.ExecuteNonQuery();

                    // If there are rows affected then successfully added
                    return rowsAffected > 0;
                }
            }
        }
    }
}
