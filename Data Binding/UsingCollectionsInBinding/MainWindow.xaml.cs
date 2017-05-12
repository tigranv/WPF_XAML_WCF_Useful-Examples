using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace UsingCollectionsInBinding
{
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
