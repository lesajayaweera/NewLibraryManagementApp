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

namespace NewLibraryManagementApp.Forms.Admin
{
    public partial class OverDueAdmin : Form
    {
        private Book book = new Book();
        private Form form;
        private int overdueId;
        private Person Person;
        public OverDueAdmin(Form form,Person person)
        {
            InitializeComponent();
            this.form = form;
        }

        private void OverDueAdmin_Load(object sender, EventArgs e)
        {
            book.LoadOverdueBooks(dataGridViewOverdue_admin);
        }

        private void dataGridViewOverdue_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewOverdue_admin.Rows[e.RowIndex];

                overdueId = Convert.ToInt32(selectedRow.Cells["OverdueId"].Value);

                book.SetPaidStatus(overdueId, paidRadio, NotpaidRadio);
            }
        }

        private void updateOverdue_Click(object sender, EventArgs e)
        {
            bool ispaid = false;

            if (paidRadio.Checked)
            {
                ispaid = true;
            }
            else if (paidRadio.Checked)
            {
                ispaid = false;
            }

            bool isUpdated = book.UpdateOverdueStatus(overdueId, ispaid);
            if (isUpdated)
            {
                book.LoadOverdueBooks(dataGridViewOverdue_admin);
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            AdminDashBoard db = new AdminDashBoard(Person,this);
            db.Show();
            this.Hide();


        }
    }
}
