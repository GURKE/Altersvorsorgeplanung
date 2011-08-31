using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    public partial class fAltersvorsorgerechner : Form
    {
        Person[] Personen = new Person[2];
        decimal dInflation = new decimal(3.5);
        string sSpeicherpfad = "";

        public fAltersvorsorgerechner()
        {
            InitializeComponent();
            Personen[0] = new Person();
            Personen[0].Farbe = Color.GreenYellow;
            Personen[1] = new Person();
            Personen[1].Farbe = Color.Goldenrod;
            pSichtblende.Location = new Point(6, 160);
            pSichtblende.BringToFront();
            nudGAInRenteGehenImJahr.Minimum = DateTime.Today.Year;
            nudGAInRenteGehenImJahr.Maximum = DateTime.Today.Year + 50;
            nudGaZPInRenteGehenImJahr.Minimum = DateTime.Today.Year;
            nudGaZPInRenteGehenImJahr.Maximum = DateTime.Today.Year + 50;
        }

        public class SpeicherDatei
        {
            public decimal Inflation;
            public Person[] Personen = new Person[2];

            public List<object> Ausgaben = new List<object>();
            public List<object> Einnahmen = new List<object>();
        }

        public class Person
        {
            public bool Aktiv = false;
            public string Name = "Person";
            public Color Farbe;
            public decimal JahrRentenbegin;
            public decimal JahreBisZurRente;
            public decimal Rentnerjahre;
        }

        public class Immobilie
        {
            public string Name;
            public decimal Kaufpreis;
            public decimal Kaufjahr;
            public decimal Restschulden;
            public decimal MonatRate;
            public decimal Abtragende;
            public decimal Wertanpassung;
            public decimal Bruttozins;
            public decimal Barwert;
            public decimal RenteProMonat;
            public int PositionEingabe;
        }

        public class FesteAusgabe
        {
            public decimal MonatKosten;
            public decimal MonatKostenInclInf;
        }

        public class Kinder
        {
            public decimal MonatKosten;
            public decimal MonatKostenInclInf;
        }

        public class Altersvorsorge
        {
            public string Name;
            public decimal IstKapital;
            public decimal Nettozins;
            public decimal MonatSparRate;
            public decimal Barwert;
            public decimal MonatRate;
            public decimal NettozinsAufBarwert;
            public int PersonID;
            public int PositionAusgabe;
        }

        private string Tausenderkommasetzer(decimal dZahl, bool bRunden)
        {
            string sZahl = dZahl.ToString();
            if (bRunden)
                sZahl = Math.Round(dZahl).ToString();

            string[] Kommas = sZahl.Split(',');

            double AnzZeichen = Kommas[0].Count();
            for (int i = 0; i < Math.Round((AnzZeichen + 1) / 3) - 1; i++)
                Kommas[0] = Kommas[0].Substring(0, Kommas[0].Count() - (4 * i + 3)) + "." + Kommas[0].Substring(Kommas[0].Count() - (4 * i + 3));

            return Kommas[0];
        }

        private decimal Rentenratenberechnung(double Startkapital, double Zins, double Zeit)
        {
            try
            {
                double Rate;
                if (Zins == 0)
                    Rate = Startkapital / Zeit;
                else
                    Rate = (Zins / 100) * (Startkapital * Math.Pow(1 + Zins / 100, Zeit)) / (Math.Pow(1 + Zins / 100, Zeit) - 1);

                return Convert.ToDecimal(Rate);
            }
            catch
            {
                return -1;
            }
        }

        void AusgabeHinzufügen(object Ausgabe)
        {            
            if (Ausgabe.GetType() == typeof(Immobilie))
            {
                Immobilie Immobilie = (Immobilie)(Ausgabe);

                tvAusgaben.Nodes.Add("Immobilie: " + Immobilie.Name);
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Nodes.Add("Rate: " + Immobilie.MonatRate.ToString() + "€/Monat");
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Nodes.Add("Andere Eigenschaften");
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Nodes[1].Nodes.Add("Kaufpreis: " + Tausenderkommasetzer(Immobilie.Kaufpreis, false) + "€");
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Nodes[1].Nodes.Add("Kaufjahr: " + Immobilie.Kaufjahr.ToString());
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Nodes[1].Nodes.Add("Restschulden: " + Tausenderkommasetzer(Immobilie.Restschulden, false) + "€");
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Nodes[1].Nodes.Add("Monatliche Rate: " + Tausenderkommasetzer(Immobilie.MonatRate, false) + "€");
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Nodes[1].Nodes.Add("Abtragende: " + Immobilie.Abtragende.ToString());
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Nodes[1].Nodes.Add("Wertanpassung: " + Tausenderkommasetzer(Immobilie.Wertanpassung, false) + "€");
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Nodes[1].Nodes.Add("Bruttozins: " + Immobilie.Bruttozins.ToString() + "%");
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Nodes[1].Nodes.Add("Rente/Monat: " + Tausenderkommasetzer(Immobilie.RenteProMonat, true) + "€");
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Tag = Immobilie;
            }
            else if (Ausgabe.GetType() == typeof(FesteAusgabe))
            {
                FesteAusgabe FesteAusgabe = (FesteAusgabe)(Ausgabe);

                tvAusgaben.Nodes.Add("Feste Ausgaben");
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Nodes.Add("Feste Ausgaben: " + Tausenderkommasetzer(FesteAusgabe.MonatKosten, false) + "€");
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Nodes.Add("Feste Ausgaben (incl Inflation) : " + Tausenderkommasetzer(FesteAusgabe.MonatKostenInclInf, true) + "€");
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Tag = FesteAusgabe;
            }
            else if (Ausgabe.GetType() == typeof(Kinder))
            {
                Kinder kinder = (Kinder)(Ausgabe);

                tvAusgaben.Nodes.Add("Kinder");
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Nodes.Add("Kosten der Kinder: " + Tausenderkommasetzer(kinder.MonatKosten, false) + "€");
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Nodes.Add("Kosten der Kinder (incl Inflation) : " + Tausenderkommasetzer(kinder.MonatKostenInclInf, true) + "€");
                tvAusgaben.Nodes[tvAusgaben.Nodes.Count - 1].Tag = kinder;
            }

            AusgabenZumBeginDerRenteBerechnen();
        }

        private void bARAusgabeHinzufügen_Click_1(object sender, EventArgs e)
        {
            cbAaAusgabeAuswählen.SelectedIndex = -1;
            gbAusgabenauswählen.Visible = true;
        }

        private void bAusgabeBearbeiten_Click(object sender, EventArgs e)
        {
            if (tvAusgaben.SelectedNode == null)
                return;
            
            try
            {
                bAusgabeBearbeiten.Tag = tvAusgaben.SelectedNode.Index;
                gbAusgabenauswählen.Visible = true;
                if (typeof(Immobilie) == tvAusgaben.SelectedNode.Tag.GetType())
                {
                    bAusgabeBearbeiten.Tag = -1;
                    return;
                    cbAaAusgabeAuswählen.SelectedIndex = 1;
                    Immobilie i = (Immobilie)(tvAusgaben.SelectedNode.Tag);
                    tbIName.Text = i.Name;
                    nudIKaufjahr.Value = i.Kaufjahr;
                    nudIKaufpreis.Value = i.Kaufpreis / 1000;
                    nudIMonatRate.Value = i.MonatRate;
                    nudIAbtragende.Value = i.Abtragende;
                    nudIRestschulden.Value = i.Restschulden / 1000;
                    nudIWertanpassung.Value = i.Wertanpassung / 1000;
                    nudIZins.Value = i.Bruttozins;
                    bIBerechnen.Tag = i.PositionEingabe;
                }
                else if (typeof(FesteAusgabe) == tvAusgaben.SelectedNode.Tag.GetType())
                {
                    cbAaAusgabeAuswählen.SelectedIndex = 0;
                    FesteAusgabe Fa = (FesteAusgabe)(tvAusgaben.SelectedNode.Tag);
                    nudFAMonatKosten.Value = Fa.MonatKosten;
                }
                else if (typeof(Kinder) == tvAusgaben.SelectedNode.Tag.GetType())
                {
                    cbAaAusgabeAuswählen.SelectedIndex = 2;
                    Kinder k = (Kinder)(tvAusgaben.SelectedNode.Tag);
                    nudFAMonatKosten.Value = k.MonatKosten;
                }
            }
            catch { }
        }

        private void bIAbbrechen_Click(object sender, EventArgs e)
        {
            bIBerechnen.Tag = -1;
            bAusgabeBearbeiten.Tag = -1;
            gbImmobilie.Visible = false;
            gbAusgabenauswählen.Visible = false;
        }

        private void bIBerechnen_Click(object sender, EventArgs e)
        {
            if (tbIBarwert.Text == "0")
            {
                MessageBox.Show("Der Barwert kann noch nicht ausgerechnet werden. Bitte tragen sie fehlende Werte ein.", "Barwert noch nicht berechnet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tbIRenteProMonat.Text == "0")
            {
                if (tbIRenteProMonat_Berechnen() == false)
                {
                    MessageBox.Show("Die Rente pro Monat konnte noch nicht berechnet werden. Bitte tragen sie fehlende Werte ein.", "Rente/Monat noch nicht berechnet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (bAusgabeBearbeiten.Tag != "-1")
            {
                lvEinnahmen.Items.RemoveAt((int)(bIBerechnen.Tag));
                tvAusgaben.Nodes.RemoveAt((int)(bAusgabeBearbeiten.Tag));
                bAusgabeBearbeiten.Tag = -1;
            }

            Immobilie i = new Immobilie();
            i.Name = tbIName.Text;
            i.Kaufpreis = nudIKaufpreis.Value * 1000;
            i.Kaufjahr = nudIKaufjahr.Value;
            i.Restschulden = nudIRestschulden.Value * 1000;
            i.MonatRate = nudIMonatRate.Value;
            i.Abtragende = nudIAbtragende.Value;
            i.Wertanpassung = nudIWertanpassung.Value * 1000;
            i.Bruttozins = nudIZins.Value;
            i.Barwert = Convert.ToDecimal(tbIBarwert.Tag);
            i.RenteProMonat = Convert.ToDecimal(tbIRenteProMonat.Tag);

            i.PositionEingabe = lvEinnahmen.Items.Count;
            
            AusgabeHinzufügen(i);
            gbAusgabenauswählen.Visible = false;
            
            AusgabenZumBeginDerRenteBerechnen();

            Altersvorsorge AV = new Altersvorsorge();
            AV.Name = i.Name;
            AV.Barwert = i.Barwert - i.Restschulden + i.MonatRate * Personen[0].JahreBisZurRente * 12;
            AV.MonatRate = i.RenteProMonat;
            AV.NettozinsAufBarwert = i.Bruttozins;
            AV.PersonID = 2;
            AV.PositionAusgabe = tvAusgaben.Nodes.Count - 1;
            Altersvorsorgehinzufügen(AV);    
        }

        private void nudIKaufpreis_ValueChanged(object sender, EventArgs e)
        {
            nudIWertanpassung.Maximum = nudIKaufpreis.Value;
            nudIWertanpassung.Minimum = -nudIKaufpreis.Value;
            nudIRestschulden.Maximum = nudIKaufpreis.Value * new decimal(1.5);

            BarwertImmobilieBerechnen();
        }

        private void nudIMonatRate_ValueChanged(object sender, EventArgs e)
        {
            nudIJährlicheRate.Value = nudIMonatRate.Value * 12;
        }

        private void nudIJährlicheRate_ValueChanged(object sender, EventArgs e)
        {
            nudIMonatRate.Value = nudIJährlicheRate.Value / 12;
        }

        private void nudIKaufjahr_ValueChanged(object sender, EventArgs e)
        {
            nudIAbtragende.Minimum = nudIKaufjahr.Value + 1;

            BarwertImmobilieBerechnen();
        }

        private void nudIAbtragende_ValueChanged(object sender, EventArgs e)
        {
            BarwertImmobilieBerechnen();
        }

        void BarwertImmobilieBerechnen()
        {
            try
            {
                decimal dBarwert = nudIKaufpreis.Value * 1000 * (decimal)(Math.Pow(Convert.ToDouble(1 + dInflation / 100), Convert.ToDouble(nudIAbtragende.Value - nudIKaufjahr.Value)));
                tbIBarwert.Text = Tausenderkommasetzer(Math.Round(dBarwert) + Convert.ToInt32(nudIWertanpassung.Value), false);
                tbIBarwert.Tag = dBarwert.ToString();
            }
            catch
            {
                tbIBarwert.Text = "0";
                tbIBarwert.Tag = 0;
            }
        }

        private void nudIWertanpassung_ValueChanged(object sender, EventArgs e)
        {
            BarwertImmobilieBerechnen();
        }

        private void nudIZins_ValueChanged(object sender, EventArgs e)
        {
            tbIRenteProMonat_Berechnen();
        }

        bool tbIRenteProMonat_Berechnen()
        {
            try
            {
                if (Rentenratenberechnung(Convert.ToDouble(tbIBarwert.Tag) - Convert.ToDouble(nudIRestschulden.Value + 12 * nudIMonatRate.Value * Personen[0].Rentnerjahre), Convert.ToDouble(nudIZins.Value + dInflation), Convert.ToDouble(Personen[0].Rentnerjahre)) == new decimal(-1))
                    return false;
                tbIRenteProMonat.Tag = (Rentenratenberechnung(Convert.ToDouble(tbIBarwert.Tag), Convert.ToDouble(nudIZins.Value + dInflation), Convert.ToDouble(Personen[0].Rentnerjahre)) / 12).ToString();
                tbIRenteProMonat.Text = Tausenderkommasetzer(Convert.ToDecimal(tbIRenteProMonat.Tag), true);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void tbIBarwert_TextChanged(object sender, EventArgs e)
        {
            tbIRenteProMonat_Berechnen();
        }

        private void cbAaAusgabeAuswählen_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbImmobilie.Visible = false;
            gbFesteAusgaben.Visible = false;
            nudFAMonatKosten.Value = 0;

            if (cbAaAusgabeAuswählen.SelectedIndex == 0 || cbAaAusgabeAuswählen.SelectedIndex == 2)
            {
                if (cbAaAusgabeAuswählen.SelectedIndex == 0)
                    gbFesteAusgaben.Text = "Feste Ausgaben";
                else
                    gbFesteAusgaben.Text = "Ausgaben für Kinder";

                nudFAInflation.Value = dInflation;
                nudFAJahreBisZurRente.Value = Personen[0].JahreBisZurRente;
                gbAusgabenauswählen.Size = new Size(220, 221);
                gbFesteAusgaben.Visible = true;
                gbFesteAusgaben.BringToFront();
            }
            else if (cbAaAusgabeAuswählen.SelectedIndex == 1)
            {
                tbIName.Text = "";
                nudIKaufpreis.Value = 0;
                nudIKaufjahr.Value = 2000;
                nudIMonatRate.Value = 0;
                nudIAbtragende.Value = DateTime.Today.Year;
                nudIRestschulden.Value = 0;
                nudIZins.Value = 0;
                nudIWertanpassung.Value = 0;

                gbImmobilie.Visible = true;
                gbAusgabenauswählen.Size = new Size(220, 427);
                gbAusgabenauswählen.BringToFront();
            }
        }

        private void nudIMonatRate_ValueChanged_1(object sender, EventArgs e)
        {
            nudIJährlicheRate.Value = nudIMonatRate.Value * 12;
        }

        private void nudIJährlicheRate_ValueChanged_1(object sender, EventArgs e)
        {
            nudIMonatRate.Value = Math.Round(nudIJährlicheRate.Value / 12);
        }

        private void nudBdmRJahreBisZurRente_ValueChanged(object sender, EventArgs e)
        {
            Personen[0].JahreBisZurRente = nudGaJahreBisZurRente.Value;
            nudGAInRenteGehenImJahr.Value = DateTime.Today.Year + Personen[0].JahreBisZurRente;
            GAAufVollständigkeitÜberprüfen();
        }

        private void nudGaRentnerjahre_ValueChanged(object sender, EventArgs e)
        {
            Personen[0].Rentnerjahre = nudGaRentnerjahre.Value;
            GAAufVollständigkeitÜberprüfen();
        }

        private void nudGaInflation_ValueChanged(object sender, EventArgs e)
        {
            dInflation = nudGaInflation.Value;
            GAAufVollständigkeitÜberprüfen();
        }

        private void nudGAInRenteGehenImJahr_ValueChanged(object sender, EventArgs e)
        {
            nudGaJahreBisZurRente.Value = nudGAInRenteGehenImJahr.Value - DateTime.Today.Year;
            Personen[0].JahrRentenbegin = nudGAInRenteGehenImJahr.Value;
            GAAufVollständigkeitÜberprüfen();
        }

        private void cbGaZweitePerson_CheckedChanged(object sender, EventArgs e)
        {
            nudGaZPJahreBisZurRente.Enabled = cbGaZweitePerson.Checked;
            nudGaZPInRenteGehenImJahr.Enabled = cbGaZweitePerson.Checked;
            nudGAZPRentnerjahre.Enabled = cbGaZweitePerson.Checked;
            lGA2Person.Enabled = cbGaZweitePerson.Checked;
            lName2Person.Enabled = cbGaZweitePerson.Checked;
            tbGAName2Per.Enabled = cbGaZweitePerson.Checked;
            Personen[1].Aktiv = cbGaZweitePerson.Checked;

            if (cbGaZweitePerson.Checked)
            {
                lGA1Person.BackColor = Personen[0].Farbe;
                lGA2Person.BackColor = Personen[1].Farbe;
            }
            else
            {
                lGA1Person.BackColor = SystemColors.Control;
                lGA2Person.BackColor = SystemColors.Control;
            }
        }

        void AusgabenZumBeginDerRenteBerechnen()
        {
            if (tvAusgaben.Nodes[0].Text == "Feste Ausgaben")
            {
                FesteAusgabe FesteAusgabe = new FesteAusgabe();
                Immobilie Immobilie = new Immobilie();
                Kinder Kinder = new Kinder();

                decimal dAusgaben = 0;
                for (int i = 0; i < tvAusgaben.Nodes.Count; i++)
                {
                    if (tvAusgaben.Nodes[i].Tag.GetType() == FesteAusgabe.GetType())
                    {
                        FesteAusgabe = (FesteAusgabe)(tvAusgaben.Nodes[i].Tag);
                        dAusgaben = dAusgaben + FesteAusgabe.MonatKostenInclInf;
                    }
                    else if (tvAusgaben.Nodes[i].Tag.GetType() == Immobilie.GetType())
                    {
                        Immobilie = (Immobilie)(tvAusgaben.Nodes[i].Tag);
                        dAusgaben = dAusgaben - Immobilie.MonatRate;
                    }
                    else if (tvAusgaben.Nodes[i].Tag.GetType() == Kinder.GetType())
                    {
                        Kinder = (Kinder)(tvAusgaben.Nodes[i].Tag);
                        dAusgaben = dAusgaben - Kinder.MonatKostenInclInf;
                    }
                }
                tbAAusgabenZumRentenbegin.Tag = dAusgaben;
                tbAAusgabenZumRentenbegin.Text = Tausenderkommasetzer(dAusgaben, true) + "€";
                EinahmenBerechnen();
            }
        }

        private void nudFAJetztigeMonatKosten_ValueChanged(object sender, EventArgs e)
        {
            tbFAEndwert.Tag = (Convert.ToDouble(nudFAMonatKosten.Value) * Math.Pow((Convert.ToDouble(nudFAInflation.Value) / 100 + 1), Convert.ToDouble(nudFAJahreBisZurRente.Value))).ToString();
            tbFAEndwert.Text = Tausenderkommasetzer(Convert.ToDecimal(tbFAEndwert.Tag), true) + "€";
        }

        private void nudFAJahreBisZurRente_ValueChanged(object sender, EventArgs e)
        {
            nudFAJetztigeMonatKosten_ValueChanged(null, null);
            nudGaJahreBisZurRente.Value = nudFAJahreBisZurRente.Value;
        }

        private void nudFAInflation_ValueChanged(object sender, EventArgs e)
        {
            nudFAJetztigeMonatKosten_ValueChanged(null, null);
            nudGaInflation.Value = nudFAInflation.Value;
        }

        private void bFAÜbernehmen_Click(object sender, EventArgs e)
        {
            if ((int)(bAusgabeBearbeiten.Tag) != -1)
            {
                tvAusgaben.Nodes.RemoveAt((int)(bAusgabeBearbeiten.Tag));
                bAusgabeBearbeiten.Tag = -1;
            }

            if (tbFAEndwert.Text == "0")
            {
                nudFAJetztigeMonatKosten_ValueChanged(null, null);
                if (tbFAEndwert.Text == "0")
                    MessageBox.Show("Die monatlichen Kosten konnten noch nicht berechnet werden!", "Monatliche Kosten nicht berechnet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cbAaAusgabeAuswählen.SelectedIndex == 0) //Feste Ausgaben
            {
                List<TreeNode> ltn = new List<TreeNode>();
                foreach (TreeNode tn in tvAusgaben.Nodes)
                    ltn.Add(tn);
                tvAusgaben.Nodes.Clear();

                FesteAusgabe fa = new FesteAusgabe();
                fa.MonatKosten = nudFAMonatKosten.Value;
                fa.MonatKostenInclInf = Convert.ToDecimal(tbFAEndwert.Tag);


                AusgabeHinzufügen(fa);

                foreach (TreeNode tn in ltn)
                    tvAusgaben.Nodes.Add(tn);

                AusgabenZumBeginDerRenteBerechnen();

            }
            else if (cbAaAusgabeAuswählen.SelectedIndex == 2)
            {
                Kinder kinder = new Kinder();
                kinder.MonatKosten = nudFAMonatKosten.Value;
                kinder.MonatKostenInclInf = Convert.ToDecimal(tbFAEndwert.Tag);
                AusgabeHinzufügen(kinder);
            }
            gbAusgabenauswählen.Visible = false;
        }

        private void beendenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bFAAbbrechen_Click(object sender, EventArgs e)
        {
            gbAusgabenauswählen.Visible = false;
            gbFesteAusgaben.Visible = false;
        }

        void Altersvorsorgehinzufügen(object oAltersvorsorge) //string Name, decimal Rate, string Zinssatz, decimal Barwert)
        {
            List<ListViewItem> lvi = new List<ListViewItem>();
            if (Convert.ToInt16(bIBerechnen.Tag) != -1)
            {
                for (int i = lvEinnahmen.Items.Count - 1;  i > Convert.ToInt16(bIBerechnen.Tag) - 1; i--)
                {
                    lvi.Add(lvEinnahmen.Items[i]);
                    lvEinnahmen.Items.RemoveAt(i);
                }
            }

            Altersvorsorge AV = (Altersvorsorge)(oAltersvorsorge);
            lvEinnahmen.Items.AddRange(new ListViewItem[] { new ListViewItem(new string[] {AV.Name, 
                    Tausenderkommasetzer(AV.MonatRate, false), 
                    AV.NettozinsAufBarwert.ToString(), Tausenderkommasetzer(AV.Barwert, true)}) });

            lvEinnahmen.Items[lvEinnahmen.Items.Count - 1].Tag = AV;
            
            if (AV.PersonID == 2)
                lvEinnahmen.Items[lvEinnahmen.Items.Count - 1].BackColor = Color.LightBlue;
            else
                lvEinnahmen.Items[lvEinnahmen.Items.Count - 1].BackColor = Personen[AV.PersonID].Farbe;

            lvi.Reverse();
            foreach (ListViewItem l in lvi)
                lvEinnahmen.Items.Add(l);

            bIBerechnen.Tag = -1;

            EinahmenBerechnen();
        }

        private void EinahmenBerechnen()
        {
            decimal dGesamtrate = 0;
            decimal dGesamtbarwert = 0;
            for (int i = 0; i < lvEinnahmen.Items.Count; i++)
            {
                if (lvEinnahmen.Items[i].Text == "")
                    break;

                dGesamtrate = dGesamtrate + Convert.ToDecimal(lvEinnahmen.Items[i].SubItems[1].Text);
                dGesamtbarwert = dGesamtbarwert + Convert.ToDecimal(lvEinnahmen.Items[i].SubItems[3].Text);
            }
            lvEinnahmenErgebnis.Items[0].SubItems[1].Text = Tausenderkommasetzer(dGesamtrate, false);
            lvEinnahmenErgebnis.Items[0].SubItems[3].Text = Tausenderkommasetzer(dGesamtbarwert, false);
            lvEinnahmenErgebnis.Items[1].SubItems[1].Text = Tausenderkommasetzer(Convert.ToDecimal(tbAAusgabenZumRentenbegin.Tag) - dGesamtrate, false);
        }

        private void bEEinnahmeHinzufügen_Click(object sender, EventArgs e)
        {
            cbAVaAltersvorsorgeAuswählen.SelectedIndex = -1;
            gbAltersvorsorgeAuswählen.Visible = true;
        }

        private void cbAVaAltersvorsorgeAuswählen_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbAltersvorsorgeErstellen.Visible = false;
            gbAltersvorsorgebetragBerechnen.Visible = false;

            if (cbAVaAltersvorsorgeAuswählen.SelectedIndex == 0)
            {
                gbAltersvorsorgeAuswählen.Size = new Size(220, gbAltersvorsorgeErstellen.Height + 49);
                gbAltersvorsorgeErstellen.Location = new Point(6, 43);
                gbAltersvorsorgeErstellen.Visible = true;
                gbAltersvorsorgeErstellen.BringToFront();
                nudEeAVMonatlicheRate.Value = 0;

                cbEeAVPersonenauswahl.Enabled = Personen[1].Aktiv;
                cbEeAVPersonenauswahl.Items.Clear();
                cbEeAVPersonenauswahl.Items.Add(Personen[0].Name);
                if (cbEeAVPersonenauswahl.Enabled = Personen[1].Aktiv)
                {
                    cbEeAVPersonenauswahl.Items.Add(Personen[1].Name);
                    cbEeAVPersonenauswahl.Items.Add("Beide");
                }
                cbEeAVPersonenauswahl.SelectedIndex = 0;
            }
            else if (cbAVaAltersvorsorgeAuswählen.SelectedIndex == 1)
            {
                gbAltersvorsorgeAuswählen.Size = new Size(220, gbAltersvorsorgebetragBerechnen.Height + 49);
                gbAltersvorsorgebetragBerechnen.Location = new Point(6, 43);
                gbAltersvorsorgebetragBerechnen.Visible = true;
                gbAltersvorsorgebetragBerechnen.BringToFront();
                nudAVBbIstKapital.Value = 0;
                nudAVBbJährlicheRate.Value = 0;
                nudAVBbZins.Value = 0;
                nudAVBbZinsAufBarwert.Value = 0;

                cbAVBbPersonenauswahl.Enabled = Personen[1].Aktiv;
                cbAVBbPersonenauswahl.Items.Clear();
                cbAVBbPersonenauswahl.Items.Add(Personen[0].Name);
                if (cbAVBbPersonenauswahl.Enabled = Personen[1].Aktiv)
                {
                    cbAVBbPersonenauswahl.Items.Add(Personen[1].Name);
                    cbAVBbPersonenauswahl.Items.Add("Beide");
                }
                cbAVBbPersonenauswahl.SelectedIndex = 0;
            }
        }

        private void bAVBbBerechnen_Click(object sender, EventArgs e)
        {
            if (tbAVBbName.Text == "")
            {
                MessageBox.Show("Es muss ein Name angegeben werden, um die Versorgungsart übernehmen zu können.", "Kein Name angegeben", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbAVBbBarwert.Text == "0")
            {
                MessageBox.Show("Der Barwert konnte nicht berechnet werden. Bitte überprüfen sie ihre Angaben.", "Kein Name angegeben", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal dRenteProJahr = Rentenratenberechnung(Convert.ToDouble(tbAVBbBarwert.Tag), Convert.ToDouble((double)(nudAVBbZinsAufBarwert.Value + dInflation)), Convert.ToDouble(Personen[0].Rentnerjahre));

            Altersvorsorge AV = new Altersvorsorge();
            AV.Name = tbAVBbName.Text;
            AV.IstKapital = nudAVBbIstKapital.Value;
            AV.MonatSparRate = nudAVBbMonatRate.Value;
            AV.Nettozins = nudAVBbZins.Value;
            AV.NettozinsAufBarwert = nudAVBbZinsAufBarwert.Value + dInflation;
            AV.Barwert = Convert.ToDecimal(tbAVBbBarwert.Text);
            AV.MonatRate = dRenteProJahr / 12;
            AV.PersonID = cbAVBbPersonenauswahl.SelectedIndex;

            Altersvorsorgehinzufügen(AV);

            gbAltersvorsorgeAuswählen.Visible = false;

            tbAVBbName.Text = "";
            nudAVBbMonatRate.Value = 0;
        }

        private void bEeAVHinzufügen_Click(object sender, EventArgs e)
        {
            if (tbEeAVName.Text == "")
            {
                MessageBox.Show("Bitte geben sie einen Namen an.", "Namen angeben", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbEeAVWertDerAltersvorsorge.Text == "0")
            {
                MessageBox.Show("Der Wert für die Altersvorsorge konnte noch nicht ausgerechnet werden. Bitte geben sie alle Werte an.", "Barwert noch nicht berechnet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Altersvorsorge Altersvorsorge = new Altersvorsorge();
            Altersvorsorge.Name = tbEeAVName.Text;
            Altersvorsorge.MonatRate = nudEeAVMonatlicheRate.Value;
            Altersvorsorge.Barwert = Convert.ToDecimal(tbEeAVWertDerAltersvorsorge.Tag);
            Altersvorsorge.PersonID = cbEeAVPersonenauswahl.SelectedIndex;

            Altersvorsorgehinzufügen(Altersvorsorge);

            gbAltersvorsorgeAuswählen.Visible = false;

            tbEeAVName.Text = "";
            nudEeAVMonatlicheRate.Value = 0;
        }

        private void nudEeAVMonatlicheRate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal dZins = new decimal(3.5);
                decimal dVorsorgewert = 0;
                for (int i = 0; i < Personen[0].Rentnerjahre * 12; i++)
                    dVorsorgewert = (dVorsorgewert + nudEeAVMonatlicheRate.Value) * (1 + (dInflation - dZins) / 100 / 12);

                tbEeAVWertDerAltersvorsorge.Text = Tausenderkommasetzer(dVorsorgewert, true) + "€";
                tbEeAVWertDerAltersvorsorge.Tag = (dVorsorgewert).ToString();
            }
            catch
            { }
        }

        private void nudAVBbIstKapital_ValueChanged(object sender, EventArgs e)
        {
            BarwertMitStartkapitalBerechnen();
        }

        private void nudAVBbZins_ValueChanged(object sender, EventArgs e)
        {
            nudAVBbIstKapital_ValueChanged(null, null);
            BarwertMitStartkapitalBerechnen();
        }

        private void bNeundorf_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = @"C:\Dokumente und Einstellungen\Julian.NEUNDORF-KELLER\Eigene Dateien\Neundorf.xml";
            ladenToolStripMenuItem_Click_1(null, null);
        }

        private void nudAVBbMonatRate_ValueChanged(object sender, EventArgs e)
        {
            nudAVBbJährlicheRate.Value = nudAVBbMonatRate.Value * 12;
            BarwertMitStartkapitalBerechnen();
        }

        private void nudAVBbJährlicheRate_ValueChanged(object sender, EventArgs e)
        {
            nudAVBbMonatRate.Value = nudAVBbJährlicheRate.Value / 12;
            BarwertMitStartkapitalBerechnen();
        }

        void BarwertMitStartkapitalBerechnen()
        {
            decimal dBarwert = nudAVBbIstKapital.Value;
            for (int i = 0; i < Math.Truncate(Personen[0].JahreBisZurRente); i++)
                dBarwert = dBarwert * ((nudAVBbZins.Value + dInflation) / 100 + 1) + nudAVBbJährlicheRate.Value;

            dBarwert = dBarwert + nudAVBbJährlicheRate.Value * (Personen[0].JahreBisZurRente - Math.Truncate(Personen[0].JahreBisZurRente));
            dBarwert = dBarwert * ((nudAVBbZins.Value + dInflation) / 100 * (Personen[0].JahreBisZurRente - Math.Truncate(Personen[0].JahreBisZurRente)) + 1);

            tbAVBbBarwert.Tag = dBarwert.ToString();
            tbAVBbBarwert.Text = Tausenderkommasetzer(dBarwert, true);
        }

        private void bAVBbAbbrechen_Click(object sender, EventArgs e)
        {
            gbAltersvorsorgeAuswählen.Visible = false;
        }

        private void bEEinahmeLöschen_Click(object sender, EventArgs e)
        {
            lvEinnahmen.Items.Remove(lvEinnahmen.SelectedItems[0]);
            EinahmenBerechnen();
        }

        private void bARAusgabeLöschen_Click(object sender, EventArgs e)
        {
            try
            {
                tvAusgaben.Nodes.Remove(tvAusgaben.SelectedNode);
                AusgabenZumBeginDerRenteBerechnen();
            }
            catch { }
        }

        private void bEeAVAbbrechen_Click(object sender, EventArgs e)
        {
            gbAltersvorsorgeAuswählen.Visible = false;
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sSpeicherpfad != "")
            {
                SpeicherDatei SD = new SpeicherDatei();
                SD.Inflation = dInflation;
                SD.Personen = Personen;

                foreach (TreeNode Tn in tvAusgaben.Nodes)
                {
                    SD.Ausgaben.Add(Tn.Tag);
                }

                foreach (ListViewItem lvi in lvEinnahmen.Items)
                    if (lvi.Text != "")
                        SD.Einnahmen.Add(lvi.Tag);
                    else
                        break;

                XmlSerializer ser = new XmlSerializer(typeof(SpeicherDatei), new Type[] {typeof(FesteAusgabe), typeof(Immobilie), typeof(Kinder), typeof(Altersvorsorge)});
                TextWriter tw = new StreamWriter(@sSpeicherpfad);
                ser.Serialize(tw, SD);
                tw.Close();
            }
            else
                speichernUnterToolStripMenuItem_Click(null, null);
        }

        private void speichernUnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Xml Dateien (*.xml)|*.xml|Alle Dateien (*.*)|*.*";
            DialogResult dr = sfd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                sSpeicherpfad = sfd.FileName;
                speichernToolStripMenuItem_Click(null, null);
            }

        }

        private void ladenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                neueBerechnungToolStripMenuItem_Click(null, null);
                XmlSerializer ser = new XmlSerializer(typeof(SpeicherDatei), new Type[] { typeof(FesteAusgabe), typeof(Immobilie), typeof(Kinder), typeof(Altersvorsorge) });
                StreamReader sr = new StreamReader(@openFileDialog1.FileName);
                SpeicherDatei SpeicherDatei = (SpeicherDatei)ser.Deserialize(sr);
                sr.Close();

                nudGaInflation.Value = SpeicherDatei.Inflation;
                tbGAName1Per.Text = SpeicherDatei.Personen[0].Name;
                nudGaRentnerjahre.Value = SpeicherDatei.Personen[0].Rentnerjahre;
                nudGaJahreBisZurRente.Value = SpeicherDatei.Personen[0].JahreBisZurRente;
                if (SpeicherDatei.Personen[1].Aktiv)
                {
                    cbGaZweitePerson.Checked = true;
                    tbGAName2Per.Text = SpeicherDatei.Personen[1].Name;
                    nudGAZPRentnerjahre.Value = SpeicherDatei.Personen[1].Rentnerjahre;
                    nudGaZPJahreBisZurRente.Value = SpeicherDatei.Personen[1].JahreBisZurRente;
                }

                foreach (object o in SpeicherDatei.Ausgaben)
                    AusgabeHinzufügen(o);

                foreach (object o in SpeicherDatei.Einnahmen)
                    Altersvorsorgehinzufügen(o);
                pSichtblende.Visible = false;
            }
        }

        private void tbGAName2Per_TextChanged(object sender, EventArgs e)
        {
            Personen[1].Name = tbGAName2Per.Text;
            lGA2Person.Text = tbGAName2Per.Text + ":";
            GAAufVollständigkeitÜberprüfen();
        }

        private void tbGAName1Per_TextChanged(object sender, EventArgs e)
        {
            Personen[0].Name = tbGAName1Per.Text;
            lGA1Person.Text = tbGAName1Per.Text + ":";
            GAAufVollständigkeitÜberprüfen();
        }

        private void nudGaZPJahreBisZurRente_ValueChanged(object sender, EventArgs e)
        {
            Personen[1].JahreBisZurRente = nudGaZPJahreBisZurRente.Value;
            nudGaZPInRenteGehenImJahr.Value = DateTime.Today.Year + Personen[1].JahreBisZurRente;
            GAAufVollständigkeitÜberprüfen();
        }

        private void nudGaZPInRenteGehenImJahr_ValueChanged(object sender, EventArgs e)
        {
            nudGaZPJahreBisZurRente.Value = nudGaZPInRenteGehenImJahr.Value - DateTime.Today.Year;
            Personen[1].JahrRentenbegin = nudGaZPInRenteGehenImJahr.Value;
            GAAufVollständigkeitÜberprüfen();
        }

        private void nudGAZPRentnerjahre_ValueChanged(object sender, EventArgs e)
        {
            Personen[1].Rentnerjahre = nudGAZPRentnerjahre.Value;
            GAAufVollständigkeitÜberprüfen();
        }

        void GAAufVollständigkeitÜberprüfen()
        {
            if (!(nudGaJahreBisZurRente.Value == 0 || nudGaRentnerjahre.Value == 0 || tbGAName1Per.Text == ""))
                if (!(cbGaZweitePerson.Checked && (tbGAName2Per.Text == "" || nudGaZPJahreBisZurRente.Value == 0 || nudGAZPRentnerjahre.Value == 0)))
                    pSichtblende.Visible = false;
        }

        private void fAltersvorsorgerechner_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Sollen die Eingaben gespeichert werden?", "Speichern?", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                speichernToolStripMenuItem_Click(null, null);
                return;
            }
            else if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }

        private void neueBerechnungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nudGaInflation.Value = new decimal(3.5);
            tbGAName1Per.Text = "1. Person";
            tbGAName2Per.Text = "2. Person";
            cbGaZweitePerson.Checked = false;
            nudGaJahreBisZurRente.Value = 0;
            nudGaRentnerjahre.Value = 0;
            nudGaZPJahreBisZurRente.Value = 0;
            nudGAZPRentnerjahre.Value = 0;
            pSichtblende.Visible = true;
            tvAusgaben.Nodes.Clear();
            lvEinnahmen.Items.Clear();
            sSpeicherpfad = "";
            Personen[1].Aktiv = false;
        }

        private void fAltersvorsorgerechner_Load(object sender, EventArgs e)
        {
            HelpProvider hp = new HelpProvider();
            hp.SetHelpString(nudGaInflation, "Geben Sie hier die durchschnittliche Inflation pro Jahr an.");
            hp.SetHelpString(tbGAName1Per, "Geben Sie hier den Namen der ersten Person an.");
            hp.SetHelpString(cbGaZweitePerson, "Aktivieren Sie dieses Kontrollfeld, um eine zweite Person zu aktivieren.");
            hp.SetHelpString(tbGAName2Per, "Geben Sie hier den Namen der optionalen zweiten Person an.");
            hp.SetHelpString(nudGAInRenteGehenImJahr, "Geben Sie hier das Jahr an, in dem Sie vorraussichtlich in Rente gehen werden.");
            hp.SetHelpString(nudGaRentnerjahre, "Geben Sie hier die vorraussichtliche Zeit als Rentner/in an.");
            hp.SetHelpString(nudGaJahreBisZurRente, "Geben Sie hier an, wie viele Jahre es wahrscheinlich noch bis zur Rente sind.");
            hp.SetHelpString(nudGAInRenteGehenImJahr, "Geben Sie hier das Jahr an, in dem die zweite Person vorraussichtlich in Rente gehen werden.");
            hp.SetHelpString(nudGaRentnerjahre, "Geben Sie hier die vorraussichtliche Zeit der zweiten Person als Rentner/in an.");
            hp.SetHelpString(nudGaJahreBisZurRente, "Geben Sie hier an, wie viele Jahre es für die zweite Person wahrscheinlich noch bis zur Rente sind.");
        }
    }
}
