using System;
using System.Windows.Forms;

namespace ProductivityApplication
{
    public partial class NewNote : Form
    {
        public NewNote()
        {
            InitializeComponent();
        }

        // Handling create note button pressed
        private void createNoteButton_Click(object sender, EventArgs e)
        {
            // Check if note name is empty
            if (noteNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Note name is empty.", "Note Creation Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (noteContentsRichTextBox.Text == string.Empty)
            {
                MessageBox.Show("Note content is empty.", "Note Creation Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Create variables for note name, note subject and note contents
                string noteName = noteNameTextBox.Text;
                string noteSubject = noteSubjectTextBox.Text;
                string noteContents = noteContentsRichTextBox.Text;

                // Create a new note object
                Note note = new Note(noteName, noteSubject, noteContents);

                // Add new note to database
                note.addToDatabase();

                // Close the create note window
                this.Close();
            }
        }
    }
}
