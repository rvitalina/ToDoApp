namespace ToDoApp.Models
{
    public class ToDoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsImportant { get; set; }
    }
}
