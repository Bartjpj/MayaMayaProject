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
            this.lbl_OpenstaandeBestellingenKeuken = new System.Windows.Forms.Label();
            this.Bestelling_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_BARnaarHM = new System.Windows.Forms.Button();
            this.btn_BestellingGereed = new System.Windows.Forms.Button();
            this.lb_Baroverzicht = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_OpenstaandeBestellingenKeuken
            // 
            this.lbl_OpenstaandeBestellingenKeuken.AutoSize = true;
            this.lbl_OpenstaandeBestellingenKeuken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OpenstaandeBestellingenKeuken.Location = new System.Drawing.Point(263, 88);
            this.lbl_OpenstaandeBestellingenKeuken.Name = "lbl_OpenstaandeBestellingenKeuken";
            this.lbl_OpenstaandeBestellingenKeuken.Size = new System.Drawing.Size(237, 24);
            this.lbl_OpenstaandeBestellingenKeuken.TabIndex = 1;
            this.lbl_OpenstaandeBestellingenKeuken.Text = "Openstaande Bestellingen:";
            // 
            // Bestelling_id
            // 
            this.Bestelling_id.Text = "Bestelling_id";
            // 
            // btn_BARnaarHM
            // 
            this.btn_BARnaarHM.Location = new System.Drawing.Point(12, 12);
            this.btn_BARnaarHM.Name = "btn_BARnaarHM";
            this.btn_BARnaarHM.Size = new System.Drawing.Size(128, 46);
            this.btn_BARnaarHM.TabIndex = 2;
            this.btn_BARnaarHM.Text = "Terug naar Hoofdmenu";
            this.btn_BARnaarHM.UseVisualStyleBackColor = true;
            this.btn_BARnaarHM.Click += new System.EventHandler(this.btn_BARnaarHM_Click);
            // 
            // btn_BestellingGereed
            // 
            this.btn_BestellingGereed.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_BestellingGereed.ForeColor = System.Drawing.Color.Black;
            this.btn_BestellingGereed.Location = new System.Drawing.Point(555, 405);
            this.btn_BestellingGereed.Name = "btn_BestellingGereed";
            this.btn_BestellingGereed.Size = new System.Drawing.Size(154, 45);
            this.btn_BestellingGereed.TabIndex = 5;
            this.btn_BestellingGereed.Text = "Gereed";
            this.btn_BestellingGereed.UseVisualStyleBackColor = false;
            this.btn_BestellingGereed.Click += new System.EventHandler(this.btn_BestellingGereed_Click);
            // 
            // lb_Baroverzicht
            // 
            this.lb_Baroverzicht.DataSource = this.lb_Baroverzicht.CustomTabOffsets;
            this.lb_Baroverzicht.FormattingEnabled = true;
            this.lb_Baroverzicht.HorizontalScrollbar = true;
            this.lb_Baroverzicht.Location = new System.Drawing.Point(12, 64);
            this.lb_Baroverzicht.MultiColumn = true;
            this.lb_Baroverzicht.Name = "lb_Baroverzicht";
            this.lb_Baroverzicht.Size = new System.Drawing.Size(755, 160);
            this.lb_Baroverzicht.TabIndex = 7;
            this.lb_Baroverzicht.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 157);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Bestelling_id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tafel_id";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Aantal";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Item";
            this.Column4.Name = "Column4";
            // 
            // BarOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_Baroverzicht);
            this.Controls.Add(this.btn_BestellingGereed);
            this.Controls.Add(this.btn_BARnaarHM);
            this.Controls.Add(this.lbl_OpenstaandeBestellingenKeuken);
            this.Name = "BarOverzicht";
            this.Text = "BarOverzicht";
            this.Load += new System.EventHandler(this.BarOverzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_OpenstaandeBestellingenKeuken;
        private System.Windows.Forms.ColumnHeader Bestelling_id;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btn_BARnaarHM;
        private System.Windows.Forms.Button btn_BestellingGereed;
        private System.Windows.Forms.ListBox lb_Baroverzicht;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}