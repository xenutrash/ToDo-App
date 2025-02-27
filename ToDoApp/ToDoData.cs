namespace ToDoApp
{
    [Serializable]
    public class ToDoData
    {
        public DateTime Created { get; private set; }
        public DateTime Updated { get; private set; }
        public string TaskName { get; private set; }

        private string _taskNote = "";
        public string TaskNote { get { return _taskNote; } set {
                _taskNote = value; Updated = DateTime.Now; } }

        public string TaskDescription { get; private set; }

        private bool isCompleted = false;

        // forces Updated to always be updated when isCompleted is 
        public bool IsCompleted { get { return isCompleted;  }
            set { Updated = DateTime.Now; isCompleted = value; }
        } 

        public ToDoData(string TaskName, string TaskDescription) {
            this.TaskDescription = TaskDescription; 
            this.TaskName = TaskName;
            Created = DateTime.Now;
            Updated = Created;
        }

        public override string ToString()
        {
            return
              TaskName;
        }

    }
}
