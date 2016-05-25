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
            this.btn_BestellingMENUnaarHM = new System.Windows.Forms.Button();
            this.btn_BestellingMENUnaarTAFELOVERZICHT = new System.Windows.Forms.Button();
            this.btn_Lunchkaart = new System.Windows.Forms.Button();
            this.btn_dinerkaart = new System.Windows.Forms.Button();
            this.lbl_lijn1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_selecteerkaart
            // 
            this.lbl_selecteerkaart.AutoSize = true;
            this.lbl_selecteerkaart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selecteerkaart.Location = new System.Drawing.Point(217, 76);
            this.lbl_selecteerkaart.Name = "lbl_selecteerkaart";
            this.lbl_selecteerkaart.Size = new System.Drawing.Size(162, 25);
            this.lbl_selecteerkaart.TabIndex = 1;
            this.lbl_selecteerkaart.Text = "Kies een Menu ";
            // 
            // btn_BestellingMENUnaarHM
            // 
            this.btn_BestellingMENUnaarHM.Location = new System.Drawing.Point(117, 12);
            this.btn_BestellingMENUnaarHM.Name = "btn_BestellingMENUnaarHM";
            this.btn_BestellingMENUnaarHM.Size = new System.Drawing.Size(70, 40);
            this.btn_BestellingMENUnaarHM.TabIndex = 2;
            this.btn_BestellingMENUnaarHM.Text = "Terug naar Hoofdmenu";
            this.btn_BestellingMENUnaarHM.UseVisualStyleBackColor = true;
            this.btn_BestellingMENUnaarHM.Click += new System.EventHandler(this.btn_BestellingMENUnaarHM_Click);
            // 
            // btn_BestellingMENUnaarTAFELOVERZICHT
            // 
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Location = new System.Drawing.Point(12, 12);
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Name = "btn_BestellingMENUnaarTAFELOVERZICHT";
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Size = new System.Drawing.Size(99, 40);
            this.btn_BestellingMENUnaarTAFELOVERZICHT.TabIndex = 3;
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Text = "Terug naar TafelOverzicht";
            this.btn_BestellingMENUnaarTAFELOVERZICHT.UseVisualStyleBackColor = true;
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Click += new System.EventHandler(this.btn_BestellingMENUnaarTAFELOVERZICHT_Click);
            // 
            // btn_Lunchkaart
            // 
            this.btn_Lunchkaart.Location = new System.Drawing.Point(12, 123);
            this.btn_Lunchkaart.Name = "btn_Lunchkaart";
            this.btn_Lunchkaart.Size = new System.Drawing.Size(321, 62);
            this.btn_Lunchkaart.TabIndex = 4;
            this.btn_Lunchkaart.Text = "LUNCH";
            this.btn_Lunchkaart.UseVisualStyleBackColor = true;
            // 
            // btn_dinerkaart
            // 
            this.btn_dinerkaart.ForeColor = System.Drawing.Color.Black;
            this.btn_dinerkaart.Location = new System.Drawing.Point(12, 203);
            this.btn_dinerkaart.Name = "btn_dinerkaart";
            this.btn_dinerkaart.Size = new System.Drawing.Size(321, 63);
            this.btn_dinerkaart.TabIndex = 5;
            this.btn_dinerkaart.Text = "DINER";
            this.btn_dinerkaart.UseVisualStyleBackColor = true;
            // 
            // lbl_lijn1
            // 
            this.lbl_lijn1.AutoSize = true;
            this.lbl_lijn1.Location = new System.Drawing.Point(22, 64);
            this.lbl_lijn1.Name = "lbl_lijn1";
            this.lbl_lijn1.Size = new System.Drawing.Size(43, 13);
            this.lbl_lijn1.TabIndex = 6;
            this.lbl_lijn1.Text = "------------";
            this.lbl_lijn1.Click += new System.EventHandler(this.lbl_lijn1_Click);
            // 
            // BestellingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 418);
            this.Controls.Add(this.lbl_lijn1);
            this.Controls.Add(this.btn_dinerkaart);
            this.Controls.Add(this.btn_Lunchkaart);
            this.Controls.Add(this.btn_BestellingMENUnaarTAFELOVERZICHT);
            this.Controls.Add(this.btn_BestellingMENUnaarHM);
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
        private System.Windows.Forms.Button btn_BestellingMENUnaarHM;
        private System.Windows.Forms.Button btn_BestellingMENUnaarTAFELOVERZICHT;
        private System.Windows.Forms.Button btn_Lunchkaart;
        private System.Windows.Forms.Button btn_dinerkaart;
        private System.Windows.Forms.Label lbl_lijn1;

    }
}