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
    public partial class INSCRIPTION : Form
    {
        public INSCRIPTION()
        {
            InitializeComponent();
            LoadTheme();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

          //  labelmenu.ForeColor = ThemeColor.PrimaryColor;
            labelCIN.ForeColor = ThemeColor.TextColor;
            labelNOM.ForeColor = ThemeColor.TextColor;
            labelPRENOM.ForeColor = ThemeColor.TextColor;
            labelLOGIN.ForeColor = ThemeColor.TextColor;
            labelNUM.ForeColor = ThemeColor.TextColor; 

        }

        private void btninscription_Click(object sender, EventArgs e)
        {
            
        }

        private void labelText_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void switchInscription(object sender, EventArgs e)
        {
            CONNEXION con = new CONNEXION();
            this.Hide();
            con.Show();
        }

        private void btnInscription(object sender, EventArgs e)
        {

        }

        private void inscrire(object sender, EventArgs e)
        {
            String nomU = nom.Texts;
            String prenomU = prenom.Texts;
            String cinU = cin.Texts;
            String villeU = ville.Texts;
            String numeroU = numero.Texts;
            try
            {
                String con = @"server=localhost;userid=root;password=;database=gestioncommande";
                var connexion = new MySqlConnection(con);
                connexion.Open();
                var sql = "INSERT INTO client (CODE_CLIENT,NOM_CLIENT,PRENOM_CLIENT,VILLE_CLIENT,NUMERO_CLIENT) values (@cin,@nom,@prenom,@ville,@numero)";
                var cmd = new MySqlCommand(sql, connexion);
                cmd.Parameters.AddWithValue("@cin", cinU);
                cmd.Parameters.AddWithValue("@nom", nomU);
                cmd.Parameters.AddWithValue("@prenom", prenomU);
                cmd.Parameters.AddWithValue("@ville", villeU);
                cmd.Parameters.AddWithValue("@numero", numeroU);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Utilisateur inscris dans la base de donnee avec success");

                connexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("UTILISATEUR EXISTANT OU ERREUR DE CONNEXION A LA DB ");
            }
        }
    }

}
