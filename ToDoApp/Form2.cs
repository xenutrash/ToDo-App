
namespace ToDoApp
{
    public partial class AddNewItem : Form
    {
        private MainWindow _mainWindow;
        public AddNewItem(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(nameOfTaskInputBox.Text))
            {
                return;
            }

            if (string.IsNullOrEmpty(taskDescriptionInputBox.Text))
            {
                return;
            }

            ToDoData ItemToAdd = new(nameOfTaskInputBox.Text, taskDescriptionInputBox.Text);

            if (ItemToAdd == null)
            {
                return;
            }

            _mainWindow.AddItemToUncompletedTasksList(ItemToAdd);
            taskDescriptionInputBox.Text = "";
            nameOfTaskInputBox.Text = ""; 
            this.Close();
        }
    }
}
