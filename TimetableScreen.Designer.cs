namespace ProductivityApplication
{
    partial class TimetableScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimetableScreen));
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.mondayButton = new System.Windows.Forms.Button();
            this.tuesdayButton = new System.Windows.Forms.Button();
            this.wednesdayButton = new System.Windows.Forms.Button();
            this.thursdayButton = new System.Windows.Forms.Button();
            this.fridayButton = new System.Windows.Forms.Button();
            this.eventListBox = new System.Windows.Forms.ListBox();
            this.createEventButton = new System.Windows.Forms.Button();
            this.deleteEventButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(927, 594);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 75);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 65);
            this.label1.TabIndex = 15;
            this.label1.Text = "Timetable";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProductivityApplication.Properties.Resources.mP_longBlack;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 594);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 75);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // mondayButton
            // 
            this.mondayButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mondayButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mondayButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mondayButton.Location = new System.Drawing.Point(12, 146);
            this.mondayButton.Name = "mondayButton";
            this.mondayButton.Size = new System.Drawing.Size(175, 50);
            this.mondayButton.TabIndex = 17;
            this.mondayButton.Text = "Monday";
            this.mondayButton.UseVisualStyleBackColor = false;
            this.mondayButton.Click += new System.EventHandler(this.mondayButton_Click);
            // 
            // tuesdayButton
            // 
            this.tuesdayButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tuesdayButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tuesdayButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesdayButton.Location = new System.Drawing.Point(228, 146);
            this.tuesdayButton.Name = "tuesdayButton";
            this.tuesdayButton.Size = new System.Drawing.Size(175, 50);
            this.tuesdayButton.TabIndex = 18;
            this.tuesdayButton.Text = "Tuesday";
            this.tuesdayButton.UseVisualStyleBackColor = false;
            this.tuesdayButton.Click += new System.EventHandler(this.tuesdayButton_Click);
            // 
            // wednesdayButton
            // 
            this.wednesdayButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.wednesdayButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.wednesdayButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesdayButton.Location = new System.Drawing.Point(444, 146);
            this.wednesdayButton.Name = "wednesdayButton";
            this.wednesdayButton.Size = new System.Drawing.Size(175, 50);
            this.wednesdayButton.TabIndex = 19;
            this.wednesdayButton.Text = "Wednesday";
            this.wednesdayButton.UseVisualStyleBackColor = false;
            this.wednesdayButton.Click += new System.EventHandler(this.wednesdayButton_Click);
            // 
            // thursdayButton
            // 
            this.thursdayButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.thursdayButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.thursdayButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursdayButton.Location = new System.Drawing.Point(660, 146);
            this.thursdayButton.Name = "thursdayButton";
            this.thursdayButton.Size = new System.Drawing.Size(175, 50);
            this.thursdayButton.TabIndex = 20;
            this.thursdayButton.Text = "Thursday";
            this.thursdayButton.UseVisualStyleBackColor = false;
            this.thursdayButton.Click += new System.EventHandler(this.thursdayButton_Click);
            // 
            // fridayButton
            // 
            this.fridayButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fridayButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fridayButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fridayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fridayButton.Location = new System.Drawing.Point(877, 146);
            this.fridayButton.Name = "fridayButton";
            this.fridayButton.Size = new System.Drawing.Size(175, 50);
            this.fridayButton.TabIndex = 21;
            this.fridayButton.Text = "Friday";
            this.fridayButton.UseVisualStyleBackColor = false;
            this.fridayButton.Click += new System.EventHandler(this.fridayButton_Click);
            // 
            // eventListBox
            // 
            this.eventListBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.ItemHeight = 30;
            this.eventListBox.Location = new System.Drawing.Point(12, 202);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(1040, 364);
            this.eventListBox.TabIndex = 22;
            // 
            // createEventButton
            // 
            this.createEventButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.createEventButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.createEventButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEventButton.Location = new System.Drawing.Point(143, 594);
            this.createEventButton.Name = "createEventButton";
            this.createEventButton.Size = new System.Drawing.Size(220, 75);
            this.createEventButton.TabIndex = 26;
            this.createEventButton.Text = "Create New Event";
            this.createEventButton.UseVisualStyleBackColor = false;
            this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteEventButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deleteEventButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEventButton.Location = new System.Drawing.Point(369, 594);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(220, 75);
            this.deleteEventButton.TabIndex = 27;
            this.deleteEventButton.Text = "Delete Selected Event";
            this.deleteEventButton.UseVisualStyleBackColor = false;
            this.deleteEventButton.Click += new System.EventHandler(this.deleteEventButton_Click);
            // 
            // TimetableScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.deleteEventButton);
            this.Controls.Add(this.createEventButton);
            this.Controls.Add(this.eventListBox);
            this.Controls.Add(this.fridayButton);
            this.Controls.Add(this.thursdayButton);
            this.Controls.Add(this.wednesdayButton);
            this.Controls.Add(this.tuesdayButton);
            this.Controls.Add(this.mondayButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimetableScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myProductivity Timetable";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button mondayButton;
        private System.Windows.Forms.Button tuesdayButton;
        private System.Windows.Forms.Button wednesdayButton;
        private System.Windows.Forms.Button thursdayButton;
        private System.Windows.Forms.Button fridayButton;
        private System.Windows.Forms.ListBox eventListBox;
        private System.Windows.Forms.Button createEventButton;
        private System.Windows.Forms.Button deleteEventButton;
    }
}