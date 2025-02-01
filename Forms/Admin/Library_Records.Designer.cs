namespace NewLibraryManagementApp.Forms.Admin
{
    partial class Library_Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library_Records));
            panel1 = new Panel();
            libraryRecords_UserMAnagement = new Button();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            LlibraryRecords_home = new Button();
            LlibraryRecords_BookManagement = new Button();
            dataGridView_borrowings = new DataGridView();
            dataGridViewReservations = new DataGridView();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_borrowings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(libraryRecords_UserMAnagement);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LlibraryRecords_home);
            panel1.Controls.Add(LlibraryRecords_BookManagement);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 679);
            panel1.TabIndex = 1;
            // 
            // libraryRecords_UserMAnagement
            // 
            libraryRecords_UserMAnagement.BackColor = Color.DarkSlateBlue;
            libraryRecords_UserMAnagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            libraryRecords_UserMAnagement.ForeColor = SystemColors.ButtonHighlight;
            libraryRecords_UserMAnagement.Location = new Point(12, 232);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(68, 635);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 11;
            label5.Text = "Sign out";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Indigo;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 617);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
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
            LlibraryRecords_home.Click += LlibraryRecords_BookManagement_Click;
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
            LlibraryRecords_BookManagement.Click += libraryRecords_home_Click;
            // 
            // dataGridView_borrowings
            // 
            dataGridView_borrowings.BackgroundColor = Color.AliceBlue;
            dataGridView_borrowings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_borrowings.Location = new Point(285, 162);
            dataGridView_borrowings.Name = "dataGridView_borrowings";
            dataGridView_borrowings.RowHeadersWidth = 51;
            dataGridView_borrowings.Size = new Size(513, 517);
            dataGridView_borrowings.TabIndex = 2;
            // 
            // dataGridViewReservations
            // 
            dataGridViewReservations.BackgroundColor = Color.AliceBlue;
            dataGridViewReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservations.Location = new Point(804, 162);
            dataGridViewReservations.Name = "dataGridViewReservations";
            dataGridViewReservations.RowHeadersWidth = 51;
            dataGridViewReservations.Size = new Size(497, 517);
            dataGridViewReservations.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(380, 36);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 5;
            label4.Text = "Most Active User:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(888, 36);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 6;
            label6.Text = "Most Borrowed book:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(478, 130);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 8;
            label8.Text = "Borrowings";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(974, 130);
            label9.Name = "label9";
            label9.Size = new Size(92, 20);
            label9.TabIndex = 9;
            label9.Text = "Reservations";
            // 
            // Library_Records
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1313, 679);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(dataGridViewReservations);
            Controls.Add(dataGridView_borrowings);
            Controls.Add(panel1);
            Name = "Library_Records";
            Text = "Admin - Library Records";
            Load += Library_Records_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_borrowings).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button libraryRecords_UserMAnagement;
        private Label label1;
        private Label label5;
        private Button LlibraryRecords_home;
        private Button LlibraryRecords_BookManagement;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dataGridView_borrowings;
        private DataGridView dataGridViewReservations;
        private Label label4;
        private Label label6;
        private Label label8;
        private Label label9;
    }
}