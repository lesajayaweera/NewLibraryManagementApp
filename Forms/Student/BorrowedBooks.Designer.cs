namespace NewLibraryManagementApp
{
    partial class BorrowedBooks
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
            dataGridView_borrowedBooks = new DataGridView();
            label1 = new Label();
            Backbutton_borrowBooks = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_borrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_borrowedBooks
            // 
            dataGridView_borrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_borrowedBooks.Location = new Point(5, 55);
            dataGridView_borrowedBooks.Margin = new Padding(3, 4, 3, 4);
            dataGridView_borrowedBooks.Name = "dataGridView_borrowedBooks";
            dataGridView_borrowedBooks.RowHeadersWidth = 51;
            dataGridView_borrowedBooks.RowTemplate.Height = 24;
            dataGridView_borrowedBooks.Size = new Size(1128, 591);
            dataGridView_borrowedBooks.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(440, 13);
            label1.Name = "label1";
            label1.Size = new Size(193, 29);
            label1.TabIndex = 34;
            label1.Text = "Borrowed Books";
            // 
            // Backbutton_borrowBooks
            // 
            Backbutton_borrowBooks.Location = new Point(12, 13);
            Backbutton_borrowBooks.Margin = new Padding(3, 4, 3, 4);
            Backbutton_borrowBooks.Name = "Backbutton_borrowBooks";
            Backbutton_borrowBooks.Size = new Size(104, 29);
            Backbutton_borrowBooks.TabIndex = 37;
            Backbutton_borrowBooks.Text = "Back";
            Backbutton_borrowBooks.UseVisualStyleBackColor = true;
            Backbutton_borrowBooks.Click += Backbutton_borrowBooks_Click;
            // 
            // BorrowedBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 655);
            Controls.Add(Backbutton_borrowBooks);
            Controls.Add(dataGridView_borrowedBooks);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BorrowedBooks";
            Text = "BorrowedBooks";
            Load += BorrowedBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_borrowedBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_borrowedBooks;
        private System.Windows.Forms.Label label1;
        private Button Backbutton_borrowBooks;
    }
}