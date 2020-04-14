using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTelethon
{
    public class Prix
    {
        private string idPrix;
        private string description;
        private double valeur;
        private double donMinimum;
        private int qnte_Originale;
        private int qnte_Disponible;
        private string idCommanditaire;

        public Prix(string idPrix, string description, double valeur, double donMinimum, int qnte_Originale, int qnte_Disponible,  string idCommanditaire)
        {
            this.idPrix = idPrix;
            this.description = description;
            this.valeur = valeur;
            this.donMinimum = donMinimum;
            this.qnte_Originale = qnte_Originale;
            this.qnte_Disponible = qnte_Disponible;
            this.idCommanditaire = idCommanditaire;
        }

        public string IdPrix { get => idPrix; set => idPrix = value; }
        public string Description { get => description; set => description = value; }
        public double Valeur { get => valeur; set => valeur = value; }
        public double DonMinimum { get => donMinimum; set => donMinimum = value; }
        public int Qnte_Originale { get => qnte_Originale; set => qnte_Originale = value; }
        public int Qnte_Disponible { get => qnte_Disponible; set => qnte_Disponible = value; }
        public string IdCommanditaire { get => idCommanditaire; set => idCommanditaire = value; }

        public override string ToString()
        {
            return "# " + this.IdPrix + ", " + this.Description + ", Valeur: " + this.Valeur + "$, Don Minimum: " + this.DonMinimum + "$, Qnte Originale: " + this.Qnte_Originale + ", Qnte Disponible: " + this.qnte_Disponible + ", Commanditaire #" + this.idCommanditaire + " \r\n";

        }

        /*public void Deduire(int kekchose){

       }*/
    }
}
