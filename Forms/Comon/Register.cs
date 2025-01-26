using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewLibraryManagementApp.Classes;
using NewLibraryManagementApp.Classes.ControllerClasses;

namespace NewLibraryManagementApp
{
    public partial class Register : Form
    {
        private AdminController admin = new AdminController();
        private LibrarianController librarian = new LibrarianController();  
        private StudentController student = new StudentController();    
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_register_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = username_text.Text;
            string email = email_text.Text;
            string phoneNumber = phonenumber_text.Text;
            string password = password_text.Text;
            string role = Admin_radio_register.Checked ? "Admin" : Librarian_radio_Register.Checked ? "Librarian" : Student_radio_register.Checked ? "Student" : "User";

            if (username == "" || email == "" || phoneNumber == "" || password == "" || role == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                if(role == "Admin")
                {
                    admin.register(username, email, role, password, phoneNumber, this);
                }
                else if (role == "Librarian")
                {

                    librarian.register(username, email, role, password, phoneNumber, this);
                }
                else if(role == "Student")
                {
                    student.register(username, email, role, password, phoneNumber, this);
                }

                else
                {
                    MessageBox.Show("Invalid Role");
                }
            }
            }
        }
    }

