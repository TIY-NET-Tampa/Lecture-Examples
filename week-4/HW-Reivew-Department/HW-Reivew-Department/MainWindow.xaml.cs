using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Review.Services;

namespace HW_Reivew_Department
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Department> Company { get; set; } = new List<Department>();
        public Department SelectedDepartment { get; set; }
        public MainWindow()
        {  
            InitializeComponent();
            this.Departments.ItemsSource = Company;
            this.CurrentDepartmentEmployees.ItemsSource = new List<Employee>();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // before
            SelectedDepartment.AddEmployee(
                this.EmployeeName.Text, 
                double.Parse(this.EmployeeSalary.Text), 
                this.EmployeePhone.Text, 
                this.EmployeeEmail.Text);
            this.CurrentDepartmentEmployees.Items.Refresh();
        }

        private void CreateDepartmentButton_Click(object sender, RoutedEventArgs e)
        {
            this.Company.Add(new Department(this.NewDeparmentName.Text));
            this.Departments.Items.Refresh();
        }

        private void SelectDepartmentButtonEvent(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            SelectedDepartment = button.DataContext as Department;
            this.SelectedDepartedName.Content = SelectedDepartment.Name;
            this.CurrentDepartmentEmployees.ItemsSource = SelectedDepartment.Employees;
        }
    }
}
