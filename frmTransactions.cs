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
            transactions.Montant = Convert.ToDecimal(txtMontant.Text);
            transactions.CompteID = Convert.ToInt32(txtNumClient.Text);
            transactions.DateTransaction = dtTransaction.Value;
            transactions.TypeTransaction = typeTransaction;
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
            string connectionString = "votre_chaine_de_connexion";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Transactions (TypeTransaction, Montant, CompteID, DateTransaction) VALUES (@TypeTransaction, @Montant, @CompteID, @DateTransaction)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TypeTransaction", transaction.TypeTransaction);
                        command.Parameters.AddWithValue("@Montant", transaction.Montant);
                        command.Parameters.AddWithValue("@CompteID", transaction.CompteID);
                        command.Parameters.AddWithValue("@DateTransaction", transaction.DateTransaction);

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




        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulais vous confirmer cette transaction ?");
            try
            {
                Transactions transactions = new Transactions();

                // Appeler bindingClass avec le type de transaction approprié
                string typeTransaction = rbDepot.Checked ? "Depot" : rbRetrait.Checked ? "Retrait" : "";
                bindingClass(transactions, typeTransaction);

                Transactions transfertInstance = new Transactions();

                int resultat = EnregistrerTransaction(transactions);
                if (resultat > 0)
                {
                    MessageBox.Show("Transaction Réussie");
                }
                else
                {
                    MessageBox.Show("La Transaction a échoué");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un problème s'est produit, veuillez réessayer !!!\n" + ex.Message);
            }

        }
    }
}
