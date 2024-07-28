using Gestion_Compte_Clients.Mes_Classes;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmClients_Load(object sender, EventArgs e)
        {

        }
    }
}
