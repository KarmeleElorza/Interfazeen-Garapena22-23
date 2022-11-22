using Kaixo_DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaixoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //KaixoDLL kaixo = new KaixoDLL(); si no es static MezuaIkusi(), poner esto
            MessageBox.Show(KaixoDLL.MezuaIkusi());
        }
    }
}
