namespace WindowsFormsApplication1
{
    partial class DinerKaart
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
            this.lbl_btwlaagwaarde = new System.Windows.Forms.Label();
            this.lbl_btwhoogwaarde = new System.Windows.Forms.Label();
            this.lbl_btwlaag = new System.Windows.Forms.Label();
            this.lbl_btwhoog = new System.Windows.Forms.Label();
            this.lbl_incbtwwaarde = new System.Windows.Forms.Label();
            this.lbl_incbtw = new System.Windows.Forms.Label();
            this.txtbox_fooi = new System.Windows.Forms.TextBox();
            this.lbl_fooi = new System.Windows.Forms.Label();
            this.lbl_subtotaalwaarde = new System.Windows.Forms.Label();
            this.lbl_subtot = new System.Windows.Forms.Label();
            this.btn_clearbestelling = new System.Windows.Forms.Button();
            this.btn_printbestelling = new System.Windows.Forms.Button();
            this.btn_stuurbestelling = new System.Windows.Forms.Button();
            this.btn_KlaarBestelling = new System.Windows.Forms.Button();
            this.bbox_volrekeninglunch = new System.Windows.Forms.GroupBox();
            this.txtbox_OpmwerkingLunch = new System.Windows.Forms.TextBox();
            this.lbl_opmerkinglunch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LUNCHnaarDRANKEN = new System.Windows.Forms.Button();
            this.btn_addg_id9 = new System.Windows.Forms.Button();
            this.btn_addg_id8 = new System.Windows.Forms.Button();
            this.btn_addg_id7 = new System.Windows.Forms.Button();
            this.lbl_nagerechten = new System.Windows.Forms.Label();
            this.btn_addg_id6 = new System.Windows.Forms.Button();
            this.btn_addg_id16 = new System.Windows.Forms.Button();
            this.btn_addg_id4 = new System.Windows.Forms.Button();
            this.lbl_Hoofdgerechten = new System.Windows.Forms.Label();
            this.btn_addg_id13 = new System.Windows.Forms.Button();
            this.btn_addg_id12 = new System.Windows.Forms.Button();
            this.btn_addg_id11 = new System.Windows.Forms.Button();
            this.lbl_Voorgerechten = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addg_id14 = new System.Windows.Forms.Button();
            this.btn_addg_id15 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_btwlaagwaarde
            // 
            this.lbl_btwlaagwaarde.AutoSize = true;
            this.lbl_btwlaagwaarde.Location = new System.Drawing.Point(510, 300);
            this.lbl_btwlaagwaarde.Name = "lbl_btwlaagwaarde";
            this.lbl_btwlaagwaarde.Size = new System.Drawing.Size(13, 13);
            this.lbl_btwlaagwaarde.TabIndex = 74;
            this.lbl_btwlaagwaarde.Text = "0";
            // 
            // lbl_btwhoogwaarde
            // 
            this.lbl_btwhoogwaarde.AutoSize = true;
            this.lbl_btwhoogwaarde.Location = new System.Drawing.Point(510, 271);
            this.lbl_btwhoogwaarde.Name = "lbl_btwhoogwaarde";
            this.lbl_btwhoogwaarde.Size = new System.Drawing.Size(13, 13);
            this.lbl_btwhoogwaarde.TabIndex = 73;
            this.lbl_btwhoogwaarde.Text = "0";
            // 
            // lbl_btwlaag
            // 
            this.lbl_btwlaag.AutoSize = true;
            this.lbl_btwlaag.Location = new System.Drawing.Point(359, 300);
            this.lbl_btwlaag.Name = "lbl_btwlaag";
            this.lbl_btwlaag.Size = new System.Drawing.Size(62, 13);
            this.lbl_btwlaag.TabIndex = 72;
            this.lbl_btwlaag.Text = "BTW Laag:";
            // 
            // lbl_btwhoog
            // 
            this.lbl_btwhoog.AutoSize = true;
            this.lbl_btwhoog.Location = new System.Drawing.Point(359, 271);
            this.lbl_btwhoog.Name = "lbl_btwhoog";
            this.lbl_btwhoog.Size = new System.Drawing.Size(64, 13);
            this.lbl_btwhoog.TabIndex = 71;
            this.lbl_btwhoog.Text = "BTW Hoog:";
            // 
            // lbl_incbtwwaarde
            // 
            this.lbl_incbtwwaarde.AutoSize = true;
            this.lbl_incbtwwaarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_incbtwwaarde.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_incbtwwaarde.Location = new System.Drawing.Point(505, 243);
            this.lbl_incbtwwaarde.Name = "lbl_incbtwwaarde";
            this.lbl_incbtwwaarde.Size = new System.Drawing.Size(18, 20);
            this.lbl_incbtwwaarde.TabIndex = 70;
            this.lbl_incbtwwaarde.Text = "0";
            // 
            // lbl_incbtw
            // 
            this.lbl_incbtw.AutoSize = true;
            this.lbl_incbtw.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_incbtw.Location = new System.Drawing.Point(359, 248);
            this.lbl_incbtw.Name = "lbl_incbtw";
            this.lbl_incbtw.Size = new System.Drawing.Size(56, 13);
            this.lbl_incbtw.TabIndex = 69;
            this.lbl_incbtw.Text = "Inc. BTW:";
            // 
            // txtbox_fooi
            // 
            this.txtbox_fooi.Location = new System.Drawing.Point(483, 220);
            this.txtbox_fooi.Name = "txtbox_fooi";
            this.txtbox_fooi.Size = new System.Drawing.Size(58, 20);
            this.txtbox_fooi.TabIndex = 68;
            // 
            // lbl_fooi
            // 
            this.lbl_fooi.AutoSize = true;
            this.lbl_fooi.Location = new System.Drawing.Point(359, 223);
            this.lbl_fooi.Name = "lbl_fooi";
            this.lbl_fooi.Size = new System.Drawing.Size(30, 13);
            this.lbl_fooi.TabIndex = 67;
            this.lbl_fooi.Text = "Fooi:";
            // 
            // lbl_subtotaalwaarde
            // 
            this.lbl_subtotaalwaarde.AutoSize = true;
            this.lbl_subtotaalwaarde.Location = new System.Drawing.Point(510, 204);
            this.lbl_subtotaalwaarde.Name = "lbl_subtotaalwaarde";
            this.lbl_subtotaalwaarde.Size = new System.Drawing.Size(13, 13);
            this.lbl_subtotaalwaarde.TabIndex = 66;
            this.lbl_subtotaalwaarde.Text = "0";
            // 
            // lbl_subtot
            // 
            this.lbl_subtot.AutoSize = true;
            this.lbl_subtot.Location = new System.Drawing.Point(359, 204);
            this.lbl_subtot.Name = "lbl_subtot";
            this.lbl_subtot.Size = new System.Drawing.Size(55, 13);
            this.lbl_subtot.TabIndex = 65;
            this.lbl_subtot.Text = "Subtotaal:";
            // 
            // btn_clearbestelling
            // 
            this.btn_clearbestelling.Location = new System.Drawing.Point(547, 337);
            this.btn_clearbestelling.Name = "btn_clearbestelling";
            this.btn_clearbestelling.Size = new System.Drawing.Size(58, 36);
            this.btn_clearbestelling.TabIndex = 64;
            this.btn_clearbestelling.Text = "C";
            this.btn_clearbestelling.UseVisualStyleBackColor = true;
            // 
            // btn_printbestelling
            // 
            this.btn_printbestelling.Location = new System.Drawing.Point(483, 337);
            this.btn_printbestelling.Name = "btn_printbestelling";
            this.btn_printbestelling.Size = new System.Drawing.Size(58, 36);
            this.btn_printbestelling.TabIndex = 63;
            this.btn_printbestelling.Text = "Print";
            this.btn_printbestelling.UseVisualStyleBackColor = true;
            // 
            // btn_stuurbestelling
            // 
            this.btn_stuurbestelling.Location = new System.Drawing.Point(419, 337);
            this.btn_stuurbestelling.Name = "btn_stuurbestelling";
            this.btn_stuurbestelling.Size = new System.Drawing.Size(58, 36);
            this.btn_stuurbestelling.TabIndex = 62;
            this.btn_stuurbestelling.Text = "Stuur";
            this.btn_stuurbestelling.UseVisualStyleBackColor = true;
            // 
            // btn_KlaarBestelling
            // 
            this.btn_KlaarBestelling.Location = new System.Drawing.Point(355, 337);
            this.btn_KlaarBestelling.Name = "btn_KlaarBestelling";
            this.btn_KlaarBestelling.Size = new System.Drawing.Size(58, 36);
            this.btn_KlaarBestelling.TabIndex = 61;
            this.btn_KlaarBestelling.Text = "Klaar";
            this.btn_KlaarBestelling.UseVisualStyleBackColor = true;
            // 
            // bbox_volrekeninglunch
            // 
            this.bbox_volrekeninglunch.Location = new System.Drawing.Point(355, 117);
            this.bbox_volrekeninglunch.Name = "bbox_volrekeninglunch";
            this.bbox_volrekeninglunch.Size = new System.Drawing.Size(250, 63);
            this.bbox_volrekeninglunch.TabIndex = 60;
            this.bbox_volrekeninglunch.TabStop = false;
            this.bbox_volrekeninglunch.Text = "Volledige Rekening";
            // 
            // txtbox_OpmwerkingLunch
            // 
            this.txtbox_OpmwerkingLunch.Location = new System.Drawing.Point(419, 91);
            this.txtbox_OpmwerkingLunch.Name = "txtbox_OpmwerkingLunch";
            this.txtbox_OpmwerkingLunch.Size = new System.Drawing.Size(158, 20);
            this.txtbox_OpmwerkingLunch.TabIndex = 59;
            // 
            // lbl_opmerkinglunch
            // 
            this.lbl_opmerkinglunch.AutoSize = true;
            this.lbl_opmerkinglunch.Location = new System.Drawing.Point(352, 94);
            this.lbl_opmerkinglunch.Name = "lbl_opmerkinglunch";
            this.lbl_opmerkinglunch.Size = new System.Drawing.Size(61, 13);
            this.lbl_opmerkinglunch.TabIndex = 58;
            this.lbl_opmerkinglunch.Text = "Opmerking:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "Rekening";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Diner";
            // 
            // btn_LUNCHnaarDRANKEN
            // 
            this.btn_LUNCHnaarDRANKEN.BackColor = System.Drawing.Color.Maroon;
            this.btn_LUNCHnaarDRANKEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LUNCHnaarDRANKEN.ForeColor = System.Drawing.Color.White;
            this.btn_LUNCHnaarDRANKEN.Location = new System.Drawing.Point(9, 96);
            this.btn_LUNCHnaarDRANKEN.Name = "btn_LUNCHnaarDRANKEN";
            this.btn_LUNCHnaarDRANKEN.Size = new System.Drawing.Size(300, 52);
            this.btn_LUNCHnaarDRANKEN.TabIndex = 55;
            this.btn_LUNCHnaarDRANKEN.Text = "Dranken";
            this.btn_LUNCHnaarDRANKEN.UseVisualStyleBackColor = false;
            // 
            // btn_addg_id9
            // 
            this.btn_addg_id9.Location = new System.Drawing.Point(213, 363);
            this.btn_addg_id9.Name = "btn_addg_id9";
            this.btn_addg_id9.Size = new System.Drawing.Size(96, 37);
            this.btn_addg_id9.TabIndex = 54;
            this.btn_addg_id9.Text = "3 soorten Boerenkaas";
            this.btn_addg_id9.UseVisualStyleBackColor = true;
            // 
            // btn_addg_id8
            // 
            this.btn_addg_id8.Location = new System.Drawing.Point(111, 363);
            this.btn_addg_id8.Name = "btn_addg_id8";
            this.btn_addg_id8.Size = new System.Drawing.Size(96, 37);
            this.btn_addg_id8.TabIndex = 53;
            this.btn_addg_id8.Text = "Verse Madeleines";
            this.btn_addg_id8.UseVisualStyleBackColor = true;
            // 
            // btn_addg_id7
            // 
            this.btn_addg_id7.Location = new System.Drawing.Point(9, 363);
            this.btn_addg_id7.Name = "btn_addg_id7";
            this.btn_addg_id7.Size = new System.Drawing.Size(96, 37);
            this.btn_addg_id7.TabIndex = 52;
            this.btn_addg_id7.Text = "Witte Chocolade Taart";
            this.btn_addg_id7.UseVisualStyleBackColor = true;
            // 
            // lbl_nagerechten
            // 
            this.lbl_nagerechten.AutoSize = true;
            this.lbl_nagerechten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nagerechten.Location = new System.Drawing.Point(10, 340);
            this.lbl_nagerechten.Name = "lbl_nagerechten";
            this.lbl_nagerechten.Size = new System.Drawing.Size(101, 20);
            this.lbl_nagerechten.TabIndex = 51;
            this.lbl_nagerechten.Text = "Nagerechten";
            // 
            // btn_addg_id6
            // 
            this.btn_addg_id6.Location = new System.Drawing.Point(213, 300);
            this.btn_addg_id6.Name = "btn_addg_id6";
            this.btn_addg_id6.Size = new System.Drawing.Size(96, 37);
            this.btn_addg_id6.TabIndex = 50;
            this.btn_addg_id6.Text = "Linguini";
            this.btn_addg_id6.UseVisualStyleBackColor = true;
            // 
            // btn_addg_id16
            // 
            this.btn_addg_id16.Location = new System.Drawing.Point(9, 300);
            this.btn_addg_id16.Name = "btn_addg_id16";
            this.btn_addg_id16.Size = new System.Drawing.Size(96, 37);
            this.btn_addg_id16.TabIndex = 49;
            this.btn_addg_id16.Text = "Kabbeljouw";
            this.btn_addg_id16.UseVisualStyleBackColor = true;
            // 
            // btn_addg_id4
            // 
            this.btn_addg_id4.Location = new System.Drawing.Point(111, 300);
            this.btn_addg_id4.Name = "btn_addg_id4";
            this.btn_addg_id4.Size = new System.Drawing.Size(96, 37);
            this.btn_addg_id4.TabIndex = 48;
            this.btn_addg_id4.Text = "Herten Stoofpot";
            this.btn_addg_id4.UseVisualStyleBackColor = true;
            // 
            // lbl_Hoofdgerechten
            // 
            this.lbl_Hoofdgerechten.AutoSize = true;
            this.lbl_Hoofdgerechten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hoofdgerechten.Location = new System.Drawing.Point(10, 277);
            this.lbl_Hoofdgerechten.Name = "lbl_Hoofdgerechten";
            this.lbl_Hoofdgerechten.Size = new System.Drawing.Size(125, 20);
            this.lbl_Hoofdgerechten.TabIndex = 47;
            this.lbl_Hoofdgerechten.Text = "Hoofdgerechten";
            // 
            // btn_addg_id13
            // 
            this.btn_addg_id13.Location = new System.Drawing.Point(213, 174);
            this.btn_addg_id13.Name = "btn_addg_id13";
            this.btn_addg_id13.Size = new System.Drawing.Size(96, 37);
            this.btn_addg_id13.TabIndex = 46;
            this.btn_addg_id13.Text = "Krab-zalm koekjes";
            this.btn_addg_id13.UseVisualStyleBackColor = true;
            // 
            // btn_addg_id12
            // 
            this.btn_addg_id12.Location = new System.Drawing.Point(111, 174);
            this.btn_addg_id12.Name = "btn_addg_id12";
            this.btn_addg_id12.Size = new System.Drawing.Size(96, 37);
            this.btn_addg_id12.TabIndex = 45;
            this.btn_addg_id12.Text = "Paté v. Fazant";
            this.btn_addg_id12.UseVisualStyleBackColor = true;
            // 
            // btn_addg_id11
            // 
            this.btn_addg_id11.Location = new System.Drawing.Point(9, 174);
            this.btn_addg_id11.Name = "btn_addg_id11";
            this.btn_addg_id11.Size = new System.Drawing.Size(96, 37);
            this.btn_addg_id11.TabIndex = 44;
            this.btn_addg_id11.Text = "Kalfs Tartaar";
            this.btn_addg_id11.UseVisualStyleBackColor = true;
            // 
            // lbl_Voorgerechten
            // 
            this.lbl_Voorgerechten.AutoSize = true;
            this.lbl_Voorgerechten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Voorgerechten.Location = new System.Drawing.Point(10, 151);
            this.lbl_Voorgerechten.Name = "lbl_Voorgerechten";
            this.lbl_Voorgerechten.Size = new System.Drawing.Size(115, 20);
            this.lbl_Voorgerechten.TabIndex = 43;
            this.lbl_Voorgerechten.Text = "Voorgerechten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Tussengerechten";
            // 
            // btn_addg_id14
            // 
            this.btn_addg_id14.Location = new System.Drawing.Point(9, 236);
            this.btn_addg_id14.Name = "btn_addg_id14";
            this.btn_addg_id14.Size = new System.Drawing.Size(96, 37);
            this.btn_addg_id14.TabIndex = 76;
            this.btn_addg_id14.Text = "Provinciale vissoep";
            this.btn_addg_id14.UseVisualStyleBackColor = true;
            // 
            // btn_addg_id15
            // 
            this.btn_addg_id15.Location = new System.Drawing.Point(111, 237);
            this.btn_addg_id15.Name = "btn_addg_id15";
            this.btn_addg_id15.Size = new System.Drawing.Size(96, 37);
            this.btn_addg_id15.TabIndex = 77;
            this.btn_addg_id15.Text = "Consommé";
            this.btn_addg_id15.UseVisualStyleBackColor = true;
            // 
            // DinerKaart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 446);
            this.Controls.Add(this.btn_addg_id15);
            this.Controls.Add(this.btn_addg_id14);
            this.Controls.Add(this.label3);
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
            this.Controls.Add(this.bbox_volrekeninglunch);
            this.Controls.Add(this.txtbox_OpmwerkingLunch);
            this.Controls.Add(this.lbl_opmerkinglunch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_LUNCHnaarDRANKEN);
            this.Controls.Add(this.btn_addg_id9);
            this.Controls.Add(this.btn_addg_id8);
            this.Controls.Add(this.btn_addg_id7);
            this.Controls.Add(this.lbl_nagerechten);
            this.Controls.Add(this.btn_addg_id6);
            this.Controls.Add(this.btn_addg_id16);
            this.Controls.Add(this.btn_addg_id4);
            this.Controls.Add(this.lbl_Hoofdgerechten);
            this.Controls.Add(this.btn_addg_id13);
            this.Controls.Add(this.btn_addg_id12);
            this.Controls.Add(this.btn_addg_id11);
            this.Controls.Add(this.lbl_Voorgerechten);
            this.Name = "DinerKaart";
            this.Text = "DinerKaart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_btwlaagwaarde;
        private System.Windows.Forms.Label lbl_btwhoogwaarde;
        private System.Windows.Forms.Label lbl_btwlaag;
        private System.Windows.Forms.Label lbl_btwhoog;
        private System.Windows.Forms.Label lbl_incbtwwaarde;
        private System.Windows.Forms.Label lbl_incbtw;
        private System.Windows.Forms.TextBox txtbox_fooi;
        private System.Windows.Forms.Label lbl_fooi;
        private System.Windows.Forms.Label lbl_subtotaalwaarde;
        private System.Windows.Forms.Label lbl_subtot;
        private System.Windows.Forms.Button btn_clearbestelling;
        private System.Windows.Forms.Button btn_printbestelling;
        private System.Windows.Forms.Button btn_stuurbestelling;
        private System.Windows.Forms.Button btn_KlaarBestelling;
        private System.Windows.Forms.GroupBox bbox_volrekeninglunch;
        private System.Windows.Forms.TextBox txtbox_OpmwerkingLunch;
        private System.Windows.Forms.Label lbl_opmerkinglunch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_LUNCHnaarDRANKEN;
        private System.Windows.Forms.Button btn_addg_id9;
        private System.Windows.Forms.Button btn_addg_id8;
        private System.Windows.Forms.Button btn_addg_id7;
        private System.Windows.Forms.Label lbl_nagerechten;
        private System.Windows.Forms.Button btn_addg_id6;
        private System.Windows.Forms.Button btn_addg_id16;
        private System.Windows.Forms.Button btn_addg_id4;
        private System.Windows.Forms.Label lbl_Hoofdgerechten;
        private System.Windows.Forms.Button btn_addg_id13;
        private System.Windows.Forms.Button btn_addg_id12;
        private System.Windows.Forms.Button btn_addg_id11;
        private System.Windows.Forms.Label lbl_Voorgerechten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addg_id14;
        private System.Windows.Forms.Button btn_addg_id15;
    }
}