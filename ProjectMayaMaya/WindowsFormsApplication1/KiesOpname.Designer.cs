namespace WindowsFormsApplication1
{
    partial class KiesOpname
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
            this.btn_BestellingOpnemen = new System.Windows.Forms.Button();
            this.btn_afrekenen = new System.Windows.Forms.Button();
            this.btn_KIESOPNnaarTAFELOVERZICHT = new System.Windows.Forms.Button();
            this.lbl_kieseenoptie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_BestellingOpnemen
            // 
            this.btn_BestellingOpnemen.BackColor = System.Drawing.Color.Maroon;
            this.btn_BestellingOpnemen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BestellingOpnemen.ForeColor = System.Drawing.Color.White;
            this.btn_BestellingOpnemen.Location = new System.Drawing.Point(69, 182);
            this.btn_BestellingOpnemen.Name = "btn_BestellingOpnemen";
            this.btn_BestellingOpnemen.Size = new System.Drawing.Size(629, 86);
            this.btn_BestellingOpnemen.TabIndex = 0;
            this.btn_BestellingOpnemen.Text = "Bestelling Opnemen";
            this.btn_BestellingOpnemen.UseVisualStyleBackColor = false;
            this.btn_BestellingOpnemen.Click += new System.EventHandler(this.btn_BestellingOpnemen_Click);
            // 
            // btn_afrekenen
            // 
            this.btn_afrekenen.BackColor = System.Drawing.Color.Maroon;
            this.btn_afrekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_afrekenen.ForeColor = System.Drawing.Color.White;
            this.btn_afrekenen.Location = new System.Drawing.Point(69, 274);
            this.btn_afrekenen.Name = "btn_afrekenen";
            this.btn_afrekenen.Size = new System.Drawing.Size(629, 86);
            this.btn_afrekenen.TabIndex = 1;
            this.btn_afrekenen.Text = "Afrekenen";
            this.btn_afrekenen.UseVisualStyleBackColor = false;
            this.btn_afrekenen.Click += new System.EventHandler(this.btn_afrekenen_Click);
            // 
            // btn_KIESOPNnaarTAFELOVERZICHT
            // 
            this.btn_KIESOPNnaarTAFELOVERZICHT.BackColor = System.Drawing.Color.Maroon;
            this.btn_KIESOPNnaarTAFELOVERZICHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KIESOPNnaarTAFELOVERZICHT.ForeColor = System.Drawing.Color.White;
            this.btn_KIESOPNnaarTAFELOVERZICHT.Location = new System.Drawing.Point(12, 12);
            this.btn_KIESOPNnaarTAFELOVERZICHT.Name = "btn_KIESOPNnaarTAFELOVERZICHT";
            this.btn_KIESOPNnaarTAFELOVERZICHT.Size = new System.Drawing.Size(111, 49);
            this.btn_KIESOPNnaarTAFELOVERZICHT.TabIndex = 2;
            this.btn_KIESOPNnaarTAFELOVERZICHT.Text = "Terug naar Tafeloverzicht";
            this.btn_KIESOPNnaarTAFELOVERZICHT.UseVisualStyleBackColor = false;
            this.btn_KIESOPNnaarTAFELOVERZICHT.Click += new System.EventHandler(this.btn_KIESOPNnaarTAFELOVERZICHT_Click);
            // 
            // lbl_kieseenoptie
            // 
            this.lbl_kieseenoptie.AutoSize = true;
            this.lbl_kieseenoptie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kieseenoptie.Location = new System.Drawing.Point(228, 132);
            this.lbl_kieseenoptie.Name = "lbl_kieseenoptie";
            this.lbl_kieseenoptie.Size = new System.Drawing.Size(297, 25);
            this.lbl_kieseenoptie.TabIndex = 3;
            this.lbl_kieseenoptie.Text = "Kies een optie voor deze tafel";
            // 
            // KiesOpname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 502);
            this.Controls.Add(this.lbl_kieseenoptie);
            this.Controls.Add(this.btn_KIESOPNnaarTAFELOVERZICHT);
            this.Controls.Add(this.btn_afrekenen);
            this.Controls.Add(this.btn_BestellingOpnemen);
            this.Name = "KiesOpname";
            this.Text = "KiesOpname";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BestellingOpnemen;
        private System.Windows.Forms.Button btn_afrekenen;
        private System.Windows.Forms.Button btn_KIESOPNnaarTAFELOVERZICHT;
        private System.Windows.Forms.Label lbl_kieseenoptie;
    }
}