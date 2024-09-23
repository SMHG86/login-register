using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public static class CaptchaGenerator
    {
        private static Random random = new Random();

        public static string GenerateCaptcha()
        {
            return random.Next(1000, 9999).ToString();
        }
    }
}
