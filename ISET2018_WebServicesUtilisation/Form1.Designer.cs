namespace ISET2018_WebServicesUtilisation
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
            this.btnHello = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnPersonneByID = new System.Windows.Forms.Button();
            this.tbCheckPersonne = new System.Windows.Forms.TextBox();
            this.tbCheckMDP = new System.Windows.Forms.TextBox();
            this.lblPersonne = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnVerifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodeISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerifierISBN = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(0, 0);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(251, 42);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(9, 45);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(101, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Identifiant Personne";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(0, 61);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(251, 20);
            this.tbID.TabIndex = 2;
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPersonneByID
            // 
            this.btnPersonneByID.Location = new System.Drawing.Point(0, 87);
            this.btnPersonneByID.Name = "btnPersonneByID";
            this.btnPersonneByID.Size = new System.Drawing.Size(251, 42);
            this.btnPersonneByID.TabIndex = 3;
            this.btnPersonneByID.Text = "Chercher (par ID)";
            this.btnPersonneByID.UseVisualStyleBackColor = true;
            this.btnPersonneByID.Click += new System.EventHandler(this.btnPersonneByID_Click);
            // 
            // tbCheckPersonne
            // 
            this.tbCheckPersonne.Location = new System.Drawing.Point(0, 175);
            this.tbCheckPersonne.Name = "tbCheckPersonne";
            this.tbCheckPersonne.Size = new System.Drawing.Size(251, 20);
            this.tbCheckPersonne.TabIndex = 4;
            this.tbCheckPersonne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCheckMDP
            // 
            this.tbCheckMDP.Location = new System.Drawing.Point(0, 222);
            this.tbCheckMDP.Name = "tbCheckMDP";
            this.tbCheckMDP.Size = new System.Drawing.Size(251, 20);
            this.tbCheckMDP.TabIndex = 5;
            this.tbCheckMDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPersonne
            // 
            this.lblPersonne.AutoSize = true;
            this.lblPersonne.Location = new System.Drawing.Point(12, 159);
            this.lblPersonne.Name = "lblPersonne";
            this.lblPersonne.Size = new System.Drawing.Size(102, 13);
            this.lblPersonne.TabIndex = 6;
            this.lblPersonne.Text = "Nom de la personne";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 203);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Mot de passe :";
            // 
            // btnVerifier
            // 
            this.btnVerifier.Location = new System.Drawing.Point(0, 248);
            this.btnVerifier.Name = "btnVerifier";
            this.btnVerifier.Size = new System.Drawing.Size(251, 42);
            this.btnVerifier.TabIndex = 8;
            this.btnVerifier.Text = "Verifier";
            this.btnVerifier.UseVisualStyleBackColor = true;
            this.btnVerifier.Click += new System.EventHandler(this.btnVerifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "________________________________________";
            // 
            // tbCodeISBN
            // 
            this.tbCodeISBN.Location = new System.Drawing.Point(0, 341);
            this.tbCodeISBN.Name = "tbCodeISBN";
            this.tbCodeISBN.Size = new System.Drawing.Size(251, 20);
            this.tbCodeISBN.TabIndex = 11;
            this.tbCodeISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Verifier code  ISBN 13";
            // 
            // btnVerifierISBN
            // 
            this.btnVerifierISBN.Location = new System.Drawing.Point(0, 367);
            this.btnVerifierISBN.Name = "btnVerifierISBN";
            this.btnVerifierISBN.Size = new System.Drawing.Size(251, 42);
            this.btnVerifierISBN.TabIndex = 13;
            this.btnVerifierISBN.Text = "Verifier";
            this.btnVerifierISBN.UseVisualStyleBackColor = true;
            this.btnVerifierISBN.Click += new System.EventHandler(this.btnVerifierISBN_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(0, 415);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(251, 20);
            this.textBox4.TabIndex = 14;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 438);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnVerifierISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCodeISBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerifier);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPersonne);
            this.Controls.Add(this.tbCheckMDP);
            this.Controls.Add(this.tbCheckPersonne);
            this.Controls.Add(this.btnPersonneByID);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnPersonneByID;
        private System.Windows.Forms.TextBox tbCheckPersonne;
        private System.Windows.Forms.TextBox tbCheckMDP;
        private System.Windows.Forms.Label lblPersonne;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnVerifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodeISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerifierISBN;
        private System.Windows.Forms.TextBox textBox4;
    }
}

