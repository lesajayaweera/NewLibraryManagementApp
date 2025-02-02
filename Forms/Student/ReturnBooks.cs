using NewLibraryManagementApp.Classes;
using NewLibraryManagementApp.Classes.ControllerClasses;
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

        private StudentController controller = new StudentController();
        public ReturnBooks(Form form, Person person)
        {
            InitializeComponent();
            this.form = form;
            this.person = person;
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            controller.LoadBorrrowedBooks(person, dataGridView_returnBooks);
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
            DateTime returnDate = dateTimePicker1.Value;


            

            controller.ReturnBook(person,bookId,returnDate, dataGridView_returnBooks);
        }
    }
}
