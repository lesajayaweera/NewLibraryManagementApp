namespace NewLibraryManagementApp
{
    partial class Register
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            username_text = new TextBox();
            password_text = new TextBox();
            phonenumber_text = new TextBox();
            email_text = new TextBox();
            rejister_btn_register = new Button();
            login_btn_register = new Button();
            Student_radio_register = new RadioButton();
            Librarian_radio_Register = new RadioButton();
            Admin_radio_register = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 61);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Register";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(500, 122);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 136);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "UserName :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 222);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 3;
            label4.Text = "E-mail :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(204, 175);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 4;
            label5.Text = "Phone Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(204, 265);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 5;
            label6.Text = "Password :";
            // 
            // username_text
            // 
            username_text.Location = new Point(328, 133);
            username_text.Margin = new Padding(3, 4, 3, 4);
            username_text.Name = "username_text";
            username_text.Size = new Size(180, 27);
            username_text.TabIndex = 6;
            username_text.TextChanged += textBox1_TextChanged;
            // 
            // password_text
            // 
            password_text.Location = new Point(328, 265);
            password_text.Margin = new Padding(3, 4, 3, 4);
            password_text.Name = "password_text";
            password_text.Size = new Size(180, 27);
            password_text.TabIndex = 7;
            // 
            // phonenumber_text
            // 
            phonenumber_text.Location = new Point(328, 175);
            phonenumber_text.Margin = new Padding(3, 4, 3, 4);
            phonenumber_text.Name = "phonenumber_text";
            phonenumber_text.Size = new Size(180, 27);
            phonenumber_text.TabIndex = 8;
            // 
            // email_text
            // 
            email_text.Location = new Point(328, 222);
            email_text.Margin = new Padding(3, 4, 3, 4);
            email_text.Name = "email_text";
            email_text.Size = new Size(180, 27);
            email_text.TabIndex = 9;
            // 
            // rejister_btn_register
            // 
            rejister_btn_register.Location = new Point(352, 421);
            rejister_btn_register.Margin = new Padding(3, 4, 3, 4);
            rejister_btn_register.Name = "rejister_btn_register";
            rejister_btn_register.Size = new Size(86, 40);
            rejister_btn_register.TabIndex = 10;
            rejister_btn_register.Text = "Sign in";
            rejister_btn_register.UseVisualStyleBackColor = true;
            rejister_btn_register.Click += button1_Click;
            // 
            // login_btn_register
            // 
            login_btn_register.Location = new Point(603, 421);
            login_btn_register.Margin = new Padding(3, 4, 3, 4);
            login_btn_register.Name = "login_btn_register";
            login_btn_register.Size = new Size(75, 34);
            login_btn_register.TabIndex = 13;
            login_btn_register.Text = "Login";
            login_btn_register.UseVisualStyleBackColor = true;
            login_btn_register.Click += login_btn_register_Click;
            // 
            // Student_radio_register
            // 
            Student_radio_register.AutoSize = true;
            Student_radio_register.Location = new Point(628, 343);
            Student_radio_register.Name = "Student_radio_register";
            Student_radio_register.Size = new Size(81, 24);
            Student_radio_register.TabIndex = 17;
            Student_radio_register.TabStop = true;
            Student_radio_register.Text = "Student";
            Student_radio_register.UseVisualStyleBackColor = true;
            // 
            // Librarian_radio_Register
            // 
            Librarian_radio_Register.AutoSize = true;
            Librarian_radio_Register.Location = new Point(351, 343);
            Librarian_radio_Register.Name = "Librarian_radio_Register";
            Librarian_radio_Register.Size = new Size(88, 24);
            Librarian_radio_Register.TabIndex = 16;
            Librarian_radio_Register.TabStop = true;
            Librarian_radio_Register.Text = "Librarian";
            Librarian_radio_Register.UseVisualStyleBackColor = true;
            // 
            // Admin_radio_register
            // 
            Admin_radio_register.AutoSize = true;
            Admin_radio_register.Location = new Point(91, 343);
            Admin_radio_register.Name = "Admin_radio_register";
            Admin_radio_register.Size = new Size(74, 24);
            Admin_radio_register.TabIndex = 15;
            Admin_radio_register.TabStop = true;
            Admin_radio_register.Text = "Admin";
            Admin_radio_register.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(Student_radio_register);
            Controls.Add(Librarian_radio_Register);
            Controls.Add(Admin_radio_register);
            Controls.Add(login_btn_register);
            Controls.Add(rejister_btn_register);
            Controls.Add(email_text);
            Controls.Add(phonenumber_text);
            Controls.Add(password_text);
            Controls.Add(username_text);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register";
            Text = "Form1";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.TextBox phonenumber_text;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Button rejister_btn_register;
        private System.Windows.Forms.Button login_btn_register;
        private RadioButton Student_radio_register;
        private RadioButton Librarian_radio_Register;
        private RadioButton Admin_radio_register;
    }
}