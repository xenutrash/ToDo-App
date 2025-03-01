using System.Diagnostics;
using Newtonsoft.Json; 

namespace ToDoApp
{
    public partial class MainWindow : Form
    {
        private ToDoData? SelectedData = null;
        private readonly string FileName = "Data.json";
        public MainWindow()
        {
            InitializeComponent();
            LoadItems();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            AddNewItem addNewItemDialog = new(this);
            addNewItemDialog.ShowDialog();
        }

        public void AddItemToUncompletedTasksList(Object ItemToAdd)
        {
            UncompletedTaskList.Items.Add(ItemToAdd);
            SaveItems();
        }

        private void UncompletedTaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayClickedItem(UncompletedTaskList);
        }

        private void CompletedTaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayClickedItem(CompletedTasksList);
        }

        private void DisplayClickedItem(ListBox Box)
        {
            if (Box.SelectedIndex < 0 || Box.SelectedIndex >= Box?.Items.Count)
            {
                return;
            }

            if (Box == null)
            {
                return;
            }

            if (Box?.Items[Box.SelectedIndex] is not ToDoData item)
            {
                return;
            }

            SelectedData = item;

            MarkAsCompletedButton.Text = SelectedData.IsCompleted ? "Mark as Uncompleted" : "Mark as Completed";

            SelectedTaskNoteBox.ReadOnly = false;
            DisplayItem(item);
        }


        private void DisplayNoItem()
        {
            SelectedTaskTime.Text = "";
            SelectedTaskDescription.Text = "";
            SelectedTaskName.Text = "";
            SelectedTaskNoteBox.Text = "";
            SelectedTaskNoteBox.ReadOnly = true;
        }

        private void DisplayItem(ToDoData Data)
        {
            SetDate(Data);
            SelectedTaskName.Text = Data.TaskName;
            SelectedTaskDescription.Text = Data.TaskDescription;
            SelectedTaskNoteBox.Text = Data.TaskNote;
        }

        private void SetDate(ToDoData Data)
        {
            SelectedTaskTime.Text = "Created: " + Data.Created.ToString() + " Updated: " + Data.Updated.ToString();
        }

        private void MarkedAsCompletedButton_Click(object sender, EventArgs e)
        {

            if (SelectedData == null)
            {
                return;
            }


            if (!SelectedData.IsCompleted)
            {
                MoveItemFromList(UncompletedTaskList, CompletedTasksList);
                SelectedData.IsCompleted = true;
                MarkAsCompletedButton.Text = "Mark as Uncompleted";
            }
            else
            {
                MoveItemFromList(CompletedTasksList, UncompletedTaskList);
                SelectedData.IsCompleted = false;
                MarkAsCompletedButton.Text = "Mark as Completed";
            }
            SetDate(SelectedData);
            SaveItems();

        }

        private void MoveItemFromList(ListBox From, ListBox To)
        {
            if (SelectedData == null)
            {
                return;
            }

            From?.Items.Remove(SelectedData);
            From?.Refresh();
            To.Items.Add(SelectedData);
            To?.Refresh();
            SelectedData.IsCompleted = true;
        }


        private void SaveItems()
        {
            List<ToDoData> list = [];

            if (UncompletedTaskList == null || CompletedTasksList == null)
            {
                return;
            }


            foreach (ToDoData toDo in UncompletedTaskList.Items)
            {
                list.Add(toDo);
            }

            foreach (ToDoData toDo in CompletedTasksList.Items)
            {
                list.Add(toDo);
            }

            if (list.Count < 1)
            {
                return;
            }

            var JsonObject = JsonConvert.SerializeObject(list);
            Debug.Print(JsonObject);

            using StreamWriter outputFile = new(GetDataFilePath());
            outputFile.WriteLine(JsonObject);
        }

        private void LoadItems()
        {

            String? line;
            string? JsonObject = "";
            if (!File.Exists(GetDataFilePath()))
            {
                Debug.Print("No data to load");
                return;
            }

            try
            {

                StreamReader sr = new(GetDataFilePath());
                if (sr == null)
                {
                    return;
                }

                line = sr.ReadLine();

                while (line != null)
                {
                    JsonObject += line;
                    line = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            if (String.IsNullOrEmpty(JsonObject))
            {
                return;
            }


            List<ToDoData>? items = JsonConvert.DeserializeObject<List<ToDoData>>(JsonObject);

            if (items == null)
            {
                return;
            }

            foreach (var item in items)
            {
                if (item == null)
                {
                    continue;
                }

                if (item.IsCompleted)
                {
                    CompletedTasksList.Items.Add(item);
                    continue;
                }

                UncompletedTaskList.Items.Add(item);
            }
        }

        public void SelectedTaskNoteBox_OnLostFocus(object sender, EventArgs e)
        {
            if (SelectedData == null)
            {
                return;
            }
            SelectedData.TaskNote = SelectedTaskNoteBox.Text;
            SaveItems();
        }

        private string GetDataFilePath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName);
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {

            if(SelectedData == null)
            {
                return; 
            }

            if (SelectedData.IsCompleted)
            {
                CompletedTasksList.Items.Remove(SelectedData);
            }
            else
            {
                UncompletedTaskList.Items.Remove(SelectedData); 
            }

            SaveItems();
            DisplayNoItem(); 

        }
    }
}
