using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace test2
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // تبدیل رشته رمز عبور به بایت
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // تبدیل بایت‌ها به رشته (هگزادسیمال)
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString(); // رشته هش شده
            }
        }
    }
}
