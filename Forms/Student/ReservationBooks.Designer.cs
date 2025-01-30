namespace NewLibraryManagementApp
{
    partial class ReservationBooks
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
            textBox3 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            backbutton_reservation = new Button();
            dataGridView_reserveBooks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_reserveBooks).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 367);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 27);
            textBox3.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 374);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 47;
            label8.Text = "Book Author :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(485, 9);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 46;
            label7.Text = "Reservation Books";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(140, 315);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(249, 27);
            textBox5.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 319);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 38;
            label5.Text = "Book Tittle:";
            // 
            // backbutton_reservation
            // 
            backbutton_reservation.Location = new Point(12, 12);
            backbutton_reservation.Name = "backbutton_reservation";
            backbutton_reservation.Size = new Size(94, 29);
            backbutton_reservation.TabIndex = 56;
            backbutton_reservation.Text = "back";
            backbutton_reservation.UseVisualStyleBackColor = true;
            backbutton_reservation.Click += backbutton_reservation_Click;
            // 
            // dataGridView_reserveBooks
            // 
            dataGridView_reserveBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_reserveBooks.Location = new Point(414, 65);
            dataGridView_reserveBooks.Name = "dataGridView_reserveBooks";
            dataGridView_reserveBooks.RowHeadersWidth = 51;
            dataGridView_reserveBooks.Size = new Size(671, 520);
            dataGridView_reserveBooks.TabIndex = 62;
            dataGridView_reserveBooks.CellContentClick += dataGridView_reserveBooks_CellContentClick;
            // 
            // ReservationBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 694);
            Controls.Add(dataGridView_reserveBooks);
            Controls.Add(backbutton_reservation);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReservationBooks";
            Text = "ReservationBooks";
            Load += ReservationBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_reserveBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private Button backbutton_reservation;
        private DataGridView dataGridView_reserveBooks;
    }
}