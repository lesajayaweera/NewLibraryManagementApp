namespace NewLibraryManagementApp
{
    partial class AddBooks
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
            label8 = new Label();
            label7 = new Label();
            addBook_btn = new Button();
            author_text = new TextBox();
            isbn_text = new TextBox();
            label5 = new Label();
            label4 = new Label();
            title_text = new TextBox();
            label1 = new Label();
            Book_pictureBox = new PictureBox();
            uploadImageBtn = new Button();
            year_text = new TextBox();
            button = new Button();
            ((System.ComponentModel.ISupportInitialize)Book_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 341);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 47;
            label8.Text = "Year :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(532, 80);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 46;
            label7.Text = "Add Books";
            // 
            // addBook_btn
            // 
            addBook_btn.Location = new Point(535, 494);
            addBook_btn.Margin = new Padding(3, 4, 3, 4);
            addBook_btn.Name = "addBook_btn";
            addBook_btn.Size = new Size(123, 59);
            addBook_btn.TabIndex = 45;
            addBook_btn.Text = "Add Books";
            addBook_btn.UseVisualStyleBackColor = true;
            addBook_btn.Click += addBook_btn_Click;
            // 
            // author_text
            // 
            author_text.Location = new Point(192, 255);
            author_text.Margin = new Padding(3, 4, 3, 4);
            author_text.Name = "author_text";
            author_text.Size = new Size(249, 27);
            author_text.TabIndex = 42;
            // 
            // isbn_text
            // 
            isbn_text.Location = new Point(840, 179);
            isbn_text.Margin = new Padding(3, 4, 3, 4);
            isbn_text.Name = "isbn_text";
            isbn_text.Size = new Size(249, 27);
            isbn_text.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 252);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 38;
            label5.Text = "Author Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(724, 182);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 37;
            label4.Text = "ISBN:";
            // 
            // title_text
            // 
            title_text.Location = new Point(192, 175);
            title_text.Margin = new Padding(3, 4, 3, 4);
            title_text.Name = "title_text";
            title_text.Size = new Size(249, 27);
            title_text.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 182);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 33;
            label1.Text = "Book Tittle :";
            // 
            // Book_pictureBox
            // 
            Book_pictureBox.Location = new Point(726, 248);
            Book_pictureBox.Name = "Book_pictureBox";
            Book_pictureBox.Size = new Size(175, 208);
            Book_pictureBox.TabIndex = 49;
            Book_pictureBox.TabStop = false;
            // 
            // uploadImageBtn
            // 
            uploadImageBtn.Location = new Point(945, 322);
            uploadImageBtn.Margin = new Padding(3, 4, 3, 4);
            uploadImageBtn.Name = "uploadImageBtn";
            uploadImageBtn.Size = new Size(123, 59);
            uploadImageBtn.TabIndex = 50;
            uploadImageBtn.Text = "Upload Image";
            uploadImageBtn.UseVisualStyleBackColor = true;
            uploadImageBtn.Click += uploadImageBtn_Click;
            // 
            // year_text
            // 
            year_text.Location = new Point(192, 334);
            year_text.Margin = new Padding(3, 4, 3, 4);
            year_text.Name = "year_text";
            year_text.Size = new Size(249, 27);
            year_text.TabIndex = 51;
            // 
            // button
            // 
            button.Location = new Point(42, 54);
            button.Name = "button";
            button.Size = new Size(94, 29);
            button.TabIndex = 52;
            button.Text = "back";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 665);
            Controls.Add(button);
            Controls.Add(year_text);
            Controls.Add(uploadImageBtn);
            Controls.Add(Book_pictureBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(addBook_btn);
            Controls.Add(author_text);
            Controls.Add(isbn_text);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(title_text);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddBooks";
            Text = "AddBooks";
            Load += AddBooks_Load;
            ((System.ComponentModel.ISupportInitialize)Book_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addBook_btn;
        private System.Windows.Forms.TextBox author_text;
        private System.Windows.Forms.TextBox isbn_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox title_text;
        private System.Windows.Forms.Label label1;
        private PictureBox Book_pictureBox;
        private Button uploadImageBtn;
        private TextBox year_text;
        private Button button;
    }
}