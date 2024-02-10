using System;
using System.Windows.Forms;

namespace ProductivityApplication
{
    public partial class TimerScreen : Form
    {
        // Declare global variables
        private int secondsRemaining;
        private bool isTimerRunning;

        // Function to initialise the timer settings
        private void InitialiseTimer()
        {
            // Set the timer interval to 1 second
            timer.Interval = 1000;

            // Attach the Timer_Tick event handler
            timer.Tick += Timer_Tick;

            // Disable the stop and reset buttons
            resetButton.Enabled = false;
            stopButton.Enabled = false;
        }

        public TimerScreen()
        {
            InitializeComponent();
            InitialiseTimer();
        }

        // Function to check if the current session is a work session
        private bool isWorkSession()
        {
            return secondsRemaining == 25 * 60;
        }

        // Function to start the timer
        private void startTimer()
        {
            // Start the timer
            timer.Start();
            isTimerRunning = true;
        }

        // Function to stop the timer
        private void stopTimer()
        {
            // Stop the timer
            timer.Stop();
            isTimerRunning = false;
            startButton.Text = "Start";
        }

        // Function to update the label displaying the time
        private void updateTimeLabel()
        {
            int minutes = secondsRemaining / 60;
            int seconds = secondsRemaining % 60;
            timerLabel.Text = $"{minutes:D2}:{seconds:D2}";
        }

        // Event handler for the timer tick
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Check if there are still seconds remaining
            if (secondsRemaining > 0)
            {
                secondsRemaining--;
                updateTimeLabel();
            }
            else
            {
                // Timer reached zero, switch between work and break
                stopTimer();

                if (isWorkSession())
                {
                    // Start a break session (5 minutes)
                    secondsRemaining = 5 * 60;
                    MessageBox.Show("Work session completed! Take a 5-minute break.", "Timer Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Start a work session (25 minutes)
                    secondsRemaining = 25 * 60;
                    MessageBox.Show("Break session completed! Start a new work session.", "Timer Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Restart the timer for the new session
                startTimer();
            }
        }

        // Handling the start button pressed
        private void startButton_Click(object sender, EventArgs e)
        {
            if (!isTimerRunning)
            {
                // Start the timer based on the current session and disable the button
                startTimer();
                startButton.Enabled = false;
                resetButton.Enabled = true;
                stopButton.Enabled = true;
            }
        }

        // Handling the reset button pressed
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Reset the timer to the initial work session (25 minutes)
            stopTimer();
            secondsRemaining = 25 * 60;
            updateTimeLabel();
            startButton.Enabled = true;
            resetButton.Enabled = false;
            stopButton.Enabled = false;
        }

        // Handling stop button pressed
        private void stopButton_Click(object sender, EventArgs e)
        {
            // Stop the timer
            stopTimer();
            startButton.Enabled = true;
            stopButton.Enabled = false;
            resetButton.Enabled = false;
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
