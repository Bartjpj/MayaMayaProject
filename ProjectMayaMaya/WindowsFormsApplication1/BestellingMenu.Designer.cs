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
            this.btn_BestellingMENUnaarTAFELOVERZICHT = new System.Windows.Forms.Button();
            this.btn_Lunchkaart = new System.Windows.Forms.Button();
            this.btn_dinerkaart = new System.Windows.Forms.Button();
            this.btn_drankmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_selecteerkaart
            // 
            this.lbl_selecteerkaart.AutoSize = true;
            this.lbl_selecteerkaart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selecteerkaart.Location = new System.Drawing.Point(301, 104);
            this.lbl_selecteerkaart.Name = "lbl_selecteerkaart";
            this.lbl_selecteerkaart.Size = new System.Drawing.Size(162, 25);
            this.lbl_selecteerkaart.TabIndex = 1;
            this.lbl_selecteerkaart.Text = "Kies een Menu ";
            // 
            // btn_BestellingMENUnaarTAFELOVERZICHT
            // 
            this.btn_BestellingMENUnaarTAFELOVERZICHT.BackColor = System.Drawing.Color.Transparent;
            this.btn_BestellingMENUnaarTAFELOVERZICHT.ForeColor = System.Drawing.Color.Black;
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Location = new System.Drawing.Point(12, 12);
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Name = "btn_BestellingMENUnaarTAFELOVERZICHT";
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Size = new System.Drawing.Size(134, 40);
            this.btn_BestellingMENUnaarTAFELOVERZICHT.TabIndex = 3;
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Text = "Terug naar TafelOverzicht";
            this.btn_BestellingMENUnaarTAFELOVERZICHT.UseVisualStyleBackColor = false;
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Click += new System.EventHandler(this.btn_BestellingMENUnaarTAFELOVERZICHT_Click);
            // 
            // btn_Lunchkaart
            // 
            this.btn_Lunchkaart.BackColor = System.Drawing.Color.Maroon;
            this.btn_Lunchkaart.ForeColor = System.Drawing.Color.White;
            this.btn_Lunchkaart.Location = new System.Drawing.Point(12, 146);
            this.btn_Lunchkaart.Name = "btn_Lunchkaart";
            this.btn_Lunchkaart.Size = new System.Drawing.Size(751, 62);
            this.btn_Lunchkaart.TabIndex = 4;
            this.btn_Lunchkaart.Text = "LUNCH";
            this.btn_Lunchkaart.UseVisualStyleBackColor = false;
            this.btn_Lunchkaart.Click += new System.EventHandler(this.btn_Lunchkaart_Click);
            // 
            // btn_dinerkaart
            // 
            this.btn_dinerkaart.BackColor = System.Drawing.Color.Maroon;
            this.btn_dinerkaart.ForeColor = System.Drawing.Color.White;
            this.btn_dinerkaart.Location = new System.Drawing.Point(12, 214);
            this.btn_dinerkaart.Name = "btn_dinerkaart";
            this.btn_dinerkaart.Size = new System.Drawing.Size(751, 63);
            this.btn_dinerkaart.TabIndex = 5;
            this.btn_dinerkaart.Text = "DINER";
            this.btn_dinerkaart.UseVisualStyleBackColor = false;
            this.btn_dinerkaart.Click += new System.EventHandler(this.btn_dinerkaart_Click);
            // 
            // btn_drankmenu
            // 
            this.btn_drankmenu.BackColor = System.Drawing.Color.Maroon;
            this.btn_drankmenu.ForeColor = System.Drawing.Color.White;
            this.btn_drankmenu.Location = new System.Drawing.Point(12, 283);
            this.btn_drankmenu.Name = "btn_drankmenu";
            this.btn_drankmenu.Size = new System.Drawing.Size(751, 63);
            this.btn_drankmenu.TabIndex = 25;
            this.btn_drankmenu.Text = "DRANKEN";
            this.btn_drankmenu.UseVisualStyleBackColor = false;
            this.btn_drankmenu.Click += new System.EventHandler(this.btn_drankmenu_Click);
            // 
            // BestellingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 502);
            this.Controls.Add(this.btn_drankmenu);
            this.Controls.Add(this.btn_dinerkaart);
            this.Controls.Add(this.btn_Lunchkaart);
            this.Controls.Add(this.btn_BestellingMENUnaarTAFELOVERZICHT);
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
        private System.Windows.Forms.Button btn_BestellingMENUnaarTAFELOVERZICHT;
        private System.Windows.Forms.Button btn_Lunchkaart;
        private System.Windows.Forms.Button btn_dinerkaart;
        private System.Windows.Forms.Button btn_drankmenu;

    }
}