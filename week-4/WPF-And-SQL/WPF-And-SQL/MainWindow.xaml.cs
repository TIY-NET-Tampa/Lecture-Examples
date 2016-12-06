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
using System.Data.SqlClient;


namespace WPF_And_SQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<City> Cities { get; set; } = new List<City>();

        public MainWindow()
        {
            InitializeComponent();
            this.listView.ItemsSource = Cities;

            // connect to database
            var connectionStrings = @"Server=localhost\SQLEXPRESS;Database=DistinctExample;Trusted_Connection=True;";
            using( var connection = new SqlConnection(connectionStrings))
            {
                // grab all cities
                using (var cmd  = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.TableDirect;

                    cmd.CommandText = @"IncreasePopulation";

                    cmd.Parameters.AddWithValue("@cityId", 14);
                    cmd.Parameters.AddWithValue("@newPopulation", 100000);

                    connection.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var id = reader[0];
                        var cityName = reader[1];
                        var state = reader[2];
                        var population = reader[3];
                        var city = new City
                        {
                            Id = (int)id,
                            Name = cityName as string,
                            State = state as string,
                            Population = population as int?
                        };
                        Cities.Add(city);
                    }
                    connection.Close();
                }
                // display them
                this.listView.Items.Refresh();

            }

        }
    }
}
