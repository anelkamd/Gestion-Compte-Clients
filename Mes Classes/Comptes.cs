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
    }

}
