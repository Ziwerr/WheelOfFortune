using System;
using System.Linq;

namespace Koło_Fortuny_v1
{
    public class Generate
    {
        public static string GenerateWord()
        {
            PasswordsEntities passwordsEntities = new PasswordsEntities();
            var query = passwordsEntities.Passwords.OrderBy(x => Guid.NewGuid()).FirstOrDefault().Haslo;
            return query;
        }

        public static string GenerateCategory(string word)
        {
            PasswordsEntities passwordsEntities = new PasswordsEntities();
            var query = passwordsEntities.Passwords.Where(x => x.Haslo == word).FirstOrDefault().Kategoria;
            return query;
        }
    }
    
}
