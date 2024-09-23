using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace test2
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;

            // تغییر رمز عبور برای کاربر لاگین‌شده
            if (UserManager.currentLoggedInUser != null)
            {
                // هش کردن رمز عبور جدید
                // string newHashedPassword = UserManager.HashPassword(newPassword, UserManager.currentLoggedInUser.Salt);

                UserManager.currentLoggedInUser.Password = newPassword;
                MessageBox.Show("رمز عبور با موفقیت تغییر کرد!");
                this.Close();
            }
            else
            {
                MessageBox.Show("کاربر لاگین‌شده پیدا نشد.");
            }
        }

        private void ChangePasswordForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
    }
}
