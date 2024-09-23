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
    public partial class ChangeUsernameForm : Form
    {
        public ChangeUsernameForm()
        {
            InitializeComponent();
        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            string newUsername = txtNewUsername.Text;

            // یافتن کاربر فعلی از لیست کاربران
            var currentUser = UserManager.Users.FirstOrDefault(u => u.Username == UserManager.currentLoggedInUser.Username);

            // بررسی اینکه کاربر جدید وجود نداشته باشد
            if (UserManager.IsUserExist(newUsername))
            {
                MessageBox.Show("این نام کاربری قبلاً وجود دارد.");
                return;
            }

            // تغییر نام کاربری
            if (currentUser != null)
            {
                currentUser.Username = newUsername;
                MessageBox.Show("نام کاربری با موفقیت تغییر کرد!");
                this.Close();
            }
            else
            {
                MessageBox.Show("کاربر پیدا نشد.");
            }
        }

        private void btnChangeUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
    }
}
