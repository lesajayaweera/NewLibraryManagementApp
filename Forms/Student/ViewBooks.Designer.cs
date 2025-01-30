namespace NewLibraryManagementApp
{
    partial class ViewBooks
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
            dataGridView_viewBook = new DataGridView();
            back_button = new Button();
            viewBookDetail_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_viewBook).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(517, 22);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 15;
            label7.Text = "View Books";
            // 
            // dataGridView_viewBook
            // 
            dataGridView_viewBook.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView_viewBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_viewBook.Location = new Point(12, 63);
            dataGridView_viewBook.Margin = new Padding(3, 4, 3, 4);
            dataGridView_viewBook.Name = "dataGridView_viewBook";
            dataGridView_viewBook.RowHeadersWidth = 51;
            dataGridView_viewBook.RowTemplate.Height = 24;
            dataGridView_viewBook.Size = new Size(860, 568);
            dataGridView_viewBook.TabIndex = 16;
            dataGridView_viewBook.CellContentClick += dataGridView_viewBook_CellContentClick;
            // 
            // back_button
            // 
            back_button.Location = new Point(12, 13);
            back_button.Margin = new Padding(3, 4, 3, 4);
            back_button.Name = "back_button";
            back_button.Size = new Size(104, 29);
            back_button.TabIndex = 18;
            back_button.Text = "Back";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // viewBookDetail_btn
            // 
            viewBookDetail_btn.Location = new Point(912, 364);
            viewBookDetail_btn.Name = "viewBookDetail_btn";
            viewBookDetail_btn.Size = new Size(152, 29);
            viewBookDetail_btn.TabIndex = 19;
            viewBookDetail_btn.Text = "View Book Detail";
            viewBookDetail_btn.UseVisualStyleBackColor = true;
            viewBookDetail_btn.Click += viewBookDetail_btn_Click;
            // 
            // ViewBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1137, 666);
            Controls.Add(viewBookDetail_btn);
            Controls.Add(back_button);
            Controls.Add(dataGridView_viewBook);
            Controls.Add(label7);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewBooks";
            Text = "ViewBooks";
            Load += ViewBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_viewBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView_viewBook;
        private System.Windows.Forms.Button back_button;
        private Button viewBookDetail_btn;
    }
}