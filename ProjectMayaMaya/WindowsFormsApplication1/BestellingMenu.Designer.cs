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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_opmerking = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bbox_volrekening = new System.Windows.Forms.GroupBox();
            this.btn_KlaarBestelling = new System.Windows.Forms.Button();
            this.btn_stuurbestelling = new System.Windows.Forms.Button();
            this.btn_printbestelling = new System.Windows.Forms.Button();
            this.btn_clearbestelling = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "DRANKEN";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
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
            this.bbox_volrekening.Location = new System.Drawing.Point(362, 191);
            this.bbox_volrekening.Name = "bbox_volrekening";
            this.bbox_volrekening.Size = new System.Drawing.Size(250, 132);
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
            // BestellingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 418);
            this.Controls.Add(this.btn_clearbestelling);
            this.Controls.Add(this.btn_printbestelling);
            this.Controls.Add(this.btn_stuurbestelling);
            this.Controls.Add(this.btn_KlaarBestelling);
            this.Controls.Add(this.bbox_volrekening);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_opmerking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_opmerking;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox bbox_volrekening;
        private System.Windows.Forms.Button btn_KlaarBestelling;
        private System.Windows.Forms.Button btn_stuurbestelling;
        private System.Windows.Forms.Button btn_printbestelling;
        private System.Windows.Forms.Button btn_clearbestelling;

    }
}