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
            this.cbox_selecteerkaart = new System.Windows.Forms.ComboBox();
            this.lbl_selecteerkaart = new System.Windows.Forms.Label();
            this.btn_BestellingMENUnaarHM = new System.Windows.Forms.Button();
            this.btn_BestellingMENUnaarTAFELOVERZICHT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbox_selecteerkaart
            // 
            this.cbox_selecteerkaart.FormattingEnabled = true;
            this.cbox_selecteerkaart.Location = new System.Drawing.Point(17, 51);
            this.cbox_selecteerkaart.Name = "cbox_selecteerkaart";
            this.cbox_selecteerkaart.Size = new System.Drawing.Size(202, 21);
            this.cbox_selecteerkaart.TabIndex = 0;
            this.cbox_selecteerkaart.Text = "Selecteer Kaart";
            this.cbox_selecteerkaart.SelectedIndexChanged += new System.EventHandler(this.cbox_selecteerkaart_SelectedIndexChanged);
            this.cbox_selecteerkaart.Click += new System.EventHandler(this.cbox_selecteerkaart_Click);
            // 
            // lbl_selecteerkaart
            // 
            this.lbl_selecteerkaart.AutoSize = true;
            this.lbl_selecteerkaart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selecteerkaart.Location = new System.Drawing.Point(12, 9);
            this.lbl_selecteerkaart.Name = "lbl_selecteerkaart";
            this.lbl_selecteerkaart.Size = new System.Drawing.Size(220, 25);
            this.lbl_selecteerkaart.TabIndex = 1;
            this.lbl_selecteerkaart.Text = "Selecteer Menu Kaart";
            // 
            // btn_BestellingMENUnaarHM
            // 
            this.btn_BestellingMENUnaarHM.Location = new System.Drawing.Point(453, 364);
            this.btn_BestellingMENUnaarHM.Name = "btn_BestellingMENUnaarHM";
            this.btn_BestellingMENUnaarHM.Size = new System.Drawing.Size(188, 43);
            this.btn_BestellingMENUnaarHM.TabIndex = 2;
            this.btn_BestellingMENUnaarHM.Text = "Terug naar Hoofdmenu";
            this.btn_BestellingMENUnaarHM.UseVisualStyleBackColor = true;
            this.btn_BestellingMENUnaarHM.Click += new System.EventHandler(this.btn_BestellingMENUnaarHM_Click);
            // 
            // btn_BestellingMENUnaarTAFELOVERZICHT
            // 
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Location = new System.Drawing.Point(455, 314);
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Name = "btn_BestellingMENUnaarTAFELOVERZICHT";
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Size = new System.Drawing.Size(185, 40);
            this.btn_BestellingMENUnaarTAFELOVERZICHT.TabIndex = 3;
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Text = "Terug naar TafelOverzicht";
            this.btn_BestellingMENUnaarTAFELOVERZICHT.UseVisualStyleBackColor = true;
            this.btn_BestellingMENUnaarTAFELOVERZICHT.Click += new System.EventHandler(this.btn_BestellingMENUnaarTAFELOVERZICHT_Click);
            // 
            // BestellingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 418);
            this.Controls.Add(this.btn_BestellingMENUnaarTAFELOVERZICHT);
            this.Controls.Add(this.btn_BestellingMENUnaarHM);
            this.Controls.Add(this.lbl_selecteerkaart);
            this.Controls.Add(this.cbox_selecteerkaart);
            this.Name = "BestellingMenu";
            this.Text = "BestellingMenu";
            this.Load += new System.EventHandler(this.BestellingMenu_Load);
            this.Click += new System.EventHandler(this.cbox_selecteerkaart_SelectedIndexChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_selecteerkaart;
        private System.Windows.Forms.Label lbl_selecteerkaart;
        private System.Windows.Forms.Button btn_BestellingMENUnaarHM;
        private System.Windows.Forms.Button btn_BestellingMENUnaarTAFELOVERZICHT;

    }
}