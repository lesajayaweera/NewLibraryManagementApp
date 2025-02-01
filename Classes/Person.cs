using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibraryManagementApp.Classes
{
    // making the class abstract
    public abstract class Person
    {
        // Encapsulation
        private string name;
        private string email;
        private string phoneNumber;
        private string role;
        private string password;


        private string ConnectionString = "Server=127.0.0.1;Database=library_management_system;User ID=root;Password=;";

        // creating getters and setters

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        
        // Creating Constructors


        /* 
         for the Register 
        */
        public Person(string name, string email, string role, string password, string phoneNumber)
        {

            this.name = name;
            this.email = email;
            this.role = role;
            this.password = password;
            this.phoneNumber = phoneNumber;
        }
        /* 
         for the Login 
        */

        public Person(string name, string role, string password)
        {
            this.name = name;
            this.role = role;
            this.password = password;
        }

        /*
          empty constructors
         */
        public Person() { }

        // Methods 


        // Register method
        public abstract void Register(Person person, Form form);


        // Login method
        public abstract void Login(Person person, Form form);


        // to validate the user Inputed data
        public bool ValidateData()
        {
            if (Validateusername() && Validateemail() && Validatephone() && validatePassword())
            {

                return true;
            }
            else
            {

                return false;
            }
        }

        // to check the Username  
        public bool Validateusername()
        {
            // Updated validation logic
            if (!string.IsNullOrWhiteSpace(Name) && Name.Length >= 5 && Name.Length <= 15 && Name.All(char.IsLetter))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Username should contain only letters and greater than 5 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }


        // to check the email
        public bool Validateemail()
        {
            // Updated validation logic
            if (!string.IsNullOrWhiteSpace(Email) && Email.Contains("@") && Email.Length <= 25)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Email should contain '@' and should not be empty.\nAnd need to has 25 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // to check the phone number
        public bool Validatephone()
        {
            // Updated validation logic
            if (phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Phone Number! It should contain exactly 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // to check the password
        public bool validatePassword()
        {
            // Updated validation logic
            if (Password.Length >= 8 && Password.Length <= 15 && Password.All(char.IsLetterOrDigit))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Password! It should be between 8 and 15 characters long and contain only letters and digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // save person to the database
        public void SaveData(Person person)
        {
            string query = $"INSERT INTO {person.role.ToLower()}_table (name, email, role, password, phoneNumber) VALUES (@name, @email, @role, @password, @phone)";
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", person.Name);
                        command.Parameters.AddWithValue("@email", person.Email);
                        command.Parameters.AddWithValue("@role", person.Role);
                        command.Parameters.AddWithValue("@password", person.Password);
                        command.Parameters.AddWithValue("@phone", person.PhoneNumber);
                        int rowsAffected = command.ExecuteNonQuery();

                    }
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
        public bool isCredentialExist(Person person)
        {
            string query = $"SELECT COUNT(*) FROM {person.role.ToLower()}_table WHERE name = @username AND email = @email";
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", person.name);
                        command.Parameters.AddWithValue("@email", person.email);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count == 1)
                        {
                            MessageBox.Show("Username or the Gmail has bee used by another User!","Register Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public bool isUsernameExist(Person person)
        {
            string query = $"SELECT COUNT(*) FROM {person.Role.ToLower()}_table WHERE name = @username ";
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", person.Name);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count == 1)
                        {
                            MessageBox.Show("Username  has bee used by another User!", "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public bool isAthenticated(Person person)
        {
            string query = $"SELECT COUNT(*) FROM {person.role.ToLower()}_table WHERE name = @username AND password = @password AND role = @role";

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", person.name);
                        command.Parameters.AddWithValue("@password", person.password);
                        command.Parameters.AddWithValue("@role", person.role);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // to get the user id
        public int GetUserId(Person person)
        {
            string query = $"SELECT Id  FROM {person.Role.ToLower()}_table WHERE name = @Username";
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", person.Name);
                        object result = command.ExecuteScalar();

                        return (result != null) ? Convert.ToInt32(result) : 0; // Return UserID or 0 if not found
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0; // Return 0 if error occurs
                }
                catch(Exception ex)
                {
                    MessageBox.Show($" Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0; // Return 0 if error occurs

                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // method to get the most active user 
        public string GetMostActiveUser()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                try
                {
                    // SQL query to find the user with the most active borrowings (not returned)
                    string query = @"
            SELECT u.name, COUNT(b.userId) AS borrowingCount
            FROM borrowed_records b
            JOIN student_table u ON b.userId = u.Id
            WHERE b.IsReturned = 0
            GROUP BY b.userId
            ORDER BY borrowingCount DESC
            LIMIT 1;
            ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the user name and borrowing count
                                string userName = reader.GetString("name");
                                int borrowingCount = reader.GetInt32("borrowingCount");

                                // Return the most active user information as a string
                                return $"Most Active User: {userName}\nActive Borrowings: {borrowingCount}";
                            }
                            else
                            {
                                return "No active users found.";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    return "An error occurred: " + ex.Message;
                }
            }
        }



    }
}
