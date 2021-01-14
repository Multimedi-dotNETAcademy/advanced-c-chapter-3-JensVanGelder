using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DigitaleKluis
{
    public partial class Form1 : Form
    {
        private int aantalpogingen;
        private int aantalpogingen2;
        DigitaleKluis kluis = new DigitaleKluis(42);
        DigitaleKluis kluis2 = new DigitaleKluis(36);
        public Form1()
        {
            InitializeComponent();

        }

        private void btnKluis_Click(object sender, EventArgs e)
        {
            lblKluis.Text = $"Kluis 1:  {kluis.Code}";
            aantalpogingen++;
            lblAttempts.Text = $"Attempts: {aantalpogingen}";
            MessageBox.Show(kluis.TryCode(Convert.ToInt32(numKluis.Value)),"Code was:");
            if (kluis.CanShowCode)
            {
                lblKluis.Text = $"Kluis 1:  {kluis.Code}";
                btnKluis.Enabled = false;
            }
        }

        private void btnKluis2_Click(object sender, EventArgs e)
        {
            lblKluis2.Text = $"Kluis 2:  {kluis.Code}";
            aantalpogingen2++;
            lblAttempts2.Text = $"Attempts: {aantalpogingen2}";
            MessageBox.Show(kluis2.TryCode(Convert.ToInt32(numKluis2.Value)), "Code was:");
            if (kluis2.CanShowCode)
            {
                lblKluis2.Text = $"Kluis 2:  {kluis.Code}";
                btnKluis2.Enabled = false;
            }
        }
    }
}
