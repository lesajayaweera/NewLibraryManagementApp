using library_mananagement_system.Forms.Librarian;
using NewLibraryManagementApp.Forms.Librarian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibraryManagementApp
{
    internal class Librarian :Person
    {

        public Librarian(string name, string email, string role, string password, string phoneNumber) : base(name, email, role, password, phoneNumber)
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
                LibrarianDashBoard s1 = new LibrarianDashBoard();
                s1.Show();
                form.Hide();

            }
        }
    }
}
