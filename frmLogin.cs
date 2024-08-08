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
using Microsoft.Data.SqlClient;

namespace Gestion_Compte_Clients
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (IsValidAdmin(username, password))
            {
                MessageBox.Show("Login successful!");
                // Ouvrez le formulaire principal ou l'interface admin
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool IsValidAdmin(string username, string password)
        {
            bool isValid = false;

            // Changer la chaîne de connexion selon votre configuration
            string connectionString = "your_connection_string_here";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT PasswordHash FROM Admin WHERE Username = @Username";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string storedHash = reader["PasswordHash"].ToString();
                    isValid = VerifyPassword(password, storedHash);
                }

                reader.Close();
            }

            return isValid;
        }

        private bool VerifyPassword(string password, string storedHash)
        {
            // Comparer le mot de passe haché stocké avec le hachage du mot de passe entré
            string passwordHash = Admin.HashPassword(password);
            return storedHash == passwordHash;
        }
    }
}
