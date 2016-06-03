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
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 56;
            this.label1.Text = "Bestelling opnemen";
            // 
            // btn_LUNCHnaarDRANKEN
            // 
            this.btn_LUNCHnaarDRANKEN.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_LUNCHnaarDRANKEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LUNCHnaarDRANKEN.ForeColor = System.Drawing.Color.White;
            this.btn_LUNCHnaarDRANKEN.Location = new System.Drawing.Point(13, 79);
            this.btn_LUNCHnaarDRANKEN.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LUNCHnaarDRANKEN.Name = "btn_LUNCHnaarDRANKEN";
            this.btn_LUNCHnaarDRANKEN.Size = new System.Drawing.Size(317, 64);
            this.btn_LUNCHnaarDRANKEN.TabIndex = 55;
            this.btn_LUNCHnaarDRANKEN.Text = "Dranken";
            this.btn_LUNCHnaarDRANKEN.UseVisualStyleBackColor = false;
            this.btn_LUNCHnaarDRANKEN.Click += new System.EventHandler(this.btn_LUNCHnaarDRANKEN_Click);
            // 
            // btn_DINERnaarBESTELLING
            // 
            this.btn_DINERnaarBESTELLING.BackColor = System.Drawing.Color.Maroon;
            this.btn_DINERnaarBESTELLING.ForeColor = System.Drawing.Color.White;
            this.btn_DINERnaarBESTELLING.Location = new System.Drawing.Point(13, 11);
            this.btn_DINERnaarBESTELLING.Margin = new System.Windows.Forms.Padding(4);
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
            this.listview_diner.Location = new System.Drawing.Point(13, 255);
            this.listview_diner.Margin = new System.Windows.Forms.Padding(4);
            this.listview_diner.Name = "listview_diner";
            this.listview_diner.Size = new System.Drawing.Size(503, 292);
            this.listview_diner.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listview_diner.TabIndex = 81;
            this.listview_diner.UseCompatibleStateImageBehavior = false;
            this.listview_diner.View = System.Windows.Forms.View.Details;
            this.listview_diner.SelectedIndexChanged += new System.EventHandler(this.listview_diner_SelectedIndexChanged);
            // 
            // btn_stuurbestelling
            // 
            this.btn_stuurbestelling.BackColor = System.Drawing.Color.LightGreen;
            this.btn_stuurbestelling.Location = new System.Drawing.Point(896, 565);
            this.btn_stuurbestelling.Margin = new System.Windows.Forms.Padding(4);
            this.btn_stuurbestelling.Name = "btn_stuurbestelling";
            this.btn_stuurbestelling.Size = new System.Drawing.Size(124, 50);
            this.btn_stuurbestelling.TabIndex = 82;
            this.btn_stuurbestelling.Text = "Stuur Bestelling";
            this.btn_stuurbestelling.UseVisualStyleBackColor = false;
            // 
            // btn_verwijderBestelling
            // 
            this.btn_verwijderBestelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verwijderBestelling.Location = new System.Drawing.Point(540, 553);
            this.btn_verwijderBestelling.Margin = new System.Windows.Forms.Padding(4);
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
            this.label2.Location = new System.Drawing.Point(166, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 26);
            this.label2.TabIndex = 85;
            this.label2.Text = "Dinerkaart Gerechten";
            // 
            // btn_stuurbestelling
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(703, 225);
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
            this.listview_huidige_bestelling.Location = new System.Drawing.Point(524, 255);
            this.listview_huidige_bestelling.Margin = new System.Windows.Forms.Padding(4);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(872, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 37);
            this.button1.TabIndex = 88;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.YellowGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(13, 151);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 64);
            this.button4.TabIndex = 91;
            this.button4.Text = "Dranken";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.YellowGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(200, 151);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 64);
            this.button5.TabIndex = 92;
            this.button5.Text = "Dranken";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.YellowGreen;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(395, 151);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 64);
            this.button6.TabIndex = 93;
            this.button6.Text = "Dranken";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.YellowGreen;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(590, 151);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(213, 64);
            this.button7.TabIndex = 94;
            this.button7.Text = "Dranken";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.YellowGreen;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(811, 151);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(213, 64);
            this.button8.TabIndex = 95;
            this.button8.Text = "Dranken";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(703, 79);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(321, 64);
            this.button2.TabIndex = 96;
            this.button2.Text = "Dranken";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(357, 79);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(317, 64);
            this.button3.TabIndex = 97;
            this.button3.Text = "Dranken";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // DinerKaart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 618);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listview_huidige_bestelling);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_verwijderBestelling);
            this.Controls.Add(this.listview_diner);
            this.Controls.Add(this.btn_stuurbestelling);
            this.Controls.Add(this.btn_DINERnaarBESTELLING);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_LUNCHnaarDRANKEN);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}