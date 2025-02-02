using NewLibraryManagementApp.Classes;
using NewLibraryManagementApp.Classes.ControllerClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewLibraryManagementApp
{
    public partial class ViewBooksDetails : Form
    {
        private Form form;
        private Book book = new Book();
        private int selectedBookId;
        private Person person;

        private StudentController controller = new StudentController();

        public ViewBooksDetails(Form form, int selectedBookId, Person person)
        {
            InitializeComponent();
            this.form = form;
            this.selectedBookId = selectedBookId;
            this.person = person;
        }



        private void back_btn_bookDetails_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }

        private void ViewBooksDetails_Load(object sender, EventArgs e)
        {
            controller.LoadBookDetails(selectedBookId, title_text_veiwBooks, author_text_veiwBooks, year_text_veiwBooks, isbn_text_veiwBooks, book_picture_viewBook);
            bool isreturned = book.CheckBookStatus(selectedBookId);
            bool isReserved = book.CheckBookCanReserve(selectedBookId);
            if (isreturned)
            {
                
                borrowBtn.Enabled = true;
                //reserveBtn.Enabled = false;

                status_text.Text = "Available";
                status_text.ForeColor = Color.Green;
            }
            else
            {
                if (isReserved)
                {
                    

                    borrowBtn.Enabled = false;
                    reserveBtn.Enabled = false;
                    status_text.Text = "Reserved";
                    status_text.ForeColor = Color.Red;
                }
                else
                {
                    borrowBtn.Enabled = false;
                    reserveBtn.Enabled = true;
                    status_text.Text = "Currently Borrowed but Available for Reservations!";
                    status_text.ForeColor = Color.Orange;
                }
            }
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            
            controller.BorrowBooks(selectedBookId, title_text_veiwBooks, author_text_veiwBooks, year_text_veiwBooks, isbn_text_veiwBooks, book_picture_viewBook, person);
            bool isreturned = book.CheckBookStatus(selectedBookId);
            bool isReserved = book.CheckBookCanReserve(selectedBookId);
            if (isreturned)
            {

                borrowBtn.Enabled = true;
                //reserveBtn.Enabled = false;

                status_text.Text = "Available";
                status_text.ForeColor = Color.Green;
            }
            else
            {
                if (isReserved)
                {


                    borrowBtn.Enabled = false;
                    reserveBtn.Enabled = false;
                    status_text.Text = "Reserved";
                    status_text.ForeColor = Color.Red;
                }
                else
                {
                    borrowBtn.Enabled = false;
                    reserveBtn.Enabled = true;
                    status_text.Text = "Currently Borrowed but Available for Reservations!";
                    status_text.ForeColor = Color.Orange;
                }
            }
        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            controller.ReserveBook(selectedBookId, person);

            bool isreturned = book.CheckBookStatus(selectedBookId);
            bool isReserved = book.CheckBookCanReserve(selectedBookId);
            if (isreturned)
            {

                borrowBtn.Enabled=true;
                //reserveBtn.Enabled = false;

                status_text.Text = "Available";
                status_text.ForeColor = Color.Green;
            }
            else
            {
                if (isReserved)
                {


                    borrowBtn.Enabled = false;
                    reserveBtn.Enabled = false;
                    status_text.Text = "Reserved";
                    status_text.ForeColor = Color.Red;
                }
                else
                {
                    borrowBtn.Enabled = false;
                    reserveBtn.Enabled = true;
                    status_text.Text = "Currently Borrowed but Available for Reservations!";
                    status_text.ForeColor = Color.Orange;
                }
            }
        }
    }
}
