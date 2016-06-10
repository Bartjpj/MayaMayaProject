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
            this.btn_INLOGGENnaarHM = new System.Windows.Forms.Button();
            this.btn_InloggenSkippen = new System.Windows.Forms.Button();
            this.lbl_personeelsleden = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_personeelid
            // 
            this.lbl_personeelid.AutoSize = true;
            this.lbl_personeelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personeelid.Location = new System.Drawing.Point(184, 177);
            this.lbl_personeelid.Name = "lbl_personeelid";
            this.lbl_personeelid.Size = new System.Drawing.Size(132, 24);
            this.lbl_personeelid.TabIndex = 1;
            this.lbl_personeelid.Text = "Personeels ID:";
            // 
            // txt_PersoneelsID
            // 
            this.txt_PersoneelsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PersoneelsID.Location = new System.Drawing.Point(322, 181);
            this.txt_PersoneelsID.MaxLength = 9;
            this.txt_PersoneelsID.Name = "txt_PersoneelsID";
            this.txt_PersoneelsID.PasswordChar = '*';
            this.txt_PersoneelsID.Size = new System.Drawing.Size(224, 26);
            this.txt_PersoneelsID.TabIndex = 2;
            this.txt_PersoneelsID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PersoneelsID_KeyPress);
            // 
            // btn_inloggen
            // 
            this.btn_inloggen.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_inloggen.ForeColor = System.Drawing.Color.White;
            this.btn_inloggen.Location = new System.Drawing.Point(322, 225);
            this.btn_inloggen.Name = "btn_inloggen";
            this.btn_inloggen.Size = new System.Drawing.Size(65, 35);
            this.btn_inloggen.TabIndex = 5;
            this.btn_inloggen.Text = "Inloggen";
            this.btn_inloggen.UseVisualStyleBackColor = false;
            this.btn_inloggen.Click += new System.EventHandler(this.btn_inloggen_Click);
            // 
            // btn_INLOGGENnaarHM
            // 
            this.btn_INLOGGENnaarHM.BackColor = System.Drawing.Color.Maroon;
            this.btn_INLOGGENnaarHM.ForeColor = System.Drawing.Color.White;
            this.btn_INLOGGENnaarHM.Location = new System.Drawing.Point(12, 22);
            this.btn_INLOGGENnaarHM.Name = "btn_INLOGGENnaarHM";
            this.btn_INLOGGENnaarHM.Size = new System.Drawing.Size(111, 49);
            this.btn_INLOGGENnaarHM.TabIndex = 7;
            this.btn_INLOGGENnaarHM.Text = "Terug naar Hoofdmenu";
            this.btn_INLOGGENnaarHM.UseVisualStyleBackColor = false;
            this.btn_INLOGGENnaarHM.Click += new System.EventHandler(this.btn_INLOGGENnaarHM_Click);
            // 
            // btn_InloggenSkippen
            // 
            this.btn_InloggenSkippen.BackColor = System.Drawing.Color.Maroon;
            this.btn_InloggenSkippen.ForeColor = System.Drawing.Color.White;
            this.btn_InloggenSkippen.Location = new System.Drawing.Point(455, 225);
            this.btn_InloggenSkippen.Name = "btn_InloggenSkippen";
            this.btn_InloggenSkippen.Size = new System.Drawing.Size(91, 34);
            this.btn_InloggenSkippen.TabIndex = 8;
            this.btn_InloggenSkippen.Text = "Skip inloggen";
            this.btn_InloggenSkippen.UseVisualStyleBackColor = false;
            this.btn_InloggenSkippen.Click += new System.EventHandler(this.btn_InloggenSkippen_Click);
            // 
            // lbl_personeelsleden
            // 
            this.lbl_personeelsleden.AutoSize = true;
            this.lbl_personeelsleden.Location = new System.Drawing.Point(49, 271);
            this.lbl_personeelsleden.Name = "lbl_personeelsleden";
            this.lbl_personeelsleden.Size = new System.Drawing.Size(0, 13);
            this.lbl_personeelsleden.TabIndex = 9;
            // 
            // InlogSchermBediening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 502);
            this.Controls.Add(this.lbl_personeelsleden);
            this.Controls.Add(this.btn_InloggenSkippen);
            this.Controls.Add(this.btn_INLOGGENnaarHM);
            this.Controls.Add(this.btn_inloggen);
            this.Controls.Add(this.txt_PersoneelsID);
            this.Controls.Add(this.lbl_personeelid);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btn_INLOGGENnaarHM;
        private System.Windows.Forms.Button btn_InloggenSkippen;
        private System.Windows.Forms.Label lbl_personeelsleden;
    }
}

