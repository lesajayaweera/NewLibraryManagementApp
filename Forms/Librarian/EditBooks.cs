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

namespace NewLibraryManagementApp
{
    public partial class EditBooks : Form
    {
        private Form form;
        private Book book = new Book();
        private int selectedBookId;
        private string bookpath;

        private LibrarianController controller = new LibrarianController();
        public EditBooks(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void EditBooks_Load(object sender, EventArgs e)
        {
            controller.DisplayBooks(dataGridView_editbooks);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }

        private void dataGridView_editbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_editbooks.Rows[e.RowIndex];

                selectedBookId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                titletextBox.Text = selectedRow.Cells["Title"].Value.ToString();
                authortextBox.Text = selectedRow.Cells["Author"].Value.ToString();
                yeartextBox.Text = selectedRow.Cells["Year"].Value.ToString();
                isbntextBox.Text = selectedRow.Cells["ISBN"].Value.ToString();

                // Ensure bookpath is not null
                bookpath = selectedRow.Cells["URL"].Value != DBNull.Value ? selectedRow.Cells["URL"].Value.ToString() : "";

                if (!string.IsNullOrEmpty(bookpath) && System.IO.File.Exists(bookpath))
                {
                    pictureBoxEdit.Image = Image.FromFile(bookpath);
                    pictureBoxEdit.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBoxEdit.Image = null;
                }
            }
        }

        private void uploadbtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    bookpath = ofd.FileName;

                    pictureBoxEdit.Image = Image.FromFile(bookpath);
                    pictureBoxEdit.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string title = titletextBox.Text;
            string author = authortextBox.Text;
            string year = yeartextBox.Text;


            controller.EditBooks(selectedBookId, title, author, year, bookpath, dataGridView_editbooks);

            // Clear Fields
            titletextBox.Text = "";
            authortextBox.Text = "";
            yeartextBox.Text = "";
            isbntextBox.Text = "";
            bookpath = "";
            pictureBoxEdit.Image = null;
        }

    }
}
