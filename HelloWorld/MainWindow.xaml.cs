using System.Windows;
using System.Windows.Controls;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //WindowState = WindowState.Maximized;
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitting password:" + uxPassword.Text);
        }


        private void uxName_UxPassword_CheckForValues(object sender, TextChangedEventArgs e)
        {
            // Enable Submit button if Name and Password have values
            if (uxName.Text.Length > 0 && uxPassword.Text.Length > 0)           
                uxSubmit.IsEnabled = true;
            else
                uxSubmit.IsEnabled = false;
        }
    }
}
