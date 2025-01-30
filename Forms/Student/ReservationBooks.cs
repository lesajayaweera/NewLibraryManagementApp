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
    public partial class ReservationBooks : Form
    {
        private Form form;
        private Book book = new Book();
        public ReservationBooks(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void ReservationBooks_Load(object sender, EventArgs e)
        {
            book.DisplayBooks(dataGridView_reserveBooks);
        }

        private void backbutton_reservation_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }
    }
}
