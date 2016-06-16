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
            this.bestellingOverzichtKeukenView = new System.Windows.Forms.ListView();
            this.Bestelling_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tafel_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum_tijd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Opmerking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_keukenOverzicht = new System.Windows.Forms.Button();
            this.btn_gereed_keuken = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_dagKeukenOverzicht = new System.Windows.Forms.Button();
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
            this.lbl_OpenstaandeBestellingenKeuken.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_OpenstaandeBestellingenKeuken.Location = new System.Drawing.Point(253, 49);
            this.lbl_OpenstaandeBestellingenKeuken.Name = "lbl_OpenstaandeBestellingenKeuken";
            this.lbl_OpenstaandeBestellingenKeuken.Size = new System.Drawing.Size(242, 24);
            this.lbl_OpenstaandeBestellingenKeuken.TabIndex = 2;
            this.lbl_OpenstaandeBestellingenKeuken.Text = "Openstaande Bestellingen: ";
            this.lbl_OpenstaandeBestellingenKeuken.Click += new System.EventHandler(this.lbl_OpenstaandeBestellingenKeuken_Click);
            // 
            // bestellingOverzichtKeukenView
            // 
            this.bestellingOverzichtKeukenView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Bestelling_id,
            this.Tafel_id,
            this.Aantal,
            this.Item,
            this.Datum_tijd,
            this.Opmerking});
            this.bestellingOverzichtKeukenView.FullRowSelect = true;
            this.bestellingOverzichtKeukenView.GridLines = true;
            this.bestellingOverzichtKeukenView.Location = new System.Drawing.Point(34, 132);
            this.bestellingOverzichtKeukenView.Name = "bestellingOverzichtKeukenView";
            this.bestellingOverzichtKeukenView.Size = new System.Drawing.Size(737, 201);
            this.bestellingOverzichtKeukenView.TabIndex = 5;
            this.bestellingOverzichtKeukenView.UseCompatibleStateImageBehavior = false;
            this.bestellingOverzichtKeukenView.View = System.Windows.Forms.View.Details;
            this.bestellingOverzichtKeukenView.SelectedIndexChanged += new System.EventHandler(this.bestellingOverzichtKeukenView_SelectedIndexChanged);
            // 
            // Bestelling_id
            // 
            this.Bestelling_id.Text = "BestellingID";
            this.Bestelling_id.Width = 70;
            // 
            // Tafel_id
            // 
            this.Tafel_id.Text = "Tafel_id";
            this.Tafel_id.Width = 51;
            // 
            // Aantal
            // 
            this.Aantal.DisplayIndex = 3;
            this.Aantal.Text = "Aantal";
            this.Aantal.Width = 45;
            // 
            // Item
            // 
            this.Item.DisplayIndex = 2;
            this.Item.Text = "Item";
            this.Item.Width = 270;
            // 
            // Datum_tijd
            // 
            this.Datum_tijd.Text = "Datum/Tijd";
            this.Datum_tijd.Width = 118;
            // 
            // Opmerking
            // 
            this.Opmerking.Text = "Opmerking";
            this.Opmerking.Width = 175;
            // 
            // btn_keukenOverzicht
            // 
            this.btn_keukenOverzicht.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_keukenOverzicht.Location = new System.Drawing.Point(68, 402);
            this.btn_keukenOverzicht.Name = "btn_keukenOverzicht";
            this.btn_keukenOverzicht.Size = new System.Drawing.Size(136, 44);
            this.btn_keukenOverzicht.TabIndex = 6;
            this.btn_keukenOverzicht.Text = "Refresh";
            this.btn_keukenOverzicht.UseVisualStyleBackColor = false;
            this.btn_keukenOverzicht.Click += new System.EventHandler(this.btn_keukenOverzicht_Click);
            // 
            // btn_gereed_keuken
            // 
            this.btn_gereed_keuken.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_gereed_keuken.Location = new System.Drawing.Point(612, 402);
            this.btn_gereed_keuken.Name = "btn_gereed_keuken";
            this.btn_gereed_keuken.Size = new System.Drawing.Size(134, 44);
            this.btn_gereed_keuken.TabIndex = 7;
            this.btn_gereed_keuken.Text = "Gereed";
            this.btn_gereed_keuken.UseVisualStyleBackColor = false;
            this.btn_gereed_keuken.Click += new System.EventHandler(this.btn_gereed_keuken_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(501, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(294, 114);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // btn_dagKeukenOverzicht
            // 
            this.btn_dagKeukenOverzicht.BackColor = System.Drawing.Color.Maroon;
            this.btn_dagKeukenOverzicht.Location = new System.Drawing.Point(339, 402);
            this.btn_dagKeukenOverzicht.Name = "btn_dagKeukenOverzicht";
            this.btn_dagKeukenOverzicht.Size = new System.Drawing.Size(136, 44);
            this.btn_dagKeukenOverzicht.TabIndex = 9;
            this.btn_dagKeukenOverzicht.Text = "Dagoverzicht";
            this.btn_dagKeukenOverzicht.UseVisualStyleBackColor = false;
            this.btn_dagKeukenOverzicht.Click += new System.EventHandler(this.button1_Click);
            // 
            // keukenBestellingOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 458);
            this.Controls.Add(this.btn_dagKeukenOverzicht);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_gereed_keuken);
            this.Controls.Add(this.btn_keukenOverzicht);
            this.Controls.Add(this.bestellingOverzichtKeukenView);
            this.Controls.Add(this.lbl_OpenstaandeBestellingenKeuken);
            this.Controls.Add(this.btn_KeukenNaarHoofdmenu);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "keukenBestellingOverzicht";
            this.Text = "keukenBestellingOverzicht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_KeukenNaarHoofdmenu;
        private System.Windows.Forms.Label lbl_OpenstaandeBestellingenKeuken;
        private System.Windows.Forms.ListView bestellingOverzichtKeukenView;
        private System.Windows.Forms.ColumnHeader Bestelling_id;
        private System.Windows.Forms.ColumnHeader Tafel_id;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Aantal;
        private System.Windows.Forms.Button btn_keukenOverzicht;
        private System.Windows.Forms.Button btn_gereed_keuken;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ColumnHeader Datum_tijd;
        private System.Windows.Forms.ColumnHeader Opmerking;
        private System.Windows.Forms.Button btn_dagKeukenOverzicht;
    }
}