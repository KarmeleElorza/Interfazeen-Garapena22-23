namespace KalkulagailuSimplea
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnGehi = new System.Windows.Forms.Button();
            this.btnKen = new System.Windows.Forms.Button();
            this.btnBider = new System.Windows.Forms.Button();
            this.btnZati = new System.Windows.Forms.Button();
            this.txtZenb = new System.Windows.Forms.TextBox();
            this.txtZenb2 = new System.Windows.Forms.TextBox();
            this.btnIrten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGehi
            // 
            this.btnGehi.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGehi.Location = new System.Drawing.Point(85, 222);
            this.btnGehi.Name = "btnGehi";
            this.btnGehi.Size = new System.Drawing.Size(56, 48);
            this.btnGehi.TabIndex = 0;
            this.btnGehi.Text = "+";
            this.btnGehi.UseVisualStyleBackColor = true;
            this.btnGehi.Click += new System.EventHandler(this.btnGehi_Click);
            // 
            // btnKen
            // 
            this.btnKen.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKen.Location = new System.Drawing.Point(223, 222);
            this.btnKen.Name = "btnKen";
            this.btnKen.Size = new System.Drawing.Size(56, 48);
            this.btnKen.TabIndex = 1;
            this.btnKen.Text = "-";
            this.btnKen.UseVisualStyleBackColor = true;
            this.btnKen.Click += new System.EventHandler(this.btnKen_Click);
            // 
            // btnBider
            // 
            this.btnBider.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBider.Location = new System.Drawing.Point(85, 306);
            this.btnBider.Name = "btnBider";
            this.btnBider.Size = new System.Drawing.Size(56, 48);
            this.btnBider.TabIndex = 2;
            this.btnBider.Text = "*";
            this.btnBider.UseVisualStyleBackColor = true;
            this.btnBider.Click += new System.EventHandler(this.btnBider_Click);
            // 
            // btnZati
            // 
            this.btnZati.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZati.Location = new System.Drawing.Point(223, 306);
            this.btnZati.Name = "btnZati";
            this.btnZati.Size = new System.Drawing.Size(56, 48);
            this.btnZati.TabIndex = 3;
            this.btnZati.Text = "/";
            this.btnZati.UseVisualStyleBackColor = true;
            this.btnZati.Click += new System.EventHandler(this.btnZati_Click);
            // 
            // txtZenb
            // 
            this.txtZenb.Location = new System.Drawing.Point(62, 100);
            this.txtZenb.Name = "txtZenb";
            this.txtZenb.Size = new System.Drawing.Size(100, 23);
            this.txtZenb.TabIndex = 4;
            this.txtZenb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZenb_KeyPress);
            // 
            // txtZenb2
            // 
            this.txtZenb2.Location = new System.Drawing.Point(200, 100);
            this.txtZenb2.Name = "txtZenb2";
            this.txtZenb2.Size = new System.Drawing.Size(100, 23);
            this.txtZenb2.TabIndex = 5;
            this.txtZenb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZenb2_KeyPress);
            // 
            // btnIrten
            // 
            this.btnIrten.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnIrten.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIrten.Location = new System.Drawing.Point(62, 389);
            this.btnIrten.Name = "btnIrten";
            this.btnIrten.Size = new System.Drawing.Size(238, 39);
            this.btnIrten.TabIndex = 6;
            this.btnIrten.Text = "Irten";
            this.btnIrten.UseVisualStyleBackColor = true;
            this.btnIrten.Click += new System.EventHandler(this.btnIrten_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.btnIrten);
            this.Controls.Add(this.txtZenb2);
            this.Controls.Add(this.txtZenb);
            this.Controls.Add(this.btnZati);
            this.Controls.Add(this.btnBider);
            this.Controls.Add(this.btnKen);
            this.Controls.Add(this.btnGehi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KALKULAGAILUA";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGehi;
        private Button btnKen;
        private Button btnBider;
        private Button btnZati;
        private TextBox txtZenb;
        private TextBox txtZenb2;
        private Button btnIrten;
    }
}