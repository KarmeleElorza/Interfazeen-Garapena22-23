using AginteKuadroa.Models;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AginteKuadroa
{
    public partial class frmHasierakoa : Form
    {
        public frmHasierakoa()
        {
            InitializeComponent();
        }

        private void frmHasierakoa_Load(object sender, EventArgs e)
        {

            using (var db = new SalmentaDbContext())
            {
                var bezeroaData = db.Bezeroa
                    .Include("Saltzailea")
                    .GroupBy(b => b.Saltzailea.Izena)
                    .ToDictionary(g => g.Key, g => g.Count());

                if (bezeroaData != null)
                {
                    if (bezeroaData.Count > 0)
                    {
                        chart1.DataSource = bezeroaData;
                        chart1.Series[0].YValueMembers = "Value";
                        chart1.Series[0].XValueMember = "Key";
                        chart1.DataBind();
                    }
                }
                //bigarren grafikoa
                var salmentaData = db.Salmenta
               .Include("Bezeroa")
                .GroupBy(b => b.Bezeroa.Izena)
                .ToDictionary(g => g.Key, g => g.Sum(b => b.Zenbatekoa));
                if (salmentaData != null)
                {
                    if (salmentaData.Count > 0)
                    {
                        var kontrolak = grafikoa1.Controls.OfType<Chart>(); foreach (var kontrola in kontrolak)
                        {
                            kontrola.Titles[0].Text = "SALMENTA GEHIENGO BEZEROAK";
                            kontrola.DataSource = salmentaData;
                            kontrola.Series[0].YValueMembers = "Value";
                            kontrola.Series[0].XValueMember = "Key";
                            kontrola.DataBind();
                        }
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}