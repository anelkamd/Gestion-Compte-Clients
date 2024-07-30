using Gestion_Compte_Clients.Mes_Classes;
using Microsoft.Data.SqlClient;

namespace Gestion_Compte_Clients
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataAccess data = new DataAccess();
            bool isOpen = data.OpenConnection();
            if (isOpen)
            {
                MessageBox.Show("J'accepete les conditions d'utilisation de l'application");
                // Message de la connexion de base de donnees 
            }
            else
            {
                MessageBox.Show("Connexion a echoue...");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            FrmClients frm = new FrmClients();
            frm.Show();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            frmTransactions frm = new frmTransactions();
            frm.Show();
        }
    }
}
