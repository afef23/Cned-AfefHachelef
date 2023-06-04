namespace Projet_portfolio
{
    partial class PersonnelsForm
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
            this.ListBoxId = new System.Windows.Forms.ListBox();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.Nom = new System.Windows.Forms.TextBox();
            this.TextBoxTel = new System.Windows.Forms.TextBox();
            this.TextBoxMail = new System.Windows.Forms.TextBox();
            this.TextBoxPrenom = new System.Windows.Forms.TextBox();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.LblNom = new System.Windows.Forms.Label();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.ComboBoxService = new System.Windows.Forms.ComboBox();
            this.LblService = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblTel = new System.Windows.Forms.Label();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAbsence = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAjouterPersonnel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxId
            // 
            this.ListBoxId.FormattingEnabled = true;
            this.ListBoxId.ItemHeight = 20;
            this.ListBoxId.Location = new System.Drawing.Point(0, 25);
            this.ListBoxId.Name = "ListBoxId";
            this.ListBoxId.Size = new System.Drawing.Size(630, 204);
            this.ListBoxId.TabIndex = 0;
            this.ListBoxId.Visible = false;
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Location = new System.Drawing.Point(667, 109);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(120, 40);
            this.BtnSupprimer.TabIndex = 1;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Location = new System.Drawing.Point(667, 63);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(120, 40);
            this.BtnModifier.TabIndex = 2;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(0, 43);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(180, 26);
            this.Nom.TabIndex = 3;
            this.Nom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextBoxTel
            // 
            this.TextBoxTel.Location = new System.Drawing.Point(229, 105);
            this.TextBoxTel.Name = "TextBoxTel";
            this.TextBoxTel.Size = new System.Drawing.Size(180, 26);
            this.TextBoxTel.TabIndex = 5;
            // 
            // TextBoxMail
            // 
            this.TextBoxMail.Location = new System.Drawing.Point(0, 105);
            this.TextBoxMail.Name = "TextBoxMail";
            this.TextBoxMail.Size = new System.Drawing.Size(180, 26);
            this.TextBoxMail.TabIndex = 6;
            // 
            // TextBoxPrenom
            // 
            this.TextBoxPrenom.Location = new System.Drawing.Point(229, 43);
            this.TextBoxPrenom.Name = "TextBoxPrenom";
            this.TextBoxPrenom.Size = new System.Drawing.Size(180, 26);
            this.TextBoxPrenom.TabIndex = 7;
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(667, 32);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(120, 40);
            this.BtnAjouter.TabIndex = 8;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(-4, 20);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(42, 20);
            this.LblNom.TabIndex = 9;
            this.LblNom.Text = "Nom";
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Location = new System.Drawing.Point(225, 20);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(64, 20);
            this.LblPrenom.TabIndex = 10;
            this.LblPrenom.Text = "Prénom";
            // 
            // ComboBoxService
            // 
            this.ComboBoxService.FormattingEnabled = true;
            this.ComboBoxService.Location = new System.Drawing.Point(450, 41);
            this.ComboBoxService.Name = "ComboBoxService";
            this.ComboBoxService.Size = new System.Drawing.Size(180, 28);
            this.ComboBoxService.TabIndex = 11;
            this.ComboBoxService.Text = "Selectionner Service";
            // 
            // LblService
            // 
            this.LblService.AutoSize = true;
            this.LblService.Location = new System.Drawing.Point(446, 20);
            this.LblService.Name = "LblService";
            this.LblService.Size = new System.Drawing.Size(61, 20);
            this.LblService.TabIndex = 12;
            this.LblService.Text = "Service";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(-4, 82);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(37, 20);
            this.LblMail.TabIndex = 13;
            this.LblMail.Text = "Mail";
            // 
            // LblTel
            // 
            this.LblTel.AutoSize = true;
            this.LblTel.Location = new System.Drawing.Point(225, 82);
            this.LblTel.Name = "LblTel";
            this.LblTel.Size = new System.Drawing.Size(104, 20);
            this.LblTel.TabIndex = 14;
            this.LblTel.Text = "N° Téléphone";
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(667, 82);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(120, 40);
            this.BtnAnnuler.TabIndex = 15;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAjouterPersonnel);
            this.groupBox1.Controls.Add(this.BtnAbsence);
            this.groupBox1.Controls.Add(this.BtnModifier);
            this.groupBox1.Controls.Add(this.BtnSupprimer);
            this.groupBox1.Controls.Add(this.ListBoxId);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 240);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnels";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnAbsence
            // 
            this.BtnAbsence.Location = new System.Drawing.Point(667, 189);
            this.BtnAbsence.Name = "BtnAbsence";
            this.BtnAbsence.Size = new System.Drawing.Size(120, 40);
            this.BtnAbsence.TabIndex = 3;
            this.BtnAbsence.Text = "Absences";
            this.BtnAbsence.UseVisualStyleBackColor = true;
            this.BtnAbsence.Click += new System.EventHandler(this.BtnAbsence_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblTel);
            this.groupBox3.Controls.Add(this.LblService);
            this.groupBox3.Controls.Add(this.LblNom);
            this.groupBox3.Controls.Add(this.LblMail);
            this.groupBox3.Controls.Add(this.ComboBoxService);
            this.groupBox3.Controls.Add(this.BtnAnnuler);
            this.groupBox3.Controls.Add(this.LblPrenom);
            this.groupBox3.Controls.Add(this.TextBoxPrenom);
            this.groupBox3.Controls.Add(this.TextBoxMail);
            this.groupBox3.Controls.Add(this.BtnAjouter);
            this.groupBox3.Controls.Add(this.TextBoxTel);
            this.groupBox3.Controls.Add(this.Nom);
            this.groupBox3.Location = new System.Drawing.Point(12, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 162);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajout de personnels";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnAjouterPersonnel
            // 
            this.btnAjouterPersonnel.Location = new System.Drawing.Point(667, 17);
            this.btnAjouterPersonnel.Name = "btnAjouterPersonnel";
            this.btnAjouterPersonnel.Size = new System.Drawing.Size(120, 40);
            this.btnAjouterPersonnel.TabIndex = 4;
            this.btnAjouterPersonnel.Text = "Ajouter";
            this.btnAjouterPersonnel.UseVisualStyleBackColor = true;
            this.btnAjouterPersonnel.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonnelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 434);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "PersonnelsForm";
            this.Text = "Gestionnaire";
            this.Load += new System.EventHandler(this.PersonnelsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxId;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox TextBoxTel;
        private System.Windows.Forms.TextBox TextBoxMail;
        private System.Windows.Forms.TextBox TextBoxPrenom;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label LblPrenom;
        private System.Windows.Forms.ComboBox ComboBoxService;
        private System.Windows.Forms.Label LblService;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblTel;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnAbsence;
        private System.Windows.Forms.Button btnAjouterPersonnel;
    }
}