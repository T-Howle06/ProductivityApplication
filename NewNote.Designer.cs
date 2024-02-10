namespace ProductivityApplication
{
    partial class NewNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewNote));
            this.noteNameLabel = new System.Windows.Forms.Label();
            this.noteNameTextBox = new System.Windows.Forms.TextBox();
            this.noteSubjectLabel = new System.Windows.Forms.Label();
            this.noteSubjectTextBox = new System.Windows.Forms.TextBox();
            this.noteContentsLabel = new System.Windows.Forms.Label();
            this.noteContentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.createNoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noteNameLabel
            // 
            this.noteNameLabel.AutoSize = true;
            this.noteNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteNameLabel.Location = new System.Drawing.Point(12, 9);
            this.noteNameLabel.Name = "noteNameLabel";
            this.noteNameLabel.Size = new System.Drawing.Size(171, 37);
            this.noteNameLabel.TabIndex = 27;
            this.noteNameLabel.Text = "Note Name:";
            // 
            // noteNameTextBox
            // 
            this.noteNameTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteNameTextBox.Location = new System.Drawing.Point(19, 49);
            this.noteNameTextBox.Name = "noteNameTextBox";
            this.noteNameTextBox.Size = new System.Drawing.Size(500, 43);
            this.noteNameTextBox.TabIndex = 28;
            // 
            // noteSubjectLabel
            // 
            this.noteSubjectLabel.AutoSize = true;
            this.noteSubjectLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteSubjectLabel.Location = new System.Drawing.Point(12, 95);
            this.noteSubjectLabel.Name = "noteSubjectLabel";
            this.noteSubjectLabel.Size = new System.Drawing.Size(190, 37);
            this.noteSubjectLabel.TabIndex = 29;
            this.noteSubjectLabel.Text = "Note Subject:";
            // 
            // noteSubjectTextBox
            // 
            this.noteSubjectTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteSubjectTextBox.Location = new System.Drawing.Point(19, 135);
            this.noteSubjectTextBox.Name = "noteSubjectTextBox";
            this.noteSubjectTextBox.Size = new System.Drawing.Size(500, 43);
            this.noteSubjectTextBox.TabIndex = 30;
            // 
            // noteContentsLabel
            // 
            this.noteContentsLabel.AutoSize = true;
            this.noteContentsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteContentsLabel.Location = new System.Drawing.Point(12, 181);
            this.noteContentsLabel.Name = "noteContentsLabel";
            this.noteContentsLabel.Size = new System.Drawing.Size(210, 37);
            this.noteContentsLabel.TabIndex = 31;
            this.noteContentsLabel.Text = "Note Contents:";
            // 
            // noteContentsRichTextBox
            // 
            this.noteContentsRichTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteContentsRichTextBox.Location = new System.Drawing.Point(19, 221);
            this.noteContentsRichTextBox.Name = "noteContentsRichTextBox";
            this.noteContentsRichTextBox.Size = new System.Drawing.Size(500, 278);
            this.noteContentsRichTextBox.TabIndex = 32;
            this.noteContentsRichTextBox.Text = "";
            // 
            // createNoteButton
            // 
            this.createNoteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.createNoteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.createNoteButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNoteButton.Location = new System.Drawing.Point(19, 505);
            this.createNoteButton.Name = "createNoteButton";
            this.createNoteButton.Size = new System.Drawing.Size(500, 75);
            this.createNoteButton.TabIndex = 33;
            this.createNoteButton.Text = "Create Note";
            this.createNoteButton.UseVisualStyleBackColor = false;
            this.createNoteButton.Click += new System.EventHandler(this.createNoteButton_Click);
            // 
            // NewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 586);
            this.Controls.Add(this.createNoteButton);
            this.Controls.Add(this.noteContentsRichTextBox);
            this.Controls.Add(this.noteContentsLabel);
            this.Controls.Add(this.noteSubjectTextBox);
            this.Controls.Add(this.noteSubjectLabel);
            this.Controls.Add(this.noteNameTextBox);
            this.Controls.Add(this.noteNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myProductivity Create New Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noteNameLabel;
        private System.Windows.Forms.TextBox noteNameTextBox;
        private System.Windows.Forms.Label noteSubjectLabel;
        private System.Windows.Forms.TextBox noteSubjectTextBox;
        private System.Windows.Forms.Label noteContentsLabel;
        private System.Windows.Forms.RichTextBox noteContentsRichTextBox;
        private System.Windows.Forms.Button createNoteButton;
    }
}