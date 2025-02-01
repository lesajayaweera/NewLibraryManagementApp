namespace NewLibraryManagementApp.Forms.Admin
{
    partial class OverDueAdmin
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
            updateOverdue = new Button();
            label3 = new Label();
            dataGridViewOverdue_admin = new DataGridView();
            label1 = new Label();
            button = new Button();
            paidRadio = new RadioButton();
            NotpaidRadio = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOverdue_admin).BeginInit();
            SuspendLayout();
            // 
            // updateOverdue
            // 
            updateOverdue.Location = new Point(441, 602);
            updateOverdue.Name = "updateOverdue";
            updateOverdue.Size = new Size(201, 29);
            updateOverdue.TabIndex = 47;
            updateOverdue.Text = "Update OverDue";
            updateOverdue.UseVisualStyleBackColor = true;
            updateOverdue.Click += updateOverdue_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 513);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 46;
            label3.Text = "Status :";
            // 
            // dataGridViewOverdue_admin
            // 
            dataGridViewOverdue_admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOverdue_admin.Location = new Point(12, 65);
            dataGridViewOverdue_admin.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOverdue_admin.Name = "dataGridViewOverdue_admin";
            dataGridViewOverdue_admin.RowHeadersWidth = 51;
            dataGridViewOverdue_admin.RowTemplate.Height = 24;
            dataGridViewOverdue_admin.Size = new Size(1106, 397);
            dataGridViewOverdue_admin.TabIndex = 44;
            dataGridViewOverdue_admin.CellContentClick += dataGridViewOverdue_admin_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(470, 23);
            label1.Name = "label1";
            label1.Size = new Size(186, 29);
            label1.TabIndex = 43;
            label1.Text = "Over due Books";
            // 
            // button
            // 
            button.Location = new Point(25, 24);
            button.Name = "button";
            button.Size = new Size(94, 29);
            button.TabIndex = 48;
            button.Text = "Back";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // paidRadio
            // 
            paidRadio.AutoSize = true;
            paidRadio.Location = new Point(270, 513);
            paidRadio.Name = "paidRadio";
            paidRadio.Size = new Size(58, 24);
            paidRadio.TabIndex = 49;
            paidRadio.TabStop = true;
            paidRadio.Text = "Paid";
            paidRadio.UseVisualStyleBackColor = true;
            // 
            // NotpaidRadio
            // 
            NotpaidRadio.AutoSize = true;
            NotpaidRadio.Location = new Point(270, 552);
            NotpaidRadio.Name = "NotpaidRadio";
            NotpaidRadio.Size = new Size(87, 24);
            NotpaidRadio.TabIndex = 50;
            NotpaidRadio.TabStop = true;
            NotpaidRadio.Text = "Not Paid";
            NotpaidRadio.UseVisualStyleBackColor = true;
            // 
            // OverDueAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 655);
            Controls.Add(NotpaidRadio);
            Controls.Add(paidRadio);
            Controls.Add(button);
            Controls.Add(updateOverdue);
            Controls.Add(label3);
            Controls.Add(dataGridViewOverdue_admin);
            Controls.Add(label1);
            Name = "OverDueAdmin";
            Text = "OverDueAdmin";
            Load += OverDueAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOverdue_admin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateOverdue;
        private Label label3;
        private DataGridView dataGridViewOverdue_admin;
        private Label label1;
        private Button button;
        private RadioButton paidRadio;
        private RadioButton NotpaidRadio;
    }
}