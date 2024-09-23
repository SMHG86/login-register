namespace test2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            profileToolStripMenuItem.Visible = false;

        }

        public void ShowProfileOption()
        {
            // نمایش گزینه پروفایل بعد از ورود موفق
            profileToolStripMenuItem.Visible = true;
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(this);

            loginForm.Show();
        }

        public void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm(this);
            registerForm.Show();
        }

        public void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ShowProfileOption1()
        {
            // نمایش گزینه پروفایل
            profileToolStripMenuItem.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void changeUsernameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // باز کردن فرم تغییر یوزرنیم
            var changeUsernameForm = new ChangeUsernameForm();
            changeUsernameForm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // باز کردن فرم تغییر رمز عبور
            var changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ShowDialog();
        }

        private void updateProfileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // باز کردن فرم تغییر اطلاعات پروفایل
            var updateProfileForm = new UpdateProfileForm();
            updateProfileForm.ShowDialog();
        }

        private void حذفحسابکاربریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // باز کردن فرم دیلیت اکانت
            var deleteaccountform = new DeleteAccountForm();
            deleteaccountform.ShowDialog();
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void btnRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void btnExit_KeyDown(object sender, KeyEventArgs e)
        {
           /* if (e.KeyCode == Keys.Escape)
            {

            }*/
        }
    }
}
