using library_mananagement_system.Forms.Librarian;
using NewLibraryManagementApp.Forms.Admin;
using NewLibraryManagementApp.Forms.Librarian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
