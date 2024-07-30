using Gestion_Compte_Clients.Mes_Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Compte_Clients
{
    public partial class frmComptes : Form
    {
        public frmComptes()
        {
            InitializeComponent();
        }


        private int EnregistrerTransaction(Comptes comptes)
        {
            string connectionString = "Data Source=ANELKA-MD; Initial Catalog=Gestion_Compte_Clients; User ID=Anelka; Password=26355217; Encrypt=false";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Compte (Solde, DateCreation) VALUES (@Solde, @DateCreation)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Solde", comptes.Solde);
                        command.Parameters.AddWithValue("@DateCreation", comptes.DateCreation);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Erreur SQL: " + sqlEx.Message);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
                return -1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
