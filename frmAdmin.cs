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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        Admins admins = new Admins();

        private void bindingClass(Admins admins)
        {
            admins. = Convert.ToString(txtNom.Text);
            clients.Prenom = Convert.ToString(txtPrenom.Text);
            clients.Adresse = Convert.ToString(txtAdresse.Text);
            clients.Telephone = Convert.ToString(txtTelephone.Text);
        }

        private void EnregistrerClient(Clients clients)
        {
            string connectionString = "Votre_chaine_de_connexion";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Clients ( Nom, Prenom, Adresse, Telephone) VALUES ( @Nom, @Prenom, @Adresse, @Telephone)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Nom", clients.Nom);
                command.Parameters.AddWithValue("@Prenom", clients.Prenom);
                command.Parameters.AddWithValue("@Adresse", clients.Adresse);
                command.Parameters.AddWithValue("@Telephone", clients.Telephone);

                connection.Open();
                command.ExecuteNonQuery();

            }

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
