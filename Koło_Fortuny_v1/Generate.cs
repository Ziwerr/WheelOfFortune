using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koło_Fortuny_v1
{
    public class Generate
    {

        //public Password GenerateWord(List<Password> passwords)
        //{
        //    PasswordsEntities passwordsEntities = new PasswordsEntities();
        //    var query = passwordsEntities.Passwords.OrderBy(x => Guid.NewGuid()).Take(1).Single();
        //    return query;
        //}

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

        //public static void Remove(List<Password> passwords, Password pass)
        //{
        //    passwords.Remove(pass);
        //}

        //public List<Password> GetAllPasswords()
        //{
        //    PasswordsEntities passwordsEntities = new PasswordsEntities();
        //    return passwordsEntities.Passwords.ToList();
        //}
        //public static void RemovePassword(List<Password> pass, Password password)
        //{
        //    PasswordsEntities passwordsEntities = new PasswordsEntities();
        //    passwordsEntities.Passwords.Remove(password);
        //}
    }
    
}
