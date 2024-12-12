using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ContactProject
{
    public static class MD5Hash
    {
        public static string MD5Hashing(string text)
        {
            MD5 md5H = MD5.Create();

            byte[] data = md5H.ComputeHash(Encoding.UTF8.GetBytes(text));

            StringBuilder sB = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sB.Append(data[i].ToString("x2"));
            }

            return sB.ToString();
        }

    }
}
