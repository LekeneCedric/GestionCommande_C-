using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dropdown;
using MySql.Data.MySqlClient;

namespace F_GESTION_COMMANDE_PROJET_CSHARP.formulaire
{
    public partial class GESTIONPRODUITS : Form
    {
        public GESTIONPRODUITS()
        {
            InitializeComponent();
            LoadTheme();
            refresh();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(RJButton))
                {
                    RJButton btn = (RJButton)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;

                }
            }

            // labelmenu.ForeColor = ThemeColor.PrimaryColor;
            labelreference.ForeColor = ThemeColor.TextColor;
            labelintitule.ForeColor = ThemeColor.TextColor;
            labelcategories.ForeColor = ThemeColor.TextColor;
            labelquantite.ForeColor = ThemeColor.TextColor;
            labelprix.ForeColor = ThemeColor.TextColor;
           

        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            referenceProduit.Texts = "";
            intituleProduit.Texts = "";
            categorieProduit.Texts = "";
            quantiteProduit.Texts = "";
            prixProduit.Texts = "";
        }
        public void refresh()
        {
            String con = @"server=localhost;userid=root;password=;database=gestioncommande";
            String sql = "SELECT * FROM produit";
            try
            {
                var connexion = new MySqlConnection(con);
                connexion.Open();
                var cmd = new MySqlCommand(sql, connexion);
                MySqlDataReader Reader = cmd.ExecuteReader();
                ProduitView.Items.Clear();

                while (Reader.Read())
                {
                    ListViewItem lv = new ListViewItem(Reader.GetString(0));
                    lv.SubItems.Add(Reader.GetString(1));
                    lv.SubItems.Add(Reader.GetString(2));
                    lv.SubItems.Add(Reader.GetString(3));
                    lv.SubItems.Add(Reader.GetString(4));
                    ProduitView.Items.Add(lv);
                }
                Reader.Close();
                connexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors du chargement des Produits");
            }
        }

        private void btnAjouter(object sender, EventArgs e)
        {
            String reference = referenceProduit.Texts;
            String intitule = intituleProduit.Texts;
            String categorie = categorieProduit.Texts;
            String quantite = quantiteProduit.Texts;
            String prix = prixProduit.Texts;
            if(reference!="" && intitule != "" && categorie!="" && quantite!="" && prix!="")
            {
            try
            {
                String con = @"server=localhost;userid=root;password=;database=gestioncommande";
                var connexion = new MySqlConnection(con);
                connexion.Open();
                var sql = "INSERT INTO produit (REF_PRODUIT,NOM_PRODUIT,CATEGORIE_PRODUIT,QUANTITE_STOCK,PRIX_PRODUIT) values (@ref,@nom,@categ,@quant,@prix)";
                var cmd = new MySqlCommand(sql, connexion);
                cmd.Parameters.AddWithValue("@ref", reference);
                cmd.Parameters.AddWithValue("@nom", intitule);
                cmd.Parameters.AddWithValue("@categ", categorie);
                cmd.Parameters.AddWithValue("@quant", quantite);
                cmd.Parameters.AddWithValue("@prix", prix);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                string[] row = { reference, intitule, categorie, quantite, prix };
                var listViewItem = new ListViewItem(row);
                ProduitView.Items.Add(listViewItem);
                refresh();
                MessageBox.Show("Produit " + intitule + "Ajoute dans la base de donnee avec success");
                rjButton6_Click(sender, e);
                connexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("PRODUIT EXISTANT OU ERREUR DE CONNEXION A LA BD ");
            }
            }
            else
            {
                MessageBox.Show("Veuillez remplir conformement les Champs");
            }
        }

        private void btnRecherche(object sender, EventArgs e)
        {

            MySqlCommand cm;
            String reference = referenceProduit.Texts;
            String intitule = intituleProduit.Texts;
            String categorie = categorieProduit.Texts;
            String quantite = quantiteProduit.Texts;
            String prix = prixProduit.Texts;
            String con = @"server=localhost;userid=root;password=;database=gestioncommande";
            var connexion = new MySqlConnection(con);
            connexion.Open();

            if (reference == "")
            {
                cm = new MySqlCommand("SELECT * FROM produit ", connexion);
                try
                {
                    ProduitView.Items.Clear();
                    MySqlDataReader dr = cm.ExecuteReader();
                    while (dr.Read())
                    {

                        ListViewItem it = new
                        ListViewItem(dr["REF_PRODUIT"].ToString());
                        it.SubItems.Add(dr["NOM_PRODUIT"].ToString());
                        it.SubItems.Add(dr["CATEGORIE_PRODUIT"].ToString());
                        it.SubItems.Add(dr["QUANTITE_STOCK"].ToString());
                        it.SubItems.Add(dr["PRIX_PRODUIT"].ToString());
                        ProduitView.Items.Add(it);

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                cm = new MySqlCommand("SELECT * FROM produit WHERE REF_PRODUIT='" + reference + "'", connexion);
                try
                {

                    MySqlDataReader dr = cm.ExecuteReader();
                    ProduitView.Items.Clear();
                    while (dr.Read())
                    {

                        ListViewItem it = new
                         ListViewItem(dr["REF_PRODUIT"].ToString());
                        it.SubItems.Add(dr["NOM_PRODUIT"].ToString());
                        it.SubItems.Add(dr["CATEGORIE_PRODUIT"].ToString());
                        it.SubItems.Add(dr["QUANTITE_STOCK"].ToString());
                        it.SubItems.Add(dr["PRIX_PRODUIT"].ToString());
                        ProduitView.Items.Add(it);

                    }

                    dr.Close();
                    dr.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnModifier(object sender, EventArgs e)
        {
            String reference = referenceProduit.Texts;
            String intitule = intituleProduit.Texts;
            String categorie = categorieProduit.Texts;
            String quantite = quantiteProduit.Texts;
            String prix = prixProduit.Texts;
            String con = @"server=localhost;userid=root;password=;database=gestioncommande";
            if (reference != "" && intitule != "" && categorie != "" && quantite != "" && prix != "")
            {
                try
                {
                    var connexion = new MySqlConnection(con);

                    var cm = new MySqlCommand("UPDATE produit SET REF_PRODUIT = @ref , NOM_PRODUIT = @nom , CATEGORIE_PRODUIT = @categ , QUANTITE_STOCK = @quant , PRIX_PRODUIT = @prix where REF_PRODUIT = '" + reference + "';", connexion);
                    cm.Parameters.AddWithValue("@ref", reference);
                    cm.Parameters.AddWithValue("@nom", intitule);
                    cm.Parameters.AddWithValue("@categ", categorie);
                    cm.Parameters.AddWithValue("@quant", quantite);
                    cm.Parameters.AddWithValue("@prix", prix);
                    connexion.Open();

                    cm.ExecuteNonQuery();

                    connexion.Close();
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir conformement tout les champs ");
            }
        }

        private void btnSupprimer(object sender, EventArgs e)
        {

            String reference = referenceProduit.Texts;
            String con = @"server=localhost;userid=root;password=;database=gestioncommande";
            var connexion = new MySqlConnection(con);
            var connexion2 = new MySqlConnection(con);
            var cm = new MySqlCommand("delete FROM produit where REF_PRODUIT = '" + reference + "';", connexion);
            MySqlDataReader myReader;
            if (reference != "")
            {
                try
                {
                    connexion.Open();
                    myReader = cm.ExecuteReader();
                    MessageBox.Show("Le Produit " + reference + " a ete Supprime avec Succes ");
                    var cmd2 = new MySqlCommand("delete FROM contemir WHERE REF_PRODUIT = '" + reference + "'", connexion2);
                    MySqlDataReader myReader2;
                    myReader2 = cmd2.ExecuteReader();
                    refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("veuillez remplir le champ REFERENCE du Produit");
            }
        }
    }
}
