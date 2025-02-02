using NewLibraryManagementApp.Classes;
using NewLibraryManagementApp.Classes.ControllerClasses;
using NewLibraryManagementApp.Forms.Librarian;
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
    public partial class AddBooks : Form
    {
        private string filePath;
        private Form form;
        private LibrarianController controller = new LibrarianController();
        Person person;
        public AddBooks(Form form,Person person)
        {
            InitializeComponent();
            this.form = form;
            this.person = person;

        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void uploadImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath = ofd.FileName;

                    Book_pictureBox.Image = Image.FromFile(filePath);
                    Book_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void addBook_btn_Click(object sender, EventArgs e)
        {
            string title = title_text.Text;
            string author = author_text.Text;
            string year = year_text.Text;


            controller.AddBook(title, author, filePath,year, isbn_text);

            


        }

        private void button_Click(object sender, EventArgs e)
        {

            LibrarianDashBoard dashboard = new LibrarianDashBoard(person);
            dashboard.Show();
            this.Hide();
        }
    }
}
