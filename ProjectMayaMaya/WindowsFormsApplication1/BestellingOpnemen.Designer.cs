namespace WindowsFormsApplication1
{
    partial class BestellingOpnemen
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
            this.flow_menuCategorie = new System.Windows.Forms.FlowLayoutPanel();
            this.flow_MenuKaart = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_opmerking = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkbox_keuken = new System.Windows.Forms.CheckBox();
            this.checkbox_bar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Bestelling opnemen";
            // 
            // btn_DINERnaarBESTELLING
            // 
            this.btn_DINERnaarBESTELLING.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.btn_DINERnaarBESTELLING.ForeColor = System.Drawing.Color.White;
            this.btn_DINERnaarBESTELLING.Location = new System.Drawing.Point(10, 9);
            this.btn_DINERnaarBESTELLING.Name = "btn_DINERnaarBESTELLING";
            this.btn_DINERnaarBESTELLING.Size = new System.Drawing.Size(111, 49);
            this.btn_DINERnaarBESTELLING.TabIndex = 78;
            this.btn_DINERnaarBESTELLING.Text = "Terug naar Bestelling Menu";
            this.btn_DINERnaarBESTELLING.UseVisualStyleBackColor = false;
            this.btn_DINERnaarBESTELLING.Click += new System.EventHandler(this.btn_DINERnaarBESTELLING_Click);
            // 
            // listview_diner
            // 
            this.listview_diner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(246)))), ((int)(((byte)(235)))));
            this.listview_diner.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.Prijs,
            this.Voorraad});
            this.listview_diner.FullRowSelect = true;
            this.listview_diner.GridLines = true;
            this.listview_diner.Location = new System.Drawing.Point(10, 207);
            this.listview_diner.Name = "listview_diner";
            this.listview_diner.Size = new System.Drawing.Size(378, 238);
            this.listview_diner.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listview_diner.TabIndex = 81;
            this.listview_diner.UseCompatibleStateImageBehavior = false;
            this.listview_diner.View = System.Windows.Forms.View.Details;
            this.listview_diner.SelectedIndexChanged += new System.EventHandler(this.listview_diner_SelectedIndexChanged);
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 287;
            // 
            // Prijs
            // 
            this.Prijs.Text = "Prijs";
            this.Prijs.Width = 35;
            // 
            // Voorraad
            // 
            this.Voorraad.Text = "Voorraad";
            this.Voorraad.Width = 57;
            // 
            // btn_stuurbestelling
            // 
            this.btn_stuurbestelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.btn_stuurbestelling.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_stuurbestelling.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_stuurbestelling.Location = new System.Drawing.Point(672, 451);
            this.btn_stuurbestelling.Name = "btn_stuurbestelling";
            this.btn_stuurbestelling.Size = new System.Drawing.Size(99, 49);
            this.btn_stuurbestelling.TabIndex = 82;
            this.btn_stuurbestelling.Text = "Stuur Bestelling";
            this.btn_stuurbestelling.UseVisualStyleBackColor = false;
            this.btn_stuurbestelling.Click += new System.EventHandler(this.btn_stuurbestelling_Click_1);
            // 
            // btn_verwijderBestelling
            // 
            this.btn_verwijderBestelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.btn_verwijderBestelling.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_verwijderBestelling.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_verwijderBestelling.Location = new System.Drawing.Point(10, 450);
            this.btn_verwijderBestelling.Name = "btn_verwijderBestelling";
            this.btn_verwijderBestelling.Size = new System.Drawing.Size(177, 50);
            this.btn_verwijderBestelling.TabIndex = 84;
            this.btn_verwijderBestelling.Text = "Verwijder hele bestelling";
            this.btn_verwijderBestelling.UseVisualStyleBackColor = false;
            this.btn_verwijderBestelling.Click += new System.EventHandler(this.btn_verwijderGerecht_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(124, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 85;
            this.label2.Text = "Selecteer product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(527, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 86;
            this.label3.Text = "Huidige bestelling";
            // 
            // listview_huidige_bestelling
            // 
            this.listview_huidige_bestelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(246)))), ((int)(((byte)(235)))));
            this.listview_huidige_bestelling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bestelling,
            this.aantal});
            this.listview_huidige_bestelling.FullRowSelect = true;
            this.listview_huidige_bestelling.GridLines = true;
            this.listview_huidige_bestelling.Location = new System.Drawing.Point(393, 207);
            this.listview_huidige_bestelling.Name = "listview_huidige_bestelling";
            this.listview_huidige_bestelling.Size = new System.Drawing.Size(378, 238);
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
            // flow_menuCategorie
            // 
            this.flow_menuCategorie.ForeColor = System.Drawing.SystemColors.Info;
            this.flow_menuCategorie.Location = new System.Drawing.Point(10, 123);
            this.flow_menuCategorie.Name = "flow_menuCategorie";
            this.flow_menuCategorie.Size = new System.Drawing.Size(758, 57);
            this.flow_menuCategorie.TabIndex = 98;
            // 
            // flow_MenuKaart
            // 
            this.flow_MenuKaart.ForeColor = System.Drawing.SystemColors.Info;
            this.flow_MenuKaart.Location = new System.Drawing.Point(10, 64);
            this.flow_MenuKaart.Name = "flow_MenuKaart";
            this.flow_MenuKaart.Size = new System.Drawing.Size(758, 52);
            this.flow_MenuKaart.TabIndex = 99;
            // 
            // txt_opmerking
            // 
            this.txt_opmerking.Location = new System.Drawing.Point(193, 475);
            this.txt_opmerking.Multiline = true;
            this.txt_opmerking.Name = "txt_opmerking";
            this.txt_opmerking.Size = new System.Drawing.Size(470, 25);
            this.txt_opmerking.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(193, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 101;
            this.label4.Text = "Voeg een opmerking toe:";
            // 
            // checkbox_keuken
            // 
            this.checkbox_keuken.AutoSize = true;
            this.checkbox_keuken.Font = new System.Drawing.Font("Calibri", 9F);
            this.checkbox_keuken.ForeColor = System.Drawing.SystemColors.Info;
            this.checkbox_keuken.Location = new System.Drawing.Point(358, 455);
            this.checkbox_keuken.Name = "checkbox_keuken";
            this.checkbox_keuken.Size = new System.Drawing.Size(93, 18);
            this.checkbox_keuken.TabIndex = 104;
            this.checkbox_keuken.Text = "Voor keuken";
            this.checkbox_keuken.UseVisualStyleBackColor = true;

            // 
            // checkbox_bar
            // 
            this.checkbox_bar.AutoSize = true;
            this.checkbox_bar.Font = new System.Drawing.Font("Calibri", 9F);
            this.checkbox_bar.ForeColor = System.Drawing.SystemColors.Info;
            this.checkbox_bar.Location = new System.Drawing.Point(458, 455);
            this.checkbox_bar.Name = "checkbox_bar";
            this.checkbox_bar.Size = new System.Drawing.Size(71, 18);
            this.checkbox_bar.TabIndex = 105;
            this.checkbox_bar.Text = "Voor bar";
            this.checkbox_bar.UseVisualStyleBackColor = true;
            // 
            // BestellingOpnemen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(87)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(775, 502);
            this.Controls.Add(this.checkbox_bar);
            this.Controls.Add(this.checkbox_keuken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_opmerking);
            this.Controls.Add(this.flow_MenuKaart);
            this.Controls.Add(this.flow_menuCategorie);
            this.Controls.Add(this.listview_huidige_bestelling);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_verwijderBestelling);
            this.Controls.Add(this.listview_diner);
            this.Controls.Add(this.btn_stuurbestelling);
            this.Controls.Add(this.btn_DINERnaarBESTELLING);
            this.Controls.Add(this.label1);
            this.Name = "BestellingOpnemen";
            this.Text = "DinerKaart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.FlowLayoutPanel flow_menuCategorie;
        private System.Windows.Forms.FlowLayoutPanel flow_MenuKaart;
        private System.Windows.Forms.TextBox txt_opmerking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkbox_keuken;
        private System.Windows.Forms.CheckBox checkbox_bar;
    }
}