using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibraryManagementApp.Classes.ControllerClasses
{
    internal class BookController
    {
        public BookController() { }

        private Book book = new Book();

        

        public void DisplayBooks(DataGridView grid)
        {
            book.DisplayBooks(grid);
        }

        public void LoadOverDueBooks(DataGridView grid)
        {
            book.LoadOverdueBooks(grid);
        }
        public void setPaidStatus(int overdueId, RadioButton paidCheckBox, RadioButton notPaidCheckBox)
        {
            book.SetPaidStatus(overdueId, paidCheckBox, notPaidCheckBox);
        }

        public bool UpdateOverDueStatus (int overdueId, bool isPaid)
        {
            bool status = book.UpdateOverdueStatus(overdueId, isPaid);
            return status;
        }

        public void SaveBook(string title, string author, byte[] filepath, string year,TextBox isbnText)
        {
            if (book.ValidateTitle(title, out string updatedTitle) && book.ValidateAuthor(author, out string updatedAuthor)) 
            {
                    if (book.ValidateYear(year, out int updatedYear))
                    {
                        Book book = new Book(title, author, updatedYear, filepath);
                        isbnText.Text = book.Isbn;
                        book.saveBook(book);
                    }
            }
        }
        public void DeleteBook(int BookId)
        {
            book.DeleteBook(BookId);
        }

        public void EditBooks(int bookid, string title, string author, string year, byte[] url)
        {
            if (book.ValidateTitle(title, out string updatedTitle) && book.ValidateAuthor(author, out string updatedAuthor))
                {
                if (book.ValidateYear(year, out int updatedYear))
                {
                    if (bookid > 0)
                    {
                        Book updatedbook = new Book(bookid, title, author, updatedYear, url);
                        book.EditBook(updatedbook);
                    }
                    else
                    {
                        MessageBox.Show("Please select a book first.", "Book Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
            }
        }
        public void LoadBookDetails(int bookId, TextBox title, TextBox author, TextBox year, TextBox isbn, PictureBox picture)
        {
            Book selectedBook = book.LoadBookDetails(bookId);

            if (selectedBook != null)
            {
                title.Text = selectedBook.Title;
                author.Text = selectedBook.Author;
                year.Text = selectedBook.Year.ToString();
                isbn.Text = selectedBook.Isbn.ToString();

                // Convert byte[] to Image for PictureBox
                if (selectedBook.Url != null && selectedBook.Url.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(selectedBook.Url))
                    {
                        picture.Image = Image.FromStream(ms);
                        picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    picture.Image = null; // No image available
                }
            }
        }

        // convert the string imagepath to Byte[]

        public byte[] ImageToByteArray(string imagepath)
        {
            return book.ImageToByteArray(imagepath);
        }

        



    }
}
