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
    public partial class Library_Records : Form
    {
        private Person person;
        private Form form;
        

        private AdminController controller = new AdminController();
        public Library_Records(Person person, Form form)
        {
            InitializeComponent();
            this.person = person;
            this.form = form;   
        }

        private void libraryRecords_home_Click(object sender, EventArgs e)
        {
            AdminDashBoard dashboard = new AdminDashBoard(person,this);
            dashboard.Show();
            this.Hide();
        }

        private void LlibraryRecords_BookManagement_Click(object sender, EventArgs e)
        {
            BookManagement b1 = new BookManagement(person, this);
            b1.Show();
            this.Hide();
        }

        private void Library_Records_Load(object sender, EventArgs e)
        {
            label4.Text = controller.GetMostActiveUser();
            label6.Text =controller.GetMostBorrowedBook();

            
            controller.DisplayTables(dataGridView_borrowings, dataGridViewReservations);
        }
    }
}
