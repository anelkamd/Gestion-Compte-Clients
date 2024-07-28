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
    public partial class FrmClients : Form
    {
        public FrmClients()
        {
            InitializeComponent();
        }

        Clients clients = new Clients();

        private void bindingClass(Clients clients)
        {
            //achat.IdAchat = int.Parse(txIdAchat.Text);
            clients.Nom = Convert.ToString(txtNom.Text);
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


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmClients_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clients clients = new Clients();

                bindingClass(clients);

                Clients ClientInstance = new Clients();

                int resultat = ClientInstance.EnregistrerClient(clients);
                if (resultat > 0)
                {
                    MessageBox.Show("Ajout Réussi");
                }
                else
                {
                    MessageBox.Show("L'ajout a échoué");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Un problème s'est produit, veuillez réessayer !!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Clients clients = new Clients();

                bindingClass(clients);

                Clients ClientInstance = new Clients();

                int resultat = ClientInstance.ModifierClient(clients);
                if (resultat > 0)
                {
                    MessageBox.Show("Modification Réussi");
                }
                else
                {
                    MessageBox.Show("La Modification a échoué");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Un problème s'est produit, veuillez réessayer !!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Clients clients = new Clients();

                bindingClass(clients);

                Clients ClientInstance = new Clients();

                int resultat = ClientInstance.SupprimerClient(clients);
                if (resultat > 0)
                {
                    MessageBox.Show("Suppression a Réussi");
                }
                else
                {
                    MessageBox.Show("La Suppression a échoué");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Un problème s'est produit, veuillez réessayer !!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Clients ClientInstance = new Clients();
                List<Clients> clients = ClientInstance.GetClients();
                dbClients.DataSource = null; // Réinitialiser la source de données
                dbClients.DataSource = clients; // Définir la nouvelle source de données
                dbClients.Refresh(); // Forcer le rafraîchissement de la DataGrid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de Chargement Article : " + ex.Message);
            }
        }
    }
}
