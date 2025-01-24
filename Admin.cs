using NewLibraryManagementApp.Forms.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibraryManagementApp
{
    internal class Admin :Person
    {
        public Admin(string name, string email, string role, string password, string phoneNumber) : base(name, email, role, password, phoneNumber)
        {
        }
        public Admin()
        {
        }
        public override void Login(Person person, Form form)
        {
            
        }
        public override void Register(Person person, Form form)
        {
            bool isValidated = person.ValidateData();
            if (isValidated)
            {
                person.SaveData(person);
                AdminDashBoard a1 = new AdminDashBoard();
                a1.Show();
                form.Hide();
            }
        }
    }
}
