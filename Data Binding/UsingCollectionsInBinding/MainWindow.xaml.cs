using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace UsingCollectionsInBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> list = new ObservableCollection<string>();
        public MainWindow()
        {
           
            InitializeComponent();

            string[] arr = { "item1", "item2", "item3", "item4" };

            foreach (var item in arr)
            {
                list.Add(item);
            }        

            listBox1.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list.Add(DateTime.Now.ToLongTimeString());
        }
    }
}
