﻿using NewLibraryManagementApp;
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

namespace library_mananagement_system.Forms.Librarian
{
    public partial class StudentDashboard : Form
    {
        private Person person;
        private Form form;
        public StudentDashboard(Person person, Form form)
        {
            InitializeComponent();
            this.person = person;
            this.form = form;
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            label3.Text = $"{person.Name},";

        }

        private void BorrowBooks_btn_STdashboard_Click(object sender, EventArgs e)
        {
            BorrowedBooks borrowedBooks = new BorrowedBooks(this,person);
            borrowedBooks.Show();
            this.Hide();
        }

        private void Reservations_btn_STdashboard_Click(object sender, EventArgs e)
        {
            ReservationBooks reservationBooks = new ReservationBooks(this,person);
            reservationBooks.Show();
            this.Hide();
        }

        private void ReturnBooks_btn_STdashboard_Click(object sender, EventArgs e)
        {
            ReturnBooks returnBooks = new ReturnBooks(this,person);
            returnBooks.Show();
            this.Hide();

        }

        private void ViewBooks_btn_STdashboard_Click(object sender, EventArgs e)
        {
            ViewBooks viewBooks = new ViewBooks(this,person);
            viewBooks.Show();
            this.Hide();

        }
    }
}
