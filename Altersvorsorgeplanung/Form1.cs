using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.HelpProvider hp = new HelpProvider();
            hp.SetHelpString(tbArGesamteAusgaben, "Hilfe1.0");
        }

//        private void bBenötigtesKapitalBerechnen_Click(object sender, EventArgs e)
//        {
//            Decimal Kapital = 0;
//            for (int i = 0; i < nudBKbRentenjahre.Value * 12; i++)
//                Kapital = Kapital * (-((nudBKbZins.Value - dInflation) / 12) / 100 + 1) + Convert.ToDecimal(tbBdmREndwert.Tag);

//            tbBKbBenötigtesKapital.Tag = Kapital.ToString();
//            tbBKbBenötigtesKapital.Text = Math.Round(Kapital, 0).ToString();
//            tbBKbBenötigtesKapital.Text = Tausenderkommasetzer(tbBKbBenötigtesKapital.Text) + "€";

//            dRentnerjahre = nudBKbRentenjahre.Value;
//        }

//        private void bAltersvorsorgeErstellenAbbrechen_Click(object sender, EventArgs e)
//        {
//            gbAltersvorsorgeErstellen.Visible = false;
//            tbEeAVName.Text = "";
//            nudEeAVMonatlicheRate.Value = 0;
//        }

//        private void bBerechnungMonatlicherRenteAbbrechen_Click(object sender, EventArgs e)
//        {
//            gbMonatlicheRentenberechnung.Visible = false;
//        }

//        private void bAltersvosorgeLöschen_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                tvAusgaben.Nodes.Remove(tvAusgaben.SelectedNode);

//                decimal dAltersvorsorgen = 0;
//                for (int i = 0; i < tvAusgaben.Nodes.Count; i++)
//                    dAltersvorsorgen = dAltersvorsorgen + Convert.ToDecimal(tvAusgaben.Nodes[i].Nodes[3].Tag);
//                tbAWertAllerAltersvorsorgen.Tag = dAltersvorsorgen.ToString();
//                tbAWertAllerAltersvorsorgen.Text = Tausenderkommasetzer(Math.Round(dAltersvorsorgen).ToString()) + "€";
//            }
//            catch { }
//        }

//        private void nudAltersvorsorgeMonatlicheRate_ValueChanged(object sender, EventArgs e)
//        {
//            nudAltersvorsorgeJahreBisZurRente_ValueChanged(null, null);
//        }

//        private void nudEeAVZins_ValueChanged(object sender, EventArgs e)
//        {
//            nudAltersvorsorgeJahreBisZurRente_ValueChanged(null, null);
//        }


//        private void neueBerechnungToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            //    dInflation = new decimal(3.5);
//            //    dJahreBisZurRente = 0;
//            //    dRentnerjahre = 0;
//            //    sSpeicherpfad = "";
//            //    nudBdmRInflation.Value = 0;
//            //    nudBdmRJahreBisZurRente.Value = 0;
//            //    nudBdmRJetztigeMonatKosten.Value = 0;
//            //    nudBKbRentenjahre.Value = 0;
//        }

//        private void tbWertAllerAltersvorsorgen_TextChanged(object sender, EventArgs e)
//        {
//            tbFehlenderBetrag.Tag = (Convert.ToDecimal(tbBKbBenötigtesKapital.Tag) - Convert.ToDecimal(tbAWertAllerAltersvorsorgen.Tag)).ToString();
//            tbFehlenderBetrag.Text = Tausenderkommasetzer(Math.Round(Convert.ToDecimal(tbFehlenderBetrag.Tag)).ToString()) + "€";
//        }

//        private void bBenötigteVorsorgeBerechnen_Click(object sender, EventArgs e)
//        {
//            decimal dVorsorgewert = 0;
//            decimal dFehlenderBetrag = Convert.ToDecimal(tbFehlenderBetrag.Tag);
//            decimal dRate = 1;
//            decimal dZinssatz = 5;
//            do
//            {
//                dRate++;

//                dVorsorgewert = 0;
//                for (int i = 0; i < dRentnerjahre * 12; i++)
//                    dVorsorgewert = (dVorsorgewert + dRate) * (1 + (dInflation - dZinssatz) / 100 / 12);
//            }
//            while (dFehlenderBetrag > dVorsorgewert);

//            do
//            {
//                dRate = dRate + new decimal(0.1);

//                dVorsorgewert = 0;
//                for (int i = 0; i < dRentnerjahre * 12; i++)
//                    dVorsorgewert = (dVorsorgewert + dRate) * (1 + (dInflation - dZinssatz) / 100 / 12);
//            }
//            while (dFehlenderBetrag > dVorsorgewert);

//            MessageBox.Show("Rate: " + (dRate - 1).ToString());
//        }

//        private void nudAVBbMonatRate_ValueChanged(object sender, EventArgs e)
//        {
//            nudAVBbJährlicheRate.Value = nudAVBbMonatRate.Value * 12;
//        }

//        private void nudAVBbJährlicheRate_ValueChanged(object sender, EventArgs e)
//        {
//            nudAVBbMonatRate.Value = nudAVBbJährlicheRate.Value / 12;
//        }
//        private void nudIWertanpassung_Enter(object sender, EventArgs e)
//        {
//            decimal dBarwert = nudIKaufpreis.Value * 1000 * (decimal)(Math.Pow(Convert.ToDouble(1 + dInflation / 100), Convert.ToDouble(nudIAbtragende.Value - nudIKaufjahr.Value)));
//            MessageBox.Show("Theoretischer Barwert der Immobilie: " + Tausenderkommasetzer(Math.Round(dBarwert).ToString()) + "€", "Theoretischer Barwert");
//        }

//        private void bZurück_Click(object sender, EventArgs e)
//                {
//                    Rentenratenberechnung
//                }

//        private void bWeiter_Click(object sender, EventArgs e)
//        {
//            if (bWeiter.Tag == "0")
//            {
//                dJahreBisZurRente = nudBdmRJahreBisZurRente.Value;
//                gbAusgabenreduzierung.Visible = true;
//                bZurück.Enabled = true;
//                bWeiter.Tag = "2";
//            }
//            else if (bWeiter.Tag == "1")
//            {

//            }
//        }

//        private void bARAusgabeLöschen_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                tvAusgaben.Nodes.Remove(tvAusgaben.SelectedNode);
//            }
//            catch { }
//        }


//        void AusgabenBerechnen()
//                {
//                    decimal Ausgabe = 0;
//                    Immobilie Immobilie = new Immobilie();

//                    foreach (TreeNode tn in tvAusgaben.Nodes)
//                    Ausgabe = Ausgabe + ((Immobilie)(tn.Tag)).
//                        tbArGesamteAusgaben.Text = 
//                }
    }
}
