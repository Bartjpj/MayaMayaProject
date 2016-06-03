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
            this.btn_KeukenNaarHoofdmenu = new System.Windows.Forms.Button();
            this.lbl_OpenstaandeBestellingenKeuken = new System.Windows.Forms.Label();
            this.btn_gereedKeuken = new System.Windows.Forms.Button();
            this.bestellingOverzichtKeukenView = new System.Windows.Forms.ListView();
            this.Bestelling_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tafel_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_keukenOverzicht = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_KeukenNaarHoofdmenu
            // 
            this.btn_KeukenNaarHoofdmenu.BackColor = System.Drawing.Color.Maroon;
            this.btn_KeukenNaarHoofdmenu.ForeColor = System.Drawing.Color.White;
            this.btn_KeukenNaarHoofdmenu.Location = new System.Drawing.Point(11, 11);
            this.btn_KeukenNaarHoofdmenu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_KeukenNaarHoofdmenu.Name = "btn_KeukenNaarHoofdmenu";
            this.btn_KeukenNaarHoofdmenu.Size = new System.Drawing.Size(111, 49);
            this.btn_KeukenNaarHoofdmenu.TabIndex = 1;
            this.btn_KeukenNaarHoofdmenu.Text = "Terug naar hoofdmenu";
            this.btn_KeukenNaarHoofdmenu.UseVisualStyleBackColor = false;
            this.btn_KeukenNaarHoofdmenu.Click += new System.EventHandler(this.btn_KeukenNaarHoofdmenu_Click);
            // 
            // lbl_OpenstaandeBestellingenKeuken
            // 
            this.lbl_OpenstaandeBestellingenKeuken.AutoSize = true;
            this.lbl_OpenstaandeBestellingenKeuken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OpenstaandeBestellingenKeuken.Location = new System.Drawing.Point(253, 49);
            this.lbl_OpenstaandeBestellingenKeuken.Name = "lbl_OpenstaandeBestellingenKeuken";
            this.lbl_OpenstaandeBestellingenKeuken.Size = new System.Drawing.Size(242, 24);
            this.lbl_OpenstaandeBestellingenKeuken.TabIndex = 2;
            this.lbl_OpenstaandeBestellingenKeuken.Text = "Openstaande Bestellingen: ";
            // 
            // btn_gereedKeuken
            // 
            this.btn_gereedKeuken.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_gereedKeuken.ForeColor = System.Drawing.Color.Black;
            this.btn_gereedKeuken.Location = new System.Drawing.Point(602, 337);
            this.btn_gereedKeuken.Name = "btn_gereedKeuken";
            this.btn_gereedKeuken.Size = new System.Drawing.Size(146, 44);
            this.btn_gereedKeuken.TabIndex = 4;
            this.btn_gereedKeuken.Text = "Gereed";
            this.btn_gereedKeuken.UseVisualStyleBackColor = false;
            this.btn_gereedKeuken.Click += new System.EventHandler(this.btn_gereedKeuken_Click);
            // 
            // bestellingOverzichtKeukenView
            // 
            this.bestellingOverzichtKeukenView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Bestelling_id,
            this.Tafel_id,
            this.Aantal,
            this.Item});
            this.bestellingOverzichtKeukenView.Location = new System.Drawing.Point(11, 94);
            this.bestellingOverzichtKeukenView.Name = "bestellingOverzichtKeukenView";
            this.bestellingOverzichtKeukenView.Size = new System.Drawing.Size(737, 201);
            this.bestellingOverzichtKeukenView.TabIndex = 5;
            this.bestellingOverzichtKeukenView.UseCompatibleStateImageBehavior = false;
            this.bestellingOverzichtKeukenView.View = System.Windows.Forms.View.Details;
            // 
            // Bestelling_id
            // 
            this.Bestelling_id.Text = "BestellingID";
            this.Bestelling_id.Width = 149;
            // 
            // Tafel_id
            // 
            this.Tafel_id.Text = "Tafel_id";
            this.Tafel_id.Width = 163;
            // 
            // Aantal
            // 
            this.Aantal.Text = "Aantal";
            this.Aantal.Width = 116;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 176;
            // 
            // btn_keukenOverzicht
            // 
            this.btn_keukenOverzicht.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_keukenOverzicht.Location = new System.Drawing.Point(73, 337);
            this.btn_keukenOverzicht.Name = "btn_keukenOverzicht";
            this.btn_keukenOverzicht.Size = new System.Drawing.Size(136, 44);
            this.btn_keukenOverzicht.TabIndex = 6;
            this.btn_keukenOverzicht.Text = "Refresh";
            this.btn_keukenOverzicht.UseVisualStyleBackColor = false;
            // 
            // keukenBestellingOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 393);
            this.Controls.Add(this.btn_keukenOverzicht);
            this.Controls.Add(this.bestellingOverzichtKeukenView);
            this.Controls.Add(this.btn_gereedKeuken);
            this.Controls.Add(this.lbl_OpenstaandeBestellingenKeuken);
            this.Controls.Add(this.btn_KeukenNaarHoofdmenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "keukenBestellingOverzicht";
            this.Text = "keukenBestellingOverzicht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_KeukenNaarHoofdmenu;
        private System.Windows.Forms.Label lbl_OpenstaandeBestellingenKeuken;
        private System.Windows.Forms.Button btn_gereedKeuken;
        private System.Windows.Forms.ListView bestellingOverzichtKeukenView;
        private System.Windows.Forms.ColumnHeader Bestelling_id;
        private System.Windows.Forms.ColumnHeader Tafel_id;
        private System.Windows.Forms.ColumnHeader Aantal;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.Button btn_keukenOverzicht;
    }
}