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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_gereedKeuken = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_KeukenNaarHoofdmenu
            // 
            this.btn_KeukenNaarHoofdmenu.Location = new System.Drawing.Point(11, 11);
            this.btn_KeukenNaarHoofdmenu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_KeukenNaarHoofdmenu.Name = "btn_KeukenNaarHoofdmenu";
            this.btn_KeukenNaarHoofdmenu.Size = new System.Drawing.Size(125, 49);
            this.btn_KeukenNaarHoofdmenu.TabIndex = 1;
            this.btn_KeukenNaarHoofdmenu.Text = "Terug naar hoofdmenu";
            this.btn_KeukenNaarHoofdmenu.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 235);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_gereedKeuken
            // 
            this.btn_gereedKeuken.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_gereedKeuken.Location = new System.Drawing.Point(605, 339);
            this.btn_gereedKeuken.Name = "btn_gereedKeuken";
            this.btn_gereedKeuken.Size = new System.Drawing.Size(133, 57);
            this.btn_gereedKeuken.TabIndex = 4;
            this.btn_gereedKeuken.Text = "Gereed";
            this.btn_gereedKeuken.UseVisualStyleBackColor = false;
            // 
            // keukenBestellingOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 408);
            this.Controls.Add(this.btn_gereedKeuken);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_OpenstaandeBestellingenKeuken);
            this.Controls.Add(this.btn_KeukenNaarHoofdmenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "keukenBestellingOverzicht";
            this.Text = "keukenBestellingOverzicht";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_KeukenNaarHoofdmenu;
        private System.Windows.Forms.Label lbl_OpenstaandeBestellingenKeuken;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_gereedKeuken;
    }
}