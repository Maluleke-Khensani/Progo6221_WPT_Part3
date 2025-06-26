namespace CyberBot1.TaskManager
{
    public class TaskItem
    {
        // This class represents one task item in the list
        public string Name { get; set; }            // The title of the task
        public string Description { get; set; }     // A short description of what the task is about
        public string ReminderDate { get; set; }    // The date/time the user wants to be reminded
        public bool IsCompleted { get; set; }       // Whether the task is done or not

        // This combines the name and completed status to show in the UI

        public string DisplayText
        {
            get
            {
                string baseText = IsCompleted ? $"✔️ {Name} - {Description}" : $"{Name} - {Description}";
                return !string.IsNullOrWhiteSpace(ReminderDate) ? $"{baseText} ⏰ {ReminderDate}" : baseText;
            }
        }
    }
}
