using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Gestion_Compte_Clients.Mes_Classes
{
    public class Clients
    {
        public int ClientID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }

        public Clients() { }

        public Clients(string nom, string prenom, string adresse, string telephone)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Telephone = telephone;
        }

        private DataAccess data = new DataAccess();

        
    }

}
