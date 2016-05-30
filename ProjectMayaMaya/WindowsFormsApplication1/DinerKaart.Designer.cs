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
            this.listbox_added_items = new System.Windows.Forms.ListBox();
            this.listview_diner = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Voorraad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_stuurbestelling = new System.Windows.Forms.Button();
            this.btn_DinerGerechtToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Diner";
            // 
            // btn_LUNCHnaarDRANKEN
            // 
            this.btn_LUNCHnaarDRANKEN.BackColor = System.Drawing.Color.Maroon;
            this.btn_LUNCHnaarDRANKEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LUNCHnaarDRANKEN.ForeColor = System.Drawing.Color.White;
            this.btn_LUNCHnaarDRANKEN.Location = new System.Drawing.Point(9, 96);
            this.btn_LUNCHnaarDRANKEN.Name = "btn_LUNCHnaarDRANKEN";
            this.btn_LUNCHnaarDRANKEN.Size = new System.Drawing.Size(754, 52);
            this.btn_LUNCHnaarDRANKEN.TabIndex = 55;
            this.btn_LUNCHnaarDRANKEN.Text = "Dranken";
            this.btn_LUNCHnaarDRANKEN.UseVisualStyleBackColor = false;
            this.btn_LUNCHnaarDRANKEN.Click += new System.EventHandler(this.btn_LUNCHnaarDRANKEN_Click);
            // 
            // btn_DINERnaarBESTELLING
            // 
            this.btn_DINERnaarBESTELLING.BackColor = System.Drawing.Color.Maroon;
            this.btn_DINERnaarBESTELLING.ForeColor = System.Drawing.Color.White;
            this.btn_DINERnaarBESTELLING.Location = new System.Drawing.Point(9, 12);
            this.btn_DINERnaarBESTELLING.Name = "btn_DINERnaarBESTELLING";
            this.btn_DINERnaarBESTELLING.Size = new System.Drawing.Size(99, 38);
            this.btn_DINERnaarBESTELLING.TabIndex = 78;
            this.btn_DINERnaarBESTELLING.Text = "Terug naar Bestelling Menu";
            this.btn_DINERnaarBESTELLING.UseVisualStyleBackColor = false;
            this.btn_DINERnaarBESTELLING.Click += new System.EventHandler(this.btn_DINERnaarBESTELLING_Click);
            // 
            // listbox_added_items
            // 
            this.listbox_added_items.FormattingEnabled = true;
            this.listbox_added_items.Items.AddRange(new object[] {
            "Totale bestelling:"});
            this.listbox_added_items.Location = new System.Drawing.Point(396, 159);
            this.listbox_added_items.Name = "listbox_added_items";
            this.listbox_added_items.Size = new System.Drawing.Size(367, 238);
            this.listbox_added_items.TabIndex = 80;
            // 
            // listview_diner
            // 
            this.listview_diner.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.Prijs,
            this.Voorraad});
            this.listview_diner.FullRowSelect = true;
            this.listview_diner.Location = new System.Drawing.Point(12, 159);
            this.listview_diner.Name = "listview_diner";
            this.listview_diner.Size = new System.Drawing.Size(378, 238);
            this.listview_diner.TabIndex = 81;
            this.listview_diner.UseCompatibleStateImageBehavior = false;
            this.listview_diner.View = System.Windows.Forms.View.Details;
            // 
            // Naam
            // 
            this.Naam.Text = "Gerecht";
            this.Naam.Width = 284;
            // 
            // Prijs
            // 
            this.Prijs.Text = "Prijs";
            this.Prijs.Width = 35;
            // 
            // Voorraad
            // 
            this.Voorraad.Text = "Voorraad";
            this.Voorraad.Width = 55;
            // 
            // btn_stuurbestelling
            // 
            this.btn_stuurbestelling.BackColor = System.Drawing.Color.LightGreen;
            this.btn_stuurbestelling.Location = new System.Drawing.Point(670, 449);
            this.btn_stuurbestelling.Name = "btn_stuurbestelling";
            this.btn_stuurbestelling.Size = new System.Drawing.Size(93, 41);
            this.btn_stuurbestelling.TabIndex = 82;
            this.btn_stuurbestelling.Text = "Stuur Bestelling";
            this.btn_stuurbestelling.UseVisualStyleBackColor = false;
            // 
            // btn_DinerGerechtToevoegen
            // 
            this.btn_DinerGerechtToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DinerGerechtToevoegen.Location = new System.Drawing.Point(71, 412);
            this.btn_DinerGerechtToevoegen.Name = "btn_DinerGerechtToevoegen";
            this.btn_DinerGerechtToevoegen.Size = new System.Drawing.Size(243, 50);
            this.btn_DinerGerechtToevoegen.TabIndex = 83;
            this.btn_DinerGerechtToevoegen.Text = "Voeg gerecht toe aan bestelling";
            this.btn_DinerGerechtToevoegen.UseVisualStyleBackColor = true;
            this.btn_DinerGerechtToevoegen.Click += new System.EventHandler(this.btn_DinerGerechtToevoegen_Click);
            // 
            // btn_stuurbestelling
            // 
            this.btn_stuurbestelling.BackColor = System.Drawing.Color.LightGreen;
            this.btn_stuurbestelling.Location = new System.Drawing.Point(670, 449);
            this.btn_stuurbestelling.Name = "btn_stuurbestelling";
            this.btn_stuurbestelling.Size = new System.Drawing.Size(93, 41);
            this.btn_stuurbestelling.TabIndex = 82;
            this.btn_stuurbestelling.Text = "Stuur Bestelling";
            this.btn_stuurbestelling.UseVisualStyleBackColor = false;
            this.btn_stuurbestelling.Click += new System.EventHandler(this.btn_stuurbestelling_Click);
            // 
            // DinerKaart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 502);
            this.Controls.Add(this.btn_DinerGerechtToevoegen);
            this.Controls.Add(this.listview_diner);
            this.Controls.Add(this.listbox_added_items);
            this.Controls.Add(this.btn_stuurbestelling);
            this.Controls.Add(this.btn_DINERnaarBESTELLING);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_LUNCHnaarDRANKEN);
            this.Name = "DinerKaart";
            this.Text = "DinerKaart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_LUNCHnaarDRANKEN;
        private System.Windows.Forms.Button btn_DINERnaarBESTELLING;
        private System.Windows.Forms.ListBox listbox_added_items;
        private System.Windows.Forms.ListView listview_diner;
        private System.Windows.Forms.Button btn_stuurbestelling;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Prijs;
        private System.Windows.Forms.ColumnHeader Voorraad;
        private System.Windows.Forms.Button btn_DinerGerechtToevoegen;
    }
}