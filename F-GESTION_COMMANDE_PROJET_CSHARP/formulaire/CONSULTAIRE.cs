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

namespace F_GESTION_COMMANDE_PROJET_CSHARP.formulaire
{
    public partial class CONSULTAIRE : Form
    {
        public CONSULTAIRE()
        {
            InitializeComponent();
        }

        private void btnValider(object sender, EventArgs e)
        {
            CommandeView.Items.Clear();
            DetailView.Items.Clear();
            String cin = cinClient.Text;
            String con = @"server=localhost;userid=root;password=;database=gestioncommande";
            String sql = "SELECT NUMCMDE , DATECMD FROM commande WHERE CODE_CLIENT = '" + cin + "'";
            int Total = 0; 
            try
            {
                var connexion = new MySqlConnection(con);
                var connexion2 = new MySqlConnection(con);
                var connexion3 = new MySqlConnection(con);
                connexion.Open();
                connexion2.Open();
                connexion3.Open();
                var cmd = new MySqlCommand(sql, connexion);
                MySqlDataReader Reader = cmd.ExecuteReader();
                CommandeView.Items.Clear();

                while (Reader.Read())
                {
                    ListViewItem lv = new ListViewItem(Reader.GetString(0));
                    lv.SubItems.Add(Reader.GetString(1));
                    CommandeView.Items.Add(lv);
                    var cm = new MySqlCommand("SELECT * FROM contenir WHERE NUMCMDE ='" + Reader.GetString(0) + "'", connexion2);
                    try
                    {

                        MySqlDataReader dr = cm.ExecuteReader();
                        while (dr.Read())
                        {

                            ListViewItem it = new
                            ListViewItem(dr["REF_PRODUIT"].ToString());
                            it.SubItems.Add(dr["INTITULE_PRODUIT"].ToString());
                            var refCmd = new MySqlCommand("select * FROM produit where REF_PRODUIT = '" + dr["REF_PRODUIT"] + "'", connexion3);
                            MySqlDataReader rf = refCmd.ExecuteReader();
                            while (rf.Read())
                            {
                                it.SubItems.Add(rf["PRIX_PRODUIT"].ToString());
                            }
                            int quantite = Int32.Parse(dr["QUANTITE"].ToString());
                            int PrixU = Int32.Parse(rf["PRIX_PRODUIT"].ToString());
                            int result = quantite * PrixU;
                            Total += result;
                            it.SubItems.Add(result.ToString());
                            DetailView.Items.Add(it);
                            rf.Close();
                            rf.Dispose();
                        }
                        TotalBox.Text = Total.ToString();
                        dr.Close();
                        dr.Dispose();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                Reader.Close();
                connexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors du chargement de la Liste des Commandes ");
            }
            

        }

    }
}
