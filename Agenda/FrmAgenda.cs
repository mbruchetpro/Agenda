using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BiblioOutils;

namespace Agenda
{
    public partial class FrmAgenda : Form
    {
        // @SortedList<DateTime, Rappel> listeRappel est une liste des différent rappel courant. 
        SortedList<DateTime, Rappel> listeRappel = new SortedList<DateTime, Rappel>();

        // Nom Fichier serialisation.
        private string nomFichier = "LesRappels";

        //Timer permettant à la date et l'heure de se mettre a jour.
        Timer bg = new Timer();

        /// <summary>
        /// Initialisation des composants du formulaire.
        /// </summary>
        public FrmAgenda()
        {
            InitializeComponent();

            // Mettre à jour la date et l'heure automatiquement. 
            bg.Tick += (s, e) 
                => {
                    lblDate.Text = DateTime.Now.ToShortDateString();
                    lblHeure.Text = DateTime.Now.ToLongTimeString();
                };
            bg.Interval = 500;
            bg.Start();
            //Fin mise à jour auto.
        }

        /// <summary>
        /// Au chargement de la page met par défaut le combobox a la valeur d'indice 1. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            cboFrequence.SelectedIndex = 1;


            // Chargement du fichier dans la liste. 
            Object fichier = OutilsSerialisation.Charger(nomFichier);

            if (fichier != null)
            {
                listeRappel = (SortedList<DateTime, Rappel>)fichier;
            }
            majListeRappel();
        }

        /// <summary>
        /// Ajout de rappel dans la liste rappel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjout_Click(object sender, EventArgs e)
        {
            if ("" == txtRappel.Text)
            {
                MessageBox.Show("Le libellé du rappel doit être rempli");
                return;
            }

            int jour        = dtpJour.Value.Day;
            int mois        = dtpJour.Value.Month;
            int annee       = dtpJour.Value.Year;
            int heures      = dtpHeure.Value.Hour;
            int minutes     = dtpHeure.Value.Minute;
            int secondes    = 0;


            DateTime laDate = new DateTime(annee, mois, jour, heures, minutes, secondes);


            if (this.listeRappel.ContainsKey(laDate))
            {
                MessageBox.Show("Un rappel existe déja à cette date et heure :" + this.listeRappel[laDate].Date + ": "+ this.listeRappel[laDate].Libelle
                    + ". Pour votre rappel : " + laDate + ": " + txtRappel.Text);
                return;
            }

            Rappel leRappel = new Rappel(txtRappel.Text, laDate, cboFrequence.SelectedIndex);

            this.listeRappel.Add(laDate, leRappel);

            majListeRappel();
            
        }

        /// <summary>
        /// Met à jour la lstEnsemble avec le contenu de la listeRappel.
        /// </summary>
        private void majListeRappel()
        {
            lstEnsemble.Items.Clear();

            foreach(Rappel unRappel in this.listeRappel.Values)
            {
                lstEnsemble.Items.Add(unRappel.Date.ToShortDateString() + " " + unRappel.Date.ToShortTimeString() + " : " + unRappel.Libelle);    
            }
        }

        /// <summary>
        /// Vide la listBox lstEnsemble ainsi que la listeRappel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVider_Click(object sender, EventArgs e)
        {
            this.listeRappel.Clear();
            lstEnsemble.Items.Clear();

        }
        /// <summary>
        /// Supprime le rappel selectionner.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (lstEnsemble.SelectedIndex != -1)
            {
                supprRappel(lstEnsemble.SelectedIndex);
            }
            else
                MessageBox.Show("Veuillez sélectionner un rappel à supprimer");
        }


        /// <summary>
        /// Modifie le rappel courant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModif_Click(object sender, EventArgs e)
        {
            int k = lstEnsemble.SelectedIndex;
            if (k != -1)
            {
                Rappel unRappel = this.listeRappel.Values[k];

                dtpJour.Text = unRappel.Date.ToShortDateString();
                dtpHeure.Text = unRappel.Date.ToShortTimeString();

                txtRappel.Text = unRappel.Libelle;

                cboFrequence.SelectedIndex = unRappel.Frequence;


                supprRappel(k);
            }
            else
                MessageBox.Show("Un élement de la liste doit être sélectionné");
        }

        /// <summary>
        /// Timer permettant de chercher toute les 10 secondes si il existe un ou plusieurs rappels
        /// et le supprime et affiche un message d'alerte.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrRappel_Tick(object sender, EventArgs e)
        {
            int i = 0;
            DateTime dateActuelle = DateTime.Now;
            while (i < this.listeRappel.Count && this.listeRappel.Values[i].Date <= dateActuelle) {

                Rappel unRappel = listeRappel.Values[i];

                MessageBox.Show("Votre rappel " + unRappel.getNomFrequence(unRappel.Frequence) + " : " + unRappel.Date + " " + unRappel.Libelle + " a été dépassée.");

                if(unRappel.Frequence != 0)
                {
                    listeRappel.Remove(unRappel.Date);

                    unRappel.Suivant(unRappel.Frequence);

                    listeRappel.Add(unRappel.Date, unRappel);

                    majListeRappel();
                }
                else
                    supprRappel(i);
                
                i = i++;
            }
        }

        /// <summary>
        /// Permet la supression d'un rappel dans la listeRappel 
        /// et de mettre a jour lstEnsemble.
        /// </summary>
        /// <param name="indice"></param>
        private void supprRappel(int indice)
        {
            this.listeRappel.RemoveAt(indice);
            majListeRappel();
        }


        /// <summary>
        /// Permet de mettre des couleurs différente en fonction du type de fréquence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstEnsemble_DrawItem(object sender, DrawItemEventArgs e)
        {

            // Define the default color of the brush as black.
            //Définit la valeur de la couleur par défaut.
            Brush myBrush = Brushes.Black;
            
            //Determine la couleur basé sur le type de fréquence.
            switch (listeRappel.Values[e.Index].Frequence)
            {
                case 0:
                    myBrush = Brushes.Black;
                    break;
                case 1:
                    myBrush = Brushes.Red;
                    break;
                case 2:
                    myBrush = Brushes.DarkOrange;
                    break;
                case 3:
                    myBrush = Brushes.CadetBlue;
                    break;
                case 4:
                    myBrush = Brushes.Indigo;
                    break;
            }

            // Dessinne l'item courant basé sur la couleur courante. 
            // Et les paramètres personnalisé du brush.
            e.Graphics.DrawString(lstEnsemble.Items[e.Index].ToString(),
                e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
        }

        /// <summary>
        /// Minimise l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMini_Click(object sender, EventArgs e)
        {
            icoAgenda.Visible = true;

            this.Hide();
        }

        /// <summary>
        /// Maximise l'application depuis l'icone minimisée.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void icoAgenda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            icoAgenda.Visible = false;

            this.Show();
        }

        /// <summary>
        /// Enregistrement à la fermeture de l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAgenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            OutilsSerialisation.Enregistrer(nomFichier, listeRappel);
        }
        
    }
}
