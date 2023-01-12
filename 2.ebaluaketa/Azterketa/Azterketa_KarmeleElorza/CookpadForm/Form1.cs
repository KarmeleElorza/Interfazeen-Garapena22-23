using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CookpadForm.Models;
using Microsoft.SqlServer.Server;

namespace CookpadForm
{
    public partial class CookpadForm : Form
    {
        public CookpadForm()
        {
            InitializeComponent();
        }

        private void CookpadForm_Load(object sender, EventArgs e)
        {
            using (var db = new CookpadDBContext())
            {
                var botoaData = db.Botoa
                .Include("Errezeta")
                .Where(b => b.Urtea == cBoxUrtea.Text)
                .GroupBy(b => b.Errezeta.Izena)
                .ToDictionary(g => g.Key, g => g.Count());


                if (botoaData != null)
                {
                    if (botoaData.Count > 0)
                    {
                        var kontrolak = cookpadDll1.Controls.OfType<Chart>(); foreach (var kontrola in kontrolak)
                        {
                            kontrola.DataSource = botoaData;
                            kontrola.Series[0].YValueMembers = "Value";
                            kontrola.Series[0].XValueMember = "Key";
                            kontrola.DataBind();
                        }
                    }
                }
            }
        }

        private void btnBidali_Click(object sender, EventArgs e)
        {
            string mezua = "";
            int ondo = 0;
            //nan balidatu 9 karakter direla
            if (this.txtNan.Text.Length < 9)
            {
                mezua = mezua + " Nan-ak ez du 9 karaktere.";
            }
            else
            {
                ondo++;
            }
            //izen eta ezizena hutsik ez daudela balidatu
            if (this.txtIzena.Text.Equals(""))
            {
                mezua = mezua + " Izena hutsik dago.";
               
            }
            else
            {
                ondo++;
            }
            if (this.txtEzizena.Text.Equals(""))
            {
                mezua = mezua + " Ezizena hutsik dago.";
            }
            else
            {
                ondo++;
            }
            //Emaila ez dagoela hutsik eta gutxienez @ bat duela balidatu
            if (this.txtEmaila.Text.Equals(""))
            {
                mezua = mezua + " Emaila hutsik dago.";
            }
            else
            {
                if (!this.txtEmaila.Text.Contains("@"))
                {
                    mezua = mezua + " Emailak ez du formatu egokia.";
                }
                else
                {
                    ondo++;
                }
            }
            //errezeta id ez dagoela hutsik eta zenbakia dela balidatu
            if (this.txtErrezetaId.Text.Equals(""))
            {
                mezua = mezua + " Errezeta Id-a hutsik dago.";
            }
            else
            {
                try
                {
                    int ErrezetaId = Int32.Parse(this.txtErrezetaId.Text);
                    ondo++;
                }
                catch (Exception)
                { mezua = mezua + " Errezeta Id-a ez da zenbakia."; }
            }
            if (ondo == 5)            //balidazioa ondo = izena + ,zure botoa jaso dugu, eskerrik asko.
            {
                mezua = this.txtIzena.Text + ", zure botoa jaso dugu, eskerrik asko.";
            }
            MessageBox.Show(mezua, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cBoxUrtea_TextChanged(object sender, EventArgs e)
        {
             //urtea aldatuz gero, grafikoa aldatzeko berriz urte horretako datuak hartzeko
            using (var db = new CookpadDBContext())
            {
                var botoaData = db.Botoa
                .Include("Errezeta")
                .Where(b => b.Urtea == cBoxUrtea.Text)
                .GroupBy(b => b.Errezeta.Izena)
                .ToDictionary(g => g.Key, g => g.Count());


                if (botoaData != null)
                {
                    if (botoaData.Count > 0)
                    {
                        var kontrolak = cookpadDll1.Controls.OfType<Chart>(); foreach (var kontrola in kontrolak)
                        {
                            kontrola.DataSource = botoaData;
                            kontrola.Series[0].YValueMembers = "Value";
                            kontrola.Series[0].XValueMember = "Key";
                            kontrola.DataBind();
                        }
                    }
                }
            }
        }
    }
}
