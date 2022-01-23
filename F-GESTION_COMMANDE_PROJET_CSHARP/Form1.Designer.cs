namespace F_GESTION_COMMANDE_PROJET_CSHARP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnconsultaire = new System.Windows.Forms.Button();
            this.btndeconnexion = new System.Windows.Forms.Button();
            this.btninscription = new System.Windows.Forms.Button();
            this.btnficher = new System.Windows.Forms.Button();
            this.gestionSection = new System.Windows.Forms.Button();
            this.btnproduit = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclient = new System.Windows.Forms.Button();
            this.btncommande = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnclose = new dropdown.RJButton();
            this.btnsize = new dropdown.RJButton();
            this.btnminimise = new dropdown.RJButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btncloseactiveForm = new System.Windows.Forms.Button();
            this.Maintitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(94)))));
            this.panelMenu.Controls.Add(this.btnconsultaire);
            this.panelMenu.Controls.Add(this.btndeconnexion);
            this.panelMenu.Controls.Add(this.btninscription);
            this.panelMenu.Controls.Add(this.btnficher);
            this.panelMenu.Controls.Add(this.gestionSection);
            this.panelMenu.Controls.Add(this.btnproduit);
            this.panelMenu.Controls.Add(this.btnexit);
            this.panelMenu.Controls.Add(this.btnclient);
            this.panelMenu.Controls.Add(this.btncommande);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(261, 700);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnconsultaire
            // 
            this.btnconsultaire.FlatAppearance.BorderSize = 0;
            this.btnconsultaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultaire.ForeColor = System.Drawing.Color.White;
            this.btnconsultaire.Image = global::F_GESTION_COMMANDE_PROJET_CSHARP.Properties.Resources.icons8_consultation_30;
            this.btnconsultaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsultaire.Location = new System.Drawing.Point(3, 484);
            this.btnconsultaire.Name = "btnconsultaire";
            this.btnconsultaire.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnconsultaire.Size = new System.Drawing.Size(255, 63);
            this.btnconsultaire.TabIndex = 8;
            this.btnconsultaire.Text = "CONSULTAIRE";
            this.btnconsultaire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsultaire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnconsultaire.UseVisualStyleBackColor = true;
            this.btnconsultaire.Click += new System.EventHandler(this.btnconsultaire_Click);
            // 
            // btndeconnexion
            // 
            this.btndeconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndeconnexion.FlatAppearance.BorderSize = 0;
            this.btndeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeconnexion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btndeconnexion.Image = global::F_GESTION_COMMANDE_PROJET_CSHARP.Properties.Resources.icons8_disconnected_30;
            this.btndeconnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeconnexion.Location = new System.Drawing.Point(-3, 140);
            this.btndeconnexion.Name = "btndeconnexion";
            this.btndeconnexion.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btndeconnexion.Size = new System.Drawing.Size(258, 54);
            this.btndeconnexion.TabIndex = 3;
            this.btndeconnexion.Text = "DECONNEXION";
            this.btndeconnexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeconnexion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndeconnexion.UseVisualStyleBackColor = false;
            this.btndeconnexion.Click += new System.EventHandler(this.btndeconnexion_Click_1);
            // 
            // btninscription
            // 
            this.btninscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btninscription.FlatAppearance.BorderSize = 0;
            this.btninscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninscription.ForeColor = System.Drawing.Color.White;
            this.btninscription.Image = global::F_GESTION_COMMANDE_PROJET_CSHARP.Properties.Resources.icons8_sign_up_30;
            this.btninscription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninscription.Location = new System.Drawing.Point(5, 200);
            this.btninscription.Name = "btninscription";
            this.btninscription.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btninscription.Size = new System.Drawing.Size(258, 60);
            this.btninscription.TabIndex = 6;
            this.btninscription.Text = "    INSCRIPTION";
            this.btninscription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninscription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btninscription.UseVisualStyleBackColor = false;
            this.btninscription.Click += new System.EventHandler(this.btninscription_Click);
            // 
            // btnficher
            // 
            this.btnficher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(94)))));
            this.btnficher.FlatAppearance.BorderSize = 0;
            this.btnficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnficher.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnficher.Image = global::F_GESTION_COMMANDE_PROJET_CSHARP.Properties.Resources.fichier_30;
            this.btnficher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnficher.Location = new System.Drawing.Point(-2, 71);
            this.btnficher.Name = "btnficher";
            this.btnficher.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnficher.Size = new System.Drawing.Size(258, 63);
            this.btnficher.TabIndex = 1;
            this.btnficher.Text = "FICHER";
            this.btnficher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnficher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnficher.UseVisualStyleBackColor = false;
            this.btnficher.Click += new System.EventHandler(this.btnficher_Click);
            // 
            // gestionSection
            // 
            this.gestionSection.FlatAppearance.BorderSize = 0;
            this.gestionSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestionSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionSection.ForeColor = System.Drawing.Color.White;
            this.gestionSection.Image = global::F_GESTION_COMMANDE_PROJET_CSHARP.Properties.Resources.icons8_management_30;
            this.gestionSection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gestionSection.Location = new System.Drawing.Point(8, 266);
            this.gestionSection.Name = "gestionSection";
            this.gestionSection.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.gestionSection.Size = new System.Drawing.Size(255, 56);
            this.gestionSection.TabIndex = 7;
            this.gestionSection.Text = "GESTION";
            this.gestionSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gestionSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gestionSection.UseVisualStyleBackColor = true;
            // 
            // btnproduit
            // 
            this.btnproduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnproduit.FlatAppearance.BorderSize = 0;
            this.btnproduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduit.ForeColor = System.Drawing.Color.White;
            this.btnproduit.Image = global::F_GESTION_COMMANDE_PROJET_CSHARP.Properties.Resources.icons8_goods_30;
            this.btnproduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduit.Location = new System.Drawing.Point(5, 376);
            this.btnproduit.Name = "btnproduit";
            this.btnproduit.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnproduit.Size = new System.Drawing.Size(258, 40);
            this.btnproduit.TabIndex = 3;
            this.btnproduit.Text = "    GESTION PRODUIT";
            this.btnproduit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproduit.UseVisualStyleBackColor = false;
            this.btnproduit.Click += new System.EventHandler(this.btnproduit_Click);
            // 
            // btnexit
            // 
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Image = global::F_GESTION_COMMANDE_PROJET_CSHARP.Properties.Resources.cancel_48px;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(5, 553);
            this.btnexit.Name = "btnexit";
            this.btnexit.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnexit.Size = new System.Drawing.Size(253, 50);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "    EXIT";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclient
            // 
            this.btnclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclient.FlatAppearance.BorderSize = 0;
            this.btnclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclient.ForeColor = System.Drawing.Color.White;
            this.btnclient.Image = global::F_GESTION_COMMANDE_PROJET_CSHARP.Properties.Resources.gestion_des_clients_30;
            this.btnclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclient.Location = new System.Drawing.Point(3, 319);
            this.btnclient.Name = "btnclient";
            this.btnclient.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnclient.Size = new System.Drawing.Size(255, 51);
            this.btnclient.TabIndex = 2;
            this.btnclient.Text = "    GESTION CLIENT";
            this.btnclient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclient.UseVisualStyleBackColor = false;
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click);
            // 
            // btncommande
            // 
            this.btncommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncommande.FlatAppearance.BorderSize = 0;
            this.btncommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncommande.ForeColor = System.Drawing.Color.White;
            this.btncommande.Image = global::F_GESTION_COMMANDE_PROJET_CSHARP.Properties.Resources.icons8_delivery_30;
            this.btncommande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncommande.Location = new System.Drawing.Point(0, 422);
            this.btncommande.Name = "btncommande";
            this.btncommande.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btncommande.Size = new System.Drawing.Size(258, 56);
            this.btncommande.TabIndex = 4;
            this.btncommande.Text = "    GESTION COMMANDE";
            this.btncommande.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncommande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncommande.UseVisualStyleBackColor = false;
            this.btncommande.Click += new System.EventHandler(this.btncommande_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.panelLogo.Controls.Add(this.btnclose);
            this.panelLogo.Controls.Add(this.btnsize);
            this.panelLogo.Controls.Add(this.btnminimise);
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(261, 71);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.BackgroundColor = System.Drawing.Color.Red;
            this.btnclose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclose.BorderRadius = 10;
            this.btnclose.BorderSize = 0;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(62, 7);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(19, 21);
            this.btnclose.TabIndex = 2;
            this.btnclose.TextColor = System.Drawing.Color.White;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnsize
            // 
            this.btnsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsize.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsize.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnsize.BorderRadius = 10;
            this.btnsize.BorderSize = 0;
            this.btnsize.FlatAppearance.BorderSize = 0;
            this.btnsize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsize.ForeColor = System.Drawing.Color.White;
            this.btnsize.Location = new System.Drawing.Point(37, 7);
            this.btnsize.Name = "btnsize";
            this.btnsize.Size = new System.Drawing.Size(19, 21);
            this.btnsize.TabIndex = 4;
            this.btnsize.TextColor = System.Drawing.Color.White;
            this.btnsize.UseVisualStyleBackColor = false;
            this.btnsize.Click += new System.EventHandler(this.btnsize_Click);
            // 
            // btnminimise
            // 
            this.btnminimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimise.BackColor = System.Drawing.Color.Green;
            this.btnminimise.BackgroundColor = System.Drawing.Color.Green;
            this.btnminimise.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnminimise.BorderRadius = 10;
            this.btnminimise.BorderSize = 0;
            this.btnminimise.FlatAppearance.BorderSize = 0;
            this.btnminimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimise.ForeColor = System.Drawing.Color.White;
            this.btnminimise.Location = new System.Drawing.Point(12, 7);
            this.btnminimise.Name = "btnminimise";
            this.btnminimise.Size = new System.Drawing.Size(19, 21);
            this.btnminimise.TabIndex = 3;
            this.btnminimise.TextColor = System.Drawing.Color.White;
            this.btnminimise.UseVisualStyleBackColor = false;
            this.btnminimise.Click += new System.EventHandler(this.btnminimise_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::F_GESTION_COMMANDE_PROJET_CSHARP.Properties.Resources.delivery1;
            this.pictureBox2.Location = new System.Drawing.Point(172, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(180)))), ((int)(((byte)(251)))));
            this.panelTitleBar.Controls.Add(this.btncloseactiveForm);
            this.panelTitleBar.Controls.Add(this.Maintitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(261, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(787, 71);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btncloseactiveForm
            // 
            this.btncloseactiveForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btncloseactiveForm.FlatAppearance.BorderSize = 0;
            this.btncloseactiveForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncloseactiveForm.Image = global::F_GESTION_COMMANDE_PROJET_CSHARP.Properties.Resources.icons8_effacer_25;
            this.btncloseactiveForm.Location = new System.Drawing.Point(0, 0);
            this.btncloseactiveForm.Name = "btncloseactiveForm";
            this.btncloseactiveForm.Size = new System.Drawing.Size(75, 71);
            this.btncloseactiveForm.TabIndex = 1;
            this.btncloseactiveForm.UseVisualStyleBackColor = true;
            this.btncloseactiveForm.Click += new System.EventHandler(this.btncloseactiveForm_Click);
            // 
            // Maintitle
            // 
            this.Maintitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Maintitle.AutoSize = true;
            this.Maintitle.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maintitle.ForeColor = System.Drawing.Color.White;
            this.Maintitle.Location = new System.Drawing.Point(345, 11);
            this.Maintitle.Name = "Maintitle";
            this.Maintitle.Size = new System.Drawing.Size(89, 37);
            this.Maintitle.TabIndex = 0;
            this.Maintitle.Text = "HOME";
            this.Maintitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.AutoSize = true;
            this.panelDesktopPane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDesktopPane.BackColor = System.Drawing.Color.White;
            this.panelDesktopPane.Controls.Add(this.panel1);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(261, 71);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(787, 629);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(5, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 157);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION COMMANDE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::F_GESTION_COMMANDE_PROJET_CSHARP.Properties.Resources.express_delivery;
            this.pictureBox1.Location = new System.Drawing.Point(554, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 700);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnficher;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncommande;
        private System.Windows.Forms.Button btnproduit;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label Maintitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btninscription;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button gestionSection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btncloseactiveForm;
        private dropdown.RJButton btnminimise;
        private dropdown.RJButton btnsize;
        private dropdown.RJButton btnclose;
        private System.Windows.Forms.Button btndeconnexion;
        private System.Windows.Forms.Button btnconsultaire;
    }
}

