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

namespace NewLibraryManagementApp
{
    public partial class OverDueBooks : Form
    {
        private LibrarianController controller = new LibrarianController();
        private Book book = new Book();
        int overdueId;
        public OverDueBooks()
        {
            InitializeComponent();
        }

        private void OverDueBooks_Load(object sender, EventArgs e)
        {
            controller.LoadOverDueBooks(dataGridViewOverDueBooks);
        }

        private void dataGridViewOverDueBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewOverDueBooks.Rows[e.RowIndex];

                overdueId = Convert.ToInt32(selectedRow.Cells["OverdueId"].Value);

                controller.SetPaidStatus(overdueId, paidRadio_l, NotpaidRadio_l);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
           

            controller.UpdateOverdue(paidRadio_l, NotpaidRadio_l, overdueId, dataGridViewOverDueBooks);
        }
    }
}
