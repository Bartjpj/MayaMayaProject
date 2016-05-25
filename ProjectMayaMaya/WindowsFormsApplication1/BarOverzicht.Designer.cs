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
            this.Bestelling_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BestellingInzienBar = new System.Windows.Forms.ListView();
            this.gbox_BarBestelling.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_BarBestelling
            // 
            this.gbox_BarBestelling.Controls.Add(this.BestellingInzienBar);
            this.gbox_BarBestelling.Location = new System.Drawing.Point(12, 53);
            this.gbox_BarBestelling.Name = "gbox_BarBestelling";
            this.gbox_BarBestelling.Size = new System.Drawing.Size(757, 317);
            this.gbox_BarBestelling.TabIndex = 0;
            this.gbox_BarBestelling.TabStop = false;
            this.gbox_BarBestelling.Text = "Bestelling X";
            this.gbox_BarBestelling.Enter += new System.EventHandler(this.gbox_BarBestelling_Enter);
            // 
            // lbl_OpenstaandeBestellingenKeuken
            // 
            this.lbl_OpenstaandeBestellingenKeuken.AutoSize = true;
            this.lbl_OpenstaandeBestellingenKeuken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OpenstaandeBestellingenKeuken.Location = new System.Drawing.Point(12, 9);
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
            this.btn_BARnaarHM.Click += new System.EventHandler(this.btn_BARnaarHM_Click);
            // 
            // Bestelling_id
            // 
            this.Bestelling_id.Text = "Bestelling_id";
            // 
            // BestellingInzienBar
            // 
            this.BestellingInzienBar.Location = new System.Drawing.Point(6, 19);
            this.BestellingInzienBar.Name = "BestellingInzienBar";
            this.BestellingInzienBar.Size = new System.Drawing.Size(745, 280);
            this.BestellingInzienBar.TabIndex = 0;
            this.BestellingInzienBar.UseCompatibleStateImageBehavior = false;
            this.BestellingInzienBar.View = System.Windows.Forms.View.Details;
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
            this.Load += new System.EventHandler(this.BarOverzicht_Load);
            this.gbox_BarBestelling.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_BarBestelling;
        private System.Windows.Forms.Label lbl_OpenstaandeBestellingenKeuken;
        private System.Windows.Forms.Button btn_BARnaarHM;
        private System.Windows.Forms.ColumnHeader Bestelling_id;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView BestellingInzienBar;
    }
}