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
            this.SuspendLayout();
            // 
            // txtbUsername
            // 
            this.txtbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbUsername.Location = new System.Drawing.Point(440, 73);
            this.txtbUsername.Multiline = true;
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(160, 22);
            this.txtbUsername.TabIndex = 3;
            // 
            // Lgetstarted
            // 
            this.Lgetstarted.AutoSize = true;
            this.Lgetstarted.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lgetstarted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lgetstarted.Location = new System.Drawing.Point(362, 18);
            this.Lgetstarted.Name = "Lgetstarted";
            this.Lgetstarted.Size = new System.Drawing.Size(163, 28);
            this.Lgetstarted.TabIndex = 4;
            this.Lgetstarted.Text = "Get Started";
            // 
            // Lusername
            // 
            this.Lusername.AutoSize = true;
            this.Lusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lusername.Location = new System.Drawing.Point(258, 73);
            this.Lusername.Name = "Lusername";
            this.Lusername.Size = new System.Drawing.Size(102, 25);
            this.Lusername.TabIndex = 5;
            this.Lusername.Text = "Username";
            // 
            // Lpassword
            // 
            this.Lpassword.AutoSize = true;
            this.Lpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpassword.Location = new System.Drawing.Point(262, 129);
            this.Lpassword.Name = "Lpassword";
            this.Lpassword.Size = new System.Drawing.Size(98, 25);
            this.Lpassword.TabIndex = 6;
            this.Lpassword.Text = "Password";
            this.Lpassword.Click += new System.EventHandler(this.Lpassword_Click);
            // 
            // txtbPassword
            // 
            this.txtbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbPassword.Location = new System.Drawing.Point(440, 129);
            this.txtbPassword.Multiline = true;
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '*';
            this.txtbPassword.Size = new System.Drawing.Size(160, 22);
            this.txtbPassword.TabIndex = 7;
            this.txtbPassword.TextChanged += new System.EventHandler(this.txtbPassword_TextChanged);
            // 
            // txtbConfirmpass
            // 
            this.txtbConfirmpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtbConfirmpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtbConfirmpass.Location = new System.Drawing.Point(440, 186);
            this.txtbConfirmpass.Multiline = true;
            this.txtbConfirmpass.Name = "txtbConfirmpass";
            this.txtbConfirmpass.PasswordChar = '*';
            this.txtbConfirmpass.Size = new System.Drawing.Size(160, 22);
            this.txtbConfirmpass.TabIndex = 8;
            // 
            // Lconfirmpassword
            // 
            this.Lconfirmpassword.AutoSize = true;
            this.Lconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lconfirmpassword.Location = new System.Drawing.Point(189, 186);
            this.Lconfirmpassword.Name = "Lconfirmpassword";
            this.Lconfirmpassword.Size = new System.Drawing.Size(171, 25);
            this.Lconfirmpassword.TabIndex = 9;
            this.Lconfirmpassword.Text = "Confirm Password";
            // 
            // CHbxShowPass
            // 
            this.CHbxShowPass.AutoSize = true;
            this.CHbxShowPass.Location = new System.Drawing.Point(613, 228);
            this.CHbxShowPass.Name = "CHbxShowPass";
            this.CHbxShowPass.Size = new System.Drawing.Size(125, 20);
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
            this.ButtonRegister.Location = new System.Drawing.Point(413, 370);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(140, 40);
            this.ButtonRegister.TabIndex = 11;
            this.ButtonRegister.Text = "REGISTER";
            this.ButtonRegister.UseVisualStyleBackColor = false;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // LalreadyHaveAccount
            // 
            this.LalreadyHaveAccount.AutoSize = true;
            this.LalreadyHaveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LalreadyHaveAccount.Location = new System.Drawing.Point(383, 427);
            this.LalreadyHaveAccount.Name = "LalreadyHaveAccount";
            this.LalreadyHaveAccount.Size = new System.Drawing.Size(200, 20);
            this.LalreadyHaveAccount.TabIndex = 12;
            this.LalreadyHaveAccount.Text = "Already Have An Account";
            // 
            // LbacktoLogin
            // 
            this.LbacktoLogin.AutoSize = true;
            this.LbacktoLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbacktoLogin.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbacktoLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbacktoLogin.Location = new System.Drawing.Point(413, 462);
            this.LbacktoLogin.Name = "LbacktoLogin";
            this.LbacktoLogin.Size = new System.Drawing.Size(144, 22);
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
            "Nmae of the city you were born in?",
            "Name of the first school you went to?",
            "Nmae of your first pet?"});
            this.combobxSecurityQues.Location = new System.Drawing.Point(440, 268);
            this.combobxSecurityQues.Name = "combobxSecurityQues";
            this.combobxSecurityQues.Size = new System.Drawing.Size(257, 30);
            this.combobxSecurityQues.TabIndex = 14;
            // 
            // textbSecurityQuesAns
            // 
            this.textbSecurityQuesAns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textbSecurityQuesAns.Location = new System.Drawing.Point(440, 314);
            this.textbSecurityQuesAns.Multiline = true;
            this.textbSecurityQuesAns.Name = "textbSecurityQuesAns";
            this.textbSecurityQuesAns.Size = new System.Drawing.Size(257, 29);
            this.textbSecurityQuesAns.TabIndex = 15;
            // 
            // LselectSecurityQues
            // 
            this.LselectSecurityQues.AutoSize = true;
            this.LselectSecurityQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LselectSecurityQues.Location = new System.Drawing.Point(87, 273);
            this.LselectSecurityQues.Name = "LselectSecurityQues";
            this.LselectSecurityQues.Size = new System.Drawing.Size(273, 25);
            this.LselectSecurityQues.TabIndex = 16;
            this.LselectSecurityQues.Text = "Select Your Security Question";
            // 
            // LAnswer
            // 
            this.LAnswer.AutoSize = true;
            this.LAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAnswer.Location = new System.Drawing.Point(282, 318);
            this.LAnswer.Name = "LAnswer";
            this.LAnswer.Size = new System.Drawing.Size(78, 25);
            this.LAnswer.TabIndex = 17;
            this.LAnswer.Text = "Answer";
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 514);
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
    }
}