namespace WindowsFormsApplication1
{
    partial class Afrekenen
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
            this.lbl_rekening = new System.Windows.Forms.Label();
            this.lbl_opmerkingen = new System.Windows.Forms.Label();
            this.lbl_subtotaal = new System.Windows.Forms.Label();
            this.lbl_fooilabel = new System.Windows.Forms.Label();
            this.lbl_incbtw = new System.Windows.Forms.Label();
            this.lbl_btwhoog = new System.Windows.Forms.Label();
            this.lbl_btwlaag = new System.Windows.Forms.Label();
            this.lbl_subtotaalgetal = new System.Windows.Forms.Label();
            this.lbl_incbtwgetal = new System.Windows.Forms.Label();
            this.lbl_btwhooggetal = new System.Windows.Forms.Label();
            this.lbl_btwlaaggetal = new System.Windows.Forms.Label();
            this.BTN_AFREKENENnaarTAFELOVERZICHT = new System.Windows.Forms.Button();
            this.btn_printrekening = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txt_fooi = new System.Windows.Forms.TextBox();
            this.listview_rekening = new System.Windows.Forms.ListView();
            this.naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tafel_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_tafelNummerDisplay = new System.Windows.Forms.Label();
            this.lbl_opmerking = new System.Windows.Forms.Label();
            this.lbl_totaalBTW = new System.Windows.Forms.Label();
            this.lbl_totaal = new System.Windows.Forms.Label();
            this.txt_Opmerking = new System.Windows.Forms.TextBox();
            this.lbl_GhostSubtotaal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_rekening
            // 
            this.lbl_rekening.AutoSize = true;
            this.lbl_rekening.Font = new System.Drawing.Font("Calibri", 18F);
            this.lbl_rekening.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_rekening.Location = new System.Drawing.Point(334, 21);
            this.lbl_rekening.Name = "lbl_rekening";
            this.lbl_rekening.Size = new System.Drawing.Size(109, 29);
            this.lbl_rekening.TabIndex = 1;
            this.lbl_rekening.Text = "Rekening:";
            // 
            // lbl_opmerkingen
            // 
            this.lbl_opmerkingen.AutoSize = true;
            this.lbl_opmerkingen.Font = new System.Drawing.Font("Calibri", 9F);
            this.lbl_opmerkingen.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_opmerkingen.Location = new System.Drawing.Point(364, 345);
            this.lbl_opmerkingen.Name = "lbl_opmerkingen";
            this.lbl_opmerkingen.Size = new System.Drawing.Size(69, 14);
            this.lbl_opmerkingen.TabIndex = 4;
            this.lbl_opmerkingen.Text = "Opmerking:";
            // 
            // lbl_subtotaal
            // 
            this.lbl_subtotaal.AutoSize = true;
            this.lbl_subtotaal.Font = new System.Drawing.Font("Calibri", 9F);
            this.lbl_subtotaal.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_subtotaal.Location = new System.Drawing.Point(368, 480);
            this.lbl_subtotaal.Name = "lbl_subtotaal";
            this.lbl_subtotaal.Size = new System.Drawing.Size(63, 14);
            this.lbl_subtotaal.TabIndex = 5;
            this.lbl_subtotaal.Text = "Subtotaal:";
            // 
            // lbl_fooilabel
            // 
            this.lbl_fooilabel.AutoSize = true;
            this.lbl_fooilabel.Font = new System.Drawing.Font("Calibri", 9F);
            this.lbl_fooilabel.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_fooilabel.Location = new System.Drawing.Point(396, 375);
            this.lbl_fooilabel.Name = "lbl_fooilabel";
            this.lbl_fooilabel.Size = new System.Drawing.Size(31, 14);
            this.lbl_fooilabel.TabIndex = 6;
            this.lbl_fooilabel.Text = "Fooi";
            // 
            // lbl_incbtw
            // 
            this.lbl_incbtw.AutoSize = true;
            this.lbl_incbtw.Font = new System.Drawing.Font("Calibri", 9F);
            this.lbl_incbtw.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_incbtw.Location = new System.Drawing.Point(355, 452);
            this.lbl_incbtw.Name = "lbl_incbtw";
            this.lbl_incbtw.Size = new System.Drawing.Size(71, 14);
            this.lbl_incbtw.TabIndex = 7;
            this.lbl_incbtw.Text = "Totaal BTW:";
            // 
            // lbl_btwhoog
            // 
            this.lbl_btwhoog.AutoSize = true;
            this.lbl_btwhoog.Font = new System.Drawing.Font("Calibri", 9F);
            this.lbl_btwhoog.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_btwhoog.Location = new System.Drawing.Point(359, 402);
            this.lbl_btwhoog.Name = "lbl_btwhoog";
            this.lbl_btwhoog.Size = new System.Drawing.Size(65, 14);
            this.lbl_btwhoog.TabIndex = 8;
            this.lbl_btwhoog.Text = "BTW Hoog:";
            // 
            // lbl_btwlaag
            // 
            this.lbl_btwlaag.AutoSize = true;
            this.lbl_btwlaag.Font = new System.Drawing.Font("Calibri", 9F);
            this.lbl_btwlaag.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_btwlaag.Location = new System.Drawing.Point(361, 422);
            this.lbl_btwlaag.Name = "lbl_btwlaag";
            this.lbl_btwlaag.Size = new System.Drawing.Size(62, 14);
            this.lbl_btwlaag.TabIndex = 9;
            this.lbl_btwlaag.Text = "BTW Laag:";
            // 
            // lbl_subtotaalgetal
            // 
            this.lbl_subtotaalgetal.AutoSize = true;
            this.lbl_subtotaalgetal.Font = new System.Drawing.Font("Calibri", 9F);
            this.lbl_subtotaalgetal.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_subtotaalgetal.Location = new System.Drawing.Point(441, 480);
            this.lbl_subtotaalgetal.Name = "lbl_subtotaalgetal";
            this.lbl_subtotaalgetal.Size = new System.Drawing.Size(0, 14);
            this.lbl_subtotaalgetal.TabIndex = 10;
            // 
            // lbl_incbtwgetal
            // 
            this.lbl_incbtwgetal.AutoSize = true;
            this.lbl_incbtwgetal.Location = new System.Drawing.Point(654, 422);
            this.lbl_incbtwgetal.Name = "lbl_incbtwgetal";
            this.lbl_incbtwgetal.Size = new System.Drawing.Size(0, 13);
            this.lbl_incbtwgetal.TabIndex = 12;
            // 
            // lbl_btwhooggetal
            // 
            this.lbl_btwhooggetal.AutoSize = true;
            this.lbl_btwhooggetal.Font = new System.Drawing.Font("Calibri", 9F);
            this.lbl_btwhooggetal.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_btwhooggetal.Location = new System.Drawing.Point(441, 402);
            this.lbl_btwhooggetal.Name = "lbl_btwhooggetal";
            this.lbl_btwhooggetal.Size = new System.Drawing.Size(0, 14);
            this.lbl_btwhooggetal.TabIndex = 13;
            // 
            // lbl_btwlaaggetal
            // 
            this.lbl_btwlaaggetal.AutoSize = true;
            this.lbl_btwlaaggetal.Font = new System.Drawing.Font("Calibri", 9F);
            this.lbl_btwlaaggetal.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_btwlaaggetal.Location = new System.Drawing.Point(441, 422);
            this.lbl_btwlaaggetal.Name = "lbl_btwlaaggetal";
            this.lbl_btwlaaggetal.Size = new System.Drawing.Size(0, 14);
            this.lbl_btwlaaggetal.TabIndex = 14;
            // 
            // BTN_AFREKENENnaarTAFELOVERZICHT
            // 
            this.BTN_AFREKENENnaarTAFELOVERZICHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.BTN_AFREKENENnaarTAFELOVERZICHT.Font = new System.Drawing.Font("Calibri", 10F);
            this.BTN_AFREKENENnaarTAFELOVERZICHT.ForeColor = System.Drawing.Color.White;
            this.BTN_AFREKENENnaarTAFELOVERZICHT.Location = new System.Drawing.Point(7, 12);
            this.BTN_AFREKENENnaarTAFELOVERZICHT.Name = "BTN_AFREKENENnaarTAFELOVERZICHT";
            this.BTN_AFREKENENnaarTAFELOVERZICHT.Size = new System.Drawing.Size(111, 49);
            this.BTN_AFREKENENnaarTAFELOVERZICHT.TabIndex = 21;
            this.BTN_AFREKENENnaarTAFELOVERZICHT.Text = "Terug naar Tafeloverzicht";
            this.BTN_AFREKENENnaarTAFELOVERZICHT.UseVisualStyleBackColor = false;
            this.BTN_AFREKENENnaarTAFELOVERZICHT.Click += new System.EventHandler(this.BTN_AFREKENENnaarTAFELOVERZICHT_Click);
            // 
            // btn_printrekening
            // 
            this.btn_printrekening.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.btn_printrekening.Font = new System.Drawing.Font("Calibri", 13F);
            this.btn_printrekening.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_printrekening.Location = new System.Drawing.Point(7, 372);
            this.btn_printrekening.Name = "btn_printrekening";
            this.btn_printrekening.Size = new System.Drawing.Size(309, 43);
            this.btn_printrekening.TabIndex = 22;
            this.btn_printrekening.Text = "Print Rekening";
            this.btn_printrekening.UseVisualStyleBackColor = false;
            this.btn_printrekening.Click += new System.EventHandler(this.btn_printrekening_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Calibri", 13F);
            this.radioButton1.ForeColor = System.Drawing.SystemColors.Info;
            this.radioButton1.Location = new System.Drawing.Point(12, 441);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 26);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pin";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(87)))), ((int)(((byte)(64)))));
            this.radioButton2.Font = new System.Drawing.Font("Calibri", 13F);
            this.radioButton2.ForeColor = System.Drawing.SystemColors.Info;
            this.radioButton2.Location = new System.Drawing.Point(94, 441);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 26);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Creditcard";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Calibri", 13F);
            this.radioButton3.ForeColor = System.Drawing.SystemColors.Info;
            this.radioButton3.Location = new System.Drawing.Point(232, 441);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 26);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Contant";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // txt_fooi
            // 
            this.txt_fooi.Location = new System.Drawing.Point(431, 372);
            this.txt_fooi.Name = "txt_fooi";
            this.txt_fooi.Size = new System.Drawing.Size(61, 20);
            this.txt_fooi.TabIndex = 26;
            this.txt_fooi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listview_rekening
            // 
            this.listview_rekening.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(246)))), ((int)(((byte)(235)))));
            this.listview_rekening.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.naam,
            this.tafel_id,
            this.aantal});
            this.listview_rekening.FullRowSelect = true;
            this.listview_rekening.GridLines = true;
            this.listview_rekening.Location = new System.Drawing.Point(7, 78);
            this.listview_rekening.Name = "listview_rekening";
            this.listview_rekening.Size = new System.Drawing.Size(756, 260);
            this.listview_rekening.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listview_rekening.TabIndex = 88;
            this.listview_rekening.UseCompatibleStateImageBehavior = false;
            this.listview_rekening.View = System.Windows.Forms.View.Details;
            this.listview_rekening.SelectedIndexChanged += new System.EventHandler(this.listview_rekening_SelectedIndexChanged);
            // 
            // naam
            // 
            this.naam.Text = "Naam";
            this.naam.Width = 500;
            // 
            // tafel_id
            // 
            this.tafel_id.Text = "Aantal";
            // 
            // aantal
            // 
            this.aantal.Text = "Prijs";
            // 
            // lbl_tafelNummerDisplay
            // 
            this.lbl_tafelNummerDisplay.AutoSize = true;
            this.lbl_tafelNummerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tafelNummerDisplay.Location = new System.Drawing.Point(377, 21);
            this.lbl_tafelNummerDisplay.Name = "lbl_tafelNummerDisplay";
            this.lbl_tafelNummerDisplay.Size = new System.Drawing.Size(0, 24);
            this.lbl_tafelNummerDisplay.TabIndex = 89;
            // 
            // lbl_opmerking
            // 
            this.lbl_opmerking.AutoSize = true;
            this.lbl_opmerking.Location = new System.Drawing.Point(443, 345);
            this.lbl_opmerking.Name = "lbl_opmerking";
            this.lbl_opmerking.Size = new System.Drawing.Size(0, 13);
            this.lbl_opmerking.TabIndex = 90;
            // 
            // lbl_totaalBTW
            // 
            this.lbl_totaalBTW.AutoSize = true;
            this.lbl_totaalBTW.Font = new System.Drawing.Font("Calibri", 9F);
            this.lbl_totaalBTW.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_totaalBTW.Location = new System.Drawing.Point(441, 452);
            this.lbl_totaalBTW.Name = "lbl_totaalBTW";
            this.lbl_totaalBTW.Size = new System.Drawing.Size(0, 14);
            this.lbl_totaalBTW.TabIndex = 91;
            // 
            // lbl_totaal
            // 
            this.lbl_totaal.AutoSize = true;
            this.lbl_totaal.Font = new System.Drawing.Font("Calibri", 9F);
            this.lbl_totaal.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_totaal.Location = new System.Drawing.Point(441, 480);
            this.lbl_totaal.Name = "lbl_totaal";
            this.lbl_totaal.Size = new System.Drawing.Size(0, 14);
            this.lbl_totaal.TabIndex = 93;
            // 
            // txt_Opmerking
            // 
            this.txt_Opmerking.Location = new System.Drawing.Point(431, 344);
            this.txt_Opmerking.Name = "txt_Opmerking";
            this.txt_Opmerking.Size = new System.Drawing.Size(332, 20);
            this.txt_Opmerking.TabIndex = 94;
            // 
            // lbl_GhostSubtotaal
            // 
            this.lbl_GhostSubtotaal.AutoSize = true;
            this.lbl_GhostSubtotaal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(87)))), ((int)(((byte)(64)))));
            this.lbl_GhostSubtotaal.Location = new System.Drawing.Point(587, 21);
            this.lbl_GhostSubtotaal.Name = "lbl_GhostSubtotaal";
            this.lbl_GhostSubtotaal.Size = new System.Drawing.Size(0, 13);
            this.lbl_GhostSubtotaal.TabIndex = 95;
            // 
            // Afrekenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(87)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(775, 502);
            this.Controls.Add(this.lbl_GhostSubtotaal);
            this.Controls.Add(this.txt_Opmerking);
            this.Controls.Add(this.lbl_totaal);
            this.Controls.Add(this.lbl_totaalBTW);
            this.Controls.Add(this.lbl_opmerking);
            this.Controls.Add(this.lbl_tafelNummerDisplay);
            this.Controls.Add(this.listview_rekening);
            this.Controls.Add(this.txt_fooi);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btn_printrekening);
            this.Controls.Add(this.BTN_AFREKENENnaarTAFELOVERZICHT);
            this.Controls.Add(this.lbl_btwlaaggetal);
            this.Controls.Add(this.lbl_btwhooggetal);
            this.Controls.Add(this.lbl_incbtwgetal);
            this.Controls.Add(this.lbl_subtotaalgetal);
            this.Controls.Add(this.lbl_btwlaag);
            this.Controls.Add(this.lbl_btwhoog);
            this.Controls.Add(this.lbl_incbtw);
            this.Controls.Add(this.lbl_fooilabel);
            this.Controls.Add(this.lbl_subtotaal);
            this.Controls.Add(this.lbl_opmerkingen);
            this.Controls.Add(this.lbl_rekening);
            this.Name = "Afrekenen";
            this.Text = "Afrekenen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rekening;
        private System.Windows.Forms.Label lbl_opmerkingen;
        private System.Windows.Forms.Label lbl_subtotaal;
        private System.Windows.Forms.Label lbl_fooilabel;
        private System.Windows.Forms.Label lbl_incbtw;
        private System.Windows.Forms.Label lbl_btwhoog;
        private System.Windows.Forms.Label lbl_btwlaag;
        private System.Windows.Forms.Label lbl_subtotaalgetal;
        private System.Windows.Forms.Label lbl_incbtwgetal;
        private System.Windows.Forms.Label lbl_btwhooggetal;
        private System.Windows.Forms.Label lbl_btwlaaggetal;
        private System.Windows.Forms.Button BTN_AFREKENENnaarTAFELOVERZICHT;
        private System.Windows.Forms.Button btn_printrekening;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox txt_fooi;
        private System.Windows.Forms.ListView listview_rekening;
        private System.Windows.Forms.ColumnHeader tafel_id;
        private System.Windows.Forms.ColumnHeader aantal;
        private System.Windows.Forms.ColumnHeader naam;
        private System.Windows.Forms.Label lbl_tafelNummerDisplay;
        private System.Windows.Forms.Label lbl_opmerking;
        private System.Windows.Forms.Label lbl_totaalBTW;
        private System.Windows.Forms.Label lbl_totaal;
        private System.Windows.Forms.TextBox txt_Opmerking;
        private System.Windows.Forms.Label lbl_GhostSubtotaal;

    }
}