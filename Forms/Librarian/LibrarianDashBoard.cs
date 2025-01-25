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
        public LibrarianDashBoard(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private string username;
        
        
        private void LibrarianDashBoard_Load(object sender, EventArgs e)
        {
            username_label_Ldashboard.Text = $"{username},";
        }
    }
}
