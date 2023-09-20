namespace Tuan5
{
    partial class FrmBai2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txtRePassWord = new System.Windows.Forms.Label();
            this.txbRePassword = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txbEmail);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txbPassword);
            this.panel1.Controls.Add(this.txtRePassWord);
            this.panel1.Controls.Add(this.txbRePassword);
            this.panel1.Controls.Add(this.txtPassWord);
            this.panel1.Controls.Add(this.txbUserName);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Location = new System.Drawing.Point(2, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 237);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(118, 166);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(174, 52);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Đăng ký";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(118, 82);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(175, 20);
            this.txbEmail.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(10, 85);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(67, 13);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Text = "Địa chỉ email";
            // 
            // txbPassword
            // 
            this.txbPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbPassword.Location = new System.Drawing.Point(118, 108);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(175, 20);
            this.txbPassword.TabIndex = 6;
            // 
            // txtRePassWord
            // 
            this.txtRePassWord.AutoSize = true;
            this.txtRePassWord.Location = new System.Drawing.Point(13, 137);
            this.txtRePassWord.Name = "txtRePassWord";
            this.txtRePassWord.Size = new System.Drawing.Size(100, 13);
            this.txtRePassWord.TabIndex = 5;
            this.txtRePassWord.Text = "Xác nhận mật khẩu";
            // 
            // txbRePassword
            // 
            this.txbRePassword.Location = new System.Drawing.Point(118, 134);
            this.txbRePassword.Name = "txbRePassword";
            this.txbRePassword.Size = new System.Drawing.Size(175, 20);
            this.txbRePassword.TabIndex = 4;
            // 
            // txtPassWord
            // 
            this.txtPassWord.AutoSize = true;
            this.txtPassWord.Location = new System.Drawing.Point(11, 111);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(52, 13);
            this.txtPassWord.TabIndex = 3;
            this.txtPassWord.Text = "Mật khẩu";
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(118, 54);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(175, 20);
            this.txbUserName.TabIndex = 2;
            this.txbUserName.TextChanged += new System.EventHandler(this.txbUserName_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Location = new System.Drawing.Point(10, 57);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(81, 13);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "Tên đăng nhập";
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLogin.Location = new System.Drawing.Point(95, 15);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(175, 24);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Text = "Đăng ký tài khoản";
            this.txtLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 274);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBai2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBai2_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtLogin;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label txtRePassWord;
        private System.Windows.Forms.TextBox txbRePassword;
        private System.Windows.Forms.Label txtPassWord;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Button btnLogin;
    }
}