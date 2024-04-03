using MySql.Data.MySqlClient;
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


namespace app_service_x
{
    public partial class FormLogin : Form
    {
        MySqlConnection connection;

        public FormLogin()
        {
            InitializeComponent();

            // Créer une chaîne de connexion MySQL
            string connectionString = "server=VotreServeur;port=VotrePort;database=VotreBaseDeDonnees;uid=VotreUtilisateur;password=VotreMotDePasse";
            connection = new MySqlConnection(connectionString);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Mot de passe");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Hide Mot de passe");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxMotdepasse.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxMotdepasse.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private void textBoxMotdepasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {

            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Exécuter la requête pour vérifier le nom d'utilisateur et le mot de passe
                string query = "SELECT COUNT(*) FROM users WHERE nom_utilisateur = @nom_utilisateur AND mot_de_passe = @mot_de_passe";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nom_utilisateur", textBoxPrenom.Text.Trim());
                cmd.Parameters.AddWithValue("@mot_de_passe", textBoxMotdepasse.Text.Trim());
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    // Connexion réussie, ouvrir le formulaire de tableau de bord
                    FormDashboard fd = new FormDashboard();
                    fd.Show();
                }
                else
                {
                    // Connexion échouée, afficher un message d'erreur
                    MessageBox.Show("Nom d'utilisateur ou mot de passe invalide.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                // Gérer les exceptions liées à la connexion à la base de données
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fermer la connexion à la base de données
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        
    }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }
    } 
}
