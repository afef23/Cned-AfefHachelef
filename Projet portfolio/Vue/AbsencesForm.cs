using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_portfolio;
using MySql.Data.MySqlClient;

namespace Projet_portfolio
{

    public partial class AbsencesForm : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private string connectionString = "server=localhost;user id=root;database=atelier;SslMode=None";
        public int idPersonnels;
        public AbsencesForm(int personnelId)
        {
            InitializeComponent();
            InitConnection();
            idPersonnels = personnelId;
            RecupAbsences();
            RemplirComboBoxMotif();

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

        //Module qui récupère les absences de la base de donnée et qui les affiche dans la listBox
        private void RecupAbsences()
        {
            ListBoxAbsence.Visible = true;
            string query = "SELECT A.datedebut, A.datefin, M.libelle " +
                               "FROM absence AS A " +
                               "JOIN motif AS M ON A.idmotif = M.idmotif " +
                               "WHERE A.idpersonnel = @idPersonnel";
            command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@idPersonnel", idPersonnels);
            reader = command.ExecuteReader();
            ListBoxAbsence.Items.Clear();

            while (reader.Read())
            {
                string datedebut = reader.GetString(0);
                string datefin = reader.GetString(1);
                string motif = reader.GetString(2);

                string listItem = datedebut + "|" + datefin + "|" + motif;
                ListBoxAbsence.Items.Add(listItem);
            }

            reader.Close();


        }

        //remplir la comboBoxMotif avec les motifs disponible dans la base de données
        private void RemplirComboBoxMotif()
        {
            string query = "SELECT libelle FROM motif";
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string nomMotif = reader.GetString(0);
                comboBoxMotif.Items.Add(nomMotif);
            }
            reader.Close();
        }

   

        //Ajouter une absence
        private void BtnAjouterAbsence_Click(object sender, EventArgs e)
        {
            DateTime datedebut = TimePickerDebut.Value;
            string fNvxdatedebut = datedebut.ToString("yyyy-MM-dd");
            DateTime datefin = TimePickerFin.Value;
            string fNvxdatefin = datefin.ToString("yyyy-MM-dd");

            // Vérifier que la date de début est inférieure ou égal à la date de fin
            if (datedebut <= datefin)
            {
                if (comboBoxMotif.SelectedItem != null)
                {
                    // Récupérer le motif de l'absence
                    string motif = comboBoxMotif.SelectedItem.ToString();

                    // Insérer l'absence dans la base de données
                    string query = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES (@idpersonnel, @datedebut, @datefin, (SELECT idmotif FROM motif WHERE libelle = @motif))";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idpersonnel", idPersonnels);
                    command.Parameters.AddWithValue("@datedebut", fNvxdatedebut);
                    command.Parameters.AddWithValue("@datefin", fNvxdatefin);
                    command.Parameters.AddWithValue("@motif", motif);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("L'absence a été ajoutée.");
                        ListBoxAbsence.Items.Clear();
                        RecupAbsences();
                        BtnAnnulerAbsence_Click(null, null);
                    }
                }
            }
            else
            {
                MessageBox.Show("La date de début doit être inférieur à la date de fin.");
            }
        }
     

        //Annuler la saisie
        private void BtnAnnulerAbsence_Click(object sender, EventArgs e)
        {
            TimePickerDebut.Value = DateTime.Now;
            TimePickerFin.Value = DateTime.Now;
            comboBoxMotif.SelectedIndex = -1;
        }

        //Modifier une absence
        private void BtnModifierAbsence_Click(object sender, EventArgs e)
        {
            if (ListBoxAbsence.SelectedIndex != -1)
            {
                try
                {
                    if (comboBoxMotif.SelectedItem != null)
                    {
                        //récupérer le contenue de la ListBoxAbsence 
                        string ligne = ListBoxAbsence.SelectedItem.ToString();
                        List<string> liste = ligne.Split('|').ToList();
                        string datedebut = liste[0];
                        string datefin = liste[1];
                        string motif = liste[2];
                        DateTime nvxdatedebut = TimePickerDebut.Value;
                        string fNvxdatedebut = nvxdatedebut.ToString("yyyy-MM-dd");
                        DateTime nvxdatefin = TimePickerFin.Value;
                        string fNvxdatefin = nvxdatefin.ToString("yyyy-MM-dd");
                        string nvxmotif = comboBoxMotif.SelectedItem.ToString();
                        if (nvxdatedebut <= nvxdatefin)
                        {
                           //Mettre à jour les données dans la base
                            string query = "UPDATE absence SET datedebut = @nouvelleDateDebut, datefin = @nouvelleDateFin, idmotif = (SELECT idmotif FROM motif WHERE libelle = @nouveauMotif) WHERE datedebut = @datedebut AND datefin = @datefin AND idpersonnel = @idperso";
                            command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@nouvelleDateDebut", fNvxdatedebut);
                            command.Parameters.AddWithValue("@nouvelleDateFin", fNvxdatefin);
                            command.Parameters.AddWithValue("@nouveauMotif", nvxmotif);
                            command.Parameters.AddWithValue("@datedebut", datedebut);
                            command.Parameters.AddWithValue("@datefin", datefin);
                            command.Parameters.AddWithValue("@idperso", idPersonnels);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Mettre à jour l'affichage dans la ListBox
                                ListBoxAbsence.Items.Clear();
                                RecupAbsences();

                                MessageBox.Show("L'Absence a bien était modifiée.");
                                BtnAnnulerAbsence_Click(null, null);

                            }

                        }
                        else
                        {
                            MessageBox.Show("La date de début doit être inférieure à la date de fin.");
                        }
                    }
                    else { MessageBox.Show("Veuillez sélectionner un Motif !"); }
                }
                catch { }
                }
        }
        //Supprimer une absence
        private void BtnSupprimerAbsence_Click(object sender, EventArgs e)
        {
            if (ListBoxAbsence.SelectedIndex != -1)
            {
                //Récupérer le contenue sélectionné et le metrre dans des variables 
                string ligne = ListBoxAbsence.SelectedItem.ToString();
                List<string> liste = ligne.Split('|').ToList();
                string datedebut = liste[0];
                string datefin = liste[1];
                string motif = liste[2];

                //Demander une confirmation
                ConfirmationForm confirmationForm = new ConfirmationForm();
                confirmationForm.ShowDialog();
                if (confirmationForm.confirmation)
                {
                    //Mettre à jour les données dans la base
                    string query = "DELETE FROM absence WHERE datedebut = @datedebut AND datefin = @datefin AND idpersonnel = @idperso";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@datedebut", datedebut);
                    command.Parameters.AddWithValue("@datefin", datefin);
                    command.Parameters.AddWithValue("@idperso", idPersonnels);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        ListBoxAbsence.Items.Clear();
                        RecupAbsences();
                        MessageBox.Show("L'Absence a bien était supprimée.");
                    }

                }
            }
        }
    } }

