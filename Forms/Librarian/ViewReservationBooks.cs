using NewLibraryManagementApp.Classes;
using NewLibraryManagementApp.Forms.Librarian;
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
    public partial class ViewReservationBooks : Form
    {
        private Book book = new Book();
        private Form form;
        private Person Person;
        private int ReservationId;
        public ViewReservationBooks(Person person, Form form)
        {
            this.Person = person;
            this.form = form;
            InitializeComponent();
        }

        private void ViewReservationBooks_Load(object sender, EventArgs e)
        {
            book.LoadReservationBooks(dataGridView_Reservations);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibrarianDashBoard das = new LibrarianDashBoard(Person);
            das.Show();
            this.Hide();
        }

        private void dataGridView_Reservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_Reservations.Rows[e.RowIndex];

                ReservationId = Convert.ToInt32(selectedRow.Cells["ReservationId"].Value);

                book.SetCollectStatus(ReservationId, radioButton1, radioButton2, comboBox1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool iscollected = false;
            string currentStatus = comboBox1.SelectedItem.ToString();

            if (radioButton1.Checked)
            {
                iscollected = true;
            }
            else if(radioButton2.Checked)
            {
                iscollected = false;
            }
            bool done =book.UpdateReservationStatus(ReservationId, iscollected, currentStatus);

            if (done)
            {
                book.LoadReservationBooks(dataGridView_Reservations);
            }

        }
    }
}
