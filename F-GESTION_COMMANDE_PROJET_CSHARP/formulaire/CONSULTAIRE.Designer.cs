namespace F_GESTION_COMMANDE_PROJET_CSHARP.formulaire
{
    partial class CONSULTAIRE
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
            this.btndetails = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.DetailView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbcommande = new System.Windows.Forms.GroupBox();
            this.CommandeView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbcin = new System.Windows.Forms.GroupBox();
            this.cinClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btndetails.SuspendLayout();
            this.gbcommande.SuspendLayout();
            this.gbcin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndetails
            // 
            this.btndetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndetails.Controls.Add(this.label2);
            this.btndetails.Controls.Add(this.TotalBox);
            this.btndetails.Controls.Add(this.DetailView);
            this.btndetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.btndetails.Location = new System.Drawing.Point(18, 321);
            this.btndetails.Name = "btndetails";
            this.btndetails.Size = new System.Drawing.Size(848, 216);
            this.btndetails.TabIndex = 5;
            this.btndetails.TabStop = false;
            this.btndetails.Text = "D E T A I L S ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(611, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "T O T A L ";
            // 
            // TotalBox
            // 
            this.TotalBox.Enabled = false;
            this.TotalBox.Location = new System.Drawing.Point(684, 191);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(157, 20);
            this.TotalBox.TabIndex = 2;
            // 
            // DetailView
            // 
            this.DetailView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DetailView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.DetailView.Location = new System.Drawing.Point(7, 20);
            this.DetailView.Name = "DetailView";
            this.DetailView.Size = new System.Drawing.Size(834, 165);
            this.DetailView.TabIndex = 0;
            this.DetailView.UseCompatibleStateImageBehavior = false;
            this.DetailView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "R E F E R E N C E ";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "I N T I T U L E ";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "P R I X   U N I T A I R E ";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "S O U S   T O T A L ";
            this.columnHeader6.Width = 200;
            // 
            // gbcommande
            // 
            this.gbcommande.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbcommande.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbcommande.Controls.Add(this.CommandeView);
            this.gbcommande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.gbcommande.Location = new System.Drawing.Point(18, 90);
            this.gbcommande.Name = "gbcommande";
            this.gbcommande.Size = new System.Drawing.Size(848, 225);
            this.gbcommande.TabIndex = 4;
            this.gbcommande.TabStop = false;
            this.gbcommande.Text = "C O M M A N D E ";
            // 
            // CommandeView
            // 
            this.CommandeView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CommandeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.CommandeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(101)))));
            this.CommandeView.Location = new System.Drawing.Point(6, 19);
            this.CommandeView.Name = "CommandeView";
            this.CommandeView.Size = new System.Drawing.Size(835, 200);
            this.CommandeView.TabIndex = 0;
            this.CommandeView.UseCompatibleStateImageBehavior = false;
            this.CommandeView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NUMERO COMMANDE";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DATE COMMANDE";
            this.columnHeader2.Width = 150;
            // 
            // gbcin
            // 
            this.gbcin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbcin.Controls.Add(this.cinClient);
            this.gbcin.Controls.Add(this.label1);
            this.gbcin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.gbcin.Location = new System.Drawing.Point(18, 24);
            this.gbcin.Name = "gbcin";
            this.gbcin.Size = new System.Drawing.Size(590, 60);
            this.gbcin.TabIndex = 3;
            this.gbcin.TabStop = false;
            this.gbcin.Text = "C   I    N  ";
            // 
            // cinClient
            // 
            this.cinClient.Location = new System.Drawing.Point(330, 27);
            this.cinClient.Name = "cinClient";
            this.cinClient.Size = new System.Drawing.Size(233, 20);
            this.cinClient.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENREZ VOTRE CIN : ";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(180)))), ((int)(((byte)(251)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(632, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "V A L I D E R ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnValider);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(180)))), ((int)(((byte)(251)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(741, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "ANNULER";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // CONSULTAIRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndetails);
            this.Controls.Add(this.gbcommande);
            this.Controls.Add(this.gbcin);
            this.Name = "CONSULTAIRE";
            this.Text = "CONSULTAIRE";
            this.btndetails.ResumeLayout(false);
            this.btndetails.PerformLayout();
            this.gbcommande.ResumeLayout(false);
            this.gbcin.ResumeLayout(false);
            this.gbcin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox btndetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.ListView DetailView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox gbcommande;
        private System.Windows.Forms.ListView CommandeView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox gbcin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cinClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}