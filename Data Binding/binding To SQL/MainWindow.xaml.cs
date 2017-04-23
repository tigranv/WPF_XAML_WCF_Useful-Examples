using System;
using System.Windows;
using System.Windows.Controls;

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
                gridMain.DataContext = CurrentBook;
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
