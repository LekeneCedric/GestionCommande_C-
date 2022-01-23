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
    public partial class GESTIONCOMMANDE : Form
    {
        public GESTIONCOMMANDE()
        {
            InitializeComponent();
            LoadTheme();
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

            gbcommande.ForeColor = ThemeColor.PrimaryColor;
            detailGroup.ForeColor = ThemeColor.PrimaryColor;
            labelreference.ForeColor = ThemeColor.TextColor;
            labelCIN.ForeColor = ThemeColor.TextColor;
            labelquantite.ForeColor = ThemeColor.TextColor;
            labelNUM.ForeColor = ThemeColor.TextColor;
            labelDATE.ForeColor = ThemeColor.TextColor;
            dateCommande.SkinColor = ThemeColor.PrimaryColor;


        }

        private void NouveauC(object sender, EventArgs e)
        {
            numeroCommande.Texts = "";
            cinClientCommande.Texts = "";
            dateCommande.Text = "";
            
        }

        private void NouveauD(object sender, EventArgs e)
        {
            referenceProduit.Texts = "";
            quantiteProduit.Texts = "";
        }
        public void clean()
        {
            CommandeView.Items.Clear();
        }
        private void btnRechercherProduit(object sender, EventArgs e)
        {
            clean();
            String con = @"server=localhost;userid=root;password=;database=gestioncommande";
            var connexion = new MySqlConnection(con);
            var connexion2 = new MySqlConnection(con);
            String numero = numeroCommande.Texts;
            connexion.Open();
            connexion2.Open();
            var cm = new MySqlCommand("SELECT * FROM contenir WHERE NUMCMDE ='" + numero + "'", connexion);
            try
            {

                MySqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    ListViewItem it = new
                    ListViewItem();
                    it.SubItems.Add(dr["REF_PRODUIT"].ToString());
                    it.SubItems.Add(dr["INTITULE_PRODUIT"].ToString());
                    var refCmd = new MySqlCommand("select * FROM produit where REF_PRODUIT = '" + dr["REF_PRODUIT"] + "'", connexion2);
                    MySqlDataReader rf = refCmd.ExecuteReader();
                    while (rf.Read())
                    {
                        it.SubItems.Add(rf["PRIX_PRODUIT"].ToString());
                    }
                    it.SubItems.Add(dr["QUANTITE"].ToString());
                    CommandeView.Items.Add(it);
                    rf.Close();
                    rf.Dispose();
                }

                dr.Close();
                dr.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegisterCommande(object sender, EventArgs e)
        {
            String numero = numeroCommande.Texts;
            String cin = cinClientCommande.Texts;
            DateTime date = Convert.ToDateTime(dateCommande.Text);
            try
            {
                String con = @"server=localhost;userid=root;password=;database=gestioncommande";
                var connexion = new MySqlConnection(con);
                connexion.Open();
                var sql = "INSERT INTO commande (NUMCMDE,CODE_CLIENT,DATECMD) values (@num,@cin,@date)";
                var cmd = new MySqlCommand(sql, connexion);
                cmd.Parameters.AddWithValue("@num", numero);
                cmd.Parameters.AddWithValue("@cin", cin);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Commande Ajoute Avec Success en Attente des Details ");

                connexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERREUR LORS DE L'ENREGISTREMENT DE LA COMMANDE ");
            }
            
        }

        private void btnModifierCommande(object sender, EventArgs e)
        {
            String numero = numeroCommande.Texts;
            String cin = cinClientCommande.Texts;
            DateTime date = Convert.ToDateTime(dateCommande.Text);
            String con = @"server=localhost;userid=root;password=;database=gestioncommande";

            try
            {
                var connexion = new MySqlConnection(con);

                var cm = new MySqlCommand("UPDATE commande SET NUMCMDE = @numero ,CODE_CLIENT = @cin ,DATECMD = @date where NUMCMDE  = '" + numero + "';", connexion);
                cm.Parameters.AddWithValue("@numero", numero);
                cm.Parameters.AddWithValue("@cin", cin);
                cm.Parameters.AddWithValue("@date", date);
                connexion.Open();
                cm.ExecuteNonQuery();
                connexion.Close();

                MessageBox.Show("Modification de la Commande Numero " + numero + "Effectue");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSupprimerCommande(object sender, EventArgs e)
        {
            String numero = numeroCommande.Texts;
            String con = @"server=localhost;userid=root;password=;database=gestioncommande";
            var connexion = new MySqlConnection(con);
            var connexion2 = new MySqlConnection(con);
            var cm = new MySqlCommand("delete FROM commande where NUMCMDE = '" + numero + "';", connexion);
            MySqlDataReader myReader;
            try
            {
                connexion.Open();
                myReader = cm.ExecuteReader();
                MessageBox.Show("La Commande Numero " + numero + " a ete Supprime avec Succes ");
                var sql2 = new MySqlCommand("delete FROM contenir WHERE NUMCMDE = '" + numero + "'", connexion2);
                MySqlDataReader myReader2;
                    connexion2.Open();
                    myReader2 = sql2.ExecuteReader();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addDetail(object sender, EventArgs e)
        {
            if (detailGroup.Enabled == true)
            {
                detailGroup.Enabled = false;
            }
            else
            {
                detailGroup.Enabled = true; 
            }

        }

        private void btnAjouterDetail(object sender, EventArgs e)
        {
            String reference = referenceProduit.Texts;
            String quantite = quantiteProduit.Texts;
            String numero = numeroCommande.Texts;

            try
            {
                String con = @"server=localhost;userid=root;password=;database=gestioncommande";
                var connexion = new MySqlConnection(con);
                var connexion2 = new MySqlConnection(con);
                connexion.Open();
                connexion2.Open();
                var sql = "INSERT INTO contenir (NUMCMDE,REF_PRODUIT,INTITULE_PRODUIT,QUANTITE) values (@num,@ref,@intitule,@quant)";
                var cmd = new MySqlCommand(sql, connexion);
                cmd.Parameters.AddWithValue("@num", numero);
                cmd.Parameters.AddWithValue("@ref", reference);
                var refCmd = new MySqlCommand("select * FROM produit where REF_PRODUIT = '" + reference + "'", connexion2);
                MySqlDataReader rf = refCmd.ExecuteReader();
                while (rf.Read())
                {
                    cmd.Parameters.AddWithValue("@intitule", rf["NOM_PRODUIT"]);
                }
                cmd.Parameters.AddWithValue("@quant", quantite);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Commande Ajoute Avec Success en Attente des Details ");
                NouveauD(sender, e);
                connexion.Close();
                rf.Close();
                rf.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnRemoveDetail(object sender, EventArgs e)
        {
             String reference = referenceProduit.Texts;
            String quantite = quantiteProduit.Texts;
            String numero = numeroCommande.Texts;
            String con = @"server=localhost;userid=root;password=;database=gestioncommande";
            var connexion = new MySqlConnection(con);
           
            var sql = "DELETE  FROM  contenir WHERE NUMCMDE ='"+numero+"'AND REF_PRODUIT = '"+reference+"'";
            var cmd = new MySqlCommand(sql, connexion);
            MySqlDataReader myReader;
            try {
                connexion.Open();
            myReader = cmd.ExecuteReader();
            MessageBox.Show("La Commande Numero " + numero + " a ete Supprime avec Succes ");
             
        }
            catch(Exception ex )
            {
            MessageBox.Show(ex.Message);
            }
        }

        private void btnModifierDetail(object sender, EventArgs e)
        {
            String numero = numeroCommande.Texts;
            DateTime date = Convert.ToDateTime(dateCommande.Text);
            String reference = referenceProduit.Texts;
            String quantite = quantiteProduit.Texts;
            String con = @"server=localhost;userid=root;password=;database=gestioncommande";

            try
            {
                var connexion = new MySqlConnection(con);

                var cm = new MySqlCommand("UPDATE contenir SET REF_PRODUIT= @ref , QUANTITE = @quant  where NUMCMDE  = '" + numero + "';", connexion);
                cm.Parameters.AddWithValue("@ref", numero);
                cm.Parameters.AddWithValue("@quant",quantite);
                connexion.Open();
                cm.ExecuteNonQuery();
                connexion.Close();

                MessageBox.Show("Modification des Details de la Commande Numero " + numero + "Effectue");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTerminer(object sender, EventArgs e)
        {
            NouveauC(sender, e);
            NouveauC(sender, e);
        }

        
        
    }
}
