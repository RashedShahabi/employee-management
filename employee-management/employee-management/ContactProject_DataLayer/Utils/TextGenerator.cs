using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ContactProject_DataLayer.Utils
{
    public static class TextGenerator
    {
        public static string GetRandomString(int length=10)
        {
            var chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
                Thread.Sleep(2);
            }

            return new string(stringChars);
        }
    }
}
