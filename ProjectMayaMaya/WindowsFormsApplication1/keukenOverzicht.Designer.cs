namespace WindowsFormsApplication1
{
    partial class keukenBestellingOverzicht
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
            this.groep_BestellingKeukenX = new System.Windows.Forms.GroupBox();
            this.verticaal_ScrollBar = new System.Windows.Forms.VScrollBar();
            this.lbl_BestellingKeukenX = new System.Windows.Forms.Label();
            this.btn_KeukenNaarHoofdmenu = new System.Windows.Forms.Button();
            this.lbl_OpenstaandeBestellingenKeuken = new System.Windows.Forms.Label();
            this.groep_BestellingKeukenX.SuspendLayout();
            this.SuspendLayout();
            // 
            // groep_BestellingKeukenX
            // 
            this.groep_BestellingKeukenX.Controls.Add(this.verticaal_ScrollBar);
            this.groep_BestellingKeukenX.Controls.Add(this.lbl_BestellingKeukenX);
            this.groep_BestellingKeukenX.Location = new System.Drawing.Point(11, 51);
            this.groep_BestellingKeukenX.Margin = new System.Windows.Forms.Padding(2);
            this.groep_BestellingKeukenX.Name = "groep_BestellingKeukenX";
            this.groep_BestellingKeukenX.Padding = new System.Windows.Forms.Padding(2);
            this.groep_BestellingKeukenX.Size = new System.Drawing.Size(254, 179);
            this.groep_BestellingKeukenX.TabIndex = 0;
            this.groep_BestellingKeukenX.TabStop = false;
            this.groep_BestellingKeukenX.Text = "Bestelling X";
            // 
            // verticaal_ScrollBar
            // 
            this.verticaal_ScrollBar.Location = new System.Drawing.Point(229, 15);
            this.verticaal_ScrollBar.Name = "verticaal_ScrollBar";
            this.verticaal_ScrollBar.Size = new System.Drawing.Size(21, 152);
            this.verticaal_ScrollBar.TabIndex = 1;
            // 
            // lbl_BestellingKeukenX
            // 
            this.lbl_BestellingKeukenX.AutoSize = true;
            this.lbl_BestellingKeukenX.Location = new System.Drawing.Point(5, 18);
            this.lbl_BestellingKeukenX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BestellingKeukenX.Name = "lbl_BestellingKeukenX";
            this.lbl_BestellingKeukenX.Size = new System.Drawing.Size(35, 13);
            this.lbl_BestellingKeukenX.TabIndex = 0;
            this.lbl_BestellingKeukenX.Text = "label1";
            // 
            // btn_KeukenNaarHoofdmenu
            // 
            this.btn_KeukenNaarHoofdmenu.Location = new System.Drawing.Point(576, 349);
            this.btn_KeukenNaarHoofdmenu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_KeukenNaarHoofdmenu.Name = "btn_KeukenNaarHoofdmenu";
            this.btn_KeukenNaarHoofdmenu.Size = new System.Drawing.Size(175, 49);
            this.btn_KeukenNaarHoofdmenu.TabIndex = 1;
            this.btn_KeukenNaarHoofdmenu.Text = "Terug naar hoofdmenu";
            this.btn_KeukenNaarHoofdmenu.UseVisualStyleBackColor = true;
            this.btn_KeukenNaarHoofdmenu.Click += new System.EventHandler(this.btn_KeukenNaarHoofdmenu_Click);
            // 
            // lbl_OpenstaandeBestellingenKeuken
            // 
            this.lbl_OpenstaandeBestellingenKeuken.AutoSize = true;
            this.lbl_OpenstaandeBestellingenKeuken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OpenstaandeBestellingenKeuken.Location = new System.Drawing.Point(36, 25);
            this.lbl_OpenstaandeBestellingenKeuken.Name = "lbl_OpenstaandeBestellingenKeuken";
            this.lbl_OpenstaandeBestellingenKeuken.Size = new System.Drawing.Size(242, 24);
            this.lbl_OpenstaandeBestellingenKeuken.TabIndex = 2;
            this.lbl_OpenstaandeBestellingenKeuken.Text = "Openstaande Bestellingen: ";
            // 
            // keukenBestellingOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 408);
            this.Controls.Add(this.lbl_OpenstaandeBestellingenKeuken);
            this.Controls.Add(this.btn_KeukenNaarHoofdmenu);
            this.Controls.Add(this.groep_BestellingKeukenX);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "keukenBestellingOverzicht";
            this.Text = "keukenBestellingOverzicht";
            this.groep_BestellingKeukenX.ResumeLayout(false);
            this.groep_BestellingKeukenX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groep_BestellingKeukenX;
        private System.Windows.Forms.VScrollBar verticaal_ScrollBar;
        private System.Windows.Forms.Label lbl_BestellingKeukenX;
        private System.Windows.Forms.Button btn_KeukenNaarHoofdmenu;
        private System.Windows.Forms.Label lbl_OpenstaandeBestellingenKeuken;
    }
}