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
    public partial class ViewBooks : Form
    {
        private Form form;
        private Book book = new Book();
        private int selectedBookId;
        private Person person;
        public ViewBooks(Form form,Person person)
        {
            InitializeComponent();
            this.form = form;
            this.person = person;
        }



        private void ViewBooks_Load(object sender, EventArgs e)
        {
            book.DisplayBooks(dataGridView_viewBook);
        }

        private void dataGridView_viewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_viewBook.Rows[e.RowIndex];

                selectedBookId = Convert.ToInt32(row.Cells["ID"].Value);
            }
        }

        private void viewBookDetail_btn_Click(object sender, EventArgs e)
        {
            if (selectedBookId != 0)
            {
                ViewBooksDetails form = new ViewBooksDetails(this, selectedBookId,person);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a book to view details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();

        }
    }
}
