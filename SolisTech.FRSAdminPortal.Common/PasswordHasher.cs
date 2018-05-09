using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace SolisTech.FRSAdminPortal.Common
{
    public class PasswordHasher
    {
        //public string GenerateHash(string password)
        //{
        //    UnicodeEncoding ue = new UnicodeEncoding();
        //    var ByteSourceText = ue.GetBytes(password);
        //    var md5 = new MD5CryptoServiceProvider();
        //    var ByteHash = md5.ComputeHash(ByteSourceText);
        //    var tmp = Convert.ToBase64String(ByteHash);

        //}

        public static string GenerateHash(string SourceText)
        {
            UnicodeEncoding Ue = new UnicodeEncoding();
            byte[] ByteSourceText = Ue.GetBytes(SourceText);
            MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();
            byte[] ByteHash = Md5.ComputeHash(ByteSourceText);
            string tmp = Convert.ToBase64String(ByteHash);
            int x = 0;
            var aStringBuilder = tmp.ToArray();
            for (x = 1; x <= tmp.Length; x++)
            {
                if (Strings.Asc(Strings.Mid(tmp, x, 1)) < 48 | (Strings.Asc(Strings.Mid(tmp, x, 1)) > 57 & Strings.Asc(Strings.Mid(tmp, x, 1)) < 65) | (Strings.Asc(Strings.Mid(tmp, x, 1)) > 90 & Strings.Asc(Strings.Mid(tmp, x, 1)) < 97) | Strings.Asc(Strings.Mid(tmp, x, 1)) > 122)
                {
                    //Strings.Mid(tmp, x, 1);
                    aStringBuilder[x - 1] = 'x';
                }
            }

            return string.Join("", aStringBuilder);
        }
    }
}
