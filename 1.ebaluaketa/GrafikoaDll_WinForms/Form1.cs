using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafikoaDll_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Datua> datuak = new List<Datua>();
            datuak.Add(new Datua() { gakoa = "a", balioa = 90});
            datuak.Add(new Datua() { gakoa = "b", balioa = 43 });
            datuak.Add(new Datua() { gakoa = "c", balioa = 10 });
            var kontrolak = grafikoa1.Controls.OfType<System.Windows.Forms.DataVisualization.Charting.Chart>();

            foreach(var kontrola in kontrolak)
            {
                kontrola.Titles[0].Text = "HELMUGA TURISTIKO NAGUSIAK";
                kontrola.DataSource = datuak;
                kontrola.Series[0].YValueMembers = "balioa";
                kontrola.Series[0].XValueMember = "gakoa";
                kontrola.DataBind();
            }

        }

        private void grafikoa1_Load(object sender, EventArgs e)
        {

        }
    }
}
