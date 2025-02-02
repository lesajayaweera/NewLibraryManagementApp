using library_mananagement_system.Forms.Librarian;
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

namespace NewLibraryManagementApp.Forms.Student
{
    public partial class OverDueStudent : Form
    {
        private StudentController controller = new StudentController();

        public OverDueStudent(Person person)
        {
            InitializeComponent();
            this.person = person;

        }
        private Person person;
        


        private void OverDueStudent_Load(object sender, EventArgs e)
        {
            controller.LoadOverdueBooks(person, dataGridViewOverdue_student);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDashboard db = new StudentDashboard(person,this);
            db.Show();
            this.Hide();
        }
    }
}
