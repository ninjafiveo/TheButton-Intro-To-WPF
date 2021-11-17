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

namespace TheButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number1 = 0;
        double number2 = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Green_Click_Me_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ninja Ninja Ninja");
        }


        private void Crooked_Clicker_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Crooked Clicker Button Has Been Clicked");
        }

        private void Calculate_Button_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(Number1_Input.Text, out number1);
            Double.TryParse(Number2_Input.Text, out number2);
            double answer = number1 + number2;

            ResponseAnswer.Text = answer.ToString();
        }

        private void Number1_Input_GotFocus(object sender, RoutedEventArgs e)
        {
            Double.TryParse(Number1_Input.Text, out number1);
            Double.TryParse(Number2_Input.Text, out number2);
            double answer = number1 + number2;

            ResponseAnswer.Text = answer.ToString();
        }

        private void Number2_Input_LostFocus(object sender, RoutedEventArgs e)
        {
            Double.TryParse(Number1_Input.Text, out number1);
            Double.TryParse(Number2_Input.Text, out number2);
            double answer = number1 + number2;

            ResponseAnswer.Text = answer.ToString();
        }



        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            Number1_Input.Text = "0";
            Number2_Input.Text = "0";
            ResponseAnswer.Text = (0).ToString();

        }

        private void Number1_Input_LostFocus(object sender, RoutedEventArgs e)
        {
            Double.TryParse(Number1_Input.Text, out number1);
            Double.TryParse(Number2_Input.Text, out number2);
            double answer = number1 + number2;

            ResponseAnswer.Text = answer.ToString();
        }
    }
}
