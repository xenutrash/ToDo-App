namespace ToDoApp
{
    partial class AddNewItem
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
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            taskDescriptionInputBox = new TextBox();
            nameOfTaskInputBox = new TextBox();
            AddTaskButton = new Button();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 2);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(383, 23);
            textBox6.TabIndex = 13;
            textBox6.TabStop = false;
            textBox6.Text = "Name of Task";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 63);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(383, 23);
            textBox5.TabIndex = 12;
            textBox5.TabStop = false;
            textBox5.Text = "Description of Task";
            // 
            // taskDescriptionInputBox
            // 
            taskDescriptionInputBox.Location = new Point(12, 92);
            taskDescriptionInputBox.Multiline = true;
            taskDescriptionInputBox.Name = "taskDescriptionInputBox";
            taskDescriptionInputBox.PlaceholderText = "desciption of task";
            taskDescriptionInputBox.RightToLeft = RightToLeft.No;
            taskDescriptionInputBox.Size = new Size(383, 230);
            taskDescriptionInputBox.TabIndex = 2;
            // 
            // nameOfTaskInputBox
            // 
            nameOfTaskInputBox.Location = new Point(12, 34);
            nameOfTaskInputBox.Name = "nameOfTaskInputBox";
            nameOfTaskInputBox.PlaceholderText = "name of task";
            nameOfTaskInputBox.Size = new Size(383, 23);
            nameOfTaskInputBox.TabIndex = 1;
            // 
            // AddTaskButton
            // 
            AddTaskButton.Location = new Point(12, 328);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(99, 23);
            AddTaskButton.TabIndex = 3;
            AddTaskButton.Text = "Add Item";
            AddTaskButton.UseVisualStyleBackColor = true;
            AddTaskButton.Click += AddTaskButton_Click;
            // 
            // AddNewItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 369);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(taskDescriptionInputBox);
            Controls.Add(nameOfTaskInputBox);
            Controls.Add(AddTaskButton);
            Name = "AddNewItem";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox taskDescriptionInputBox;
        private TextBox nameOfTaskInputBox;
        private Button AddTaskButton;
    }
}