using System;
using System.Windows.Forms;

namespace ProductivityApplication
{
    public partial class NewEvent : Form
    {
        public NewEvent()
        {
            InitializeComponent();
        }

        // Handling create event button pressed
        private void createEventButton_Click(object sender, EventArgs e)
        {
            // Check if event name or day is empty
            if (eventNameTextBox.Text == string.Empty || eventDayListBox.SelectedItem == null)
            {
                MessageBox.Show("Event name or day is empty.", "Event Creation Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Create variables for event name, subject, start time, end time and day
                string eventName = eventNameTextBox.Text;
                string eventSubject = eventSubjectTextBox.Text;
                string eventStart = eventStartTextBox.Text;
                string eventEnd = eventEndTextBox.Text;
                string eventDay = eventDayListBox.SelectedItem.ToString();

                // Create a new event object 
                Event newevent = new Event(eventName, eventSubject, eventStart, eventEnd, eventDay);

                // Add new event to database
                newevent.addToDatabase();

                // Close the create event window
                this.Close();
            }
        }
    }
}
