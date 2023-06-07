namespace Projet_portfolio
{
    partial class AbsencesForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxMotif = new System.Windows.Forms.ComboBox();
            this.LblMotif = new System.Windows.Forms.Label();
            this.ListBoxAbsence = new System.Windows.Forms.ListBox();
            this.BtnModifierAbsence = new System.Windows.Forms.Button();
            this.LblFin = new System.Windows.Forms.Label();
            this.Lbldebut = new System.Windows.Forms.Label();
            this.TimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.BtnAnnulerAbsence = new System.Windows.Forms.Button();
            this.BtnAjouterAbsence = new System.Windows.Forms.Button();
            this.TimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.BtnSupprimerAbsence = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSupprimerAbsence);
            this.groupBox2.Controls.Add(this.comboBoxMotif);
            this.groupBox2.Controls.Add(this.LblMotif);
            this.groupBox2.Controls.Add(this.ListBoxAbsence);
            this.groupBox2.Controls.Add(this.BtnModifierAbsence);
            this.groupBox2.Controls.Add(this.LblFin);
            this.groupBox2.Controls.Add(this.Lbldebut);
            this.groupBox2.Controls.Add(this.TimePickerFin);
            this.groupBox2.Controls.Add(this.BtnAnnulerAbsence);
            this.groupBox2.Controls.Add(this.BtnAjouterAbsence);
            this.groupBox2.Controls.Add(this.TimePickerDebut);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 275);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Absences";
            // 
            // comboBoxMotif
            // 
            this.comboBoxMotif.FormattingEnabled = true;
            this.comboBoxMotif.Location = new System.Drawing.Point(472, 135);
            this.comboBoxMotif.Name = "comboBoxMotif";
            this.comboBoxMotif.Size = new System.Drawing.Size(138, 28);
            this.comboBoxMotif.TabIndex = 26;
            this.comboBoxMotif.Text = "Motif";
            // 
            // LblMotif
            // 
            this.LblMotif.AutoSize = true;
            this.LblMotif.Location = new System.Drawing.Point(415, 138);
            this.LblMotif.Name = "LblMotif";
            this.LblMotif.Size = new System.Drawing.Size(52, 20);
            this.LblMotif.TabIndex = 25;
            this.LblMotif.Text = "Motif :";
            // 
            // ListBoxAbsence
            // 
            this.ListBoxAbsence.FormattingEnabled = true;
            this.ListBoxAbsence.ItemHeight = 20;
            this.ListBoxAbsence.Location = new System.Drawing.Point(3, 22);
            this.ListBoxAbsence.Name = "ListBoxAbsence";
            this.ListBoxAbsence.Size = new System.Drawing.Size(404, 244);
            this.ListBoxAbsence.TabIndex = 24;
            // 
            // BtnModifierAbsence
            // 
            this.BtnModifierAbsence.Location = new System.Drawing.Point(636, 86);
            this.BtnModifierAbsence.Name = "BtnModifierAbsence";
            this.BtnModifierAbsence.Size = new System.Drawing.Size(121, 58);
            this.BtnModifierAbsence.TabIndex = 23;
            this.BtnModifierAbsence.Text = "Modifier";
            this.BtnModifierAbsence.UseVisualStyleBackColor = true;
            this.BtnModifierAbsence.Click += new System.EventHandler(this.BtnModifierAbsence_Click);
            // 
            // LblFin
            // 
            this.LblFin.AutoSize = true;
            this.LblFin.Location = new System.Drawing.Point(414, 74);
            this.LblFin.Name = "LblFin";
            this.LblFin.Size = new System.Drawing.Size(31, 20);
            this.LblFin.TabIndex = 22;
            this.LblFin.Text = "Fin";
            // 
            // Lbldebut
            // 
            this.Lbldebut.AutoSize = true;
            this.Lbldebut.Location = new System.Drawing.Point(414, 22);
            this.Lbldebut.Name = "Lbldebut";
            this.Lbldebut.Size = new System.Drawing.Size(53, 20);
            this.Lbldebut.TabIndex = 21;
            this.Lbldebut.Text = "Début";
            // 
            // TimePickerFin
            // 
            this.TimePickerFin.Location = new System.Drawing.Point(413, 97);
            this.TimePickerFin.Name = "TimePickerFin";
            this.TimePickerFin.Size = new System.Drawing.Size(197, 26);
            this.TimePickerFin.TabIndex = 20;
            this.TimePickerFin.Value = new System.DateTime(2023, 6, 7, 0, 0, 0, 0);
            // 
            // BtnAnnulerAbsence
            // 
            this.BtnAnnulerAbsence.Location = new System.Drawing.Point(636, 217);
            this.BtnAnnulerAbsence.Name = "BtnAnnulerAbsence";
            this.BtnAnnulerAbsence.Size = new System.Drawing.Size(121, 58);
            this.BtnAnnulerAbsence.TabIndex = 19;
            this.BtnAnnulerAbsence.Text = "Annuler";
            this.BtnAnnulerAbsence.UseVisualStyleBackColor = true;
            this.BtnAnnulerAbsence.Click += new System.EventHandler(this.BtnAnnulerAbsence_Click);
            // 
            // BtnAjouterAbsence
            // 
            this.BtnAjouterAbsence.Location = new System.Drawing.Point(636, 22);
            this.BtnAjouterAbsence.Name = "BtnAjouterAbsence";
            this.BtnAjouterAbsence.Size = new System.Drawing.Size(121, 58);
            this.BtnAjouterAbsence.TabIndex = 18;
            this.BtnAjouterAbsence.Text = "Ajouter";
            this.BtnAjouterAbsence.UseVisualStyleBackColor = true;
            this.BtnAjouterAbsence.Click += new System.EventHandler(this.BtnAjouterAbsence_Click);
            // 
            // TimePickerDebut
            // 
            this.TimePickerDebut.Checked = false;
            this.TimePickerDebut.Location = new System.Drawing.Point(413, 45);
            this.TimePickerDebut.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.TimePickerDebut.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.TimePickerDebut.Name = "TimePickerDebut";
            this.TimePickerDebut.Size = new System.Drawing.Size(197, 26);
            this.TimePickerDebut.TabIndex = 17;
            this.TimePickerDebut.Value = new System.DateTime(2023, 6, 7, 0, 0, 0, 0);
            // 
            // BtnSupprimerAbsence
            // 
            this.BtnSupprimerAbsence.Location = new System.Drawing.Point(636, 153);
            this.BtnSupprimerAbsence.Name = "BtnSupprimerAbsence";
            this.BtnSupprimerAbsence.Size = new System.Drawing.Size(121, 58);
            this.BtnSupprimerAbsence.TabIndex = 27;
            this.BtnSupprimerAbsence.Text = "Supprimer";
            this.BtnSupprimerAbsence.UseVisualStyleBackColor = true;
            this.BtnSupprimerAbsence.Click += new System.EventHandler(this.BtnSupprimerAbsence_Click);
            // 
            // AbsencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 319);
            this.Controls.Add(this.groupBox2);
            this.Name = "AbsencesForm";
            this.Text = "Absences";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnModifierAbsence;
        private System.Windows.Forms.Label LblFin;
        private System.Windows.Forms.Label Lbldebut;
        private System.Windows.Forms.DateTimePicker TimePickerFin;
        private System.Windows.Forms.Button BtnAnnulerAbsence;
        private System.Windows.Forms.Button BtnAjouterAbsence;
        private System.Windows.Forms.DateTimePicker TimePickerDebut;
        private System.Windows.Forms.ListBox ListBoxAbsence;
        private System.Windows.Forms.ComboBox comboBoxMotif;
        private System.Windows.Forms.Label LblMotif;
        private System.Windows.Forms.Button BtnSupprimerAbsence;
    }
}