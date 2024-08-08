using Gestion_Compte_Clients.Mes_Classes;
using Microsoft.Data.SqlClient;

namespace Gestion_Compte_Clients
{
    public partial class frmComptes : Form
    {
        public frmComptes()
        {
            InitializeComponent();
        }

        private void bindingClass(Comptes comptes)
        {
            try
            {
                comptes.Solde = Convert.ToDecimal(txtSolde.Text);
                comptes.ClientID = Convert.ToInt32(txtClientID.Text);
                comptes.DateCreation = dtCreation.Value;
            }
            catch
            {
                MessageBox.Show("Veillez remplire le formulaire svp");
            }
        }


        private int EnregistrerComptes(Comptes comptes)
        {
            string connectionString = "Data Source=ANELKA-MD; Initial Catalog=Gestion_Compte_Clients; User ID=Anelka; Password=26355217; Encrypt=false";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Compte (ClientID,Solde, DateCreation) VALUES ( @ClientID, @Solde, @DateCreation)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClientID", comptes.Solde);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Comptes comptes = new Comptes();

                bindingClass(comptes);

                Comptes CompteInstance = new Comptes();

                int resultat = CompteInstance.EnregistrerComptes(comptes);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
