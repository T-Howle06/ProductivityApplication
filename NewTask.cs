using System;
using System.Windows.Forms;

namespace ProductivityApplication
{
    public partial class NewTask : Form
    {
        public NewTask()
        {
            InitializeComponent();
        }

        // Handling create task button press
        private void createTaskButton_Click(object sender, EventArgs e)
        {
            // Check if task name is empty
            if (taskNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Task name is empty.", "Task Creation Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Create variables for task name and task due date
                string taskName = taskNameTextBox.Text;
                string taskDue = taskDueTextBox.Text;

                // Create a new task object from tasks
                Task task = new Task(taskName, taskDue);

                // Add new task to database
                task.addToDatabase();

                // Close the create task window
                this.Close();
            }
        }
    }
}
