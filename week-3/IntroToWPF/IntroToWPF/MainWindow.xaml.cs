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

namespace IntroToWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int TimesButtonsClicked { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Hello there nick!";
        }

        private void SHowUserInput(object thingThatWasClicked, RoutedEventArgs e)
        {
            // interact with a button????
            var button = (Button)thingThatWasClicked;
            var dataContext = button.DataContext as String;
            if (dataContext != null)
            {
                this.Giraffe.Content = "You Cliked the secret button";

            }
            else
            {
            this.TimesButtonsClicked++;
                this.Giraffe.Content = $"Keeep Trying, you tried {this.TimesButtonsClicked}";
            }
            button.Content = "You clicked me!";
        }

        private void Button_Click(object thingThatWasClicked, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
