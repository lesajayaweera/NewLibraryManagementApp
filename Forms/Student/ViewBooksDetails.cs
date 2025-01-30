using NewLibraryManagementApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLibraryManagementApp
{
    public partial class ViewBooksDetails : Form
    {
        private Form form;
        private Book book = new Book();
        private int selectedBookId;
        private Person person;


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
            Book selectedBook = book.LoadBookDetails(selectedBookId);
            if (selectedBook != null)
            {
                title_text_veiwBooks.Text = selectedBook.Title;
                author_text_veiwBooks.Text = selectedBook.Author;
                year_text_veiwBooks.Text = selectedBook.Year.ToString();
                isbn_text_veiwBooks.Text = selectedBook.Isbn.ToString();


                if (!string.IsNullOrEmpty(selectedBook.Url) && System.IO.File.Exists(selectedBook.Url))
                {
                    book_picture_viewBook.Image = Image.FromFile(selectedBook.Url);
                    book_picture_viewBook.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    book_picture_viewBook.Image = null;
                }

            }

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
                if(isReserved)
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
            int userId = person.GetUserId(person);
            book.BorrowBook(selectedBookId, person);
        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            book.ReserveBook(selectedBookId, person);
        }
    }
}
