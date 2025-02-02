namespace NewLibraryManagementApp.Forms.Librarian
{
    partial class LibrarianDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianDashBoard));
            label1 = new Label();
            username_label_Ldashboard = new Label();
            label2 = new Label();
            panel1 = new Panel();
            reservation_btn = new Button();
            OverdueBook_btn_Ldashboard = new Button();
            addBook_btn_LDashboard = new Button();
            DelBook_btn_LDashboard = new Button();
            EditBook_btn_LDashboard = new Button();
            label5 = new Label();
            signoutButton = new PictureBox();
            Main_dataGridView = new DataGridView();
            panel2 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel4 = new Panel();
            tBookCount = new Label();
            label10 = new Label();
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Main_dataGridView).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 70);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 12;
            label1.Text = "Library Management System";
            // 
            // username_label_Ldashboard
            // 
            username_label_Ldashboard.AutoSize = true;
            username_label_Ldashboard.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            username_label_Ldashboard.Location = new Point(331, 29);
            username_label_Ldashboard.Name = "username_label_Ldashboard";
            username_label_Ldashboard.Size = new Size(81, 41);
            username_label_Ldashboard.TabIndex = 9;
            username_label_Ldashboard.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(283, 29);
            label2.Name = "label2";
            label2.Size = new Size(59, 41);
            label2.TabIndex = 8;
            label2.Text = "Hi ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(reservation_btn);
            panel1.Controls.Add(OverdueBook_btn_Ldashboard);
            panel1.Controls.Add(addBook_btn_LDashboard);
            panel1.Controls.Add(DelBook_btn_LDashboard);
            panel1.Controls.Add(EditBook_btn_LDashboard);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(signoutButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 577);
            panel1.TabIndex = 7;
            // 
            // reservation_btn
            // 
            reservation_btn.BackColor = Color.DarkSlateBlue;
            reservation_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            reservation_btn.ForeColor = SystemColors.ButtonHighlight;
            reservation_btn.Location = new Point(12, 398);
            reservation_btn.Name = "reservation_btn";
            reservation_btn.Size = new Size(257, 55);
            reservation_btn.TabIndex = 26;
            reservation_btn.Text = "Manage Reservations";
            reservation_btn.UseVisualStyleBackColor = false;
            reservation_btn.Click += reservation_btn_Click;
            // 
            // OverdueBook_btn_Ldashboard
            // 
            OverdueBook_btn_Ldashboard.BackColor = Color.DarkSlateBlue;
            OverdueBook_btn_Ldashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            OverdueBook_btn_Ldashboard.ForeColor = SystemColors.ButtonHighlight;
            OverdueBook_btn_Ldashboard.Location = new Point(12, 337);
            OverdueBook_btn_Ldashboard.Name = "OverdueBook_btn_Ldashboard";
            OverdueBook_btn_Ldashboard.Size = new Size(257, 55);
            OverdueBook_btn_Ldashboard.TabIndex = 25;
            OverdueBook_btn_Ldashboard.Text = "Over due Books";
            OverdueBook_btn_Ldashboard.UseVisualStyleBackColor = false;
            OverdueBook_btn_Ldashboard.Click += OverdueBook_btn_Ldashboard_Click;
            // 
            // addBook_btn_LDashboard
            // 
            addBook_btn_LDashboard.BackColor = Color.DarkSlateBlue;
            addBook_btn_LDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            addBook_btn_LDashboard.ForeColor = SystemColors.ButtonHighlight;
            addBook_btn_LDashboard.Location = new Point(10, 154);
            addBook_btn_LDashboard.Name = "addBook_btn_LDashboard";
            addBook_btn_LDashboard.Size = new Size(257, 55);
            addBook_btn_LDashboard.TabIndex = 24;
            addBook_btn_LDashboard.Text = "Add Book";
            addBook_btn_LDashboard.UseVisualStyleBackColor = false;
            addBook_btn_LDashboard.Click += addBook_btn_LDashboard_Click;
            // 
            // DelBook_btn_LDashboard
            // 
            DelBook_btn_LDashboard.BackColor = Color.DarkSlateBlue;
            DelBook_btn_LDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DelBook_btn_LDashboard.ForeColor = SystemColors.ButtonHighlight;
            DelBook_btn_LDashboard.Location = new Point(10, 215);
            DelBook_btn_LDashboard.Name = "DelBook_btn_LDashboard";
            DelBook_btn_LDashboard.Size = new Size(257, 55);
            DelBook_btn_LDashboard.TabIndex = 23;
            DelBook_btn_LDashboard.Text = "Delete Book";
            DelBook_btn_LDashboard.UseVisualStyleBackColor = false;
            DelBook_btn_LDashboard.Click += DelBook_btn_LDashboard_Click;
            // 
            // EditBook_btn_LDashboard
            // 
            EditBook_btn_LDashboard.BackColor = Color.DarkSlateBlue;
            EditBook_btn_LDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            EditBook_btn_LDashboard.ForeColor = SystemColors.ButtonHighlight;
            EditBook_btn_LDashboard.Location = new Point(10, 276);
            EditBook_btn_LDashboard.Name = "EditBook_btn_LDashboard";
            EditBook_btn_LDashboard.Size = new Size(257, 55);
            EditBook_btn_LDashboard.TabIndex = 22;
            EditBook_btn_LDashboard.Text = "Edit Books";
            EditBook_btn_LDashboard.UseVisualStyleBackColor = false;
            EditBook_btn_LDashboard.Click += EditBook_btn_LDashboard_Click;
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
            // Main_dataGridView
            // 
            Main_dataGridView.BackgroundColor = SystemColors.ButtonFace;
            Main_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Main_dataGridView.Location = new Point(283, 112);
            Main_dataGridView.Name = "Main_dataGridView";
            Main_dataGridView.RowHeadersWidth = 51;
            Main_dataGridView.Size = new Size(831, 465);
            Main_dataGridView.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(676, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 94);
            panel2.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(97, 17);
            label7.Name = "label7";
            label7.Size = new Size(34, 38);
            label7.TabIndex = 2;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(34, 55);
            label8.Name = "label8";
            label8.Size = new Size(155, 28);
            label8.TabIndex = 0;
            label8.Text = "Overdue Books";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Lavender;
            panel4.Controls.Add(tBookCount);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(454, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(216, 94);
            panel4.TabIndex = 13;
            // 
            // tBookCount
            // 
            tBookCount.AutoSize = true;
            tBookCount.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tBookCount.Location = new Point(93, 17);
            tBookCount.Name = "tBookCount";
            tBookCount.Size = new Size(34, 38);
            tBookCount.TabIndex = 1;
            tBookCount.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(49, 55);
            label10.Name = "label10";
            label10.Size = new Size(122, 28);
            label10.TabIndex = 0;
            label10.Text = "Total Books";
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // LibrarianDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 577);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(Main_dataGridView);
            Controls.Add(username_label_Ldashboard);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "LibrarianDashBoard";
            Text = "Librarian-DashBoard";
            Load += LibrarianDashBoard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)Main_dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label username_label_Ldashboard;
        private Label label2;
        private Panel panel1;
        private Label label5;
        private PictureBox signoutButton;
        private Panel panel2;
        private Label label7;
        private Label label8;
        private Panel panel4;
        private Label tBookCount;
        private Label label10;
        private Button addBook_btn_LDashboard;
        private Button DelBook_btn_LDashboard;
        private Button EditBook_btn_LDashboard;
        private Button OverdueBook_btn_Ldashboard;
        public DataGridView Main_dataGridView;
        private Button reservation_btn;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
    }
}