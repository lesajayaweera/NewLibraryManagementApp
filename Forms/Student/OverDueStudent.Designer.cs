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
            ((System.ComponentModel.ISupportInitialize)dataGridViewOverdue_student).BeginInit();
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
            dataGridViewOverdue_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOverdue_student.Location = new Point(12, 81);
            dataGridViewOverdue_student.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOverdue_student.Name = "dataGridViewOverdue_student";
            dataGridViewOverdue_student.RowHeadersWidth = 51;
            dataGridViewOverdue_student.RowTemplate.Height = 24;
            dataGridViewOverdue_student.Size = new Size(1106, 398);
            dataGridViewOverdue_student.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(470, 39);
            label1.Name = "label1";
            label1.Size = new Size(186, 29);
            label1.TabIndex = 45;
            label1.Text = "Over due Books";
            // 
            // OverDueStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 655);
            Controls.Add(dataGridViewOverdue_student);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "OverDueStudent";
            Text = "OverDueStudent";
            Load += OverDueStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOverdue_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridViewOverdue_student;
        private Label label1;
    }
}