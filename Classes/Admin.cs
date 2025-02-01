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


    }
}
