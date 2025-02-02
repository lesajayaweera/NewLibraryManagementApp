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

        public void UpdateReservations(RadioButton collected,RadioButton notCollected,string currentStatus,int reservationId,DataGridView data)
        {
            bool iscollected = false;


            BookController controller = new BookController();   
            if (collected.Checked)
            {
                iscollected = true;
            }
            else if (notCollected.Checked)
            {
                iscollected = false;
            }

            bool status = librarian.UpdateReservationStatus(reservationId, iscollected, currentStatus);
            if(status)
            {
                LoadReservations(data);
            }
            
        }

        public void LoadReservations(DataGridView grid)
        {
            
            librarian.LoadReservationBooks(grid);
        }

        public void SetCollectStatus(int reservationId,RadioButton collect, RadioButton notCollect,ComboBox box)
        {
            librarian.SetCollectStatus(reservationId,collect,notCollect,box);
        }

        public void LoadOverDueBooks(DataGridView grid)
        {
            BookController controller = new BookController();
            controller.LoadOverDueBooks(grid);
        }
        public void SetPaidStatus(int overdueId, RadioButton paidCheckBox, RadioButton notPaidCheckBox)
        {
            BookController controller = new BookController();
            controller.setPaidStatus(overdueId,paidCheckBox,notPaidCheckBox);
        }
        public void UpdateOverdue(RadioButton paid, RadioButton notpaid, int overdueId, DataGridView grid)
        {
            bool ispaid = false;

            if (paid.Checked)
            {
                ispaid = true;
            }
            else if (notpaid.Checked)
            {
                ispaid = false;
            }

            BookController controller = new BookController();
            bool isUpdated = controller.UpdateOverDueStatus(overdueId, ispaid);
            if (isUpdated)
            {
                LoadOverDueBooks(grid);
            }
        }

        public string GetBookCount()
        {

            return librarian.GetBookCount().ToString();
        }

        public void DisplayBooks(DataGridView grid)
        {
            BookController controller = new BookController();
            controller.DisplayBooks(grid);
        }

        public void AddBook(string title,string author,string filepath,string year, TextBox isbnText)
        {
            BookController controller = new BookController();
            controller.SaveBook(title, author, filepath, year,isbnText);

        }

        public void DeleteBook(int bookId,DataGridView grid)
        {
            BookController controller = new BookController();
            controller.DeleteBook(bookId);
            DisplayBooks(grid);

        }

        public void EditBooks(int bookid , string title,string author, string year,string url,DataGridView grid)
        { 
            BookController controller = new BookController();
            controller.EditBooks(bookid,title,author,year,url);
            DisplayBooks(grid);
        }
    }
}
