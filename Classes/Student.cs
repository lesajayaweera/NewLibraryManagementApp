using library_mananagement_system.Forms.Librarian;
using NewLibraryManagementApp.Forms.Librarian;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace NewLibraryManagementApp.Classes
{
    internal class Student : Person
    {
        private string connectionString = "Server=127.0.0.1;Database=library_management_system;User ID=root;Password=;";

        public Student() { }
        public Student(string name, string email, string role, string password, string phoneNumber) : base(name, email, role, password, phoneNumber)
        {
        }
        public Student(string name, string role, string password) : base(name, role, password) { }
        public override void Register(Person person, Form form)
        {
            bool isValidated = person.ValidateData();
            bool isCredentialExits = person.isCredentialExist(person);
            if (isValidated)
            {
                if (isCredentialExits)
                {
                    person.SaveData(person);
                    StudentDashboard dashboard = new StudentDashboard(person, form);
                    dashboard.Show();
                    form.Hide();
                }
                
            }
        }
        public override void Login(Person person, Form form)
        {
            bool isAuthorized = person.isAthenticated(person);
            if (isAuthorized)
            {
                StudentDashboard dashboard = new StudentDashboard(person, form);
                dashboard.Show();
                form.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadUserOverdueBooks(int userId, DataGridView dataGridView)
        {
            string query = @"
        SELECT 
            o.OverdueId,
            o.BookID,
            bk.Title AS BookTitle,
            bk.Author AS BookAuthor,
            o.OverdueDays,
            
            o.FineAmount
        FROM overdue_table o
        JOIN books_table bk ON o.BookID = bk.ID
        WHERE o.UserId = @userId AND o.PaidStatus = 0 
        ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable overdueBooksTable = new DataTable();
                            adapter.Fill(overdueBooksTable);

                            // Bind DataGridView
                            dataGridView.DataSource = overdueBooksTable;
                            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
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
        public bool ReturnBook(int borrowedId, DateTime returnDate)
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
        public void BorrowBook(int bookId, Person person)
        {
            Book book = new Book();
            int studentId = person.GetUserId(person); // Fetch user ID
            bool canBorrowOrReserve = book.CanUserBorrowOrReserve(person);
            // Validate user existence
            if (canBorrowOrReserve)
            {
                if (studentId == 0)
                {
                    MessageBox.Show($"User '{person.Name}' not found. Please enter a valid username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the book is available
                if (!book.IsBookAvailable(bookId))
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
        public void ReserveBook(int bookId, Person person)
        {
            Book book = new Book();
            bool canBorrowOrReserve = book.CanUserBorrowOrReserve(person);
            if (canBorrowOrReserve)
            {
                bool isReserved = book.CheckBookCanReserve(bookId);
                bool isSameUser = book.CheckUserReserveBook(bookId, person);
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

    }
}
