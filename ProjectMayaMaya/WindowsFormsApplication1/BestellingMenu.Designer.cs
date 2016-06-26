namespace WindowsFormsApplication1
{
    partial class BestellingMenu
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
            this.lbl_selecteerkaart = new System.Windows.Forms.Label();
            this.btn_BestellingMENUnaarKIESMENU = new System.Windows.Forms.Button();
            this.btn_Lunchkaart = new System.Windows.Forms.Button();
            this.btn_dinerkaart = new System.Windows.Forms.Button();
            this.btn_drankmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_selecteerkaart
            // 
            this.lbl_selecteerkaart.AutoSize = true;
            this.lbl_selecteerkaart.Font = new System.Drawing.Font("Calibri", 18F);
            this.lbl_selecteerkaart.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_selecteerkaart.Location = new System.Drawing.Point(311, 100);
            this.lbl_selecteerkaart.Name = "lbl_selecteerkaart";
            this.lbl_selecteerkaart.Size = new System.Drawing.Size(161, 29);
            this.lbl_selecteerkaart.TabIndex = 1;
            this.lbl_selecteerkaart.Text = "Kies een menu ";
            // 
            // btn_BestellingMENUnaarKIESMENU
            // 
            this.btn_BestellingMENUnaarKIESMENU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.btn_BestellingMENUnaarKIESMENU.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_BestellingMENUnaarKIESMENU.ForeColor = System.Drawing.Color.White;
            this.btn_BestellingMENUnaarKIESMENU.Location = new System.Drawing.Point(12, 12);
            this.btn_BestellingMENUnaarKIESMENU.Name = "btn_BestellingMENUnaarKIESMENU";
            this.btn_BestellingMENUnaarKIESMENU.Size = new System.Drawing.Size(111, 49);
            this.btn_BestellingMENUnaarKIESMENU.TabIndex = 3;
            this.btn_BestellingMENUnaarKIESMENU.Text = "Terug naar Kies Opname";
            this.btn_BestellingMENUnaarKIESMENU.UseVisualStyleBackColor = false;
            this.btn_BestellingMENUnaarKIESMENU.Click += new System.EventHandler(this.btn_BestellingMENUnaarTAFELOVERZICHT_Click);
            // 
            // btn_Lunchkaart
            // 
            this.btn_Lunchkaart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.btn_Lunchkaart.Font = new System.Drawing.Font("Calibri", 15F);
            this.btn_Lunchkaart.ForeColor = System.Drawing.Color.White;
            this.btn_Lunchkaart.Location = new System.Drawing.Point(12, 146);
            this.btn_Lunchkaart.Name = "btn_Lunchkaart";
            this.btn_Lunchkaart.Size = new System.Drawing.Size(751, 62);
            this.btn_Lunchkaart.TabIndex = 4;
            this.btn_Lunchkaart.Text = "Lunch";
            this.btn_Lunchkaart.UseVisualStyleBackColor = false;
            this.btn_Lunchkaart.Click += new System.EventHandler(this.btn_Lunchkaart_Click);
            // 
            // btn_dinerkaart
            // 
            this.btn_dinerkaart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.btn_dinerkaart.Font = new System.Drawing.Font("Calibri", 15F);
            this.btn_dinerkaart.ForeColor = System.Drawing.Color.White;
            this.btn_dinerkaart.Location = new System.Drawing.Point(12, 214);
            this.btn_dinerkaart.Name = "btn_dinerkaart";
            this.btn_dinerkaart.Size = new System.Drawing.Size(751, 63);
            this.btn_dinerkaart.TabIndex = 5;
            this.btn_dinerkaart.Text = "Diner";
            this.btn_dinerkaart.UseVisualStyleBackColor = false;
            this.btn_dinerkaart.Click += new System.EventHandler(this.btn_dinerkaart_Click);
            // 
            // btn_drankmenu
            // 
            this.btn_drankmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.btn_drankmenu.Font = new System.Drawing.Font("Calibri", 15F);
            this.btn_drankmenu.ForeColor = System.Drawing.Color.White;
            this.btn_drankmenu.Location = new System.Drawing.Point(12, 283);
            this.btn_drankmenu.Name = "btn_drankmenu";
            this.btn_drankmenu.Size = new System.Drawing.Size(751, 63);
            this.btn_drankmenu.TabIndex = 25;
            this.btn_drankmenu.Text = "Dranken";
            this.btn_drankmenu.UseVisualStyleBackColor = false;
            // 
            // BestellingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(87)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(775, 502);
            this.Controls.Add(this.btn_drankmenu);
            this.Controls.Add(this.btn_dinerkaart);
            this.Controls.Add(this.btn_Lunchkaart);
            this.Controls.Add(this.btn_BestellingMENUnaarKIESMENU);
            this.Controls.Add(this.lbl_selecteerkaart);
            this.Name = "BestellingMenu";
            this.Text = "BestellingMenu";
            this.Load += new System.EventHandler(this.BestellingMenu_Load);
            this.Click += new System.EventHandler(this.cbox_selecteerkaart_SelectedIndexChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_selecteerkaart;
        private System.Windows.Forms.Button btn_BestellingMENUnaarKIESMENU;
        private System.Windows.Forms.Button btn_Lunchkaart;
        private System.Windows.Forms.Button btn_dinerkaart;
        private System.Windows.Forms.Button btn_drankmenu;

    }
}