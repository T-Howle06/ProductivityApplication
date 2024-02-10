namespace ProductivityApplication
{
    partial class NotesScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesScreen));
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.notesListBox = new System.Windows.Forms.ListBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.viewNoteButton = new System.Windows.Forms.Button();
            this.createNoteButton = new System.Windows.Forms.Button();
            this.deleteNoteButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(161, 65);
            this.label1.TabIndex = 15;
            this.label1.Text = "Notes";
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
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // notesListBox
            // 
            this.notesListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.notesListBox.FormattingEnabled = true;
            this.notesListBox.ItemHeight = 25;
            this.notesListBox.Location = new System.Drawing.Point(12, 183);
            this.notesListBox.Name = "notesListBox";
            this.notesListBox.Size = new System.Drawing.Size(1040, 329);
            this.notesListBox.TabIndex = 19;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(12, 143);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(100, 37);
            this.notesLabel.TabIndex = 21;
            this.notesLabel.Text = "Notes:";
            // 
            // viewNoteButton
            // 
            this.viewNoteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.viewNoteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.viewNoteButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewNoteButton.Location = new System.Drawing.Point(238, 518);
            this.viewNoteButton.Name = "viewNoteButton";
            this.viewNoteButton.Size = new System.Drawing.Size(220, 75);
            this.viewNoteButton.TabIndex = 24;
            this.viewNoteButton.Text = "View Selected Note";
            this.viewNoteButton.UseVisualStyleBackColor = false;
            this.viewNoteButton.Click += new System.EventHandler(this.viewNoteButton_Click);
            // 
            // createNoteButton
            // 
            this.createNoteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.createNoteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.createNoteButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNoteButton.Location = new System.Drawing.Point(12, 518);
            this.createNoteButton.Name = "createNoteButton";
            this.createNoteButton.Size = new System.Drawing.Size(220, 75);
            this.createNoteButton.TabIndex = 25;
            this.createNoteButton.Text = "Create New Note";
            this.createNoteButton.UseVisualStyleBackColor = false;
            this.createNoteButton.Click += new System.EventHandler(this.createNoteButton_Click);
            // 
            // deleteNoteButton
            // 
            this.deleteNoteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteNoteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deleteNoteButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteNoteButton.Location = new System.Drawing.Point(464, 518);
            this.deleteNoteButton.Name = "deleteNoteButton";
            this.deleteNoteButton.Size = new System.Drawing.Size(220, 75);
            this.deleteNoteButton.TabIndex = 26;
            this.deleteNoteButton.Text = "Delete Selected Note";
            this.deleteNoteButton.UseVisualStyleBackColor = false;
            this.deleteNoteButton.Click += new System.EventHandler(this.deleteNoteButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.refreshButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(832, 142);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(220, 35);
            this.refreshButton.TabIndex = 30;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // NotesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.deleteNoteButton);
            this.Controls.Add(this.createNoteButton);
            this.Controls.Add(this.viewNoteButton);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.notesListBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myProductivity Notes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox notesListBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Button viewNoteButton;
        private System.Windows.Forms.Button createNoteButton;
        private System.Windows.Forms.Button deleteNoteButton;
        private System.Windows.Forms.Button refreshButton;
    }
}