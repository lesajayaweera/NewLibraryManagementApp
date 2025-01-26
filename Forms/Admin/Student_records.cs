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
    public partial class Student_records : Form
    {
        private Person person;
        private Form form;

        public Student_records(Person person, Form form)
        {
            this.person = person;
            this.form = form;
            InitializeComponent();
        }

        private void StudentRecords_BookManagement_Click(object sender, EventArgs e)
        {
            BookManagement b1 = new BookManagement(person, form);
            b1.Show();
            this.Hide();
        }

        private void StudentRecords_home_Click(object sender, EventArgs e)
        {
            AdminDashBoard a1 = new AdminDashBoard(person, form);
            a1.Show();
            this.Hide();
        }

        private void StudentRecords_LibraryRecords_Click(object sender, EventArgs e)
        {
            Library_Records l1 = new Library_Records(person, form);
            l1.Show();
            this.Hide();
        }

        private void StudentRecords_UserManagement_Click(object sender, EventArgs e)
        {
            User_Management u1 = new User_Management(person, form);
            u1.Show();
            this.Hide();

        }

        private void Student_records_Load(object sender, EventArgs e)
        {

        }
    }
}
