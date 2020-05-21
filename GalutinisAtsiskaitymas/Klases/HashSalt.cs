using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GalutinisAtsiskaitymas
{
    public class HashSalt
    {
        public string Hash { get; set; }
        public string Salt { get; set; }

        public static HashSalt GenerateSaltedHash(int size, string password)
        {
            var saltbytes = new byte[size];
            var provider = new RNGCryptoServiceProvider();
            provider.GetNonZeroBytes(saltbytes);
            var salt = Convert.ToBase64String(saltbytes);

            var pbkdf2 = new Rfc2898DeriveBytes(password, saltbytes, 1000);
            var hash = Convert.ToBase64String(pbkdf2.GetBytes(256));

            HashSalt hashSalt = new HashSalt { Hash = hash, Salt = salt };
            return hashSalt;
        }
    }
}
