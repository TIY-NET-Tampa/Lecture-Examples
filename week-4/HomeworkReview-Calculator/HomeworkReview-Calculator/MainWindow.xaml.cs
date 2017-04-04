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

namespace HomeworkReview_Calculator
{
    /*
     - The +/- button
     - Memory buttons
     - Buttons and Keyboard & focus
     - regex!!!!! - using buttons to assign buttons

         */



    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MyMath Calculator { get; set; } = new MyMath();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Output.Content = 
                Calculator.Add(
                    double.Parse(this.Value1.Text),
                    double.Parse(this.Value2.Text));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Output.Content = 
                this.Calculator
                .TogglesTheSignOfLastAnswer()
                .ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Calculator.SaveLastAnswerToMemory();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Value2.Text = this.Calculator.RecallLastMemory().ToString();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            var pressed = e.Key;
        }
    }
}
