using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Rappel
    {

        private string      libelle;
        private DateTime    date;
        private int         frequence;
        private SortedList<DateTime, Rappel> listeRappel;

        public Rappel(string libelle, DateTime date, int frequence)
        {
            this.libelle     = libelle;
            this.date        = date;
            this.frequence   = frequence;
            this.listeRappel = new SortedList<DateTime, Rappel>();
        }

        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Frequence { get => frequence; set => frequence = value; }
        internal SortedList<DateTime, Rappel> ListeRappel { get => listeRappel; set => listeRappel = value; }

        public void Suivant(int frequence)
        {
            switch (frequence)
            {
                case 0:
                    // Unique
                    break;
                case 1:
                    // Journalier
                    this.date = this.date.AddDays(1);
                    break;
                case 2:
                    // Hebdomadaire
                    this.date = this.date.AddDays(7);
                    break;
                case 3:
                    // Mensuel
                    this.date = this.date.AddMonths(1);
                    break;
                case 4:
                    // Annuel
                    this.date = this.date.AddYears(1);
                    break;  
            }
        }




    }
}
