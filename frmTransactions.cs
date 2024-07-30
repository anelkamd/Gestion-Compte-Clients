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
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
            rbDepot.CheckedChanged += new EventHandler(rbDepot_CheckedChanged);
            rbRetrait.CheckedChanged += new EventHandler(rbRetrait_CheckedChanged);
        }

        private void bindingClass(Transactions transactions, string typeTransaction)
        {
            try 
            {
                transactions.Montant = Convert.ToDecimal(txtMontant.Text);
                transactions.CompteID = Convert.ToInt32(txtNumClient.Text);
                transactions.DateTransaction = dtTransaction.Value;
                transactions.TypeTransaction = typeTransaction;
            }
            catch
            {
                MessageBox.Show("Veillez remplire le formulaire svp");
            }
        }

        private void rbDepot_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDepot.Checked)
            {
                Transactions transaction = new Transactions();
                bindingClass(transaction, "Depot");
                EnregistrerTransaction(transaction);
            }
        }

        private void rbRetrait_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRetrait.Checked)
            {
                Transactions transaction = new Transactions();
                bindingClass(transaction, "Retrait");
                EnregistrerTransaction(transaction);
            }
        }

        private int EnregistrerTransaction(Transactions transaction)
        {
            string connectionString = "Data Source=ANELKA-MD; Initial Catalog=Gestion_Compte_Clients; User ID=Anelka; Password=26355217; Encrypt=false";

            try
            {
                // Vérifier que le type de transaction est valide
                if (transaction.TypeTransaction != "Dépot" && transaction.TypeTransaction != "Retrait")
                {
                    throw new ArgumentException("TypeTransaction doit être 'Dépot' ou 'Retrait'");
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Transactions (CompteID, TypeTransaction, Montant, DateTransaction) VALUES (@CompteID, @TypeTransaction, @Montant, @DateTransaction)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CompteID", transaction.CompteID);
                        command.Parameters.AddWithValue("@TypeTransaction", transaction.TypeTransaction);
                        command.Parameters.AddWithValue("@Montant", transaction.Montant);
                        command.Parameters.AddWithValue("@DateTransaction", transaction.DateTransaction);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Erreur SQL: " + sqlEx.Message, "Erreur SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show("Erreur de validation: " + argEx.Message, "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer les valeurs des contrôles
                decimal montant = Convert.ToDecimal(txtMontant.Text);
                int compteID = Convert.ToInt32(txtNumClient.Text);
                DateTime dateTransaction = dtTransaction.Value;
                string typeTransaction = rbDepot.Checked ? "Dépot" : "Retrait";

                // Chaîne de connexion à la base de données
                string connectionString = "Data Source=ANELKA-MD; Initial Catalog=Gestion_Compte_Clients; User ID=Anelka; Password=26355217; Encrypt=false";

                // Requête SQL pour insérer une transaction
                string queryTransaction = "INSERT INTO Transactions (CompteID,TypeTransaction, Montant, DateTransaction) " +
                                          "VALUES (@CompteID,@TypeTransaction, @Montant, @DateTransaction)";

                // Requête SQL pour mettre à jour le solde du compte
                string queryUpdateSolde;
                if (typeTransaction == "Dépot")
                {
                    queryUpdateSolde = "UPDATE Comptes SET Solde = Solde + @Montant WHERE CompteID = @CompteID";
                }
                else
                {
                    queryUpdateSolde = "UPDATE Comptes SET Solde = Solde - @Montant WHERE CompteID = @CompteID";
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Commencer une transaction SQL
                    SqlTransaction sqlTransaction = connection.BeginTransaction();

                    try
                    {
                        // Insérer la transaction
                        using (SqlCommand commandTransaction = new SqlCommand(queryTransaction, connection, sqlTransaction))
                        {
                            commandTransaction.Parameters.AddWithValue("@CompteID", compteID);
                            commandTransaction.Parameters.AddWithValue("@TypeTransaction", typeTransaction);
                            commandTransaction.Parameters.AddWithValue("@Montant", montant);
                            commandTransaction.Parameters.AddWithValue("@DateTransaction", dateTransaction);
                            commandTransaction.ExecuteNonQuery();
                        }

                        // Mettre à jour le solde du compte
                        using (SqlCommand commandUpdateSolde = new SqlCommand(queryUpdateSolde, connection, sqlTransaction))
                        {
                            commandUpdateSolde.Parameters.AddWithValue("@CompteID", compteID);
                            commandUpdateSolde.Parameters.AddWithValue("@Montant", montant);
                            commandUpdateSolde.ExecuteNonQuery();
                        }

                        // Valider la transaction SQL
                        sqlTransaction.Commit();

                        MessageBox.Show("Transaction enregistrée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Annuler la transaction SQL en cas d'erreur
                        sqlTransaction.Rollback();
                        MessageBox.Show("Une erreur est survenue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

