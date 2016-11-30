using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToDoList.Services;

namespace ToDoList.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TaskList MyList { get; set; } = new TaskList();

        public MainWindow()
        {
            InitializeComponent();
            
            this.listView.ItemsSource = MyList.Tasking;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var newTaskString = this.NewTaskBox.Text;
            MyList.AddItemToList(newTaskString);
            this.listView.Items.Refresh();
        }

        private void ItemButtonClicked(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var taskSelect = button.DataContext as Task;
            MyList.RemoveItemFromList(taskSelect);
            this.listView.Items.Refresh();

        }
    }
}
