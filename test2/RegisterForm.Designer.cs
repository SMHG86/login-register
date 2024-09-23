namespace test2
{
    partial class RegisterForm
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnBack = new Button();
            lblCaptcha = new Label();
            txtCaptcha = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(312, 291);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(127, 78);
            button1.TabIndex = 0;
            button1.Text = "ثبت نام";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.KeyDown += button1_KeyDown;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(71, 48);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(263, 25);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(71, 138);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(263, 25);
            txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Violet;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(481, 48);
            label1.Name = "label1";
            label1.Size = new Size(125, 30);
            label1.TabIndex = 3;
            label1.Text = " : نام کاربری ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Violet;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(507, 131);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 4;
            label2.Text = ": رمز عبور";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F);
            btnBack.Location = new Point(179, 307);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 44);
            btnBack.TabIndex = 5;
            btnBack.Text = "برگشت";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            btnBack.KeyDown += btnBack_KeyDown;
            // 
            // lblCaptcha
            // 
            lblCaptcha.AutoSize = true;
            lblCaptcha.Font = new Font("Segoe UI", 16F);
            lblCaptcha.Location = new Point(471, 211);
            lblCaptcha.Name = "lblCaptcha";
            lblCaptcha.Size = new Size(67, 30);
            lblCaptcha.TabIndex = 7;
            lblCaptcha.Text = ": کپچا ";
            // 
            // txtCaptcha
            // 
            txtCaptcha.Location = new Point(71, 218);
            txtCaptcha.Margin = new Padding(3, 2, 3, 2);
            txtCaptcha.Name = "txtCaptcha";
            txtCaptcha.Size = new Size(263, 25);
            txtCaptcha.TabIndex = 8;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(700, 383);
            Controls.Add(txtCaptcha);
            Controls.Add(lblCaptcha);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فرم ثبت نام";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnBack;
        private Label lblCaptcha;
        private TextBox txtCaptcha;
    }
}