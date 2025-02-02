using library_mananagement_system.Forms.Librarian;
using NewLibraryManagementApp.Forms.Admin;
using NewLibraryManagementApp.Forms.Librarian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;


namespace NewLibraryManagementApp.Classes
{
    internal class Librarian : Person
    {
        public Librarian() { }  
        public Librarian(string name, string email, string role, string password, string phoneNumber) : base(name, email, role, password, phoneNumber)
        {
        }
        public Librarian(string name, string role, string password) : base(name, role, password)
        {

        }
        private string connectionString = "Server=127.0.0.1;Database=library_management_system;User ID=root;Password=;";

        public override void Login(Person person, Form form)
        {
            bool isAuthorized = person.isAthenticated(person);
            if (isAuthorized)
            {
                LibrarianDashBoard dashboard = new LibrarianDashBoard(person);
                dashboard.Show();
                form.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Register(Person person, Form form)
        {
            bool isValidated = person.ValidateData();
            if (isValidated)
            {
                person.SaveData(person);
                LibrarianDashBoard s1 = new LibrarianDashBoard(person);
                s1.Show();
                form.Hide();

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

        public bool IsBookAvailable(int bookId)
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
        INSERT INTO borrowed_records (UserId, BookId, BorrowDate, DueDate,IsReturned) 
        VALUES (@userId, @bookId, NOW(),@DueDate, @isReturned)";

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
                                            insertCmd.Parameters.AddWithValue("@DueDate", DateTime.Now.AddDays(14));
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

       

    }
}
