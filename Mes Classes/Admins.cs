using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Compte_Clients.Mes_Classes
{
    internal class Admins
    {
        public int AdminID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }

        public Admins(int adminID, string username, string passwordHash, string email)
        {
            AdminID = adminID;
            Username = username;
            PasswordHash = passwordHash;
            Email = email;
            CreatedAt = DateTime.Now;
        }

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        public bool VerifyPassword(string password)
        {
            // Compare le mot de passe haché stocké avec le hachage du mot de passe entré
            string passwordHash = HashPassword(password);
            return PasswordHash == passwordHash;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"AdminID: {AdminID}");
            Console.WriteLine($"Username: {Username}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"CreatedAt: {CreatedAt}");
        }


    }
}
