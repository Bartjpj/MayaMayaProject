namespace WindowsFormsApplication1
{
    partial class BestellingMenu
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
            this.lbl_selecteerkaart = new System.Windows.Forms.Label();
            this.btn_BestellingMENUnaarTAFELOVERZICHT = new System.Windows.Forms.Button();
            this.btn_Lunchkaart = new System.Windows.Forms.Button();
            this.btn_dinerkaart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_opmerking = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bbox_volrekening = new System.Windows.Forms.GroupBox();
            this.btn_KlaarBestelling = new System.Windows.Forms.Button();
            this.btn_stuurbestelling = new System.Windows.Forms.Button();
            this.btn_printbestelling = new System.Windows.Forms.Button();
            this.btn_clearbestelling = new System.Windows.Forms.Button();
            this.lbl_subtot = new System.Windows.Forms.Label();
            this.lbl_subtotaalwaarde = new System.Windows.Forms.Label();
            this.lbl_fooi = new System.Windows.Forms.Label();
            this.txtbox_fooi = new System.Windows.Forms.TextBox();
            this.lbl_incbtw = new System.Windows.Forms.Label();
            this.lbl_incbtwwaarde = new System.Windows.Forms.Label();
            this.lbl_btwhoog = new System.Windows.Forms.Label();
            this.lbl_btwlaag = new System.Windows.Forms.Label();
            this.lbl_btwhoogwaarde = new System.Windows.Forms.Label();
            this.lbl_btwlaagwaarde = new System.Windows.Forms.Label();
            this.btn_drankmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_selecteerkaart
            // 
            this.lbl_selecteerkaart.AutoSize = true;
            this.lbl_selecteerkaart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selecteerkaart.Location = new System.Drawing.Point(92, 78);
            this.lbl_selecteerkaart.Name = "lbl_selecteerkaart";
            this.lbl_selecteerkaart.Size = new System.Drawing.Size(162, 25);
            this.lbl_selecteerkaart.TabIndex = 1;
            this.lbl_selecteerkaart.Text = "Kies een Menu ";
            // 
            // btn_BestellingMENUnaarTAFELOVERZICHT
            // 
            this.btn_BestellingMENUnaarTAFELOVERZICHT.BackColor = System.Drawing.Color.Transparent;
            this.btn_BestellingMENUnaarTAFELOVERZICHT.ForeColor = System.Drawing.Color.Black;
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Location = new System.Drawing.Point(12, 12);
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Name = "btn_BestellingMENUnaarTAFELOVERZICHT";
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Size = new System.Drawing.Size(134, 40);
            this.btn_BestellingMENUnaarTAFELOVERZICHT.TabIndex = 3;
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Text = "Terug naar TafelOverzicht";
            this.btn_BestellingMENUnaarTAFELOVERZICHT.UseVisualStyleBackColor = false;
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Click += new System.EventHandler(this.btn_BestellingMENUnaarTAFELOVERZICHT_Click);
            // 
            // btn_Lunchkaart
            // 
            this.btn_Lunchkaart.BackColor = System.Drawing.Color.Maroon;
            this.btn_Lunchkaart.ForeColor = System.Drawing.Color.White;
            this.btn_Lunchkaart.Location = new System.Drawing.Point(12, 123);
            this.btn_Lunchkaart.Name = "btn_Lunchkaart";
            this.btn_Lunchkaart.Size = new System.Drawing.Size(321, 62);
            this.btn_Lunchkaart.TabIndex = 4;
            this.btn_Lunchkaart.Text = "LUNCH";
            this.btn_Lunchkaart.UseVisualStyleBackColor = false;
            this.btn_Lunchkaart.Click += new System.EventHandler(this.btn_Lunchkaart_Click);
            // 
            // btn_dinerkaart
            // 
            this.btn_dinerkaart.BackColor = System.Drawing.Color.Maroon;
            this.btn_dinerkaart.ForeColor = System.Drawing.Color.White;
            this.btn_dinerkaart.Location = new System.Drawing.Point(12, 191);
            this.btn_dinerkaart.Name = "btn_dinerkaart";
            this.btn_dinerkaart.Size = new System.Drawing.Size(321, 63);
            this.btn_dinerkaart.TabIndex = 5;
            this.btn_dinerkaart.Text = "DINER";
            this.btn_dinerkaart.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rekening";
            // 
            // lbl_opmerking
            // 
            this.lbl_opmerking.AutoSize = true;
            this.lbl_opmerking.Location = new System.Drawing.Point(359, 120);
            this.lbl_opmerking.Name = "lbl_opmerking";
            this.lbl_opmerking.Size = new System.Drawing.Size(61, 13);
            this.lbl_opmerking.TabIndex = 8;
            this.lbl_opmerking.Text = "Opmerking:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(426, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 9;
            // 
            // bbox_volrekening
            // 
            this.bbox_volrekening.Location = new System.Drawing.Point(362, 143);
            this.bbox_volrekening.Name = "bbox_volrekening";
            this.bbox_volrekening.Size = new System.Drawing.Size(250, 63);
            this.bbox_volrekening.TabIndex = 10;
            this.bbox_volrekening.TabStop = false;
            this.bbox_volrekening.Text = "Volledige Rekening";
            // 
            // btn_KlaarBestelling
            // 
            this.btn_KlaarBestelling.Location = new System.Drawing.Point(362, 363);
            this.btn_KlaarBestelling.Name = "btn_KlaarBestelling";
            this.btn_KlaarBestelling.Size = new System.Drawing.Size(58, 36);
            this.btn_KlaarBestelling.TabIndex = 11;
            this.btn_KlaarBestelling.Text = "Klaar";
            this.btn_KlaarBestelling.UseVisualStyleBackColor = true;
            // 
            // btn_stuurbestelling
            // 
            this.btn_stuurbestelling.Location = new System.Drawing.Point(426, 363);
            this.btn_stuurbestelling.Name = "btn_stuurbestelling";
            this.btn_stuurbestelling.Size = new System.Drawing.Size(58, 36);
            this.btn_stuurbestelling.TabIndex = 12;
            this.btn_stuurbestelling.Text = "Stuur";
            this.btn_stuurbestelling.UseVisualStyleBackColor = true;
            this.btn_stuurbestelling.Click += new System.EventHandler(this.btn_stuurbestelling_Click);
            // 
            // btn_printbestelling
            // 
            this.btn_printbestelling.Location = new System.Drawing.Point(490, 363);
            this.btn_printbestelling.Name = "btn_printbestelling";
            this.btn_printbestelling.Size = new System.Drawing.Size(58, 36);
            this.btn_printbestelling.TabIndex = 13;
            this.btn_printbestelling.Text = "Print";
            this.btn_printbestelling.UseVisualStyleBackColor = true;
            // 
            // btn_clearbestelling
            // 
            this.btn_clearbestelling.Location = new System.Drawing.Point(554, 363);
            this.btn_clearbestelling.Name = "btn_clearbestelling";
            this.btn_clearbestelling.Size = new System.Drawing.Size(58, 36);
            this.btn_clearbestelling.TabIndex = 14;
            this.btn_clearbestelling.Text = "C";
            this.btn_clearbestelling.UseVisualStyleBackColor = true;
            // 
            // lbl_subtot
            // 
            this.lbl_subtot.AutoSize = true;
            this.lbl_subtot.Location = new System.Drawing.Point(366, 230);
            this.lbl_subtot.Name = "lbl_subtot";
            this.lbl_subtot.Size = new System.Drawing.Size(55, 13);
            this.lbl_subtot.TabIndex = 15;
            this.lbl_subtot.Text = "Subtotaal:";
            // 
            // lbl_subtotaalwaarde
            // 
            this.lbl_subtotaalwaarde.AutoSize = true;
            this.lbl_subtotaalwaarde.Location = new System.Drawing.Point(517, 230);
            this.lbl_subtotaalwaarde.Name = "lbl_subtotaalwaarde";
            this.lbl_subtotaalwaarde.Size = new System.Drawing.Size(13, 13);
            this.lbl_subtotaalwaarde.TabIndex = 16;
            this.lbl_subtotaalwaarde.Text = "0";
            // 
            // lbl_fooi
            // 
            this.lbl_fooi.AutoSize = true;
            this.lbl_fooi.Location = new System.Drawing.Point(366, 249);
            this.lbl_fooi.Name = "lbl_fooi";
            this.lbl_fooi.Size = new System.Drawing.Size(30, 13);
            this.lbl_fooi.TabIndex = 17;
            this.lbl_fooi.Text = "Fooi:";
            // 
            // txtbox_fooi
            // 
            this.txtbox_fooi.Location = new System.Drawing.Point(490, 246);
            this.txtbox_fooi.Name = "txtbox_fooi";
            this.txtbox_fooi.Size = new System.Drawing.Size(58, 20);
            this.txtbox_fooi.TabIndex = 18;
            this.txtbox_fooi.TextChanged += new System.EventHandler(this.txtbox_fooi_TextChanged);
            // 
            // lbl_incbtw
            // 
            this.lbl_incbtw.AutoSize = true;
            this.lbl_incbtw.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_incbtw.Location = new System.Drawing.Point(366, 274);
            this.lbl_incbtw.Name = "lbl_incbtw";
            this.lbl_incbtw.Size = new System.Drawing.Size(56, 13);
            this.lbl_incbtw.TabIndex = 19;
            this.lbl_incbtw.Text = "Inc. BTW:";
            // 
            // lbl_incbtwwaarde
            // 
            this.lbl_incbtwwaarde.AutoSize = true;
            this.lbl_incbtwwaarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_incbtwwaarde.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_incbtwwaarde.Location = new System.Drawing.Point(512, 269);
            this.lbl_incbtwwaarde.Name = "lbl_incbtwwaarde";
            this.lbl_incbtwwaarde.Size = new System.Drawing.Size(18, 20);
            this.lbl_incbtwwaarde.TabIndex = 20;
            this.lbl_incbtwwaarde.Text = "0";
            // 
            // lbl_btwhoog
            // 
            this.lbl_btwhoog.AutoSize = true;
            this.lbl_btwhoog.Location = new System.Drawing.Point(366, 297);
            this.lbl_btwhoog.Name = "lbl_btwhoog";
            this.lbl_btwhoog.Size = new System.Drawing.Size(64, 13);
            this.lbl_btwhoog.TabIndex = 21;
            this.lbl_btwhoog.Text = "BTW Hoog:";
            // 
            // lbl_btwlaag
            // 
            this.lbl_btwlaag.AutoSize = true;
            this.lbl_btwlaag.Location = new System.Drawing.Point(366, 321);
            this.lbl_btwlaag.Name = "lbl_btwlaag";
            this.lbl_btwlaag.Size = new System.Drawing.Size(62, 13);
            this.lbl_btwlaag.TabIndex = 22;
            this.lbl_btwlaag.Text = "BTW Laag:";
            // 
            // lbl_btwhoogwaarde
            // 
            this.lbl_btwhoogwaarde.AutoSize = true;
            this.lbl_btwhoogwaarde.Location = new System.Drawing.Point(517, 297);
            this.lbl_btwhoogwaarde.Name = "lbl_btwhoogwaarde";
            this.lbl_btwhoogwaarde.Size = new System.Drawing.Size(13, 13);
            this.lbl_btwhoogwaarde.TabIndex = 23;
            this.lbl_btwhoogwaarde.Text = "0";
            // 
            // lbl_btwlaagwaarde
            // 
            this.lbl_btwlaagwaarde.AutoSize = true;
            this.lbl_btwlaagwaarde.Location = new System.Drawing.Point(517, 321);
            this.lbl_btwlaagwaarde.Name = "lbl_btwlaagwaarde";
            this.lbl_btwlaagwaarde.Size = new System.Drawing.Size(13, 13);
            this.lbl_btwlaagwaarde.TabIndex = 24;
            this.lbl_btwlaagwaarde.Text = "0";
            // 
            // btn_drankmenu
            // 
            this.btn_drankmenu.BackColor = System.Drawing.Color.Maroon;
            this.btn_drankmenu.ForeColor = System.Drawing.Color.White;
            this.btn_drankmenu.Location = new System.Drawing.Point(12, 260);
            this.btn_drankmenu.Name = "btn_drankmenu";
            this.btn_drankmenu.Size = new System.Drawing.Size(321, 63);
            this.btn_drankmenu.TabIndex = 25;
            this.btn_drankmenu.Text = "DRANKEN";
            this.btn_drankmenu.UseVisualStyleBackColor = false;
            this.btn_drankmenu.Click += new System.EventHandler(this.btn_drankmenu_Click);
            // 
            // BestellingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 418);
            this.Controls.Add(this.btn_drankmenu);
            this.Controls.Add(this.lbl_btwlaagwaarde);
            this.Controls.Add(this.lbl_btwhoogwaarde);
            this.Controls.Add(this.lbl_btwlaag);
            this.Controls.Add(this.lbl_btwhoog);
            this.Controls.Add(this.lbl_incbtwwaarde);
            this.Controls.Add(this.lbl_incbtw);
            this.Controls.Add(this.txtbox_fooi);
            this.Controls.Add(this.lbl_fooi);
            this.Controls.Add(this.lbl_subtotaalwaarde);
            this.Controls.Add(this.lbl_subtot);
            this.Controls.Add(this.btn_clearbestelling);
            this.Controls.Add(this.btn_printbestelling);
            this.Controls.Add(this.btn_stuurbestelling);
            this.Controls.Add(this.btn_KlaarBestelling);
            this.Controls.Add(this.bbox_volrekening);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_opmerking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dinerkaart);
            this.Controls.Add(this.btn_Lunchkaart);
            this.Controls.Add(this.btn_BestellingMENUnaarTAFELOVERZICHT);
            this.Controls.Add(this.lbl_selecteerkaart);
            this.Name = "BestellingMenu";
            this.Text = "BestellingMenu";
            this.Load += new System.EventHandler(this.BestellingMenu_Load);
            this.Click += new System.EventHandler(this.cbox_selecteerkaart_SelectedIndexChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_selecteerkaart;
        private System.Windows.Forms.Button btn_BestellingMENUnaarTAFELOVERZICHT;
        private System.Windows.Forms.Button btn_Lunchkaart;
        private System.Windows.Forms.Button btn_dinerkaart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_opmerking;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox bbox_volrekening;
        private System.Windows.Forms.Button btn_KlaarBestelling;
        private System.Windows.Forms.Button btn_stuurbestelling;
        private System.Windows.Forms.Button btn_printbestelling;
        private System.Windows.Forms.Button btn_clearbestelling;
        private System.Windows.Forms.Label lbl_subtot;
        private System.Windows.Forms.Label lbl_subtotaalwaarde;
        private System.Windows.Forms.Label lbl_fooi;
        private System.Windows.Forms.TextBox txtbox_fooi;
        private System.Windows.Forms.Label lbl_incbtw;
        private System.Windows.Forms.Label lbl_incbtwwaarde;
        private System.Windows.Forms.Label lbl_btwhoog;
        private System.Windows.Forms.Label lbl_btwlaag;
        private System.Windows.Forms.Label lbl_btwhoogwaarde;
        private System.Windows.Forms.Label lbl_btwlaagwaarde;
        private System.Windows.Forms.Button btn_drankmenu;

    }
}