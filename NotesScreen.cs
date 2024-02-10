using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductivityApplication
{
    public partial class NotesScreen : Form
    {
        public NotesScreen()
        {
            InitializeComponent();
        }

        // Function to delete the selected task
        private bool deleteSelectedNote(string noteName)
        {
            // Create connection string variable
            string connectionString = "Data Source=DESKTOP-RVQ5B1D\\SQLEXPRESS;Initial Catalog=MyProductivity;Integrated Security=True";

            // Query to set the completed field of the selected task to true
            string query = "DELETE FROM notes WHERE title = @NoteName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the database connection
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@NoteName", noteName);

                    // Execute query and get rows affected
                    int rowsAffected = command.ExecuteNonQuery();

                    // If rows are affected the update query is successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Note successfully updated!", "Note Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Note unsuccessfully updated!", "Note Not Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        // Handling refresh button pressed
        private void refreshButton_Click(object sender, EventArgs e)
        {
            // Clear existing items in the ListBox
            notesListBox.Items.Clear();

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

                // Query to get the title and subject of notes belonging to the current user
                query = "SELECT title, subject FROM notes WHERE (username = @Username)";

                // List for the notes
                List<string> notes = new List<string>();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute query and read results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Read the title and subject from the reader
                            string title = reader.GetString(0);
                            string subject = reader.GetString(1);

                            // Add the note details to the list
                            notes.Add($"Title: {title}, Subject: {subject}");
                        }

                        // Populate the ListBox with the notes
                        foreach (string note in notes)
                        {
                            notesListBox.Items.Add(note);
                        }
                    }
                }
            }
        }

        // Handling create new button pressed
        private void createNoteButton_Click(object sender, EventArgs e)
        {
            NewNote newNote = new NewNote();
            newNote.Show();
        }

        // Handling view note button pressed
        private void viewNoteButton_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (notesListBox.SelectedItem != null)
            {
                // Retrieve the selected note
                string selectedNote = notesListBox.SelectedItem.ToString();

                // Extract the task name using substring
                int startIndex = selectedNote.IndexOf("Title: ") + "Title: ".Length;
                int endIndex = selectedNote.IndexOf(", Subject:");

                if (startIndex >= 0 && endIndex >= 0)
                {
                    // Set the note name variable
                    string selectedNoteTitle = selectedNote.Substring(startIndex, endIndex - startIndex);

                    // Create connection string variable
                    string connectionString = "Data Source=DESKTOP-RVQ5B1D\\SQLEXPRESS;Initial Catalog=MyProductivity;Integrated Security=True";

                    // Query to select the note corresponding to the note title clicked
                    string query = "SELECT title, subject, contents FROM notes WHERE (title = @NoteTitle)";

                    // Set variables for the title, subject and contents of the note
                    string title = null;
                    string subject = null;
                    string contents = null;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Open the database connection
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Use paramaters to prevent SQL injection
                            command.Parameters.AddWithValue("@NoteTitle", selectedNoteTitle);

                            // Execute query and read results
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    // Read the title and subject from the reader
                                    title = reader.GetString(0);
                                    subject = reader.GetString(1);
                                    contents = reader.GetString(2);
                                }

                                // Create a string for the format of the output
                                string outputNote = $"Title: {title}\nSubject: {subject}\nContents: \n{contents}";

                                // Output a message box with the format of the note
                                MessageBox.Show(outputNote, "View Selected Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }

        // Handling delete selected note button pressed
        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            // Check if a note is selected
            if (notesListBox.SelectedItem != null)
            {
                // Retrieve the selected note
                string selectedNote = notesListBox.SelectedItem.ToString();

                // Extract the note name using substring
                int startIndex = selectedNote.IndexOf("Title: ") + "Title: ".Length;
                int endIndex = selectedNote.IndexOf(", Subject: ");

                if (startIndex >= 0 && endIndex >= 0)
                {
                    // Set the note name variable
                    string selectedNoteName = selectedNote.Substring(startIndex, endIndex - startIndex);

                    // Call the delete note function with the note name as a parameter
                    deleteSelectedNote(selectedNoteName);
                }
            }
        }

        // Handling back button pressed
        private void backButton_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            this.Close();
            homeScreen.Show();
        }

        // Handing exit button press
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
