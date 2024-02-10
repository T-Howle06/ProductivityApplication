using System;
using System.Windows.Forms;

namespace ProductivityApplication
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        // Handling todo list button press
        private void todoButton_Click(object sender, EventArgs e)
        {
            ToDoScreen toDoScreen = new ToDoScreen();
            this.Close();
            toDoScreen.Show();
        }

        // Handling notes button press
        private void notesButton_Click(object sender, EventArgs e)
        {
            NotesScreen notesScreen = new NotesScreen();
            this.Close();
            notesScreen.Show();
        }

        // Handling timer button press
        private void timerButton_Click(object sender, EventArgs e)
        {
            TimerScreen timerScreen = new TimerScreen();
            this.Close();
            timerScreen.Show();
        }

        // Handling timetable button press
        private void timetableButton_Click(object sender, EventArgs e)
        {
            TimetableScreen timetableScreen = new TimetableScreen();
            this.Close();
            timetableScreen.Show();
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
