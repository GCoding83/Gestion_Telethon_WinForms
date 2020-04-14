using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTelethon
{
    public class Don
    {
        private string idDon;
        private string dateDuDon;
        private string idDonateur;
        private double montantDuDon;
        private string idPrix;
        private int qttePrix;

        public Don(string idDon, string dateDuDon, string idDonateur, double montantDuDon, string idPrix, int qttePrix)
        {
            this.IdDon = idDon;
            this.DateDuDon = dateDuDon;
            this.IdDonateur = idDonateur;
            this.MontantDuDon = montantDuDon;
            this.IdPrix = "Aucun Prix";
            this.QttePrix = 0;
            this.IdPrix = idPrix;
            this.QttePrix = qttePrix;
        }

        public Don(string idDon, string dateDuDon, string idDonateur, double montantDuDon)
        {
            this.IdDon = idDon;
            this.DateDuDon = dateDuDon;
            this.IdDonateur = idDonateur;
            this.MontantDuDon = montantDuDon;
            this.IdPrix = "Aucun Prix";
            this.QttePrix = 0;
        }

        public string IdDon { get => idDon; set => idDon = value; }
        public string DateDuDon { get => dateDuDon; set => dateDuDon = value; }
        public string IdDonateur { get => idDonateur; set => idDonateur = value; }
        public double MontantDuDon { get => montantDuDon; set => montantDuDon = value; }
        public string IdPrix { get => idPrix; set => idPrix = value; }
        public int QttePrix { get => qttePrix; set => qttePrix = value; }

        public override string ToString()
        {
            return "#" + this.IdDon + ", Date du don: " + this.DateDuDon + ", Montant: " + this.MontantDuDon + "$, Donateur # " + this.IdDonateur + ", Prix # " + this.IdPrix + ", Quantite du Prix: " + QttePrix + " \r\n";

        }
    }
}
