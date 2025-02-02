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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewLibraryManagementApp
{
    public partial class ReservationBooks : Form
    {
        private Form form;
        private Book book = new Book();
        private Person person;

        private StudentController controller = new StudentController();
        public ReservationBooks(Form form, Person person)
        {
            InitializeComponent();
            this.form = form;
            this.person = person;
        }

        private void ReservationBooks_Load(object sender, EventArgs e)
        {
            controller.LoadReservedBooks(person, dataGridView_reserveBooks);
        }

        private void backbutton_reservation_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }

        private void dataGridView_reserveBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_reserveBooks.Rows[e.RowIndex];
                textBox5.Text = selectedRow.Cells["Title"].Value.ToString();
                textBox3.Text = selectedRow.Cells["Author"].Value.ToString();
            }
        }
    }
}
