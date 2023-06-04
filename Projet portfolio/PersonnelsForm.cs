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
using Projet_portfolio;
namespace Projet_portfolio
{
   
    public partial class PersonnelsForm : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private string connectionString = "server=localhost;user id=root;database=atelier;SslMode=None";
        public int personnelId { get; private set; }

        















        public PersonnelsForm()
        {
            InitializeComponent();
            InitConnection();
            RecupPersonnels();
            groupBox3.Visible = false;
            RemplirComboBoxService();
            


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

        private void RecupPersonnels()
        {
            ListBoxId.Visible = true;
            string query = "SELECT P.nom, P.prenom, P.mail, P.tel, S.nom " +
               "FROM personnel AS P " +
               "JOIN service AS S ON P.idservice = S.idservice";

            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            ListBoxId.Items.Clear();

            while (reader.Read())
            {
                string nom = reader.GetString(0);
                string prenom = reader.GetString(1);
                string mail = reader.GetString(2);
                string tel = reader.GetString(3);
                string nomService = reader.GetString(4);

                string listItem = nom + " " + prenom + " " + mail + " " + tel + " " + nomService;
                ListBoxId.Items.Add(listItem);
            }

            reader.Close();

        }


        private void RemplirComboBoxService()
        {
            string query = "SELECT nom FROM service";
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string nomService = reader.GetString(0);
                ComboBoxService.Items.Add(nomService);
;

            }
            reader.Close();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (BtnAjouter.Text == "Ajouter")
            {
                string nom = Nom.Text;
                string prenom = TextBoxPrenom.Text;
                string mail = TextBoxMail.Text;
                string tel = TextBoxTel.Text;

                int idService = 0;

                if (ComboBoxService.SelectedItem != null)

                {
                    string service = ComboBoxService.SelectedItem.ToString();

                    if (nom != "" && prenom != "" && tel != "" && mail != "")
                    {

                        string query = "SELECT idservice FROM service WHERE nom = @service";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@service", service);
                        reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            idService = reader.GetInt32(0);
                        }

                        reader.Close();

                        query = "INSERT INTO personnel (idservice, nom, prenom, tel, mail) VALUES (@idservice, @nom, @prenom, @tel, @mail)";
                        command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@idservice", idService);
                        command.Parameters.AddWithValue("@nom", nom);
                        command.Parameters.AddWithValue("@prenom", prenom);
                        command.Parameters.AddWithValue("@tel", tel);
                        command.Parameters.AddWithValue("@mail", mail);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Un nouveau membre à bien était ajouter.");
                            ListBoxId.Items.Clear();
                            RecupPersonnels();


                        }

                    }
                    else { MessageBox.Show("Les informations ne sont pas complètes."); }
                }
                else { MessageBox.Show("Veuillez Selectioner un service !"); }
            }
            else
            {
                if (ComboBoxService != null) { 
                ConfirmationForm confirmationForm = new ConfirmationForm();
                confirmationForm.ShowDialog();
                if (confirmationForm.confirmation)
                {
                    string ligne = ListBoxId.SelectedItem.ToString();
                    List<string> liste = ligne.Split(' ').ToList();
                    string nom = liste[0];
                    string prenom = liste[1];
                    string mail = liste[2];
                    string tel = liste[3];
                    string nomService = liste[4];
                    int idpersonnel = 0;
                    string query = "SELECT idpersonnel FROM personnel WHERE nom =@nom AND prenom=@prenom AND mail=@mail AND tel=@tel";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@tel", tel);

                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        idpersonnel = reader.GetInt32(0);
                    }

                    reader.Close();

                    string nombis = Nom.Text;
                    string prenombis = TextBoxPrenom.Text;
                    string mailbis = TextBoxMail.Text;
                    string telbis = TextBoxTel.Text;
                    string servicebis = ComboBoxService.SelectedItem.ToString();






                    string query2 = "UPDATE personnel SET nom = @nombis, prenom = @prenombis, mail = @mailbis, tel = @telbis, idservice = (SELECT idservice FROM service WHERE nom = @servicebis) WHERE idpersonnel = @idpersonnel";
                    command = new MySqlCommand(query2, connection);
                    command.Parameters.AddWithValue("@nombis", nombis);
                    command.Parameters.AddWithValue("@prenombis", prenombis);
                    command.Parameters.AddWithValue("@mailbis", mailbis);
                    command.Parameters.AddWithValue("@telbis", telbis);
                    command.Parameters.AddWithValue("@servicebis", servicebis);
                    command.Parameters.AddWithValue("@idpersonnel", idpersonnel);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Le personnel a été modifié avec succès.");
                        ListBoxId.Items.Clear();
                        RecupPersonnels();
                        BtnAnnuler_Click(null, null);
                    }
                }


                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner le service.");

                }
            }
        }

        private void PersonnelsForm_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnAnnuler_Click(null, null);
            groupBox3.Visible = true;
            groupBox3.Text = "Ajouter un personnel";
            BtnAjouter.Text = "Ajouter";
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox3.Text = "Modifer un personnel";
            BtnAjouter.Text = "Modifier";
            if(ListBoxId.SelectedIndex !=-1)
            {
                string ligne = ListBoxId.SelectedItem.ToString();
                List<string> liste = ligne.Split(' ').ToList();
                string nom = liste[0];
                string prenom = liste[1];
                string mail = liste[2];
                string tel = liste[3];
                string nomService = liste[4];
                Nom.Text = nom;
                TextBoxPrenom.Text = prenom;
                TextBoxMail.Text = mail;
                TextBoxTel.Text = tel;
                ComboBoxService.SelectedItem = nomService;
            }else { MessageBox.Show("Veuillez Selectioner un membre du personnel pour le modifier !"); }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Nom.Text = "";
            TextBoxPrenom.Text = "";
            TextBoxMail.Text = "";
            TextBoxTel.Text = "";
            ComboBoxService.SelectedIndex = -1;
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if(ListBoxId.SelectedIndex != -1)
             {
                ConfirmationForm confirmationForm = new ConfirmationForm();
                confirmationForm.ShowDialog();

                if (confirmationForm.confirmation) {
                    string ligne = ListBoxId.SelectedItem.ToString();
                    List<string> liste = ligne.Split(' ').ToList();
                    string nom = liste[0];
                    string prenom = liste[1];
                    string mail = liste[2];
                    string tel = liste[3];
                    string nomService = liste[4];
                    string query = "DELETE FROM personnel WHERE nom = @nom AND prenom = @prenom AND mail = @mail AND tel = @tel";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@tel", tel);
                    command.ExecuteNonQuery();
                    int indice = ListBoxId.SelectedIndex;
                    ListBoxId.Items.RemoveAt(indice);
                    }
            }else { MessageBox.Show("Veuillez Selectioner un membre du personnel pour le supprimer !"); }
        }

        private void BtnAbsence_Click(object sender, EventArgs e)
        {
            if (ListBoxId.SelectedIndex != -1)
            {
                string ligne = ListBoxId.SelectedItem.ToString();
                List<string> liste = ligne.Split(' ').ToList();
                string nom = liste[0];
                string prenom = liste[1];
                string mail = liste[2];
                string tel = liste[3];
                string nomService = liste[4];
                string query = "SELECT idpersonnel FROM personnel WHERE nom =@nom AND prenom=@prenom AND mail=@mail AND tel=@tel";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@prenom", prenom);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@tel", tel);

                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    personnelId = reader.GetInt32(0);
                }

                reader.Close();

                AbsencesForm absencesForm = new AbsencesForm(personnelId);
                absencesForm.ShowDialog();
            }
            else { MessageBox.Show("Veuillez sellectioner un membre du personnel afin de consulter son registre d'abscence."); }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
