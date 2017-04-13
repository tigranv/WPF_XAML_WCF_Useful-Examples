using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace SoccerDataApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Author_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tigran Vardanyan");
        }

        private void ShowTeam_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowInNumber_Click(object sender, RoutedEventArgs e)
        {
            int PlayerID = int.Parse(IdTextBox.Text);
            SqlDataReader reader = null;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                

                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Table] WHERE ID=@id", connection);
                command.Parameters.AddWithValue("id", PlayerID);
                connection.Open();

                reader = command.ExecuteReader();
                reader.Read();

                FirstLastNAme.Text = reader[1].ToString();
                AboutIn.Text = reader[2].ToString();

                reader.Close();
            }
        }
    }
}
