namespace Projet_portfolio
{
    partial class ConfirmationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnConfirmer = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.LblConfirmation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConfirmer
            // 
            this.BtnConfirmer.Location = new System.Drawing.Point(52, 73);
            this.BtnConfirmer.Name = "BtnConfirmer";
            this.BtnConfirmer.Size = new System.Drawing.Size(110, 45);
            this.BtnConfirmer.TabIndex = 0;
            this.BtnConfirmer.Text = "Oui";
            this.BtnConfirmer.UseVisualStyleBackColor = true;
            this.BtnConfirmer.Click += new System.EventHandler(this.BtnConfirmation_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(212, 73);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(110, 45);
            this.BtnAnnuler.TabIndex = 1;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // LblConfirmation
            // 
            this.LblConfirmation.AutoSize = true;
            this.LblConfirmation.Location = new System.Drawing.Point(48, 26);
            this.LblConfirmation.Name = "LblConfirmation";
            this.LblConfirmation.Size = new System.Drawing.Size(246, 20);
            this.LblConfirmation.TabIndex = 2;
            this.LblConfirmation.Text = "Êtes-vous sûr de vouloir faire ça ?";
            this.LblConfirmation.Click += new System.EventHandler(this.LblConfirmation_Click);
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 154);
            this.Controls.Add(this.LblConfirmation);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.BtnConfirmer);
            this.Name = "ConfirmationForm";
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.ConfirmationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConfirmer;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Label LblConfirmation;
    }
}