namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cmsHilfe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiHilfe = new System.Windows.Forms.ToolStripMenuItem();
            this.bBenötigteVorsorgeBerechnen = new System.Windows.Forms.Button();
            this.tbArGesamteAusgaben = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.gbAusgabenreduzierung = new System.Windows.Forms.GroupBox();
            this.tbFehlenderBetrag = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.nudBKbZins = new System.Windows.Forms.NumericUpDown();
            this.gbBenötigtesKapitalBerechnen = new System.Windows.Forms.GroupBox();
            this.bBKbMonatRenteBerechnen = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbBKbMonatRente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bBKbBerechnen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBKbBenötigtesKapital = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudBKbRentenjahre = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.gbAltersvorsorge = new System.Windows.Forms.GroupBox();
            this.tbAWertAllerAltersvorsorgen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bAAltersvosorgeLöschen = new System.Windows.Forms.Button();
            this.bANeueAltersvorsorge = new System.Windows.Forms.Button();
            this.tvAAltersvorsorge = new System.Windows.Forms.TreeView();
            this.cmsHilfe.SuspendLayout();
            this.gbAusgabenreduzierung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBKbZins)).BeginInit();
            this.gbBenötigtesKapitalBerechnen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBKbRentenjahre)).BeginInit();
            this.gbAltersvorsorge.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsHilfe
            // 
            this.cmsHilfe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHilfe});
            this.cmsHilfe.Name = "cmsHilfe";
            this.cmsHilfe.Size = new System.Drawing.Size(107, 26);
            // 
            // tsmiHilfe
            // 
            this.tsmiHilfe.Name = "tsmiHilfe";
            this.tsmiHilfe.Size = new System.Drawing.Size(106, 22);
            this.tsmiHilfe.Text = "Hilfe";
            // 
            // bBenötigteVorsorgeBerechnen
            // 
            this.bBenötigteVorsorgeBerechnen.Location = new System.Drawing.Point(482, 114);
            this.bBenötigteVorsorgeBerechnen.Name = "bBenötigteVorsorgeBerechnen";
            this.bBenötigteVorsorgeBerechnen.Size = new System.Drawing.Size(281, 23);
            this.bBenötigteVorsorgeBerechnen.TabIndex = 40;
            this.bBenötigteVorsorgeBerechnen.Text = "Benötigte Vorsorge berechnen";
            this.bBenötigteVorsorgeBerechnen.UseVisualStyleBackColor = true;
            // 
            // tbArGesamteAusgaben
            // 
            this.tbArGesamteAusgaben.Location = new System.Drawing.Point(131, 219);
            this.tbArGesamteAusgaben.Name = "tbArGesamteAusgaben";
            this.tbArGesamteAusgaben.Size = new System.Drawing.Size(71, 20);
            this.tbArGesamteAusgaben.TabIndex = 36;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(6, 216);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(117, 26);
            this.label28.TabIndex = 35;
            this.label28.Text = "Gesamte Ausgaben:";
            // 
            // gbAusgabenreduzierung
            // 
            this.gbAusgabenreduzierung.Controls.Add(this.tbArGesamteAusgaben);
            this.gbAusgabenreduzierung.Controls.Add(this.label28);
            this.gbAusgabenreduzierung.Location = new System.Drawing.Point(12, 267);
            this.gbAusgabenreduzierung.Name = "gbAusgabenreduzierung";
            this.gbAusgabenreduzierung.Size = new System.Drawing.Size(208, 245);
            this.gbAusgabenreduzierung.TabIndex = 41;
            this.gbAusgabenreduzierung.TabStop = false;
            this.gbAusgabenreduzierung.Text = "2.0) Ausgabenreduzierung";
            this.gbAusgabenreduzierung.Visible = false;
            // 
            // tbFehlenderBetrag
            // 
            this.tbFehlenderBetrag.AccessibleDescription = "";
            this.tbFehlenderBetrag.AllowDrop = true;
            this.tbFehlenderBetrag.ContextMenuStrip = this.cmsHilfe;
            this.tbFehlenderBetrag.Location = new System.Drawing.Point(678, 88);
            this.tbFehlenderBetrag.Name = "tbFehlenderBetrag";
            this.tbFehlenderBetrag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbFehlenderBetrag.Size = new System.Drawing.Size(85, 20);
            this.tbFehlenderBetrag.TabIndex = 38;
            // 
            // nudBKbZins
            // 
            this.nudBKbZins.DecimalPlaces = 1;
            this.nudBKbZins.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudBKbZins.Location = new System.Drawing.Point(125, 66);
            this.nudBKbZins.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudBKbZins.Name = "nudBKbZins";
            this.nudBKbZins.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudBKbZins.Size = new System.Drawing.Size(71, 20);
            this.nudBKbZins.TabIndex = 19;
            this.nudBKbZins.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // gbBenötigtesKapitalBerechnen
            // 
            this.gbBenötigtesKapitalBerechnen.Controls.Add(this.nudBKbZins);
            this.gbBenötigtesKapitalBerechnen.Controls.Add(this.bBKbMonatRenteBerechnen);
            this.gbBenötigtesKapitalBerechnen.Controls.Add(this.pictureBox2);
            this.gbBenötigtesKapitalBerechnen.Controls.Add(this.tbBKbMonatRente);
            this.gbBenötigtesKapitalBerechnen.Controls.Add(this.label1);
            this.gbBenötigtesKapitalBerechnen.Controls.Add(this.bBKbBerechnen);
            this.gbBenötigtesKapitalBerechnen.Controls.Add(this.label2);
            this.gbBenötigtesKapitalBerechnen.Controls.Add(this.tbBKbBenötigtesKapital);
            this.gbBenötigtesKapitalBerechnen.Controls.Add(this.label3);
            this.gbBenötigtesKapitalBerechnen.Controls.Add(this.nudBKbRentenjahre);
            this.gbBenötigtesKapitalBerechnen.Controls.Add(this.label4);
            this.gbBenötigtesKapitalBerechnen.Location = new System.Drawing.Point(489, 177);
            this.gbBenötigtesKapitalBerechnen.Name = "gbBenötigtesKapitalBerechnen";
            this.gbBenötigtesKapitalBerechnen.Size = new System.Drawing.Size(294, 122);
            this.gbBenötigtesKapitalBerechnen.TabIndex = 37;
            this.gbBenötigtesKapitalBerechnen.TabStop = false;
            this.gbBenötigtesKapitalBerechnen.Text = "Benötigtes Kapital berechnen";
            // 
            // bBKbMonatRenteBerechnen
            // 
            this.bBKbMonatRenteBerechnen.Location = new System.Drawing.Point(202, 11);
            this.bBKbMonatRenteBerechnen.Name = "bBKbMonatRenteBerechnen";
            this.bBKbMonatRenteBerechnen.Size = new System.Drawing.Size(85, 23);
            this.bBKbMonatRenteBerechnen.TabIndex = 2;
            this.bBKbMonatRenteBerechnen.Text = "Monat. Rente";
            this.bBKbMonatRenteBerechnen.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox2.Location = new System.Drawing.Point(9, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 2);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // tbBKbMonatRente
            // 
            this.tbBKbMonatRente.Location = new System.Drawing.Point(125, 13);
            this.tbBKbMonatRente.Name = "tbBKbMonatRente";
            this.tbBKbMonatRente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbBKbMonatRente.Size = new System.Drawing.Size(71, 20);
            this.tbBKbMonatRente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Monatliche Rente:";
            // 
            // bBKbBerechnen
            // 
            this.bBKbBerechnen.Location = new System.Drawing.Point(202, 95);
            this.bBKbBerechnen.Name = "bBKbBerechnen";
            this.bBKbBerechnen.Size = new System.Drawing.Size(85, 23);
            this.bBKbBerechnen.TabIndex = 21;
            this.bBKbBerechnen.Text = "Berechnen";
            this.bBKbBerechnen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rentenjahre:";
            // 
            // tbBKbBenötigtesKapital
            // 
            this.tbBKbBenötigtesKapital.AccessibleDescription = "";
            this.tbBKbBenötigtesKapital.AllowDrop = true;
            this.tbBKbBenötigtesKapital.ContextMenuStrip = this.cmsHilfe;
            this.tbBKbBenötigtesKapital.Location = new System.Drawing.Point(125, 97);
            this.tbBKbBenötigtesKapital.Name = "tbBKbBenötigtesKapital";
            this.tbBKbBenötigtesKapital.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbBKbBenötigtesKapital.Size = new System.Drawing.Size(71, 20);
            this.tbBKbBenötigtesKapital.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zins (in %):";
            // 
            // nudBKbRentenjahre
            // 
            this.nudBKbRentenjahre.DecimalPlaces = 1;
            this.nudBKbRentenjahre.Location = new System.Drawing.Point(125, 40);
            this.nudBKbRentenjahre.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudBKbRentenjahre.Name = "nudBKbRentenjahre";
            this.nudBKbRentenjahre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudBKbRentenjahre.Size = new System.Drawing.Size(71, 20);
            this.nudBKbRentenjahre.TabIndex = 19;
            this.nudBKbRentenjahre.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Benötigtes Kapital:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(486, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 26);
            this.label9.TabIndex = 39;
            this.label9.Text = "Fehlender Betrag:";
            // 
            // gbAltersvorsorge
            // 
            this.gbAltersvorsorge.Controls.Add(this.tbAWertAllerAltersvorsorgen);
            this.gbAltersvorsorge.Controls.Add(this.label7);
            this.gbAltersvorsorge.Controls.Add(this.bAAltersvosorgeLöschen);
            this.gbAltersvorsorge.Controls.Add(this.bANeueAltersvorsorge);
            this.gbAltersvorsorge.Controls.Add(this.tvAAltersvorsorge);
            this.gbAltersvorsorge.Location = new System.Drawing.Point(247, 267);
            this.gbAltersvorsorge.Name = "gbAltersvorsorge";
            this.gbAltersvorsorge.Size = new System.Drawing.Size(294, 224);
            this.gbAltersvorsorge.TabIndex = 42;
            this.gbAltersvorsorge.TabStop = false;
            this.gbAltersvorsorge.Text = "Altersvorsorge";
            // 
            // tbAWertAllerAltersvorsorgen
            // 
            this.tbAWertAllerAltersvorsorgen.AccessibleDescription = "";
            this.tbAWertAllerAltersvorsorgen.AllowDrop = true;
            this.tbAWertAllerAltersvorsorgen.Location = new System.Drawing.Point(202, 195);
            this.tbAWertAllerAltersvorsorgen.Name = "tbAWertAllerAltersvorsorgen";
            this.tbAWertAllerAltersvorsorgen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbAWertAllerAltersvorsorgen.Size = new System.Drawing.Size(85, 20);
            this.tbAWertAllerAltersvorsorgen.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 26);
            this.label7.TabIndex = 24;
            this.label7.Text = "Wert der Altersvorsorgen:";
            // 
            // bAAltersvosorgeLöschen
            // 
            this.bAAltersvosorgeLöschen.Location = new System.Drawing.Point(202, 77);
            this.bAAltersvosorgeLöschen.Name = "bAAltersvosorgeLöschen";
            this.bAAltersvosorgeLöschen.Size = new System.Drawing.Size(85, 55);
            this.bAAltersvosorgeLöschen.TabIndex = 25;
            this.bAAltersvosorgeLöschen.Text = "Altersvorsorge löschen";
            this.bAAltersvosorgeLöschen.UseVisualStyleBackColor = true;
            // 
            // bANeueAltersvorsorge
            // 
            this.bANeueAltersvorsorge.Location = new System.Drawing.Point(202, 19);
            this.bANeueAltersvorsorge.Name = "bANeueAltersvorsorge";
            this.bANeueAltersvorsorge.Size = new System.Drawing.Size(85, 55);
            this.bANeueAltersvorsorge.TabIndex = 23;
            this.bANeueAltersvorsorge.Text = "Neue Altersvorsorge erstellen";
            this.bANeueAltersvorsorge.UseVisualStyleBackColor = true;
            // 
            // tvAAltersvorsorge
            // 
            this.tvAAltersvorsorge.Location = new System.Drawing.Point(6, 19);
            this.tvAAltersvorsorge.Name = "tvAAltersvorsorge";
            this.tvAAltersvorsorge.Size = new System.Drawing.Size(190, 161);
            this.tvAAltersvorsorge.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 589);
            this.Controls.Add(this.bBenötigteVorsorgeBerechnen);
            this.Controls.Add(this.gbAltersvorsorge);
            this.Controls.Add(this.gbAusgabenreduzierung);
            this.Controls.Add(this.tbFehlenderBetrag);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbBenötigtesKapitalBerechnen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsHilfe.ResumeLayout(false);
            this.gbAusgabenreduzierung.ResumeLayout(false);
            this.gbAusgabenreduzierung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBKbZins)).EndInit();
            this.gbBenötigtesKapitalBerechnen.ResumeLayout(false);
            this.gbBenötigtesKapitalBerechnen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBKbRentenjahre)).EndInit();
            this.gbAltersvorsorge.ResumeLayout(false);
            this.gbAltersvorsorge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsHilfe;
        private System.Windows.Forms.ToolStripMenuItem tsmiHilfe;
        private System.Windows.Forms.Button bBenötigteVorsorgeBerechnen;
        private System.Windows.Forms.TextBox tbArGesamteAusgaben;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox gbAusgabenreduzierung;
        private System.Windows.Forms.TextBox tbFehlenderBetrag;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown nudBKbZins;
        private System.Windows.Forms.GroupBox gbBenötigtesKapitalBerechnen;
        private System.Windows.Forms.Button bBKbMonatRenteBerechnen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbBKbMonatRente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bBKbBerechnen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBKbBenötigtesKapital;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudBKbRentenjahre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbAltersvorsorge;
        private System.Windows.Forms.TextBox tbAWertAllerAltersvorsorgen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bAAltersvosorgeLöschen;
        private System.Windows.Forms.Button bANeueAltersvorsorge;
        private System.Windows.Forms.TreeView tvAAltersvorsorge;
    }
}