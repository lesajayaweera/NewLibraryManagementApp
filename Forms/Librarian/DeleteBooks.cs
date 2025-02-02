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
    public partial class DeleteBooks : Form
    {
        private Book book = new Book();

        private string bookpath;
        private int bookid;
        private Form form;

        private LibrarianController controller = new LibrarianController(); 
        public DeleteBooks(Form form)
        {

            InitializeComponent();
            this.form = form;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBooks_Load(object sender, EventArgs e)
        {
            controller.DisplayBooks(dataGridView_books);




        }

        private void dataGridView_books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_books.Rows[e.RowIndex];

                bookid = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                bookname_text.Text = selectedRow.Cells["Title"].Value.ToString();
                bookauthor_text.Text = selectedRow.Cells["Author"].Value.ToString();
                bookyear_text.Text = selectedRow.Cells["Year"].Value.ToString();
                bookisbn_text.Text = selectedRow.Cells["ISBN"].Value.ToString();
                bookpath = selectedRow.Cells["URL"].Value.ToString();



                if (!string.IsNullOrEmpty(bookpath) && System.IO.File.Exists(bookpath))
                {
                    bookpictureBox.Image = Image.FromFile(bookpath);
                    bookpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    bookpictureBox.Image = null;
                }

            }

        }

        private void removeBookbtn_Click(object sender, EventArgs e)
        {
            controller.DeleteBook(bookid, dataGridView_books);
            bookname_text.Text = "";
            bookauthor_text.Text = "";
            bookyear_text.Text = "";
            bookisbn_text.Text = "";
            bookpath = "";
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }
    }
}
