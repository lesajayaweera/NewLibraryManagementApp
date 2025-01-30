namespace library_mananagement_system.Forms.Librarian
{
    partial class StudentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            ViewBooks_btn_STdashboard = new Button();
            ReturnBooks_btn_STdashboard = new Button();
            Reservations_btn_STdashboard = new Button();
            BorrowBooks_btn_STdashboard = new Button();
            label5 = new Label();
            signoutButton = new PictureBox();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            label6 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel4 = new Panel();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(363, 28);
            label3.Name = "label3";
            label3.Size = new Size(81, 41);
            label3.TabIndex = 9;
            label3.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(315, 28);
            label2.Name = "label2";
            label2.Size = new Size(59, 41);
            label2.TabIndex = 8;
            label2.Text = "Hi ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(ViewBooks_btn_STdashboard);
            panel1.Controls.Add(ReturnBooks_btn_STdashboard);
            panel1.Controls.Add(Reservations_btn_STdashboard);
            panel1.Controls.Add(BorrowBooks_btn_STdashboard);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(signoutButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 577);
            panel1.TabIndex = 7;
            // 
            // ViewBooks_btn_STdashboard
            // 
            ViewBooks_btn_STdashboard.BackColor = Color.DarkSlateBlue;
            ViewBooks_btn_STdashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ViewBooks_btn_STdashboard.ForeColor = SystemColors.ButtonHighlight;
            ViewBooks_btn_STdashboard.Location = new Point(12, 310);
            ViewBooks_btn_STdashboard.Name = "ViewBooks_btn_STdashboard";
            ViewBooks_btn_STdashboard.Size = new Size(257, 55);
            ViewBooks_btn_STdashboard.TabIndex = 22;
            ViewBooks_btn_STdashboard.Text = "View Books";
            ViewBooks_btn_STdashboard.UseVisualStyleBackColor = false;
            ViewBooks_btn_STdashboard.Click += ViewBooks_btn_STdashboard_Click;
            // 
            // ReturnBooks_btn_STdashboard
            // 
            ReturnBooks_btn_STdashboard.BackColor = Color.DarkSlateBlue;
            ReturnBooks_btn_STdashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ReturnBooks_btn_STdashboard.ForeColor = SystemColors.ButtonHighlight;
            ReturnBooks_btn_STdashboard.Location = new Point(12, 249);
            ReturnBooks_btn_STdashboard.Name = "ReturnBooks_btn_STdashboard";
            ReturnBooks_btn_STdashboard.Size = new Size(257, 55);
            ReturnBooks_btn_STdashboard.TabIndex = 21;
            ReturnBooks_btn_STdashboard.Text = "Return Books";
            ReturnBooks_btn_STdashboard.UseVisualStyleBackColor = false;
            ReturnBooks_btn_STdashboard.Click += ReturnBooks_btn_STdashboard_Click;
            // 
            // Reservations_btn_STdashboard
            // 
            Reservations_btn_STdashboard.BackColor = Color.DarkSlateBlue;
            Reservations_btn_STdashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Reservations_btn_STdashboard.ForeColor = SystemColors.ButtonHighlight;
            Reservations_btn_STdashboard.Location = new Point(12, 188);
            Reservations_btn_STdashboard.Name = "Reservations_btn_STdashboard";
            Reservations_btn_STdashboard.Size = new Size(257, 55);
            Reservations_btn_STdashboard.TabIndex = 20;
            Reservations_btn_STdashboard.Text = "Reserved Books";
            Reservations_btn_STdashboard.UseVisualStyleBackColor = false;
            Reservations_btn_STdashboard.Click += Reservations_btn_STdashboard_Click;
            // 
            // BorrowBooks_btn_STdashboard
            // 
            BorrowBooks_btn_STdashboard.BackColor = Color.DarkSlateBlue;
            BorrowBooks_btn_STdashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BorrowBooks_btn_STdashboard.ForeColor = SystemColors.ButtonHighlight;
            BorrowBooks_btn_STdashboard.Location = new Point(12, 127);
            BorrowBooks_btn_STdashboard.Name = "BorrowBooks_btn_STdashboard";
            BorrowBooks_btn_STdashboard.Size = new Size(257, 55);
            BorrowBooks_btn_STdashboard.TabIndex = 19;
            BorrowBooks_btn_STdashboard.Text = "Borrowed Books";
            BorrowBooks_btn_STdashboard.UseVisualStyleBackColor = false;
            BorrowBooks_btn_STdashboard.Click += BorrowBooks_btn_STdashboard_Click;
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(303, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(802, 323);
            dataGridView1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lavender;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(889, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(216, 94);
            panel3.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(95, 17);
            label6.Name = "label6";
            label6.Size = new Size(34, 38);
            label6.TabIndex = 3;
            label6.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 55);
            label4.Name = "label4";
            label4.Size = new Size(192, 28);
            label4.TabIndex = 0;
            label4.Text = "Total Return Books";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(594, 99);
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
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(303, 99);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 94);
            panel4.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(93, 17);
            label9.Name = "label9";
            label9.Size = new Size(34, 38);
            label9.TabIndex = 1;
            label9.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 55);
            label10.Name = "label10";
            label10.Size = new Size(220, 28);
            label10.TabIndex = 0;
            label10.Text = "Total Borrowed Books";
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 577);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "StudentDashboard";
            Text = "Librarian-DashBoard";
            Load += StudentDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signoutButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label5;
        private PictureBox signoutButton;
        private Button Reservations_btn_STdashboard;
        private Button BorrowBooks_btn_STdashboard;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label label6;
        private Label label4;
        private Panel panel2;
        private Label label7;
        private Label label8;
        private Panel panel4;
        private Label label9;
        private Label label10;
        private Button ReturnBooks_btn_STdashboard;
        private Button ViewBooks_btn_STdashboard;
    }
}