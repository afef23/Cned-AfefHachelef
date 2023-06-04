using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_portfolio
{
    public partial class ConfirmationForm : Form
    {
        public bool confirmation { get; private set; }

        public ConfirmationForm()
        {
            InitializeComponent();
            confirmation = false;

        }



        private void BtnConfirmation_Click(object sender, EventArgs e)
        {
            confirmation = true;
            this.Close();
        }

        private void LblConfirmation_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            confirmation = false;
            this.Close();
        }
    }
}
