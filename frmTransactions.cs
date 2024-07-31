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
                if (transaction.TypeTransaction != "Depot" && transaction.TypeTransaction != "Retrait")
                {
                    //throw new ArgumentException("TypeTransaction doit être 'Dépot' ou 'Retrait'");
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
                string typeTransaction = rbDepot.Checked ? "Depot" : (rbRetrait.Checked ? "Retrait" : null);

                if (typeTransaction == null)
                {
                    MessageBox.Show("Veuillez sélectionner le type de transaction.");
                    return;
                }

                // Créer une instance de Transactions
                Transactions transaction = new Transactions
                {
                    CompteID = compteID,
                    TypeTransaction = typeTransaction,
                    Montant = montant,
                    DateTransaction = dateTransaction
                };

                // Enregistrer la transaction
                int resultat = EnregistrerTransaction(transaction);

                if (resultat > 0)
                {
                    MessageBox.Show("Transaction enregistrée avec succès.");
                }
                else
                {
                    MessageBox.Show("L'enregistrement de la transaction a échoué.", "Échec", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue : " + ex.Message, "Erreur", MessageBoxButtons.OK);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

