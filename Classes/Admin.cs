using MySql.Data.MySqlClient;
using NewLibraryManagementApp.Forms.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibraryManagementApp.Classes
{
    internal class Admin : Person
    {
        private string ConnectionString = "Server=127.0.0.1;Database=library_management_system;User ID=root;Password=;";

        public Admin(string name, string email, string role, string password, string phoneNumber) : base(name, email, role, password, phoneNumber)
        {
        }
        public Admin(string name, string role, string password) : base(name, role, password)
        {

        }

        
        public Admin()
        {
        }
        public override void Login(Person person, Form form)
        {
            bool isAuthorized = person.isAthenticated(person);
            if (isAuthorized)
            {
                AdminDashBoard dashboard = new AdminDashBoard(person , form);
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
            bool iscredentialExist = person.isCredentialExist(person);
            if (isValidated)
            {
                if (iscredentialExist)
                {
                    MessageBox.Show("This user already exist");
                }
                else
                {
                    person.SaveData(person);
                    AdminDashBoard a1 = new AdminDashBoard(person, form);
                    a1.Show();
                    form.Hide();
                    MessageBox.Show("User Registered Successfully");
                }

            }


        }

        // display the users to the data grid view
        public void DisplayUsers(string user, DataGridView table)
        {
            string query = $"SELECT * FROM {user.ToLower()}_table";
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                    DataTable usertable = new DataTable();
                    adapter.Fill(usertable);


                    table.DataSource = usertable;
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
        
        public void UpdateUserCredentials(int id, Person person)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlTransaction transaction = conn.BeginTransaction()) // Start transaction
                {
                    try
                    {
                        string query = $"UPDATE {person.Role.ToLower()}_table SET name = @Name, password = @Password WHERE Id = @Id";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.Parameters.AddWithValue("@Name", person.Name);
                            cmd.Parameters.AddWithValue("@Password", person.Password);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                transaction.Commit(); // Commit transaction if successful
                                MessageBox.Show("User credentials updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                transaction.Rollback(); // Rollback if no rows were updated
                                MessageBox.Show("No user was found with the given ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Rollback on error
                        MessageBox.Show("Transaction failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        public void DeleteUser(int id, string role)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlTransaction transaction = conn.BeginTransaction()) // Start transaction
                {
                    try
                    {
                        bool hasOutstandingBorrowing = false;
                        bool hasOverdueFine = false;

                        // Check if the student has any outstanding borrowings
                        if (role.ToLower() == "student")
                        {
                            string checkBorrowingQuery = "SELECT COUNT(*) FROM borrowed_records WHERE UserId = @Id AND isReturned = 0";
                            using (MySqlCommand cmd = new MySqlCommand(checkBorrowingQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Id", id);
                                hasOutstandingBorrowing = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                            }

                            // Check if the student has any overdue fines
                            string checkOverdueFineQuery = "SELECT COUNT(*) FROM overdue_table WHERE UserID = @Id AND PaidStatus = 0";
                            using (MySqlCommand cmd = new MySqlCommand(checkOverdueFineQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Id", id);
                                hasOverdueFine = Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                            }

                            // If there are outstanding borrowings or overdue fines, do not proceed with deletion
                            if (hasOutstandingBorrowing || hasOverdueFine)
                            {
                                MessageBox.Show("User has outstanding borrowings or overdue fines. Cannot delete the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaction.Rollback(); // Rollback transaction
                                return; // Exit the method if deletion is not allowed
                            }
                        }

                        // Delete student-related data (if role is student)
                        if (role.ToLower() == "student")
                        {
                            string deleteReservationsQuery = "DELETE FROM reservation_table WHERE UserId = @Id";
                            string deleteBorrowedDetailsQuery = "DELETE FROM borrowed_records WHERE UserId = @Id";
                            string deleteOverdueFineQuery = "DELETE FROM overdue_table WHERE UserID = @Id";

                            using (MySqlCommand cmd = new MySqlCommand(deleteReservationsQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Id", id);
                                cmd.ExecuteNonQuery();
                            }

                            using (MySqlCommand cmd = new MySqlCommand(deleteBorrowedDetailsQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Id", id);
                                cmd.ExecuteNonQuery();
                            }

                            using (MySqlCommand cmd = new MySqlCommand(deleteOverdueFineQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Id", id);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Delete the user from the specific role table (e.g., student, admin, etc.)
                        string deleteUserQuery = $"DELETE FROM {role.ToLower()}_table WHERE Id = @Id";

                        using (MySqlCommand cmd = new MySqlCommand(deleteUserQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Id", id);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                transaction.Commit(); // Commit transaction if successful
                                MessageBox.Show($"User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                transaction.Rollback(); // Rollback if no user was deleted
                                MessageBox.Show("No user found with the given ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Rollback on error
                        MessageBox.Show("Transaction failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public string GetMostBorrowedBook()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
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

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
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

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
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
        public int GetBorrowedBookCount()
        {
            int count = 0;

            string query = "SELECT COUNT(*) FROM borrowed_records WHERE IsReturned = 0";
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
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
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
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
        public int GetBookCount()
        {
            int count = 0;

            string query = "SELECT COUNT(*) FROM books_table";
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
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
