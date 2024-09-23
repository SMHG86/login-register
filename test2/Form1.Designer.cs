namespace test2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnRegister = new Button();
            btnExit = new Button();
            menuStrip1 = new MenuStrip();
            profileToolStripMenuItem = new ToolStripMenuItem();
            changeUsernameToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            updateProfileToolStripMenuItem = new ToolStripMenuItem();
            حذفحسابکاربریToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 15F);
            btnLogin.Location = new Point(279, 69);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(142, 75);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "ورود";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.KeyDown += btnLogin_KeyDown;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 15F);
            btnRegister.Location = new Point(279, 161);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(142, 84);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "ثبت نام";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            btnRegister.KeyDown += btnRegister_KeyDown;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 15F);
            btnExit.Location = new Point(280, 260);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(142, 77);
            btnExit.TabIndex = 2;
            btnExit.Text = "خروج";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            btnExit.KeyDown += btnExit_KeyDown;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeUsernameToolStripMenuItem, changePasswordToolStripMenuItem, updateProfileToolStripMenuItem, حذفحسابکاربریToolStripMenuItem });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(88, 20);
            profileToolStripMenuItem.Text = "پروفایل کاربری";
            // 
            // changeUsernameToolStripMenuItem
            // 
            changeUsernameToolStripMenuItem.Name = "changeUsernameToolStripMenuItem";
            changeUsernameToolStripMenuItem.Size = new Size(181, 22);
            changeUsernameToolStripMenuItem.Text = "تغییر یوزر نیم";
            changeUsernameToolStripMenuItem.Click += changeUsernameToolStripMenuItem_Click_1;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(181, 22);
            changePasswordToolStripMenuItem.Text = "تغییر رمز عبور";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click_1;
            // 
            // updateProfileToolStripMenuItem
            // 
            updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            updateProfileToolStripMenuItem.Size = new Size(181, 22);
            updateProfileToolStripMenuItem.Text = "تغییر اطلاعات شخصی";
            updateProfileToolStripMenuItem.Click += updateProfileToolStripMenuItem_Click_1;
            // 
            // حذفحسابکاربریToolStripMenuItem
            // 
            حذفحسابکاربریToolStripMenuItem.Name = "حذفحسابکاربریToolStripMenuItem";
            حذفحسابکاربریToolStripMenuItem.Size = new Size(181, 22);
            حذفحسابکاربریToolStripMenuItem.Text = "حذف حساب کاربری";
            حذفحسابکاربریToolStripMenuItem.Click += حذفحسابکاربریToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(700, 383);
            Controls.Add(btnExit);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "صفحه اصلی";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnRegister;
        private Button btnExit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem changeUsernameToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem updateProfileToolStripMenuItem;
        private ToolStripMenuItem حذفحسابکاربریToolStripMenuItem;
    }
}
