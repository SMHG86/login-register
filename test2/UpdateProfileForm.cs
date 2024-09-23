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
    public partial class UpdateProfileForm : Form
    {
        public UpdateProfileForm()
        {
            InitializeComponent();
           // txtNationalId.Text; = nationalId;
        }



        private void UpdateProfileForm_Load(object sender, EventArgs e)
        {


        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            string nationalId = txtNationalId.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string fullName = txtFullName.Text;
            // اعمال تغییرات در پروفایل کاربر
            // اضافه کردن کد برای به‌روزرسانی اطلاعات پروفایل
            MessageBox.Show("اطلاعات پروفایل با موفقیت تغییر کرد!");
            this.Close();
        }

        private void btnChangeUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
    }
}
