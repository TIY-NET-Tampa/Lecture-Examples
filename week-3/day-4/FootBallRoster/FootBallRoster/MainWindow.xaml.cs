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
using Football.Services;

namespace FootBallRoster
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Guid SelectedPlayer { get; set; } = Guid.Empty;
        public Team Team { get; set; } = new Team();
        public MainWindow()
        {
            InitializeComponent();
            this.Roster.ItemsSource = Team.Players;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedPlayer == Guid.Empty)
            {
                // Create a new Player 
                // Grab values from UI
                var name = this.PlayerName.Text;
                var number = int.Parse(this.PlayerNumber.Text);
                var salary = double.Parse(this.PlayerSalary.Text);
                
                // Do the logic in our service
                var newPlayer = Team.AddPlayer(name, number, salary);

                // IF NEEDED: update the UI
                SelectedPlayer = newPlayer.Id;
                this.Roster.Items.Refresh();
            }

        }

        private void PlayerSelected(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                var player = btn.DataContext as Player;
                this.PlayerName.Text = player.Name;
                this.PlayerNumber.Text = player.Number.ToString();
                this.PlayerSalary.Text = player.Salary.ToString();
                this.PlayerInterceptions.Text = player.Statistics.Interceptions.ToString();
                this.PlayerTackles.Text = player.Statistics.Tackles.ToString();
                this.PlayerTouchDowns.Text = player.Statistics.Touchdowns.ToString();
                SelectedPlayer = player.Id;
            }
        }

        private void ClearSelectedPlayer(object sender, RoutedEventArgs e)
        {
            SelectedPlayer = Guid.Empty;
        }

        private void DeleteSelectedPlayer(object sender, RoutedEventArgs e)
        {
            if (SelectedPlayer != Guid.Empty)
            {
                Team.DeletePlayer(SelectedPlayer);
                this.Roster.Items.Refresh();
                SelectedPlayer = Guid.Empty;
            }
        }

        private void UpdatePlayerStats(object sender, RoutedEventArgs e)
        {
            // Grab values from UI
            var tackles = int.Parse(this.PlayerTackles.Text);
            var interceptions = int.Parse(this.PlayerInterceptions.Text);
            var touchdowns = int.Parse(this.PlayerTouchDowns.Text);

            // Do the logic in our service
            Team.UpdatePlayerStats(SelectedPlayer, tackles, interceptions, touchdowns);
            // IF NEEDED: update the UI
          
        }
    }
}
