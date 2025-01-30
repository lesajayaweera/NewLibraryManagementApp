﻿using NewLibraryManagementApp.Classes;
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
    public partial class BorrowedBooks : Form
    {
        private Form form;
        private Person person;
        private Book book = new Book();

        public BorrowedBooks(Form form,Person person)
        {
            InitializeComponent();
            this.form = form;
            this.person = person;
        }

        private void BorrowedBooks_Load(object sender, EventArgs e)
        {
            book.LoadBorrowedBooks(person, dataGridView_borrowedBooks);
        }

        private void Backbutton_borrowBooks_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }
    }
}
