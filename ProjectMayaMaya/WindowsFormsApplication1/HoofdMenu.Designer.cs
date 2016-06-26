namespace WindowsFormsApplication1
{
    partial class HoofdMenu
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
            this.btn_HMnaarBediening = new System.Windows.Forms.Button();
            this.btn_HMnaarBar = new System.Windows.Forms.Button();
            this.lbl_HMtekst = new System.Windows.Forms.Label();
            this.btn_ExitWindows = new System.Windows.Forms.Button();
            this.btn_HMnaarKEUKEN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_HMnaarBediening
            // 
            this.btn_HMnaarBediening.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.btn_HMnaarBediening.Font = new System.Drawing.Font("Calibri", 15F);
            this.btn_HMnaarBediening.ForeColor = System.Drawing.Color.White;
            this.btn_HMnaarBediening.Location = new System.Drawing.Point(21, 203);
            this.btn_HMnaarBediening.Name = "btn_HMnaarBediening";
            this.btn_HMnaarBediening.Size = new System.Drawing.Size(742, 61);
            this.btn_HMnaarBediening.TabIndex = 2;
            this.btn_HMnaarBediening.Text = "Bediening";
            this.btn_HMnaarBediening.UseVisualStyleBackColor = false;
            this.btn_HMnaarBediening.Click += new System.EventHandler(this.btn_HMnaarBediening_Click);
            // 
            // btn_HMnaarBar
            // 
            this.btn_HMnaarBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.btn_HMnaarBar.Font = new System.Drawing.Font("Calibri", 15F);
            this.btn_HMnaarBar.ForeColor = System.Drawing.Color.White;
            this.btn_HMnaarBar.Location = new System.Drawing.Point(21, 270);
            this.btn_HMnaarBar.Name = "btn_HMnaarBar";
            this.btn_HMnaarBar.Size = new System.Drawing.Size(742, 61);
            this.btn_HMnaarBar.TabIndex = 3;
            this.btn_HMnaarBar.Text = "Bar";
            this.btn_HMnaarBar.UseVisualStyleBackColor = false;
            this.btn_HMnaarBar.Click += new System.EventHandler(this.btn_HMnaarBar_Click);
            // 
            // lbl_HMtekst
            // 
            this.lbl_HMtekst.AutoSize = true;
            this.lbl_HMtekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HMtekst.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_HMtekst.Location = new System.Drawing.Point(290, 79);
            this.lbl_HMtekst.Name = "lbl_HMtekst";
            this.lbl_HMtekst.Size = new System.Drawing.Size(211, 42);
            this.lbl_HMtekst.TabIndex = 4;
            this.lbl_HMtekst.Text = "Hoofdmenu";
            // 
            // btn_ExitWindows
            // 
            this.btn_ExitWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.btn_ExitWindows.Font = new System.Drawing.Font("Calibri", 15F);
            this.btn_ExitWindows.ForeColor = System.Drawing.Color.White;
            this.btn_ExitWindows.Location = new System.Drawing.Point(652, 441);
            this.btn_ExitWindows.Name = "btn_ExitWindows";
            this.btn_ExitWindows.Size = new System.Drawing.Size(111, 49);
            this.btn_ExitWindows.TabIndex = 6;
            this.btn_ExitWindows.Text = "Exit";
            this.btn_ExitWindows.UseVisualStyleBackColor = false;
            this.btn_ExitWindows.Click += new System.EventHandler(this.btn_ExitWindows_Click);
            // 
            // btn_HMnaarKEUKEN
            // 
            this.btn_HMnaarKEUKEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.btn_HMnaarKEUKEN.Font = new System.Drawing.Font("Calibri", 15F);
            this.btn_HMnaarKEUKEN.ForeColor = System.Drawing.Color.White;
            this.btn_HMnaarKEUKEN.Location = new System.Drawing.Point(21, 136);
            this.btn_HMnaarKEUKEN.Name = "btn_HMnaarKEUKEN";
            this.btn_HMnaarKEUKEN.Size = new System.Drawing.Size(742, 61);
            this.btn_HMnaarKEUKEN.TabIndex = 7;
            this.btn_HMnaarKEUKEN.Text = "Keuken";
            this.btn_HMnaarKEUKEN.UseVisualStyleBackColor = false;
            this.btn_HMnaarKEUKEN.Click += new System.EventHandler(this.btn_HMnaarKEUKEN_Click);
            // 
            // HoofdMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 502);
            this.Controls.Add(this.btn_HMnaarKEUKEN);
            this.Controls.Add(this.btn_ExitWindows);
            this.Controls.Add(this.lbl_HMtekst);
            this.Controls.Add(this.btn_HMnaarBar);
            this.Controls.Add(this.btn_HMnaarBediening);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoofdMenu";
            this.Text = "HoofdMenu";
            this.Load += new System.EventHandler(this.HoofdMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HMnaarBediening;
        private System.Windows.Forms.Button btn_HMnaarBar;
        private System.Windows.Forms.Label lbl_HMtekst;
        private System.Windows.Forms.Button btn_ExitWindows;
        private System.Windows.Forms.Button btn_HMnaarKEUKEN;
    }
}