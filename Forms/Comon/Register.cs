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
    public partial class Register : Form
    {
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
                    Admin admin = new Admin(username,email,role,password,phoneNumber);
                    admin.Register(admin, this);
                }
                else if (role == "Librarian")
                {

                    Librarian librarian = new Librarian(username, email, role, password, phoneNumber);
                    librarian.Register(librarian, this);
                }
               
                else
                {
                    MessageBox.Show("Invalid Role");
                }
            }
            }
        }
    }

