using System.Collections.ObjectModel;
using System.Windows;
using CyberBot1.Logging;

namespace CyberBot1.TaskManager
{
    // This window manages the list of tasks (add, delete, complete)

    public partial class TaskManagerWindow : Window
    {
        public ObservableCollection<TaskItem> Tasks { get; set; } = new ObservableCollection<TaskItem>();

        public TaskManagerWindow()
        {
            InitializeComponent();
            this.DataContext = this;  // binds the DataContext to this window
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            main.Show();
            this.Close();
        }

        // This method is called when the user clicks the "Add Task" button
        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            AddTaskWindow window = new AddTaskWindow();
            bool? result = window.ShowDialog();

            if (result == true && window.NewTask != null)
            {
                Tasks.Add(window.NewTask);

                // after adding to the collection
                ActivityLog.Add($"Task added: '{window.NewTask.Name}'");

            }

        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (TaskListBox.SelectedItem is TaskItem selected)
            {
                Tasks.Remove(selected);

                ActivityLog.Add($"Task deleted: '{selected.Name}'");

            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "No Task Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void CompleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (TaskListBox.SelectedItem is TaskItem selected)
            {
                selected.IsCompleted = true;
                TaskListBox.Items.Refresh(); // updates DisplayText
                
                ActivityLog.Add($"Task completed: '{selected.Name}'");
            }




            else
            {
                MessageBox.Show("Please select a task to mark as completed.", "No Task Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
