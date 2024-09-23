using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class RegisterForm : Form
    {



        public Form mainForm;
        public string captchaCode;
        public RegisterForm(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            GenerateNewCaptcha();
            txtPassword.PasswordChar = '*';
            // نمایش رمز عبور به صورت ستاره

        }
        public void GenerateNewCaptcha()
        {
            captchaCode = CaptchaGenerator.GenerateCaptcha();
            lblCaptcha.Text = "کد کپچا: " + captchaCode;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string enteredCaptcha = txtCaptcha.Text;

            // بررسی کد کپچا
            if (enteredCaptcha != captchaCode)
            {
                MessageBox.Show("کد کپچا اشتباه است. لطفاً دوباره تلاش کنید.");
                GenerateNewCaptcha();
                return;
            }

            // بررسی وجود کاربر
            if (UserManager.IsUserExist(username))
            {
                MessageBox.Show("این نام کاربری قبلاً ثبت شده است.");
                return;
            }

            // هش کردن رمز عبور
            string hashedPassword = PasswordHasher.HashPassword(password);

            // اضافه کردن کاربر جدید با رمز عبور هش شده
            UserManager.AddUser(username, hashedPassword);
            MessageBox.Show("ثبت‌نام با موفقیت انجام شد!");

            // بازگشت به فرم اصلی
            mainForm.Show();
            this.Close();
        }

        public void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void btnBack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

            }
        }
    }
}