using System.Windows;

namespace ElementToElementBinding
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_SetSmall(object sender, RoutedEventArgs e)
        {
            sampleText.FontSize = 5;
        }

        private void Button_Click_SetNormal(object sender, RoutedEventArgs e)
        {
            sampleText.FontSize = FontSize;
        }

        private void Button_Click_SetLarge(object sender, RoutedEventArgs e)
        {
            sampleText.FontSize = 35;
        }
    }
}
