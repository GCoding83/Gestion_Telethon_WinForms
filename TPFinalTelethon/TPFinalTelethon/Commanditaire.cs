using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTelethon
{
    public class Commanditaire : Personne
    {
        private string idCommanditaire;

        public Commanditaire(string prenom, string nomFamille, string id)
        {
            this.Prenom = prenom;
            this.NomFamille = nomFamille;
            this.idCommanditaire = id;
        }

        public string IdCommanditaire { get => idCommanditaire; set => idCommanditaire = value; }

        public override string ToString()
        {
            return "#" + this.IdCommanditaire + ", " + this.Prenom + " " + this.NomFamille + "\r\n";
        }


    }
}
