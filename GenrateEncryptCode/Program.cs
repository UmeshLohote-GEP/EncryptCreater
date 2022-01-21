using Gep.Cumulus.Encryption;
using System;

namespace GenrateEncryptCode
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.Write("Encryption Started\n");
            string username = "";
            string password = "";
            string bpcCode = "";
            string partnerCode = "";
            Console.Write("User Name: ");
            username = Console.ReadLine();
            username = SecurityEncryptionUtility.AESEncrypt(username != null && username.Length > 0
              ? username
              : "click.admin@gep.com");
            Console.WriteLine(username);
            Console.Write("Password: ");
            password = Console.ReadLine();
            password = SecurityEncryptionUtility.AESEncrypt(password != null && password.Length > 0
               ? password
               : "MZa8!TRjE(S");
            Console.WriteLine(password);
            Console.Write("BPC: ");
            bpcCode = Console.ReadLine();
            bpcCode = SecurityEncryptionUtility.AESEncrypt(bpcCode != null && bpcCode.Length > 0
                ? bpcCode
                : "70021939");
            Console.WriteLine(bpcCode);
            Console.Write("Partner Code: ");
            partnerCode = Console.ReadLine();
            partnerCode =
               SecurityEncryptionUtility.AESEncrypt(partnerCode != null && partnerCode.Length > 0
                   ? partnerCode
                   : "0");
            Console.WriteLine(partnerCode);
            Console.Write("Encryption completed\n");
            Console.ReadKey(true);
        }
    }
}
