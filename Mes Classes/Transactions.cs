using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Gestion_Compte_Clients.Mes_Classes
{
    public class Transactions
    {
        public int TransactionID { get; set; }
        public int CompteID { get; set; }
        public string TypeTransaction { get; set; } // 'Depot' ou 'Retrait'
        public decimal Montant { get; set; }
        public DateTime DateTransaction { get; set; } = DateTime.Now;

        public Transactions() { }

        public Transactions(int compteID, string typeTransaction, decimal montant)
        {
            CompteID = compteID;
            TypeTransaction = typeTransaction;
            Montant = montant;
        }

        private DataAccess data = new DataAccess();

        public int EnregistrerTransaction(Transactions transactions)
        {
            int resultat = 0;
            string strQuery = "INSERT INTO Transactions ( CompteID, Montant, TypeTransaction) VALUES ( @CompteID, @Montant, @TypeTransaction)";

            if (data.OpenConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(strQuery, data.conn))
                    {

                        cmd.Parameters.AddWithValue("@CompteID", transactions.CompteID);
                        cmd.Parameters.AddWithValue("@Montant", transactions.Montant);
                        cmd.Parameters.AddWithValue("@TypeTransaction", transactions.TypeTransaction);

                        resultat = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la Transaction : {ex.Message}");
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
