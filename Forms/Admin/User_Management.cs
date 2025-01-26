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

namespace NewLibraryManagementApp.Forms.Admin
{
    public partial class User_Management : Form
    {
        private Person person;
        private Form form;
        public User_Management(Person person, Form form)
        {
            this.person = person;
            this.form = form;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void UserManagement_home_Click(object sender, EventArgs e)
        {
            AdminDashBoard dashboard = new AdminDashBoard(person, form);
            dashboard.Show();
            this.Hide();
        }

        private void UserManagement_BookManagement_Click(object sender, EventArgs e)
        {
            BookManagement book = new BookManagement(person, form);
            book.Show();
            this.Hide();
        }

        private void UserManagement_LibraryRecords_Click(object sender, EventArgs e)
        {
            Library_Records library_Records = new Library_Records(person, form);
            library_Records.Show();
            this.Hide();
        }

        private void UserManagement_StudentRecords_Click(object sender, EventArgs e)
        {
            Student_records student_Records = new Student_records(person, form);
            student_Records.Show();
            this.Hide();

        }

        private void User_Management_Load(object sender, EventArgs e)
        {

        }
    }
}
