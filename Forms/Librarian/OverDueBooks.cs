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
    public partial class OverDueBooks : Form
    {
        private Book book = new Book();
        int overdueId;
        public OverDueBooks()
        {
            InitializeComponent();
        }

        private void OverDueBooks_Load(object sender, EventArgs e)
        {
            book.LoadOverdueBooks(dataGridViewOverDueBooks);
        }

        private void dataGridViewOverDueBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewOverDueBooks.Rows[e.RowIndex];

                overdueId = Convert.ToInt32(selectedRow.Cells["OverdueId"].Value);

                book.SetPaidStatus(overdueId, paidRadio_l, NotpaidRadio_l);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            bool ispaid = false;

            if (paidRadio_l.Checked)
            {
                ispaid = true;
            }
            else if (paidRadio_l.Checked)
            {
                ispaid = false;
            }

            bool isUpdated = book.UpdateOverdueStatus(overdueId, ispaid);
            if (isUpdated)
            {
                book.LoadOverdueBooks(dataGridViewOverDueBooks);
            }
        }
    }
}
