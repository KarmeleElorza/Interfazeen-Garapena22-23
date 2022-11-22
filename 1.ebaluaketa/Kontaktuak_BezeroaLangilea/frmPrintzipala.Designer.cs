namespace Kontaktuak_BezeroaLangilea
{
    partial class frmPrintzipala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintzipala));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNan = new System.Windows.Forms.TextBox();
            this.txtIzena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAbizena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmaila = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbMota = new System.Windows.Forms.GroupBox();
            this.rbtnLangilea = new System.Windows.Forms.RadioButton();
            this.rbtnBezeroa = new System.Windows.Forms.RadioButton();
            this.rbtnKontaktua = new System.Windows.Forms.RadioButton();
            this.gbBezeroa = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbKategoria = new System.Windows.Forms.ComboBox();
            this.gbLangilea = new System.Windows.Forms.GroupBox();
            this.txtSegurtasunSoziala = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoldata = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGorde = new System.Windows.Forms.Button();
            this.btnIrten = new System.Windows.Forms.Button();
            this.gbMota.SuspendLayout();
            this.gbBezeroa.SuspendLayout();
            this.gbLangilea.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nan:";
            // 
            // txtNan
            // 
            this.txtNan.Location = new System.Drawing.Point(119, 39);
            this.txtNan.Name = "txtNan";
            this.txtNan.Size = new System.Drawing.Size(100, 20);
            this.txtNan.TabIndex = 1;
            // 
            // txtIzena
            // 
            this.txtIzena.Location = new System.Drawing.Point(119, 85);
            this.txtIzena.Name = "txtIzena";
            this.txtIzena.Size = new System.Drawing.Size(206, 20);
            this.txtIzena.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Izena:";
            // 
            // txtAbizena
            // 
            this.txtAbizena.Location = new System.Drawing.Point(119, 135);
            this.txtAbizena.Name = "txtAbizena";
            this.txtAbizena.Size = new System.Drawing.Size(206, 20);
            this.txtAbizena.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Abizena:";
            // 
            // txtEmaila
            // 
            this.txtEmaila.Location = new System.Drawing.Point(119, 183);
            this.txtEmaila.Name = "txtEmaila";
            this.txtEmaila.Size = new System.Drawing.Size(206, 20);
            this.txtEmaila.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Emaila:";
            // 
            // gbMota
            // 
            this.gbMota.Controls.Add(this.rbtnLangilea);
            this.gbMota.Controls.Add(this.rbtnBezeroa);
            this.gbMota.Controls.Add(this.rbtnKontaktua);
            this.gbMota.Location = new System.Drawing.Point(464, 39);
            this.gbMota.Name = "gbMota";
            this.gbMota.Size = new System.Drawing.Size(247, 164);
            this.gbMota.TabIndex = 8;
            this.gbMota.TabStop = false;
            this.gbMota.Text = "Mota";
            // 
            // rbtnLangilea
            // 
            this.rbtnLangilea.AutoSize = true;
            this.rbtnLangilea.Location = new System.Drawing.Point(16, 121);
            this.rbtnLangilea.Name = "rbtnLangilea";
            this.rbtnLangilea.Size = new System.Drawing.Size(65, 17);
            this.rbtnLangilea.TabIndex = 2;
            this.rbtnLangilea.TabStop = true;
            this.rbtnLangilea.Text = "Langilea";
            this.rbtnLangilea.UseVisualStyleBackColor = true;
            this.rbtnLangilea.CheckedChanged += new System.EventHandler(this.rbtnLangilea_CheckedChanged);
            // 
            // rbtnBezeroa
            // 
            this.rbtnBezeroa.AutoSize = true;
            this.rbtnBezeroa.Location = new System.Drawing.Point(16, 79);
            this.rbtnBezeroa.Name = "rbtnBezeroa";
            this.rbtnBezeroa.Size = new System.Drawing.Size(64, 17);
            this.rbtnBezeroa.TabIndex = 1;
            this.rbtnBezeroa.TabStop = true;
            this.rbtnBezeroa.Text = "Bezeroa";
            this.rbtnBezeroa.UseVisualStyleBackColor = true;
            this.rbtnBezeroa.CheckedChanged += new System.EventHandler(this.rbtnBezeroa_CheckedChanged);
            // 
            // rbtnKontaktua
            // 
            this.rbtnKontaktua.AutoSize = true;
            this.rbtnKontaktua.Checked = true;
            this.rbtnKontaktua.Location = new System.Drawing.Point(16, 37);
            this.rbtnKontaktua.Name = "rbtnKontaktua";
            this.rbtnKontaktua.Size = new System.Drawing.Size(74, 17);
            this.rbtnKontaktua.TabIndex = 0;
            this.rbtnKontaktua.TabStop = true;
            this.rbtnKontaktua.Text = "Kontaktua";
            this.rbtnKontaktua.UseVisualStyleBackColor = true;
            this.rbtnKontaktua.CheckedChanged += new System.EventHandler(this.rbtnKontaktua_CheckedChanged);
            // 
            // gbBezeroa
            // 
            this.gbBezeroa.Controls.Add(this.label5);
            this.gbBezeroa.Controls.Add(this.cbKategoria);
            this.gbBezeroa.Location = new System.Drawing.Point(119, 259);
            this.gbBezeroa.Name = "gbBezeroa";
            this.gbBezeroa.Size = new System.Drawing.Size(247, 138);
            this.gbBezeroa.TabIndex = 9;
            this.gbBezeroa.TabStop = false;
            this.gbBezeroa.Text = "Bezeroa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kategoria:";
            // 
            // cbKategoria
            // 
            this.cbKategoria.FormattingEnabled = true;
            this.cbKategoria.Location = new System.Drawing.Point(18, 63);
            this.cbKategoria.Name = "cbKategoria";
            this.cbKategoria.Size = new System.Drawing.Size(210, 21);
            this.cbKategoria.TabIndex = 10;
            // 
            // gbLangilea
            // 
            this.gbLangilea.Controls.Add(this.txtSegurtasunSoziala);
            this.gbLangilea.Controls.Add(this.label7);
            this.gbLangilea.Controls.Add(this.txtSoldata);
            this.gbLangilea.Controls.Add(this.label6);
            this.gbLangilea.Location = new System.Drawing.Point(464, 259);
            this.gbLangilea.Name = "gbLangilea";
            this.gbLangilea.Size = new System.Drawing.Size(247, 138);
            this.gbLangilea.TabIndex = 9;
            this.gbLangilea.TabStop = false;
            this.gbLangilea.Text = "Langilea";
            // 
            // txtSegurtasunSoziala
            // 
            this.txtSegurtasunSoziala.Location = new System.Drawing.Point(25, 99);
            this.txtSegurtasunSoziala.Name = "txtSegurtasunSoziala";
            this.txtSegurtasunSoziala.Size = new System.Drawing.Size(197, 20);
            this.txtSegurtasunSoziala.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Segurtasun soziala: ";
            // 
            // txtSoldata
            // 
            this.txtSoldata.Location = new System.Drawing.Point(92, 30);
            this.txtSoldata.Name = "txtSoldata";
            this.txtSoldata.Size = new System.Drawing.Size(100, 20);
            this.txtSoldata.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Soldata:";
            // 
            // btnGorde
            // 
            this.btnGorde.Location = new System.Drawing.Point(243, 432);
            this.btnGorde.Name = "btnGorde";
            this.btnGorde.Size = new System.Drawing.Size(92, 35);
            this.btnGorde.TabIndex = 10;
            this.btnGorde.Text = "Gorde";
            this.btnGorde.UseVisualStyleBackColor = true;
            this.btnGorde.Click += new System.EventHandler(this.btnGorde_Click);
            // 
            // btnIrten
            // 
            this.btnIrten.Location = new System.Drawing.Point(452, 432);
            this.btnIrten.Name = "btnIrten";
            this.btnIrten.Size = new System.Drawing.Size(92, 35);
            this.btnIrten.TabIndex = 12;
            this.btnIrten.Text = "Irten";
            this.btnIrten.UseVisualStyleBackColor = true;
            this.btnIrten.Click += new System.EventHandler(this.btnIrten_Click);
            // 
            // frmPrintzipala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.btnIrten);
            this.Controls.Add(this.btnGorde);
            this.Controls.Add(this.gbLangilea);
            this.Controls.Add(this.gbBezeroa);
            this.Controls.Add(this.gbMota);
            this.Controls.Add(this.txtEmaila);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAbizena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIzena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNan);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrintzipala";
            this.Text = "Kontaktuak Gehitu";
            this.Load += new System.EventHandler(this.frmHasierakoa_Load);
            this.gbMota.ResumeLayout(false);
            this.gbMota.PerformLayout();
            this.gbBezeroa.ResumeLayout(false);
            this.gbBezeroa.PerformLayout();
            this.gbLangilea.ResumeLayout(false);
            this.gbLangilea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNan;
        private System.Windows.Forms.TextBox txtIzena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAbizena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmaila;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbMota;
        private System.Windows.Forms.RadioButton rbtnLangilea;
        private System.Windows.Forms.RadioButton rbtnBezeroa;
        private System.Windows.Forms.RadioButton rbtnKontaktua;
        private System.Windows.Forms.GroupBox gbBezeroa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbKategoria;
        private System.Windows.Forms.GroupBox gbLangilea;
        private System.Windows.Forms.TextBox txtSegurtasunSoziala;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoldata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGorde;
        private System.Windows.Forms.Button btnIrten;
    }
}

