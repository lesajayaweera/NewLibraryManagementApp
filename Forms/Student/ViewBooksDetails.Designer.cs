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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 89);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(597, 538);
            dataGridView1.TabIndex = 30;
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(649, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 193);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(921, 273);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(249, 27);
            textBox5.TabIndex = 48;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(921, 377);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(249, 27);
            textBox4.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(921, 233);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 46;
            label5.Text = "Author Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(921, 338);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 45;
            label4.Text = "Publication :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(921, 183);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 27);
            textBox1.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(921, 139);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 43;
            label2.Text = "Book Tittle :";
            // 
            // button1
            // 
            button1.Location = new Point(253, 692);
            button1.Name = "button1";
            button1.Size = new Size(162, 44);
            button1.TabIndex = 49;
            button1.Text = "Veiw Details";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(922, 502);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 27);
            textBox3.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(924, 463);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 50;
            label8.Text = "Book Type :";
            // 
            // ViewBooksDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 775);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewBooksDetails";
            Text = "ViewBooksDetails";
            Load += ViewBooksDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private TextBox textBox3;
        private Label label8;
    }
}