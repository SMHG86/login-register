namespace test2
{
    partial class DeleteAccountForm
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
            btnDeleteAccount = new Button();
            label1 = new Label();
            lblCaptcha = new Label();
            txtPassword = new TextBox();
            txtCaptcha = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            SuspendLayout();
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Font = new Font("Segoe UI", 12F);
            btnDeleteAccount.Location = new Point(294, 278);
            btnDeleteAccount.Margin = new Padding(3, 2, 3, 2);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(116, 68);
            btnDeleteAccount.TabIndex = 0;
            btnDeleteAccount.Text = "حذف اکانت";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            btnDeleteAccount.KeyDown += btnDeleteAccount_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(483, 121);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 1;
            label1.Text = ": رمز عبور را وارد کنید";
            // 
            // lblCaptcha
            // 
            lblCaptcha.AutoSize = true;
            lblCaptcha.Font = new Font("Segoe UI", 15F);
            lblCaptcha.Location = new Point(608, 184);
            lblCaptcha.Name = "lblCaptcha";
            lblCaptcha.Size = new Size(55, 28);
            lblCaptcha.TabIndex = 2;
            lblCaptcha.Text = ": کپچا";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(84, 121);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(221, 25);
            txtPassword.TabIndex = 3;
            // 
            // txtCaptcha
            // 
            txtCaptcha.Location = new Point(84, 193);
            txtCaptcha.Margin = new Padding(3, 2, 3, 2);
            txtCaptcha.Name = "txtCaptcha";
            txtCaptcha.Size = new Size(221, 25);
            txtCaptcha.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(471, 36);
            label2.Name = "label2";
            label2.Size = new Size(192, 28);
            label2.TabIndex = 5;
            label2.Text = ": نام کاربری را وارد کنید";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(84, 42);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(221, 25);
            txtUsername.TabIndex = 6;
            // 
            // DeleteAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(700, 383);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(txtCaptcha);
            Controls.Add(txtPassword);
            Controls.Add(lblCaptcha);
            Controls.Add(label1);
            Controls.Add(btnDeleteAccount);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DeleteAccountForm";
            Text = "DeleteAccountForm";
            Load += DeleteAccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteAccount;
        private Label label1;
        private Label lblCaptcha;
        private TextBox txtPassword;
        private TextBox txtCaptcha;
        private Label label2;
        private TextBox txtUsername;
    }
}