namespace NewLibraryManagementApp
{
    partial class Login
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
            Login_btn_login = new Button();
            label2 = new Label();
            label3 = new Label();
            Password_text_login = new TextBox();
            Username_text_login = new TextBox();
            rejister_btn_login = new Button();
            label4 = new Label();
            label5 = new Label();
            Admin_radio_login = new RadioButton();
            Librarian_radio_login = new RadioButton();
            Student_radio_login = new RadioButton();
            ShowPass_check = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(350, 49);
            label1.Name = "label1";
            label1.Size = new Size(151, 29);
            label1.TabIndex = 0;
            label1.Text = "Library login ";
            label1.Click += label1_Click;
            // 
            // Login_btn_login
            // 
            Login_btn_login.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_btn_login.Location = new Point(321, 377);
            Login_btn_login.Margin = new Padding(2);
            Login_btn_login.Name = "Login_btn_login";
            Login_btn_login.Size = new Size(148, 51);
            Login_btn_login.TabIndex = 1;
            Login_btn_login.Text = "Login";
            Login_btn_login.Click += Login_btn_login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 129);
            label2.Name = "label2";
            label2.Size = new Size(79, 16);
            label2.TabIndex = 2;
            label2.Text = "UserName :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 188);
            label3.Name = "label3";
            label3.Size = new Size(73, 16);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            label3.Click += label3_Click;
            // 
            // Password_text_login
            // 
            Password_text_login.Location = new Point(336, 188);
            Password_text_login.Name = "Password_text_login";
            Password_text_login.PasswordChar = '*';
            Password_text_login.Size = new Size(206, 22);
            Password_text_login.TabIndex = 4;
            // 
            // Username_text_login
            // 
            Username_text_login.Location = new Point(336, 123);
            Username_text_login.Name = "Username_text_login";
            Username_text_login.Size = new Size(206, 22);
            Username_text_login.TabIndex = 5;
            Username_text_login.TextChanged += Username_text_login_TextChanged;
            // 
            // rejister_btn_login
            // 
            rejister_btn_login.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rejister_btn_login.Location = new Point(34, 445);
            rejister_btn_login.Margin = new Padding(2);
            rejister_btn_login.Name = "rejister_btn_login";
            rejister_btn_login.Size = new Size(216, 35);
            rejister_btn_login.TabIndex = 6;
            rejister_btn_login.Text = "Create an account";
            rejister_btn_login.UseVisualStyleBackColor = true;
            rejister_btn_login.Click += rejister_btn_login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 202);
            label4.Name = "label4";
            label4.Size = new Size(0, 16);
            label4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(297, 286);
            label5.Name = "label5";
            label5.Size = new Size(218, 29);
            label5.TabIndex = 9;
            label5.Text = "What is your Role ?";
            // 
            // Admin_radio_login
            // 
            Admin_radio_login.AutoSize = true;
            Admin_radio_login.Location = new Point(95, 336);
            Admin_radio_login.Name = "Admin_radio_login";
            Admin_radio_login.Size = new Size(66, 20);
            Admin_radio_login.TabIndex = 10;
            Admin_radio_login.TabStop = true;
            Admin_radio_login.Text = "Admin";
            Admin_radio_login.UseVisualStyleBackColor = true;
            // 
            // Librarian_radio_login
            // 
            Librarian_radio_login.AutoSize = true;
            Librarian_radio_login.Location = new Point(355, 336);
            Librarian_radio_login.Name = "Librarian_radio_login";
            Librarian_radio_login.Size = new Size(80, 20);
            Librarian_radio_login.TabIndex = 11;
            Librarian_radio_login.TabStop = true;
            Librarian_radio_login.Text = "Librarian";
            Librarian_radio_login.UseVisualStyleBackColor = true;
            // 
            // Student_radio_login
            // 
            Student_radio_login.AutoSize = true;
            Student_radio_login.Location = new Point(632, 336);
            Student_radio_login.Name = "Student_radio_login";
            Student_radio_login.Size = new Size(73, 20);
            Student_radio_login.TabIndex = 12;
            Student_radio_login.TabStop = true;
            Student_radio_login.Text = "Student";
            Student_radio_login.UseVisualStyleBackColor = true;
            // 
            // ShowPass_check
            // 
            ShowPass_check.AutoSize = true;
            ShowPass_check.Location = new Point(447, 229);
            ShowPass_check.Name = "ShowPass_check";
            ShowPass_check.Size = new Size(125, 20);
            ShowPass_check.TabIndex = 13;
            ShowPass_check.Text = "Show Password";
            ShowPass_check.UseVisualStyleBackColor = true;
            ShowPass_check.CheckedChanged += ShowPass_check_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(800, 491);
            Controls.Add(ShowPass_check);
            Controls.Add(Student_radio_login);
            Controls.Add(Librarian_radio_login);
            Controls.Add(Admin_radio_login);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(rejister_btn_login);
            Controls.Add(Username_text_login);
            Controls.Add(Password_text_login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Login_btn_login);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Login_btn_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password_text_login;
        private System.Windows.Forms.TextBox Username_text_login;
        private System.Windows.Forms.Button rejister_btn_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Admin_radio_login;
        private System.Windows.Forms.RadioButton Librarian_radio_login;
        private System.Windows.Forms.RadioButton Student_radio_login;
        private CheckBox ShowPass_check;
    }
}