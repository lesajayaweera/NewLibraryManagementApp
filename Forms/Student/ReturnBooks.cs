using NewLibraryManagementApp.Classes;
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
    public partial class ReturnBooks : Form
    {
        private Form form;
        private Person person;
        public ReturnBooks(Form form,Person person)
        {
            InitializeComponent();
            this.form = form;
            this.person = person;
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }
    }
}
