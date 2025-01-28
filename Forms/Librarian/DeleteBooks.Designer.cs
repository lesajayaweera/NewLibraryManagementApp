namespace NewLibraryManagementApp
{
    partial class DeleteBooks
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
            dataGridView_books = new DataGridView();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            bookisbn_text = new TextBox();
            label5 = new Label();
            bookyear_text = new TextBox();
            bookauthor_text = new TextBox();
            bookname_text = new TextBox();
            removeBookbtn = new Button();
            backbutton = new Button();
            bookpictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_books).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookpictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(433, 32);
            label1.Name = "label1";
            label1.Size = new Size(177, 29);
            label1.TabIndex = 1;
            label1.Text = "Remove Books";
            // 
            // dataGridView_books
            // 
            dataGridView_books.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView_books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_books.GridColor = SystemColors.HighlightText;
            dataGridView_books.Location = new Point(454, 77);
            dataGridView_books.Margin = new Padding(3, 4, 3, 4);
            dataGridView_books.Name = "dataGridView_books";
            dataGridView_books.RowHeadersWidth = 51;
            dataGridView_books.RowTemplate.Height = 24;
            dataGridView_books.Size = new Size(650, 447);
            dataGridView_books.TabIndex = 17;
            dataGridView_books.CellContentClick += dataGridView_books_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 297);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 29;
            label4.Text = "Book Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 359);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 31;
            label2.Text = "Book Author :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 420);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 33;
            label3.Text = "Book Year :";
            // 
            // bookisbn_text
            // 
            bookisbn_text.Location = new Point(124, 490);
            bookisbn_text.Margin = new Padding(3, 4, 3, 4);
            bookisbn_text.Name = "bookisbn_text";
            bookisbn_text.Size = new Size(295, 27);
            bookisbn_text.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 490);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 35;
            label5.Text = "Book ISBN :";
            // 
            // bookyear_text
            // 
            bookyear_text.Location = new Point(124, 420);
            bookyear_text.Margin = new Padding(3, 4, 3, 4);
            bookyear_text.Name = "bookyear_text";
            bookyear_text.Size = new Size(295, 27);
            bookyear_text.TabIndex = 34;
            // 
            // bookauthor_text
            // 
            bookauthor_text.Location = new Point(124, 359);
            bookauthor_text.Margin = new Padding(3, 4, 3, 4);
            bookauthor_text.Name = "bookauthor_text";
            bookauthor_text.Size = new Size(295, 27);
            bookauthor_text.TabIndex = 32;
            // 
            // bookname_text
            // 
            bookname_text.Location = new Point(124, 297);
            bookname_text.Margin = new Padding(3, 4, 3, 4);
            bookname_text.Name = "bookname_text";
            bookname_text.Size = new Size(295, 27);
            bookname_text.TabIndex = 30;
            // 
            // removeBookbtn
            // 
            removeBookbtn.BackColor = Color.Red;
            removeBookbtn.ForeColor = SystemColors.ButtonFace;
            removeBookbtn.Location = new Point(681, 611);
            removeBookbtn.Name = "removeBookbtn";
            removeBookbtn.Size = new Size(169, 47);
            removeBookbtn.TabIndex = 38;
            removeBookbtn.Text = "Remove book";
            removeBookbtn.UseVisualStyleBackColor = false;
            removeBookbtn.Click += removeBookbtn_Click;
            // 
            // backbutton
            // 
            backbutton.Location = new Point(15, 18);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(94, 29);
            backbutton.TabIndex = 39;
            backbutton.Text = "back";
            backbutton.UseVisualStyleBackColor = true;
            backbutton.Click += backbutton_Click;
            // 
            // bookpictureBox
            // 
            bookpictureBox.Location = new Point(241, 77);
            bookpictureBox.Name = "bookpictureBox";
            bookpictureBox.Size = new Size(169, 194);
            bookpictureBox.TabIndex = 40;
            bookpictureBox.TabStop = false;
            // 
            // DeleteBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1136, 760);
            Controls.Add(bookpictureBox);
            Controls.Add(backbutton);
            Controls.Add(removeBookbtn);
            Controls.Add(bookisbn_text);
            Controls.Add(label5);
            Controls.Add(bookyear_text);
            Controls.Add(label3);
            Controls.Add(bookauthor_text);
            Controls.Add(label2);
            Controls.Add(bookname_text);
            Controls.Add(label4);
            Controls.Add(dataGridView_books);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DeleteBooks";
            Text = "RemoveBooks";
            Load += DeleteBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_books).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_books;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox bookisbn_text;
        private Label label5;
        private TextBox bookyear_text;
        private TextBox bookauthor_text;
        private TextBox bookname_text;
        private Button removeBookbtn;
        private Button backbutton;
        private PictureBox bookpictureBox;
    }
}