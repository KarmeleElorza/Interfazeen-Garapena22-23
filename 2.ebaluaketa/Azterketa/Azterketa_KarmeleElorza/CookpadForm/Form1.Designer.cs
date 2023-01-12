namespace CookpadForm
{
    partial class CookpadForm
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
            this.lblUrtea = new System.Windows.Forms.Label();
            this.cBoxUrtea = new System.Windows.Forms.ComboBox();
            this.txtNan = new System.Windows.Forms.TextBox();
            this.txtIzena = new System.Windows.Forms.TextBox();
            this.txtEmaila = new System.Windows.Forms.TextBox();
            this.txtEzizena = new System.Windows.Forms.TextBox();
            this.txtErrezetaId = new System.Windows.Forms.TextBox();
            this.btnBidali = new System.Windows.Forms.Button();
            this.cookpadDll1 = new CookpadDLL.CookpadDll();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEzizena = new System.Windows.Forms.Label();
            this.lblEmaila = new System.Windows.Forms.Label();
            this.lblIzena = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBotoa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUrtea
            // 
            this.lblUrtea.AutoSize = true;
            this.lblUrtea.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrtea.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblUrtea.Location = new System.Drawing.Point(443, 37);
            this.lblUrtea.Name = "lblUrtea";
            this.lblUrtea.Size = new System.Drawing.Size(179, 33);
            this.lblUrtea.TabIndex = 0;
            this.lblUrtea.Text = "Aukeratu urtea :";
            // 
            // cBoxUrtea
            // 
            this.cBoxUrtea.DisplayMember = "2022";
            this.cBoxUrtea.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxUrtea.ForeColor = System.Drawing.Color.Black;
            this.cBoxUrtea.FormattingEnabled = true;
            this.cBoxUrtea.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022"});
            this.cBoxUrtea.Location = new System.Drawing.Point(449, 73);
            this.cBoxUrtea.Name = "cBoxUrtea";
            this.cBoxUrtea.Size = new System.Drawing.Size(387, 36);
            this.cBoxUrtea.TabIndex = 2;
            this.cBoxUrtea.Text = "2022";
            this.cBoxUrtea.TextChanged += new System.EventHandler(this.cBoxUrtea_TextChanged);
            // 
            // txtNan
            // 
            this.txtNan.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNan.ForeColor = System.Drawing.Color.Black;
            this.txtNan.Location = new System.Drawing.Point(872, 296);
            this.txtNan.Name = "txtNan";
            this.txtNan.Size = new System.Drawing.Size(267, 36);
            this.txtNan.TabIndex = 4;
            // 
            // txtIzena
            // 
            this.txtIzena.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzena.ForeColor = System.Drawing.Color.Black;
            this.txtIzena.Location = new System.Drawing.Point(872, 351);
            this.txtIzena.Name = "txtIzena";
            this.txtIzena.Size = new System.Drawing.Size(267, 36);
            this.txtIzena.TabIndex = 6;
            // 
            // txtEmaila
            // 
            this.txtEmaila.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmaila.ForeColor = System.Drawing.Color.Black;
            this.txtEmaila.Location = new System.Drawing.Point(872, 408);
            this.txtEmaila.Name = "txtEmaila";
            this.txtEmaila.Size = new System.Drawing.Size(267, 36);
            this.txtEmaila.TabIndex = 8;
            // 
            // txtEzizena
            // 
            this.txtEzizena.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEzizena.ForeColor = System.Drawing.Color.Black;
            this.txtEzizena.Location = new System.Drawing.Point(872, 460);
            this.txtEzizena.Name = "txtEzizena";
            this.txtEzizena.Size = new System.Drawing.Size(267, 36);
            this.txtEzizena.TabIndex = 10;
            // 
            // txtErrezetaId
            // 
            this.txtErrezetaId.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrezetaId.ForeColor = System.Drawing.Color.Black;
            this.txtErrezetaId.Location = new System.Drawing.Point(872, 514);
            this.txtErrezetaId.Name = "txtErrezetaId";
            this.txtErrezetaId.Size = new System.Drawing.Size(107, 36);
            this.txtErrezetaId.TabIndex = 12;
            // 
            // btnBidali
            // 
            this.btnBidali.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBidali.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBidali.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBidali.Location = new System.Drawing.Point(901, 595);
            this.btnBidali.Name = "btnBidali";
            this.btnBidali.Size = new System.Drawing.Size(189, 45);
            this.btnBidali.TabIndex = 14;
            this.btnBidali.Text = "Botoa Bidali";
            this.btnBidali.UseVisualStyleBackColor = false;
            this.btnBidali.Click += new System.EventHandler(this.btnBidali_Click);
            // 
            // cookpadDll1
            // 
            this.cookpadDll1.Location = new System.Drawing.Point(2, 115);
            this.cookpadDll1.Name = "cookpadDll1";
            this.cookpadDll1.Size = new System.Drawing.Size(745, 579);
            this.cookpadDll1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(721, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 33);
            this.label5.TabIndex = 21;
            this.label5.Text = "Errezeta Id :";
            // 
            // lblEzizena
            // 
            this.lblEzizena.AutoSize = true;
            this.lblEzizena.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEzizena.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblEzizena.Location = new System.Drawing.Point(734, 463);
            this.lblEzizena.Name = "lblEzizena";
            this.lblEzizena.Size = new System.Drawing.Size(101, 33);
            this.lblEzizena.TabIndex = 20;
            this.lblEzizena.Text = "Ezizena :";
            // 
            // lblEmaila
            // 
            this.lblEmaila.AutoSize = true;
            this.lblEmaila.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmaila.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblEmaila.Location = new System.Drawing.Point(734, 411);
            this.lblEmaila.Name = "lblEmaila";
            this.lblEmaila.Size = new System.Drawing.Size(93, 33);
            this.lblEmaila.TabIndex = 19;
            this.lblEmaila.Text = "Emaila :";
            // 
            // lblIzena
            // 
            this.lblIzena.AutoSize = true;
            this.lblIzena.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzena.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblIzena.Location = new System.Drawing.Point(734, 354);
            this.lblIzena.Name = "lblIzena";
            this.lblIzena.Size = new System.Drawing.Size(79, 33);
            this.lblIzena.TabIndex = 18;
            this.lblIzena.Text = "Izena :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(734, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nan :";
            // 
            // lblBotoa
            // 
            this.lblBotoa.AutoSize = true;
            this.lblBotoa.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBotoa.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBotoa.Location = new System.Drawing.Point(713, 248);
            this.lblBotoa.Name = "lblBotoa";
            this.lblBotoa.Size = new System.Drawing.Size(188, 33);
            this.lblBotoa.TabIndex = 16;
            this.lblBotoa.Text = "Eman zure botoa:";
            // 
            // CookpadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 696);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEzizena);
            this.Controls.Add(this.lblEmaila);
            this.Controls.Add(this.lblIzena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBotoa);
            this.Controls.Add(this.cookpadDll1);
            this.Controls.Add(this.btnBidali);
            this.Controls.Add(this.txtErrezetaId);
            this.Controls.Add(this.txtEzizena);
            this.Controls.Add(this.txtEmaila);
            this.Controls.Add(this.txtIzena);
            this.Controls.Add(this.txtNan);
            this.Controls.Add(this.cBoxUrtea);
            this.Controls.Add(this.lblUrtea);
            this.Name = "CookpadForm";
            this.Text = "Cookpad";
            this.Load += new System.EventHandler(this.CookpadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUrtea;
        private System.Windows.Forms.ComboBox cBoxUrtea;
        private System.Windows.Forms.TextBox txtNan;
        private System.Windows.Forms.TextBox txtIzena;
        private System.Windows.Forms.TextBox txtEmaila;
        private System.Windows.Forms.TextBox txtEzizena;
        private System.Windows.Forms.TextBox txtErrezetaId;
        private System.Windows.Forms.Button btnBidali;
        private CookpadDLL.CookpadDll cookpadDll1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEzizena;
        private System.Windows.Forms.Label lblEmaila;
        private System.Windows.Forms.Label lblIzena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBotoa;
    }
}

