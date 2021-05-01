using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //"Encoding.UTF8.GetBytes(password)" => verinin byte karşılığını almak istiyorsak
        //bu blok => verdiğimiz bir password değerinin salt ve hash değerini oluşturmaya yarıyor.
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())  //=> algoritma
            {
                passwordSalt = hmac.Key;  //her kullanıcı için bir key oluşturur. <algoritmanın DEĞİŞMEYEN anahtarı.>
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        //bu blok => sonradan sisteme girmek isteyen kişin girdiği parolanın veri kaynağımızda ki hashle(ilgili salta göre) eşleşme kontrolü.
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))  // passwordSalt => yukarıda ki key..
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
           
        }   
    }
}
