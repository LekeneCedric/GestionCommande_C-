using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dropdown.RJ_CONTROL;
using dropdown;
using MySql.Data.MySqlClient;
namespace F_GESTION_COMMANDE_PROJET_CSHARP.formulaire
{
    public partial class CONNEXION : Form
    {
        
        public CONNEXION()
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

            labelText.ForeColor = ThemeColor.TextColor;
            labelPASSE.ForeColor = ThemeColor.TextColor; 
           
      
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(username.Texts);
        }

        private void CONNEXION_Load(object sender, EventArgs e)
        {

        }

        private void btnConnexion(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void switchInscription(object sender, EventArgs e)
        {
            INSCRIPTION ins = new INSCRIPTION();
            this.Hide();
            ins.Show();
        }

        private void btnConnxion(object sender, EventArgs e)
        {

            String con = @"server=localhost;userid=root;password=;database=gestioncommande";
            var connexion = new MySqlConnection(con);
            connexion.Open();
            MySqlCommand cm;
            String login = username.Texts;
            String mdp = password.Texts;
            if (login != "" && mdp != "")
            {
                cm = new MySqlCommand("SELECT * FROM client WHERE NOM_CLIENT = '" + login + "' AND  CODE_CLIENT = '" + mdp + "'", connexion);
                try
                {
                    MySqlDataReader dr = cm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        Form1 form = new Form1();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Utilisateur innexistant veuillez vous Inscrire ");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Remplissez les champs de saisies");
            }
        }

      
    }
}
