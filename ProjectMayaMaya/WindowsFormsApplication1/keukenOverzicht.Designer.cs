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
            this.lbl_BestellingKeukenX = new System.Windows.Forms.Label();
            this.verticaal_ScrollBar = new System.Windows.Forms.VScrollBar();
            this.btn_KeukenNaarHoofdmenu = new System.Windows.Forms.Button();
            this.groep_BestellingKeukenX.SuspendLayout();
            this.SuspendLayout();
            // 
            // groep_BestellingKeukenX
            // 
            this.groep_BestellingKeukenX.Controls.Add(this.verticaal_ScrollBar);
            this.groep_BestellingKeukenX.Controls.Add(this.lbl_BestellingKeukenX);
            this.groep_BestellingKeukenX.Location = new System.Drawing.Point(12, 12);
            this.groep_BestellingKeukenX.Name = "groep_BestellingKeukenX";
            this.groep_BestellingKeukenX.Size = new System.Drawing.Size(339, 220);
            this.groep_BestellingKeukenX.TabIndex = 0;
            this.groep_BestellingKeukenX.TabStop = false;
            this.groep_BestellingKeukenX.Text = "Bestelling X";
            // 
            // lbl_BestellingKeukenX
            // 
            this.lbl_BestellingKeukenX.AutoSize = true;
            this.lbl_BestellingKeukenX.Location = new System.Drawing.Point(7, 22);
            this.lbl_BestellingKeukenX.Name = "lbl_BestellingKeukenX";
            this.lbl_BestellingKeukenX.Size = new System.Drawing.Size(46, 17);
            this.lbl_BestellingKeukenX.TabIndex = 0;
            this.lbl_BestellingKeukenX.Text = "label1";
            // 
            // verticaal_ScrollBar
            // 
            this.verticaal_ScrollBar.Location = new System.Drawing.Point(305, 18);
            this.verticaal_ScrollBar.Name = "verticaal_ScrollBar";
            this.verticaal_ScrollBar.Size = new System.Drawing.Size(21, 187);
            this.verticaal_ScrollBar.TabIndex = 1;
            // 
            // btn_KeukenNaarHoofdmenu
            // 
            this.btn_KeukenNaarHoofdmenu.Location = new System.Drawing.Point(823, 456);
            this.btn_KeukenNaarHoofdmenu.Name = "btn_KeukenNaarHoofdmenu";
            this.btn_KeukenNaarHoofdmenu.Size = new System.Drawing.Size(178, 34);
            this.btn_KeukenNaarHoofdmenu.TabIndex = 1;
            this.btn_KeukenNaarHoofdmenu.Text = "Terug naar hoofdmenu";
            this.btn_KeukenNaarHoofdmenu.UseVisualStyleBackColor = true;
            // 
            // keukenBestellingOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 502);
            this.Controls.Add(this.btn_KeukenNaarHoofdmenu);
            this.Controls.Add(this.groep_BestellingKeukenX);
            this.Name = "keukenBestellingOverzicht";
            this.Text = "keukenBestellingOverzicht";
            this.groep_BestellingKeukenX.ResumeLayout(false);
            this.groep_BestellingKeukenX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groep_BestellingKeukenX;
        private System.Windows.Forms.VScrollBar verticaal_ScrollBar;
        private System.Windows.Forms.Label lbl_BestellingKeukenX;
        private System.Windows.Forms.Button btn_KeukenNaarHoofdmenu;
    }
}