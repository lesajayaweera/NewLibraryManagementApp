namespace NewLibraryManagementApp.Forms.Student
{
    partial class OverDueStudent
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
            dataGridViewOverdue_student = new DataGridView();
            label1 = new Label();
            panel4 = new Panel();
            totalFines = new Label();
            label10 = new Label();
            label2 = new Label();
            Messagelabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOverdue_student).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewOverdue_student
            // 
            dataGridViewOverdue_student.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewOverdue_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOverdue_student.Location = new Point(12, 182);
            dataGridViewOverdue_student.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOverdue_student.Name = "dataGridViewOverdue_student";
            dataGridViewOverdue_student.RowHeadersWidth = 51;
            dataGridViewOverdue_student.RowTemplate.Height = 24;
            dataGridViewOverdue_student.Size = new Size(1114, 467);
            dataGridViewOverdue_student.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(470, 12);
            label1.Name = "label1";
            label1.Size = new Size(186, 29);
            label1.TabIndex = 45;
            label1.Text = "Over due Books";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Lavender;
            panel4.Controls.Add(totalFines);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(894, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 94);
            panel4.TabIndex = 47;
            // 
            // totalFines
            // 
            totalFines.AutoSize = true;
            totalFines.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalFines.Location = new Point(93, 17);
            totalFines.Name = "totalFines";
            totalFines.Size = new Size(34, 38);
            totalFines.TabIndex = 1;
            totalFines.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 55);
            label10.Name = "label10";
            label10.Size = new Size(209, 28);
            label10.TabIndex = 0;
            label10.Text = "Total Fine To Be Paid";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(145, 33);
            label2.TabIndex = 48;
            label2.Text = "Message:";
            // 
            // Messagelabel
            // 
            Messagelabel.AutoSize = true;
            Messagelabel.Location = new Point(163, 106);
            Messagelabel.Name = "Messagelabel";
            Messagelabel.Size = new Size(50, 20);
            Messagelabel.TabIndex = 49;
            Messagelabel.Text = "label3";
            // 
            // OverDueStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1130, 655);
            Controls.Add(Messagelabel);
            Controls.Add(label2);
            Controls.Add(panel4);
            Controls.Add(dataGridViewOverdue_student);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "OverDueStudent";
            Text = "OverDueStudent";
            Load += OverDueStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOverdue_student).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridViewOverdue_student;
        private Label label1;
        private Panel panel4;
        private Label totalFines;
        private Label label10;
        private Label label2;
        private Label Messagelabel;
    }
}