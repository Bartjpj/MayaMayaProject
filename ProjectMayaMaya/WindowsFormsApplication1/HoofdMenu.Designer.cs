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
            this.btn_HMnaarKeuken = new System.Windows.Forms.Button();
            this.btn_HMnaarBediening = new System.Windows.Forms.Button();
            this.btn_HMnaarBar = new System.Windows.Forms.Button();
            this.lbl_HMtekst = new System.Windows.Forms.Label();
            this.btn_ExitWindows = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_HMnaarKeuken
            // 
            this.btn_HMnaarKeuken.BackColor = System.Drawing.Color.Maroon;
            this.btn_HMnaarKeuken.Enabled = false;
            this.btn_HMnaarKeuken.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HMnaarKeuken.ForeColor = System.Drawing.Color.White;
            this.btn_HMnaarKeuken.Location = new System.Drawing.Point(12, 187);
            this.btn_HMnaarKeuken.Name = "btn_HMnaarKeuken";
            this.btn_HMnaarKeuken.Size = new System.Drawing.Size(770, 73);
            this.btn_HMnaarKeuken.TabIndex = 0;
            this.btn_HMnaarKeuken.Text = "Keuken";
            this.btn_HMnaarKeuken.UseVisualStyleBackColor = false;
            this.btn_HMnaarKeuken.Click += new System.EventHandler(this.btn_HMnaarKeuken_Click);
            // 
            // btn_HMnaarBediening
            // 
            this.btn_HMnaarBediening.BackColor = System.Drawing.Color.Maroon;
            this.btn_HMnaarBediening.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HMnaarBediening.ForeColor = System.Drawing.Color.White;
            this.btn_HMnaarBediening.Location = new System.Drawing.Point(12, 266);
            this.btn_HMnaarBediening.Name = "btn_HMnaarBediening";
            this.btn_HMnaarBediening.Size = new System.Drawing.Size(770, 73);
            this.btn_HMnaarBediening.TabIndex = 2;
            this.btn_HMnaarBediening.Text = "Bediening";
            this.btn_HMnaarBediening.UseVisualStyleBackColor = false;
            this.btn_HMnaarBediening.Click += new System.EventHandler(this.btn_HMnaarBediening_Click);
            // 
            // btn_HMnaarBar
            // 
            this.btn_HMnaarBar.BackColor = System.Drawing.Color.Maroon;
            this.btn_HMnaarBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HMnaarBar.ForeColor = System.Drawing.Color.White;
            this.btn_HMnaarBar.Location = new System.Drawing.Point(12, 345);
            this.btn_HMnaarBar.Name = "btn_HMnaarBar";
            this.btn_HMnaarBar.Size = new System.Drawing.Size(770, 76);
            this.btn_HMnaarBar.TabIndex = 3;
            this.btn_HMnaarBar.Text = "Bar";
            this.btn_HMnaarBar.UseVisualStyleBackColor = false;
            this.btn_HMnaarBar.Click += new System.EventHandler(this.btn_HMnaarBar_Click);
            // 
            // lbl_HMtekst
            // 
            this.lbl_HMtekst.AutoSize = true;
            this.lbl_HMtekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HMtekst.Location = new System.Drawing.Point(284, 9);
            this.lbl_HMtekst.Name = "lbl_HMtekst";
            this.lbl_HMtekst.Size = new System.Drawing.Size(211, 42);
            this.lbl_HMtekst.TabIndex = 4;
            this.lbl_HMtekst.Text = "Hoofdmenu";
            // 
            // btn_ExitWindows
            // 
            this.btn_ExitWindows.Location = new System.Drawing.Point(586, 510);
            this.btn_ExitWindows.Name = "btn_ExitWindows";
            this.btn_ExitWindows.Size = new System.Drawing.Size(196, 47);
            this.btn_ExitWindows.TabIndex = 6;
            this.btn_ExitWindows.Text = "X";
            this.btn_ExitWindows.UseVisualStyleBackColor = true;
            this.btn_ExitWindows.Click += new System.EventHandler(this.btn_ExitWindows_Click);
            // 
            // HoofdMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 569);

            this.Controls.Add(this.btn_ExitWindows);
            this.Controls.Add(this.lbl_HMtekst);
            this.Controls.Add(this.btn_HMnaarBar);
            this.Controls.Add(this.btn_HMnaarBediening);
            this.Controls.Add(this.btn_HMnaarKeuken);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoofdMenu";
            this.Text = "HoofdMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HMnaarKeuken;
        private System.Windows.Forms.Button btn_HMnaarBediening;
        private System.Windows.Forms.Button btn_HMnaarBar;
        private System.Windows.Forms.Label lbl_HMtekst;
        private System.Windows.Forms.Button btn_ExitWindows;
    }
}