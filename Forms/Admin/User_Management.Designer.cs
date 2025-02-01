namespace NewLibraryManagementApp.Forms.Admin
{
    partial class User_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Management));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            libraryRecords_StudentRecords = new Button();
            LlibraryRecords_home = new Button();
            LlibraryRecords_BookManagement = new Button();
            dataGridView_librarian = new DataGridView();
            UserManagement_EditDataBtn = new Button();
            UserManagement_DeleteUserBtn = new Button();
            label3 = new Label();
            UserManagement_UsernameText = new TextBox();
            UserManagement_PasswordText = new TextBox();
            label4 = new Label();
            dataGridView_student = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_librarian).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(libraryRecords_StudentRecords);
            panel1.Controls.Add(LlibraryRecords_home);
            panel1.Controls.Add(LlibraryRecords_BookManagement);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 722);
            panel1.TabIndex = 3;
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
            label5.Location = new Point(68, 678);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 11;
            label5.Text = "Sign out";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Indigo;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 660);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            libraryRecords_StudentRecords.Text = "Library Records";
            libraryRecords_StudentRecords.UseVisualStyleBackColor = false;
            libraryRecords_StudentRecords.Click += libraryRecords_StudentRecords_Click;
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
            LlibraryRecords_home.Click += LlibraryRecords_home_Click;
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
            LlibraryRecords_BookManagement.Click += LlibraryRecords_BookManagement_Click;
            // 
            // dataGridView_librarian
            // 
            dataGridView_librarian.BackgroundColor = Color.LightSteelBlue;
            dataGridView_librarian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_librarian.Location = new Point(283, 74);
            dataGridView_librarian.Name = "dataGridView_librarian";
            dataGridView_librarian.RowHeadersWidth = 51;
            dataGridView_librarian.Size = new Size(559, 636);
            dataGridView_librarian.TabIndex = 4;
            dataGridView_librarian.CellContentClick += dataGridView_librarian_CellContentClick;
            // 
            // UserManagement_EditDataBtn
            // 
            UserManagement_EditDataBtn.BackColor = Color.Thistle;
            UserManagement_EditDataBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UserManagement_EditDataBtn.Location = new Point(1423, 469);
            UserManagement_EditDataBtn.Name = "UserManagement_EditDataBtn";
            UserManagement_EditDataBtn.Size = new Size(262, 48);
            UserManagement_EditDataBtn.TabIndex = 1;
            UserManagement_EditDataBtn.Text = "Edit Credentials";
            UserManagement_EditDataBtn.UseVisualStyleBackColor = false;
            UserManagement_EditDataBtn.Click += UserManagement_EditDataBtn_Click;
            // 
            // UserManagement_DeleteUserBtn
            // 
            UserManagement_DeleteUserBtn.BackColor = Color.Crimson;
            UserManagement_DeleteUserBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UserManagement_DeleteUserBtn.ForeColor = SystemColors.ButtonHighlight;
            UserManagement_DeleteUserBtn.Location = new Point(1423, 523);
            UserManagement_DeleteUserBtn.Name = "UserManagement_DeleteUserBtn";
            UserManagement_DeleteUserBtn.Size = new Size(265, 48);
            UserManagement_DeleteUserBtn.TabIndex = 2;
            UserManagement_DeleteUserBtn.Text = "Delete User";
            UserManagement_DeleteUserBtn.UseVisualStyleBackColor = false;
            UserManagement_DeleteUserBtn.Click += UserManagement_DeleteUserBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1411, 74);
            label3.Name = "label3";
            label3.Size = new Size(130, 31);
            label3.TabIndex = 5;
            label3.Text = "Username: ";
            // 
            // UserManagement_UsernameText
            // 
            UserManagement_UsernameText.Location = new Point(1411, 108);
            UserManagement_UsernameText.Multiline = true;
            UserManagement_UsernameText.Name = "UserManagement_UsernameText";
            UserManagement_UsernameText.Size = new Size(261, 34);
            UserManagement_UsernameText.TabIndex = 6;
            // 
            // UserManagement_PasswordText
            // 
            UserManagement_PasswordText.Location = new Point(1411, 193);
            UserManagement_PasswordText.Multiline = true;
            UserManagement_PasswordText.Name = "UserManagement_PasswordText";
            UserManagement_PasswordText.Size = new Size(261, 34);
            UserManagement_PasswordText.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1411, 159);
            label4.Name = "label4";
            label4.Size = new Size(124, 31);
            label4.TabIndex = 7;
            label4.Text = "Password: ";
            // 
            // dataGridView_student
            // 
            dataGridView_student.BackgroundColor = Color.LightSteelBlue;
            dataGridView_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_student.Location = new Point(848, 74);
            dataGridView_student.Name = "dataGridView_student";
            dataGridView_student.RowHeadersWidth = 51;
            dataGridView_student.Size = new Size(548, 636);
            dataGridView_student.TabIndex = 9;
            dataGridView_student.CellContentClick += dataGridView_student_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(414, 40);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 10;
            label6.Text = "Labrarians";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1085, 40);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 11;
            label7.Text = "Student";
            // 
            // User_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1688, 722);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dataGridView_student);
            Controls.Add(UserManagement_PasswordText);
            Controls.Add(label4);
            Controls.Add(UserManagement_UsernameText);
            Controls.Add(label3);
            Controls.Add(UserManagement_DeleteUserBtn);
            Controls.Add(UserManagement_EditDataBtn);
            Controls.Add(dataGridView_librarian);
            Controls.Add(panel1);
            Name = "User_Management";
            Text = "Admin - User Management";
            Load += User_Management_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_librarian).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label5;
        private PictureBox pictureBox1;
        private Button libraryRecords_StudentRecords;
        private Button LlibraryRecords_home;
        private Button LlibraryRecords_BookManagement;
        private DataGridView dataGridView_librarian;
        private Button UserManagement_EditDataBtn;
        private Button UserManagement_DeleteUserBtn;
        private Label label3;
        private TextBox UserManagement_UsernameText;
        private TextBox UserManagement_PasswordText;
        private Label label4;
        private DataGridView dataGridView_student;
        private Label label6;
        private Label label7;
    }
}