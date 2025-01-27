﻿using NewLibraryManagementApp.Classes;
using NewLibraryManagementApp.Forms.Admin;
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
        private Person person;
        public LibrarianDashBoard(Person person)
        {
            InitializeComponent();
            this.person = person;
           
        }

        


        private void LibrarianDashBoard_Load(object sender, EventArgs e)
        {
            username_label_Ldashboard.Text = $"{person.Name},";
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void LibraryRecords_btn_HomeManagement_Click(object sender, EventArgs e)
        {

        }

        private void addBook_btn_LDashboard_Click(object sender, EventArgs e)
        {
            AddBooks form = new AddBooks();
            form.Show();
            this.Hide();
        }

        private void DelBook_btn_LDashboard_Click(object sender, EventArgs e)
        {
            DeleteBooks form = new DeleteBooks();
            form.Show();
            this.Hide();
        }

        private void EditBook_btn_LDashboard_Click(object sender, EventArgs e)
        {
            EditBooks form = new EditBooks();
            form.Show();
            this.Hide();

        }

        private void OverdueBook_btn_Ldashboard_Click(object sender, EventArgs e)
        {
            OverDueBooks form = new OverDueBooks();
            form.Show();
            this.Hide();
        }

        private void Student_btn_LDashboard_Click(object sender, EventArgs e)
        {
            Student_records form = new Student_records(person, this);
            form.Show();
            this.Hide();
        }
    }
}
