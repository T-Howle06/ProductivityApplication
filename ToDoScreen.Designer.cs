namespace ProductivityApplication
{
    partial class ToDoScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoScreen));
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.todoListLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.currentTasksListBox = new System.Windows.Forms.ListBox();
            this.currentTasksLabel = new System.Windows.Forms.Label();
            this.completedTasksListBox = new System.Windows.Forms.ListBox();
            this.completedTaskslabel = new System.Windows.Forms.Label();
            this.newTaskButton = new System.Windows.Forms.Button();
            this.setCompletedButton = new System.Windows.Forms.Button();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.setCurrentButton = new System.Windows.Forms.Button();
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
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProductivityApplication.Properties.Resources.mP_longBlack;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // todoListLabel
            // 
            this.todoListLabel.AutoSize = true;
            this.todoListLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoListLabel.Location = new System.Drawing.Point(518, 43);
            this.todoListLabel.Name = "todoListLabel";
            this.todoListLabel.Size = new System.Drawing.Size(256, 65);
            this.todoListLabel.TabIndex = 13;
            this.todoListLabel.Text = "To-Do List";
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
            // currentTasksListBox
            // 
            this.currentTasksListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTasksListBox.FormattingEnabled = true;
            this.currentTasksListBox.ItemHeight = 25;
            this.currentTasksListBox.Location = new System.Drawing.Point(12, 183);
            this.currentTasksListBox.Name = "currentTasksListBox";
            this.currentTasksListBox.Size = new System.Drawing.Size(500, 329);
            this.currentTasksListBox.TabIndex = 19;
            // 
            // currentTasksLabel
            // 
            this.currentTasksLabel.AutoSize = true;
            this.currentTasksLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTasksLabel.Location = new System.Drawing.Point(5, 143);
            this.currentTasksLabel.Name = "currentTasksLabel";
            this.currentTasksLabel.Size = new System.Drawing.Size(196, 37);
            this.currentTasksLabel.TabIndex = 20;
            this.currentTasksLabel.Text = "Current Tasks:";
            // 
            // completedTasksListBox
            // 
            this.completedTasksListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.completedTasksListBox.FormattingEnabled = true;
            this.completedTasksListBox.ItemHeight = 25;
            this.completedTasksListBox.Location = new System.Drawing.Point(552, 183);
            this.completedTasksListBox.Name = "completedTasksListBox";
            this.completedTasksListBox.Size = new System.Drawing.Size(500, 329);
            this.completedTasksListBox.TabIndex = 21;
            // 
            // completedTaskslabel
            // 
            this.completedTaskslabel.AutoSize = true;
            this.completedTaskslabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedTaskslabel.Location = new System.Drawing.Point(545, 143);
            this.completedTaskslabel.Name = "completedTaskslabel";
            this.completedTaskslabel.Size = new System.Drawing.Size(358, 37);
            this.completedTaskslabel.TabIndex = 22;
            this.completedTaskslabel.Text = "Recently Completed Tasks:";
            // 
            // newTaskButton
            // 
            this.newTaskButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newTaskButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.newTaskButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTaskButton.Location = new System.Drawing.Point(12, 513);
            this.newTaskButton.Name = "newTaskButton";
            this.newTaskButton.Size = new System.Drawing.Size(220, 75);
            this.newTaskButton.TabIndex = 23;
            this.newTaskButton.Text = "Add New Task";
            this.newTaskButton.UseVisualStyleBackColor = false;
            this.newTaskButton.Click += new System.EventHandler(this.newTaskButton_Click);
            // 
            // setCompletedButton
            // 
            this.setCompletedButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.setCompletedButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.setCompletedButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setCompletedButton.Location = new System.Drawing.Point(292, 513);
            this.setCompletedButton.Name = "setCompletedButton";
            this.setCompletedButton.Size = new System.Drawing.Size(220, 75);
            this.setCompletedButton.TabIndex = 24;
            this.setCompletedButton.Text = "Set Completed";
            this.setCompletedButton.UseVisualStyleBackColor = false;
            this.setCompletedButton.Click += new System.EventHandler(this.setCompletedButton_Click);
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteTaskButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deleteTaskButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTaskButton.Location = new System.Drawing.Point(832, 513);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(220, 75);
            this.deleteTaskButton.TabIndex = 26;
            this.deleteTaskButton.Text = "Delete Task";
            this.deleteTaskButton.UseVisualStyleBackColor = false;
            this.deleteTaskButton.Click += new System.EventHandler(this.deleteTaskButton_Click);
            // 
            // setCurrentButton
            // 
            this.setCurrentButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.setCurrentButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.setCurrentButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setCurrentButton.Location = new System.Drawing.Point(552, 513);
            this.setCurrentButton.Name = "setCurrentButton";
            this.setCurrentButton.Size = new System.Drawing.Size(220, 75);
            this.setCurrentButton.TabIndex = 27;
            this.setCurrentButton.Text = "Set Current";
            this.setCurrentButton.UseVisualStyleBackColor = false;
            this.setCurrentButton.Click += new System.EventHandler(this.setCurrentButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.refreshButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(292, 145);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(220, 35);
            this.refreshButton.TabIndex = 29;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // ToDoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.setCurrentButton);
            this.Controls.Add(this.deleteTaskButton);
            this.Controls.Add(this.setCompletedButton);
            this.Controls.Add(this.newTaskButton);
            this.Controls.Add(this.completedTaskslabel);
            this.Controls.Add(this.completedTasksListBox);
            this.Controls.Add(this.currentTasksLabel);
            this.Controls.Add(this.currentTasksListBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.todoListLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToDoScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myProductivity To-Do List";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label todoListLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox currentTasksListBox;
        private System.Windows.Forms.Label currentTasksLabel;
        private System.Windows.Forms.ListBox completedTasksListBox;
        private System.Windows.Forms.Label completedTaskslabel;
        private System.Windows.Forms.Button newTaskButton;
        private System.Windows.Forms.Button setCompletedButton;
        private System.Windows.Forms.Button deleteTaskButton;
        private System.Windows.Forms.Button setCurrentButton;
        private System.Windows.Forms.Button refreshButton;
    }
}