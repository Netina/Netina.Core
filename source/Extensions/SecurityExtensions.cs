using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Netina.Core.Extensions
{
    public static class SecurityExtensions
    {
        public static string GetSha256Hash(string input)
        {
            //using (var sha256 = new SHA256CryptoServiceProvider())
            var provider = HashAlgorithm.Create("SHA256Managed");
            using (var sha256 = provider)
            {
                var byteValue = Encoding.UTF8.GetBytes(input);
                var byteHash = sha256.ComputeHash(byteValue);
                return Convert.ToBase64String(byteHash);
                //return BitConverter.ToString(byteHash).Replace("-", "").ToLower();
            }
        }
    }
}
