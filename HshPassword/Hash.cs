using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HshPassword
{
    public class Hash
    {
        public static string HashPswd(string Password)
        {
            using (SHA256 sha256Hash = SHA256.Create()) 
            {
                byte[] sourseBytePassw = Encoding.UTF8.GetBytes(Password);
                byte[] hashSourceBytePassw = sha256Hash.ComputeHash(sourseBytePassw);
                string hashPassw = BitConverter.ToString(hashSourceBytePassw).Replace("-", String.Empty);
                return hashPassw;
            }
        }
    }
}
