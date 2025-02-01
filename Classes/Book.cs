using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

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

        // constructor for the LoadBooks Details method
        public Book(int bookId, string title, string author, int year, string isbn, string url)
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            this.year = year;
            this.isbn = isbn;
            this.url = url;
        }

        // constructor for the edit book
        public Book(int bookid, string title, string author, int year, string url)
        {
            this.bookId = bookid;
            this.title = title;
            this.author = author;
            this.isbn = GenerateISBN13();
            this.year = year;
            this.url = url;
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

        // method to update the details of an existing book
        public void EditBook(Book book)
        {
            string query = "UPDATE books_table SET Title = @Title, Author = @Author, Year = @Year, ISBN = @ISBN ,URL = @URL WHERE Id = @Id";

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

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No book found with the given ID or no changes made.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // method to get the book count

        public int GetBookCount()
        {
            int count = 0;

            string query = "SELECT COUNT(*) FROM books_table";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        count = Convert.ToInt32(command.ExecuteScalar());

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
            return count;

        }
        public int GetOverdueBookCount()
        {
            int count = 0;

            string query = "SELECT COUNT(*) FROM overdue_table";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        count = Convert.ToInt32(command.ExecuteScalar());

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
            return count;

        }
        public int GetBorrowedBookCount()
        {
            int count = 0;

            string query = "SELECT COUNT(*) FROM borrowed_records WHERE IsReturned = 0";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        count = Convert.ToInt32(command.ExecuteScalar());

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
            return count;

        }



        // method to get the the book id
        public int GetBookId(Book book)
        {
            string query = "SELECT ID FROM books_table WHERE Title = @Title AND Author = @Author AND ISBN = @ISBN";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", book.Title);
                        command.Parameters.AddWithValue("@Author", book.Author);
                        command.Parameters.AddWithValue("@ISBN", book.Isbn);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            int bookId = Convert.ToInt32(result);
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
            return bookId;
        }

        // method to load book details 
        public Book LoadBookDetails(int selectedBookId)
        {
            string query = "SELECT * FROM books_table WHERE ID = @BookId";

            using (MySqlConnection conection = new MySqlConnection(connectionString))
            {
                try
                {
                    conection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, conection))
                    {
                        command.Parameters.AddWithValue("@BookId", selectedBookId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int bookId = reader.GetInt32("ID");
                                string title = reader.GetString("Title");
                                string author = reader.GetString("Author");
                                int year = reader.GetInt32("Year");
                                string isbn = reader.GetString("ISBN");
                                string url = reader.GetString("URL");

                                return new Book(bookId, title, author, year, isbn, url);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database Error:{ex.Message}");
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception error {ex.Message}");
                }
                finally
                {
                    conection.Close();
                }


            }
            return null;
        }

        // method to check the book is available
        private bool IsBookAvailable(int bookId)
        {
            string query = "SELECT COUNT(*) FROM borrowed_records WHERE BookID = @BookID AND IsReturned = FALSE";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookId);
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count == 0; // Book is available if no active borrow records
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Assume unavailable on error
                }
            }
        }

        // method to borrow a book
        public void BorrowBook(int bookId, Person person)
        {
            int studentId = person.GetUserId(person); // Fetch user ID
            bool canBorrowOrReserve = CanUserBorrowOrReserve(person);
            // Validate user existence
            if (canBorrowOrReserve)
            {
                if (studentId == 0)
                {
                    MessageBox.Show($"User '{person.Name}' not found. Please enter a valid username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the book is available
                if (!IsBookAvailable(bookId))
                {
                    MessageBox.Show($"Book (ID: {bookId}) is currently unavailable. You can reserve it instead.", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO borrowed_records (BookID, UserID, BorrowDate, DueDate, IsReturned) " +
                               "VALUES (@BookID, @StudentID, @BorrowedDate, @DueDate, @IsReturned)";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlTransaction transaction = connection.BeginTransaction()) // Start transaction
                    {
                        try
                        {
                            using (MySqlCommand command = new MySqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@BookID", bookId);
                                command.Parameters.AddWithValue("@StudentID", studentId);
                                command.Parameters.AddWithValue("@BorrowedDate", DateTime.Now);
                                command.Parameters.AddWithValue("@DueDate", DateTime.Now.AddDays(14));
                                command.Parameters.AddWithValue("@IsReturned", false);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    transaction.Commit(); // Commit transaction
                                    MessageBox.Show($"Book (ID: {bookId}) borrowed successfully by User '{person.Name}' (ID: {studentId})!",
                                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    transaction.Rollback(); // Rollback if no rows affected
                                    MessageBox.Show($"Failed to borrow the book (ID: {bookId}) for User '{person.Name}' (ID: {studentId}).",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (MySqlException ex)
                        {
                            transaction.Rollback(); // Rollback on SQL error
                            MessageBox.Show($"Database Error: {ex.Message}\n\nUser: {person.Name} (ID: {studentId})",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback(); // Rollback on general error
                            MessageBox.Show($"Error: {ex.Message}\n\nUser: {person.Name} (ID: {studentId})",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        // method to load the borrowed books of the user to the datagrid
        public void LoadBorrowedBooks(Person person, DataGridView dataGridView)
        {
            int userId = person.GetUserId(person); // Fetch user ID

            if (userId == 0)
            {
                MessageBox.Show($"User '{person.Name}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"
        SELECT br.BorrowedId, b.ID AS BookId, b.Title, b.Author, br.BorrowDate, br.DueDate
        FROM borrowed_records br
        INNER JOIN books_table b ON br.BookID = b.ID
        WHERE br.UserID = @UserID AND br.IsReturned = 0";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView.DataSource = dt;
                            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // method to check the book is avaible to reserve
        public bool CheckBookStatus(int bookId)
        {
            string query = "SELECT IsReturned FROM borrowed_records WHERE BookID = @BookID ORDER BY BorrowDate DESC LIMIT 1";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookId);
                        object result = command.ExecuteScalar();

                        // If no result is found, it means the book has not been borrowed or does not exist
                        if (result == null || result == DBNull.Value)
                        {
                            return true; // The book is available (not borrowed).
                        }

                        // Otherwise, convert result to boolean
                        bool isReturned = Convert.ToBoolean(result);
                        return isReturned; // Return whether the book is returned
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Return false if there is a database error
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // method to return the book
        public bool ReturnBook(int borrowedId,DateTime returnDate)
        {
            string selectQuery = "SELECT UserId, BookId, DueDate FROM borrowed_records WHERE BorrowedId = @BorrowedId";
            string updateQuery = "UPDATE borrowed_records SET IsReturned = 1, ReturnedDate = @ReturnDate WHERE BorrowedId = @BorrowedId";
            string insertOverdueQuery = @"INSERT INTO overdue_table (BorrowedId, UserID, BookID, OverdueDays, FineAmount, PaidStatus) 
                                  VALUES (@BorrowedId, @UserID, @BookID, @OverdueDays, @FineAmount ,@PaidStatus)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction(); // Start transaction

                try
                {
                    DateTime dueDate;
                    int userId, bookId;
                    //DateTime returnDate = DateTime.Now;

                    // Step 1: Get UserID, BookID, and DueDate (inside transaction)
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection, transaction))
                    {
                        selectCommand.Parameters.AddWithValue("@BorrowedId", borrowedId);
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                transaction.Rollback();
                                return false; // No record found, rollback
                            }

                            userId = reader.GetInt32("UserID");
                            bookId = reader.GetInt32("BookID");
                            dueDate = reader.GetDateTime("DueDate");
                        }
                    }

                    // Step 2: Calculate overdue fee
                    int overdueDays = (returnDate > dueDate) ? (returnDate - dueDate).Days : 0;
                    decimal overdueFee = overdueDays * 5; // Example: $2 per day

                    // Step 3: Update borrowed_records table
                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection, transaction))
                    {
                        updateCommand.Parameters.AddWithValue("@BorrowedId", borrowedId);
                        updateCommand.Parameters.AddWithValue("@ReturnDate", returnDate);
                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            transaction.Rollback();
                            return false; // No row updated, rollback
                        }
                    }

                    // Step 4: If overdue, insert into overdue_records table
                    if (overdueDays > 0)
                    {
                        using (MySqlCommand insertCommand = new MySqlCommand(insertOverdueQuery, connection, transaction))
                        {
                            insertCommand.Parameters.AddWithValue("@BorrowedId", borrowedId);
                            insertCommand.Parameters.AddWithValue("@UserID", userId);
                            insertCommand.Parameters.AddWithValue("@BookID", bookId);
                            insertCommand.Parameters.AddWithValue("@OverdueDays", overdueDays);
                            insertCommand.Parameters.AddWithValue("@FineAmount", overdueFee);
                            insertCommand.Parameters.AddWithValue("@PaidStatus", 0);
                            insertCommand.ExecuteNonQuery();
                        }
                        MessageBox.Show($"Book returned, but overdue! You owe ${overdueFee}.", "Overdue Fee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    transaction.Commit(); // Commit transaction if all steps succeed
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Rollback transaction on error
                    MessageBox.Show("Error: " + ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        
        // method that check the whether the book is availble to reserve
        public bool CheckBookCanReserve(int bookId)
        {
            string query = "SELECT COUNT(*) FROM reservation_table " +
                                "WHERE BookId = @BookID AND Status = 'Pending' AND ReservedUntill >= NOW();";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookId);
                        object result = command.ExecuteScalar();

                        // If no result is found, it means the book has not been borrowed or does not exist
                        if (result == null || result == DBNull.Value)
                        {
                            return true; // The book is available (not borrowed).
                        }

                        // Otherwise, convert result to boolean
                        bool isReserved = Convert.ToBoolean(result);
                        return isReserved; // Return whether the book is returned
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Return false if there is a database error
                }
                catch(Exception ex)
                {
                    MessageBox.Show(" Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //method to check the whether the borrowed user is the same user who is reserving the book
        private bool CheckUserReserveBook(int bookId, Person person)
        {
            string query = "SELECT COUNT(*) FROM borrowed_records WHERE BookID = @BookID AND UserID = @UserID AND IsReturned = 0";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookId);
                        command.Parameters.AddWithValue("@UserID", person.GetUserId(person));

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        // method to reserve a book

        public void ReserveBook(int bookId, Person person)
        {
            bool canBorrowOrReserve = CanUserBorrowOrReserve(person);
            if (canBorrowOrReserve)
            {
                bool isReserved = CheckBookCanReserve(bookId);
                bool isSameUser = CheckUserReserveBook(bookId, person);
                if (isSameUser)
                {

                    MessageBox.Show("You cannot reserve a book that you have borrowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (isReserved)
                    {
                        MessageBox.Show("Book is already reserved by another user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int userId = person.GetUserId(person); // Fetch user ID

                        if (userId == 0)
                        {
                            MessageBox.Show($"User '{person.Name}' not found. Please enter a valid username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        string query = "INSERT INTO reservation_table (BookId, UserId, ReservationDate, ReservedUntill, Status, IsCollected) " +
                                   "VALUES (@BookID, @StudentID, @ReservationDate, @ReservedUntill, @Status, @IsCollected)";

                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {

                            connection.Open();

                            using (MySqlTransaction transaction = connection.BeginTransaction())
                            {
                                try
                                {
                                    using (MySqlCommand command = new MySqlCommand(query, connection, transaction))
                                    {
                                        command.Parameters.AddWithValue("@BookID", bookId);
                                        command.Parameters.AddWithValue("@StudentID", userId);
                                        command.Parameters.AddWithValue("@ReservationDate", DateTime.Now);
                                        command.Parameters.AddWithValue("@ReservedUntill", DateTime.Now.AddDays(3));
                                        command.Parameters.AddWithValue("@Status", "Pending");
                                        command.Parameters.AddWithValue("@IsCollected", false);

                                        int rowsAffected = command.ExecuteNonQuery();
                                        if (rowsAffected > 0)
                                        {
                                            transaction.Commit();
                                            MessageBox.Show($"Book (ID: {bookId}) reserved successfully by User '{person.Name}' (ID: {userId})!",
                                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        }
                                        else
                                        {

                                            transaction.Rollback();
                                            MessageBox.Show($"Failed to reserve the book (ID: {bookId}) for User '{person.Name}' (ID: {userId}).",
                                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                catch (MySqlException ex)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                catch (Exception ex)
                                {

                                    transaction.Rollback();
                                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                finally
                                {
                                    connection.Close();
                                }

                            }
                        }
                    }
                }
            }

        }

        //method to load the reserved books
        public void LoadReservedBooks(Person person, DataGridView dataGridView)
        {
            int userId = person.GetUserId(person); // Fetch user ID

            if (userId == 0)
            {
                MessageBox.Show($"User '{person.Name}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = @"
                    SELECT br.ReservationId, b.ID AS BookId, b.Title, b.Author, b.Year, br.ReservationDate, br.ReservedUntill
                    FROM reservation_table br
                    INNER JOIN books_table b ON br.BookID = b.ID
                    WHERE br.UserID = @UserID AND br.Status = 'Pending' AND br.ReservedUntill >= NOW();";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView.DataSource = dt;
                            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        // method to check the user is eligible to reserve or borrow book based on fines

        private bool CanUserBorrowOrReserve(Person person)
        {
            int userId =person.GetUserId(person);
            string query = "SELECT SUM(FineAmount) FROM overdue_table WHERE UserID = @UserID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        object result = command.ExecuteScalar();

                        decimal overdueAmount = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                        if (overdueAmount > 50)
                        {
                            MessageBox.Show($"Your overdue fine is ${overdueAmount}. Please clear it before borrowing or reserving a book.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public int GetTotalBorrowedBooks(Person person)
        {
            int userId = person.GetUserId(person);
            string query = "SELECT COUNT(*) FROM borrowed_records WHERE UserId = @UserID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        object result = command.ExecuteScalar();

                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }

        public int GetTotalOverdueBooks(Person person)
        {
            int userId = person.GetUserId(person);
            string query = "SELECT COUNT(*) FROM overdue_table WHERE UserID = @UserID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        object result = command.ExecuteScalar();

                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }

        // method to get the most borrowed Book
        public string GetMostBorrowedBook()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    // SQL query to find the most borrowed book
                    string query = @"
                SELECT b.Title, COUNT(br.BookId) AS borrowingCount
                FROM borrowed_records br
                JOIN books_table b ON br.BookId = b.ID
                GROUP BY br.BookId
                ORDER BY borrowingCount DESC
                LIMIT 1;
            ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Retrieve the book title and borrowing count
                            string bookTitle = reader.GetString("title");
                            int borrowingCount = reader.GetInt32("borrowingCount");

                            // Return the most borrowed book information as a string
                            return $"Most Borrowed Book: {bookTitle}\nNumber of Borrowings: {borrowingCount}";
                        }
                        else
                        {
                            return "No books have been borrowed yet.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    return "An error occurred: " + ex.Message;
                }
            }
        }


        //  method to display the Borrowing table
        public void LoadLibraryBorrowings(DataGridView dataGridView)
        {
            string query = @"
        SELECT 
            br.BorrowedId, 
            u.Id AS UserId, 
            u.name AS UserName, 
            b.ID AS BookID, 
            b.Title AS BookTitle, 
            b.Author, 
            br.BorrowDate, 
            br.DueDate, 
            br.IsReturned 
        FROM borrowed_records br
        INNER JOIN student_table u ON br.UserID = u.Id
        INNER JOIN books_table b ON br.BookId = b.ID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())  // Start Transaction
                {
                    try
                    {
                        using (MySqlCommand command = new MySqlCommand(query, connection, transaction))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView.DataSource = dt;

                                // Adjust DataGridView display
                                
                                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                            }
                        }

                        transaction.Commit();  // Commit Transaction
                    }
                    catch (MySqlException ex)
                    {
                        transaction.Rollback();  // Rollback Transaction if an error occurs
                        MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        /// <summary>
        /// load the library reservations
        /// </summary>

        public void LoadLibraryReservations(DataGridView dataGridView)
        {
            string query = @"
    SELECT 
        r.ReservationId, 
        u.Id AS UserId, 
        u.name AS UserName, 
        b.ID AS BookId, 
        b.Title AS BookTitle, 
        b.Author, 
        r.ReservationDate, 
        r.Status 
    FROM reservation_table r
    INNER JOIN student_table u ON r.UserID = u.Id
    INNER JOIN books_table b ON r.BookId = b.ID
    WHERE r.IsCollected = 0 AND r.Status = 'Pending'";  // Filter only uncollected & pending reservations

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlTransaction transaction = connection.BeginTransaction())  // Start Transaction
                {
                    try
                    {
                        using (MySqlCommand command = new MySqlCommand(query, connection, transaction))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridView.DataSource = dt;

                                // Adjust DataGridView display
                                
                                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                            }
                        }

                        transaction.Commit();  // Commit Transaction
                    }
                    catch (MySqlException ex)
                    {
                        transaction.Rollback();  // Rollback Transaction if an error occurs
                        MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void LoadOverdueBooks(DataGridView dataGridView)
        {
            
    string query = @"
SELECT
    o.OverdueId, 
    u.Id AS UserId, 
    u.Name AS UserName, 
    b.ID AS BookId, 
    b.Title AS BookTitle, 
    o.OverdueDays, 
    o.FineAmount, 
    o.PaidStatus, 
    COALESCE(NULLIF(o.PaidDate, '0000-00-00'), NULL) AS PaidDate
FROM overdue_table o
INNER JOIN student_table u ON o.UserID = u.Id
INNER JOIN books_table b ON o.BookID = b.ID
WHERE o.PaidStatus = 0";


            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView.Invoke((MethodInvoker)delegate
                            {
                                dataGridView.DataSource = dt;

                                // Adjust DataGridView display
                                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                            });
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // method to get the paid status

        public void SetPaidStatus(int overdueId, RadioButton paidCheckBox, RadioButton notPaidCheckBox)
        {
            bool isPaid = false; // Initialize to false
            string query = "SELECT PaidStatus FROM overdue_table WHERE OverdueId " +
                " = @overdueId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@overdueId", overdueId);

                    // Execute the query and get the paid status
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        isPaid = Convert.ToBoolean(result);

                        // Set the checkbox status based on the result
                        paidCheckBox.Checked = isPaid;
                        notPaidCheckBox.Checked = !isPaid; // Uncheck the other checkbox
                    }
                    else
                    {
                        // If no result, ensure both checkboxes are unchecked (or handle as needed)
                        paidCheckBox.Checked = false;
                        notPaidCheckBox.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    paidCheckBox.Checked = false;  // Default to unchecked if there's an error
                    notPaidCheckBox.Checked = false;
                }
            }
        }
        public bool UpdateOverdueStatus(int overdueId, bool isPaid)
        {
            DateTime paidDate = DateTime.Now;
            // Example query to update the status and insert the paid date in the database
            string queryUpdate = "UPDATE overdue_table SET PaidStatus = @paid, PaidDate = @paidDate WHERE OverdueId = @overdueId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlTransaction transaction = null;

                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction(); // Start a new transaction

                    MySqlCommand cmd = new MySqlCommand(queryUpdate, conn, transaction);
                    cmd.Parameters.AddWithValue("@paid", isPaid); // Pass the isPaid value
                    cmd.Parameters.AddWithValue("@overdueId", overdueId); // Pass the overdueId
                    cmd.Parameters.AddWithValue("@paidDate", paidDate); // Pass the paid date

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Commit the transaction if the update was successful
                        transaction.Commit();
                        return true; // Successfully updated
                    }
                    else
                    {
                        // Rollback the transaction if no rows were updated
                        transaction.Rollback();
                        return false; // No rows updated, operation failed
                    }
                }
                catch (Exception ex)
                {
                    // Rollback the transaction in case of an error
                    transaction?.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                    return false; // Return false if an exception occurs
                }
            }
        }

        public void LoadReservationBooks(DataGridView dataGridView)
        {

            string query = @"
            SELECT
                o.ReservationId, 
                u.Id AS UserId, 
                u.Name AS UserName, 
                b.ID AS BookId, 
                b.Title AS BookTitle, 
                o.ReservationDate, 
                o.ReservedUntill, 
                o.IsCollected,
                o.Status
            FROM reservation_table o
            INNER JOIN student_table u ON o.UserID = u.Id
            INNER JOIN books_table b ON o.BookId = b.ID
            WHERE o.Status = 'Pending';";




            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView.Invoke((MethodInvoker)delegate
                            {
                                dataGridView.DataSource = dt;

                                // Adjust DataGridView display
                               
                                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                            });
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SetCollectStatus(int reservationId, RadioButton collectCheckBox, RadioButton notcollectCheckBox, ComboBox box)
        {
            bool isPaid = false; // Initialize to false
            string query = "SELECT IsCollected FROM reservation_table WHERE ReservationId = @overdueId";
            string combo = "SELECT Status FROM reservation_table WHERE ReservationId = @overdueId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@overdueId", reservationId);

                    // Execute the query and get the paid status
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        isPaid = Convert.ToBoolean(result);

                        // Set the checkbox status based on the result
                        collectCheckBox.Checked = isPaid;
                        notcollectCheckBox.Checked = !isPaid; // Uncheck the other checkbox
                    }
                    else
                    {
                        // If no result, ensure both checkboxes are unchecked (or handle as needed)
                        collectCheckBox.Checked = false;
                        notcollectCheckBox.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in payment status query: " + ex.Message);
                    collectCheckBox.Checked = false;  // Default to unchecked if there's an error
                    notcollectCheckBox.Checked = false;
                }
            }

            // Now retrieve the status from the database and set it in the ComboBox
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(combo, connection))
                    {
                        cmd.Parameters.AddWithValue("@overdueId", reservationId);

                        // Execute the query to get the current status
                        object statusResult = cmd.ExecuteScalar();

                        if (statusResult != null)
                        {
                            string status = statusResult.ToString();

                            // Set the ComboBox selected item to match the status from the database
                            if (box.Items.Contains(status))
                            {
                                box.SelectedItem = status;
                            }
                            else
                            {
                                MessageBox.Show("Status value not found in ComboBox items.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No status found for this reservation.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in status query: " + ex.Message);
                }
            }
        }

        public bool UpdateReservationStatus(int reservationId, bool isCollected, string status)
        {
            // If status is "Denied", force isCollected to be 0
            if (status.Equals("Denied", StringComparison.OrdinalIgnoreCase))
            {
                isCollected = false; // Ensure it's set to false (0 in the database)
            }

            string updateQuery = "UPDATE reservation_table SET IsCollected = @isCollected, Status = @status WHERE ReservationId = @reservationId";
            string deleteQuery = "DELETE FROM reservation_table WHERE ReservationId = @reservationId";
            string selectQuery = "SELECT UserId, BookId FROM reservation_table WHERE ReservationId = @reservationId";
            string insertBorrowQuery = @"
        INSERT INTO borrow_table (UserId, BookId, BorrowDate, IsReturned) 
        VALUES (@userId, @bookId, NOW(), @isReturned)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlTransaction transaction = connection.BeginTransaction()) // Start Transaction
                    {
                        try
                        {
                            if (status.Equals("Denied", StringComparison.OrdinalIgnoreCase))
                            {
                                // Delete the reservation if status is "Denied"
                                using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection, transaction))
                                {
                                    deleteCmd.Parameters.AddWithValue("@reservationId", reservationId);
                                    deleteCmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Update reservation status
                                using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@isCollected", isCollected ? 1 : 0); // Convert bool to int
                                    cmd.Parameters.AddWithValue("@status", status);
                                    cmd.Parameters.AddWithValue("@reservationId", reservationId);
                                    cmd.ExecuteNonQuery();
                                }

                                // If status is "Confirmed" and isCollected is true, insert into borrow_table
                                if (status.Equals("Confirmed", StringComparison.OrdinalIgnoreCase) && isCollected)
                                {
                                    int userId = 0;
                                    int bookId = 0;

                                    // Retrieve UserID and BookID from reservation_table
                                    using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, connection, transaction))
                                    {
                                        selectCmd.Parameters.AddWithValue("@reservationId", reservationId);
                                        using (MySqlDataReader reader = selectCmd.ExecuteReader())
                                        {
                                            if (reader.Read())
                                            {
                                                userId = reader.GetInt32("UserID");
                                                bookId = reader.GetInt32("BookID");
                                            }
                                            reader.Close(); // Close reader before executing next query
                                        }
                                    }

                                    // Check if the book is available
                                    if (IsBookAvailable(bookId))
                                    {
                                        using (MySqlCommand insertCmd = new MySqlCommand(insertBorrowQuery, connection, transaction))
                                        {
                                            insertCmd.Parameters.AddWithValue("@userId", userId);
                                            insertCmd.Parameters.AddWithValue("@bookId", bookId);
                                            insertCmd.Parameters.AddWithValue("@isReturned", false);

                                            insertCmd.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }

                            transaction.Commit(); // Commit transaction if everything is successful
                            return true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback(); // Rollback in case of an error
                            MessageBox.Show("Error: " + ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
















    }

}


