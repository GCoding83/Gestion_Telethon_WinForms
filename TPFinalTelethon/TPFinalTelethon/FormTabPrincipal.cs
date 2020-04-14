using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinalTelethon
{
    public partial class FormTabPrincipal : Form
    {

        //Infos donateurs
        string prenomD;
        string nomFamilleD;
        string idDonateur;
        string adresseD;
        string telephone;
        char typeDeCarte;
        string numeroDeCarte;
        string dateExpiration;

        //Infos dons
        string idDon;
        string dateDuDon;
        string idDonateurDon;
        double montantDuDon;
        string idPrixDon;

        //Infos commanditaires
        string prenomC;
        string nomFamilleC;
        string idC;

        //Infos prix
        string idP;
        string descriptionP;
        double valeurP;
        double donMinimumP;
        int quantite_orP;
        int quantite_disP;
        string idCommanditaireP;

        //Creer une instance du gestionnaire
        public GestionnaireSTE gest = new GestionnaireSTE();

        public int Quantite_disP { get => quantite_disP; set => quantite_disP = value; }

        public FormTabPrincipal()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void ongPrix_Click(object sender, EventArgs e)
        {

        }

        private void tabDonateur_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabDon_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        //Le button est pour Afficher les Commanditaires ( je n'arrive pas a le renommer....)
        private void button8_Click(object sender, EventArgs e)
        {
            txtAfficherPrincipal.Clear();
            txtAfficherPrincipal.Paste(gest.AfficherCommanditaires());
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void txtAfficherPrincipal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouterDonateur_Click(object sender, EventArgs e)
        {
            try
            {
                prenomD = txtPrenomDonateur.Text;
                nomFamilleD = txtNomDonateur.Text;
                idDonateur = txtIdDonateur.Text;
                adresseD = txtAdresseDonateur.Text;
                telephone = txtTelephoneDonateur.Text;
                if (rbtnVisa.Checked)
                    typeDeCarte = 'V';
                else if (rbtnAmex.Checked)
                    typeDeCarte = 'A';
                else if (rbtnMc.Checked)
                    typeDeCarte = 'M';
                else
                    throw new Exception("Vous devez choisir une carte de credit.");
                numeroDeCarte = txtNumeroCarte.Text;
                dateExpiration = dateCarte.Value.ToString("dd/MM/yyyy");

                gest.AjouterDonateur(prenomD, nomFamilleD, idDonateur, adresseD, telephone, typeDeCarte, numeroDeCarte, dateExpiration);

                MessageBox.Show("Donateur ajouté avec succès.", "Ajout Donateur");

                //init
                txtPrenomDonateur.Text  = String.Empty;
                txtNomDonateur.Text = String.Empty;
                txtIdDonateur.Text = String.Empty;
                txtAdresseDonateur.Text = String.Empty;
                txtAdresseDonateur.Text = String.Empty;
                txtTelephoneDonateur.Text = String.Empty;
                txtNumeroCarte.Text = String.Empty;
            }
            catch (OverflowException oE)
            {
                MessageBox.Show(oE.Message, "Erreur");
            }
            catch (NullReferenceException nRE)
            {
                MessageBox.Show(nRE.Message, "Erreur");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAfficherPrix_Click(object sender, EventArgs e)
        {
            txtAfficherPrincipal.Clear();
            txtAfficherPrincipal.Paste(gest.AfficherPrix());
        }

        private void btnAfficherDonateur_Click(object sender, EventArgs e)
        {
            txtAfficherPrincipal.Clear();
            txtAfficherPrincipal.Paste(gest.AfficherDonateurs());

        }

        private void btnAjouterDon_Click(object sender, EventArgs e)
        {
            try
            {
                idDon = txtIdDon.Text;
                dateDuDon = dateDon.Value.ToString("dd/MM/yyyy");

                idDonateurDon = txtIdDonateur2.Text;
                montantDuDon = Double.Parse(txtMontantDon.Text);

                gest.AjouterDon(idDon, dateDuDon, idDonateurDon, montantDuDon);

                //Afficher l'information sur le prix attribue pour le don.
                Don ledon = gest.GetDon(idDon);
                string idPrix = ledon.IdPrix;
                int quantitePrix = ledon.QttePrix;

                txtIdPrix2.Text = idPrix;
                txtQuantitePrix2.Text = quantitePrix.ToString();

                MessageBox.Show("Don ajouté avec succès.", "Ajout Donateur");

                //init
                txtIdDon.Text = String.Empty;
                txtIdDonateur2.Text = String.Empty;
                txtAdresseDonateur.Text = String.Empty;
                txtMontantDon.Text = String.Empty;
                txtIdPrix2.Text = String.Empty;
                txtQuantitePrix2.Text = String.Empty;



            }
            catch (OverflowException oE)
            {
                MessageBox.Show(oE.Message, "Erreur");
            }
            catch (NullReferenceException nRE)
            {
                MessageBox.Show(nRE.Message, "Erreur");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }

        }

        private void btnAfficherDon_Click(object sender, EventArgs e)
        {
            txtAfficherPrincipal.Clear();
            txtAfficherPrincipal.Paste(gest.AfficherDons());
        }

        private void btnAfficherPrix2_Click(object sender, EventArgs e)
        {
            //init
            txtIdPrix2.Text = String.Empty;
            txtQuantitePrix2.Text = String.Empty;

            idDon = txtIdDon.Text;

            if (String.IsNullOrEmpty(idDon))
            {
                MessageBox.Show("Entrez un ID valide pour le don.");
            }

            try
            {
                Don ledon = gest.GetDon(idDon);
                string idPrix = ledon.IdPrix;
                int quantitePrix = ledon.QttePrix;

                txtIdPrix2.Text = idPrix;
                txtQuantitePrix2.Text = quantitePrix.ToString();
            }
            catch(NullReferenceException nRE)
            {
                MessageBox.Show(nRE.Message, "Entrez un ID valide pour le don");
            }

        }

        private void btnAjouterCommanditaire_Click(object sender, EventArgs e)
        {
            try
            {
                idC = txtIdCommanditaire.Text;
                prenomC = txtPrenomCommanditaire.Text;
                nomFamilleC = txtNomCommanditaire.Text;

                gest.AjouterCommanditaire(prenomC, nomFamilleC, idC);

                MessageBox.Show("Commanditaire ajouté avec succès.", "Ajout Commanditaire");

                //init
                txtIdCommanditaire.Text = String.Empty;
                txtPrenomCommanditaire.Text = String.Empty;
                txtNomCommanditaire.Text = String.Empty;


            }
            catch (OverflowException oE)
            {
                MessageBox.Show(oE.Message, "Erreur");
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }
        }

        private void btnAjouterPrix_Click(object sender, EventArgs e)
        {
            try
            {
                idP = txtIdPrix.Text;
                descriptionP = txtDescriptionPrix.Text;
                valeurP = Double.Parse(txtValeurPrix.Text);
                donMinimumP = Double.Parse(txtDonMinimumPrix.Text);
                quantite_orP = Int32.Parse(txtQuantitePrix.Text);
                Quantite_disP = Int32.Parse(txtQuantitePrix.Text);
                idCommanditaireP = txtIdCommanditaire2.Text;


                gest.AjouterPrix(idP, descriptionP, valeurP, donMinimumP, quantite_orP, quantite_disP, idCommanditaireP);

                MessageBox.Show("Prix ajouté avec succès.", "Ajout Donateur");

                //init
                txtPrenomDonateur.Text = String.Empty;
                txtNomDonateur.Text = String.Empty;
                txtIdDonateur.Text = String.Empty;
                txtAdresseDonateur.Text = String.Empty;
                txtTelephoneDonateur.Text = String.Empty;
                txtNumeroCarte.Text = String.Empty;
            }
            catch (OverflowException oE)
            {
                MessageBox.Show(oE.Message, "Erreur");
            }
            catch (NullReferenceException nRE)
            {
                MessageBox.Show(nRE.Message, "Erreur");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gest.LireCommanditaires();
            gest.LireDonateurs();
            gest.LireDons();
            gest.LirePrix();

            MessageBox.Show("Fichier ouvert avec succès.", "Fichier ouvert");

        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            gest.EcrireDons();
            gest.EcrireDonateurs();
            gest.EcrireCommanditaires();
            gest.EcrirePrix();

            MessageBox.Show("Données sauvegardées avec succès.", "Sauvegarde");



        }
    }
}
