using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class DeleteAccountForm : Form
    {
        public string captchaCode;
        public string username; // فرض کنید کاربر لاگین شده نام کاربری خودش را وارد کرده

        public DeleteAccountForm()
        {
            InitializeComponent();
            this.username = username;
            GenerateNewCaptcha();

        }

        public void GenerateNewCaptcha()
        {
            captchaCode = CaptchaGenerator.GenerateCaptcha();
            lblCaptcha.Text = "کد کپچا: " + captchaCode;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; // نام کاربری وارد شده
            string password = txtPassword.Text; // رمز عبور وارد شده
            string enteredCaptcha = txtCaptcha.Text; // کپچای وارد شده

            // بررسی کد کپچا
            if (enteredCaptcha != captchaCode)
            {
                MessageBox.Show("کد کپچا اشتباه است. لطفاً دوباره تلاش کنید.");
                GenerateNewCaptcha(); // کپچا جدید تولید کن
                return;
            }

            // بررسی نام کاربری و رمز عبور
            if (UserManager.ValidateUser(username, password))
            {
                // حذف حساب کاربری
                UserManager.DeleteUser(username);
                MessageBox.Show("حساب کاربری با موفقیت حذف شد!");
                this.Close();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.");
            }
        }

        private void DeleteAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
    }
}
