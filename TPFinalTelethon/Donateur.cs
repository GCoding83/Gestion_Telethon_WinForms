using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTelethon
{
    public class Donateur : Personne
    {
        private string idDonateur;
        private string adresse;
        private string telephone;
        private char typeDeCarte;
        private string numeroDeCarte;
        private string dateExpiration;

        public Donateur(string prenom, string nomFamille, string idDonateur, string adresse, string telephone, char typeDeCarte, string numeroDeCarte, string dateExpiration)
        {
            this.Prenom = prenom;
            this.NomFamille = nomFamille;
            this.idDonateur = idDonateur;
            this.adresse = adresse;
            this.telephone = telephone;
            this.typeDeCarte = typeDeCarte;
            this.numeroDeCarte = numeroDeCarte;
            this.dateExpiration = dateExpiration;
        }

        public string IdDonateur { get => idDonateur; set => idDonateur = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public char TypeDeCarte { get => typeDeCarte; set => typeDeCarte = value; }
        public string NumeroDeCarte { get => numeroDeCarte; set => numeroDeCarte = value; }
        public string DateExpiration { get => dateExpiration; set => dateExpiration = value; }

        public override string ToString()
        {
            return "#" + this.IdDonateur + ", " + this.Prenom + " " + this.NomFamille + ", Adresse: " + this.Adresse + ", " + this.Telephone + ", Carte de Credit: " + this.TypeDeCarte + ", " + this.NumeroDeCarte + ", Expiration: " + this.DateExpiration + " \r\n";
        }
    }
}
