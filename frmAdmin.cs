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
            admins.Username = Convert.ToString(txtUser.Text);
            admins.PasswordHash = Convert.ToString(txtPassword.Text);
            admins.Email = Convert.ToString(txtEmail.Text);
            admins.CreatedAt = dtAjoutAdmin.Value;
        }

        private void EnregistrerAdmin(Admins admins)
        {
            string connectionString = "Votre_chaine_de_connexion";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Admins ( Username, PasswordHash, Email, CreateAt) VALUES ( @Username, @PasswordHash, @Email, @CreatedAt)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Username", admins.Username);
                command.Parameters.AddWithValue("@Prenom", admins.PasswordHash);
                command.Parameters.AddWithValue("@Adresse", admins.Email);
                command.Parameters.AddWithValue("@Telephone", admins.CreatedAt);

                connection.Open();
                command.ExecuteNonQuery();

            }

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Admins admins = new Admins();

                bindingClass(admins);

                Admins AdminInstance = new Admins();

                int resultat = AdminInstance.EnregistrerAdmin(admins);
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
    }
}
