namespace Esaldiak
{
    public partial class frmHasierakoa : Form
    {
        private Esaldia Esaldia = new Esaldia();

        public frmHasierakoa()
        {
            InitializeComponent();
        }

        private void btnItxi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            this.txtEsaldiOsoa.Text = "";
            this.Esaldia.esaldia = "";
            this.btnEsaldia1.Enabled = true;
            this.btnEsaldia2.Enabled = false;
            this.btnEsaldia3.Enabled = false;
            this.btnEsaldia4.Enabled = false;
            this.btnEsaldia5.Enabled = false;
            this.btnEsaldia6.Enabled = false;
            this.txtEsaldiOsoa.Enabled = true;
        }

        private void btnEsaldia1_Click(object sender, EventArgs e)
        {
            try
            {
                Esaldia.esaldia = Esaldia.esaldia + this.txtEsaldiOsoa.Text + " ";
                this.btnEsaldia1.Enabled = false;
                this.btnEsaldia2.Enabled = true;
                this.txtEsaldiOsoa.Text = "";
                this.txtEsaldiOsoa.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Sartu esaldia", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEsaldia2_Click(object sender, EventArgs e)
        {
            try
            {
                Esaldia.esaldia = Esaldia.esaldia + this.txtEsaldiOsoa.Text + " ";
                this.btnEsaldia2.Enabled = false;
                this.btnEsaldia3.Enabled = true;
                this.txtEsaldiOsoa.Text = "";
                this.txtEsaldiOsoa.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Sartu esaldia", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEsaldia3_Click(object sender, EventArgs e)
        {
            try
            {
                Esaldia.esaldia = Esaldia.esaldia + this.txtEsaldiOsoa.Text + " ";
                this.btnEsaldia3.Enabled = false;
                this.btnEsaldia4.Enabled = true;
                this.txtEsaldiOsoa.Text = "";
                this.txtEsaldiOsoa.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Sartu esaldia", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEsaldia4_Click(object sender, EventArgs e)
        {
            try
            {
                Esaldia.esaldia = Esaldia.esaldia + this.txtEsaldiOsoa.Text + " ";
                this.btnEsaldia4.Enabled = false;
                this.btnEsaldia5.Enabled = true;
                this.txtEsaldiOsoa.Text = "";
                this.txtEsaldiOsoa.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Sartu esaldia", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEsaldia5_Click(object sender, EventArgs e)
        {
            try
            {
                Esaldia.esaldia = Esaldia.esaldia + this.txtEsaldiOsoa.Text;
                this.btnEsaldia5.Enabled = false;
                this.btnEsaldia6.Enabled = true;
                this.txtEsaldiOsoa.Text = "";
                this.txtEsaldiOsoa.Enabled = false;
                this.btnEsaldia6.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Sartu esaldia", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEsaldia6_Click(object sender, EventArgs e)
        {
            Esaldia.esaldiakBatu();
            try
            {
                MessageBox.Show(Esaldia.esaldiBatua, "Sartutako esaldia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sartu esaldia", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void frmHasierakoa_Load(object sender, EventArgs e)
        {
           this.txtEsaldiOsoa.Focus();
        }
    }
}