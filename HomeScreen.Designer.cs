namespace ProductivityApplication
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.todoButton = new System.Windows.Forms.Button();
            this.notesButton = new System.Windows.Forms.Button();
            this.timerButton = new System.Windows.Forms.Button();
            this.timetableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProductivityApplication.Properties.Resources.mP_longBlack;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(12, 438);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(500, 67);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // todoButton
            // 
            this.todoButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.todoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.todoButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoButton.Location = new System.Drawing.Point(12, 146);
            this.todoButton.Name = "todoButton";
            this.todoButton.Size = new System.Drawing.Size(500, 67);
            this.todoButton.TabIndex = 11;
            this.todoButton.Text = "To-Do List";
            this.todoButton.UseVisualStyleBackColor = false;
            this.todoButton.Click += new System.EventHandler(this.todoButton_Click);
            // 
            // notesButton
            // 
            this.notesButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.notesButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.notesButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesButton.Location = new System.Drawing.Point(12, 219);
            this.notesButton.Name = "notesButton";
            this.notesButton.Size = new System.Drawing.Size(500, 67);
            this.notesButton.TabIndex = 12;
            this.notesButton.Text = "Notes";
            this.notesButton.UseVisualStyleBackColor = false;
            this.notesButton.Click += new System.EventHandler(this.notesButton_Click);
            // 
            // timerButton
            // 
            this.timerButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.timerButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.timerButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerButton.Location = new System.Drawing.Point(12, 292);
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(500, 67);
            this.timerButton.TabIndex = 13;
            this.timerButton.Text = "Focus Timer";
            this.timerButton.UseVisualStyleBackColor = false;
            this.timerButton.Click += new System.EventHandler(this.timerButton_Click);
            // 
            // timetableButton
            // 
            this.timetableButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.timetableButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.timetableButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetableButton.Location = new System.Drawing.Point(12, 365);
            this.timetableButton.Name = "timetableButton";
            this.timetableButton.Size = new System.Drawing.Size(500, 67);
            this.timetableButton.TabIndex = 14;
            this.timetableButton.Text = "Timetable";
            this.timetableButton.UseVisualStyleBackColor = false;
            this.timetableButton.Click += new System.EventHandler(this.timetableButton_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(529, 511);
            this.Controls.Add(this.timetableButton);
            this.Controls.Add(this.timerButton);
            this.Controls.Add(this.notesButton);
            this.Controls.Add(this.todoButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myProductivity Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button todoButton;
        private System.Windows.Forms.Button notesButton;
        private System.Windows.Forms.Button timerButton;
        private System.Windows.Forms.Button timetableButton;
    }
}