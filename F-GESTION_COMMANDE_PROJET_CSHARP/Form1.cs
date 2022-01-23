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
using System.Runtime.InteropServices;
namespace F_GESTION_COMMANDE_PROJET_CSHARP
{
    public partial class Form1 : Form
    {

        //field
        private Button currentbutton;  //the button that is just click
        private Random random; //willl be use in generating randomly our colours
        private int tempIndex; //the index in the colour table
        private Form activeForm;
       

        //contructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btncloseactiveForm.Visible = false;

            //here we will remove the window bar
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        /**
          DRAG FORM PROPERTIES WILL BE ADDED HERE
         */

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Method

        // this method permit us to change from color to color
        private Color SelectThemeColor() 
        {
            int Index = random.Next(ThemeColor.ColorList.Count); //here we are Acccessing the THeme class Color list Randomly
           //here we change the value of tempidex if it is same with colorIndex
            while (tempIndex == Index) 
            {
              Index= random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = Index;
            string color = ThemeColor.ColorList[Index];
            return ColorTranslator.FromHtml(color); // here it return the HTML code of the colour that is randomly generated
        }

        private void ActivateButton(object btnsender) 
        {
            if (btnsender != null) // if a sender is send to the function 
            {
                if (currentbutton != (Button)btnsender) // if the current button is diff from the button just click
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentbutton = (Button)btnsender;
                    currentbutton.BackColor = color;
                    currentbutton.ForeColor = Color.White;
                    currentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif",9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    panelTitleBar.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.TextColor = ThemeColor.ChangeColorBrightness(color, -0.5);
                    btncloseactiveForm.Visible = true;
                }
            }
        }

        private void DisableButton() 
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button)) 
                {
                    previousBtn.BackColor = Color.FromArgb(49, 51, 94);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        /**
         * 
         this function will help us to change from one form toanother form only in the panel desire
         * which will be panelDesktop
         */
        public void OpenChildForm(Form childForm, object btnsender) 
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.AutoSize = true;
            this.panelDesktopPane.Controls.Add(childForm); //this is where we add on the panelDEsktop the form we want to add to the window
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Maintitle.Text = childForm.Text;// the maintitle is converted to the name of the childform

        }



        //Button action 

        private void btnficher_Click(object sender, EventArgs e)
        {
       
           
        }

     
        private void btnclient_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new formulaire.GESTIONCLIENT(), sender);
        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new formulaire.GESTIONPRODUITS(), sender);
            
        }

        private void btncommande_Click(object sender, EventArgs e)
        {

            ActivateButton(sender);
            OpenChildForm(new formulaire.GESTIONCOMMANDE(), sender);

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Close();
        }

        private void btninscription_Click(object sender, EventArgs e)
        {
            
          
         
            Maintitle.Text = "";
            panelLogo.BackColor = Color.FromArgb(32, 34, 62);
            panelTitleBar.BackColor = Color.FromArgb(128, 180, 251);
            currentbutton = null;
            OpenChildForm(new formulaire.INSCRIPTION(), sender);
           
        }

        private void cONNEXIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

          ActivateButton(sender);
            OpenChildForm(new formulaire.CONNEXION(), sender);
        }

        private void btnconnexion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new formulaire.CONNEXION(), sender);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void btncloseactiveForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            reset(sender);

        }

        private void reset(object sender)
        {
           
            Maintitle.Text = "HOME";
            panelLogo.BackColor = Color.FromArgb(32, 34, 62);
            panelTitleBar.BackColor = Color.FromArgb(128, 180, 251);
            currentbutton = null;
            OpenChildForm(new formulaire.MAINPAGE(), sender);
            btncloseactiveForm.Visible = false;

        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnminimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndeconnexion_Click_1(object sender, EventArgs e)
        {
            formulaire.CONNEXION con = new formulaire.CONNEXION();
            this.Hide();
            con.Show();
            Maintitle.Text = "DECONNEXION";
            panelLogo.BackColor = Color.FromArgb(32, 34, 62);
            panelTitleBar.BackColor = Color.FromArgb(128, 180, 251);
            currentbutton = null;
            OpenChildForm(new formulaire.DECONNEXION(), sender);
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnconsultaire_Click(object sender, EventArgs e)
        {
              Maintitle.Text = "CONSULTAIRE";
            panelLogo.BackColor = Color.FromArgb(32, 34, 62);
            panelTitleBar.BackColor = Color.FromArgb(128, 180, 251);
            currentbutton = null;
            OpenChildForm(new formulaire.CONSULTAIRE(), sender);
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

   

        

     
    }
}
