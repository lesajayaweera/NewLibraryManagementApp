using NewLibraryManagementApp.Classes;
using NewLibraryManagementApp.Classes.ControllerClasses;
using NewLibraryManagementApp.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLibraryManagementApp.Forms.Librarian
{
    public partial class LibrarianDashBoard : Form
    {
        private Person person;
        private Book book = new Book();
        private LibrarianController controller = new LibrarianController();
        public LibrarianDashBoard(Person person)
        {
            InitializeComponent();
            this.person = person;

        }




        private void LibrarianDashBoard_Load(object sender, EventArgs e)
        {
            tBookCount.Text = controller.GetBookCount();
            controller.DisplayBooks(Main_dataGridView);
            username_label_Ldashboard.Text = $"{person.Name},";

        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void LibraryRecords_btn_HomeManagement_Click(object sender, EventArgs e)
        {

        }

        private void addBook_btn_LDashboard_Click(object sender, EventArgs e)
        {
            AddBooks form = new AddBooks(this, person);
            form.Show();
            this.Hide();
        }

        private void DelBook_btn_LDashboard_Click(object sender, EventArgs e)
        {
            DeleteBooks form = new DeleteBooks(this);
            form.Show();
            this.Hide();
        }

        private void EditBook_btn_LDashboard_Click(object sender, EventArgs e)
        {
            EditBooks form = new EditBooks(this);
            form.Show();
            this.Hide();

        }

        private void OverdueBook_btn_Ldashboard_Click(object sender, EventArgs e)
        {
            OverDueBooks form = new OverDueBooks();
            form.Show();
            this.Hide();
        }

        private void reservation_btn_Click(object sender, EventArgs e)
        {
            ViewReservationBooks rb = new ViewReservationBooks(person, this);
            rb.Show();
            this.Hide();
        }
    }
}
