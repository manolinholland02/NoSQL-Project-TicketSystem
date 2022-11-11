using Model;
using System.Security.Cryptography;


namespace Logic
{
    public class HashTool
    {
        //is used to hash a passsword
        public HashWithSaltResult HashPassword(string password)
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            HashWithSaltResult hashResultSha256 = pwHasher.HashWithSalt(password, 64, SHA256.Create());

            return hashResultSha256;
        }

        public HashWithSaltResult HashPassword(string password, string salt)
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            HashWithSaltResult hashResultSha256 = pwHasher.Hash(password, SHA256.Create(), salt);

            return hashResultSha256;
        }
    }
}
