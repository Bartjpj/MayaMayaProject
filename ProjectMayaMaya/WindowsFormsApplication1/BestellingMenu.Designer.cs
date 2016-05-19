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
            // BestellingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 414);
            this.Controls.Add(this.lbl_selecteerkaart);
            this.Controls.Add(this.cbox_selecteerkaart);
            this.Name = "BestellingMenu";
            this.Text = "BestellingMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox_selecteerkaart;
        private System.Windows.Forms.Label lbl_selecteerkaart;

    }
}