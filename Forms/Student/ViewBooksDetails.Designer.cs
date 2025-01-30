namespace NewLibraryManagementApp
{
    partial class ViewBooksDetails
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
            label1 = new Label();
            book_picture_viewBook = new PictureBox();
            author_text_veiwBooks = new TextBox();
            year_text_veiwBooks = new TextBox();
            label5 = new Label();
            label4 = new Label();
            title_text_veiwBooks = new TextBox();
            label2 = new Label();
            isbn_text_veiwBooks = new TextBox();
            label8 = new Label();
            borrowBtn = new Button();
            reserveBtn = new Button();
            back_btn_bookDetails = new Button();
            label3 = new Label();
            status_text = new Label();
            ((System.ComponentModel.ISupportInitialize)book_picture_viewBook).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(428, 45);
            label1.Name = "label1";
            label1.Size = new Size(214, 29);
            label1.TabIndex = 29;
            label1.Text = "View Book Details ";
            // 
            // book_picture_viewBook
            // 
            book_picture_viewBook.Location = new Point(51, 119);
            book_picture_viewBook.Name = "book_picture_viewBook";
            book_picture_viewBook.Size = new Size(335, 426);
            book_picture_viewBook.TabIndex = 34;
            book_picture_viewBook.TabStop = false;
            // 
            // author_text_veiwBooks
            // 
            author_text_veiwBooks.Location = new Point(488, 253);
            author_text_veiwBooks.Margin = new Padding(3, 4, 3, 4);
            author_text_veiwBooks.Name = "author_text_veiwBooks";
            author_text_veiwBooks.Size = new Size(249, 27);
            author_text_veiwBooks.TabIndex = 48;
            // 
            // year_text_veiwBooks
            // 
            year_text_veiwBooks.Location = new Point(488, 357);
            year_text_veiwBooks.Margin = new Padding(3, 4, 3, 4);
            year_text_veiwBooks.Name = "year_text_veiwBooks";
            year_text_veiwBooks.Size = new Size(249, 27);
            year_text_veiwBooks.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(488, 213);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 46;
            label5.Text = "Author Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 318);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 45;
            label4.Text = "Year :";
            // 
            // title_text_veiwBooks
            // 
            title_text_veiwBooks.Location = new Point(488, 163);
            title_text_veiwBooks.Margin = new Padding(3, 4, 3, 4);
            title_text_veiwBooks.Name = "title_text_veiwBooks";
            title_text_veiwBooks.Size = new Size(249, 27);
            title_text_veiwBooks.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(488, 119);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 43;
            label2.Text = "Book Tittle :";
            // 
            // isbn_text_veiwBooks
            // 
            isbn_text_veiwBooks.Location = new Point(489, 482);
            isbn_text_veiwBooks.Margin = new Padding(3, 4, 3, 4);
            isbn_text_veiwBooks.Name = "isbn_text_veiwBooks";
            isbn_text_veiwBooks.Size = new Size(249, 27);
            isbn_text_veiwBooks.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(491, 443);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 50;
            label8.Text = "ISBN:";
            // 
            // borrowBtn
            // 
            borrowBtn.Location = new Point(912, 172);
            borrowBtn.Name = "borrowBtn";
            borrowBtn.Size = new Size(94, 29);
            borrowBtn.TabIndex = 52;
            borrowBtn.Text = "Borrow";
            borrowBtn.UseVisualStyleBackColor = true;
            borrowBtn.Click += borrowBtn_Click;
            // 
            // reserveBtn
            // 
            reserveBtn.Location = new Point(912, 283);
            reserveBtn.Name = "reserveBtn";
            reserveBtn.Size = new Size(94, 29);
            reserveBtn.TabIndex = 53;
            reserveBtn.Text = "Reserve";
            reserveBtn.UseVisualStyleBackColor = true;
            reserveBtn.Click += reserveBtn_Click;
            // 
            // back_btn_bookDetails
            // 
            back_btn_bookDetails.Location = new Point(23, 38);
            back_btn_bookDetails.Name = "back_btn_bookDetails";
            back_btn_bookDetails.Size = new Size(94, 29);
            back_btn_bookDetails.TabIndex = 54;
            back_btn_bookDetails.Text = "back";
            back_btn_bookDetails.UseVisualStyleBackColor = true;
            back_btn_bookDetails.Click += back_btn_bookDetails_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 552);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 55;
            label3.Text = "Current Status:";
            // 
            // status_text
            // 
            status_text.AutoSize = true;
            status_text.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            status_text.ForeColor = Color.Black;
            status_text.Location = new Point(610, 547);
            status_text.Name = "status_text";
            status_text.Size = new Size(128, 25);
            status_text.TabIndex = 56;
            status_text.Text = "Not Available";
            // 
            // ViewBooksDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 775);
            Controls.Add(status_text);
            Controls.Add(label3);
            Controls.Add(back_btn_bookDetails);
            Controls.Add(reserveBtn);
            Controls.Add(borrowBtn);
            Controls.Add(isbn_text_veiwBooks);
            Controls.Add(label8);
            Controls.Add(author_text_veiwBooks);
            Controls.Add(year_text_veiwBooks);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(title_text_veiwBooks);
            Controls.Add(label2);
            Controls.Add(book_picture_viewBook);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewBooksDetails";
            Text = "ViewBooksDetails";
            Load += ViewBooksDetails_Load;
            ((System.ComponentModel.ISupportInitialize)book_picture_viewBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private PictureBox book_picture_viewBook;
        private TextBox author_text_veiwBooks;
        private TextBox year_text_veiwBooks;
        private Label label5;
        private Label label4;
        private TextBox title_text_veiwBooks;
        private Label label2;
        private TextBox isbn_text_veiwBooks;
        private Label label8;
        private Button borrowBtn;
        private Button reserveBtn;
        private Button back_btn_bookDetails;
        private Label label3;
        private Label status_text;
    }
}