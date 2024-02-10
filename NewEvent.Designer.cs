namespace ProductivityApplication
{
    partial class NewEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEvent));
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.eventSubjectLabel = new System.Windows.Forms.Label();
            this.eventSubjectTextBox = new System.Windows.Forms.TextBox();
            this.eventStartLabel = new System.Windows.Forms.Label();
            this.eventStartTextBox = new System.Windows.Forms.TextBox();
            this.eventEndLabel = new System.Windows.Forms.Label();
            this.eventEndTextBox = new System.Windows.Forms.TextBox();
            this.eventDayLabel = new System.Windows.Forms.Label();
            this.eventDayListBox = new System.Windows.Forms.ListBox();
            this.createEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.Location = new System.Drawing.Point(12, 9);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(178, 37);
            this.eventNameLabel.TabIndex = 28;
            this.eventNameLabel.Text = "Event Name:";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameTextBox.Location = new System.Drawing.Point(19, 49);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(500, 43);
            this.eventNameTextBox.TabIndex = 29;
            // 
            // eventSubjectLabel
            // 
            this.eventSubjectLabel.AutoSize = true;
            this.eventSubjectLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventSubjectLabel.Location = new System.Drawing.Point(12, 95);
            this.eventSubjectLabel.Name = "eventSubjectLabel";
            this.eventSubjectLabel.Size = new System.Drawing.Size(197, 37);
            this.eventSubjectLabel.TabIndex = 30;
            this.eventSubjectLabel.Text = "Event Subject:";
            // 
            // eventSubjectTextBox
            // 
            this.eventSubjectTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventSubjectTextBox.Location = new System.Drawing.Point(19, 135);
            this.eventSubjectTextBox.Name = "eventSubjectTextBox";
            this.eventSubjectTextBox.Size = new System.Drawing.Size(500, 43);
            this.eventSubjectTextBox.TabIndex = 31;
            // 
            // eventStartLabel
            // 
            this.eventStartLabel.AutoSize = true;
            this.eventStartLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventStartLabel.Location = new System.Drawing.Point(12, 181);
            this.eventStartLabel.Name = "eventStartLabel";
            this.eventStartLabel.Size = new System.Drawing.Size(165, 37);
            this.eventStartLabel.TabIndex = 32;
            this.eventStartLabel.Text = "Event Start:";
            // 
            // eventStartTextBox
            // 
            this.eventStartTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventStartTextBox.Location = new System.Drawing.Point(19, 221);
            this.eventStartTextBox.Name = "eventStartTextBox";
            this.eventStartTextBox.Size = new System.Drawing.Size(500, 43);
            this.eventStartTextBox.TabIndex = 33;
            // 
            // eventEndLabel
            // 
            this.eventEndLabel.AutoSize = true;
            this.eventEndLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventEndLabel.Location = new System.Drawing.Point(12, 267);
            this.eventEndLabel.Name = "eventEndLabel";
            this.eventEndLabel.Size = new System.Drawing.Size(149, 37);
            this.eventEndLabel.TabIndex = 34;
            this.eventEndLabel.Text = "Event End:";
            // 
            // eventEndTextBox
            // 
            this.eventEndTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventEndTextBox.Location = new System.Drawing.Point(19, 307);
            this.eventEndTextBox.Name = "eventEndTextBox";
            this.eventEndTextBox.Size = new System.Drawing.Size(500, 43);
            this.eventEndTextBox.TabIndex = 35;
            // 
            // eventDayLabel
            // 
            this.eventDayLabel.AutoSize = true;
            this.eventDayLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDayLabel.Location = new System.Drawing.Point(12, 353);
            this.eventDayLabel.Name = "eventDayLabel";
            this.eventDayLabel.Size = new System.Drawing.Size(152, 37);
            this.eventDayLabel.TabIndex = 37;
            this.eventDayLabel.Text = "Event Day:";
            // 
            // eventDayListBox
            // 
            this.eventDayListBox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.eventDayListBox.FormattingEnabled = true;
            this.eventDayListBox.ItemHeight = 37;
            this.eventDayListBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.eventDayListBox.Location = new System.Drawing.Point(19, 393);
            this.eventDayListBox.Name = "eventDayListBox";
            this.eventDayListBox.Size = new System.Drawing.Size(500, 41);
            this.eventDayListBox.TabIndex = 38;
            // 
            // createEventButton
            // 
            this.createEventButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.createEventButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.createEventButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEventButton.Location = new System.Drawing.Point(19, 440);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(500, 75);
            this.createEventButton.TabIndex = 39;
            this.createEventButton.Text = "Create Event";
            this.createEventButton.UseVisualStyleBackColor = false;
            this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);
            // 
            // NewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 536);
            this.Controls.Add(this.createEventButton);
            this.Controls.Add(this.eventDayListBox);
            this.Controls.Add(this.eventDayLabel);
            this.Controls.Add(this.eventEndTextBox);
            this.Controls.Add(this.eventEndLabel);
            this.Controls.Add(this.eventStartTextBox);
            this.Controls.Add(this.eventStartLabel);
            this.Controls.Add(this.eventSubjectTextBox);
            this.Controls.Add(this.eventSubjectLabel);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.eventNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myProductivity Create New Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Label eventSubjectLabel;
        private System.Windows.Forms.TextBox eventSubjectTextBox;
        private System.Windows.Forms.Label eventStartLabel;
        private System.Windows.Forms.TextBox eventStartTextBox;
        private System.Windows.Forms.Label eventEndLabel;
        private System.Windows.Forms.TextBox eventEndTextBox;
        private System.Windows.Forms.Label eventDayLabel;
        private System.Windows.Forms.ListBox eventDayListBox;
        private System.Windows.Forms.Button createEventButton;
    }
}