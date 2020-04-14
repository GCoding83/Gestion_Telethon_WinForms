namespace TPFinalTelethon
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomUtil = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnOkMain = new System.Windows.Forms.Button();
            this.btnAnnulerMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 234);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(233, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(233, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe :";
            // 
            // txtNomUtil
            // 
            this.txtNomUtil.Location = new System.Drawing.Point(419, 48);
            this.txtNomUtil.Name = "txtNomUtil";
            this.txtNomUtil.Size = new System.Drawing.Size(183, 22);
            this.txtNomUtil.TabIndex = 3;
            this.txtNomUtil.Text = "Telethon";
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(419, 95);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.Size = new System.Drawing.Size(183, 22);
            this.txtMdp.TabIndex = 4;
            this.txtMdp.Text = "admin";
            // 
            // btnOkMain
            // 
            this.btnOkMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkMain.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnOkMain.Location = new System.Drawing.Point(324, 167);
            this.btnOkMain.Name = "btnOkMain";
            this.btnOkMain.Size = new System.Drawing.Size(87, 35);
            this.btnOkMain.TabIndex = 5;
            this.btnOkMain.Text = "OK";
            this.btnOkMain.UseVisualStyleBackColor = true;
            this.btnOkMain.Click += new System.EventHandler(this.btnOkMain_Click);
            // 
            // btnAnnulerMain
            // 
            this.btnAnnulerMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerMain.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAnnulerMain.Location = new System.Drawing.Point(446, 167);
            this.btnAnnulerMain.Name = "btnAnnulerMain";
            this.btnAnnulerMain.Size = new System.Drawing.Size(112, 35);
            this.btnAnnulerMain.TabIndex = 6;
            this.btnAnnulerMain.Text = "Annuler";
            this.btnAnnulerMain.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOkMain;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnulerMain;
            this.ClientSize = new System.Drawing.Size(628, 230);
            this.Controls.Add(this.btnAnnulerMain);
            this.Controls.Add(this.btnOkMain);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtNomUtil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Système Téléthon STE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomUtil;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnOkMain;
        private System.Windows.Forms.Button btnAnnulerMain;
    }
}

