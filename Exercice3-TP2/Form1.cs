using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exercice3_TP2
{
    public partial class Form1 : Form
    {
        static string connectionString = @"Data Source=DESKTOP-8KDCUOK\SQLEXPRESS;Initial Catalog=DbStagiaire;User ID=tdi-sg1;Password=2021;";
        SqlConnection connection = new SqlConnection(connectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void formLoadEvent(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Stagiaires";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxStagiaire.Items.Add(reader[0]);
                }
                reader.Close();
            }
            comboBoxStagiaire.SelectedItem = comboBoxStagiaire.Items[0];
            selectionnerExamen(comboBoxStagiaire.SelectedItem.ToString());
        }

        private void btnModifierClickEvent(object sender, EventArgs e)
        {
            if (textBoxNote.Text == "")
            {
                MessageBox.Show("Le champ de note est obligatoir !");
                return;
            }

            try
            {
                float note = float.Parse(textBoxNote.Text);
                int StagiaireNum = int.Parse(comboBoxStagiaire.SelectedItem.ToString()),
                    ExamenNum = int.Parse(comboBoxExamen.SelectedItem.ToString());
                if (note > 20)
                {
                    MessageBox.Show("La note doit etre inferieur ou egale a 20 !");
                    return;
                }

                SqlCommand command = connection.CreateCommand();
                command.CommandText = string.Format("UPDATE Notes SET note = {0} WHERE Stagiaire = {1} AND Examen = {2}", note, StagiaireNum, ExamenNum);
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("La note de l\'examen est bien modifieé !");
                }
            }
            catch ( FormatException)
            {
                MessageBox.Show("La note est invalid !");
            }
        }

        private void selectionnerExamen(string numero)
        {
            SqlCommand command = connection.CreateCommand();
            int numeroStagiaire = int.Parse(numero);
            command.CommandText = string.Format("SELECT Examen FROM Notes WHERE Stagiaire = {0}", numeroStagiaire);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxExamen.Items.Add(reader[0]);
                }
                textBoxNote.Enabled = true;
                btnModifierNote.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nothing !");
                textBoxNote.Enabled = false;
                btnModifierNote.Enabled = false;
            }
            reader.Close();
        }

        private void dropDownClosedEvent(object sender, EventArgs e)
        {
            selectionnerExamen(comboBoxStagiaire.SelectedItem.ToString());
        }
    }
}
