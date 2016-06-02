namespace WindowsFormsApplication1
{
    partial class DinerKaart
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LUNCHnaarDRANKEN = new System.Windows.Forms.Button();
            this.btn_DINERnaarBESTELLING = new System.Windows.Forms.Button();
            this.listview_diner = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Voorraad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_stuurbestelling = new System.Windows.Forms.Button();
            this.btn_verwijderBestelling = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listview_huidige_bestelling = new System.Windows.Forms.ListView();
            this.bestelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 31);
            this.label1.TabIndex = 56;
            this.label1.Text = "Diner";
            // 
            // btn_LUNCHnaarDRANKEN
            // 
            this.btn_LUNCHnaarDRANKEN.BackColor = System.Drawing.Color.Maroon;
            this.btn_LUNCHnaarDRANKEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LUNCHnaarDRANKEN.ForeColor = System.Drawing.Color.White;
            this.btn_LUNCHnaarDRANKEN.Location = new System.Drawing.Point(12, 100);
            this.btn_LUNCHnaarDRANKEN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LUNCHnaarDRANKEN.Name = "btn_LUNCHnaarDRANKEN";
            this.btn_LUNCHnaarDRANKEN.Size = new System.Drawing.Size(1005, 64);
            this.btn_LUNCHnaarDRANKEN.TabIndex = 55;
            this.btn_LUNCHnaarDRANKEN.Text = "Dranken";
            this.btn_LUNCHnaarDRANKEN.UseVisualStyleBackColor = false;
            this.btn_LUNCHnaarDRANKEN.Click += new System.EventHandler(this.btn_LUNCHnaarDRANKEN_Click);
            // 
            // btn_DINERnaarBESTELLING
            // 
            this.btn_DINERnaarBESTELLING.BackColor = System.Drawing.Color.Maroon;
            this.btn_DINERnaarBESTELLING.ForeColor = System.Drawing.Color.White;
            this.btn_DINERnaarBESTELLING.Location = new System.Drawing.Point(12, 15);
            this.btn_DINERnaarBESTELLING.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DINERnaarBESTELLING.Name = "btn_DINERnaarBESTELLING";
            this.btn_DINERnaarBESTELLING.Size = new System.Drawing.Size(148, 60);
            this.btn_DINERnaarBESTELLING.TabIndex = 78;
            this.btn_DINERnaarBESTELLING.Text = "Terug naar Bestelling Menu";
            this.btn_DINERnaarBESTELLING.UseVisualStyleBackColor = false;
            this.btn_DINERnaarBESTELLING.Click += new System.EventHandler(this.btn_DINERnaarBESTELLING_Click);
            // 
            // listview_diner
            // 
            this.listview_diner.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.Prijs,
            this.Voorraad});
            this.listview_diner.FullRowSelect = true;
            this.listview_diner.GridLines = true;
            this.listview_diner.Location = new System.Drawing.Point(16, 196);
            this.listview_diner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listview_diner.Name = "listview_diner";
            this.listview_diner.Size = new System.Drawing.Size(503, 292);
            this.listview_diner.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listview_diner.TabIndex = 81;
            this.listview_diner.UseCompatibleStateImageBehavior = false;
            this.listview_diner.View = System.Windows.Forms.View.Details;
            this.listview_diner.SelectedIndexChanged += new System.EventHandler(this.listview_diner_SelectedIndexChanged);
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 284;
            // 
            // Prijs
            // 
            this.Prijs.Text = "Prijs";
            this.Prijs.Width = 33;
            // 
            // Voorraad
            // 
            this.Voorraad.Text = "Voorraad";
            this.Voorraad.Width = 55;
            // 
            // btn_stuurbestelling
            // 
            this.btn_stuurbestelling.BackColor = System.Drawing.Color.LightGreen;
            this.btn_stuurbestelling.Location = new System.Drawing.Point(893, 553);
            this.btn_stuurbestelling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_stuurbestelling.Name = "btn_stuurbestelling";
            this.btn_stuurbestelling.Size = new System.Drawing.Size(124, 50);
            this.btn_stuurbestelling.TabIndex = 82;
            this.btn_stuurbestelling.Text = "Stuur Bestelling";
            this.btn_stuurbestelling.UseVisualStyleBackColor = false;
            this.btn_stuurbestelling.Click += new System.EventHandler(this.btn_stuurbestelling_Click);
            // 
            // btn_verwijderBestelling
            // 
            this.btn_verwijderBestelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verwijderBestelling.Location = new System.Drawing.Point(541, 496);
            this.btn_verwijderBestelling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_verwijderBestelling.Name = "btn_verwijderBestelling";
            this.btn_verwijderBestelling.Size = new System.Drawing.Size(236, 62);
            this.btn_verwijderBestelling.TabIndex = 84;
            this.btn_verwijderBestelling.Text = "Verwijder hele bestelling";
            this.btn_verwijderBestelling.UseVisualStyleBackColor = true;
            this.btn_verwijderBestelling.Click += new System.EventHandler(this.btn_verwijderGerecht_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 26);
            this.label2.TabIndex = 85;
            this.label2.Text = "Dinerkaart Gerechten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(676, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 26);
            this.label3.TabIndex = 86;
            this.label3.Text = "Huidige bestelling";
            // 
            // listview_huidige_bestelling
            // 
            this.listview_huidige_bestelling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bestelling,
            this.aantal});
            this.listview_huidige_bestelling.FullRowSelect = true;
            this.listview_huidige_bestelling.GridLines = true;
            this.listview_huidige_bestelling.Location = new System.Drawing.Point(527, 196);
            this.listview_huidige_bestelling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listview_huidige_bestelling.Name = "listview_huidige_bestelling";
            this.listview_huidige_bestelling.Size = new System.Drawing.Size(503, 292);
            this.listview_huidige_bestelling.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listview_huidige_bestelling.TabIndex = 87;
            this.listview_huidige_bestelling.UseCompatibleStateImageBehavior = false;
            this.listview_huidige_bestelling.View = System.Windows.Forms.View.Details;
            this.listview_huidige_bestelling.SelectedIndexChanged += new System.EventHandler(this.listview_huidige_bestelling_SelectedIndexChanged);
            // 
            // bestelling
            // 
            this.bestelling.Text = "Bestelling";
            this.bestelling.Width = 300;
            // 
            // aantal
            // 
            this.aantal.Text = "Aantal";
            // 
            // DinerKaart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 618);
            this.Controls.Add(this.listview_huidige_bestelling);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_verwijderBestelling);
            this.Controls.Add(this.listview_diner);
            this.Controls.Add(this.btn_stuurbestelling);
            this.Controls.Add(this.btn_DINERnaarBESTELLING);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_LUNCHnaarDRANKEN);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DinerKaart";
            this.Text = "DinerKaart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_LUNCHnaarDRANKEN;
        private System.Windows.Forms.Button btn_DINERnaarBESTELLING;
        private System.Windows.Forms.ListView listview_diner;
        private System.Windows.Forms.Button btn_stuurbestelling;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Prijs;
        private System.Windows.Forms.ColumnHeader Voorraad;
        private System.Windows.Forms.Button btn_verwijderBestelling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listview_huidige_bestelling;
        private System.Windows.Forms.ColumnHeader bestelling;
        private System.Windows.Forms.ColumnHeader aantal;
    }
}