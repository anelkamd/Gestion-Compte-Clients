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
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        private void bindingClass(Transactions transactions)
        {
            transactions.Montant = Convert.ToDecimal(txtMontant.Text);
            transactions.CompteID = Convert.ToInt32(txtNumClient.Text);
            transactions.DateTransaction = dtTransaction.Value;
            transactions.TypeTransaction = txtTransaction.Text;
            
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
        }
    }
}
