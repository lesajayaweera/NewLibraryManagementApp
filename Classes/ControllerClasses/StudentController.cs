using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibraryManagementApp.Classes.ControllerClasses
{
    internal class StudentController
    {
        private Student student = new Student();

        public StudentController() { }  

        public void login(string username, string password,string  role, Form form) 
        {
            Student s1 = new Student(username,role,password);
            s1.Login(s1,form);
        }
        public void register(string username, string email, string role, string password, string phoneNumber, Form form)
        {
            Student s1 = new Student(username, email, role, password, phoneNumber);
            s1.Register(s1, form);
        }
    }
}
