using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_03.Models
{
    public class Verifier
    {
        public bool Verification(HttpContext HttpContext, workouthunterContext DbContext)
        {
            string userID = HttpContext.Session.GetString("userUID");
            var query = from o in DbContext.UserInfos
                        where o.Uid == userID
                        select o;
            return query.FirstOrDefault() != null;

        }
        public bool SignIn(HttpContext HttpContext, workouthunterContext DbContext, string userID, string userPassword)
        {
            // 確認格式
            if (!(matchEmail(userID) && matchPassword(userPassword)))
                return false;
            // SQL資料，確認是否有這個Email
            var query = from o in DbContext.UserInfos
                        where o.Email == userID
                        select o;

            var userInfo = query.FirstOrDefault();
            if (userInfo == null)
                return false;
            // Hash
            string salt = userInfo.salt;
            string hash = createHash(userPassword, Convert.FromBase64String(salt));

            // 比對
            if(hash == userInfo.PassWord)
            {
                HttpContext.Session.SetString("userUID", userInfo.Uid);
                return true;
            }
            else return false;
        }
        public bool register(string userID, string userPassword, workouthunterContext DbContext)
        {
            // 確認格式
            if (!(matchEmail(userID) && matchPassword(userPassword)))
                return false;
            // SQL資料，確認是否有這個Email
            var query = from o in DbContext.UserInfos
                        where o.Email == userID
                        select o;

            // 帳號重複
            if (query.FirstOrDefault() != null)
                return false;
            // Hash
            string salt = Convert.ToBase64String(createSalt());
            string hashPassword = createHash(userPassword, Convert.FromBase64String(salt));
            string randomUID = RandomString();

            // 帳號沒有重複
            UserInfo user = new UserInfo()
            {
                Uid = randomUID,
                Email = userID,
                PassWord = hashPassword,
                Class = "N",
                Role = "S",
                SignDate = DateTime.Now,
                salt = salt
            };
            DbContext.UserInfos.Add(user);
            DbContext.SaveChanges();
            return true;

        }

        static bool matchEmail(string s)
        {
            if (s == null)
                return false;
            Regex X = new Regex(".+@gmail.com");
            return X.IsMatch(s);
        }
        static bool matchPassword(string s)
        {
            if (s == null)
                return false;
            Regex Y = new Regex("\\s");
            return !Y.IsMatch(s);
        }
        private string RandomString()
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
        private byte[] createSalt()
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }
        private string createHash(string password, byte[] salt)
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
