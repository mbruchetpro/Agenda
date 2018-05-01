namespace Agenda
{
    partial class FrmAgenda
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            this.grpRappel = new System.Windows.Forms.GroupBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.txtRappel = new System.Windows.Forms.TextBox();
            this.cboFrequence = new System.Windows.Forms.ComboBox();
            this.dtpHeure = new System.Windows.Forms.DateTimePicker();
            this.dtpJour = new System.Windows.Forms.DateTimePicker();
            this.grpMaintenant = new System.Windows.Forms.GroupBox();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpEnsemble = new System.Windows.Forms.GroupBox();
            this.lblAnnuel = new System.Windows.Forms.Label();
            this.lblMensuel = new System.Windows.Forms.Label();
            this.lblHebdomadaire = new System.Windows.Forms.Label();
            this.lblJournalier = new System.Windows.Forms.Label();
            this.lblUnique = new System.Windows.Forms.Label();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.lstEnsemble = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tmrRappel = new System.Windows.Forms.Timer(this.components);
            this.icoAgenda = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnMini = new System.Windows.Forms.Button();
            this.grpRappel.SuspendLayout();
            this.grpMaintenant.SuspendLayout();
            this.grpEnsemble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRappel
            // 
            this.grpRappel.Controls.Add(this.btnAjout);
            this.grpRappel.Controls.Add(this.txtRappel);
            this.grpRappel.Controls.Add(this.cboFrequence);
            this.grpRappel.Controls.Add(this.dtpHeure);
            this.grpRappel.Controls.Add(this.dtpJour);
            this.grpRappel.Location = new System.Drawing.Point(12, 12);
            this.grpRappel.Name = "grpRappel";
            this.grpRappel.Size = new System.Drawing.Size(428, 100);
            this.grpRappel.TabIndex = 0;
            this.grpRappel.TabStop = false;
            this.grpRappel.Text = "Un rappel";
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(339, 27);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 48);
            this.btnAjout.TabIndex = 0;
            this.btnAjout.Text = "Ajout";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // txtRappel
            // 
            this.txtRappel.Location = new System.Drawing.Point(44, 55);
            this.txtRappel.Name = "txtRappel";
            this.txtRappel.Size = new System.Drawing.Size(284, 20);
            this.txtRappel.TabIndex = 3;
            // 
            // cboFrequence
            // 
            this.cboFrequence.FormattingEnabled = true;
            this.cboFrequence.Items.AddRange(new object[] {
            "Unique",
            "Journalier",
            "Hebdomadaire",
            "Mensuel",
            "Annuel"});
            this.cboFrequence.Location = new System.Drawing.Point(207, 27);
            this.cboFrequence.Name = "cboFrequence";
            this.cboFrequence.Size = new System.Drawing.Size(121, 21);
            this.cboFrequence.TabIndex = 2;
            // 
            // dtpHeure
            // 
            this.dtpHeure.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHeure.Location = new System.Drawing.Point(133, 28);
            this.dtpHeure.Name = "dtpHeure";
            this.dtpHeure.ShowUpDown = true;
            this.dtpHeure.Size = new System.Drawing.Size(68, 20);
            this.dtpHeure.TabIndex = 1;
            // 
            // dtpJour
            // 
            this.dtpJour.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJour.Location = new System.Drawing.Point(44, 28);
            this.dtpJour.Name = "dtpJour";
            this.dtpJour.Size = new System.Drawing.Size(83, 20);
            this.dtpJour.TabIndex = 0;
            // 
            // grpMaintenant
            // 
            this.grpMaintenant.Controls.Add(this.lblHeure);
            this.grpMaintenant.Controls.Add(this.lblDate);
            this.grpMaintenant.Location = new System.Drawing.Point(446, 12);
            this.grpMaintenant.Name = "grpMaintenant";
            this.grpMaintenant.Size = new System.Drawing.Size(185, 100);
            this.grpMaintenant.TabIndex = 1;
            this.grpMaintenant.TabStop = false;
            this.grpMaintenant.Text = "Maintenant";
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(78, 55);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(0, 13);
            this.lblHeure.TabIndex = 13;
            this.lblHeure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(78, 30);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpEnsemble
            // 
            this.grpEnsemble.Controls.Add(this.lblAnnuel);
            this.grpEnsemble.Controls.Add(this.lblMensuel);
            this.grpEnsemble.Controls.Add(this.lblHebdomadaire);
            this.grpEnsemble.Controls.Add(this.lblJournalier);
            this.grpEnsemble.Controls.Add(this.lblUnique);
            this.grpEnsemble.Controls.Add(this.btnVider);
            this.grpEnsemble.Controls.Add(this.btnSuppr);
            this.grpEnsemble.Controls.Add(this.btnModif);
            this.grpEnsemble.Controls.Add(this.lstEnsemble);
            this.grpEnsemble.Location = new System.Drawing.Point(12, 131);
            this.grpEnsemble.Name = "grpEnsemble";
            this.grpEnsemble.Size = new System.Drawing.Size(619, 170);
            this.grpEnsemble.TabIndex = 1;
            this.grpEnsemble.TabStop = false;
            this.grpEnsemble.Text = "Ensemble des rappels";
            // 
            // lblAnnuel
            // 
            this.lblAnnuel.AutoSize = true;
            this.lblAnnuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnuel.ForeColor = System.Drawing.Color.Indigo;
            this.lblAnnuel.Location = new System.Drawing.Point(410, 138);
            this.lblAnnuel.Name = "lblAnnuel";
            this.lblAnnuel.Size = new System.Drawing.Size(46, 13);
            this.lblAnnuel.TabIndex = 11;
            this.lblAnnuel.Text = "Annuel";
            // 
            // lblMensuel
            // 
            this.lblMensuel.AutoSize = true;
            this.lblMensuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensuel.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblMensuel.Location = new System.Drawing.Point(319, 138);
            this.lblMensuel.Name = "lblMensuel";
            this.lblMensuel.Size = new System.Drawing.Size(54, 13);
            this.lblMensuel.TabIndex = 10;
            this.lblMensuel.Text = "Mensuel";
            // 
            // lblHebdomadaire
            // 
            this.lblHebdomadaire.AutoSize = true;
            this.lblHebdomadaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHebdomadaire.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHebdomadaire.Location = new System.Drawing.Point(204, 138);
            this.lblHebdomadaire.Name = "lblHebdomadaire";
            this.lblHebdomadaire.Size = new System.Drawing.Size(88, 13);
            this.lblHebdomadaire.TabIndex = 9;
            this.lblHebdomadaire.Text = "Hebdomadaire";
            // 
            // lblJournalier
            // 
            this.lblJournalier.AutoSize = true;
            this.lblJournalier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJournalier.ForeColor = System.Drawing.Color.Red;
            this.lblJournalier.Location = new System.Drawing.Point(120, 138);
            this.lblJournalier.Name = "lblJournalier";
            this.lblJournalier.Size = new System.Drawing.Size(62, 13);
            this.lblJournalier.TabIndex = 8;
            this.lblJournalier.Text = "Journalier";
            // 
            // lblUnique
            // 
            this.lblUnique.AutoSize = true;
            this.lblUnique.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnique.Location = new System.Drawing.Point(41, 138);
            this.lblUnique.Name = "lblUnique";
            this.lblUnique.Size = new System.Drawing.Size(47, 13);
            this.lblUnique.TabIndex = 7;
            this.lblUnique.Text = "Unique";
            // 
            // btnVider
            // 
            this.btnVider.Location = new System.Drawing.Point(538, 116);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(75, 48);
            this.btnVider.TabIndex = 6;
            this.btnVider.Text = "Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(538, 66);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(75, 48);
            this.btnSuppr.TabIndex = 5;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(538, 16);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 48);
            this.btnModif.TabIndex = 4;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // lstEnsemble
            // 
            this.lstEnsemble.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstEnsemble.FormattingEnabled = true;
            this.lstEnsemble.Location = new System.Drawing.Point(7, 28);
            this.lstEnsemble.Name = "lstEnsemble";
            this.lstEnsemble.Size = new System.Drawing.Size(489, 95);
            this.lstEnsemble.TabIndex = 4;
            this.lstEnsemble.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstEnsemble_DrawItem);
            // 
            // tmrRappel
            // 
            this.tmrRappel.Enabled = true;
            this.tmrRappel.Interval = 10000;
            this.tmrRappel.Tick += new System.EventHandler(this.tmrRappel_Tick);
            // 
            // icoAgenda
            // 
            this.icoAgenda.Icon = ((System.Drawing.Icon)(resources.GetObject("icoAgenda.Icon")));
            this.icoAgenda.Text = "Liste des rappels";
            this.icoAgenda.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.icoAgenda_MouseDoubleClick);
            // 
            // btnMini
            // 
            this.btnMini.Location = new System.Drawing.Point(550, 112);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(75, 23);
            this.btnMini.TabIndex = 2;
            this.btnMini.Text = "Minimiser";
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 312);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.grpEnsemble);
            this.Controls.Add(this.grpMaintenant);
            this.Controls.Add(this.grpRappel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            this.grpRappel.ResumeLayout(false);
            this.grpRappel.PerformLayout();
            this.grpMaintenant.ResumeLayout(false);
            this.grpMaintenant.PerformLayout();
            this.grpEnsemble.ResumeLayout(false);
            this.grpEnsemble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRappel;
        private System.Windows.Forms.GroupBox grpMaintenant;
        private System.Windows.Forms.GroupBox grpEnsemble;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.TextBox txtRappel;
        private System.Windows.Forms.ComboBox cboFrequence;
        private System.Windows.Forms.DateTimePicker dtpHeure;
        private System.Windows.Forms.DateTimePicker dtpJour;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAnnuel;
        private System.Windows.Forms.Label lblMensuel;
        private System.Windows.Forms.Label lblHebdomadaire;
        private System.Windows.Forms.Label lblJournalier;
        private System.Windows.Forms.Label lblUnique;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.ListBox lstEnsemble;
        private System.Windows.Forms.Timer tmrRappel;
        private System.Windows.Forms.NotifyIcon icoAgenda;
        private System.Windows.Forms.Button btnMini;
    }
}

