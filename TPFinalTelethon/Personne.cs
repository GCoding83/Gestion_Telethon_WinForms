using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTelethon
{
    public class Personne
    {
        private string prenom;
        private string nomFamille;

        public string Prenom { get => prenom; set => prenom = value; }
        public string NomFamille { get => nomFamille; set => nomFamille = value; }

        public override string ToString()
        {
            string nom = this.prenom + " " + this.nomFamille;
            return nom;
        }

        

    }
}
