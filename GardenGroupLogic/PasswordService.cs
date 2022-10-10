using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using GardenGroupModel;
using System.Configuration;

namespace GardenGroupLogic
{
    public class PasswordService
    {
        // hash the password
        public string GenerateSaltedHash(string password)
        {
            // generate to byte array
            byte[] saltBytes = Convert.FromBase64String(ConfigurationManager.AppSettings["salt"]);            

            // hashing algoritm
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 50);
            string hashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

            // save and return as password
            return hashPassword;
        }

        // verify the givin password
        public bool VerifyPassword(string enteredPassword, string password)
        {
            // save salt as byte
            byte[] saltBytes = Convert.FromBase64String(ConfigurationManager.AppSettings["salt"]);

            // hash algortime
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltBytes, 50);

            // check if the hash from algoritme above is the samen as the storedhash
            return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == password;
        }        
    }
}
