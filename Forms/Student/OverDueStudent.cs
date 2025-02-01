using library_mananagement_system.Forms.Librarian;
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

namespace NewLibraryManagementApp.Forms.Student
{
    public partial class OverDueStudent : Form
    {


        public OverDueStudent(Person person)
        {
            InitializeComponent();
            this.person = person;

        }
        private Person person;
        private Book book = new Book();


        private void OverDueStudent_Load(object sender, EventArgs e)
        {
            int userId = person.GetUserId(person);
            book.LoadUserOverdueBooks(userId, dataGridViewOverdue_student);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDashboard db = new StudentDashboard(person,this);
            db.Show();
            this.Hide();
        }
    }
}
