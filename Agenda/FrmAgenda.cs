using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            cboFrequence.SelectedIndex = 0;
            lblHeure.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if ("" == txtRappel.Text)
            {
                MessageBox.Show("Le libellé du rappel doit être rempli");
            }

            int jour        = dtpJour.Value.Day;
            int mois        = dtpJour.Value.Month;
            int annee       = dtpJour.Value.Year;
            int heures      = dtpHeure.Value.Hour;
            int minutes     = dtpHeure.Value.Minute;
            int secondes    = 0;


            DateTime laDate = new DateTime(annee, mois, jour, heures, minutes, secondes);

            Rappel leRappel = new Rappel(txtRappel.Text, laDate, cboFrequence.SelectedIndex);

            if (leRappel.ListeRappel.ContainsKey(laDate))
            {
                MessageBox.Show("Un rappel existe déja à cette date et heure :" + laDate + ": " + txtRappel.Text);
            }






        }
    }
}
