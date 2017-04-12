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

namespace binding_To_SQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Book CurrentBook = null;
        StoreDB _db = new StoreDB();

        public MainWindow()
        {
            InitializeComponent();
        }

        bool isCollapsed = true;

        private void listBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gridMain.DataContext = listBooks.SelectedItem;
        }

        private void buttonGetBook_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int bookID = Convert.ToInt32(TextBoxID.Text);
                CurrentBook = _db.GetBook(bookID);
                TextBoxID.DataContext = CurrentBook;
            }
            catch (Exception)
            {
                MessageBox.Show("Error !!!.");
            }

        }

        private void UpdateBook_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int bookID = Convert.ToInt32(TextBoxID.Text);
                _db.UpdateBook(CurrentBook, bookID);
            }
            catch (Exception)
            {
                MessageBox.Show("Error !!!");
            }
        }

        private void buttonShowList_Click_1(object sender, RoutedEventArgs e)
        {
            if (isCollapsed)
            {
                listBooks.Visibility = System.Windows.Visibility.Visible;
                try
                {
                    listBooks.ItemsSource = _db.GetAllBooks();
                    listBooks.DisplayMemberPath = "Title";
                }
                catch
                {
                    MessageBox.Show("Error !!!");
                }
            }
            else
            {
                listBooks.Visibility = System.Windows.Visibility.Collapsed;
            }
            isCollapsed = !isCollapsed;

        }
    }
}
