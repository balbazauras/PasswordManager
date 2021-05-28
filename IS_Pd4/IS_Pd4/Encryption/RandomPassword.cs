using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IS_Pd4
{
    static class RandomPassword
    {
        public static string GeneratePassword()
        {
            RandomNumberGenerator randomNumberGenerator = RNGCryptoServiceProvider.Create();
            byte[] data = new byte[128];
            randomNumberGenerator.GetBytes(data);
            return Convert.ToBase64String(data);
        }
    }
}
