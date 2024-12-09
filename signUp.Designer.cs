namespace member_space
{
    partial class signUp
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
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.Lgetstarted = new System.Windows.Forms.Label();
            this.Lusername = new System.Windows.Forms.Label();
            this.Lpassword = new System.Windows.Forms.Label();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbConfirmpass = new System.Windows.Forms.TextBox();
            this.Lconfirmpassword = new System.Windows.Forms.Label();
            this.CHbxShowPass = new System.Windows.Forms.CheckBox();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.LalreadyHaveAccount = new System.Windows.Forms.Label();
            this.LbacktoLogin = new System.Windows.Forms.Label();
            this.combobxSecurityQues = new System.Windows.Forms.ComboBox();
            this.textbSecurityQuesAns = new System.Windows.Forms.TextBox();
            this.LselectSecurityQues = new System.Windows.Forms.Label();
            this.LAnswer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.textBxFirstName = new System.Windows.Forms.TextBox();
            this.textBxLastname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtbInterests = new System.Windows.Forms.TextBox();
            this.txtbIntentions = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbUsername
            // 
            this.txtbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbUsername.Location = new System.Drawing.Point(513, 52);
            this.txtbUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtbUsername.Multiline = true;
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(121, 18);
            this.txtbUsername.TabIndex = 3;
            // 
            // Lgetstarted
            // 
            this.Lgetstarted.AutoSize = true;
            this.Lgetstarted.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lgetstarted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lgetstarted.Location = new System.Drawing.Point(271, 14);
            this.Lgetstarted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lgetstarted.Name = "Lgetstarted";
            this.Lgetstarted.Size = new System.Drawing.Size(131, 22);
            this.Lgetstarted.TabIndex = 4;
            this.Lgetstarted.Text = "Get Started";
            // 
            // Lusername
            // 
            this.Lusername.AutoSize = true;
            this.Lusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lusername.Location = new System.Drawing.Point(423, 49);
            this.Lusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lusername.Name = "Lusername";
            this.Lusername.Size = new System.Drawing.Size(83, 20);
            this.Lusername.TabIndex = 5;
            this.Lusername.Text = "Username";
            // 
            // Lpassword
            // 
            this.Lpassword.AutoSize = true;
            this.Lpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpassword.Location = new System.Drawing.Point(426, 84);
            this.Lpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lpassword.Name = "Lpassword";
            this.Lpassword.Size = new System.Drawing.Size(78, 20);
            this.Lpassword.TabIndex = 6;
            this.Lpassword.Text = "Password";
            // 
            // txtbPassword
            // 
            this.txtbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbPassword.Location = new System.Drawing.Point(513, 88);
            this.txtbPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtbPassword.Multiline = true;
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '*';
            this.txtbPassword.Size = new System.Drawing.Size(121, 18);
            this.txtbPassword.TabIndex = 7;
            this.txtbPassword.TextChanged += new System.EventHandler(this.txtbPassword_TextChanged);
            // 
            // txtbConfirmpass
            // 
            this.txtbConfirmpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbConfirmpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtbConfirmpass.Location = new System.Drawing.Point(513, 129);
            this.txtbConfirmpass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtbConfirmpass.Multiline = true;
            this.txtbConfirmpass.Name = "txtbConfirmpass";
            this.txtbConfirmpass.PasswordChar = '*';
            this.txtbConfirmpass.Size = new System.Drawing.Size(121, 18);
            this.txtbConfirmpass.TabIndex = 8;
            this.txtbConfirmpass.TextChanged += new System.EventHandler(this.txtbConfirmpass_TextChanged);
            // 
            // Lconfirmpassword
            // 
            this.Lconfirmpassword.AutoSize = true;
            this.Lconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lconfirmpassword.Location = new System.Drawing.Point(371, 125);
            this.Lconfirmpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lconfirmpassword.Name = "Lconfirmpassword";
            this.Lconfirmpassword.Size = new System.Drawing.Size(137, 20);
            this.Lconfirmpassword.TabIndex = 9;
            this.Lconfirmpassword.Text = "Confirm Password";
            // 
            // CHbxShowPass
            // 
            this.CHbxShowPass.AutoSize = true;
            this.CHbxShowPass.Location = new System.Drawing.Point(614, 165);
            this.CHbxShowPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CHbxShowPass.Name = "CHbxShowPass";
            this.CHbxShowPass.Size = new System.Drawing.Size(102, 17);
            this.CHbxShowPass.TabIndex = 10;
            this.CHbxShowPass.Text = "Show Password";
            this.CHbxShowPass.UseVisualStyleBackColor = true;
            this.CHbxShowPass.CheckedChanged += new System.EventHandler(this.CHbxShowPass_CheckedChanged);
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonRegister.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRegister.ForeColor = System.Drawing.Color.White;
            this.ButtonRegister.Location = new System.Drawing.Point(310, 405);
            this.ButtonRegister.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(147, 32);
            this.ButtonRegister.TabIndex = 11;
            this.ButtonRegister.Text = "REGISTER";
            this.ButtonRegister.UseVisualStyleBackColor = false;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // LalreadyHaveAccount
            // 
            this.LalreadyHaveAccount.AutoSize = true;
            this.LalreadyHaveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LalreadyHaveAccount.Location = new System.Drawing.Point(296, 440);
            this.LalreadyHaveAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LalreadyHaveAccount.Name = "LalreadyHaveAccount";
            this.LalreadyHaveAccount.Size = new System.Drawing.Size(169, 17);
            this.LalreadyHaveAccount.TabIndex = 12;
            this.LalreadyHaveAccount.Text = "Already Have An Account";
            // 
            // LbacktoLogin
            // 
            this.LbacktoLogin.AutoSize = true;
            this.LbacktoLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbacktoLogin.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbacktoLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbacktoLogin.Location = new System.Drawing.Point(310, 466);
            this.LbacktoLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbacktoLogin.Name = "LbacktoLogin";
            this.LbacktoLogin.Size = new System.Drawing.Size(117, 18);
            this.LbacktoLogin.TabIndex = 13;
            this.LbacktoLogin.Text = "Back To Login";
            this.LbacktoLogin.Click += new System.EventHandler(this.LbacktoLogin_Click);
            // 
            // combobxSecurityQues
            // 
            this.combobxSecurityQues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.combobxSecurityQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobxSecurityQues.ForeColor = System.Drawing.Color.White;
            this.combobxSecurityQues.FormattingEnabled = true;
            this.combobxSecurityQues.Items.AddRange(new object[] {
            "Name of the city you were born in?",
            "Name of the first school you went to?",
            "Name of your first pet?"});
            this.combobxSecurityQues.Location = new System.Drawing.Point(330, 218);
            this.combobxSecurityQues.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.combobxSecurityQues.Name = "combobxSecurityQues";
            this.combobxSecurityQues.Size = new System.Drawing.Size(194, 25);
            this.combobxSecurityQues.TabIndex = 14;
            this.combobxSecurityQues.SelectedIndexChanged += new System.EventHandler(this.combobxSecurityQues_SelectedIndexChanged);
            // 
            // textbSecurityQuesAns
            // 
            this.textbSecurityQuesAns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textbSecurityQuesAns.Location = new System.Drawing.Point(330, 255);
            this.textbSecurityQuesAns.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textbSecurityQuesAns.Multiline = true;
            this.textbSecurityQuesAns.Name = "textbSecurityQuesAns";
            this.textbSecurityQuesAns.Size = new System.Drawing.Size(194, 24);
            this.textbSecurityQuesAns.TabIndex = 15;
            this.textbSecurityQuesAns.TextChanged += new System.EventHandler(this.textbSecurityQuesAns_TextChanged);
            // 
            // LselectSecurityQues
            // 
            this.LselectSecurityQues.AutoSize = true;
            this.LselectSecurityQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LselectSecurityQues.Location = new System.Drawing.Point(65, 222);
            this.LselectSecurityQues.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LselectSecurityQues.Name = "LselectSecurityQues";
            this.LselectSecurityQues.Size = new System.Drawing.Size(221, 20);
            this.LselectSecurityQues.TabIndex = 16;
            this.LselectSecurityQues.Text = "Select Your Security Question";
            // 
            // LAnswer
            // 
            this.LAnswer.AutoSize = true;
            this.LAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAnswer.Location = new System.Drawing.Point(211, 259);
            this.LAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LAnswer.Name = "LAnswer";
            this.LAnswer.Size = new System.Drawing.Size(62, 20);
            this.LAnswer.TabIndex = 17;
            this.LAnswer.Text = "Answer";
            this.LAnswer.Click += new System.EventHandler(this.LAnswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Date of Birth";
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstname.Location = new System.Drawing.Point(65, 68);
            this.labelFirstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(86, 20);
            this.labelFirstname.TabIndex = 20;
            this.labelFirstname.Text = "First Name";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastname.Location = new System.Drawing.Point(65, 111);
            this.labelLastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(86, 20);
            this.labelLastname.TabIndex = 21;
            this.labelLastname.Text = "Last Name";
            // 
            // textBxFirstName
            // 
            this.textBxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBxFirstName.Location = new System.Drawing.Point(150, 68);
            this.textBxFirstName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBxFirstName.Multiline = true;
            this.textBxFirstName.Name = "textBxFirstName";
            this.textBxFirstName.Size = new System.Drawing.Size(121, 18);
            this.textBxFirstName.TabIndex = 22;
            this.textBxFirstName.TextChanged += new System.EventHandler(this.textBxFirstName_TextChanged);
            // 
            // textBxLastname
            // 
            this.textBxLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBxLastname.Location = new System.Drawing.Point(150, 111);
            this.textBxLastname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBxLastname.Multiline = true;
            this.textBxLastname.Name = "textBxLastname";
            this.textBxLastname.Size = new System.Drawing.Size(121, 18);
            this.textBxLastname.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(440, 225);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(330, 176);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker2.TabIndex = 24;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txtbInterests
            // 
            this.txtbInterests.Location = new System.Drawing.Point(150, 330);
            this.txtbInterests.Name = "txtbInterests";
            this.txtbInterests.Size = new System.Drawing.Size(182, 20);
            this.txtbInterests.TabIndex = 25;
            // 
            // txtbIntentions
            // 
            this.txtbIntentions.Location = new System.Drawing.Point(150, 366);
            this.txtbIntentions.Name = "txtbIntentions";
            this.txtbIntentions.Size = new System.Drawing.Size(182, 20);
            this.txtbIntentions.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Interests";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Intentions";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 502);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbIntentions);
            this.Controls.Add(this.txtbInterests);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBxLastname);
            this.Controls.Add(this.textBxFirstName);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LAnswer);
            this.Controls.Add(this.LselectSecurityQues);
            this.Controls.Add(this.textbSecurityQuesAns);
            this.Controls.Add(this.combobxSecurityQues);
            this.Controls.Add(this.LbacktoLogin);
            this.Controls.Add(this.LalreadyHaveAccount);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.CHbxShowPass);
            this.Controls.Add(this.Lconfirmpassword);
            this.Controls.Add(this.txtbConfirmpass);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.Lpassword);
            this.Controls.Add(this.Lusername);
            this.Controls.Add(this.Lgetstarted);
            this.Controls.Add(this.txtbUsername);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "signUp";
            this.Text = "signUp";
            this.Load += new System.EventHandler(this.signUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.Label Lgetstarted;
        private System.Windows.Forms.Label Lusername;
        private System.Windows.Forms.Label Lpassword;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbConfirmpass;
        private System.Windows.Forms.Label Lconfirmpassword;
        private System.Windows.Forms.CheckBox CHbxShowPass;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Label LalreadyHaveAccount;
        private System.Windows.Forms.Label LbacktoLogin;
        private System.Windows.Forms.ComboBox combobxSecurityQues;
        private System.Windows.Forms.TextBox textbSecurityQuesAns;
        private System.Windows.Forms.Label LselectSecurityQues;
        private System.Windows.Forms.Label LAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.TextBox textBxFirstName;
        private System.Windows.Forms.TextBox textBxLastname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtbInterests;
        private System.Windows.Forms.TextBox txtbIntentions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}