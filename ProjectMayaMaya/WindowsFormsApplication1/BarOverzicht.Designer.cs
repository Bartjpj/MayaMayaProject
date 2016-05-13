namespace WindowsFormsApplication1
{
    partial class BarOverzicht
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
            this.gbox_BarBestelling = new System.Windows.Forms.GroupBox();
            this.lbl_OpenstaandeBestellingenKeuken = new System.Windows.Forms.Label();
            this.btn_BARnaarHM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gbox_BarBestelling
            // 
            this.gbox_BarBestelling.Location = new System.Drawing.Point(12, 53);
            this.gbox_BarBestelling.Name = "gbox_BarBestelling";
            this.gbox_BarBestelling.Size = new System.Drawing.Size(211, 145);
            this.gbox_BarBestelling.TabIndex = 0;
            this.gbox_BarBestelling.TabStop = false;
            this.gbox_BarBestelling.Text = "Bestelling X";
            // 
            // lbl_OpenstaandeBestellingenKeuken
            // 
            this.lbl_OpenstaandeBestellingenKeuken.AutoSize = true;
            this.lbl_OpenstaandeBestellingenKeuken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OpenstaandeBestellingenKeuken.Location = new System.Drawing.Point(33, 26);
            this.lbl_OpenstaandeBestellingenKeuken.Name = "lbl_OpenstaandeBestellingenKeuken";
            this.lbl_OpenstaandeBestellingenKeuken.Size = new System.Drawing.Size(237, 24);
            this.lbl_OpenstaandeBestellingenKeuken.TabIndex = 1;
            this.lbl_OpenstaandeBestellingenKeuken.Text = "Openstaande Bestellingen:";
            // 
            // btn_BARnaarHM
            // 
            this.btn_BARnaarHM.Location = new System.Drawing.Point(584, 404);
            this.btn_BARnaarHM.Name = "btn_BARnaarHM";
            this.btn_BARnaarHM.Size = new System.Drawing.Size(185, 46);
            this.btn_BARnaarHM.TabIndex = 2;
            this.btn_BARnaarHM.Text = "Terug naar Hoofdmenu";
            this.btn_BARnaarHM.UseVisualStyleBackColor = true;
            // 
            // BarOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 463);
            this.Controls.Add(this.btn_BARnaarHM);
            this.Controls.Add(this.lbl_OpenstaandeBestellingenKeuken);
            this.Controls.Add(this.gbox_BarBestelling);
            this.Name = "BarOverzicht";
            this.Text = "BarOverzicht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_BarBestelling;
        private System.Windows.Forms.Label lbl_OpenstaandeBestellingenKeuken;
        private System.Windows.Forms.Button btn_BARnaarHM;
    }
}