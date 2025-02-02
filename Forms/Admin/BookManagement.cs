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

namespace NewLibraryManagementApp.Forms.Admin
{
    public partial class BookManagement : Form
    {
        private Person person;
        private Form form;
        private Book book = new Book();

        private AdminController adminController = new AdminController();
        public BookManagement(Person person,Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Home_btn_HomeManagement_Click(object sender, EventArgs e)
        {
            AdminDashBoard a1 = new AdminDashBoard(person,this);
            a1.Show();
            this.Hide();
        }

        private void LibraryRecords_btn_HomeManagement_Click(object sender, EventArgs e)
        {
            Library_Records l1 = new Library_Records(person,this);
            l1.Show();
            this.Hide();
        }

        private void BookManagement_Load(object sender, EventArgs e)
        {
            label4.Text = adminController.GetBookCount();
            label5.Text = adminController.GetOverdueBookCount();
            label6.Text =adminController.GetBorrowedBookCount();

            adminController.DisplayBooks(dataGridView_bookManagement);
        }
    }
}
