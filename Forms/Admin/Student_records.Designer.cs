namespace NewLibraryManagementApp.Forms.Admin
{
    partial class Student_records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_records));
            StudentRecords_UserManagement = new Button();
            label2 = new Label();
            StudentRecords_LibraryRecords = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            StudentRecords_home = new Button();
            StudentRecords_BookManagement = new Button();
            panel1 = new Panel();
            libraryRecords_UserMAnagement = new Button();
            label1 = new Label();
            libraryRecords_StudentRecords = new Button();
            signoutButton = new PictureBox();
            LlibraryRecords_home = new Button();
            LlibraryRecords_BookManagement = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // StudentRecords_UserManagement
            // 
            StudentRecords_UserManagement.BackColor = Color.DarkSlateBlue;
            StudentRecords_UserManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            StudentRecords_UserManagement.ForeColor = SystemColors.ButtonHighlight;
            StudentRecords_UserManagement.Location = new Point(12, 293);
            StudentRecords_UserManagement.Name = "StudentRecords_UserManagement";
            StudentRecords_UserManagement.Size = new Size(257, 55);
            StudentRecords_UserManagement.TabIndex = 13;
            StudentRecords_UserManagement.Text = "User Management";
            StudentRecords_UserManagement.UseVisualStyleBackColor = false;
            StudentRecords_UserManagement.Click += StudentRecords_UserManagement_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 49);
            label2.Name = "label2";
            label2.Size = new Size(197, 20);
            label2.TabIndex = 12;
            label2.Text = "Library Management System";
            // 
            // StudentRecords_LibraryRecords
            // 
            StudentRecords_LibraryRecords.BackColor = Color.DarkSlateBlue;
            StudentRecords_LibraryRecords.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            StudentRecords_LibraryRecords.ForeColor = SystemColors.ButtonHighlight;
            StudentRecords_LibraryRecords.Location = new Point(12, 232);
            StudentRecords_LibraryRecords.Name = "StudentRecords_LibraryRecords";
            StudentRecords_LibraryRecords.Size = new Size(257, 55);
            StudentRecords_LibraryRecords.TabIndex = 2;
            StudentRecords_LibraryRecords.Text = "Library Records";
            StudentRecords_LibraryRecords.UseVisualStyleBackColor = false;
            StudentRecords_LibraryRecords.Click += StudentRecords_LibraryRecords_Click;
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
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Indigo;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 515);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // StudentRecords_home
            // 
            StudentRecords_home.BackColor = Color.DarkSlateBlue;
            StudentRecords_home.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            StudentRecords_home.ForeColor = SystemColors.ButtonHighlight;
            StudentRecords_home.Location = new Point(12, 110);
            StudentRecords_home.Name = "StudentRecords_home";
            StudentRecords_home.Size = new Size(257, 55);
            StudentRecords_home.TabIndex = 1;
            StudentRecords_home.Text = "Home";
            StudentRecords_home.UseVisualStyleBackColor = false;
            StudentRecords_home.Click += StudentRecords_home_Click;
            // 
            // StudentRecords_BookManagement
            // 
            StudentRecords_BookManagement.BackColor = Color.DarkSlateBlue;
            StudentRecords_BookManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            StudentRecords_BookManagement.ForeColor = SystemColors.ButtonHighlight;
            StudentRecords_BookManagement.Location = new Point(12, 171);
            StudentRecords_BookManagement.Name = "StudentRecords_BookManagement";
            StudentRecords_BookManagement.Size = new Size(257, 55);
            StudentRecords_BookManagement.TabIndex = 0;
            StudentRecords_BookManagement.Text = "Book Management";
            StudentRecords_BookManagement.UseVisualStyleBackColor = false;
            StudentRecords_BookManagement.Click += StudentRecords_BookManagement_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(StudentRecords_UserManagement);
            panel1.Controls.Add(libraryRecords_UserMAnagement);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(StudentRecords_LibraryRecords);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(libraryRecords_StudentRecords);
            panel1.Controls.Add(StudentRecords_home);
            panel1.Controls.Add(signoutButton);
            panel1.Controls.Add(StudentRecords_BookManagement);
            panel1.Controls.Add(LlibraryRecords_home);
            panel1.Controls.Add(LlibraryRecords_BookManagement);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 577);
            panel1.TabIndex = 2;
            // 
            // libraryRecords_UserMAnagement
            // 
            libraryRecords_UserMAnagement.BackColor = Color.DarkSlateBlue;
            libraryRecords_UserMAnagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            libraryRecords_UserMAnagement.ForeColor = SystemColors.ButtonHighlight;
            libraryRecords_UserMAnagement.Location = new Point(12, 293);
            libraryRecords_UserMAnagement.Name = "libraryRecords_UserMAnagement";
            libraryRecords_UserMAnagement.Size = new Size(257, 55);
            libraryRecords_UserMAnagement.TabIndex = 13;
            libraryRecords_UserMAnagement.Text = "User Management";
            libraryRecords_UserMAnagement.UseVisualStyleBackColor = false;
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
            // libraryRecords_StudentRecords
            // 
            libraryRecords_StudentRecords.BackColor = Color.DarkSlateBlue;
            libraryRecords_StudentRecords.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            libraryRecords_StudentRecords.ForeColor = SystemColors.ButtonHighlight;
            libraryRecords_StudentRecords.Location = new Point(12, 232);
            libraryRecords_StudentRecords.Name = "libraryRecords_StudentRecords";
            libraryRecords_StudentRecords.Size = new Size(257, 55);
            libraryRecords_StudentRecords.TabIndex = 2;
            libraryRecords_StudentRecords.Text = "Student Records";
            libraryRecords_StudentRecords.UseVisualStyleBackColor = false;
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
            // 
            // LlibraryRecords_home
            // 
            LlibraryRecords_home.BackColor = Color.DarkSlateBlue;
            LlibraryRecords_home.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LlibraryRecords_home.ForeColor = SystemColors.ButtonHighlight;
            LlibraryRecords_home.Location = new Point(12, 110);
            LlibraryRecords_home.Name = "LlibraryRecords_home";
            LlibraryRecords_home.Size = new Size(257, 55);
            LlibraryRecords_home.TabIndex = 1;
            LlibraryRecords_home.Text = "Home";
            LlibraryRecords_home.UseVisualStyleBackColor = false;
            // 
            // LlibraryRecords_BookManagement
            // 
            LlibraryRecords_BookManagement.BackColor = Color.DarkSlateBlue;
            LlibraryRecords_BookManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LlibraryRecords_BookManagement.ForeColor = SystemColors.ButtonHighlight;
            LlibraryRecords_BookManagement.Location = new Point(12, 171);
            LlibraryRecords_BookManagement.Name = "LlibraryRecords_BookManagement";
            LlibraryRecords_BookManagement.Size = new Size(257, 55);
            LlibraryRecords_BookManagement.TabIndex = 0;
            LlibraryRecords_BookManagement.Text = "Book Management";
            LlibraryRecords_BookManagement.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(306, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(781, 504);
            dataGridView1.TabIndex = 3;
            // 
            // Student_records
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 577);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Student_records";
            Text = "Student_records";
            Load += Student_records_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button StudentRecords_UserManagement;
        private Label label2;
        private Button StudentRecords_LibraryRecords;
        private Label label5;
        private PictureBox pictureBox1;
        private Button StudentRecords_home;
        private Button StudentRecords_BookManagement;
        private Panel panel1;
        private Button libraryRecords_UserMAnagement;
        private Label label1;
        private Button libraryRecords_StudentRecords;
        private PictureBox signoutButton;
        private Button LlibraryRecords_home;
        private Button LlibraryRecords_BookManagement;
        private DataGridView dataGridView1;
    }
}