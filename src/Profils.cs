using Microsoft.VisualBasic.ApplicationServices;
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
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;



namespace rsvsport_logiciel
{
    public partial class Profils : Form
    {
        private MySqlConnection conn;
        private string server = "10.5.5.10";    // localhost
        private string database = "rsvsport";   // rsvsport
        private string uid = "admrsvsport";     // root
        private string pwd = "adm13?sp0rt45";   // 


        public Profils()
        {
            InitializeComponent();
            conn = new MySqlConnection($"Server={server};Port=3306;Database={database};Uid={uid};Pwd={pwd};");
        }




        //Enregistrer
        private void Enregistrer_Click(object sender, EventArgs e)
        {
            string mdp = passwordTXT + "#/ùzz";
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(mdp));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("x2"));
                }
                mdp = sb.ToString();
            }

            try
            {
                conn.Open();
                string query = "insert into users (id_groups, nom, prenom, email, tel, adresse, actif, password) values('" + group.Text + "','" + nom.Text + "','" + prenom.Text + "','" + email.Text + "','" + telephone.Text + "','" + adresse.Text + "', '" + status.Text + "', '" + mdp + "')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int i = cmd.ExecuteNonQuery();
                if (i >= -1)
                {
                    MessageBox.Show("Données insérées avec succes!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
            }
            finally
            {
                conn.Close();
                this.Actualiser_Click(sender, e);
            }
        }


        // Modifier
        private void Modification_Click(object sender, EventArgs e)
        {
            string mdp = passwordTXT + "#/ùzz";
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(mdp));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("x2"));
                }
                mdp = sb.ToString();
            }

            try
            {
                conn.Open();
                string query = "UPDATE users SET id_groups='" + group.Text + "', nom='" + nom.Text + "', prenom='" + prenom.Text + "', email='" + email.Text + "', tel='" + telephone.Text + "', adresse='" + adresse.Text + "', actif='" + status.Text + "' , password='" + mdp + "' WHERE id_user=" + dataGridView1.SelectedCells[0].Value.ToString();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int i = cmd.ExecuteNonQuery();
                if (i >= -1)
                {
                    MessageBox.Show("Donnée modifiée avec succes!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
            }
            finally
            {
                conn.Close();
                this.Actualiser_Click(sender, e);
            }
        }


        // Supprimer
        private void Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM users WHERE id_user=" + dataGridView1.SelectedCells[0].Value.ToString();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int i = cmd.ExecuteNonQuery();
                if (i >= -1)
                {
                    MessageBox.Show("Données supprimées avec succes!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
            }
            finally
            {
                conn.Close();
                this.Actualiser_Click(sender, e);
            }
        }





        // Actualiser
        private void Actualiser_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = "SELECT * FROM users";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }





        // Liens pages

        // Voir Tennis
        private void label4_Click_1(object sender, EventArgs e)
        {
            //conn.Close();
            this.Hide();
            Tennis Tennis = new Tennis();
            Tennis.Show();
        }

        // Voir Rugby
        private void label15_Click(object sender, EventArgs e)
        {
            //conn.Close();
            this.Hide();
            Rugby Rugby = new Rugby();
            Rugby.Show();
        }

        // Voir Football
        private void label14_Click(object sender, EventArgs e)
        {
            //conn.Close();
            this.Hide();
            Foot Foot = new Foot();
            Foot.Show();
        }

        // Deconnection
        private void label10_Click(object sender, EventArgs e)
        {
            //conn.Close();
            this.Hide();
            Connection1 Connection1 = new Connection1();
            Connection1.Show();
        }


    }
}
