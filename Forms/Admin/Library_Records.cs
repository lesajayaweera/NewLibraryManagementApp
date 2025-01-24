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
        public Library_Records()
        {
            InitializeComponent();
        }

        private void libraryRecords_home_Click(object sender, EventArgs e)
        {
            Library_Records l1 = new Library_Records();
            l1.Show();
            this.Hide();
        }

        private void LlibraryRecords_BookManagement_Click(object sender, EventArgs e)
        {
            BookManagement b1 = new BookManagement();
            b1.Show();
            this.Hide();
        }

        private void Library_Records_Load(object sender, EventArgs e)
        {

        }
    }
}
