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
            RecupAbscences();
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

        private void RecupAbscences()
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


                string listItem = datedebut + "/" + datefin + "/" + motif;
                ListBoxAbsence.Items.Add(listItem);
            }

            reader.Close();


        }


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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAjouterAbsence_Click(object sender, EventArgs e)
        {
            DateTime dateDebut = TimePickerDebut.Value;
            DateTime dateFin = TimePickerFin.Value;

            // Vérifier que la date de début est inférieure à la date de fin
            if (dateDebut <= dateFin)
            {
                if (comboBoxMotif.SelectedItem != null)
                {
                    // Récupérer le motif de l'absence
                    string motif = comboBoxMotif.SelectedItem.ToString();

                    // Insérer l'absence dans la base de données
                    string query = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES (@idpersonnel, @datedebut, @datefin, (SELECT idmotif FROM motif WHERE libelle = @motif))";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idpersonnel", idPersonnels);
                    command.Parameters.AddWithValue("@datedebut", dateDebut);
                    command.Parameters.AddWithValue("@datefin", dateFin);
                    command.Parameters.AddWithValue("@motif", motif);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("L'absence a été ajoutée.");
                        ListBoxAbsence.Items.Clear();
                        RecupAbscences();
                    }
                }
            }
            else
            {
                MessageBox.Show("La date de début doit être inférieur à la date de fin.");
            }
        }

        private void comboBoxMotif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAnnulerAbsence_Click(object sender, EventArgs e)
        {
            TimePickerDebut.Value = DateTime.Now;
            TimePickerFin.Value = DateTime.Now;
            comboBoxMotif.SelectedIndex = -1;
        }

        private void BtnModifierAbsence_Click(object sender, EventArgs e)
        {
            if (ListBoxAbsence.SelectedIndex != -1)
            {
                string ligne = ListBoxAbsence.SelectedItem.ToString();
                List<string> liste = ligne.Split('/').ToList();
                string datedebut = liste[0];
                string datefin = liste[1];
                string motif = liste[2];
                DateTime nvxdatedebut = TimePickerDebut.Value;
                DateTime nvxdatefin = TimePickerFin.Value;
                string nvxmotif = comboBoxMotif.SelectedItem.ToString();
                if (nvxdatedebut <= nvxdatefin)
                {
                    string query = "UPDATE absence SET datedebut = @nouvelleDateDebut, datefin = @nouvelleDateFin, idmotif = (SELECT idmotif FROM motif WHERE libelle = @nouveauMotif) WHERE datedebut = @datedebut AND datefin = @datefin AND idpersonnel = @idperso";
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nouvelleDateDebut", nvxdatedebut);
                    command.Parameters.AddWithValue("@nouvelleDateFin", nvxdatefin);
                    command.Parameters.AddWithValue("@nouveauMotif", nvxmotif);
                    command.Parameters.AddWithValue("@datedebut", datedebut);
                    command.Parameters.AddWithValue("@datefin", datefin);
                    command.Parameters.AddWithValue("@idperso", idPersonnels);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Mettre à jour l'affichage dans la ListBox
                        ListBoxAbsence.Items.Clear();
                        RecupAbscences();

                        MessageBox.Show("Absence modifiée avec succès.");
                    }
                    else
                    {
                        MessageBox.Show("La modification de l'absence a échoué.");
                    }





                }
                else
                {
                    MessageBox.Show("La date de debut doit être inferieur à la date de fin.");


                }
            }

        }
    } }

