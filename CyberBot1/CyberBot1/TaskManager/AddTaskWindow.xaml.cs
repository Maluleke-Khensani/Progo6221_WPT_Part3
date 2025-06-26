using System;
using System.Windows;
using CyberBot1.Logging;

namespace CyberBot1.TaskManager
{
    // This window appears when the user clicks "Add Task"
    public partial class AddTaskWindow : Window
    {
        public TaskItem NewTask { get; private set; }

        public AddTaskWindow()
        {
            InitializeComponent();
        }

        // This method is called when the user clicks the "Back to Task Manager" button
        private void BackToTaskManager_Click(object sender, RoutedEventArgs e)
        {
             var taskManager = new TaskManagerWindow();
            taskManager.Show();
            this.Close();
        }

        // This method is called when the user clicks the "Add Task" button
        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            string name = TitleBox.Text.Trim();          // User input: title
            string description = DescriptionBox.Text.Trim();     // User input: description

            string reminder = "";

            if (ReminderPicker.SelectedDate != null)
            {
                string datePart = ReminderPicker.SelectedDate.Value.ToString("yyyy-MM-dd");
                string timePart = TimeBox.Text.Trim();

                if (!string.IsNullOrEmpty(timePart))
                {
                    reminder = $"{datePart} {timePart}";
                }
                else
                {
                    reminder = datePart;
                }
            }


            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a title for the task.", "Missing Info", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Create a new task object with user input
            NewTask = new TaskItem
            {
                Name = name,
                Description = description,
                ReminderDate = reminder,
                IsCompleted = false
            };

            // Logs the task creation
            ActivityLog.Add($"Task added: '{name}'");
            // If a reminder was set, log that too
            if (!string.IsNullOrEmpty(reminder))
            {
                ActivityLog.Add($"Reminder set for task '{name}' on {reminder}");
            }
           

            this.DialogResult = true;
        }
    }
}
