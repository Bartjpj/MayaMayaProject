namespace WindowsFormsApplication1
{
    partial class InlogSchermBediening
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
            this.lbl_personeelid = new System.Windows.Forms.Label();
            this.txt_PersoneelsID = new System.Windows.Forms.TextBox();
            this.btn_inloggen = new System.Windows.Forms.Button();
            this.lbl_Bedieninglogininfo = new System.Windows.Forms.Label();
            this.btn_INLOGGENnaarHM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_personeelid
            // 
            this.lbl_personeelid.AutoSize = true;
            this.lbl_personeelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personeelid.Location = new System.Drawing.Point(207, 182);
            this.lbl_personeelid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_personeelid.Name = "lbl_personeelid";
            this.lbl_personeelid.Size = new System.Drawing.Size(165, 29);
            this.lbl_personeelid.TabIndex = 1;
            this.lbl_personeelid.Text = "Personeels ID";
            // 
            // txt_PersoneelsID
            // 
            this.txt_PersoneelsID.Location = new System.Drawing.Point(207, 215);
            this.txt_PersoneelsID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_PersoneelsID.Name = "txt_PersoneelsID";
            this.txt_PersoneelsID.Size = new System.Drawing.Size(339, 22);
            this.txt_PersoneelsID.TabIndex = 2;
            this.txt_PersoneelsID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PersoneelsID_KeyPress);
            // 
            // btn_inloggen
            // 
            this.btn_inloggen.Location = new System.Drawing.Point(205, 274);
            this.btn_inloggen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_inloggen.Name = "btn_inloggen";
            this.btn_inloggen.Size = new System.Drawing.Size(217, 43);
            this.btn_inloggen.TabIndex = 5;
            this.btn_inloggen.Text = "Inloggen";
            this.btn_inloggen.UseVisualStyleBackColor = true;
            this.btn_inloggen.Click += new System.EventHandler(this.btn_inloggen_Click);
            // 
            // lbl_Bedieninglogininfo
            // 
            this.lbl_Bedieninglogininfo.AutoSize = true;
            this.lbl_Bedieninglogininfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bedieninglogininfo.Location = new System.Drawing.Point(199, 52);
            this.lbl_Bedieninglogininfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Bedieninglogininfo.Name = "lbl_Bedieninglogininfo";
            this.lbl_Bedieninglogininfo.Size = new System.Drawing.Size(384, 39);
            this.lbl_Bedieninglogininfo.TabIndex = 6;
            this.lbl_Bedieninglogininfo.Text = "Bediening hier inloggen:";
            // 
            // btn_INLOGGENnaarHM
            // 
            this.btn_INLOGGENnaarHM.Location = new System.Drawing.Point(723, 481);
            this.btn_INLOGGENnaarHM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_INLOGGENnaarHM.Name = "btn_INLOGGENnaarHM";
            this.btn_INLOGGENnaarHM.Size = new System.Drawing.Size(279, 48);
            this.btn_INLOGGENnaarHM.TabIndex = 7;
            this.btn_INLOGGENnaarHM.Text = "Terug naar Hoofdmenu";
            this.btn_INLOGGENnaarHM.UseVisualStyleBackColor = true;
            this.btn_INLOGGENnaarHM.Click += new System.EventHandler(this.btn_INLOGGENnaarHM_Click);
            // 
            // InlogSchermBediening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 619);
            this.Controls.Add(this.btn_INLOGGENnaarHM);
            this.Controls.Add(this.lbl_Bedieninglogininfo);
            this.Controls.Add(this.btn_inloggen);
            this.Controls.Add(this.txt_PersoneelsID);
            this.Controls.Add(this.lbl_personeelid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InlogSchermBediening";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InlogSchermBediening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_personeelid;
        private System.Windows.Forms.TextBox txt_PersoneelsID;
        private System.Windows.Forms.Button btn_inloggen;
        private System.Windows.Forms.Label lbl_Bedieninglogininfo;
        private System.Windows.Forms.Button btn_INLOGGENnaarHM;
    }
}

