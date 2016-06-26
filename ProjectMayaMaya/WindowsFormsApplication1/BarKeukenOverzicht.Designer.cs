namespace WindowsFormsApplication1
{
    partial class BarKeukenOverzicht
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
            this.lbl_OpenstaandeBestellingenKeuken = new System.Windows.Forms.Label();
            this.Bestelling_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_BARnaarHM = new System.Windows.Forms.Button();
            this.btn_BestellingGereed = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Tafel_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum_tijd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opmerking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lopendeBestellingTafels = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_dagoverzicht = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_OpenstaandeBestellingenKeuken
            // 
            this.lbl_OpenstaandeBestellingenKeuken.AutoSize = true;
            this.lbl_OpenstaandeBestellingenKeuken.Font = new System.Drawing.Font("Calibri", 16F);
            this.lbl_OpenstaandeBestellingenKeuken.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_OpenstaandeBestellingenKeuken.Location = new System.Drawing.Point(218, 66);
            this.lbl_OpenstaandeBestellingenKeuken.Name = "lbl_OpenstaandeBestellingenKeuken";
            this.lbl_OpenstaandeBestellingenKeuken.Size = new System.Drawing.Size(250, 27);
            this.lbl_OpenstaandeBestellingenKeuken.TabIndex = 1;
            this.lbl_OpenstaandeBestellingenKeuken.Text = "Openstaande Bestellingen";
            // 
            // Bestelling_id
            // 
            this.Bestelling_id.Text = "Bestelling_id";
            // 
            // btn_BARnaarHM
            // 
            this.btn_BARnaarHM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.btn_BARnaarHM.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_BARnaarHM.ForeColor = System.Drawing.Color.White;
            this.btn_BARnaarHM.Location = new System.Drawing.Point(12, 12);
            this.btn_BARnaarHM.Name = "btn_BARnaarHM";
            this.btn_BARnaarHM.Size = new System.Drawing.Size(145, 49);
            this.btn_BARnaarHM.TabIndex = 2;
            this.btn_BARnaarHM.Text = "Inlogscherm";
            this.btn_BARnaarHM.UseVisualStyleBackColor = false;
            this.btn_BARnaarHM.Click += new System.EventHandler(this.btn_BARnaarHM_Click);
            // 
            // btn_BestellingGereed
            // 
            this.btn_BestellingGereed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.btn_BestellingGereed.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_BestellingGereed.ForeColor = System.Drawing.Color.White;
            this.btn_BestellingGereed.Location = new System.Drawing.Point(622, 405);
            this.btn_BestellingGereed.Name = "btn_BestellingGereed";
            this.btn_BestellingGereed.Size = new System.Drawing.Size(145, 46);
            this.btn_BestellingGereed.TabIndex = 5;
            this.btn_BestellingGereed.Text = "Gereed";
            this.btn_BestellingGereed.UseVisualStyleBackColor = false;
            this.btn_BestellingGereed.Click += new System.EventHandler(this.btn_BestellingGereed_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(246)))), ((int)(((byte)(235)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tafel_id,
            this.Item,
            this.Aantal,
            this.Datum_tijd,
            this.opmerking});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 158);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(755, 204);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Tafel_id
            // 
            this.Tafel_id.Text = "Tafel";
            this.Tafel_id.Width = 40;
            // 
            // Item
            // 
            this.Item.DisplayIndex = 2;
            this.Item.Text = "Item";
            this.Item.Width = 300;
            // 
            // Aantal
            // 
            this.Aantal.DisplayIndex = 1;
            this.Aantal.Text = "Aantal";
            this.Aantal.Width = 43;
            // 
            // Datum_tijd
            // 
            this.Datum_tijd.Text = "Datum/tijd";
            this.Datum_tijd.Width = 114;
            // 
            // opmerking
            // 
            this.opmerking.Text = "Opmerking";
            this.opmerking.Width = 200;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_refresh.Location = new System.Drawing.Point(12, 405);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(145, 46);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lopendeBestellingTafels
            // 
            this.lopendeBestellingTafels.Location = new System.Drawing.Point(492, 12);
            this.lopendeBestellingTafels.Name = "lopendeBestellingTafels";
            this.lopendeBestellingTafels.Size = new System.Drawing.Size(275, 138);
            this.lopendeBestellingTafels.TabIndex = 11;
            // 
            // btn_dagoverzicht
            // 
            this.btn_dagoverzicht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.btn_dagoverzicht.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_dagoverzicht.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dagoverzicht.Location = new System.Drawing.Point(311, 405);
            this.btn_dagoverzicht.Name = "btn_dagoverzicht";
            this.btn_dagoverzicht.Size = new System.Drawing.Size(145, 46);
            this.btn_dagoverzicht.TabIndex = 12;
            this.btn_dagoverzicht.Text = "Dagoverzicht";
            this.btn_dagoverzicht.UseVisualStyleBackColor = false;
            this.btn_dagoverzicht.Click += new System.EventHandler(this.btn_dagoverzicht_Click);
            // 
            // BarKeukenOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(87)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(790, 463);
            this.Controls.Add(this.btn_dagoverzicht);
            this.Controls.Add(this.lopendeBestellingTafels);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_BestellingGereed);
            this.Controls.Add(this.btn_BARnaarHM);
            this.Controls.Add(this.lbl_OpenstaandeBestellingenKeuken);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "BarKeukenOverzicht";
            this.Text = "BarOverzicht";
            this.Load += new System.EventHandler(this.BarOverzicht_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_OpenstaandeBestellingenKeuken;
        private System.Windows.Forms.ColumnHeader Bestelling_id;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btn_BARnaarHM;
        private System.Windows.Forms.Button btn_BestellingGereed;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Tafel_id;
        private System.Windows.Forms.ColumnHeader Aantal;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.FlowLayoutPanel lopendeBestellingTafels;
        private System.Windows.Forms.Button btn_dagoverzicht;
        private System.Windows.Forms.ColumnHeader Datum_tijd;
        private System.Windows.Forms.ColumnHeader opmerking;
    }
}