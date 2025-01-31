namespace NewLibraryManagementApp
{
    partial class ReturnBooks
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
            button1 = new Button();
            dataGridView_returnBooks = new DataGridView();
            label1 = new Label();
            returnBook_btn = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView_returnBooks).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 40);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(104, 29);
            button1.TabIndex = 37;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView_returnBooks
            // 
            dataGridView_returnBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_returnBooks.Location = new Point(30, 139);
            dataGridView_returnBooks.Margin = new Padding(3, 4, 3, 4);
            dataGridView_returnBooks.Name = "dataGridView_returnBooks";
            dataGridView_returnBooks.RowHeadersWidth = 51;
            dataGridView_returnBooks.RowTemplate.Height = 24;
            dataGridView_returnBooks.Size = new Size(1071, 417);
            dataGridView_returnBooks.TabIndex = 35;
            dataGridView_returnBooks.CellContentClick += dataGridView_returnBooks_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(426, 40);
            label1.Name = "label1";
            label1.Size = new Size(164, 29);
            label1.TabIndex = 34;
            label1.Text = "Return Books ";
            // 
            // returnBook_btn
            // 
            returnBook_btn.Location = new Point(426, 613);
            returnBook_btn.Name = "returnBook_btn";
            returnBook_btn.Size = new Size(145, 29);
            returnBook_btn.TabIndex = 38;
            returnBook_btn.Text = "Return Book";
            returnBook_btn.UseVisualStyleBackColor = true;
            returnBook_btn.Click += returnBook_btn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(607, 576);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 39;
            // 
            // ReturnBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 681);
            Controls.Add(dateTimePicker1);
            Controls.Add(returnBook_btn);
            Controls.Add(button1);
            Controls.Add(dataGridView_returnBooks);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReturnBooks";
            Text = "ReturnBooks";
            Load += ReturnBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_returnBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_returnBooks;
        private System.Windows.Forms.Label label1;
        private Button returnBook_btn;
        private DateTimePicker dateTimePicker1;
    }
}