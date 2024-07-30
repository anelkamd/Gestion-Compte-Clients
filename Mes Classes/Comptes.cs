using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Gestion_Compte_Clients.Mes_Classes
{
    public class Comptes
    {
        public int CompteID { get; set; }
        public int ClientID { get; set; }
        public decimal Solde { get; set; }
        public DateTime DateCreation { get; set; } = DateTime.Now;

        public Comptes() { }

        public Comptes(int clientID, decimal solde)
        {
            ClientID = clientID;
            Solde = solde;
        }

        private DataAccess data = new DataAccess();

        public int EnregistrerTransaction(Comptes comptes)
        {
            int resultat = 0;
            string strQuery = "INSERT INTO Comptes ( ClientID, Solde) VALUES ( @ClientID, @Solde)";

            if (data.OpenConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(strQuery, data.conn))
                    {
                        cmd.Parameters.AddWithValue("@ClientID", comptes.ClientID);
                        cmd.Parameters.AddWithValue("@Solde", comptes.Solde);

                        resultat = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la creation du compte : {ex.Message}");
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
