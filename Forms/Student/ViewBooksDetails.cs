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

             book.CheckBookStatus(selectedBookId, status_text);
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            int userId=person.GetUserId(person);
            book.BorrowBook(selectedBookId,person);
        }
    }
}
