using Lab_05.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_05.Models
{
    public class Verifier
    {
        public string RandomString()
        {
            Random rnd = new Random();
            byte[] B = new byte[10];
            for (int i = 0; i < B.Length; i++)
            {
                int temp = rnd.Next(61);
                if (temp < 10)
                    temp += 48;
                else if (temp < 36)
                    temp += 55;
                else
                    temp += 61;

                B[i] = Convert.ToByte(temp);
            }
            return Encoding.ASCII.GetString(B);
        }
        public byte[] createSalt()
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }
        public string createHash(string password, byte[] salt)
        {
            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            return hashed;
        }
    }
}
