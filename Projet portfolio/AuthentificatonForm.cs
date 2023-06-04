using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Projet_portfolio
{
    public partial class AuthenficationForm : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user id=root;database=atelier;SslMode=None";

        public AuthenficationForm()
        {
            InitializeComponent();
            InitConnection();
            textBoxMdp.UseSystemPasswordChar = true;

        }
        private void InitConnection()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);

            }


        }

        //Fonction provenant d'internet pour hashé
        private string ComputeSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool ConnexionResp(string identifiant, string mdp)
        {
            string mdpHash = ComputeSHA256Hash(mdp);
            string query = "SELECT COUNT(*) FROM responsable WHERE login = @identifiant AND pwd = @mdp";
            MySqlCommand prepare = new MySqlCommand(query, connection);
            prepare.Parameters.AddWithValue("@identifiant", identifiant);
            prepare.Parameters.AddWithValue("@mdp", mdpHash);
            int count = Convert.ToInt32(prepare.ExecuteScalar());
            return count != 0;
        }


        




        private void BtnValider_Click(object sender, EventArgs e)
        {

            string identifiant = textBoxLogin.Text;
            string mdp = textBoxMdp.Text;
            if (identifiant != "" && mdp!="")
            {
                if (ConnexionResp(identifiant, mdp))
                {
                    PersonnelsForm personnelsForm = new PersonnelsForm();
                    personnelsForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrect !");
                }
            } else { MessageBox.Show("Veuillez Remplir le champ correspondant a votre identifiant ou votre mot de passe avant de Valider") ; }
        }

        private void AuthenficationForm_Load(object sender, EventArgs e)
        {

        }
    }
}


