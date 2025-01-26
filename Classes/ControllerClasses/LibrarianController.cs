using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibraryManagementApp.Classes.ControllerClasses
{
    internal class LibrarianController
    {
        private Librarian librarian = new Librarian();
        public LibrarianController() { }

        public void login(string username, string password,string role,Form form)
        {
           Librarian l1 = new Librarian(username,role, password);
            l1.Login(l1,form);
        }
        public void register(string username, string email, string role, string password, string phoneNumber, Form form)
        {
            Librarian l1 = new Librarian(username, email, role, password, phoneNumber);
            l1.Register(l1 ,form);
        }
    }
}
