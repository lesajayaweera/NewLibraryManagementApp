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
            UserManagement_StudentRecords = new Button();
            libraryRecords_UserMAnagement = new Button();
            label2 = new Label();
            label1 = new Label();
            UserManagement_LibraryRecords = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            libraryRecords_StudentRecords = new Button();
            UserManagement_home = new Button();
            signoutButton = new PictureBox();
            UserManagement_BookManagement = new Button();
            LlibraryRecords_home = new Button();
            LlibraryRecords_BookManagement = new Button();
            dataGridView1 = new DataGridView();
            UserManagement_VeiwRecordsBtn = new Button();
            UserManagement_EditDataBtn = new Button();
            UserManagement_DeleteUserBtn = new Button();
            label3 = new Label();
            UserManagement_UsernameText = new TextBox();
            UserManagement_PasswordText = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signoutButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(UserManagement_StudentRecords);
            panel1.Controls.Add(libraryRecords_UserMAnagement);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(UserManagement_LibraryRecords);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(libraryRecords_StudentRecords);
            panel1.Controls.Add(UserManagement_home);
            panel1.Controls.Add(signoutButton);
            panel1.Controls.Add(UserManagement_BookManagement);
            panel1.Controls.Add(LlibraryRecords_home);
            panel1.Controls.Add(LlibraryRecords_BookManagement);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 577);
            panel1.TabIndex = 3;
            // 
            // UserManagement_StudentRecords
            // 
            UserManagement_StudentRecords.BackColor = Color.DarkSlateBlue;
            UserManagement_StudentRecords.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UserManagement_StudentRecords.ForeColor = SystemColors.ButtonHighlight;
            UserManagement_StudentRecords.Location = new Point(12, 293);
            UserManagement_StudentRecords.Name = "UserManagement_StudentRecords";
            UserManagement_StudentRecords.Size = new Size(257, 55);
            UserManagement_StudentRecords.TabIndex = 13;
            UserManagement_StudentRecords.Text = "Student Records";
            UserManagement_StudentRecords.UseVisualStyleBackColor = false;
            UserManagement_StudentRecords.Click += UserManagement_StudentRecords_Click;
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
            // UserManagement_LibraryRecords
            // 
            UserManagement_LibraryRecords.BackColor = Color.DarkSlateBlue;
            UserManagement_LibraryRecords.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UserManagement_LibraryRecords.ForeColor = SystemColors.ButtonHighlight;
            UserManagement_LibraryRecords.Location = new Point(12, 232);
            UserManagement_LibraryRecords.Name = "UserManagement_LibraryRecords";
            UserManagement_LibraryRecords.Size = new Size(257, 55);
            UserManagement_LibraryRecords.TabIndex = 2;
            UserManagement_LibraryRecords.Text = "Library Records";
            UserManagement_LibraryRecords.UseVisualStyleBackColor = false;
            UserManagement_LibraryRecords.Click += UserManagement_LibraryRecords_Click;
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
            libraryRecords_StudentRecords.Text = "Student Records";
            libraryRecords_StudentRecords.UseVisualStyleBackColor = false;
            // 
            // UserManagement_home
            // 
            UserManagement_home.BackColor = Color.DarkSlateBlue;
            UserManagement_home.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UserManagement_home.ForeColor = SystemColors.ButtonHighlight;
            UserManagement_home.Location = new Point(12, 110);
            UserManagement_home.Name = "UserManagement_home";
            UserManagement_home.Size = new Size(257, 55);
            UserManagement_home.TabIndex = 1;
            UserManagement_home.Text = "Home";
            UserManagement_home.UseVisualStyleBackColor = false;
            UserManagement_home.Click += UserManagement_home_Click;
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
            // UserManagement_BookManagement
            // 
            UserManagement_BookManagement.BackColor = Color.DarkSlateBlue;
            UserManagement_BookManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UserManagement_BookManagement.ForeColor = SystemColors.ButtonHighlight;
            UserManagement_BookManagement.Location = new Point(12, 171);
            UserManagement_BookManagement.Name = "UserManagement_BookManagement";
            UserManagement_BookManagement.Size = new Size(257, 55);
            UserManagement_BookManagement.TabIndex = 0;
            UserManagement_BookManagement.Text = "Book Management";
            UserManagement_BookManagement.UseVisualStyleBackColor = false;
            UserManagement_BookManagement.Click += UserManagement_BookManagement_Click;
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
            dataGridView1.BackgroundColor = Color.LightSteelBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(292, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(515, 553);
            dataGridView1.TabIndex = 4;
            // 
            // UserManagement_VeiwRecordsBtn
            // 
            UserManagement_VeiwRecordsBtn.BackColor = Color.LightBlue;
            UserManagement_VeiwRecordsBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UserManagement_VeiwRecordsBtn.Location = new Point(840, 377);
            UserManagement_VeiwRecordsBtn.Name = "UserManagement_VeiwRecordsBtn";
            UserManagement_VeiwRecordsBtn.Size = new Size(265, 48);
            UserManagement_VeiwRecordsBtn.TabIndex = 0;
            UserManagement_VeiwRecordsBtn.Text = "View Records";
            UserManagement_VeiwRecordsBtn.UseVisualStyleBackColor = false;
            // 
            // UserManagement_EditDataBtn
            // 
            UserManagement_EditDataBtn.BackColor = Color.Thistle;
            UserManagement_EditDataBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UserManagement_EditDataBtn.Location = new Point(840, 431);
            UserManagement_EditDataBtn.Name = "UserManagement_EditDataBtn";
            UserManagement_EditDataBtn.Size = new Size(262, 48);
            UserManagement_EditDataBtn.TabIndex = 1;
            UserManagement_EditDataBtn.Text = "Edit Credentials";
            UserManagement_EditDataBtn.UseVisualStyleBackColor = false;
            // 
            // UserManagement_DeleteUserBtn
            // 
            UserManagement_DeleteUserBtn.BackColor = Color.Crimson;
            UserManagement_DeleteUserBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UserManagement_DeleteUserBtn.ForeColor = SystemColors.ButtonHighlight;
            UserManagement_DeleteUserBtn.Location = new Point(840, 485);
            UserManagement_DeleteUserBtn.Name = "UserManagement_DeleteUserBtn";
            UserManagement_DeleteUserBtn.Size = new Size(265, 48);
            UserManagement_DeleteUserBtn.TabIndex = 2;
            UserManagement_DeleteUserBtn.Text = "Delete User";
            UserManagement_DeleteUserBtn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(828, 36);
            label3.Name = "label3";
            label3.Size = new Size(130, 31);
            label3.TabIndex = 5;
            label3.Text = "Username: ";
            // 
            // UserManagement_UsernameText
            // 
            UserManagement_UsernameText.Location = new Point(828, 70);
            UserManagement_UsernameText.Multiline = true;
            UserManagement_UsernameText.Name = "UserManagement_UsernameText";
            UserManagement_UsernameText.Size = new Size(261, 34);
            UserManagement_UsernameText.TabIndex = 6;
            // 
            // UserManagement_PasswordText
            // 
            UserManagement_PasswordText.Location = new Point(828, 155);
            UserManagement_PasswordText.Multiline = true;
            UserManagement_PasswordText.Name = "UserManagement_PasswordText";
            UserManagement_PasswordText.Size = new Size(261, 34);
            UserManagement_PasswordText.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(828, 121);
            label4.Name = "label4";
            label4.Size = new Size(124, 31);
            label4.TabIndex = 7;
            label4.Text = "Password: ";
            // 
            // User_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 577);
            Controls.Add(UserManagement_PasswordText);
            Controls.Add(label4);
            Controls.Add(UserManagement_UsernameText);
            Controls.Add(label3);
            Controls.Add(UserManagement_DeleteUserBtn);
            Controls.Add(UserManagement_EditDataBtn);
            Controls.Add(dataGridView1);
            Controls.Add(UserManagement_VeiwRecordsBtn);
            Controls.Add(panel1);
            Name = "User_Management";
            Text = "Admin - User Management";
            Load += User_Management_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)signoutButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button UserManagement_StudentRecords;
        private Button libraryRecords_UserMAnagement;
        private Label label2;
        private Label label1;
        private Button UserManagement_LibraryRecords;
        private Label label5;
        private PictureBox pictureBox1;
        private Button libraryRecords_StudentRecords;
        private Button UserManagement_home;
        private PictureBox signoutButton;
        private Button UserManagement_BookManagement;
        private Button LlibraryRecords_home;
        private Button LlibraryRecords_BookManagement;
        private DataGridView dataGridView1;
        private Button UserManagement_EditDataBtn;
        private Button UserManagement_VeiwRecordsBtn;
        private Button UserManagement_DeleteUserBtn;
        private Label label3;
        private TextBox UserManagement_UsernameText;
        private TextBox UserManagement_PasswordText;
        private Label label4;
    }
}