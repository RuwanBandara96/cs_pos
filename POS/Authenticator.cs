using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace POS
{
    class Authenticator
    {
        private String EncryptString(String plainText)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedbytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                return BitConverter.ToString(hashedbytes).Replace("-", "").ToLower();
            }
        }


    }
}
