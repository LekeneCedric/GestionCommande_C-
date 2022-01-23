namespace F_GESTION_COMMANDE_PROJET_CSHARP.formulaire
{
    partial class GESTIONCLIENT
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
            this.labelNUM = new System.Windows.Forms.Label();
            this.labelLOGIN = new System.Windows.Forms.Label();
            this.labelPRENOM = new System.Windows.Forms.Label();
            this.labelNOM = new System.Windows.Forms.Label();
            this.labelCIN = new System.Windows.Forms.Label();
            this.numeroClient = new dropdown.RJ_CONTROL.RJTextBox();
            this.nomClient = new dropdown.RJ_CONTROL.RJTextBox();
            this.prenomClient = new dropdown.RJ_CONTROL.RJTextBox();
            this.villeClient = new dropdown.RJ_CONTROL.RJTextBox();
            this.cinClient = new dropdown.RJ_CONTROL.RJTextBox();
            this.btninscription = new dropdown.RJButton();
            this.rjButton2 = new dropdown.RJButton();
            this.rjButton3 = new dropdown.RJButton();
            this.ClientView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnnouveau = new dropdown.RJButton();
            this.rjButton4 = new dropdown.RJButton();
            this.SuspendLayout();
            // 
            // labelNUM
            // 
            this.labelNUM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNUM.AutoSize = true;
            this.labelNUM.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNUM.Location = new System.Drawing.Point(264, 221);
            this.labelNUM.Name = "labelNUM";
            this.labelNUM.Size = new System.Drawing.Size(130, 22);
            this.labelNUM.TabIndex = 76;
            this.labelNUM.Text = "NUMERO TEL :";
            // 
            // labelLOGIN
            // 
            this.labelLOGIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLOGIN.AutoSize = true;
            this.labelLOGIN.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLOGIN.Location = new System.Drawing.Point(324, 175);
            this.labelLOGIN.Name = "labelLOGIN";
            this.labelLOGIN.Size = new System.Drawing.Size(70, 22);
            this.labelLOGIN.TabIndex = 75;
            this.labelLOGIN.Text = "VILLE:";
            // 
            // labelPRENOM
            // 
            this.labelPRENOM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPRENOM.AutoSize = true;
            this.labelPRENOM.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPRENOM.Location = new System.Drawing.Point(304, 123);
            this.labelPRENOM.Name = "labelPRENOM";
            this.labelPRENOM.Size = new System.Drawing.Size(90, 22);
            this.labelPRENOM.TabIndex = 74;
            this.labelPRENOM.Text = "PRENOM :";
            // 
            // labelNOM
            // 
            this.labelNOM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNOM.AutoSize = true;
            this.labelNOM.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNOM.Location = new System.Drawing.Point(334, 69);
            this.labelNOM.Name = "labelNOM";
            this.labelNOM.Size = new System.Drawing.Size(60, 22);
            this.labelNOM.TabIndex = 73;
            this.labelNOM.Text = "NOM :";
            // 
            // labelCIN
            // 
            this.labelCIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCIN.AutoSize = true;
            this.labelCIN.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCIN.Location = new System.Drawing.Point(334, 23);
            this.labelCIN.Name = "labelCIN";
            this.labelCIN.Size = new System.Drawing.Size(60, 22);
            this.labelCIN.TabIndex = 72;
            this.labelCIN.Text = "CIN :";
            // 
            // numeroClient
            // 
            this.numeroClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numeroClient.AutoSize = true;
            this.numeroClient.BackColor = System.Drawing.SystemColors.Window;
            this.numeroClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.numeroClient.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(59)))), ((int)(((byte)(124)))));
            this.numeroClient.BorderRadius = 0;
            this.numeroClient.BorderSize = 2;
            this.numeroClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroClient.Location = new System.Drawing.Point(400, 215);
            this.numeroClient.Multiline = false;
            this.numeroClient.Name = "numeroClient";
            this.numeroClient.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.numeroClient.PasswordChar = false;
            this.numeroClient.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.numeroClient.PlaceholderText = "Entre Votre Numero";
            this.numeroClient.Size = new System.Drawing.Size(234, 28);
            this.numeroClient.TabIndex = 70;
            this.numeroClient.Texts = "";
            this.numeroClient.UnderlinedStyle = false;
            this.numeroClient._TextChanged += new System.EventHandler(this.txttel__TextChanged);
            // 
            // nomClient
            // 
            this.nomClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomClient.AutoSize = true;
            this.nomClient.BackColor = System.Drawing.SystemColors.Window;
            this.nomClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.nomClient.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(59)))), ((int)(((byte)(124)))));
            this.nomClient.BorderRadius = 0;
            this.nomClient.BorderSize = 2;
            this.nomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomClient.Location = new System.Drawing.Point(400, 63);
            this.nomClient.Multiline = false;
            this.nomClient.Name = "nomClient";
            this.nomClient.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nomClient.PasswordChar = false;
            this.nomClient.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.nomClient.PlaceholderText = "Entre Votre Nom";
            this.nomClient.Size = new System.Drawing.Size(234, 28);
            this.nomClient.TabIndex = 69;
            this.nomClient.Texts = "";
            this.nomClient.UnderlinedStyle = false;
            // 
            // prenomClient
            // 
            this.prenomClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prenomClient.AutoSize = true;
            this.prenomClient.BackColor = System.Drawing.SystemColors.Window;
            this.prenomClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.prenomClient.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(59)))), ((int)(((byte)(124)))));
            this.prenomClient.BorderRadius = 0;
            this.prenomClient.BorderSize = 2;
            this.prenomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomClient.Location = new System.Drawing.Point(400, 117);
            this.prenomClient.Multiline = false;
            this.prenomClient.Name = "prenomClient";
            this.prenomClient.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.prenomClient.PasswordChar = false;
            this.prenomClient.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.prenomClient.PlaceholderText = "Entre Votre Prenom";
            this.prenomClient.Size = new System.Drawing.Size(234, 28);
            this.prenomClient.TabIndex = 68;
            this.prenomClient.Texts = "";
            this.prenomClient.UnderlinedStyle = false;
            // 
            // villeClient
            // 
            this.villeClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.villeClient.AutoSize = true;
            this.villeClient.BackColor = System.Drawing.SystemColors.Window;
            this.villeClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.villeClient.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(59)))), ((int)(((byte)(124)))));
            this.villeClient.BorderRadius = 0;
            this.villeClient.BorderSize = 2;
            this.villeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.villeClient.Location = new System.Drawing.Point(400, 169);
            this.villeClient.Multiline = false;
            this.villeClient.Name = "villeClient";
            this.villeClient.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.villeClient.PasswordChar = false;
            this.villeClient.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.villeClient.PlaceholderText = "Entre Votre Ville";
            this.villeClient.Size = new System.Drawing.Size(234, 28);
            this.villeClient.TabIndex = 67;
            this.villeClient.Texts = "";
            this.villeClient.UnderlinedStyle = false;
            // 
            // cinClient
            // 
            this.cinClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cinClient.AutoSize = true;
            this.cinClient.BackColor = System.Drawing.SystemColors.Window;
            this.cinClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.cinClient.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(59)))), ((int)(((byte)(124)))));
            this.cinClient.BorderRadius = 0;
            this.cinClient.BorderSize = 2;
            this.cinClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinClient.Location = new System.Drawing.Point(400, 17);
            this.cinClient.Multiline = false;
            this.cinClient.Name = "cinClient";
            this.cinClient.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cinClient.PasswordChar = false;
            this.cinClient.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cinClient.PlaceholderText = "Entre Votre CIN";
            this.cinClient.Size = new System.Drawing.Size(234, 28);
            this.cinClient.TabIndex = 66;
            this.cinClient.Texts = "";
            this.cinClient.UnderlinedStyle = false;
            // 
            // btninscription
            // 
            this.btninscription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btninscription.AutoSize = true;
            this.btninscription.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btninscription.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.btninscription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btninscription.BorderRadius = 0;
            this.btninscription.BorderSize = 0;
            this.btninscription.FlatAppearance.BorderSize = 0;
            this.btninscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninscription.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninscription.ForeColor = System.Drawing.Color.White;
            this.btninscription.Location = new System.Drawing.Point(703, 87);
            this.btninscription.Name = "btninscription";
            this.btninscription.Size = new System.Drawing.Size(186, 29);
            this.btninscription.TabIndex = 77;
            this.btninscription.Text = "RECHERCHE";
            this.btninscription.TextColor = System.Drawing.Color.White;
            this.btninscription.UseVisualStyleBackColor = false;
            this.btninscription.Click += new System.EventHandler(this.btnRecherche);
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
            this.rjButton2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(703, 191);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(186, 29);
            this.rjButton2.TabIndex = 79;
            this.rjButton2.Text = "SUPPRIMER";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.btnSupprimer);
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
            this.rjButton3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(703, 139);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(186, 29);
            this.rjButton3.TabIndex = 80;
            this.rjButton3.Text = "MODIFIER";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.btnModifier);
            // 
            // ClientView
            // 
            this.ClientView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClientView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ClientView.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientView.Location = new System.Drawing.Point(52, 308);
            this.ClientView.Name = "ClientView";
            this.ClientView.Size = new System.Drawing.Size(848, 277);
            this.ClientView.TabIndex = 83;
            this.ClientView.UseCompatibleStateImageBehavior = false;
            this.ClientView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "C I N ";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "N O M ";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = " P R E N O M ";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 190;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "V I L L E ";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 173;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "N U M E R O ";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 160;
            // 
            // btnnouveau
            // 
            this.btnnouveau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnnouveau.AutoSize = true;
            this.btnnouveau.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnnouveau.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnnouveau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnnouveau.BorderRadius = 0;
            this.btnnouveau.BorderSize = 0;
            this.btnnouveau.FlatAppearance.BorderSize = 0;
            this.btnnouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnouveau.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnouveau.ForeColor = System.Drawing.Color.White;
            this.btnnouveau.Location = new System.Drawing.Point(703, 39);
            this.btnnouveau.Name = "btnnouveau";
            this.btnnouveau.Size = new System.Drawing.Size(186, 29);
            this.btnnouveau.TabIndex = 84;
            this.btnnouveau.Text = "NOUVEAU";
            this.btnnouveau.TextColor = System.Drawing.Color.White;
            this.btnnouveau.UseVisualStyleBackColor = false;
            this.btnnouveau.Click += new System.EventHandler(this.rjButton6_Click);
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
            this.rjButton4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(400, 259);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(234, 29);
            this.rjButton4.TabIndex = 100;
            this.rjButton4.Text = "AJOUTER";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.btnAjouter);
            // 
            // GESTIONCLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 597);
            this.Controls.Add(this.rjButton4);
            this.Controls.Add(this.btnnouveau);
            this.Controls.Add(this.ClientView);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.btninscription);
            this.Controls.Add(this.labelNUM);
            this.Controls.Add(this.labelLOGIN);
            this.Controls.Add(this.labelPRENOM);
            this.Controls.Add(this.labelNOM);
            this.Controls.Add(this.labelCIN);
            this.Controls.Add(this.numeroClient);
            this.Controls.Add(this.nomClient);
            this.Controls.Add(this.prenomClient);
            this.Controls.Add(this.villeClient);
            this.Controls.Add(this.cinClient);
            this.Name = "GESTIONCLIENT";
            this.Text = "GESTIONCLIENT";
            this.Load += new System.EventHandler(this.GESTIONCLIENT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNUM;
        private System.Windows.Forms.Label labelLOGIN;
        private System.Windows.Forms.Label labelPRENOM;
        private System.Windows.Forms.Label labelNOM;
        private System.Windows.Forms.Label labelCIN;
        private dropdown.RJ_CONTROL.RJTextBox numeroClient;
        private dropdown.RJ_CONTROL.RJTextBox nomClient;
        private dropdown.RJ_CONTROL.RJTextBox prenomClient;
        private dropdown.RJ_CONTROL.RJTextBox villeClient;
        private dropdown.RJ_CONTROL.RJTextBox cinClient;
        private dropdown.RJButton btninscription;
        private dropdown.RJButton rjButton2;
        private dropdown.RJButton rjButton3;
        private System.Windows.Forms.ListView ClientView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private dropdown.RJButton btnnouveau;
        private dropdown.RJButton rjButton4;
    }
}