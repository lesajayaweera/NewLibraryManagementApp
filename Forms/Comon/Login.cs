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
    public partial class Login : Form
    {
        public Login()
        {

            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rejister_btn_login_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void Username_text_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_btn_login_Click(object sender, EventArgs e)
        {
            string username = Username_text_login.Text;
            string password = Password_text_login.Text;
            string role = Admin_radio_login.Checked ? "Admin" : Librarian_radio_login.Checked ? "Librarian" : Student_radio_login.Checked ? "Student" : "User";


        }

        private void ShowPass_check_CheckedChanged(object sender, EventArgs e)
        {
            Password_text_login.PasswordChar = ShowPass_check.Checked ? '\0' : '*';
        }
    }
}
