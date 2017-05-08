using System.Windows;

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Show(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(passwor.Text) || string.IsNullOrEmpty(login.Text))
            {
                MessageBox.Show("Error");
            }
            else
            {
                MessageBox.Show("ura");
            }
        }
    }
}
