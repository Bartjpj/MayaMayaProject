namespace WindowsFormsApplication1
{
    partial class Inlogscherm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtbx_wachtwoord_invoer = new System.Windows.Forms.TextBox();
            this.lbl_personeelsid = new System.Windows.Forms.Label();
            this.lbl_wachtwoord = new System.Windows.Forms.Label();
            this.btn_inlog = new System.Windows.Forms.Button();
            this.btn_hoofdmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 36);
            this.textBox1.TabIndex = 0;
            // 
            // txtbx_wachtwoord_invoer
            // 
            this.txtbx_wachtwoord_invoer.Location = new System.Drawing.Point(277, 199);
            this.txtbx_wachtwoord_invoer.Multiline = true;
            this.txtbx_wachtwoord_invoer.Name = "txtbx_wachtwoord_invoer";
            this.txtbx_wachtwoord_invoer.Size = new System.Drawing.Size(200, 38);
            this.txtbx_wachtwoord_invoer.TabIndex = 1;
            this.txtbx_wachtwoord_invoer.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_personeelsid
            // 
            this.lbl_personeelsid.AutoSize = true;
            this.lbl_personeelsid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personeelsid.Location = new System.Drawing.Point(273, 103);
            this.lbl_personeelsid.Name = "lbl_personeelsid";
            this.lbl_personeelsid.Size = new System.Drawing.Size(92, 19);
            this.lbl_personeelsid.TabIndex = 2;
            this.lbl_personeelsid.Text = "PersoneelsId";
            this.lbl_personeelsid.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_wachtwoord
            // 
            this.lbl_wachtwoord.AutoSize = true;
            this.lbl_wachtwoord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wachtwoord.Location = new System.Drawing.Point(275, 177);
            this.lbl_wachtwoord.Name = "lbl_wachtwoord";
            this.lbl_wachtwoord.Size = new System.Drawing.Size(90, 19);
            this.lbl_wachtwoord.TabIndex = 3;
            this.lbl_wachtwoord.Text = "Wachtwoord";
            // 
            // btn_inlog
            // 
            this.btn_inlog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inlog.Location = new System.Drawing.Point(279, 257);
            this.btn_inlog.Name = "btn_inlog";
            this.btn_inlog.Size = new System.Drawing.Size(198, 53);
            this.btn_inlog.TabIndex = 4;
            this.btn_inlog.Text = "Inloggen";
            this.btn_inlog.UseVisualStyleBackColor = true;
            // 
            // btn_hoofdmenu
            // 
            this.btn_hoofdmenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoofdmenu.Location = new System.Drawing.Point(12, 12);
            this.btn_hoofdmenu.Name = "btn_hoofdmenu";
            this.btn_hoofdmenu.Size = new System.Drawing.Size(98, 50);
            this.btn_hoofdmenu.TabIndex = 5;
            this.btn_hoofdmenu.Text = "Hoofdmenu";
            this.btn_hoofdmenu.UseVisualStyleBackColor = true;
            this.btn_hoofdmenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inlogscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 435);
            this.Controls.Add(this.btn_hoofdmenu);
            this.Controls.Add(this.btn_inlog);
            this.Controls.Add(this.lbl_wachtwoord);
            this.Controls.Add(this.lbl_personeelsid);
            this.Controls.Add(this.txtbx_wachtwoord_invoer);
            this.Controls.Add(this.textBox1);
            this.Name = "Inlogscherm";
            this.Text = "Inlogscherm";
            this.Load += new System.EventHandler(this.Inlogscherm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtbx_wachtwoord_invoer;
        private System.Windows.Forms.Label lbl_personeelsid;
        private System.Windows.Forms.Label lbl_wachtwoord;
        private System.Windows.Forms.Button btn_inlog;
        private System.Windows.Forms.Button btn_hoofdmenu;
    }
}

