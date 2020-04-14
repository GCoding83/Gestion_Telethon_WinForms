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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int essai = 0;

        private void btnOkMain_Click(object sender, EventArgs e)
        {
            if (txtNomUtil.Text == "Telethon" && txtMdp.Text == "admin")
            {
                FormTabPrincipal autreFenetre = new FormTabPrincipal();
                autreFenetre.ShowDialog();
                this.Hide();

            }
            else if (essai == 2)
                Application.Exit();
            else
                MessageBox.Show($"Il vous reste seulement {2-essai} tentatives pour vous connecter", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                essai++;
        }
    }
}
