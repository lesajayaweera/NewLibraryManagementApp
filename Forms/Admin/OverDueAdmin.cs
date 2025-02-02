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

namespace NewLibraryManagementApp.Forms.Admin
{
    public partial class OverDueAdmin : Form
    {
        
        private Form form;
        private int overdueId;
        private Person person;
        private AdminController controller = new AdminController();
        
        public OverDueAdmin(Form form,Person person)
        {
            InitializeComponent();
            this.form = form;
            this.person = person;
        }

        private void OverDueAdmin_Load(object sender, EventArgs e)
        {
            controller.LoadOverDueBooks(dataGridViewOverdue_admin);
        }

        private void dataGridViewOverdue_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewOverdue_admin.Rows[e.RowIndex];

                overdueId = Convert.ToInt32(selectedRow.Cells["OverdueId"].Value);

                controller.SetPaidStatus(overdueId, paidRadio, NotpaidRadio);
            }
        }

        private void updateOverdue_Click(object sender, EventArgs e)
        {
            controller.UpdateOverdue(paidRadio, NotpaidRadio, overdueId, dataGridViewOverdue_admin);

        }

        private void button_Click(object sender, EventArgs e)
        {
            AdminDashBoard db = new AdminDashBoard(person,this);
            db.Show();
            this.Hide();


        }
    }
}
