namespace NewLibraryManagementApp
{
    partial class ViewReservationBooks
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
            dataGridView_Reservations = new DataGridView();
            button2 = new Button();
            label4 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Reservations).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(426, 40);
            label1.Name = "label1";
            label1.Size = new Size(215, 29);
            label1.TabIndex = 2;
            label1.Text = "Reservation Books";
            // 
            // dataGridView_Reservations
            // 
            dataGridView_Reservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Reservations.Location = new Point(31, 90);
            dataGridView_Reservations.Margin = new Padding(3, 4, 3, 4);
            dataGridView_Reservations.Name = "dataGridView_Reservations";
            dataGridView_Reservations.RowHeadersWidth = 51;
            dataGridView_Reservations.RowTemplate.Height = 24;
            dataGridView_Reservations.Size = new Size(1071, 487);
            dataGridView_Reservations.TabIndex = 20;
            dataGridView_Reservations.CellContentClick += dataGridView_Reservations_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(440, 712);
            button2.Name = "button2";
            button2.Size = new Size(219, 62);
            button2.TabIndex = 42;
            button2.Text = "Confirm Reservation";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(651, 626);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 41;
            label4.Text = "Collect Status";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(791, 660);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(116, 24);
            radioButton2.TabIndex = 40;
            radioButton2.TabStop = true;
            radioButton2.Text = "In the Library\r\n";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(665, 660);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 24);
            radioButton1.TabIndex = 39;
            radioButton1.TabStop = true;
            radioButton1.Text = "Collected";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 629);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 38;
            label3.Text = "Status :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Confirmed", "Denied", "Pending" });
            comboBox1.Location = new Point(291, 626);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 37;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(138, 34);
            button1.TabIndex = 43;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ViewReservationBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 786);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView_Reservations);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewReservationBooks";
            Text = "ReservationBooks";
            Load += ViewReservationBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Reservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Reservations;
        private Button button2;
        private Label label4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
    }
}