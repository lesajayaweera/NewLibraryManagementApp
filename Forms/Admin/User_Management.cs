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
    public partial class User_Management : Form
    {
        private Person person;
        private Form form;
        private AdminController controller = new AdminController();

        private string name;
        private string password;
        private int userID;
        private string role;
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



        private void User_Management_Load(object sender, EventArgs e)
        {
            controller.displayUser("librarian", dataGridView_librarian);
            controller.displayUser("student", dataGridView_student);
        }

        private void dataGridView_librarian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_librarian.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["Id"].Value);
                role = row.Cells["role"].Value.ToString();

                UserManagement_UsernameText.Text = row.Cells["name"].Value.ToString(); ;
                UserManagement_PasswordText.Text = row.Cells["password"].Value.ToString();
            }
        }

        private void dataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_student.Rows[e.RowIndex];


                userID = Convert.ToInt32(row.Cells["Id"].Value);
                role = row.Cells["role"].Value.ToString();

                UserManagement_UsernameText.Text = row.Cells["name"].Value.ToString(); ;
                UserManagement_PasswordText.Text = row.Cells["password"].Value.ToString();
            }
        }

        private void UserManagement_EditDataBtn_Click(object sender, EventArgs e)
        {

            name = UserManagement_UsernameText.Text;
            password = UserManagement_PasswordText.Text;
            controller.UpdateUserCredentials(userID, name, password, role);
            controller.displayUser("librarian", dataGridView_librarian);
            controller.displayUser("student", dataGridView_student);

        }

        private void UserManagement_DeleteUserBtn_Click(object sender, EventArgs e)
        {
            controller.DeleteUser(userID, role);
            controller.displayUser("librarian", dataGridView_librarian);
            controller.displayUser("student", dataGridView_student);
        }

        private void LlibraryRecords_home_Click(object sender, EventArgs e)
        {
            AdminDashBoard db = new AdminDashBoard(person, this);
            db.Show();
            this.Hide();
        }

        private void LlibraryRecords_BookManagement_Click(object sender, EventArgs e)
        {
            BookManagement bm = new BookManagement(person, this);
            bm.Show();
            this.Hide();
        }

        private void libraryRecords_StudentRecords_Click(object sender, EventArgs e)
        {

        }
    }
}
