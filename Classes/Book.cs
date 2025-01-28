using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibraryManagementApp.Classes
{
    public class Book
    {
        private int bookId;
        private string title;
        private string author;
        private string url;
        private int year;
        private string isbn;
        private DateTime borrowedDate;
        private DateTime dueDate;
        private DateTime returnDate;
        private DateTime reservationDate;


        private string connectionString = "Server=127.0.0.1;Database=library_management_system;User ID=root;Password=;";


        public int BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Url
        {
            get { return url; }
            set { url = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public DateTime BorrowedDate
        {
            get { return borrowedDate; }
            set { borrowedDate = value; }
        }
        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
        public DateTime ReservationDate
        {
            get { return reservationDate; }
            set { reservationDate = value; }
        }

        public Book() { }

        public Book(int bookid, string title, string author, int year, string url)
        {
            this.bookId = bookid;
            this.title = title;
            this.author = author;
            this.isbn = GenerateISBN13();
            this.year = year;
        }

        // constructor for the add Book
        public Book(string title, string author, int year, string url)
        {
            this.title = title;
            this.author = author;
            this.isbn = GenerateISBN13();
            this.year = year;
            this.url = url;
        }


        // Generate ISBN-13
        private string GenerateISBN13()
        {
            string prefix = "978";
            Random random = new Random();
            string randomDigits = "";
            for (int i = 0; i < 9; i++) randomDigits += random.Next(0, 10).ToString();

            string isbnWithoutCheckDigit = prefix + randomDigits;
            int checkDigit = CalculateISBN13CheckDigit(isbnWithoutCheckDigit);
            return isbnWithoutCheckDigit + checkDigit;
        }

        // Calculate ISBN-13 Check Digit
        private int CalculateISBN13CheckDigit(string isbnWithoutCheckDigit)
        {
            int sum = 0;
            for (int i = 0; i < isbnWithoutCheckDigit.Length; i++)
            {
                int digit = int.Parse(isbnWithoutCheckDigit[i].ToString());
                sum += (i % 2 == 0) ? digit : digit * 3;
            }
            int remainder = sum % 10;
            return (remainder == 0) ? 0 : 10 - remainder;
        }

        // private method to save the book
        public void saveBook(Book book)
        {
            string query = "INSERT INTO books_table (Id, Title, Author, Year, ISBN, URL) VALUES (@Id, @Title, @Author, @Year, @ISBN, @URL)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", book.BookId);
                        command.Parameters.AddWithValue("@Title", book.Title);
                        command.Parameters.AddWithValue("@Author", book.Author);
                        command.Parameters.AddWithValue("@Year", book.Year);
                        command.Parameters.AddWithValue("@ISBN", book.Isbn);
                        command.Parameters.AddWithValue("@URL", book.Url);

                        int rowAffected = command.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Book saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to save the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        //method to display the books from the db
        public void DisplayBooks(DataGridView datagrid)
        {
            string query = "SELECT * FROM books_table";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        datagrid.DataSource = table;

                        //datagrid.Columns[0].HeaderText = "Book Name";
                        //datagrid.Columns[1].HeaderText = "Author";
                        //datagrid.Columns[2].HeaderText = "Year";
                        //datagrid.Columns[3].HeaderText = "ISBN";
                        datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;



                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }


        }
        // method to delete the book
        public void DeleteBook(int bookId)
        {
            string query = "DELETE FROM books_table WHERE Id = @Id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", bookId);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void EditBook(Book book)
        {
            string query = "UPDATE books_table SET Title = @Title, Author = @Author, Year = @Year, URL = @URL WHERE Id = @Id";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", book.BookId);
                        command.Parameters.AddWithValue("@Title", book.Title);
                        command.Parameters.AddWithValue("@Author", book.Author);
                        command.Parameters.AddWithValue("@Year", book.Year);
                        command.Parameters.AddWithValue("@URL", book.Url);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
