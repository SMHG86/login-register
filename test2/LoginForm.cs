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
    public partial class LoginForm : Form
    {
        public Form mainform;
        public LoginForm(Form mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            txtPassword.PasswordChar = '*';
            // نمایش رمز عبور به صورت ستاره

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // بررسی صحت اطلاعات کاربر
            if (UserManager.ValidateUser(username, password))
            {
                MessageBox.Show("ورود با موفقیت انجام شد!");

                // مقداردهی currentLoggedInUser با کاربر لاگین‌شده
                UserManager.currentLoggedInUser = UserManager.Users.FirstOrDefault(u => u.Username == username);


                // نمایش گزینه پروفایل در فرم اصلی
                /*  if (mainform is Form1 form1)
                  {
                      form1.ShowProfileOption();
                  }*/

                // بازگشت به فرم اصلی
                this.Hide();
                mainform.Show();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.");
            }
            if (mainform is Form1 form1)
            {
                form1.ShowProfileOption();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform.Show();
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
    }
}