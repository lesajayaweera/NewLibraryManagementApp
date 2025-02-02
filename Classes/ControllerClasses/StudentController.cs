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

        public void LoadOverdueBooks(Person person,DataGridView grid)
        {
            int userId = person.GetUserId(person);
            student.LoadUserOverdueBooks(userId, grid);
        }
        public void DisplayBooks(DataGridView grid)
        {
            BookController bookController = new BookController();
            bookController.DisplayBooks(grid);
        }

        public void LoadBorrrowedBooks(Person person,DataGridView data)
        {
            student.LoadBorrowedBooks(person, data);
        }
        public void LoadReservedBooks(Person person, DataGridView data)
        {
            student.LoadReservedBooks(person, data);
        }
        public void ReturnBook(Person person,int bookId,DateTime returnDate,DataGridView grid)
        {
            bool isReturned = student.ReturnBook(bookId, returnDate);
            if(isReturned)
            {
                LoadBorrrowedBooks(person,grid);
            }
            else
            {
                MessageBox.Show("Failed to return book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public string GetTotalBorrowedBooks(Person person)
        {
            return student.GetTotalBorrowedBooks(person).ToString();
        }
        public void LoadBookDetails(int bookId, TextBox title, TextBox author, TextBox year, TextBox isbn, PictureBox picture)
        {
            BookController controller = new BookController();
            controller.LoadBookDetails(bookId,title,author,year,isbn,picture);
        }
        public void BorrowBooks(int bookId, TextBox title, TextBox author, TextBox year, TextBox isbn, PictureBox picture, Person person)
        {
            int userid = person.GetUserId(person);
            student.BorrowBook(bookId, person);
            LoadBookDetails(bookId, title,author,year,isbn,picture);

        }
        public void ReserveBook(int bookId,Person person)
        {
            student.ReserveBook(bookId, person);
        }
    }
}
