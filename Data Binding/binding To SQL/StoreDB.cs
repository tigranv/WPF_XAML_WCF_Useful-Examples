using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

namespace binding_To_SQL
{
    class StoreDB
    {
        public Book GetBook(int bookId)
        {
            Book book = null;
            SqlDataReader reader = null;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE ID=@id", connection);
                command.Parameters.AddWithValue("id", bookId);
                connection.Open();

                try
                {
                    reader = command.ExecuteReader();
                    reader.Read();
                    book = new Book()
                    {
                        Title = reader[1].ToString(),
                        Description = reader[2].ToString(),
                        Author = reader[3].ToString()
                    };
                }
                catch (Exception e)
                {         
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }
                return book;
            }
        }

        public void UpdateBook(Book book, int bookId)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                SqlCommand command = new SqlCommand("UPDATE Books SET Title=@title, Description=@description, Author=@author WHERE ID=@id", connection);
                command.Parameters.AddWithValue("title", book.Title);
                command.Parameters.AddWithValue("description", book.Description);
                command.Parameters.AddWithValue("author", book.Author);
                command.Parameters.AddWithValue("ID", bookId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            SqlDataReader reader = null;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Books", connection);
                try
                {
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Book book = new Book()
                        {
                            Title = reader[1].ToString(),
                            Description = reader[2].ToString(),
                            Author = reader[3].ToString()
                        };
                        books.Add(book);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    reader.Close();
                }
            }
            return books;
        }
    }
}
