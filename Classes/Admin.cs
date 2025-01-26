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
    }
}
