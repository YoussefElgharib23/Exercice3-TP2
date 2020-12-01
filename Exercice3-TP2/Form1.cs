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
        static string connectionString = @"Data Source=localhost;Initial Catalog=Stagiaires;Integrated Security=True;User Id=Youssef;Password=Youssef@2310";
        SqlConnection connection = new SqlConnection(connectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void formLoadEvent(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT Stagiaire, Examen FROM Notes";
            SqlDataReader reader = command.ExecuteReader();

            if ( reader.HasRows )
            {
                while (reader.Read())
                {
                    comboBoxStagiaire.Items.Add(reader[0]);
                    comboBoxStagiaire.Items.Add(reader[1]);
                }
            }
            reader.Close();
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
                command.ExecuteNonQuery();
            }
            catch ( FormatException)
            {
                MessageBox.Show("La note est invalid !");
            }
        }
    }
}
