﻿using System.Data.SqlClient;
using System.Windows;

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
            if (ListBoxAll.Items.Count != 0 && ListBoxAll.Visibility!=Visibility.Collapsed)
            {
                ListBoxAll.Visibility = Visibility.Collapsed;
                ListBoxAll.Items.Clear();
            }
            else
            {
                ListBoxAll.Visibility = Visibility.Visible;
                SqlDataReader reader = null;
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {


                    SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Table] ", connection);

                    connection.Open();

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ListBoxAll.Items.Add(reader[1]);
                    }
                    reader.Close();
                }
            }
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
