namespace test2
{
    partial class ChangePasswordForm
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
            btnChangePassword = new Button();
            txtNewPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(471, 120);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 0;
            label1.Text = ": رمز عبور جدید";
            // 
            // btnChangePassword
            // 
            btnChangePassword.Font = new Font("Segoe UI", 12F);
            btnChangePassword.Location = new Point(283, 240);
            btnChangePassword.Margin = new Padding(3, 2, 3, 2);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(122, 55);
            btnChangePassword.TabIndex = 1;
            btnChangePassword.Text = "اعمال تغییرات";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(82, 125);
            txtNewPassword.Margin = new Padding(3, 2, 3, 2);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(242, 23);
            txtNewPassword.TabIndex = 2;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(700, 338);
            Controls.Add(txtNewPassword);
            Controls.Add(btnChangePassword);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            KeyDown += ChangePasswordForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnChangePassword;
        private TextBox txtNewPassword;
    }
}