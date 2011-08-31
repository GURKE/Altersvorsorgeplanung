namespace WindowsFormsApplication1
{
    partial class fAltersvorsorgerechner
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Summe",
            "0",
            "",
            "0"}, -1);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "Versorgungslücke",
            "0",
            "",
            "0"}, -1);
            this.gbAusgaben = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAAusgabenZumRentenbegin = new System.Windows.Forms.TextBox();
            this.bAusgabeBearbeiten = new System.Windows.Forms.Button();
            this.bARAusgabeLöschen = new System.Windows.Forms.Button();
            this.bARAusgabeHinzufügen = new System.Windows.Forms.Button();
            this.tvAusgaben = new System.Windows.Forms.TreeView();
            this.gbAltersvorsorgeAuswählen = new System.Windows.Forms.GroupBox();
            this.gbAltersvorsorgeErstellen = new System.Windows.Forms.GroupBox();
            this.cbEeAVPersonenauswahl = new System.Windows.Forms.ComboBox();
            this.tbEeAVName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bEeAVAbbrechen = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.nudEeAVMonatlicheRate = new System.Windows.Forms.NumericUpDown();
            this.lAltersvorsorgeMonatlicheRate = new System.Windows.Forms.Label();
            this.bEeAVHinzufügen = new System.Windows.Forms.Button();
            this.tbEeAVWertDerAltersvorsorge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAVaAltersvorsorgeAuswählen = new System.Windows.Forms.ComboBox();
            this.gbAltersvorsorgebetragBerechnen = new System.Windows.Forms.GroupBox();
            this.cbAVBbPersonenauswahl = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAVBbJährlicheRate = new System.Windows.Forms.NumericUpDown();
            this.nudAVBbZinsAufBarwert = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudAVBbIstKapital = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.nudAVBbMonatRate = new System.Windows.Forms.NumericUpDown();
            this.tbAVBbName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.bAVBbAbbrechen = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.nudAVBbZins = new System.Windows.Forms.NumericUpDown();
            this.lAVBbRate = new System.Windows.Forms.Label();
            this.bAVBbÜbernehmen = new System.Windows.Forms.Button();
            this.tbAVBbBarwert = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.gbEinnahmen = new System.Windows.Forms.GroupBox();
            this.lvEinnahmenErgebnis = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEinnahmen = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRateProMonat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chZinssatz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBarwert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bEEinahmeBearbeiten = new System.Windows.Forms.Button();
            this.bEEinahmeLöschen = new System.Windows.Forms.Button();
            this.bEEinnahmeHinzufügen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neueBerechnungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernUnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAusgabenauswählen = new System.Windows.Forms.GroupBox();
            this.gbFesteAusgaben = new System.Windows.Forms.GroupBox();
            this.bFAAbbrechen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudFAMonatKosten = new System.Windows.Forms.NumericUpDown();
            this.nudFAInflation = new System.Windows.Forms.NumericUpDown();
            this.lJetztigeMonatlicheKosten = new System.Windows.Forms.Label();
            this.nudFAJahreBisZurRente = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bFAÜbernehmen = new System.Windows.Forms.Button();
            this.tbFAEndwert = new System.Windows.Forms.TextBox();
            this.lEndwert = new System.Windows.Forms.Label();
            this.gbImmobilie = new System.Windows.Forms.GroupBox();
            this.nudIZins = new System.Windows.Forms.NumericUpDown();
            this.nudIWertanpassung = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.nudIAbtragende = new System.Windows.Forms.NumericUpDown();
            this.nudIKaufjahr = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.tbIRenteProMonat = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nudIRestschulden = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.nudIJährlicheRate = new System.Windows.Forms.NumericUpDown();
            this.tbIName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.bIAbbrechen = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.nudIMonatRate = new System.Windows.Forms.NumericUpDown();
            this.nudIKaufpreis = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.bIBerechnen = new System.Windows.Forms.Button();
            this.tbIBarwert = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbAaAusgabeAuswählen = new System.Windows.Forms.ComboBox();
            this.gbGrundangaben = new System.Windows.Forms.GroupBox();
            this.lGA2Person = new System.Windows.Forms.Label();
            this.lGA1Person = new System.Windows.Forms.Label();
            this.lName2Person = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tbGAName1Per = new System.Windows.Forms.TextBox();
            this.tbGAName2Per = new System.Windows.Forms.TextBox();
            this.nudGAZPRentnerjahre = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudGaZPInRenteGehenImJahr = new System.Windows.Forms.NumericUpDown();
            this.nudGaZPJahreBisZurRente = new System.Windows.Forms.NumericUpDown();
            this.cbGaZweitePerson = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudGAInRenteGehenImJahr = new System.Windows.Forms.NumericUpDown();
            this.nudGaRentnerjahre = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudGaInflation = new System.Windows.Forms.NumericUpDown();
            this.nudGaJahreBisZurRente = new System.Windows.Forms.NumericUpDown();
            this.lJahreBisZurRente = new System.Windows.Forms.Label();
            this.lInflation = new System.Windows.Forms.Label();
            this.pSichtblende = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbAusgaben.SuspendLayout();
            this.gbAltersvorsorgeAuswählen.SuspendLayout();
            this.gbAltersvorsorgeErstellen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEeAVMonatlicheRate)).BeginInit();
            this.gbAltersvorsorgebetragBerechnen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAVBbJährlicheRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAVBbZinsAufBarwert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAVBbIstKapital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAVBbMonatRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAVBbZins)).BeginInit();
            this.gbEinnahmen.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbAusgabenauswählen.SuspendLayout();
            this.gbFesteAusgaben.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFAMonatKosten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFAInflation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFAJahreBisZurRente)).BeginInit();
            this.gbImmobilie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIZins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIWertanpassung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIAbtragende)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIKaufjahr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIRestschulden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIJährlicheRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIMonatRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIKaufpreis)).BeginInit();
            this.gbGrundangaben.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGAZPRentnerjahre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGaZPInRenteGehenImJahr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGaZPJahreBisZurRente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGAInRenteGehenImJahr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGaRentnerjahre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGaInflation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGaJahreBisZurRente)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAusgaben
            // 
            this.gbAusgaben.Controls.Add(this.label7);
            this.gbAusgaben.Controls.Add(this.tbAAusgabenZumRentenbegin);
            this.gbAusgaben.Controls.Add(this.bAusgabeBearbeiten);
            this.gbAusgaben.Controls.Add(this.bARAusgabeLöschen);
            this.gbAusgaben.Controls.Add(this.bARAusgabeHinzufügen);
            this.gbAusgaben.Controls.Add(this.tvAusgaben);
            this.gbAusgaben.Location = new System.Drawing.Point(6, 160);
            this.gbAusgaben.Name = "gbAusgaben";
            this.gbAusgaben.Size = new System.Drawing.Size(350, 350);
            this.gbAusgaben.TabIndex = 2;
            this.gbAusgaben.TabStop = false;
            this.gbAusgaben.Text = "Ausgaben";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 26);
            this.label7.TabIndex = 45;
            this.label7.Text = "Ausgaben zum Rentenbegin:";
            // 
            // tbAAusgabenZumRentenbegin
            // 
            this.tbAAusgabenZumRentenbegin.Location = new System.Drawing.Point(129, 324);
            this.tbAAusgabenZumRentenbegin.Name = "tbAAusgabenZumRentenbegin";
            this.tbAAusgabenZumRentenbegin.Size = new System.Drawing.Size(100, 20);
            this.tbAAusgabenZumRentenbegin.TabIndex = 45;
            // 
            // bAusgabeBearbeiten
            // 
            this.bAusgabeBearbeiten.Location = new System.Drawing.Point(269, 67);
            this.bAusgabeBearbeiten.Name = "bAusgabeBearbeiten";
            this.bAusgabeBearbeiten.Size = new System.Drawing.Size(75, 42);
            this.bAusgabeBearbeiten.TabIndex = 2;
            this.bAusgabeBearbeiten.Tag = "-1";
            this.bAusgabeBearbeiten.Text = "Ausgabe bearbeiten";
            this.bAusgabeBearbeiten.UseVisualStyleBackColor = true;
            this.bAusgabeBearbeiten.Click += new System.EventHandler(this.bAusgabeBearbeiten_Click);
            // 
            // bARAusgabeLöschen
            // 
            this.bARAusgabeLöschen.Location = new System.Drawing.Point(269, 115);
            this.bARAusgabeLöschen.Name = "bARAusgabeLöschen";
            this.bARAusgabeLöschen.Size = new System.Drawing.Size(75, 42);
            this.bARAusgabeLöschen.TabIndex = 3;
            this.bARAusgabeLöschen.Text = "Ausgabe löschen";
            this.bARAusgabeLöschen.UseVisualStyleBackColor = true;
            this.bARAusgabeLöschen.Click += new System.EventHandler(this.bARAusgabeLöschen_Click);
            // 
            // bARAusgabeHinzufügen
            // 
            this.bARAusgabeHinzufügen.Location = new System.Drawing.Point(269, 19);
            this.bARAusgabeHinzufügen.Name = "bARAusgabeHinzufügen";
            this.bARAusgabeHinzufügen.Size = new System.Drawing.Size(75, 42);
            this.bARAusgabeHinzufügen.TabIndex = 1;
            this.bARAusgabeHinzufügen.Text = "Ausgabe hinzufügen";
            this.bARAusgabeHinzufügen.UseVisualStyleBackColor = true;
            this.bARAusgabeHinzufügen.Click += new System.EventHandler(this.bARAusgabeHinzufügen_Click_1);
            // 
            // tvAusgaben
            // 
            this.tvAusgaben.Location = new System.Drawing.Point(6, 19);
            this.tvAusgaben.Name = "tvAusgaben";
            this.tvAusgaben.Size = new System.Drawing.Size(257, 299);
            this.tvAusgaben.TabIndex = 0;
            // 
            // gbAltersvorsorgeAuswählen
            // 
            this.gbAltersvorsorgeAuswählen.Controls.Add(this.gbAltersvorsorgeErstellen);
            this.gbAltersvorsorgeAuswählen.Controls.Add(this.cbAVaAltersvorsorgeAuswählen);
            this.gbAltersvorsorgeAuswählen.Controls.Add(this.gbAltersvorsorgebetragBerechnen);
            this.gbAltersvorsorgeAuswählen.Location = new System.Drawing.Point(138, 160);
            this.gbAltersvorsorgeAuswählen.Name = "gbAltersvorsorgeAuswählen";
            this.gbAltersvorsorgeAuswählen.Size = new System.Drawing.Size(220, 334);
            this.gbAltersvorsorgeAuswählen.TabIndex = 5;
            this.gbAltersvorsorgeAuswählen.TabStop = false;
            this.gbAltersvorsorgeAuswählen.Text = "Altersvorsorge auswählen";
            this.gbAltersvorsorgeAuswählen.Visible = false;
            // 
            // gbAltersvorsorgeErstellen
            // 
            this.gbAltersvorsorgeErstellen.Controls.Add(this.cbEeAVPersonenauswahl);
            this.gbAltersvorsorgeErstellen.Controls.Add(this.tbEeAVName);
            this.gbAltersvorsorgeErstellen.Controls.Add(this.label5);
            this.gbAltersvorsorgeErstellen.Controls.Add(this.bEeAVAbbrechen);
            this.gbAltersvorsorgeErstellen.Controls.Add(this.pictureBox3);
            this.gbAltersvorsorgeErstellen.Controls.Add(this.nudEeAVMonatlicheRate);
            this.gbAltersvorsorgeErstellen.Controls.Add(this.lAltersvorsorgeMonatlicheRate);
            this.gbAltersvorsorgeErstellen.Controls.Add(this.bEeAVHinzufügen);
            this.gbAltersvorsorgeErstellen.Controls.Add(this.tbEeAVWertDerAltersvorsorge);
            this.gbAltersvorsorgeErstellen.Controls.Add(this.label8);
            this.gbAltersvorsorgeErstellen.Location = new System.Drawing.Point(6, 43);
            this.gbAltersvorsorgeErstellen.Name = "gbAltersvorsorgeErstellen";
            this.gbAltersvorsorgeErstellen.Size = new System.Drawing.Size(208, 203);
            this.gbAltersvorsorgeErstellen.TabIndex = 2;
            this.gbAltersvorsorgeErstellen.TabStop = false;
            this.gbAltersvorsorgeErstellen.Text = "Erstellen einer Altersvorsorge";
            this.gbAltersvorsorgeErstellen.Visible = false;
            // 
            // cbEeAVPersonenauswahl
            // 
            this.cbEeAVPersonenauswahl.FormattingEnabled = true;
            this.cbEeAVPersonenauswahl.Items.AddRange(new object[] {
            "1. Person"});
            this.cbEeAVPersonenauswahl.Location = new System.Drawing.Point(9, 16);
            this.cbEeAVPersonenauswahl.Name = "cbEeAVPersonenauswahl";
            this.cbEeAVPersonenauswahl.Size = new System.Drawing.Size(191, 21);
            this.cbEeAVPersonenauswahl.TabIndex = 0;
            this.cbEeAVPersonenauswahl.Text = "1. Person";
            // 
            // tbEeAVName
            // 
            this.tbEeAVName.AccessibleDescription = "";
            this.tbEeAVName.AllowDrop = true;
            this.tbEeAVName.Location = new System.Drawing.Point(129, 46);
            this.tbEeAVName.Name = "tbEeAVName";
            this.tbEeAVName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbEeAVName.Size = new System.Drawing.Size(71, 20);
            this.tbEeAVName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Name der Altersvorsorge:";
            // 
            // bEeAVAbbrechen
            // 
            this.bEeAVAbbrechen.Location = new System.Drawing.Point(27, 174);
            this.bEeAVAbbrechen.Name = "bEeAVAbbrechen";
            this.bEeAVAbbrechen.Size = new System.Drawing.Size(85, 23);
            this.bEeAVAbbrechen.TabIndex = 4;
            this.bEeAVAbbrechen.Text = "Abbrechen";
            this.bEeAVAbbrechen.UseVisualStyleBackColor = true;
            this.bEeAVAbbrechen.Click += new System.EventHandler(this.bEeAVAbbrechen_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox3.Location = new System.Drawing.Point(9, 134);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(191, 2);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // nudEeAVMonatlicheRate
            // 
            this.nudEeAVMonatlicheRate.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudEeAVMonatlicheRate.Location = new System.Drawing.Point(129, 75);
            this.nudEeAVMonatlicheRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudEeAVMonatlicheRate.Name = "nudEeAVMonatlicheRate";
            this.nudEeAVMonatlicheRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudEeAVMonatlicheRate.Size = new System.Drawing.Size(71, 20);
            this.nudEeAVMonatlicheRate.TabIndex = 2;
            this.nudEeAVMonatlicheRate.ThousandsSeparator = true;
            this.nudEeAVMonatlicheRate.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudEeAVMonatlicheRate.ValueChanged += new System.EventHandler(this.nudEeAVMonatlicheRate_ValueChanged);
            // 
            // lAltersvorsorgeMonatlicheRate
            // 
            this.lAltersvorsorgeMonatlicheRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAltersvorsorgeMonatlicheRate.Location = new System.Drawing.Point(6, 69);
            this.lAltersvorsorgeMonatlicheRate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lAltersvorsorgeMonatlicheRate.Name = "lAltersvorsorgeMonatlicheRate";
            this.lAltersvorsorgeMonatlicheRate.Size = new System.Drawing.Size(117, 26);
            this.lAltersvorsorgeMonatlicheRate.TabIndex = 5;
            this.lAltersvorsorgeMonatlicheRate.Text = "Monatliche Rate (in €):";
            // 
            // bEeAVHinzufügen
            // 
            this.bEeAVHinzufügen.Location = new System.Drawing.Point(118, 174);
            this.bEeAVHinzufügen.Name = "bEeAVHinzufügen";
            this.bEeAVHinzufügen.Size = new System.Drawing.Size(85, 23);
            this.bEeAVHinzufügen.TabIndex = 3;
            this.bEeAVHinzufügen.Text = "Übernehmen";
            this.bEeAVHinzufügen.UseVisualStyleBackColor = true;
            this.bEeAVHinzufügen.Click += new System.EventHandler(this.bEeAVHinzufügen_Click);
            // 
            // tbEeAVWertDerAltersvorsorge
            // 
            this.tbEeAVWertDerAltersvorsorge.AccessibleDescription = "";
            this.tbEeAVWertDerAltersvorsorge.AllowDrop = true;
            this.tbEeAVWertDerAltersvorsorge.Location = new System.Drawing.Point(129, 148);
            this.tbEeAVWertDerAltersvorsorge.Name = "tbEeAVWertDerAltersvorsorge";
            this.tbEeAVWertDerAltersvorsorge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbEeAVWertDerAltersvorsorge.Size = new System.Drawing.Size(71, 20);
            this.tbEeAVWertDerAltersvorsorge.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Wert der Altersvorsorge:";
            // 
            // cbAVaAltersvorsorgeAuswählen
            // 
            this.cbAVaAltersvorsorgeAuswählen.FormattingEnabled = true;
            this.cbAVaAltersvorsorgeAuswählen.Items.AddRange(new object[] {
            "Erstellen einer Altersvorsorge",
            "Altersvorsorge mit Startkapital"});
            this.cbAVaAltersvorsorgeAuswählen.Location = new System.Drawing.Point(6, 16);
            this.cbAVaAltersvorsorgeAuswählen.Name = "cbAVaAltersvorsorgeAuswählen";
            this.cbAVaAltersvorsorgeAuswählen.Size = new System.Drawing.Size(208, 21);
            this.cbAVaAltersvorsorgeAuswählen.TabIndex = 0;
            this.cbAVaAltersvorsorgeAuswählen.SelectedIndexChanged += new System.EventHandler(this.cbAVaAltersvorsorgeAuswählen_SelectedIndexChanged);
            // 
            // gbAltersvorsorgebetragBerechnen
            // 
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.cbAVBbPersonenauswahl);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.label6);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.nudAVBbJährlicheRate);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.nudAVBbZinsAufBarwert);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.label13);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.nudAVBbIstKapital);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.label16);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.nudAVBbMonatRate);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.tbAVBbName);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.label12);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.label14);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.bAVBbAbbrechen);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.pictureBox4);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.nudAVBbZins);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.lAVBbRate);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.bAVBbÜbernehmen);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.tbAVBbBarwert);
            this.gbAltersvorsorgebetragBerechnen.Controls.Add(this.label28);
            this.gbAltersvorsorgebetragBerechnen.Location = new System.Drawing.Point(6, 43);
            this.gbAltersvorsorgebetragBerechnen.Name = "gbAltersvorsorgebetragBerechnen";
            this.gbAltersvorsorgebetragBerechnen.Size = new System.Drawing.Size(208, 285);
            this.gbAltersvorsorgebetragBerechnen.TabIndex = 1;
            this.gbAltersvorsorgebetragBerechnen.TabStop = false;
            this.gbAltersvorsorgebetragBerechnen.Text = "Altersvorsorgebetrag berechnen";
            this.gbAltersvorsorgebetragBerechnen.Visible = false;
            // 
            // cbAVBbPersonenauswahl
            // 
            this.cbAVBbPersonenauswahl.FormattingEnabled = true;
            this.cbAVBbPersonenauswahl.Items.AddRange(new object[] {
            "1. Person"});
            this.cbAVBbPersonenauswahl.Location = new System.Drawing.Point(11, 17);
            this.cbAVBbPersonenauswahl.Name = "cbAVBbPersonenauswahl";
            this.cbAVBbPersonenauswahl.Size = new System.Drawing.Size(191, 21);
            this.cbAVBbPersonenauswahl.TabIndex = 0;
            this.cbAVBbPersonenauswahl.Text = "1. Person";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nettozins während Rente (in %):";
            // 
            // nudAVBbJährlicheRate
            // 
            this.nudAVBbJährlicheRate.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudAVBbJährlicheRate.Location = new System.Drawing.Point(131, 163);
            this.nudAVBbJährlicheRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAVBbJährlicheRate.Name = "nudAVBbJährlicheRate";
            this.nudAVBbJährlicheRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudAVBbJährlicheRate.Size = new System.Drawing.Size(71, 20);
            this.nudAVBbJährlicheRate.TabIndex = 5;
            this.nudAVBbJährlicheRate.ThousandsSeparator = true;
            this.nudAVBbJährlicheRate.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudAVBbJährlicheRate.ValueChanged += new System.EventHandler(this.nudAVBbJährlicheRate_ValueChanged);
            // 
            // nudAVBbZinsAufBarwert
            // 
            this.nudAVBbZinsAufBarwert.DecimalPlaces = 1;
            this.nudAVBbZinsAufBarwert.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudAVBbZinsAufBarwert.Location = new System.Drawing.Point(130, 232);
            this.nudAVBbZinsAufBarwert.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudAVBbZinsAufBarwert.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nudAVBbZinsAufBarwert.Name = "nudAVBbZinsAufBarwert";
            this.nudAVBbZinsAufBarwert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudAVBbZinsAufBarwert.Size = new System.Drawing.Size(71, 20);
            this.nudAVBbZinsAufBarwert.TabIndex = 9;
            this.nudAVBbZinsAufBarwert.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 157);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 26);
            this.label13.TabIndex = 31;
            this.label13.Text = "Jährliche Spar-\r\nRate (in €):";
            // 
            // nudAVBbIstKapital
            // 
            this.nudAVBbIstKapital.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAVBbIstKapital.Location = new System.Drawing.Point(131, 76);
            this.nudAVBbIstKapital.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAVBbIstKapital.Name = "nudAVBbIstKapital";
            this.nudAVBbIstKapital.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudAVBbIstKapital.Size = new System.Drawing.Size(71, 20);
            this.nudAVBbIstKapital.TabIndex = 2;
            this.nudAVBbIstKapital.ThousandsSeparator = true;
            this.nudAVBbIstKapital.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudAVBbIstKapital.ValueChanged += new System.EventHandler(this.nudAVBbIstKapital_ValueChanged);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 70);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 26);
            this.label16.TabIndex = 20;
            this.label16.Text = "Ist-Kapital\r\n(in €):";
            // 
            // nudAVBbMonatRate
            // 
            this.nudAVBbMonatRate.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudAVBbMonatRate.Location = new System.Drawing.Point(131, 134);
            this.nudAVBbMonatRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAVBbMonatRate.Name = "nudAVBbMonatRate";
            this.nudAVBbMonatRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudAVBbMonatRate.Size = new System.Drawing.Size(71, 20);
            this.nudAVBbMonatRate.TabIndex = 4;
            this.nudAVBbMonatRate.ThousandsSeparator = true;
            this.nudAVBbMonatRate.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudAVBbMonatRate.ValueChanged += new System.EventHandler(this.nudAVBbMonatRate_ValueChanged);
            // 
            // tbAVBbName
            // 
            this.tbAVBbName.AccessibleDescription = "";
            this.tbAVBbName.AllowDrop = true;
            this.tbAVBbName.Location = new System.Drawing.Point(131, 47);
            this.tbAVBbName.Name = "tbAVBbName";
            this.tbAVBbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbAVBbName.Size = new System.Drawing.Size(71, 20);
            this.tbAVBbName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 99);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 26);
            this.label12.TabIndex = 20;
            this.label12.Text = "Nettozins\r\n(in %):";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 26);
            this.label14.TabIndex = 20;
            this.label14.Text = "Name der Altersvorsorge:";
            // 
            // bAVBbAbbrechen
            // 
            this.bAVBbAbbrechen.Location = new System.Drawing.Point(28, 258);
            this.bAVBbAbbrechen.Name = "bAVBbAbbrechen";
            this.bAVBbAbbrechen.Size = new System.Drawing.Size(85, 23);
            this.bAVBbAbbrechen.TabIndex = 7;
            this.bAVBbAbbrechen.Text = "Abbrechen";
            this.bAVBbAbbrechen.UseVisualStyleBackColor = true;
            this.bAVBbAbbrechen.Click += new System.EventHandler(this.bAVBbAbbrechen_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox4.Location = new System.Drawing.Point(11, 189);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(191, 2);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // nudAVBbZins
            // 
            this.nudAVBbZins.DecimalPlaces = 1;
            this.nudAVBbZins.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudAVBbZins.Location = new System.Drawing.Point(131, 105);
            this.nudAVBbZins.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudAVBbZins.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nudAVBbZins.Name = "nudAVBbZins";
            this.nudAVBbZins.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudAVBbZins.Size = new System.Drawing.Size(71, 20);
            this.nudAVBbZins.TabIndex = 3;
            this.nudAVBbZins.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudAVBbZins.ValueChanged += new System.EventHandler(this.nudAVBbZins_ValueChanged);
            // 
            // lAVBbRate
            // 
            this.lAVBbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAVBbRate.Location = new System.Drawing.Point(8, 128);
            this.lAVBbRate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lAVBbRate.Name = "lAVBbRate";
            this.lAVBbRate.Size = new System.Drawing.Size(117, 26);
            this.lAVBbRate.TabIndex = 5;
            this.lAVBbRate.Text = "Monatliche Spar-Rate (in €):";
            // 
            // bAVBbÜbernehmen
            // 
            this.bAVBbÜbernehmen.Location = new System.Drawing.Point(119, 258);
            this.bAVBbÜbernehmen.Name = "bAVBbÜbernehmen";
            this.bAVBbÜbernehmen.Size = new System.Drawing.Size(85, 23);
            this.bAVBbÜbernehmen.TabIndex = 6;
            this.bAVBbÜbernehmen.Text = "Übernehmen";
            this.bAVBbÜbernehmen.UseVisualStyleBackColor = true;
            this.bAVBbÜbernehmen.Click += new System.EventHandler(this.bAVBbBerechnen_Click);
            // 
            // tbAVBbBarwert
            // 
            this.tbAVBbBarwert.AccessibleDescription = "";
            this.tbAVBbBarwert.AllowDrop = true;
            this.tbAVBbBarwert.Location = new System.Drawing.Point(131, 203);
            this.tbAVBbBarwert.Name = "tbAVBbBarwert";
            this.tbAVBbBarwert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbAVBbBarwert.Size = new System.Drawing.Size(71, 20);
            this.tbAVBbBarwert.TabIndex = 8;
            this.tbAVBbBarwert.Text = "0";
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(8, 197);
            this.label28.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(117, 26);
            this.label28.TabIndex = 13;
            this.label28.Text = "Barwert:";
            // 
            // gbEinnahmen
            // 
            this.gbEinnahmen.Controls.Add(this.lvEinnahmenErgebnis);
            this.gbEinnahmen.Controls.Add(this.lvEinnahmen);
            this.gbEinnahmen.Controls.Add(this.bEEinahmeBearbeiten);
            this.gbEinnahmen.Controls.Add(this.bEEinahmeLöschen);
            this.gbEinnahmen.Controls.Add(this.bEEinnahmeHinzufügen);
            this.gbEinnahmen.Location = new System.Drawing.Point(362, 160);
            this.gbEinnahmen.Name = "gbEinnahmen";
            this.gbEinnahmen.Size = new System.Drawing.Size(450, 350);
            this.gbEinnahmen.TabIndex = 4;
            this.gbEinnahmen.TabStop = false;
            this.gbEinnahmen.Text = "Einnahmen";
            // 
            // lvEinnahmenErgebnis
            // 
            this.lvEinnahmenErgebnis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvEinnahmenErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEinnahmenErgebnis.GridLines = true;
            this.lvEinnahmenErgebnis.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvEinnahmenErgebnis.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem15,
            listViewItem16});
            this.lvEinnahmenErgebnis.Location = new System.Drawing.Point(6, 210);
            this.lvEinnahmenErgebnis.MultiSelect = false;
            this.lvEinnahmenErgebnis.Name = "lvEinnahmenErgebnis";
            this.lvEinnahmenErgebnis.ShowGroups = false;
            this.lvEinnahmenErgebnis.Size = new System.Drawing.Size(438, 32);
            this.lvEinnahmenErgebnis.TabIndex = 44;
            this.lvEinnahmenErgebnis.UseCompatibleStateImageBehavior = false;
            this.lvEinnahmenErgebnis.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rate/m (in €)";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Zins (in %)";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 74;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Barwert (in €)   ";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 110;
            // 
            // lvEinnahmen
            // 
            this.lvEinnahmen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chRateProMonat,
            this.chZinssatz,
            this.chBarwert});
            this.lvEinnahmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEinnahmen.GridLines = true;
            this.lvEinnahmen.Location = new System.Drawing.Point(6, 19);
            this.lvEinnahmen.MultiSelect = false;
            this.lvEinnahmen.Name = "lvEinnahmen";
            this.lvEinnahmen.ShowGroups = false;
            this.lvEinnahmen.Size = new System.Drawing.Size(438, 192);
            this.lvEinnahmen.TabIndex = 0;
            this.lvEinnahmen.UseCompatibleStateImageBehavior = false;
            this.lvEinnahmen.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 154;
            // 
            // chRateProMonat
            // 
            this.chRateProMonat.Text = "Rate/m (in €)";
            this.chRateProMonat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chRateProMonat.Width = 92;
            // 
            // chZinssatz
            // 
            this.chZinssatz.Text = "Zins (in %)";
            this.chZinssatz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chZinssatz.Width = 74;
            // 
            // chBarwert
            // 
            this.chBarwert.Text = "Barwert (in €)   ";
            this.chBarwert.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chBarwert.Width = 110;
            // 
            // bEEinahmeBearbeiten
            // 
            this.bEEinahmeBearbeiten.Enabled = false;
            this.bEEinahmeBearbeiten.Location = new System.Drawing.Point(87, 248);
            this.bEEinahmeBearbeiten.Name = "bEEinahmeBearbeiten";
            this.bEEinahmeBearbeiten.Size = new System.Drawing.Size(75, 42);
            this.bEEinahmeBearbeiten.TabIndex = 2;
            this.bEEinahmeBearbeiten.Text = "Einnahme bearbeiten";
            this.bEEinahmeBearbeiten.UseVisualStyleBackColor = true;
            // 
            // bEEinahmeLöschen
            // 
            this.bEEinahmeLöschen.Location = new System.Drawing.Point(168, 248);
            this.bEEinahmeLöschen.Name = "bEEinahmeLöschen";
            this.bEEinahmeLöschen.Size = new System.Drawing.Size(75, 42);
            this.bEEinahmeLöschen.TabIndex = 3;
            this.bEEinahmeLöschen.Text = "Einnahme löschen";
            this.bEEinahmeLöschen.UseVisualStyleBackColor = true;
            this.bEEinahmeLöschen.Click += new System.EventHandler(this.bEEinahmeLöschen_Click);
            // 
            // bEEinnahmeHinzufügen
            // 
            this.bEEinnahmeHinzufügen.Location = new System.Drawing.Point(6, 248);
            this.bEEinnahmeHinzufügen.Name = "bEEinnahmeHinzufügen";
            this.bEEinnahmeHinzufügen.Size = new System.Drawing.Size(75, 42);
            this.bEEinnahmeHinzufügen.TabIndex = 1;
            this.bEEinnahmeHinzufügen.Text = "Einnahme hinzufügen";
            this.bEEinnahmeHinzufügen.UseVisualStyleBackColor = true;
            this.bEEinnahmeHinzufügen.Click += new System.EventHandler(this.bEEinnahmeHinzufügen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neueBerechnungToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.speichernUnterToolStripMenuItem,
            this.ladenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // neueBerechnungToolStripMenuItem
            // 
            this.neueBerechnungToolStripMenuItem.Name = "neueBerechnungToolStripMenuItem";
            this.neueBerechnungToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.neueBerechnungToolStripMenuItem.Text = "Neue Berechnung";
            this.neueBerechnungToolStripMenuItem.Click += new System.EventHandler(this.neueBerechnungToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // speichernUnterToolStripMenuItem
            // 
            this.speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
            this.speichernUnterToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.speichernUnterToolStripMenuItem.Text = "Speichern unter";
            this.speichernUnterToolStripMenuItem.Click += new System.EventHandler(this.speichernUnterToolStripMenuItem_Click);
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ladenToolStripMenuItem.Text = "Laden";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click_1);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click_1);
            // 
            // gbAusgabenauswählen
            // 
            this.gbAusgabenauswählen.Controls.Add(this.gbFesteAusgaben);
            this.gbAusgabenauswählen.Controls.Add(this.gbImmobilie);
            this.gbAusgabenauswählen.Controls.Add(this.cbAaAusgabeAuswählen);
            this.gbAusgabenauswählen.Location = new System.Drawing.Point(357, 87);
            this.gbAusgabenauswählen.Name = "gbAusgabenauswählen";
            this.gbAusgabenauswählen.Size = new System.Drawing.Size(224, 421);
            this.gbAusgabenauswählen.TabIndex = 3;
            this.gbAusgabenauswählen.TabStop = false;
            this.gbAusgabenauswählen.Text = "Ausgabe auswählen";
            this.gbAusgabenauswählen.Visible = false;
            // 
            // gbFesteAusgaben
            // 
            this.gbFesteAusgaben.Controls.Add(this.bFAAbbrechen);
            this.gbFesteAusgaben.Controls.Add(this.pictureBox1);
            this.gbFesteAusgaben.Controls.Add(this.nudFAMonatKosten);
            this.gbFesteAusgaben.Controls.Add(this.nudFAInflation);
            this.gbFesteAusgaben.Controls.Add(this.lJetztigeMonatlicheKosten);
            this.gbFesteAusgaben.Controls.Add(this.nudFAJahreBisZurRente);
            this.gbFesteAusgaben.Controls.Add(this.label9);
            this.gbFesteAusgaben.Controls.Add(this.label11);
            this.gbFesteAusgaben.Controls.Add(this.bFAÜbernehmen);
            this.gbFesteAusgaben.Controls.Add(this.tbFAEndwert);
            this.gbFesteAusgaben.Controls.Add(this.lEndwert);
            this.gbFesteAusgaben.Location = new System.Drawing.Point(6, 43);
            this.gbFesteAusgaben.Name = "gbFesteAusgaben";
            this.gbFesteAusgaben.Size = new System.Drawing.Size(208, 172);
            this.gbFesteAusgaben.TabIndex = 1;
            this.gbFesteAusgaben.TabStop = false;
            this.gbFesteAusgaben.Text = "Feste Ausgaben";
            this.gbFesteAusgaben.Visible = false;
            // 
            // bFAAbbrechen
            // 
            this.bFAAbbrechen.Location = new System.Drawing.Point(26, 143);
            this.bFAAbbrechen.Name = "bFAAbbrechen";
            this.bFAAbbrechen.Size = new System.Drawing.Size(85, 23);
            this.bFAAbbrechen.TabIndex = 5;
            this.bFAAbbrechen.Text = "Abbrechen";
            this.bFAAbbrechen.UseVisualStyleBackColor = true;
            this.bFAAbbrechen.Click += new System.EventHandler(this.bFAAbbrechen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(9, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 2);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // nudFAMonatKosten
            // 
            this.nudFAMonatKosten.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudFAMonatKosten.Location = new System.Drawing.Point(129, 19);
            this.nudFAMonatKosten.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudFAMonatKosten.Name = "nudFAMonatKosten";
            this.nudFAMonatKosten.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudFAMonatKosten.Size = new System.Drawing.Size(71, 20);
            this.nudFAMonatKosten.TabIndex = 0;
            this.nudFAMonatKosten.ThousandsSeparator = true;
            this.nudFAMonatKosten.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudFAMonatKosten.ValueChanged += new System.EventHandler(this.nudFAJetztigeMonatKosten_ValueChanged);
            // 
            // nudFAInflation
            // 
            this.nudFAInflation.DecimalPlaces = 1;
            this.nudFAInflation.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudFAInflation.Location = new System.Drawing.Point(129, 80);
            this.nudFAInflation.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFAInflation.Name = "nudFAInflation";
            this.nudFAInflation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudFAInflation.Size = new System.Drawing.Size(71, 20);
            this.nudFAInflation.TabIndex = 2;
            this.nudFAInflation.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudFAInflation.Value = new decimal(new int[] {
            35,
            0,
            0,
            65536});
            this.nudFAInflation.ValueChanged += new System.EventHandler(this.nudFAInflation_ValueChanged);
            // 
            // lJetztigeMonatlicheKosten
            // 
            this.lJetztigeMonatlicheKosten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lJetztigeMonatlicheKosten.Location = new System.Drawing.Point(6, 16);
            this.lJetztigeMonatlicheKosten.Name = "lJetztigeMonatlicheKosten";
            this.lJetztigeMonatlicheKosten.Size = new System.Drawing.Size(117, 26);
            this.lJetztigeMonatlicheKosten.TabIndex = 5;
            this.lJetztigeMonatlicheKosten.Text = "Monatliche Kosten (in €):";
            // 
            // nudFAJahreBisZurRente
            // 
            this.nudFAJahreBisZurRente.DecimalPlaces = 1;
            this.nudFAJahreBisZurRente.Location = new System.Drawing.Point(129, 51);
            this.nudFAJahreBisZurRente.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudFAJahreBisZurRente.Name = "nudFAJahreBisZurRente";
            this.nudFAJahreBisZurRente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudFAJahreBisZurRente.Size = new System.Drawing.Size(71, 20);
            this.nudFAJahreBisZurRente.TabIndex = 1;
            this.nudFAJahreBisZurRente.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudFAJahreBisZurRente.ValueChanged += new System.EventHandler(this.nudFAJahreBisZurRente_ValueChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 26);
            this.label9.TabIndex = 7;
            this.label9.Text = "Jahre bis zur Rente:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 74);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 26);
            this.label11.TabIndex = 9;
            this.label11.Text = "Durchschnittliche Inflation (in %):";
            // 
            // bFAÜbernehmen
            // 
            this.bFAÜbernehmen.Location = new System.Drawing.Point(117, 143);
            this.bFAÜbernehmen.Name = "bFAÜbernehmen";
            this.bFAÜbernehmen.Size = new System.Drawing.Size(85, 23);
            this.bFAÜbernehmen.TabIndex = 4;
            this.bFAÜbernehmen.Tag = "0";
            this.bFAÜbernehmen.Text = "Übernehmen";
            this.bFAÜbernehmen.UseVisualStyleBackColor = true;
            this.bFAÜbernehmen.Click += new System.EventHandler(this.bFAÜbernehmen_Click);
            // 
            // tbFAEndwert
            // 
            this.tbFAEndwert.AccessibleDescription = "";
            this.tbFAEndwert.AllowDrop = true;
            this.tbFAEndwert.Location = new System.Drawing.Point(129, 117);
            this.tbFAEndwert.Name = "tbFAEndwert";
            this.tbFAEndwert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbFAEndwert.Size = new System.Drawing.Size(71, 20);
            this.tbFAEndwert.TabIndex = 3;
            this.tbFAEndwert.Text = "0";
            // 
            // lEndwert
            // 
            this.lEndwert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEndwert.Location = new System.Drawing.Point(6, 111);
            this.lEndwert.Name = "lEndwert";
            this.lEndwert.Size = new System.Drawing.Size(117, 26);
            this.lEndwert.TabIndex = 13;
            this.lEndwert.Text = "Monatliche Kosten (incl Inflation in €):";
            // 
            // gbImmobilie
            // 
            this.gbImmobilie.Controls.Add(this.nudIZins);
            this.gbImmobilie.Controls.Add(this.nudIWertanpassung);
            this.gbImmobilie.Controls.Add(this.label27);
            this.gbImmobilie.Controls.Add(this.label26);
            this.gbImmobilie.Controls.Add(this.nudIAbtragende);
            this.gbImmobilie.Controls.Add(this.nudIKaufjahr);
            this.gbImmobilie.Controls.Add(this.label21);
            this.gbImmobilie.Controls.Add(this.tbIRenteProMonat);
            this.gbImmobilie.Controls.Add(this.label19);
            this.gbImmobilie.Controls.Add(this.label17);
            this.gbImmobilie.Controls.Add(this.nudIRestschulden);
            this.gbImmobilie.Controls.Add(this.label24);
            this.gbImmobilie.Controls.Add(this.label25);
            this.gbImmobilie.Controls.Add(this.label18);
            this.gbImmobilie.Controls.Add(this.nudIJährlicheRate);
            this.gbImmobilie.Controls.Add(this.tbIName);
            this.gbImmobilie.Controls.Add(this.label20);
            this.gbImmobilie.Controls.Add(this.bIAbbrechen);
            this.gbImmobilie.Controls.Add(this.pictureBox5);
            this.gbImmobilie.Controls.Add(this.nudIMonatRate);
            this.gbImmobilie.Controls.Add(this.nudIKaufpreis);
            this.gbImmobilie.Controls.Add(this.label22);
            this.gbImmobilie.Controls.Add(this.bIBerechnen);
            this.gbImmobilie.Controls.Add(this.tbIBarwert);
            this.gbImmobilie.Controls.Add(this.label23);
            this.gbImmobilie.Location = new System.Drawing.Point(6, 43);
            this.gbImmobilie.Name = "gbImmobilie";
            this.gbImmobilie.Size = new System.Drawing.Size(208, 377);
            this.gbImmobilie.TabIndex = 2;
            this.gbImmobilie.TabStop = false;
            this.gbImmobilie.Text = "Immobilie";
            this.gbImmobilie.Visible = false;
            // 
            // nudIZins
            // 
            this.nudIZins.DecimalPlaces = 1;
            this.nudIZins.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudIZins.Location = new System.Drawing.Point(129, 251);
            this.nudIZins.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudIZins.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nudIZins.Name = "nudIZins";
            this.nudIZins.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudIZins.Size = new System.Drawing.Size(71, 20);
            this.nudIZins.TabIndex = 8;
            this.nudIZins.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudIZins.Value = new decimal(new int[] {
            35,
            0,
            0,
            65536});
            this.nudIZins.ValueChanged += new System.EventHandler(this.nudIZins_ValueChanged);
            // 
            // nudIWertanpassung
            // 
            this.nudIWertanpassung.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudIWertanpassung.Location = new System.Drawing.Point(129, 222);
            this.nudIWertanpassung.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudIWertanpassung.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudIWertanpassung.Name = "nudIWertanpassung";
            this.nudIWertanpassung.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudIWertanpassung.Size = new System.Drawing.Size(71, 20);
            this.nudIWertanpassung.TabIndex = 7;
            this.nudIWertanpassung.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudIWertanpassung.ValueChanged += new System.EventHandler(this.nudIWertanpassung_ValueChanged);
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(6, 245);
            this.label27.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(117, 26);
            this.label27.TabIndex = 20;
            this.label27.Text = "Nettozins auf Barwert (in %):";
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(6, 216);
            this.label26.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(117, 26);
            this.label26.TabIndex = 44;
            this.label26.Text = "Wertanpassung\r\n(in 1.000€):";
            // 
            // nudIAbtragende
            // 
            this.nudIAbtragende.Location = new System.Drawing.Point(129, 184);
            this.nudIAbtragende.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudIAbtragende.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudIAbtragende.Name = "nudIAbtragende";
            this.nudIAbtragende.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudIAbtragende.Size = new System.Drawing.Size(71, 20);
            this.nudIAbtragende.TabIndex = 6;
            this.nudIAbtragende.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudIAbtragende.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudIAbtragende.ValueChanged += new System.EventHandler(this.nudIAbtragende_ValueChanged);
            // 
            // nudIKaufjahr
            // 
            this.nudIKaufjahr.Location = new System.Drawing.Point(129, 77);
            this.nudIKaufjahr.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudIKaufjahr.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudIKaufjahr.Name = "nudIKaufjahr";
            this.nudIKaufjahr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudIKaufjahr.Size = new System.Drawing.Size(71, 20);
            this.nudIKaufjahr.TabIndex = 2;
            this.nudIKaufjahr.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudIKaufjahr.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudIKaufjahr.ValueChanged += new System.EventHandler(this.nudIKaufjahr_ValueChanged);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 74);
            this.label21.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(117, 26);
            this.label21.TabIndex = 40;
            this.label21.Text = "Kaufjahr:";
            // 
            // tbIRenteProMonat
            // 
            this.tbIRenteProMonat.AccessibleDescription = "";
            this.tbIRenteProMonat.AllowDrop = true;
            this.tbIRenteProMonat.Location = new System.Drawing.Point(129, 318);
            this.tbIRenteProMonat.Name = "tbIRenteProMonat";
            this.tbIRenteProMonat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbIRenteProMonat.Size = new System.Drawing.Size(71, 20);
            this.tbIRenteProMonat.TabIndex = 12;
            this.tbIRenteProMonat.Text = "0";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(5, 312);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 26);
            this.label19.TabIndex = 39;
            this.label19.Text = "Rente/Monat\r\n(in €):";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 187);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 26);
            this.label17.TabIndex = 36;
            this.label17.Text = "Abtragende:";
            // 
            // nudIRestschulden
            // 
            this.nudIRestschulden.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudIRestschulden.Location = new System.Drawing.Point(129, 106);
            this.nudIRestschulden.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudIRestschulden.Name = "nudIRestschulden";
            this.nudIRestschulden.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudIRestschulden.Size = new System.Drawing.Size(71, 20);
            this.nudIRestschulden.TabIndex = 3;
            this.nudIRestschulden.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(4, 158);
            this.label24.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(117, 26);
            this.label24.TabIndex = 35;
            this.label24.Text = "Jährliche Rate\r\n(in €):";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(4, 129);
            this.label25.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(117, 26);
            this.label25.TabIndex = 33;
            this.label25.Text = "Monatliche Rate (in €):";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(4, 100);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 26);
            this.label18.TabIndex = 20;
            this.label18.Text = "Restschulden\r\n(in 1.000€):";
            // 
            // nudIJährlicheRate
            // 
            this.nudIJährlicheRate.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudIJährlicheRate.Location = new System.Drawing.Point(129, 158);
            this.nudIJährlicheRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudIJährlicheRate.Name = "nudIJährlicheRate";
            this.nudIJährlicheRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudIJährlicheRate.Size = new System.Drawing.Size(71, 20);
            this.nudIJährlicheRate.TabIndex = 5;
            this.nudIJährlicheRate.ThousandsSeparator = true;
            this.nudIJährlicheRate.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudIJährlicheRate.ValueChanged += new System.EventHandler(this.nudIJährlicheRate_ValueChanged_1);
            // 
            // tbIName
            // 
            this.tbIName.AccessibleDescription = "";
            this.tbIName.AllowDrop = true;
            this.tbIName.Location = new System.Drawing.Point(129, 22);
            this.tbIName.Name = "tbIName";
            this.tbIName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbIName.Size = new System.Drawing.Size(71, 20);
            this.tbIName.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(117, 26);
            this.label20.TabIndex = 20;
            this.label20.Text = "Name der Immobilie:";
            // 
            // bIAbbrechen
            // 
            this.bIAbbrechen.Location = new System.Drawing.Point(24, 345);
            this.bIAbbrechen.Name = "bIAbbrechen";
            this.bIAbbrechen.Size = new System.Drawing.Size(85, 23);
            this.bIAbbrechen.TabIndex = 10;
            this.bIAbbrechen.Text = "Abbrechen";
            this.bIAbbrechen.UseVisualStyleBackColor = true;
            this.bIAbbrechen.Click += new System.EventHandler(this.bIAbbrechen_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox5.Location = new System.Drawing.Point(9, 278);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(191, 2);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // nudIMonatRate
            // 
            this.nudIMonatRate.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudIMonatRate.Location = new System.Drawing.Point(129, 132);
            this.nudIMonatRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudIMonatRate.Name = "nudIMonatRate";
            this.nudIMonatRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudIMonatRate.Size = new System.Drawing.Size(71, 20);
            this.nudIMonatRate.TabIndex = 4;
            this.nudIMonatRate.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudIMonatRate.ValueChanged += new System.EventHandler(this.nudIMonatRate_ValueChanged_1);
            // 
            // nudIKaufpreis
            // 
            this.nudIKaufpreis.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudIKaufpreis.Location = new System.Drawing.Point(129, 51);
            this.nudIKaufpreis.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudIKaufpreis.Name = "nudIKaufpreis";
            this.nudIKaufpreis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudIKaufpreis.Size = new System.Drawing.Size(71, 20);
            this.nudIKaufpreis.TabIndex = 1;
            this.nudIKaufpreis.ThousandsSeparator = true;
            this.nudIKaufpreis.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudIKaufpreis.ValueChanged += new System.EventHandler(this.nudIKaufpreis_ValueChanged);
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 45);
            this.label22.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(117, 26);
            this.label22.TabIndex = 7;
            this.label22.Text = "Kaufpreis\r\n(in 1.000€):";
            // 
            // bIBerechnen
            // 
            this.bIBerechnen.Location = new System.Drawing.Point(115, 344);
            this.bIBerechnen.Name = "bIBerechnen";
            this.bIBerechnen.Size = new System.Drawing.Size(85, 23);
            this.bIBerechnen.TabIndex = 9;
            this.bIBerechnen.Tag = "-1";
            this.bIBerechnen.Text = "Übernehmen";
            this.bIBerechnen.UseVisualStyleBackColor = true;
            this.bIBerechnen.Click += new System.EventHandler(this.bIBerechnen_Click);
            // 
            // tbIBarwert
            // 
            this.tbIBarwert.AccessibleDescription = "";
            this.tbIBarwert.AllowDrop = true;
            this.tbIBarwert.Location = new System.Drawing.Point(129, 292);
            this.tbIBarwert.Name = "tbIBarwert";
            this.tbIBarwert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbIBarwert.Size = new System.Drawing.Size(71, 20);
            this.tbIBarwert.TabIndex = 11;
            this.tbIBarwert.Text = "0";
            this.tbIBarwert.TextChanged += new System.EventHandler(this.tbIBarwert_TextChanged);
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 286);
            this.label23.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(117, 26);
            this.label23.TabIndex = 13;
            this.label23.Text = "Barwert\r\n(in €):";
            // 
            // cbAaAusgabeAuswählen
            // 
            this.cbAaAusgabeAuswählen.FormattingEnabled = true;
            this.cbAaAusgabeAuswählen.Items.AddRange(new object[] {
            "Feste Ausgaben",
            "Immobilie",
            "Unterstützung Kinder",
            "Andere"});
            this.cbAaAusgabeAuswählen.Location = new System.Drawing.Point(6, 16);
            this.cbAaAusgabeAuswählen.Name = "cbAaAusgabeAuswählen";
            this.cbAaAusgabeAuswählen.Size = new System.Drawing.Size(208, 21);
            this.cbAaAusgabeAuswählen.TabIndex = 0;
            this.cbAaAusgabeAuswählen.SelectedIndexChanged += new System.EventHandler(this.cbAaAusgabeAuswählen_SelectedIndexChanged);
            // 
            // gbGrundangaben
            // 
            this.gbGrundangaben.Controls.Add(this.lGA2Person);
            this.gbGrundangaben.Controls.Add(this.lGA1Person);
            this.gbGrundangaben.Controls.Add(this.lName2Person);
            this.gbGrundangaben.Controls.Add(this.label29);
            this.gbGrundangaben.Controls.Add(this.tbGAName1Per);
            this.gbGrundangaben.Controls.Add(this.tbGAName2Per);
            this.gbGrundangaben.Controls.Add(this.nudGAZPRentnerjahre);
            this.gbGrundangaben.Controls.Add(this.label10);
            this.gbGrundangaben.Controls.Add(this.label4);
            this.gbGrundangaben.Controls.Add(this.label3);
            this.gbGrundangaben.Controls.Add(this.nudGaZPInRenteGehenImJahr);
            this.gbGrundangaben.Controls.Add(this.nudGaZPJahreBisZurRente);
            this.gbGrundangaben.Controls.Add(this.cbGaZweitePerson);
            this.gbGrundangaben.Controls.Add(this.label2);
            this.gbGrundangaben.Controls.Add(this.nudGAInRenteGehenImJahr);
            this.gbGrundangaben.Controls.Add(this.nudGaRentnerjahre);
            this.gbGrundangaben.Controls.Add(this.label1);
            this.gbGrundangaben.Controls.Add(this.nudGaInflation);
            this.gbGrundangaben.Controls.Add(this.nudGaJahreBisZurRente);
            this.gbGrundangaben.Controls.Add(this.lJahreBisZurRente);
            this.gbGrundangaben.Controls.Add(this.lInflation);
            this.gbGrundangaben.Location = new System.Drawing.Point(6, 27);
            this.gbGrundangaben.Name = "gbGrundangaben";
            this.gbGrundangaben.Size = new System.Drawing.Size(606, 127);
            this.gbGrundangaben.TabIndex = 1;
            this.gbGrundangaben.TabStop = false;
            this.gbGrundangaben.Text = "Grundangaben";
            // 
            // lGA2Person
            // 
            this.lGA2Person.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGA2Person.Location = new System.Drawing.Point(403, 12);
            this.lGA2Person.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lGA2Person.Name = "lGA2Person";
            this.lGA2Person.Size = new System.Drawing.Size(117, 26);
            this.lGA2Person.TabIndex = 59;
            this.lGA2Person.Text = "2. Person:";
            // 
            // lGA1Person
            // 
            this.lGA1Person.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGA1Person.Location = new System.Drawing.Point(206, 12);
            this.lGA1Person.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lGA1Person.Name = "lGA1Person";
            this.lGA1Person.Size = new System.Drawing.Size(117, 26);
            this.lGA1Person.TabIndex = 58;
            this.lGA1Person.Text = "1. Person:";
            // 
            // lName2Person
            // 
            this.lName2Person.Enabled = false;
            this.lName2Person.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName2Person.Location = new System.Drawing.Point(3, 99);
            this.lName2Person.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lName2Person.Name = "lName2Person";
            this.lName2Person.Size = new System.Drawing.Size(117, 26);
            this.lName2Person.TabIndex = 57;
            this.lName2Person.Text = "Name 2. Person:";
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(3, 49);
            this.label29.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(117, 26);
            this.label29.TabIndex = 56;
            this.label29.Text = "Name 1. Person:";
            // 
            // tbGAName1Per
            // 
            this.tbGAName1Per.Location = new System.Drawing.Point(129, 51);
            this.tbGAName1Per.Name = "tbGAName1Per";
            this.tbGAName1Per.Size = new System.Drawing.Size(71, 20);
            this.tbGAName1Per.TabIndex = 2;
            this.tbGAName1Per.Text = "1. Person";
            this.tbGAName1Per.TextChanged += new System.EventHandler(this.tbGAName1Per_TextChanged);
            // 
            // tbGAName2Per
            // 
            this.tbGAName2Per.Enabled = false;
            this.tbGAName2Per.Location = new System.Drawing.Point(129, 96);
            this.tbGAName2Per.Name = "tbGAName2Per";
            this.tbGAName2Per.Size = new System.Drawing.Size(71, 20);
            this.tbGAName2Per.TabIndex = 4;
            this.tbGAName2Per.Text = "2. Person";
            this.tbGAName2Per.TextChanged += new System.EventHandler(this.tbGAName2Per_TextChanged);
            // 
            // nudGAZPRentnerjahre
            // 
            this.nudGAZPRentnerjahre.DecimalPlaces = 1;
            this.nudGAZPRentnerjahre.Enabled = false;
            this.nudGAZPRentnerjahre.Location = new System.Drawing.Point(526, 105);
            this.nudGAZPRentnerjahre.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudGAZPRentnerjahre.Name = "nudGAZPRentnerjahre";
            this.nudGAZPRentnerjahre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudGAZPRentnerjahre.Size = new System.Drawing.Size(71, 20);
            this.nudGAZPRentnerjahre.TabIndex = 10;
            this.nudGAZPRentnerjahre.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudGAZPRentnerjahre.ValueChanged += new System.EventHandler(this.nudGAZPRentnerjahre_ValueChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(403, 99);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 26);
            this.label10.TabIndex = 51;
            this.label10.Text = "Rentnerjahre:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 50;
            this.label4.Text = "Jahre bis zur Rente:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 26);
            this.label3.TabIndex = 49;
            this.label3.Text = "In Rente gehen im Jahr:";
            // 
            // nudGaZPInRenteGehenImJahr
            // 
            this.nudGaZPInRenteGehenImJahr.Enabled = false;
            this.nudGaZPInRenteGehenImJahr.Location = new System.Drawing.Point(526, 76);
            this.nudGaZPInRenteGehenImJahr.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudGaZPInRenteGehenImJahr.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudGaZPInRenteGehenImJahr.Name = "nudGaZPInRenteGehenImJahr";
            this.nudGaZPInRenteGehenImJahr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudGaZPInRenteGehenImJahr.Size = new System.Drawing.Size(71, 20);
            this.nudGaZPInRenteGehenImJahr.TabIndex = 9;
            this.nudGaZPInRenteGehenImJahr.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudGaZPInRenteGehenImJahr.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudGaZPInRenteGehenImJahr.ValueChanged += new System.EventHandler(this.nudGaZPInRenteGehenImJahr_ValueChanged);
            // 
            // nudGaZPJahreBisZurRente
            // 
            this.nudGaZPJahreBisZurRente.DecimalPlaces = 1;
            this.nudGaZPJahreBisZurRente.Enabled = false;
            this.nudGaZPJahreBisZurRente.Location = new System.Drawing.Point(526, 47);
            this.nudGaZPJahreBisZurRente.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudGaZPJahreBisZurRente.Name = "nudGaZPJahreBisZurRente";
            this.nudGaZPJahreBisZurRente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudGaZPJahreBisZurRente.Size = new System.Drawing.Size(71, 20);
            this.nudGaZPJahreBisZurRente.TabIndex = 8;
            this.nudGaZPJahreBisZurRente.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudGaZPJahreBisZurRente.ValueChanged += new System.EventHandler(this.nudGaZPJahreBisZurRente_ValueChanged);
            // 
            // cbGaZweitePerson
            // 
            this.cbGaZweitePerson.AutoSize = true;
            this.cbGaZweitePerson.Location = new System.Drawing.Point(9, 79);
            this.cbGaZweitePerson.Name = "cbGaZweitePerson";
            this.cbGaZweitePerson.Size = new System.Drawing.Size(94, 17);
            this.cbGaZweitePerson.TabIndex = 3;
            this.cbGaZweitePerson.Text = "Zweite Person";
            this.cbGaZweitePerson.UseVisualStyleBackColor = true;
            this.cbGaZweitePerson.CheckedChanged += new System.EventHandler(this.cbGaZweitePerson_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 46;
            this.label2.Text = "In Rente gehen im Jahr:";
            // 
            // nudGAInRenteGehenImJahr
            // 
            this.nudGAInRenteGehenImJahr.Location = new System.Drawing.Point(329, 76);
            this.nudGAInRenteGehenImJahr.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudGAInRenteGehenImJahr.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudGAInRenteGehenImJahr.Name = "nudGAInRenteGehenImJahr";
            this.nudGAInRenteGehenImJahr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudGAInRenteGehenImJahr.Size = new System.Drawing.Size(71, 20);
            this.nudGAInRenteGehenImJahr.TabIndex = 6;
            this.nudGAInRenteGehenImJahr.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudGAInRenteGehenImJahr.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudGAInRenteGehenImJahr.ValueChanged += new System.EventHandler(this.nudGAInRenteGehenImJahr_ValueChanged);
            // 
            // nudGaRentnerjahre
            // 
            this.nudGaRentnerjahre.DecimalPlaces = 1;
            this.nudGaRentnerjahre.Location = new System.Drawing.Point(329, 105);
            this.nudGaRentnerjahre.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudGaRentnerjahre.Name = "nudGaRentnerjahre";
            this.nudGaRentnerjahre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudGaRentnerjahre.Size = new System.Drawing.Size(71, 20);
            this.nudGaRentnerjahre.TabIndex = 7;
            this.nudGaRentnerjahre.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudGaRentnerjahre.ValueChanged += new System.EventHandler(this.nudGaRentnerjahre_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Rentnerjahre:";
            // 
            // nudGaInflation
            // 
            this.nudGaInflation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nudGaInflation.DecimalPlaces = 1;
            this.nudGaInflation.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudGaInflation.Location = new System.Drawing.Point(129, 25);
            this.nudGaInflation.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudGaInflation.Name = "nudGaInflation";
            this.nudGaInflation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudGaInflation.Size = new System.Drawing.Size(71, 20);
            this.nudGaInflation.TabIndex = 1;
            this.nudGaInflation.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudGaInflation.Value = new decimal(new int[] {
            35,
            0,
            0,
            65536});
            this.nudGaInflation.ValueChanged += new System.EventHandler(this.nudGaInflation_ValueChanged);
            // 
            // nudGaJahreBisZurRente
            // 
            this.nudGaJahreBisZurRente.DecimalPlaces = 1;
            this.nudGaJahreBisZurRente.Location = new System.Drawing.Point(329, 47);
            this.nudGaJahreBisZurRente.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudGaJahreBisZurRente.Name = "nudGaJahreBisZurRente";
            this.nudGaJahreBisZurRente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudGaJahreBisZurRente.Size = new System.Drawing.Size(71, 20);
            this.nudGaJahreBisZurRente.TabIndex = 5;
            this.nudGaJahreBisZurRente.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudGaJahreBisZurRente.ValueChanged += new System.EventHandler(this.nudBdmRJahreBisZurRente_ValueChanged);
            // 
            // lJahreBisZurRente
            // 
            this.lJahreBisZurRente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lJahreBisZurRente.Location = new System.Drawing.Point(206, 41);
            this.lJahreBisZurRente.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lJahreBisZurRente.Name = "lJahreBisZurRente";
            this.lJahreBisZurRente.Size = new System.Drawing.Size(117, 26);
            this.lJahreBisZurRente.TabIndex = 18;
            this.lJahreBisZurRente.Text = "Jahre bis zur Rente:";
            // 
            // lInflation
            // 
            this.lInflation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInflation.Location = new System.Drawing.Point(6, 19);
            this.lInflation.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lInflation.Name = "lInflation";
            this.lInflation.Size = new System.Drawing.Size(117, 26);
            this.lInflation.TabIndex = 1;
            this.lInflation.Text = "Durchschnittliche Inflation (in %):";
            // 
            // pSichtblende
            // 
            this.pSichtblende.Location = new System.Drawing.Point(782, 516);
            this.pSichtblende.Name = "pSichtblende";
            this.pSichtblende.Size = new System.Drawing.Size(840, 390);
            this.pSichtblende.TabIndex = 35;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Xml Dateien (*.xml)|*.xml|Alle Dateien (*.*)|*.*";
            // 
            // fAltersvorsorgerechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 556);
            this.Controls.Add(this.gbAltersvorsorgeAuswählen);
            this.Controls.Add(this.pSichtblende);
            this.Controls.Add(this.gbAusgabenauswählen);
            this.Controls.Add(this.gbGrundangaben);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbEinnahmen);
            this.Controls.Add(this.gbAusgaben);
            this.Name = "fAltersvorsorgerechner";
            this.Text = "Altersvorsorgeplanung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAltersvorsorgerechner_FormClosing);
            this.Load += new System.EventHandler(this.fAltersvorsorgerechner_Load);
            this.gbAusgaben.ResumeLayout(false);
            this.gbAusgaben.PerformLayout();
            this.gbAltersvorsorgeAuswählen.ResumeLayout(false);
            this.gbAltersvorsorgeErstellen.ResumeLayout(false);
            this.gbAltersvorsorgeErstellen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEeAVMonatlicheRate)).EndInit();
            this.gbAltersvorsorgebetragBerechnen.ResumeLayout(false);
            this.gbAltersvorsorgebetragBerechnen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAVBbJährlicheRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAVBbZinsAufBarwert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAVBbIstKapital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAVBbMonatRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAVBbZins)).EndInit();
            this.gbEinnahmen.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbAusgabenauswählen.ResumeLayout(false);
            this.gbFesteAusgaben.ResumeLayout(false);
            this.gbFesteAusgaben.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFAMonatKosten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFAInflation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFAJahreBisZurRente)).EndInit();
            this.gbImmobilie.ResumeLayout(false);
            this.gbImmobilie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIZins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIWertanpassung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIAbtragende)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIKaufjahr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIRestschulden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIJährlicheRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIMonatRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIKaufpreis)).EndInit();
            this.gbGrundangaben.ResumeLayout(false);
            this.gbGrundangaben.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGAZPRentnerjahre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGaZPInRenteGehenImJahr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGaZPJahreBisZurRente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGAInRenteGehenImJahr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGaRentnerjahre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGaInflation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGaJahreBisZurRente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAusgaben;
        private System.Windows.Forms.GroupBox gbEinnahmen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neueBerechnungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernUnterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Button bAusgabeBearbeiten;
        private System.Windows.Forms.Button bARAusgabeLöschen;
        private System.Windows.Forms.Button bARAusgabeHinzufügen;
        private System.Windows.Forms.TreeView tvAusgaben;
        private System.Windows.Forms.GroupBox gbAusgabenauswählen;
        private System.Windows.Forms.ComboBox cbAaAusgabeAuswählen;
        private System.Windows.Forms.GroupBox gbImmobilie;
        private System.Windows.Forms.NumericUpDown nudIZins;
        private System.Windows.Forms.NumericUpDown nudIWertanpassung;
        private System.Windows.Forms.GroupBox gbAltersvorsorgeErstellen;
        private System.Windows.Forms.TextBox tbEeAVName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bEeAVAbbrechen;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown nudEeAVMonatlicheRate;
        private System.Windows.Forms.Label lAltersvorsorgeMonatlicheRate;
        private System.Windows.Forms.Button bEeAVHinzufügen;
        private System.Windows.Forms.TextBox tbEeAVWertDerAltersvorsorge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown nudIAbtragende;
        private System.Windows.Forms.NumericUpDown nudIKaufjahr;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbIRenteProMonat;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nudIRestschulden;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nudIJährlicheRate;
        private System.Windows.Forms.TextBox tbIName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button bIAbbrechen;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.NumericUpDown nudIMonatRate;
        private System.Windows.Forms.NumericUpDown nudIKaufpreis;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button bIBerechnen;
        private System.Windows.Forms.TextBox tbIBarwert;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox gbGrundangaben;
        private System.Windows.Forms.NumericUpDown nudGaInflation;
        private System.Windows.Forms.NumericUpDown nudGaJahreBisZurRente;
        private System.Windows.Forms.Label lJahreBisZurRente;
        private System.Windows.Forms.Label lInflation;
        private System.Windows.Forms.NumericUpDown nudGaRentnerjahre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudGAInRenteGehenImJahr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudGaZPInRenteGehenImJahr;
        private System.Windows.Forms.NumericUpDown nudGaZPJahreBisZurRente;
        private System.Windows.Forms.CheckBox cbGaZweitePerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAAusgabenZumRentenbegin;
        private System.Windows.Forms.GroupBox gbFesteAusgaben;
        private System.Windows.Forms.Button bFAAbbrechen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudFAMonatKosten;
        private System.Windows.Forms.NumericUpDown nudFAInflation;
        private System.Windows.Forms.Label lJetztigeMonatlicheKosten;
        private System.Windows.Forms.NumericUpDown nudFAJahreBisZurRente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bFAÜbernehmen;
        private System.Windows.Forms.TextBox tbFAEndwert;
        private System.Windows.Forms.Label lEndwert;
        private System.Windows.Forms.Button bEEinahmeBearbeiten;
        private System.Windows.Forms.Button bEEinahmeLöschen;
        private System.Windows.Forms.Button bEEinnahmeHinzufügen;
        private System.Windows.Forms.GroupBox gbAltersvorsorgeAuswählen;
        private System.Windows.Forms.ComboBox cbAVaAltersvorsorgeAuswählen;
        private System.Windows.Forms.GroupBox gbAltersvorsorgebetragBerechnen;
        private System.Windows.Forms.NumericUpDown nudAVBbJährlicheRate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudAVBbIstKapital;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudAVBbMonatRate;
        private System.Windows.Forms.TextBox tbAVBbName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bAVBbAbbrechen;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.NumericUpDown nudAVBbZins;
        private System.Windows.Forms.Label lAVBbRate;
        private System.Windows.Forms.Button bAVBbÜbernehmen;
        private System.Windows.Forms.TextBox tbAVBbBarwert;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ListView lvEinnahmen;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chRateProMonat;
        private System.Windows.Forms.ColumnHeader chZinssatz;
        private System.Windows.Forms.ColumnHeader chBarwert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAVBbZinsAufBarwert;
        private System.Windows.Forms.Panel pSichtblende;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown nudGAZPRentnerjahre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lGA2Person;
        private System.Windows.Forms.Label lGA1Person;
        private System.Windows.Forms.Label lName2Person;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbGAName1Per;
        private System.Windows.Forms.TextBox tbGAName2Per;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cbAVBbPersonenauswahl;
        private System.Windows.Forms.ComboBox cbEeAVPersonenauswahl;
        private System.Windows.Forms.ListView lvEinnahmenErgebnis;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;

    }
}

