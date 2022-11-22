namespace KalkulagailuSimplea
{
    public partial class frmPrincipal : Form
    {
        private Kalkulagailua kalkulagailua = new Kalkulagailua();
        private Boolean errorea = false; 
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void btnGehi_Click(object sender, EventArgs e)
        {
            parametroakJaso();
            if (!errorea)
            {
                MessageBox.Show(kalkulagailua.Gehiketa().ToString("0.00"), "Gehiketa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void btnKen_Click(object sender, EventArgs e)
        {
            parametroakJaso();
            if (!errorea)
            {
                MessageBox.Show(kalkulagailua.Kenketa().ToString("0.00"), "Kenketa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBider_Click(object sender, EventArgs e)
        {
            parametroakJaso();
            if (!errorea)
            {
                MessageBox.Show(kalkulagailua.Biderketa().ToString("0.00"), "Biderketa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnZati_Click(object sender, EventArgs e)
        {
            parametroakJaso();
            if (!errorea)
            {
                MessageBox.Show(kalkulagailua.Zatiketa().ToString("0.00"), "Zatiketa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void parametroakJaso()
        {
            try
            {
                kalkulagailua.Zenb = float.Parse(this.txtZenb.Text);
                kalkulagailua.Zenb2 = float.Parse(this.txtZenb2.Text);
                errorea = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Errorea", "Sartu bi zenbakiak!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorea = true;
            }
        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            //this.Close();   CERRAR LA VENTANA
            Application.Exit(); //CERRAR LA APLICACION  
            
        }

        private void txtZenb_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrolaktxt(sender,e);
        }

        private void txtZenb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            kontrolaktxt(sender, e);
        }
        private void kontrolaktxt(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !e.KeyChar.Equals(",") && !e.KeyChar.Equals("."))
            {
                e.Handled = false;
                return;
            }
            else
            {
                if (e.KeyChar.Equals("."))
                {
                    e.KeyChar = ',';
                }
                e.Handled = true;
                return;
            }

            //IRAKASLIN FORMAN-----------------------------------------------------------------------------------------------------------------------------------------
            //if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Delete) && e.KeyChar != Convert.ToChar(",")) 
            //{
            //    e.Handled = true; // ebentoa kontrolatu
            //    return; // bueltatu
            //}
            //else
            //{
            //    if (e.KeyChar == Convert.ToChar(",")) // koma bada
            //    {
            //        if (this.txtZenb.Text.IndexOf(",") >= 0) // jada badago koma bat
            //        {
            //            e.Handled = true; //ebentoa kontrolatu
            //            return; //bueltatu
            //        }
            //        else
            //        {
            //            if (this.txtZenb2.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
            //            {
            //                e.Handled = true;
            //                SendKeys.Send("0,");
            //            }
            //        }
            //    }
            //}
        }
    }
} 