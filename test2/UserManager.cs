using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace test2
{
    class UserManager
    {
        // لیست کاربران
        public static List<User> Users = new List<User>();

        public static User currentLoggedInUser;

        // متد برای اضافه کردن کاربر جدید
        public static void AddUser(string username, string password)
        {
            Users.Add(new User { Username = username, Password = password });
            // در حال حاضر رمز عبور هش شده به عنوان پارامتر به متد ارسال می‌شود

        }

        // متد برای بررسی وجود کاربر با نام کاربری مشابه
        public static bool IsUserExist(string username)
        {
            return Users.Any(u => u.Username == username);
        }

        // متد برای اعتبارسنجی کاربر
        public static bool ValidateUser(string username, string password)
        {
            // هش کردن رمز عبور ورودی کاربر
            string hashedPassword = PasswordHasher.HashPassword(password);

            // بررسی اینکه آیا کاربری با نام کاربری و رمز عبور هش شده وجود دارد
            return Users.Any(u => u.Username == username && u.Password == hashedPassword);
        }

        public static void DeleteUser(string username)
        {
            var userToRemove = Users.FirstOrDefault(u => u.Username == username);
            if (userToRemove != null )
            {
                Users.Remove(userToRemove);
            }
        }
    }
}

