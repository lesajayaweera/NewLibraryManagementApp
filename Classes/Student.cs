using library_mananagement_system.Forms.Librarian;
using NewLibraryManagementApp.Forms.Librarian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibraryManagementApp.Classes
{
    internal class Student : Person
    {
        public Student(string name, string email, string role, string password, string phoneNumber) : base(name, email, role, password, phoneNumber)
        {
        }
        public Student(string name, string role, string password) : base(name, role, password) { }
        public override void Register(Person person, Form form)
        {
            bool isValidated = person.ValidateData();
            if (isValidated)
            {
                person.SaveData(person);
                StudentDashboard dashboard = new StudentDashboard();
                dashboard.Show();
                form.Hide();
            }
        }
        public override void Login(Person person, Form form)
        {
            bool isAuthorized = person.isAthenticated(person);
            if (isAuthorized)
            {
                StudentDashboard dashboard = new StudentDashboard();
                dashboard.Show();
                form.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
