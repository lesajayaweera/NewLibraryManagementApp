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
    public partial class BookManagement : Form
    {
        public BookManagement()
        {
            InitializeComponent();
        }

        private void Home_btn_HomeManagement_Click(object sender, EventArgs e)
        {
            AdminDashBoard a1 = new AdminDashBoard();
            a1.Show();
            this.Hide();
        }

        private void LibraryRecords_btn_HomeManagement_Click(object sender, EventArgs e)
        {
            Library_Records l1 = new Library_Records();
            l1.Show();
            this.Hide();
        }

        private void BookManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
