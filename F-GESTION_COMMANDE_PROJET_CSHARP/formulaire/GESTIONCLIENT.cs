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
    public partial class GESTIONCLIENT : Form
    {
        public GESTIONCLIENT()
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
            labelCIN.ForeColor = ThemeColor.TextColor;
            labelNOM.ForeColor = ThemeColor.TextColor;
            labelPRENOM.ForeColor = ThemeColor.TextColor;
            labelLOGIN.ForeColor = ThemeColor.TextColor;
            labelNUM.ForeColor = ThemeColor.TextColor;

        }
        public void refresh()
        {

            String con = @"server=localhost;userid=root;password=;database=gestioncommande";
            String sql = "SELECT * FROM client";
            try
            {
                var connexion = new MySqlConnection(con);
                connexion.Open();
                var cmd = new MySqlCommand(sql, connexion);
                MySqlDataReader Reader = cmd.ExecuteReader();
                ClientView.Items.Clear();

                while (Reader.Read())
                {
                    ListViewItem lv = new ListViewItem(Reader.GetString(0));
                    lv.SubItems.Add(Reader.GetString(1));
                    lv.SubItems.Add(Reader.GetString(2));
                    lv.SubItems.Add(Reader.GetString(3));
                    lv.SubItems.Add(Reader.GetString(4));
                    ClientView.Items.Add(lv);
                }
                Reader.Close();
                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void GESTIONCLIENT_Load(object sender, EventArgs e)
        {

        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            cinClient.Texts = "";
            nomClient.Texts = "";
            prenomClient.Texts = "";
            villeClient.Texts = "";
            numeroClient.Texts = "";

        }

        private void txttel__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRecherche(object sender, EventArgs e)
        {

            MySqlCommand cm;
            String nom = nomClient.Texts;
            String prenom = prenomClient.Texts;
            String cin = cinClient.Texts;
            String ville = villeClient.Texts;
            String numero = numeroClient.Texts;
            String con = @"server=localhost;userid=root;password=;database=gestioncommande";
            var connexion = new MySqlConnection(con);
            connexion.Open();

            if (cinClient.Texts == "")
            {
                cm = new MySqlCommand("SELECT * FROM client ", connexion);
                try
                {
                    ClientView.Items.Clear();
                    MySqlDataReader dr = cm.ExecuteReader();
                    while (dr.Read())
                    {

                        ListViewItem it = new
                        ListViewItem(dr["CODE_CLIENT"].ToString());
                        it.SubItems.Add(dr["NOM_CLIENT"].ToString());
                        it.SubItems.Add(dr["PRENOM_CLIENT"].ToString());
                        it.SubItems.Add(dr["VILLE_CLIENT"].ToString());
                        it.SubItems.Add(dr["NUMERO_CLIENT"].ToString());
                        ClientView.Items.Add(it);

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                cm = new MySqlCommand("SELECT * FROM client WHERE CODE_CLIENT='" + cin + "'", connexion);
                try
                {

                    MySqlDataReader dr = cm.ExecuteReader();
                    ClientView.Items.Clear();
                    while (dr.Read())
                    {

                        ListViewItem it = new
                        ListViewItem(dr["CODE_CLIENT"].ToString());
                        it.SubItems.Add(dr["NOM_CLIENT"].ToString());
                        it.SubItems.Add(dr["PRENOM_CLIENT"].ToString());
                        it.SubItems.Add(dr["VILLE_CLIENT"].ToString());
                        it.SubItems.Add(dr["NUMERO_CLIENT"].ToString());
                        ClientView.Items.Add(it);

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
            String nom = nomClient.Texts;
            String prenom = prenomClient.Texts;
            String cin = cinClient.Texts;
            String ville = villeClient.Texts;
            String numero = numeroClient.Texts;
            String con = @"server=localhost;userid=root;password=;database=gestioncommande";
            if (cin != "" && prenom != "" && nom != "" && ville != "" && numero != "")
            {
                try
                {
                    var connexion = new MySqlConnection(con);

                    var cm = new MySqlCommand("UPDATE client SET CODE_CLIENT = @cin , NOM_CLIENT = @nom , PRENOM_CLIENT = @prenom , VILLE_CLIENT = @ville , NUMERO_CLIENT = @numero where CODE_CLIENT = '" + cin + "';", connexion);
                    cm.Parameters.AddWithValue("@cin", cin);
                    cm.Parameters.AddWithValue("@nom", nom);
                    cm.Parameters.AddWithValue("@prenom", prenom);
                    cm.Parameters.AddWithValue("@ville", ville);
                    cm.Parameters.AddWithValue("@numero", numero);
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
                MessageBox.Show("Veuillez remplir conformement les Champs ");
                rjButton6_Click(sender,e);
            }
        }

        private void btnSupprimer(object sender, EventArgs e)
        {
            String cin = cinClient.Texts;
            String con = @"server=localhost;userid=root;password=;database=gestioncommande";
            var connexion = new MySqlConnection(con);
            var connexion2 = new MySqlConnection(con);
            var connexion3 = new MySqlConnection(con);
            var connexion4 = new MySqlConnection(con);
            var connexion5 = new MySqlConnection(con);
            var cm = new MySqlCommand("delete FROM client where CODE_CLIENT = '" + cin + "';", connexion);
         
          var cm3 = new MySqlCommand(" SELECT * FROM commande WHERE CODE_CLIENT = '"+cin+"'",connexion3);
            MySqlDataReader myReader;
           
           MySqlDataReader myReader3;
          MySqlDataReader myReader4;
          if (cin != "")
          {

              try
              {
                  connexion.Open();
                  connexion3.Open();
                  connexion4.Open();
                  connexion5.Open();
                  myReader = cm.ExecuteReader();
                  MessageBox.Show("Le Client a la CIN " + cin + " a ete Supprime avec Succes ");

                  myReader3 = cm3.ExecuteReader();
                  while (myReader3.Read())
                  {
                      var cm4 = new MySqlCommand("delete * FROM contenir WHERE NUMCMDE ='" + myReader3["NUMCMDE"] + "'", connexion5);
                      myReader4 = cm4.ExecuteReader();
                  }
                  refresh();
                  myReader.Close();
                  myReader.Dispose();
                  myReader3.Close();
                  myReader3.Dispose();
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }
          }
          else
          {
              MessageBox.Show("Veuillez remplir le champs CIN_CLIENT ");
          }
           
            connexion.Close();
            connexion2.Close();
            connexion3.Close();
            connexion4.Close();
            connexion5.Close();
        }

        private void btnQuitter(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAjouter(object sender, EventArgs e)
        {
            String nom = nomClient.Texts;
            String prenom = prenomClient.Texts;
            String cin = cinClient.Texts;
            String ville = villeClient.Texts;
            String numero = numeroClient.Texts;
            if (cin != "" && prenom != "" && nom != "" && ville != "" && numero != "")
            {
                try
                {
                    String con = @"server=localhost;userid=root;password=;database=gestioncommande";
                    var connexion = new MySqlConnection(con);
                    connexion.Open();
                    var sql = "INSERT INTO client (CODE_CLIENT,NOM_CLIENT,PRENOM_CLIENT,VILLE_CLIENT,NUMERO_CLIENT) values (@cin,@nom,@prenom,@ville,@numero)";
                    var cmd = new MySqlCommand(sql, connexion);
                    cmd.Parameters.AddWithValue("@cin", cin);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@ville", ville);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    string[] row = { nom, prenom, cin, ville, numero };
                    var listViewItem = new ListViewItem(row);
                    ClientView.Items.Add(listViewItem);
                    refresh();
                    MessageBox.Show("Client Ajoute dans la base de donnee avec success");
                    rjButton6_Click(sender, e);
                    refresh();
                    connexion.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("UTILISATEUR EXISTANT OU ERREUR DE CONNEXION A LA DB ");
                }
            }
            else
            {
                MessageBox.Show("Veuillez Remplir Conformement les champs ");
                rjButton6_Click(sender, e);
            }
        }
    }
}
