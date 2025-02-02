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
    public partial class AdminDashBoard : Form
    {
        private Form form;
        private Person person;

        AdminController controller = new AdminController();


        public AdminDashBoard(Person p1, Form form)
        {
            InitializeComponent();
            this.form = form;
            this.person = p1;

        }
        








        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void HomeManagement_btn_HomeManagement_Click(object sender, EventArgs e)
        {

            BookManagement form = new BookManagement(person, this);
            form.Show();
            this.Hide();
        }

        private void LibraryRecords_btn_HomeManagement_Click(object sender, EventArgs e)
        {
            Library_Records l1 = new Library_Records(person, this);
            l1.Show();
            this.Hide();
        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {
            label3.Text = $"{person.Name}";
            controller.displayUser("student", dataGridView1);
            controller.displayUser("librarian", dataGridView2);

            overdue_books.Text = controller.GetOverdueBookCount();
            borrowed_books.Text = controller.GetBorrowedBookCount();



        }



        private void User_btn_HomeManagement_Click(object sender, EventArgs e)
        {
            User_Management form = new User_Management(person, this);
            form.Show();
            this.Hide();
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void OverDue_btn_HomeManagement_Click(object sender, EventArgs e)
        {
            OverDueAdmin form = new OverDueAdmin(this,person);
            form .Show();   
            this.Hide();
        }
    }
}
