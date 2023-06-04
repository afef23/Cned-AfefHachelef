namespace Projet_portfolio
{
    partial class AuthenficationForm
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblMdp = new System.Windows.Forms.Label();
            this.BtnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(167, 31);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(255, 26);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Location = new System.Drawing.Point(167, 95);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.Size = new System.Drawing.Size(255, 26);
            this.textBoxMdp.TabIndex = 1;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Location = new System.Drawing.Point(77, 34);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(56, 20);
            this.LblLogin.TabIndex = 2;
            this.LblLogin.Text = "Login :";
            // 
            // LblMdp
            // 
            this.LblMdp.AutoSize = true;
            this.LblMdp.Location = new System.Drawing.Point(20, 98);
            this.LblMdp.Name = "LblMdp";
            this.LblMdp.Size = new System.Drawing.Size(113, 20);
            this.LblMdp.TabIndex = 3;
            this.LblMdp.Text = "Mot de passe :";
            // 
            // BtnValider
            // 
            this.BtnValider.Location = new System.Drawing.Point(167, 149);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(106, 51);
            this.BtnValider.TabIndex = 4;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // AuthenficationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 240);
            this.Controls.Add(this.BtnValider);
            this.Controls.Add(this.LblMdp);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.textBoxMdp);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "AuthenficationForm";
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.AuthenficationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxMdp;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblMdp;
        private System.Windows.Forms.Button BtnValider;
    }
}

