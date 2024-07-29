using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Gestion_Compte_Clients.Mes_Classes
{
    internal class DataAccess
    {
        public SqlConnection conn = null;

        String connectionString = "Data Source=ANELKA-MD; Initial Catalog=Gestion_Compte_Clients; User ID=Anelka; Password=26355217; Encrypt=false";
        public bool OpenConnection()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }


    }
}
