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
    public partial class ReturnBooks : Form
    {
        private Form form;
        private Person person;
        private Book book = new Book();
        private int bookId;
        public ReturnBooks(Form form, Person person)
        {
            InitializeComponent();
            this.form = form;
            this.person = person;
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            book.LoadBorrowedBooks(person, dataGridView_returnBooks);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }

        private void dataGridView_returnBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_returnBooks.Rows[e.RowIndex];
                bookId = Convert.ToInt32(row.Cells["BorrowedId"].Value);

            }
        }

        private void returnBook_btn_Click(object sender, EventArgs e)
        {
            
            bool sucess = book.ReturnBook(bookId);
            if (sucess)
            {
                
                book.LoadBorrowedBooks(person, dataGridView_returnBooks);
            }
            else
            {
                MessageBox.Show("Failed to return book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
