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

namespace TextDisplayer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Test.IsChecked == true)
            {
                MessageBox.Show("Test");
            }
            else if (Hello.IsChecked == true)
            {
                MessageBox.Show("Hello");
            }
            else if (hi.IsChecked == true)
            {
                MessageBox.Show("Hi");
            }
            else if (option1.IsChecked == true)
            {
                MessageBox.Show("1");
            }
            else if (Lol.IsChecked == true)
            {
                MessageBox.Show("Lol");
            }
            else if (Cool.IsChecked == true)
            {
                MessageBox.Show("Cool");
            }
            else if (Idk.IsChecked == true)
            {
                MessageBox.Show("Idk");
            }
        }

        // Optional: You can handle the RadioButton Checked event if needed
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            // Handle event if needed
        }

        private void Lol_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Cool_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Idk_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
