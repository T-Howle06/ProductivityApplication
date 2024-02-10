using System.Data.SqlClient;

namespace ProductivityApplication
{
    internal class Event
    {
        string _username;
        string _title;
        string _subject;
        string _starttime;
        string _endtime;
        string _day;

        public Event(string title, string subject, string start, string end, string day)
        {
            _title = title;
            _subject = subject;
            _starttime = start;
            _endtime = end;
            _day = day;
        }

        // Function to add event to database
        public bool addToDatabase()
        {
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

                    // Dispose of the current command and reader
                    command.Dispose();
                    reader.Close();
                }

                // Query to insert a new task into tasks table
                query = "INSERT INTO timetable (username, title, subject, timestart, timeend, day) VALUES (@Username, @Title, @Subject, @TimeStart, @TimeEnd, @Day)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use paramaters to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", _username);
                    command.Parameters.AddWithValue("@Title", _title);
                    command.Parameters.AddWithValue("@Subject", _subject);
                    command.Parameters.AddWithValue("@TimeStart", _starttime);
                    command.Parameters.AddWithValue("@TimeEnd", _endtime);
                    command.Parameters.AddWithValue("@Day", _day);

                    // Get rows affected
                    int rowsAffected = command.ExecuteNonQuery();

                    // If there are rows affected then successfully added
                    return rowsAffected > 0;
                }
            }
        }
    }
}
