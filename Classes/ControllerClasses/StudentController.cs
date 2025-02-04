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

        public void login(string username, string password, string role, Form form)
        {
            Student s1 = new Student(username, role, password);
            s1.Login(s1, form);
        }
        public void register(string username, string email, string role, string password, string phoneNumber, Form form)
        {
            Student s1 = new Student(username, email, role, password, phoneNumber);
            s1.Register(s1, form);
        }

        public void LoadOverdueBooks(Person person, DataGridView grid)
        {
            int userId = person.GetUserId(person);
            student.LoadUserOverdueBooks(userId, grid);
        }
        public void DisplayBooks(DataGridView grid)
        {
            BookController bookController = new BookController();
            bookController.DisplayBooks(grid);
        }

        public void LoadBorrrowedBooks(Person person, DataGridView data)
        {
            student.LoadBorrowedBooks(person, data);
        }
        public void LoadReservedBooks(Person person, DataGridView data)
        {
            student.LoadReservedBooks(person, data);
        }
        public void ReturnBook(Person person, int bookId, DataGridView grid)
        {
            bool isReturned = student.ReturnBook(bookId);
            if (isReturned)
            {
                LoadBorrrowedBooks(person, grid);
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
            controller.LoadBookDetails(bookId, title, author, year, isbn, picture);
        }
        public void BorrowBooks(int bookId, TextBox title, TextBox author, TextBox year, TextBox isbn, PictureBox picture, Person person)
        {
            int userid = person.GetUserId(person);
            student.BorrowBook(bookId, person);
            LoadBookDetails(bookId, title, author, year, isbn, picture);

        }
        public void ReserveBook(int bookId, Person person)
        {
            student.ReserveBook(bookId, person);
        }
        public void GetTotalFineAmount(Person person, Label amount, Label MessageLabel)
        {
            decimal totalFine = student.GetTotalFineAmount(person);
            amount.Text = $"${student.GetTotalFineAmount(person).ToString()}";
            MessageLabel.Font = new Font("Arial", 17, FontStyle.Bold);

            if (totalFine > 0)
            {


                if (totalFine > 50)
                {
                    MessageLabel.Font = new Font("Arial", 17, FontStyle.Bold);
                    MessageLabel.ForeColor = Color.Red;
                    MessageLabel.Text = "You have an outstanding fine of " + totalFine.ToString() + "\nYou are not allowed to borrow or Reserve books  until you pay the fine.";
                }
                else
                {

                    MessageLabel.ForeColor = Color.Orange;
                    MessageLabel.Text = "You have an outstanding fine of " + totalFine.ToString();
                }

            }
            else
            {
                MessageLabel.ForeColor = Color.Green;
                MessageLabel.Text = "You have no outstanding fines.\nYou are Good to go!";
            }
        }
        public bool IsOverdue(Person person)
        {
            decimal totalfines = student.GetTotalFineAmount(person);
            if (totalfines > 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
