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
            this.lbl_klaargemeld = new System.Windows.Forms.Label();
            this.lbl_rekening = new System.Windows.Forms.Label();
            this.lstbox_eindrekening = new System.Windows.Forms.ListBox();
            this.lbl_klaargemeldetafel = new System.Windows.Forms.Label();
            this.lbl_opmerkingen = new System.Windows.Forms.Label();
            this.lbl_subtotaal = new System.Windows.Forms.Label();
            this.lbl_fooilabel = new System.Windows.Forms.Label();
            this.lbl_incbtw = new System.Windows.Forms.Label();
            this.lbl_btwhoog = new System.Windows.Forms.Label();
            this.lbl_btwlaag = new System.Windows.Forms.Label();
            this.lbl_subtotaalgetal = new System.Windows.Forms.Label();
            this.lbl_fooigetal = new System.Windows.Forms.Label();
            this.lbl_incbtwgetal = new System.Windows.Forms.Label();
            this.lbl_btwhooggetal = new System.Windows.Forms.Label();
            this.lbl_btwlaaggetal = new System.Windows.Forms.Label();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_cbutton = new System.Windows.Forms.Button();
            this.btn_pinbetalen = new System.Windows.Forms.Button();
            this.btn_creditcardbetalen = new System.Windows.Forms.Button();
            this.btn_contantbetalen = new System.Windows.Forms.Button();
            this.BTN_AFREKENENnaarTAFELOVERZICHT = new System.Windows.Forms.Button();
            this.btn_printrekening = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_klaargemeld
            // 
            this.lbl_klaargemeld.AutoSize = true;
            this.lbl_klaargemeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_klaargemeld.Location = new System.Drawing.Point(12, 90);
            this.lbl_klaargemeld.Name = "lbl_klaargemeld";
            this.lbl_klaargemeld.Size = new System.Drawing.Size(144, 25);
            this.lbl_klaargemeld.TabIndex = 0;
            this.lbl_klaargemeld.Text = "Klaar gemeld:";
            // 
            // lbl_rekening
            // 
            this.lbl_rekening.AutoSize = true;
            this.lbl_rekening.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rekening.Location = new System.Drawing.Point(290, 90);
            this.lbl_rekening.Name = "lbl_rekening";
            this.lbl_rekening.Size = new System.Drawing.Size(109, 25);
            this.lbl_rekening.TabIndex = 1;
            this.lbl_rekening.Text = "Rekening:";
            // 
            // lstbox_eindrekening
            // 
            this.lstbox_eindrekening.FormattingEnabled = true;
            this.lstbox_eindrekening.Location = new System.Drawing.Point(253, 137);
            this.lstbox_eindrekening.Name = "lstbox_eindrekening";
            this.lstbox_eindrekening.Size = new System.Drawing.Size(357, 251);
            this.lstbox_eindrekening.TabIndex = 2;
            // 
            // lbl_klaargemeldetafel
            // 
            this.lbl_klaargemeldetafel.AutoSize = true;
            this.lbl_klaargemeldetafel.Location = new System.Drawing.Point(53, 137);
            this.lbl_klaargemeldetafel.Name = "lbl_klaargemeldetafel";
            this.lbl_klaargemeldetafel.Size = new System.Drawing.Size(60, 13);
            this.lbl_klaargemeldetafel.TabIndex = 3;
            this.lbl_klaargemeldetafel.Text = "Tafel hier...";
            // 
            // lbl_opmerkingen
            // 
            this.lbl_opmerkingen.AutoSize = true;
            this.lbl_opmerkingen.Location = new System.Drawing.Point(251, 414);
            this.lbl_opmerkingen.Name = "lbl_opmerkingen";
            this.lbl_opmerkingen.Size = new System.Drawing.Size(73, 13);
            this.lbl_opmerkingen.TabIndex = 4;
            this.lbl_opmerkingen.Text = "Opmerkingen:";
            // 
            // lbl_subtotaal
            // 
            this.lbl_subtotaal.AutoSize = true;
            this.lbl_subtotaal.Location = new System.Drawing.Point(251, 445);
            this.lbl_subtotaal.Name = "lbl_subtotaal";
            this.lbl_subtotaal.Size = new System.Drawing.Size(55, 13);
            this.lbl_subtotaal.TabIndex = 5;
            this.lbl_subtotaal.Text = "Subtotaal:";
            // 
            // lbl_fooilabel
            // 
            this.lbl_fooilabel.AutoSize = true;
            this.lbl_fooilabel.Location = new System.Drawing.Point(251, 464);
            this.lbl_fooilabel.Name = "lbl_fooilabel";
            this.lbl_fooilabel.Size = new System.Drawing.Size(27, 13);
            this.lbl_fooilabel.TabIndex = 6;
            this.lbl_fooilabel.Text = "Fooi";
            // 
            // lbl_incbtw
            // 
            this.lbl_incbtw.AutoSize = true;
            this.lbl_incbtw.Location = new System.Drawing.Point(292, 495);
            this.lbl_incbtw.Name = "lbl_incbtw";
            this.lbl_incbtw.Size = new System.Drawing.Size(56, 13);
            this.lbl_incbtw.TabIndex = 7;
            this.lbl_incbtw.Text = "Inc. BTW:";
            // 
            // lbl_btwhoog
            // 
            this.lbl_btwhoog.AutoSize = true;
            this.lbl_btwhoog.Location = new System.Drawing.Point(251, 514);
            this.lbl_btwhoog.Name = "lbl_btwhoog";
            this.lbl_btwhoog.Size = new System.Drawing.Size(64, 13);
            this.lbl_btwhoog.TabIndex = 8;
            this.lbl_btwhoog.Text = "BTW Hoog:";
            // 
            // lbl_btwlaag
            // 
            this.lbl_btwlaag.AutoSize = true;
            this.lbl_btwlaag.Location = new System.Drawing.Point(251, 545);
            this.lbl_btwlaag.Name = "lbl_btwlaag";
            this.lbl_btwlaag.Size = new System.Drawing.Size(62, 13);
            this.lbl_btwlaag.TabIndex = 9;
            this.lbl_btwlaag.Text = "BTW Laag:";
            // 
            // lbl_subtotaalgetal
            // 
            this.lbl_subtotaalgetal.AutoSize = true;
            this.lbl_subtotaalgetal.Location = new System.Drawing.Point(505, 445);
            this.lbl_subtotaalgetal.Name = "lbl_subtotaalgetal";
            this.lbl_subtotaalgetal.Size = new System.Drawing.Size(25, 13);
            this.lbl_subtotaalgetal.TabIndex = 10;
            this.lbl_subtotaalgetal.Text = "000";
            // 
            // lbl_fooigetal
            // 
            this.lbl_fooigetal.AutoSize = true;
            this.lbl_fooigetal.Location = new System.Drawing.Point(505, 464);
            this.lbl_fooigetal.Name = "lbl_fooigetal";
            this.lbl_fooigetal.Size = new System.Drawing.Size(25, 13);
            this.lbl_fooigetal.TabIndex = 11;
            this.lbl_fooigetal.Text = "000";
            // 
            // lbl_incbtwgetal
            // 
            this.lbl_incbtwgetal.AutoSize = true;
            this.lbl_incbtwgetal.Location = new System.Drawing.Point(505, 495);
            this.lbl_incbtwgetal.Name = "lbl_incbtwgetal";
            this.lbl_incbtwgetal.Size = new System.Drawing.Size(25, 13);
            this.lbl_incbtwgetal.TabIndex = 12;
            this.lbl_incbtwgetal.Text = "000";
            // 
            // lbl_btwhooggetal
            // 
            this.lbl_btwhooggetal.AutoSize = true;
            this.lbl_btwhooggetal.Location = new System.Drawing.Point(505, 514);
            this.lbl_btwhooggetal.Name = "lbl_btwhooggetal";
            this.lbl_btwhooggetal.Size = new System.Drawing.Size(25, 13);
            this.lbl_btwhooggetal.TabIndex = 13;
            this.lbl_btwhooggetal.Text = "000";
            // 
            // lbl_btwlaaggetal
            // 
            this.lbl_btwlaaggetal.AutoSize = true;
            this.lbl_btwlaaggetal.Location = new System.Drawing.Point(505, 545);
            this.lbl_btwlaaggetal.Name = "lbl_btwlaaggetal";
            this.lbl_btwlaaggetal.Size = new System.Drawing.Size(25, 13);
            this.lbl_btwlaaggetal.TabIndex = 14;
            this.lbl_btwlaaggetal.Text = "000";
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.ForeColor = System.Drawing.Color.White;
            this.btn_plus.Location = new System.Drawing.Point(552, 414);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(58, 44);
            this.btn_plus.TabIndex = 15;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.Red;
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.ForeColor = System.Drawing.Color.Transparent;
            this.btn_min.Location = new System.Drawing.Point(552, 464);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(58, 44);
            this.btn_min.TabIndex = 16;
            this.btn_min.Text = "-";
            this.btn_min.UseVisualStyleBackColor = false;
            // 
            // btn_cbutton
            // 
            this.btn_cbutton.BackColor = System.Drawing.Color.Maroon;
            this.btn_cbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cbutton.ForeColor = System.Drawing.Color.White;
            this.btn_cbutton.Location = new System.Drawing.Point(553, 514);
            this.btn_cbutton.Name = "btn_cbutton";
            this.btn_cbutton.Size = new System.Drawing.Size(58, 44);
            this.btn_cbutton.TabIndex = 17;
            this.btn_cbutton.Text = "C";
            this.btn_cbutton.UseVisualStyleBackColor = false;
            // 
            // btn_pinbetalen
            // 
            this.btn_pinbetalen.BackColor = System.Drawing.Color.Maroon;
            this.btn_pinbetalen.ForeColor = System.Drawing.Color.White;
            this.btn_pinbetalen.Location = new System.Drawing.Point(7, 414);
            this.btn_pinbetalen.Name = "btn_pinbetalen";
            this.btn_pinbetalen.Size = new System.Drawing.Size(238, 43);
            this.btn_pinbetalen.TabIndex = 18;
            this.btn_pinbetalen.Text = "Pin";
            this.btn_pinbetalen.UseVisualStyleBackColor = false;
            // 
            // btn_creditcardbetalen
            // 
            this.btn_creditcardbetalen.BackColor = System.Drawing.Color.Maroon;
            this.btn_creditcardbetalen.ForeColor = System.Drawing.Color.White;
            this.btn_creditcardbetalen.Location = new System.Drawing.Point(7, 468);
            this.btn_creditcardbetalen.Name = "btn_creditcardbetalen";
            this.btn_creditcardbetalen.Size = new System.Drawing.Size(238, 43);
            this.btn_creditcardbetalen.TabIndex = 19;
            this.btn_creditcardbetalen.Text = "Creditcard (VISA/AMEX)";
            this.btn_creditcardbetalen.UseVisualStyleBackColor = false;
            // 
            // btn_contantbetalen
            // 
            this.btn_contantbetalen.BackColor = System.Drawing.Color.Maroon;
            this.btn_contantbetalen.ForeColor = System.Drawing.Color.White;
            this.btn_contantbetalen.Location = new System.Drawing.Point(7, 518);
            this.btn_contantbetalen.Name = "btn_contantbetalen";
            this.btn_contantbetalen.Size = new System.Drawing.Size(238, 43);
            this.btn_contantbetalen.TabIndex = 20;
            this.btn_contantbetalen.Text = "Contant";
            this.btn_contantbetalen.UseVisualStyleBackColor = false;
            // 
            // BTN_AFREKENENnaarTAFELOVERZICHT
            // 
            this.BTN_AFREKENENnaarTAFELOVERZICHT.Location = new System.Drawing.Point(12, 18);
            this.BTN_AFREKENENnaarTAFELOVERZICHT.Name = "BTN_AFREKENENnaarTAFELOVERZICHT";
            this.BTN_AFREKENENnaarTAFELOVERZICHT.Size = new System.Drawing.Size(101, 36);
            this.BTN_AFREKENENnaarTAFELOVERZICHT.TabIndex = 21;
            this.BTN_AFREKENENnaarTAFELOVERZICHT.Text = "Terug naar Tafeloverzicht";
            this.BTN_AFREKENENnaarTAFELOVERZICHT.UseVisualStyleBackColor = true;
            this.BTN_AFREKENENnaarTAFELOVERZICHT.Click += new System.EventHandler(this.BTN_AFREKENENnaarTAFELOVERZICHT_Click);
            // 
            // btn_printrekening
            // 
            this.btn_printrekening.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_printrekening.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_printrekening.Location = new System.Drawing.Point(7, 345);
            this.btn_printrekening.Name = "btn_printrekening";
            this.btn_printrekening.Size = new System.Drawing.Size(238, 43);
            this.btn_printrekening.TabIndex = 22;
            this.btn_printrekening.Text = "Print Rekening";
            this.btn_printrekening.UseVisualStyleBackColor = false;
            // 
            // Afrekenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 585);
            this.Controls.Add(this.btn_printrekening);
            this.Controls.Add(this.BTN_AFREKENENnaarTAFELOVERZICHT);
            this.Controls.Add(this.btn_contantbetalen);
            this.Controls.Add(this.btn_creditcardbetalen);
            this.Controls.Add(this.btn_pinbetalen);
            this.Controls.Add(this.btn_cbutton);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.lbl_btwlaaggetal);
            this.Controls.Add(this.lbl_btwhooggetal);
            this.Controls.Add(this.lbl_incbtwgetal);
            this.Controls.Add(this.lbl_fooigetal);
            this.Controls.Add(this.lbl_subtotaalgetal);
            this.Controls.Add(this.lbl_btwlaag);
            this.Controls.Add(this.lbl_btwhoog);
            this.Controls.Add(this.lbl_incbtw);
            this.Controls.Add(this.lbl_fooilabel);
            this.Controls.Add(this.lbl_subtotaal);
            this.Controls.Add(this.lbl_opmerkingen);
            this.Controls.Add(this.lbl_klaargemeldetafel);
            this.Controls.Add(this.lstbox_eindrekening);
            this.Controls.Add(this.lbl_rekening);
            this.Controls.Add(this.lbl_klaargemeld);
            this.Name = "Afrekenen";
            this.Text = "Afrekenen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_klaargemeld;
        private System.Windows.Forms.Label lbl_rekening;
        private System.Windows.Forms.ListBox lstbox_eindrekening;
        private System.Windows.Forms.Label lbl_klaargemeldetafel;
        private System.Windows.Forms.Label lbl_opmerkingen;
        private System.Windows.Forms.Label lbl_subtotaal;
        private System.Windows.Forms.Label lbl_fooilabel;
        private System.Windows.Forms.Label lbl_incbtw;
        private System.Windows.Forms.Label lbl_btwhoog;
        private System.Windows.Forms.Label lbl_btwlaag;
        private System.Windows.Forms.Label lbl_subtotaalgetal;
        private System.Windows.Forms.Label lbl_fooigetal;
        private System.Windows.Forms.Label lbl_incbtwgetal;
        private System.Windows.Forms.Label lbl_btwhooggetal;
        private System.Windows.Forms.Label lbl_btwlaaggetal;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_cbutton;
        private System.Windows.Forms.Button btn_pinbetalen;
        private System.Windows.Forms.Button btn_creditcardbetalen;
        private System.Windows.Forms.Button btn_contantbetalen;
        private System.Windows.Forms.Button BTN_AFREKENENnaarTAFELOVERZICHT;
        private System.Windows.Forms.Button btn_printrekening;

    }
}