using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Agenda
{
    public partial class FrmAgenda : Form
    {
        private SortedList<DateTime, Rappel> listeRappel = new SortedList<DateTime, Rappel>();

        Timer bg = new Timer();

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

            if (this.WindowState == FormWindowState.Minimized)
            {
                icoAgenda.Visible = true;

                this.Hide();
            }
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            cboFrequence.SelectedIndex = 0;
        }

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


        private void majListeRappel()
        {
            lstEnsemble.Items.Clear();

            foreach(Rappel unRappel in this.listeRappel.Values)
            {
                lstEnsemble.Items.Add(unRappel.Date.ToShortDateString() + " " + unRappel.Date.ToShortTimeString() + " : " + unRappel.Libelle);    
            }
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            this.listeRappel.Clear();
            lstEnsemble.Items.Clear();
            
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (lstEnsemble.SelectedIndex != -1)
            {
                supprRappel(lstEnsemble.SelectedIndex);
            }
            else
                MessageBox.Show("Veuillez sélectionner un rappel à supprimer");
        }

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


        private void supprRappel(int indice)
        {
            this.listeRappel.RemoveAt(indice);

            majListeRappel();
        }

        private void lstEnsemble_DrawItem(object sender, DrawItemEventArgs e)
        {
                   
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;

            // Determine the color of the brush to draw each item based 
            // on the index of the item to draw.
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

        private void btnMini_Click(object sender, EventArgs e)
        {
            icoAgenda.Visible = true;

            this.Hide();
        }

        private void icoAgenda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            icoAgenda.Visible = false;

            this.Show();
        }
    }
}
