namespace F_GESTION_COMMANDE_PROJET_CSHARP.formulaire
{
    partial class GESTIONCOMMANDE
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
            this.gbcommande = new System.Windows.Forms.GroupBox();
            this.cinClientCommande = new dropdown.RJ_CONTROL.RJTextBox();
            this.numeroCommande = new dropdown.RJ_CONTROL.RJTextBox();
            this.labelNUM = new System.Windows.Forms.Label();
            this.dateCommande = new dropdown.RJ_CONTROL.RJDatePicker();
            this.labelCIN = new System.Windows.Forms.Label();
            this.labelDATE = new System.Windows.Forms.Label();
            this.rjButton5 = new dropdown.RJButton();
            this.rjButton2 = new dropdown.RJButton();
            this.rjButton1 = new dropdown.RJButton();
            this.rjButton3 = new dropdown.RJButton();
            this.rjButton4 = new dropdown.RJButton();
            this.Nouveau = new dropdown.RJButton();
            this.detailGroup = new System.Windows.Forms.GroupBox();
            this.referenceProduit = new dropdown.RJ_CONTROL.RJTextBox();
            this.labelreference = new System.Windows.Forms.Label();
            this.labelquantite = new System.Windows.Forms.Label();
            this.quantiteProduit = new dropdown.RJ_CONTROL.RJTextBox();
            this.CommandeView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rjButton11 = new dropdown.RJButton();
            this.rjButton7 = new dropdown.RJButton();
            this.rjButton10 = new dropdown.RJButton();
            this.rjButton8 = new dropdown.RJButton();
            this.rjButton9 = new dropdown.RJButton();
            this.gbcommande.SuspendLayout();
            this.detailGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbcommande
            // 
            this.gbcommande.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbcommande.Controls.Add(this.cinClientCommande);
            this.gbcommande.Controls.Add(this.numeroCommande);
            this.gbcommande.Controls.Add(this.labelNUM);
            this.gbcommande.Controls.Add(this.dateCommande);
            this.gbcommande.Controls.Add(this.labelCIN);
            this.gbcommande.Controls.Add(this.labelDATE);
            this.gbcommande.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbcommande.Location = new System.Drawing.Point(6, 12);
            this.gbcommande.Name = "gbcommande";
            this.gbcommande.Size = new System.Drawing.Size(431, 174);
            this.gbcommande.TabIndex = 1;
            this.gbcommande.TabStop = false;
            this.gbcommande.Text = "C O M M A N D E S";
            // 
            // cinClientCommande
            // 
            this.cinClientCommande.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cinClientCommande.AutoSize = true;
            this.cinClientCommande.BackColor = System.Drawing.SystemColors.Window;
            this.cinClientCommande.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.cinClientCommande.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(59)))), ((int)(((byte)(124)))));
            this.cinClientCommande.BorderRadius = 0;
            this.cinClientCommande.BorderSize = 2;
            this.cinClientCommande.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinClientCommande.Location = new System.Drawing.Point(169, 68);
            this.cinClientCommande.Multiline = false;
            this.cinClientCommande.Name = "cinClientCommande";
            this.cinClientCommande.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cinClientCommande.PasswordChar = false;
            this.cinClientCommande.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cinClientCommande.PlaceholderText = "Entre Votre CIN";
            this.cinClientCommande.Size = new System.Drawing.Size(200, 28);
            this.cinClientCommande.TabIndex = 79;
            this.cinClientCommande.Texts = "";
            this.cinClientCommande.UnderlinedStyle = false;
            // 
            // numeroCommande
            // 
            this.numeroCommande.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numeroCommande.AutoSize = true;
            this.numeroCommande.BackColor = System.Drawing.SystemColors.Window;
            this.numeroCommande.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.numeroCommande.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(59)))), ((int)(((byte)(124)))));
            this.numeroCommande.BorderRadius = 0;
            this.numeroCommande.BorderSize = 2;
            this.numeroCommande.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroCommande.Location = new System.Drawing.Point(170, 30);
            this.numeroCommande.Multiline = false;
            this.numeroCommande.Name = "numeroCommande";
            this.numeroCommande.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.numeroCommande.PasswordChar = false;
            this.numeroCommande.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.numeroCommande.PlaceholderText = "Numero Client";
            this.numeroCommande.Size = new System.Drawing.Size(200, 28);
            this.numeroCommande.TabIndex = 78;
            this.numeroCommande.Texts = "";
            this.numeroCommande.UnderlinedStyle = false;
            // 
            // labelNUM
            // 
            this.labelNUM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNUM.AutoSize = true;
            this.labelNUM.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNUM.Location = new System.Drawing.Point(83, 39);
            this.labelNUM.Name = "labelNUM";
            this.labelNUM.Size = new System.Drawing.Size(81, 19);
            this.labelNUM.TabIndex = 75;
            this.labelNUM.Text = "NUMERO :";
            // 
            // dateCommande
            // 
            this.dateCommande.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateCommande.BorderSize = 0;
            this.dateCommande.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCommande.Location = new System.Drawing.Point(170, 115);
            this.dateCommande.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateCommande.Name = "dateCommande";
            this.dateCommande.Size = new System.Drawing.Size(200, 35);
            this.dateCommande.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(94)))));
            this.dateCommande.TabIndex = 2;
            this.dateCommande.TextColor = System.Drawing.Color.White;
            // 
            // labelCIN
            // 
            this.labelCIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCIN.AutoSize = true;
            this.labelCIN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCIN.Location = new System.Drawing.Point(47, 77);
            this.labelCIN.Name = "labelCIN";
            this.labelCIN.Size = new System.Drawing.Size(117, 19);
            this.labelCIN.TabIndex = 76;
            this.labelCIN.Text = "CIN CLIENT :";
            // 
            // labelDATE
            // 
            this.labelDATE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDATE.AutoSize = true;
            this.labelDATE.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDATE.Location = new System.Drawing.Point(20, 128);
            this.labelDATE.Name = "labelDATE";
            this.labelDATE.Size = new System.Drawing.Size(144, 19);
            this.labelDATE.TabIndex = 77;
            this.labelDATE.Text = "DATE COMMANDE :";
            // 
            // rjButton5
            // 
            this.rjButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton5.AutoSize = true;
            this.rjButton5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton5.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton5.BorderRadius = 0;
            this.rjButton5.BorderSize = 0;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton5.ForeColor = System.Drawing.Color.White;
            this.rjButton5.Location = new System.Drawing.Point(443, 80);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(199, 36);
            this.rjButton5.TabIndex = 86;
            this.rjButton5.Text = "R E C H E R C H E R ";
            this.rjButton5.TextColor = System.Drawing.Color.White;
            this.rjButton5.UseVisualStyleBackColor = false;
            this.rjButton5.Click += new System.EventHandler(this.btnRechercherProduit);
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton2.AutoSize = true;
            this.rjButton2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(656, 80);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(199, 37);
            this.rjButton2.TabIndex = 85;
            this.rjButton2.Text = "S U P P R I M E R ";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.btnSupprimerCommande);
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton1.AutoSize = true;
            this.rjButton1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(656, 21);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(199, 37);
            this.rjButton1.TabIndex = 83;
            this.rjButton1.Text = "M O D I F I E R ";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.btnModifierCommande);
            // 
            // rjButton3
            // 
            this.rjButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton3.AutoSize = true;
            this.rjButton3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton3.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton3.BorderRadius = 0;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(443, 140);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(198, 36);
            this.rjButton3.TabIndex = 83;
            this.rjButton3.Text = "E N R E G I S T R E R ";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.btnRegisterCommande);
            // 
            // rjButton4
            // 
            this.rjButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton4.AutoSize = true;
            this.rjButton4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton4.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton4.BorderRadius = 0;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(657, 139);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(198, 37);
            this.rjButton4.TabIndex = 84;
            this.rjButton4.Text = "D E T A I L S ";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.addDetail);
            // 
            // Nouveau
            // 
            this.Nouveau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nouveau.AutoSize = true;
            this.Nouveau.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Nouveau.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Nouveau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Nouveau.BorderRadius = 0;
            this.Nouveau.BorderSize = 0;
            this.Nouveau.FlatAppearance.BorderSize = 0;
            this.Nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nouveau.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nouveau.ForeColor = System.Drawing.Color.White;
            this.Nouveau.Location = new System.Drawing.Point(443, 21);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(198, 37);
            this.Nouveau.TabIndex = 82;
            this.Nouveau.Text = "N O U V E A U ";
            this.Nouveau.TextColor = System.Drawing.Color.White;
            this.Nouveau.UseVisualStyleBackColor = false;
            this.Nouveau.Click += new System.EventHandler(this.NouveauC);
            // 
            // detailGroup
            // 
            this.detailGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.detailGroup.Controls.Add(this.referenceProduit);
            this.detailGroup.Controls.Add(this.labelreference);
            this.detailGroup.Controls.Add(this.labelquantite);
            this.detailGroup.Controls.Add(this.quantiteProduit);
            this.detailGroup.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailGroup.Location = new System.Drawing.Point(6, 203);
            this.detailGroup.Name = "detailGroup";
            this.detailGroup.Size = new System.Drawing.Size(429, 174);
            this.detailGroup.TabIndex = 2;
            this.detailGroup.TabStop = false;
            this.detailGroup.Text = "D E T A I L S ";
            // 
            // referenceProduit
            // 
            this.referenceProduit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.referenceProduit.AutoSize = true;
            this.referenceProduit.BackColor = System.Drawing.SystemColors.Window;
            this.referenceProduit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.referenceProduit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(59)))), ((int)(((byte)(124)))));
            this.referenceProduit.BorderRadius = 0;
            this.referenceProduit.BorderSize = 2;
            this.referenceProduit.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceProduit.Location = new System.Drawing.Point(170, 35);
            this.referenceProduit.Multiline = false;
            this.referenceProduit.Name = "referenceProduit";
            this.referenceProduit.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.referenceProduit.PasswordChar = false;
            this.referenceProduit.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.referenceProduit.PlaceholderText = "Reference Produit";
            this.referenceProduit.Size = new System.Drawing.Size(200, 28);
            this.referenceProduit.TabIndex = 97;
            this.referenceProduit.Texts = "";
            this.referenceProduit.UnderlinedStyle = false;
            // 
            // labelreference
            // 
            this.labelreference.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelreference.AutoSize = true;
            this.labelreference.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelreference.Location = new System.Drawing.Point(65, 44);
            this.labelreference.Name = "labelreference";
            this.labelreference.Size = new System.Drawing.Size(99, 19);
            this.labelreference.TabIndex = 96;
            this.labelreference.Text = "REFERENCE:";
            // 
            // labelquantite
            // 
            this.labelquantite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelquantite.AutoSize = true;
            this.labelquantite.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelquantite.Location = new System.Drawing.Point(64, 107);
            this.labelquantite.Name = "labelquantite";
            this.labelquantite.Size = new System.Drawing.Size(99, 19);
            this.labelquantite.TabIndex = 95;
            this.labelquantite.Text = "QUANTITE :";
            // 
            // quantiteProduit
            // 
            this.quantiteProduit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantiteProduit.AutoSize = true;
            this.quantiteProduit.BackColor = System.Drawing.SystemColors.Window;
            this.quantiteProduit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.quantiteProduit.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(59)))), ((int)(((byte)(124)))));
            this.quantiteProduit.BorderRadius = 0;
            this.quantiteProduit.BorderSize = 2;
            this.quantiteProduit.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiteProduit.Location = new System.Drawing.Point(170, 98);
            this.quantiteProduit.Multiline = false;
            this.quantiteProduit.Name = "quantiteProduit";
            this.quantiteProduit.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.quantiteProduit.PasswordChar = false;
            this.quantiteProduit.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.quantiteProduit.PlaceholderText = "Quantite Produit";
            this.quantiteProduit.Size = new System.Drawing.Size(200, 28);
            this.quantiteProduit.TabIndex = 94;
            this.quantiteProduit.Texts = "";
            this.quantiteProduit.UnderlinedStyle = false;
            // 
            // CommandeView
            // 
            this.CommandeView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CommandeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.CommandeView.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandeView.Location = new System.Drawing.Point(7, 383);
            this.CommandeView.Name = "CommandeView";
            this.CommandeView.Size = new System.Drawing.Size(848, 213);
            this.CommandeView.TabIndex = 2;
            this.CommandeView.UseCompatibleStateImageBehavior = false;
            this.CommandeView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "R E F E R E N C E ";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "I N T I T U L E ";
            this.columnHeader3.Width = 206;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "P R I X   U N I T A I R E ";
            this.columnHeader4.Width = 247;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Q U A N T I T E ";
            this.columnHeader5.Width = 178;
            // 
            // rjButton11
            // 
            this.rjButton11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton11.AutoSize = true;
            this.rjButton11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton11.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton11.BorderRadius = 0;
            this.rjButton11.BorderSize = 0;
            this.rjButton11.FlatAppearance.BorderSize = 0;
            this.rjButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton11.ForeColor = System.Drawing.Color.White;
            this.rjButton11.Location = new System.Drawing.Point(443, 218);
            this.rjButton11.Name = "rjButton11";
            this.rjButton11.Size = new System.Drawing.Size(198, 37);
            this.rjButton11.TabIndex = 87;
            this.rjButton11.Text = "N O U V E A U ";
            this.rjButton11.TextColor = System.Drawing.Color.White;
            this.rjButton11.UseVisualStyleBackColor = false;
            this.rjButton11.Click += new System.EventHandler(this.NouveauD);
            // 
            // rjButton7
            // 
            this.rjButton7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton7.AutoSize = true;
            this.rjButton7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton7.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton7.BorderRadius = 0;
            this.rjButton7.BorderSize = 0;
            this.rjButton7.FlatAppearance.BorderSize = 0;
            this.rjButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton7.ForeColor = System.Drawing.Color.White;
            this.rjButton7.Location = new System.Drawing.Point(656, 269);
            this.rjButton7.Name = "rjButton7";
            this.rjButton7.Size = new System.Drawing.Size(199, 37);
            this.rjButton7.TabIndex = 91;
            this.rjButton7.Text = "M O D I F I E R ";
            this.rjButton7.TextColor = System.Drawing.Color.White;
            this.rjButton7.UseVisualStyleBackColor = false;
            this.rjButton7.Click += new System.EventHandler(this.btnModifierDetail);
            // 
            // rjButton10
            // 
            this.rjButton10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton10.AutoSize = true;
            this.rjButton10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton10.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton10.BorderRadius = 0;
            this.rjButton10.BorderSize = 0;
            this.rjButton10.FlatAppearance.BorderSize = 0;
            this.rjButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton10.ForeColor = System.Drawing.Color.White;
            this.rjButton10.Location = new System.Drawing.Point(443, 269);
            this.rjButton10.Name = "rjButton10";
            this.rjButton10.Size = new System.Drawing.Size(198, 37);
            this.rjButton10.TabIndex = 90;
            this.rjButton10.Text = "A J O U T E R ";
            this.rjButton10.TextColor = System.Drawing.Color.White;
            this.rjButton10.UseVisualStyleBackColor = false;
            this.rjButton10.Click += new System.EventHandler(this.btnAjouterDetail);
            // 
            // rjButton8
            // 
            this.rjButton8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton8.AutoSize = true;
            this.rjButton8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton8.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton8.BorderRadius = 0;
            this.rjButton8.BorderSize = 0;
            this.rjButton8.FlatAppearance.BorderSize = 0;
            this.rjButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton8.ForeColor = System.Drawing.Color.White;
            this.rjButton8.Location = new System.Drawing.Point(656, 218);
            this.rjButton8.Name = "rjButton8";
            this.rjButton8.Size = new System.Drawing.Size(199, 37);
            this.rjButton8.TabIndex = 88;
            this.rjButton8.Text = "E N L E V E R ";
            this.rjButton8.TextColor = System.Drawing.Color.White;
            this.rjButton8.UseVisualStyleBackColor = false;
            this.rjButton8.Click += new System.EventHandler(this.btnRemoveDetail);
            // 
            // rjButton9
            // 
            this.rjButton9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton9.AutoSize = true;
            this.rjButton9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton9.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButton9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rjButton9.BorderRadius = 0;
            this.rjButton9.BorderSize = 0;
            this.rjButton9.FlatAppearance.BorderSize = 0;
            this.rjButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton9.ForeColor = System.Drawing.Color.White;
            this.rjButton9.Location = new System.Drawing.Point(441, 327);
            this.rjButton9.Name = "rjButton9";
            this.rjButton9.Size = new System.Drawing.Size(414, 36);
            this.rjButton9.TabIndex = 89;
            this.rjButton9.Text = "T  E  R  M  I  N  E  R ";
            this.rjButton9.TextColor = System.Drawing.Color.White;
            this.rjButton9.UseVisualStyleBackColor = false;
            this.rjButton9.Click += new System.EventHandler(this.btnTerminer);
            // 
            // GESTIONCOMMANDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 631);
            this.Controls.Add(this.CommandeView);
            this.Controls.Add(this.rjButton11);
            this.Controls.Add(this.rjButton7);
            this.Controls.Add(this.rjButton5);
            this.Controls.Add(this.rjButton10);
            this.Controls.Add(this.detailGroup);
            this.Controls.Add(this.rjButton8);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton9);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.gbcommande);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.rjButton4);
            this.Name = "GESTIONCOMMANDE";
            this.Text = "GESTIONCOMMANDE";
            this.gbcommande.ResumeLayout(false);
            this.gbcommande.PerformLayout();
            this.detailGroup.ResumeLayout(false);
            this.detailGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbcommande;
        private dropdown.RJButton rjButton5;
        private dropdown.RJButton rjButton2;
        private dropdown.RJButton rjButton1;
        private dropdown.RJButton rjButton3;
        private dropdown.RJButton rjButton4;
        private dropdown.RJButton Nouveau;
        private System.Windows.Forms.GroupBox detailGroup;
        private System.Windows.Forms.ListView CommandeView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label labelquantite;
        private dropdown.RJ_CONTROL.RJTextBox quantiteProduit;
        private dropdown.RJButton rjButton11;
        private dropdown.RJButton rjButton7;
        private dropdown.RJButton rjButton10;
        private dropdown.RJButton rjButton8;
        private dropdown.RJButton rjButton9;
        private System.Windows.Forms.Label labelreference;
        private dropdown.RJ_CONTROL.RJTextBox cinClientCommande;
        private dropdown.RJ_CONTROL.RJTextBox numeroCommande;
        private System.Windows.Forms.Label labelNUM;
        private dropdown.RJ_CONTROL.RJDatePicker dateCommande;
        private System.Windows.Forms.Label labelCIN;
        private System.Windows.Forms.Label labelDATE;
        private dropdown.RJ_CONTROL.RJTextBox referenceProduit;
    }
}