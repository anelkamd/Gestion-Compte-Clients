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

        public int EnregistrerClient(Clients clients)
        {
            int resultat = 0;
            string strQuery = "INSERT INTO Clients ( Nom, Prenom, Adresse, Telephone) VALUES ( @Nom, @Prenom, @Adresse, @Telephone)";

            if (data.OpenConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(strQuery, data.conn))
                    {

                        cmd.Parameters.AddWithValue("@Nom", clients.Nom);
                        cmd.Parameters.AddWithValue("@Prenom", clients.Prenom);
                        cmd.Parameters.AddWithValue("@Adresse", clients.Adresse);
                        cmd.Parameters.AddWithValue("@Telephone", clients.Telephone);
                        if (clients != null)
                        {
                            MessageBox.Show("Veillez completer toutes les element demander Svp !!");
                        }
                        else
                        {
                            resultat = cmd.ExecuteNonQuery();
                        }  
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'Enregistrement : {ex.Message}");
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

        public int ModifierClient(Clients clients)
        {
            int resultat = 0;
            string strQuery = "update Clients set Nom=@Nom, Prenom=@Prenom, Adresse=@Adresse, Telephone=@Telephone ";

            if (data.OpenConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(strQuery, data.conn))
                    {

                        cmd.Parameters.AddWithValue("@Nom", clients.Nom);
                        cmd.Parameters.AddWithValue("@Prenom", clients.Prenom);
                        cmd.Parameters.AddWithValue("@Adresse", clients.Adresse);
                        cmd.Parameters.AddWithValue("@Telephone", clients.Telephone);

                        if (clients != null)
                        {
                            MessageBox.Show("Veillez completer toutes les element demander Svp !!");
                        }
                        else
                        {
                            resultat = cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la Modification : {ex.Message}");
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

        public int SupprimerClient(Clients clients)
        {
            int resultat = 0;
            string strQuery = "delete Achats where Nom=@Nom , Prenom=@Prenom";

            if (data.OpenConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(strQuery, data.conn))
                    {

                        cmd.Parameters.AddWithValue("@Nom", clients.Nom);
                        cmd.Parameters.AddWithValue("@Prenom", clients.Prenom);
                        cmd.Parameters.AddWithValue("@Adresse", clients.Adresse);
                        cmd.Parameters.AddWithValue("@Telephone", clients.Telephone);

                        if (clients != null)
                        {
                            MessageBox.Show("Veillez completer toutes les element demander Svp !!");
                        }
                        else
                        {
                            resultat = cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'insertion de l'Enregistrement : {ex.Message}");
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
