﻿namespace Zenbakiak_v2
{
    partial class frmZenbakiak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZenbakiak));
            this.btnI = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.txtZenb = new System.Windows.Forms.TextBox();
            this.lblZenbakia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnI
            // 
            this.btnI.Location = new System.Drawing.Point(596, 102);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(75, 23);
            this.btnI.TabIndex = 9;
            this.btnI.Text = "Irten";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnG
            // 
            this.btnG.Location = new System.Drawing.Point(357, 98);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(75, 23);
            this.btnG.TabIndex = 8;
            this.btnG.Text = "Garbitu";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnH
            // 
            this.btnH.Location = new System.Drawing.Point(131, 100);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(75, 23);
            this.btnH.TabIndex = 7;
            this.btnH.Text = "Hurrengoa";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            // 
            // txtZenb
            // 
            this.txtZenb.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtZenb.Location = new System.Drawing.Point(258, 38);
            this.txtZenb.Name = "txtZenb";
            this.txtZenb.Size = new System.Drawing.Size(414, 25);
            this.txtZenb.TabIndex = 6;
            this.txtZenb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZenb_KeyPress);
            // 
            // lblZenbakia
            // 
            this.lblZenbakia.AutoSize = true;
            this.lblZenbakia.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblZenbakia.Font = new System.Drawing.Font("Showcard Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblZenbakia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblZenbakia.Location = new System.Drawing.Point(19, 28);
            this.lblZenbakia.Name = "lblZenbakia";
            this.lblZenbakia.Size = new System.Drawing.Size(170, 35);
            this.lblZenbakia.TabIndex = 5;
            this.lblZenbakia.Text = "Zenbakia 1";
            // 
            // frmZenbakiak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 176);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.txtZenb);
            this.Controls.Add(this.lblZenbakia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmZenbakiak";
            this.Load += new System.EventHandler(this.frmZenbakiak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnI;
        private Button btnG;
        private Button btnH;
        private TextBox txtZenb;
        private Label lblZenbakia;
    }
}