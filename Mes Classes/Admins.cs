using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Gestion_Compte_Clients.Mes_Classes
{
    internal class Admins
    {
        public int AdminID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }

        public Admins() { }

        private DataAccess data = new DataAccess();

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
            // Compare le mot de passe haché stocké avec le hachage du mot de passe entrée
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

        public int EnregistrerAdmin(Admins admins)
        {
            int resultat = 0;
            string strQuery = "INSERT INTO Admin ( Username, PasswordHash, Email, CreatedAt) VALUES ( @Username, @PasswordHash, @Email, @CreatedAt)";

            if (data.OpenConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(strQuery, data.conn))
                    {

                        cmd.Parameters.AddWithValue("@Username", admins.Username);
                        cmd.Parameters.AddWithValue("@PasswordHash", admins.PasswordHash);
                        cmd.Parameters.AddWithValue("@Email", admins.Email);
                        cmd.Parameters.AddWithValue("@CreatedAt", admins.CreatedAt);

                        resultat = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'Enregistrement : {ex.Message}");
                }
                finally
                {
                    data.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Impossible d'ouvrir la connexion à la base de données.");
            }

            return resultat;
        }
    }
}
