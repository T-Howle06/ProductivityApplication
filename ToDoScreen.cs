using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductivityApplication
{
    public partial class ToDoScreen : Form
    {
        public ToDoScreen()
        {
            InitializeComponent();
        }

        // Function to delete the selected task
        private bool deleteSelectedTask(string taskName)
        {
            // Create connection string variable
            string connectionString = "Data Source=DESKTOP-RVQ5B1D\\SQLEXPRESS;Initial Catalog=MyProductivity;Integrated Security=True";

            // Query to set the completed field of the selected task to true
            string query = "DELETE FROM tasks WHERE title = @TaskName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the database connection
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TaskName", taskName);

                    // Execute query and get rows affected
                    int rowsAffected = command.ExecuteNonQuery();

                    // If rows are affected the update query is successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Task successfully updated!", "Task Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Task unsuccessfully updated!", "Task Not Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        // Handling refresh button pressed
        private void refreshButton_Click(object sender, EventArgs e)
        {
            // Clear existing items in the ListBoxes
            currentTasksListBox.Items.Clear();
            completedTasksListBox.Items.Clear();

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

                // Query to get the title and due date of tasks belonging to the current user and are not completed
                query = "SELECT title, due FROM tasks WHERE (username = @Username AND completed = 'False')";

                // List for the tasks
                List<string> tasks = new List<string>();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute query and read results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Read the title and due date from the reader
                            string title = reader.GetString(0);
                            string dueDate = reader.GetString(1);

                            // Add the task details to the list
                            tasks.Add($"Title: {title}, Due Date: {dueDate}");
                        }

                        // Populate the ListBox with the tasks
                        foreach (string task in tasks)
                        {
                            currentTasksListBox.Items.Add(task);
                        }
                    }

                    // Dispose of the current command
                    command.Dispose();
                }

                // Query to get the title and due date of tasks belonging to the current user and are completed
                query = "SELECT title, due FROM tasks WHERE (username = @Username AND completed = 'True')";

                // Clear the tasks list
                tasks.Clear();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute query and read results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Read the title and due date from the reader
                            string title = reader.GetString(0);
                            string dueDate = reader.GetString(1);

                            // Add the task details to the list
                            tasks.Add($"Title: {title}, Due Date: {dueDate}");
                        }

                        // Populate the ListBox with the tasks
                        foreach (string task in tasks)
                        {
                            completedTasksListBox.Items.Add(task);
                        }
                    }
                }
            }
        }

        // Handling add new task button pressed
        private void newTaskButton_Click(object sender, EventArgs e)
        {
            NewTask newTask = new NewTask();
            newTask.Show();
        }

        // Handling set task completed button pressed
        private void setCompletedButton_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (currentTasksListBox.SelectedItem != null)
            {
                // Retrieve the selected task
                string selectedTask = currentTasksListBox.SelectedItem.ToString();

                // Extract the task name using substring
                int startIndex = selectedTask.IndexOf("Title: ") + "Title: ".Length;
                int endIndex = selectedTask.IndexOf(", Due Date:");

                if (startIndex >= 0 && endIndex >= 0)
                {
                    // Set the task name variable
                    string selectedTaskName = selectedTask.Substring(startIndex, endIndex - startIndex);

                    // Create connection string variable
                    string connectionString = "Data Source=DESKTOP-RVQ5B1D\\SQLEXPRESS;Initial Catalog=MyProductivity;Integrated Security=True";

                    // Query to set the completed field of the selected task to true
                    string query = "UPDATE tasks SET completed = 'True' WHERE title = @TaskName";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Open the database connection
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TaskName", selectedTaskName);

                            // Execute query and get rows affected
                            int rowsAffected = command.ExecuteNonQuery();

                            // If rows are affected the update query is successful
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Task successfully updated!", "Task Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Task unsuccessfully updated!", "Task Not Updated!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        // Handling set current task button pressed
        private void setCurrentButton_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (completedTasksListBox.SelectedItem != null)
            {
                // Retrieve the selected task
                string selectedTask = completedTasksListBox.SelectedItem.ToString();

                // Extract the task name using substring
                int startIndex = selectedTask.IndexOf("Title: ") + "Title: ".Length;
                int endIndex = selectedTask.IndexOf(", Due Date:");

                if (startIndex >= 0 && endIndex >= 0)
                {
                    // Set the task name variable
                    string selectedTaskName = selectedTask.Substring(startIndex, endIndex - startIndex);

                    // Create connection string variable
                    string connectionString = "Data Source=DESKTOP-RVQ5B1D\\SQLEXPRESS;Initial Catalog=MyProductivity;Integrated Security=True";

                    // Query to set the completed field of the selected task to true
                    string query = "UPDATE tasks SET completed = 'False' WHERE title = @TaskName";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Open the database connection
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TaskName", selectedTaskName);

                            // Execute query and get rows affected
                            int rowsAffected = command.ExecuteNonQuery();

                            // If rows are affected the update query is successful
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Task successfully updated!", "Task Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Task unsuccessfully updated!", "Task Not Updated!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        // Handling delete task button pressed
        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            // Check where the item is selected
            if (currentTasksListBox.SelectedItem != null && completedTasksListBox.SelectedItem == null)
            {
                // Retrieve the selected task
                string selectedTask = currentTasksListBox.SelectedItem.ToString();

                // Extract the task name using substring
                int startIndex = selectedTask.IndexOf("Title: ") + "Title: ".Length;
                int endIndex = selectedTask.IndexOf(", Due Date:");

                if (startIndex >= 0 && endIndex >= 0)
                {
                    // Set the task name variable
                    string selectedTaskName = selectedTask.Substring(startIndex, endIndex - startIndex);

                    // Call the delete task function with the task name as a parameter
                    deleteSelectedTask(selectedTaskName);
                }
            }
            else if (currentTasksListBox.SelectedItem == null && completedTasksListBox.SelectedItem != null)
            {
                // Retrieve the selected task
                string selectedTask = completedTasksListBox.SelectedItem.ToString();

                // Extract the task name using substring
                int startIndex = selectedTask.IndexOf("Title: ") + "Title: ".Length;
                int endIndex = selectedTask.IndexOf(", Due Date:");

                if (startIndex >= 0 && endIndex >= 0)
                {
                    // Set the task name variable
                    string selectedTaskName = selectedTask.Substring(startIndex, endIndex - startIndex);

                    // Call the delete task function with the task name as a parameter
                    deleteSelectedTask(selectedTaskName);
                }
            }
            else
            {
                // Output an error as more than one task is selected
                MessageBox.Show("Please select one task.", "Task Deletion Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handling back button pressed
        private void backButton_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            this.Close();
            homeScreen.Show();
        }

        // Handling exit button pressed
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
