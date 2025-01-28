namespace NewLibraryManagementApp
{
    partial class EditBooks
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
            label7 = new Label();
            savebutton = new Button();
            yeartextBox = new TextBox();
            authortextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            titletextBox = new TextBox();
            label1 = new Label();
            label8 = new Label();
            isbntextBox = new TextBox();
            pictureBoxEdit = new PictureBox();
            backbtn = new Button();
            dataGridView_editbooks = new DataGridView();
            uploadbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_editbooks).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(452, 9);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 28;
            label7.Text = "Edit Books";
            // 
            // savebutton
            // 
            savebutton.Location = new Point(692, 613);
            savebutton.Margin = new Padding(3, 4, 3, 4);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(123, 59);
            savebutton.TabIndex = 27;
            savebutton.Text = "Save ";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // yeartextBox
            // 
            yeartextBox.Location = new Point(156, 270);
            yeartextBox.Margin = new Padding(3, 4, 3, 4);
            yeartextBox.Name = "yeartextBox";
            yeartextBox.Size = new Size(249, 27);
            yeartextBox.TabIndex = 25;
            // 
            // authortextBox
            // 
            authortextBox.Location = new Point(156, 208);
            authortextBox.Margin = new Padding(3, 4, 3, 4);
            authortextBox.Name = "authortextBox";
            authortextBox.Size = new Size(249, 27);
            authortextBox.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 278);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 21;
            label6.Text = "Year :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 205);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 20;
            label5.Text = "Author Name :";
            // 
            // titletextBox
            // 
            titletextBox.Location = new Point(156, 128);
            titletextBox.Margin = new Padding(3, 4, 3, 4);
            titletextBox.Name = "titletextBox";
            titletextBox.Size = new Size(249, 27);
            titletextBox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 135);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 15;
            label1.Text = "Book Tittle :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 351);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 29;
            label8.Text = "Book ISBN :";
            // 
            // isbntextBox
            // 
            isbntextBox.Location = new Point(156, 344);
            isbntextBox.Margin = new Padding(3, 4, 3, 4);
            isbntextBox.Name = "isbntextBox";
            isbntextBox.Size = new Size(249, 27);
            isbntextBox.TabIndex = 30;
            // 
            // pictureBoxEdit
            // 
            pictureBoxEdit.Location = new Point(12, 399);
            pictureBoxEdit.Name = "pictureBoxEdit";
            pictureBoxEdit.Size = new Size(209, 255);
            pictureBoxEdit.TabIndex = 31;
            pictureBoxEdit.TabStop = false;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(12, 12);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(94, 29);
            backbtn.TabIndex = 32;
            backbtn.Text = "back";
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // dataGridView_editbooks
            // 
            dataGridView_editbooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_editbooks.Location = new Point(532, 57);
            dataGridView_editbooks.Name = "dataGridView_editbooks";
            dataGridView_editbooks.RowHeadersWidth = 51;
            dataGridView_editbooks.Size = new Size(580, 517);
            dataGridView_editbooks.TabIndex = 33;
            dataGridView_editbooks.CellContentClick += dataGridView_editbooks_CellContentClick;
            // 
            // uploadbtn
            // 
            uploadbtn.Location = new Point(276, 474);
            uploadbtn.Name = "uploadbtn";
            uploadbtn.Size = new Size(138, 29);
            uploadbtn.TabIndex = 34;
            uploadbtn.Text = "Upload image";
            uploadbtn.UseVisualStyleBackColor = true;
            uploadbtn.Click += uploadbtn_Click;
            // 
            // EditBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 700);
            Controls.Add(uploadbtn);
            Controls.Add(dataGridView_editbooks);
            Controls.Add(backbtn);
            Controls.Add(pictureBoxEdit);
            Controls.Add(isbntextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(savebutton);
            Controls.Add(yeartextBox);
            Controls.Add(authortextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(titletextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditBooks";
            Text = "EditBooks";
            Load += EditBooks_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_editbooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.TextBox yeartextBox;
        private System.Windows.Forms.TextBox authortextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox titletextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox isbntextBox;
        private PictureBox pictureBoxEdit;
        private Button backbtn;
        private DataGridView dataGridView_editbooks;
        private Button uploadbtn;
    }
}