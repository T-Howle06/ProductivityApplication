using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductivityApplication
{
    public partial class TimetableScreen : Form
    {
        public TimetableScreen()
        {
            InitializeComponent();
        }

        // Function to refresh the events based on selected day
        private void refreshTasks(string day)
        {
            // Clear existing items in the ListBox
            eventListBox.Items.Clear();

            // Variable to hold the username from the database
            string username = "";

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
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // While the reader is reading values
                        while (reader.Read())
                        {
                            // Set the username attribute to the last username read
                            username = reader.GetString(0);
                            reader.Close();
                            break;
                        }
                    }
                    // Dispose of current command
                    command.Dispose();
                }

                // Query to get the title, subject, start time, end time of events from current user and day is monday
                query = "SELECT title, subject, timestart, timeend FROM timetable WHERE (username = @Username AND day = @Day)";

                // List for the events
                List<string> events = new List<string>();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Day", day);

                    // Execute query and read results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Read the values from the reader
                            string title = reader.GetString(0);
                            string subject = reader.GetString(1);
                            string startTime = reader.GetString(2);
                            string endTime = reader.GetString(3);

                            // Add the note details to the list
                            events.Add($"Title: {title}, Subject: {subject}, Start: {startTime}, End: {endTime}");
                        }

                        // Populate the ListBox with the notes
                        foreach (string _event in events)
                        {
                            eventListBox.Items.Add(_event);
                        }
                    }
                }
            }
        }

        // Function to delete event from the database
        private bool deleteSelectedEvent(string eventName)
        {
            // Create connection string variable
            string connectionString = "Data Source=DESKTOP-RVQ5B1D\\SQLEXPRESS;Initial Catalog=MyProductivity;Integrated Security=True";

            // Query to delete the event from the database
            string query = "DELETE FROM timetable WHERE title = @EventName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the database connection
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@EventName", eventName);

                    // Execute query and get rows affected
                    int rowsAffected = command.ExecuteNonQuery();

                    // If rows are affected the update query is successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Event successfully updated!", "Event Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Event unsuccessfully updated!", "Event Not Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        // Handling the monday button clicked
        private void mondayButton_Click(object sender, EventArgs e)
        {
            refreshTasks(mondayButton.Text);
        }

        // Handling the tuesday button clicked
        private void tuesdayButton_Click(object sender, EventArgs e)
        {
            refreshTasks(tuesdayButton.Text);
        }

        // Handling the wednesday button clicked
        private void wednesdayButton_Click(object sender, EventArgs e)
        {
            refreshTasks(wednesdayButton.Text);
        }

        // Handling the thursday button clicked
        private void thursdayButton_Click(object sender, EventArgs e)
        {
            refreshTasks(thursdayButton.Text);
        }

        // Handling the friday button clicked
        private void fridayButton_Click(object sender, EventArgs e)
        {
            refreshTasks(fridayButton.Text);
        }

        // Handling the create new event button pressed
        private void createEventButton_Click(object sender, EventArgs e)
        {
            NewEvent newEvent = new NewEvent();
            newEvent.Show();
        }

        // Handling the delete event button pressed
        private void deleteEventButton_Click(object sender, EventArgs e)
        {
            // Check if an event is selected
            if (eventListBox.SelectedItem != null)
            {
                // Retrieve the selected event
                string selectedEvent = eventListBox.SelectedItem.ToString();

                // Extract the event name using substring
                int startIndex = selectedEvent.IndexOf("Title: ") + "Title: ".Length;
                int endIndex = selectedEvent.IndexOf(", Subject: ");

                if (startIndex >= 0 && endIndex >= 0)
                {
                    // Set the event name variable
                    string selectedEventName = selectedEvent.Substring(startIndex, endIndex - startIndex);

                    // Call the delete event function with the event name as a parameter
                    deleteSelectedEvent(selectedEventName);
                }
            }
        }

        // Handling back button press
        private void backButton_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            this.Close();
            homeScreen.Show();
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
