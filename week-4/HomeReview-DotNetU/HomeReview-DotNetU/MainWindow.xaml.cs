using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace HomeReview_DotNetU
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Course> CourseCatalog { get; set; } = new List<Course>();
        const string ConnectionString = @"Server=localhost\SQLEXPRESS;Database=DotNetUnv;Trusted_Connection=True;";

        static private SqlDataReader ExecuteQuery(string query)
        {
            SqlDataReader rv;
            using (var connection = new SqlConnection(ConnectionString))
            {
                var cmd = new SqlCommand(query, connection);
                connection.Open();
                rv = cmd.ExecuteReader();
                connection.Close();
            }
            return rv;
        }

        static private int GetCountFromTable(string tableName, string column = "Id")
        {
            var count = 0;
            var query = $"SELECT COUNT({column}) FROM {tableName}";
            var reader = ExecuteQuery(query);
            while (reader.Read())
            {
                count = (int)reader[0];
            }
            return count;
        }

        public MainWindow()
        {
            InitializeComponent();
            // I want to load things from the database
            // Get count of Classes

            this.NumberOfInstructors.Content = GetCountFromTable("Instructors", "*");
            this.NumberOfCourse.Content = GetCountFromTable("Courses");
        }
    }
}
