namespace ProductivityApplication
{
    partial class NewTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTask));
            this.createTaskButton = new System.Windows.Forms.Button();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.taskDueLabel = new System.Windows.Forms.Label();
            this.taskDueTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createTaskButton
            // 
            this.createTaskButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.createTaskButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.createTaskButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTaskButton.Location = new System.Drawing.Point(156, 183);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(220, 75);
            this.createTaskButton.TabIndex = 25;
            this.createTaskButton.Text = "Create Task";
            this.createTaskButton.UseVisualStyleBackColor = false;
            this.createTaskButton.Click += new System.EventHandler(this.createTaskButton_Click);
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameLabel.Location = new System.Drawing.Point(12, 9);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(163, 37);
            this.taskNameLabel.TabIndex = 26;
            this.taskNameLabel.Text = "Task Name:";
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameTextBox.Location = new System.Drawing.Point(19, 49);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(500, 43);
            this.taskNameTextBox.TabIndex = 27;
            // 
            // taskDueLabel
            // 
            this.taskDueLabel.AutoSize = true;
            this.taskDueLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDueLabel.Location = new System.Drawing.Point(12, 95);
            this.taskDueLabel.Name = "taskDueLabel";
            this.taskDueLabel.Size = new System.Drawing.Size(206, 37);
            this.taskDueLabel.TabIndex = 28;
            this.taskDueLabel.Text = "Task Due Date:";
            // 
            // taskDueTextBox
            // 
            this.taskDueTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDueTextBox.Location = new System.Drawing.Point(19, 135);
            this.taskDueTextBox.Name = "taskDueTextBox";
            this.taskDueTextBox.Size = new System.Drawing.Size(500, 43);
            this.taskDueTextBox.TabIndex = 29;
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 270);
            this.Controls.Add(this.taskDueTextBox);
            this.Controls.Add(this.taskDueLabel);
            this.Controls.Add(this.taskNameTextBox);
            this.Controls.Add(this.taskNameLabel);
            this.Controls.Add(this.createTaskButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myProductivity Create New Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTaskButton;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.Label taskDueLabel;
        private System.Windows.Forms.TextBox taskDueTextBox;
    }
}