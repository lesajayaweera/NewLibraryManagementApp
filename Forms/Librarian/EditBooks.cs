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
        private byte[] image;
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

                // Store the initial image and path
                bookpath = selectedRow.Cells["URL"].Value.ToString();

                // Ensure bookpath is not null
                if (selectedRow.Cells["URL"].Value != DBNull.Value)
                {
                    object cellValue = selectedRow.Cells["URL"].Value;

                    if (cellValue is byte[] imageData) // Check if it's a BLOB
                    {
                        image = imageData;
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pictureBoxEdit.Image = Image.FromStream(ms);
                            pictureBoxEdit.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    else // If it's a file path
                    {
                        string bookpath = cellValue.ToString();
                        if (!string.IsNullOrEmpty(bookpath) && System.IO.File.Exists(bookpath))
                        {
                             // Store the initial path
                            pictureBoxEdit.Image = Image.FromFile(bookpath);
                            pictureBoxEdit.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            pictureBoxEdit.Image = null;
                        }
                    }
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

                    // Load image without locking the file
                    using (FileStream fs = new FileStream(bookpath, FileMode.Open, FileAccess.Read))
                    {
                        pictureBoxEdit.Image = Image.FromStream(fs);
                        pictureBoxEdit.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    // Convert the image to byte array
                    image = controller.ImageToByteArray(bookpath);
                }
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string title = titletextBox.Text;
            string author = authortextBox.Text;
            string year = yeartextBox.Text;

            

            controller.EditBooks(selectedBookId, title, author, year, image, dataGridView_editbooks);

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
