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
            this.btn_INLOGnaarHM = new System.Windows.Forms.Button();
            this.lbl_personeelid = new System.Windows.Forms.Label();
            this.txt_PersoneelsID = new System.Windows.Forms.TextBox();
            this.txt_Wachtwoord = new System.Windows.Forms.TextBox();
            this.lbl_wachtwoord = new System.Windows.Forms.Label();
            this.btn_inloggen = new System.Windows.Forms.Button();
            this.lbl_Bedieninglogininfo = new System.Windows.Forms.Label();
            this.btn_INLOGGENnaarHM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_INLOGnaarHM
            // 
            this.btn_INLOGnaarHM.Location = new System.Drawing.Point(596, 453);
            this.btn_INLOGnaarHM.Name = "btn_INLOGnaarHM";
            this.btn_INLOGnaarHM.Size = new System.Drawing.Size(155, 69);
            this.btn_INLOGnaarHM.TabIndex = 0;
            this.btn_INLOGnaarHM.Text = "Terug naar Hoofdmenu";
            this.btn_INLOGnaarHM.UseVisualStyleBackColor = true;
            // 
            // lbl_personeelid
            // 
            this.lbl_personeelid.AutoSize = true;
            this.lbl_personeelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personeelid.Location = new System.Drawing.Point(155, 148);
            this.lbl_personeelid.Name = "lbl_personeelid";
            this.lbl_personeelid.Size = new System.Drawing.Size(127, 24);
            this.lbl_personeelid.TabIndex = 1;
            this.lbl_personeelid.Text = "Personeels ID";
            // 
            // txt_PersoneelsID
            // 
            this.txt_PersoneelsID.Location = new System.Drawing.Point(155, 175);
            this.txt_PersoneelsID.Name = "txt_PersoneelsID";
            this.txt_PersoneelsID.Size = new System.Drawing.Size(255, 20);
            this.txt_PersoneelsID.TabIndex = 2;
            this.txt_PersoneelsID.TextChanged += new System.EventHandler(this.txt_PersoneelsID_TextChanged);
            // 
            // txt_Wachtwoord
            // 
            this.txt_Wachtwoord.Location = new System.Drawing.Point(155, 225);
            this.txt_Wachtwoord.Name = "txt_Wachtwoord";
            this.txt_Wachtwoord.Size = new System.Drawing.Size(255, 20);
            this.txt_Wachtwoord.TabIndex = 3;
            this.txt_Wachtwoord.TextChanged += new System.EventHandler(this.txt_Wachtwoord_TextChanged);
            // 
            // lbl_wachtwoord
            // 
            this.lbl_wachtwoord.AutoSize = true;
            this.lbl_wachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wachtwoord.Location = new System.Drawing.Point(155, 198);
            this.lbl_wachtwoord.Name = "lbl_wachtwoord";
            this.lbl_wachtwoord.Size = new System.Drawing.Size(116, 24);
            this.lbl_wachtwoord.TabIndex = 4;
            this.lbl_wachtwoord.Text = "Wachtwoord";
            this.lbl_wachtwoord.Click += new System.EventHandler(this.lbl_wachtwoord_Click);
            // 
            // btn_inloggen
            // 
            this.btn_inloggen.Location = new System.Drawing.Point(155, 263);
            this.btn_inloggen.Name = "btn_inloggen";
            this.btn_inloggen.Size = new System.Drawing.Size(163, 35);
            this.btn_inloggen.TabIndex = 5;
            this.btn_inloggen.Text = "Inloggen";
            this.btn_inloggen.UseVisualStyleBackColor = true;
            this.btn_inloggen.Click += new System.EventHandler(this.btn_inloggen_Click);
            // 
            // lbl_Bedieninglogininfo
            // 
            this.lbl_Bedieninglogininfo.AutoSize = true;
            this.lbl_Bedieninglogininfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bedieninglogininfo.Location = new System.Drawing.Point(149, 42);
            this.lbl_Bedieninglogininfo.Name = "lbl_Bedieninglogininfo";
            this.lbl_Bedieninglogininfo.Size = new System.Drawing.Size(303, 31);
            this.lbl_Bedieninglogininfo.TabIndex = 6;
            this.lbl_Bedieninglogininfo.Text = "Bediening hier inloggen:";
            // 
            // btn_INLOGGENnaarHM
            // 
            this.btn_INLOGGENnaarHM.Location = new System.Drawing.Point(542, 391);
            this.btn_INLOGGENnaarHM.Name = "btn_INLOGGENnaarHM";
            this.btn_INLOGGENnaarHM.Size = new System.Drawing.Size(209, 39);
            this.btn_INLOGGENnaarHM.TabIndex = 7;
            this.btn_INLOGGENnaarHM.Text = "Terug naar Hoofdmenu";
            this.btn_INLOGGENnaarHM.UseVisualStyleBackColor = true;
            this.btn_INLOGGENnaarHM.Click += new System.EventHandler(this.btn_INLOGGENnaarHM_Click);
            // 
            // InlogSchermBediening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 442);
            this.Controls.Add(this.btn_INLOGGENnaarHM);
            this.Controls.Add(this.lbl_Bedieninglogininfo);
            this.Controls.Add(this.btn_inloggen);
            this.Controls.Add(this.lbl_wachtwoord);
            this.Controls.Add(this.txt_Wachtwoord);
            this.Controls.Add(this.txt_PersoneelsID);
            this.Controls.Add(this.lbl_personeelid);
            this.Controls.Add(this.btn_INLOGnaarHM);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InlogSchermBediening";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InlogSchermBediening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_INLOGnaarHM;
        private System.Windows.Forms.Label lbl_personeelid;
        private System.Windows.Forms.TextBox txt_PersoneelsID;
        private System.Windows.Forms.TextBox txt_Wachtwoord;
        private System.Windows.Forms.Label lbl_wachtwoord;
        private System.Windows.Forms.Button btn_inloggen;
        private System.Windows.Forms.Label lbl_Bedieninglogininfo;
        private System.Windows.Forms.Button btn_INLOGGENnaarHM;
    }
}

