using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using GardenGroupModel;

namespace GardenGroupLogic
{
    public class PasswordService
    {
        // hash the password
        public Password GenerateSaltedHash(int size, string password)
        {
            // amount of memory for salt
            byte[] saltBytes = new byte[size];

            // encryption service
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();

            // fill an array with non zero values (salt)
            provider.GetNonZeroBytes(saltBytes);

            // save as string
            string salt = Convert.ToBase64String(saltBytes);

            // hashing algoritm
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 50);
            string hashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

            // save and return as password
            return new Password
            {
                Hash = hashPassword,
                Salt = salt
            };
        }

        // verify the givin password
        public bool VerifyPassword(string enteredPassword, Password password)
        {
            // save salt as byte
            byte[] saltBytes = Convert.FromBase64String(password.Salt);

            // hash algortime
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 50);

            // check if the hash from algoritme above is the samen as the storedhash
            return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == password.Hash;
        }        
    }
}
