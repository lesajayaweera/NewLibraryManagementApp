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
        public Student_records()
        {
            InitializeComponent();
        }

        private void StudentRecords_BookManagement_Click(object sender, EventArgs e)
        {
            BookManagement b1 = new BookManagement();
            b1.Show();
            this.Hide();
        }

        private void StudentRecords_home_Click(object sender, EventArgs e)
        {
            AdminDashBoard a1 = new AdminDashBoard();
            a1.Show();
            this.Hide();
        }

        private void StudentRecords_LibraryRecords_Click(object sender, EventArgs e)
        {
            Library_Records l1 = new Library_Records();
            l1.Show();
            this.Hide();
        }

        private void StudentRecords_UserManagement_Click(object sender, EventArgs e)
        {
            User_Management u1 = new User_Management();
            u1.Show();
            this.Hide();

        }

        private void Student_records_Load(object sender, EventArgs e)
        {

        }
    }
}
