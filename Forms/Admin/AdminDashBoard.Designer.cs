namespace NewLibraryManagementApp.Forms.Admin
{
    partial class AdminDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashBoard));
            panel1 = new Panel();
            User_btn_HomeManagement = new Button();
            label1 = new Label();
            label5 = new Label();
            signoutButton = new PictureBox();
            LibraryRecords_btn_HomeManagement = new Button();
            BookManagement_btn_HomeManagement = new Button();
            panel2 = new Panel();
            overdue_books = new Label();
            label4 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            borrowed_books = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            OverDue_btn_HomeManagement = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(OverDue_btn_HomeManagement);
            panel1.Controls.Add(User_btn_HomeManagement);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(signoutButton);
            panel1.Controls.Add(LibraryRecords_btn_HomeManagement);
            panel1.Controls.Add(BookManagement_btn_HomeManagement);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 577);
            panel1.TabIndex = 0;
            // 
            // User_btn_HomeManagement
            // 
            User_btn_HomeManagement.BackColor = Color.DarkSlateBlue;
            User_btn_HomeManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            User_btn_HomeManagement.ForeColor = SystemColors.ButtonHighlight;
            User_btn_HomeManagement.Location = new Point(12, 232);
            User_btn_HomeManagement.Name = "User_btn_HomeManagement";
            User_btn_HomeManagement.Size = new Size(257, 55);
            User_btn_HomeManagement.TabIndex = 13;
            User_btn_HomeManagement.Text = "User Management";
            User_btn_HomeManagement.UseVisualStyleBackColor = false;
            User_btn_HomeManagement.Click += User_btn_HomeManagement_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 49);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 12;
            label1.Text = "Library Management System";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(68, 533);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 11;
            label5.Text = "Sign out";
            label5.Click += label5_Click;
            // 
            // signoutButton
            // 
            signoutButton.BackColor = Color.Indigo;
            signoutButton.Image = (Image)resources.GetObject("signoutButton.Image");
            signoutButton.Location = new Point(12, 515);
            signoutButton.Name = "signoutButton";
            signoutButton.Size = new Size(50, 50);
            signoutButton.SizeMode = PictureBoxSizeMode.StretchImage;
            signoutButton.TabIndex = 10;
            signoutButton.TabStop = false;
            signoutButton.Click += signoutButton_Click;
            // 
            // LibraryRecords_btn_HomeManagement
            // 
            LibraryRecords_btn_HomeManagement.BackColor = Color.DarkSlateBlue;
            LibraryRecords_btn_HomeManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LibraryRecords_btn_HomeManagement.ForeColor = SystemColors.ButtonHighlight;
            LibraryRecords_btn_HomeManagement.Location = new Point(12, 171);
            LibraryRecords_btn_HomeManagement.Name = "LibraryRecords_btn_HomeManagement";
            LibraryRecords_btn_HomeManagement.Size = new Size(257, 55);
            LibraryRecords_btn_HomeManagement.TabIndex = 1;
            LibraryRecords_btn_HomeManagement.Text = "Library Records";
            LibraryRecords_btn_HomeManagement.UseVisualStyleBackColor = false;
            LibraryRecords_btn_HomeManagement.Click += LibraryRecords_btn_HomeManagement_Click;
            // 
            // BookManagement_btn_HomeManagement
            // 
            BookManagement_btn_HomeManagement.BackColor = Color.DarkSlateBlue;
            BookManagement_btn_HomeManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BookManagement_btn_HomeManagement.ForeColor = SystemColors.ButtonHighlight;
            BookManagement_btn_HomeManagement.Location = new Point(12, 110);
            BookManagement_btn_HomeManagement.Name = "BookManagement_btn_HomeManagement";
            BookManagement_btn_HomeManagement.Size = new Size(257, 55);
            BookManagement_btn_HomeManagement.TabIndex = 0;
            BookManagement_btn_HomeManagement.Text = "Book Management";
            BookManagement_btn_HomeManagement.UseVisualStyleBackColor = false;
            BookManagement_btn_HomeManagement.Click += HomeManagement_btn_HomeManagement_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(overdue_books);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(515, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 97);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // overdue_books
            // 
            overdue_books.AutoSize = true;
            overdue_books.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            overdue_books.Location = new Point(70, 16);
            overdue_books.Name = "overdue_books";
            overdue_books.Size = new Size(33, 38);
            overdue_books.TabIndex = 8;
            overdue_books.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 64);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 0;
            label4.Text = "Overdue Books";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 64);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 1;
            label6.Text = "Borrowed Books";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(297, 19);
            label2.Name = "label2";
            label2.Size = new Size(59, 41);
            label2.TabIndex = 5;
            label2.Text = "Hi ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(340, 19);
            label3.Name = "label3";
            label3.Size = new Size(81, 41);
            label3.TabIndex = 6;
            label3.Text = "User";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Lavender;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(borrowed_books);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(830, 80);
            panel5.Name = "panel5";
            panel5.Size = new Size(163, 97);
            panel5.TabIndex = 2;
            // 
            // borrowed_books
            // 
            borrowed_books.AutoSize = true;
            borrowed_books.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrowed_books.Location = new Point(59, 16);
            borrowed_books.Name = "borrowed_books";
            borrowed_books.Size = new Size(33, 38);
            borrowed_books.TabIndex = 13;
            borrowed_books.Text = "0";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.GhostWhite;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(283, 253);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(395, 312);
            dataGridView1.TabIndex = 8;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.GhostWhite;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(684, 253);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(421, 312);
            dataGridView2.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(422, 210);
            label9.Name = "label9";
            label9.Size = new Size(152, 31);
            label9.TabIndex = 10;
            label9.Text = "Student Lists";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(813, 210);
            label10.Name = "label10";
            label10.Size = new Size(168, 31);
            label10.TabIndex = 11;
            label10.Text = "Librarian Lists";
            // 
            // OverDue_btn_HomeManagement
            // 
            OverDue_btn_HomeManagement.BackColor = Color.DarkSlateBlue;
            OverDue_btn_HomeManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            OverDue_btn_HomeManagement.ForeColor = SystemColors.ButtonHighlight;
            OverDue_btn_HomeManagement.Location = new Point(12, 293);
            OverDue_btn_HomeManagement.Name = "OverDue_btn_HomeManagement";
            OverDue_btn_HomeManagement.Size = new Size(257, 55);
            OverDue_btn_HomeManagement.TabIndex = 14;
            OverDue_btn_HomeManagement.Text = "Over due Books";
            OverDue_btn_HomeManagement.UseVisualStyleBackColor = false;
            OverDue_btn_HomeManagement.Click += OverDue_btn_HomeManagement_Click;
            // 
            // AdminDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1117, 577);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(panel5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashBoard";
            Text = "Admin - Dashboard";
            Load += AdminDashBoard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button LibraryRecords_btn_HomeManagement;
        private Button BookManagement_btn_HomeManagement;
        private Label label5;
        private PictureBox signoutButton;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label6;
        private Panel panel5;
        private Label overdue_books;
        private Label borrowed_books;
        private Button User_btn_HomeManagement;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label9;
        private Label label10;
        private Button OverDue_btn_HomeManagement;
    }
}