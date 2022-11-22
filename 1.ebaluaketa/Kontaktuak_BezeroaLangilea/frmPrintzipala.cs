using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontaktuak_BezeroaLangilea
{
    public partial class frmPrintzipala : Form
    {
        private string mezua;
        public frmPrintzipala()
        {
            InitializeComponent();
        }

        private void frmHasierakoa_Load(object sender, EventArgs e)
        {
            this.gbBezeroa.Enabled = false;
            this.gbLangilea.Enabled = false;
        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGorde_Click(object sender, EventArgs e)
        {
            if (this.rbtnBezeroa.Checked)
            {
                BezeroaSortu();
            }
            else if(this.rbtnLangilea.Checked)
            {
                LangileaSortu();
            }
            else
            {
                KontaktuaSortu();
            }
        }

        private void rbtnKontaktua_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnKontaktua.Checked)
            {
                this.gbBezeroa.Enabled = false;
                this.gbLangilea.Enabled = false;
            }
            else
            {
                this.gbBezeroa.Enabled = true;
                this.gbLangilea.Enabled = true;
            }
        }

        private void rbtnBezeroa_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnBezeroa.Checked)
            {
                this.gbLangilea.Enabled = false;
            }
            else
            {
                this.gbLangilea.Enabled = true;
            }
        }

        private void rbtnLangilea_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnLangilea.Checked)
            {
                this.gbBezeroa.Enabled = false;
            }
            else
            {
                this.gbBezeroa.Enabled = true;
            }
        }

        private void KontaktuaSortu()
        {
            try
            {
                Kontaktua kontaktua = new Kontaktua();
                kontaktua.Izena = this.txtIzena.Text;
                kontaktua.Abizena = this.txtAbizena.Text;
                kontaktua.Nan = this.txtNan.Text;
                kontaktua.Emaila = this.txtEmaila.Text;
                mezua = kontaktua.Gorde();
                MessageBox.Show(mezua);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BezeroaSortu()
        {
            try
            {
                Bezeroa bezeroa = new Bezeroa();
                bezeroa.Izena = this.txtIzena.Text;
                bezeroa.Abizena = this.txtAbizena.Text;
                bezeroa.Nan = this.txtNan.Text;
                bezeroa.Emaila = this.txtEmaila.Text;
                bezeroa.Kategoria = this.cbKategoria.Text;
                mezua = bezeroa.Gorde();
                MessageBox.Show(mezua);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LangileaSortu()
        {
            try
            {
                Langilea langilea = new Langilea();
                langilea.Izena = this.txtIzena.Text;
                langilea.Abizena = this.txtAbizena.Text;
                langilea.Nan = this.txtNan.Text;
                langilea.Emaila = this.txtEmaila.Text;
                langilea.SegurtasunSoziala = this.txtSegurtasunSoziala.Text;
                langilea.Soldata = float.Parse(this.txtSoldata.Text);
                mezua = langilea.Gorde();
                MessageBox.Show(mezua);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
