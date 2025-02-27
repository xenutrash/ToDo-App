namespace ToDoApp
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            addTaskButton = new Button();
            SelectedTaskName = new TextBox();
            SelectedTaskDescription = new TextBox();
            SelectedTaskTime = new TextBox();
            MarkAsCompletedButton = new Button();
            UncompletedTaskList = new ListBox();
            CompletedTasksList = new ListBox();
            NoteName = new TextBox();
            SelectedTaskNoteBox = new TextBox();
            RemoveItemButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(2, 390);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(343, 23);
            textBox1.TabIndex = 101;
            textBox1.TabStop = false;
            textBox1.Text = "Completed";
            textBox1.UseWaitCursor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(2, 3);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(213, 23);
            textBox2.TabIndex = 100;
            textBox2.TabStop = false;
            textBox2.Text = "Uncompleted";
            textBox2.UseWaitCursor = true;
            // 
            // addTaskButton
            // 
            addTaskButton.Location = new Point(221, 2);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(124, 23);
            addTaskButton.TabIndex = 1;
            addTaskButton.Text = "Add New Task";
            addTaskButton.UseVisualStyleBackColor = true;
            addTaskButton.Click += AddTaskButton_Click;
            // 
            // SelectedTaskName
            // 
            SelectedTaskName.Location = new Point(393, 8);
            SelectedTaskName.Name = "SelectedTaskName";
            SelectedTaskName.ReadOnly = true;
            SelectedTaskName.Size = new Size(811, 23);
            SelectedTaskName.TabIndex = 104;
            SelectedTaskName.TabStop = false;
            // 
            // SelectedTaskDescription
            // 
            SelectedTaskDescription.ImeMode = ImeMode.Off;
            SelectedTaskDescription.Location = new Point(393, 37);
            SelectedTaskDescription.Multiline = true;
            SelectedTaskDescription.Name = "SelectedTaskDescription";
            SelectedTaskDescription.ReadOnly = true;
            SelectedTaskDescription.RightToLeft = RightToLeft.No;
            SelectedTaskDescription.Size = new Size(811, 441);
            SelectedTaskDescription.TabIndex = 1006;
            SelectedTaskDescription.TabStop = false;
            // 
            // SelectedTaskTime
            // 
            SelectedTaskTime.Location = new Point(393, 725);
            SelectedTaskTime.Name = "SelectedTaskTime";
            SelectedTaskTime.ReadOnly = true;
            SelectedTaskTime.Size = new Size(509, 23);
            SelectedTaskTime.TabIndex = 108;
            SelectedTaskTime.TabStop = false;
            SelectedTaskTime.Text = " ";
            // 
            // MarkAsCompletedButton
            // 
            MarkAsCompletedButton.Location = new Point(1060, 725);
            MarkAsCompletedButton.Name = "MarkAsCompletedButton";
            MarkAsCompletedButton.Size = new Size(144, 24);
            MarkAsCompletedButton.TabIndex = 5;
            MarkAsCompletedButton.Text = "Mark as completed";
            MarkAsCompletedButton.UseVisualStyleBackColor = true;
            MarkAsCompletedButton.Click += MarkedAsCompletedButton_Click;
            // 
            // UncompletedTaskList
            // 
            UncompletedTaskList.FormattingEnabled = true;
            UncompletedTaskList.ItemHeight = 15;
            UncompletedTaskList.Location = new Point(2, 32);
            UncompletedTaskList.Name = "UncompletedTaskList";
            UncompletedTaskList.Size = new Size(343, 349);
            UncompletedTaskList.TabIndex = 2;
            UncompletedTaskList.SelectedIndexChanged += UncompletedTaskList_SelectedIndexChanged;
            // 
            // CompletedTasksList
            // 
            CompletedTasksList.FormattingEnabled = true;
            CompletedTasksList.ItemHeight = 15;
            CompletedTasksList.Location = new Point(3, 414);
            CompletedTasksList.Name = "CompletedTasksList";
            CompletedTasksList.Size = new Size(342, 334);
            CompletedTasksList.TabIndex = 3;
            CompletedTasksList.SelectedIndexChanged += CompletedTaskList_SelectedIndexChanged;
            // 
            // NoteName
            // 
            NoteName.Location = new Point(393, 484);
            NoteName.Name = "NoteName";
            NoteName.ReadOnly = true;
            NoteName.Size = new Size(811, 23);
            NoteName.TabIndex = 1007;
            NoteName.TabStop = false;
            NoteName.Text = "Notes";
            // 
            // SelectedTaskNoteBox
            // 
            SelectedTaskNoteBox.ImeMode = ImeMode.Off;
            SelectedTaskNoteBox.Location = new Point(393, 513);
            SelectedTaskNoteBox.Multiline = true;
            SelectedTaskNoteBox.Name = "SelectedTaskNoteBox";
            SelectedTaskNoteBox.ReadOnly = true;
            SelectedTaskNoteBox.RightToLeft = RightToLeft.No;
            SelectedTaskNoteBox.Size = new Size(811, 206);
            SelectedTaskNoteBox.TabIndex = 4;
            SelectedTaskNoteBox.LostFocus += SelectedTaskNoteBox_OnLostFocus;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Location = new Point(908, 725);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(144, 24);
            RemoveItemButton.TabIndex = 1008;
            RemoveItemButton.Text = "Delete Task";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 758);
            Controls.Add(RemoveItemButton);
            Controls.Add(SelectedTaskNoteBox);
            Controls.Add(NoteName);
            Controls.Add(CompletedTasksList);
            Controls.Add(UncompletedTaskList);
            Controls.Add(MarkAsCompletedButton);
            Controls.Add(SelectedTaskTime);
            Controls.Add(SelectedTaskName);
            Controls.Add(SelectedTaskDescription);
            Controls.Add(addTaskButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "MainWindow";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Button addTaskButton;
        private TextBox SelectedTaskName;
        private TextBox SelectedTaskDescription;
        private TextBox SelectedTaskTime;
        private Button MarkAsCompletedButton;
        private ListBox UncompletedTaskList;
        private ListBox CompletedTasksList;
        private TextBox NoteName;
        private TextBox SelectedTaskNoteBox;
        private Button RemoveItemButton;
    }
}
