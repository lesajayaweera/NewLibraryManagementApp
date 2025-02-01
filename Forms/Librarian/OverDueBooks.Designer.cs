namespace NewLibraryManagementApp
{
    partial class OverDueBooks
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
            dataGridViewOverDueBooks = new DataGridView();
            label1 = new Label();
            update = new Button();
            NotpaidRadio_l = new RadioButton();
            paidRadio_l = new RadioButton();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOverDueBooks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOverDueBooks
            // 
            dataGridViewOverDueBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOverDueBooks.Location = new Point(12, 67);
            dataGridViewOverDueBooks.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOverDueBooks.Name = "dataGridViewOverDueBooks";
            dataGridViewOverDueBooks.RowHeadersWidth = 51;
            dataGridViewOverDueBooks.RowTemplate.Height = 24;
            dataGridViewOverDueBooks.Size = new Size(1106, 397);
            dataGridViewOverDueBooks.TabIndex = 25;
            dataGridViewOverDueBooks.CellContentClick += dataGridViewOverDueBooks_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(470, 25);
            label1.Name = "label1";
            label1.Size = new Size(186, 29);
            label1.TabIndex = 24;
            label1.Text = "Over due Books";
            // 
            // update
            // 
            update.Location = new Point(441, 604);
            update.Name = "update";
            update.Size = new Size(201, 29);
            update.TabIndex = 42;
            update.Text = "Update OverDue";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // NotpaidRadio_l
            // 
            NotpaidRadio_l.AutoSize = true;
            NotpaidRadio_l.Location = new Point(263, 546);
            NotpaidRadio_l.Name = "NotpaidRadio_l";
            NotpaidRadio_l.Size = new Size(87, 24);
            NotpaidRadio_l.TabIndex = 53;
            NotpaidRadio_l.TabStop = true;
            NotpaidRadio_l.Text = "Not Paid";
            NotpaidRadio_l.UseVisualStyleBackColor = true;
            // 
            // paidRadio_l
            // 
            paidRadio_l.AutoSize = true;
            paidRadio_l.Location = new Point(263, 507);
            paidRadio_l.Name = "paidRadio_l";
            paidRadio_l.Size = new Size(58, 24);
            paidRadio_l.TabIndex = 52;
            paidRadio_l.TabStop = true;
            paidRadio_l.Text = "Paid";
            paidRadio_l.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 507);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 51;
            label2.Text = "Status :";
            // 
            // OverDueBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 655);
            Controls.Add(NotpaidRadio_l);
            Controls.Add(paidRadio_l);
            Controls.Add(label2);
            Controls.Add(update);
            Controls.Add(dataGridViewOverDueBooks);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OverDueBooks";
            Text = "OverDueBooks";
            Load += OverDueBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOverDueBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewOverDueBooks;
        private System.Windows.Forms.Label label1;
        private Button update;
        private RadioButton NotpaidRadio_l;
        private RadioButton paidRadio_l;
        private Label label2;
    }
}