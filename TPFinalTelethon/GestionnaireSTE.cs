using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTelethon
{
    public class GestionnaireSTE
    {
        List<Commanditaire> commanditaires = new List<Commanditaire>();
        List<Donateur> donateurs = new List<Donateur>();
        List<Prix> prix = new List<Prix>();
        List<Don> dons = new List<Don>();

        public void AjouterDonateur(string prenom, string nomFamille, string idDonateur, string adresse, string telephone, char typeDeCarte, string numeroDeCarte, string dateExpiration) 
        {
            for (int i = 0; i < donateurs.Count; i++)
            {
                if (idDonateur == donateurs[i].IdDonateur)
                    throw new Exception("ID Donateur déjà assignée.");
            }
            if (prenom == "" || nomFamille == "" || idDonateur == "" || adresse == "" || telephone == "" || numeroDeCarte == "" || dateExpiration == "")
                throw new FormatException("Un champ est vide.");
            if (prenom.Contains(',') || nomFamille.Contains(',') || idDonateur.Contains(','))
                throw new FormatException("Vous ne pouvez pas utiliser de virgules (,) .");
            Donateur donateur = new Donateur(prenom, nomFamille, idDonateur, adresse, telephone, typeDeCarte, numeroDeCarte, dateExpiration);
            donateurs.Add(donateur);
        }

        public void AjouterCommanditaire(string prenom, string nomFamille, string id)
        {
            for (int i = 0; i < commanditaires.Count; i++)
            {
                if (id == commanditaires[i].IdCommanditaire)
                    throw new Exception("ID Commanditaire déjà assignée.");
            }
            if (prenom == "" || nomFamille == "" || id == "")
                throw new FormatException("Un champ est vide.");
            if (prenom.Contains(',') || nomFamille.Contains(',') || id.Contains(','))
                throw new FormatException("Vous ne pouvez pas utiliser de virgules (,) .");
            Commanditaire commanditaire = new Commanditaire(prenom, nomFamille, id);
            commanditaires.Add(commanditaire);
        }

        public void AjouterPrix(string idPrix, string description, double valeur, double donMinimum, int qnte_Originale, int qnte_Disponible, string idCommanditaire)
        {
            for (int i = 0; i < prix.Count; i++)
            {
                if (idPrix == prix[i].IdPrix)
                    throw new Exception("ID Prix déjà assignée.");
            }

            bool commanditaireTrouve = false;
            for (int i = 0; i < commanditaires.Count; i++)
            {
                if (idCommanditaire == commanditaires[i].IdCommanditaire)
                    commanditaireTrouve = true;
            }
            if (!commanditaireTrouve)
            {
                throw new Exception("ID commanditaire introuvable.");
            }

            if (description == "" || idCommanditaire == "")
                throw new FormatException("Un champ est vide.");

            Prix le_prix = new Prix(idPrix, description, valeur, donMinimum, qnte_Originale, qnte_Disponible, idCommanditaire);
            prix.Add(le_prix);
        }

        public void AjouterDon(string idDon, string dateDuDon, string idDonateur, double montantDuDon)
        {
            for (int i = 0; i < dons.Count; i++)
            {
                if (idDon == dons[i].IdDon)
                    throw new Exception("ID Don déjà assignée.");
            }

            bool donateurTrouve = false;
            for (int i = 0; i < donateurs.Count; i++)
            {
                if (idDonateur == donateurs[i].IdDonateur)
                    donateurTrouve = true;
            }
            if (!donateurTrouve)
            {
                throw new Exception("ID donateur introuvable.");
            }

            if (idDon == "" || dateDuDon == "" || idDonateur == "")
                throw new FormatException("Un champ est vide.");

            Don don = new Don(idDon, dateDuDon, idDonateur, montantDuDon);
            dons.Add(don);
            AttribuerPrix(don);

        }

        public string AfficherDonateurs()
        {

            string listeDonateurs = "";
            foreach (Donateur donateur in donateurs)
            {
                listeDonateurs += donateur.ToString();
            }
            return listeDonateurs;
        }

        public string AfficherCommanditaires()
        {
            string listeCommanditaires = "";
            foreach (Commanditaire commanditaire in commanditaires)
            {
                listeCommanditaires += commanditaire.ToString();
            }
            return listeCommanditaires;
        }

        public string AfficherPrix()
        {
            string listePrix = "";
            foreach (Prix le_prix in prix)
            {
                listePrix += le_prix.ToString();
            }
            return listePrix;
        }

        public string AfficherDons()
        {
            string listeDons = "";
            foreach (Don don in dons)
            {
                listeDons += don.ToString();
            }
            return listeDons;
        }

        public bool AttribuerPrix(Don don)
        {
            //Veridier le nombre de prix auquel le donateur a droit pour son don
            double montantDon = don.MontantDuDon;
            int compteurPrix;

            if (montantDon < 50)
                return false;
            else if (montantDon < 200)
                compteurPrix = 1;
            else if (montantDon < 350)
                compteurPrix = 2;
            else if (montantDon < 500)
                compteurPrix = 3;
            else
                compteurPrix = 4;

            //Pour tous les prix dans notre liste de prix
            for (int i = 0; i < prix.Count; i++)
            {
                //Si le don minimum pour ce prix est respecte et qu'il reste au moins 1 prix disponible 
                if (prix[i].DonMinimum < montantDon && prix[i].Qnte_Disponible > 0)
                {
                    //Attribuer le maximum possible/permis de ce prix au donateur 
                    while (prix[i].Qnte_Disponible > 0 && compteurPrix > 0)
                    {
                        //Ajuster les attributs IdPrix de Don, QttePrix de Don, et Qnte_Disponible de Prix, puis diminuer le compteur de prix.
                        don.IdPrix = prix[i].IdPrix;
                        don.QttePrix++;
                        prix[i].Qnte_Disponible--;
                        compteurPrix--;
                    }
                    return true;
                }
            }
            return false;            
        }


        public Don GetDon(string id)
        {
            Don d = null;
            if (id != null)
            {
                for (int i = 0; i < dons.Count; i++)
                    if (id == dons[i].IdDon)
                        d = dons[i];
            }
           return d;
           
        }
        

        public bool LireDonateurs()
        {
            string[] strArray;
            StreamReader sr = new StreamReader("donateurs.txt");
            string strLine = sr.ReadLine();
            donateurs.Clear();
            while (strLine != null)
            {
                strArray = strLine.Split(',');
                donateurs.Add(new Donateur(strArray[0], strArray[1], strArray[2], strArray[3], strArray[4], char.Parse(strArray[5]), strArray[6], strArray[7]));
                strLine = sr.ReadLine();
            }
            sr.Close();
            return true;
        }

        public bool LireCommanditaires()
        {
            string[] strArray;
            StreamReader sr = new StreamReader("commanditaires.txt");
            string strLine = sr.ReadLine();
            commanditaires.Clear();
            while (strLine != null)
            {
                strArray = strLine.Split(',');
                commanditaires.Add(new Commanditaire(strArray[0], strArray[1], strArray[2]));
                strLine = sr.ReadLine();
            }
            sr.Close();
            return true;
        }

        public bool LireDons()
        {
            string[] strArray;
            StreamReader sr = new StreamReader("dons.txt");
            string strLine = sr.ReadLine();
            dons.Clear();
            while (strLine != null)
            {
                strArray = strLine.Split(',');
                dons.Add(new Don(strArray[0], strArray[1], strArray[2], Double.Parse(strArray[3]), strArray[4], Int32.Parse(strArray[5])));
                strLine = sr.ReadLine();
            }
            sr.Close();
            return true;
        }

        public bool LirePrix()
        {
            string[] strArray;
            StreamReader sr = new StreamReader("prix.txt");
            string strLine = sr.ReadLine();
            prix.Clear();
            while (strLine != null)
            {
                strArray = strLine.Split(',');
                prix.Add(new Prix(strArray[0], strArray[1], Double.Parse(strArray[2]), Double.Parse(strArray[3]), Int32.Parse(strArray[4]), Int32.Parse(strArray[5]), strArray[6]));
                strLine = sr.ReadLine();
            }
            sr.Close();
            return true;
        }


        public void EcrireDonateurs()
        {
            StreamWriter sw = new StreamWriter("donateurs.txt", false);
            for (int i = 0; i < donateurs.Count; i++)
            {
                if (i == donateurs.Count - 1)
                    //string prenom, string nomFamille, string idDonateur, string adresse, string telephone, char typeDeCarte, string numeroDeCarte, string dateExpiration
                    sw.Write("{0},{1},{2},{3},{4},{5},{6},{7}", donateurs[i].Prenom, donateurs[i].NomFamille, donateurs[i].IdDonateur, donateurs[i].Adresse, donateurs[i].Telephone, donateurs[i].TypeDeCarte, donateurs[i].NumeroDeCarte, donateurs[i].DateExpiration);
                else
                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", donateurs[i].Prenom, donateurs[i].NomFamille, donateurs[i].IdDonateur, donateurs[i].Adresse, donateurs[i].Telephone, donateurs[i].TypeDeCarte, donateurs[i].NumeroDeCarte, donateurs[i].DateExpiration);
            }
            sw.Close();
        }

        public void EcrireCommanditaires()
        {
            StreamWriter sw = new StreamWriter("commanditaires.txt", false);
            for (int i = 0; i < commanditaires.Count; i++)
            {
                if (i == commanditaires.Count - 1)
                    sw.Write("{0},{1},{2}", commanditaires[i].Prenom, commanditaires[i].NomFamille, commanditaires[i].IdCommanditaire);
                else
                    sw.WriteLine("{0},{1},{2}", commanditaires[i].Prenom, commanditaires[i].NomFamille, commanditaires[i].IdCommanditaire);
            }
            sw.Close();
        }

        public void EcrireDons()
        {
            StreamWriter sw = new StreamWriter("dons.txt", false);
            for (int i = 0; i < dons.Count; i++)
            {
                if (i == dons.Count - 1)
                    sw.Write("{0},{1},{2},{3},{4},{5}", dons[i].IdDon, dons[i].DateDuDon, dons[i].IdDonateur, dons[i].MontantDuDon, dons[i].IdPrix, dons[i].QttePrix);
                else
                    sw.WriteLine("{0},{1},{2},{3},{4},{5}", dons[i].IdDon, dons[i].DateDuDon, dons[i].IdDonateur, dons[i].MontantDuDon, dons[i].IdPrix, dons[i].QttePrix);
            }
            sw.Close();
        }

        public void EcrirePrix()
        {
            StreamWriter sw = new StreamWriter("prix.txt", false);
            for (int i = 0; i < prix.Count; i++)
            {
                if (i == prix.Count - 1)
                    sw.Write("{0},{1},{2},{3},{4},{5},{6}", prix[i].IdPrix, prix[i].Description, prix[i].Valeur, prix[i].DonMinimum, prix[i].Qnte_Originale, prix[i].Qnte_Disponible, prix[i].IdCommanditaire);
                else
                    sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", prix[i].IdPrix, prix[i].Description, prix[i].Valeur, prix[i].DonMinimum, prix[i].Qnte_Originale, prix[i].Qnte_Disponible, prix[i].IdCommanditaire);
            }
            sw.Close();
        }

    }
}
