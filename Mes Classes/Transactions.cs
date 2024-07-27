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
    }

}
