namespace KaixoMundua
{
    public partial class frmKaixoMundua : Form
    {
        public frmKaixoMundua()
        {
            InitializeComponent();
        }
        public void frmKaixoMundua_Load(Object sender, EventArgs e)
        {
            
        }
        public void btnItxi_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaixo Mundua", "Egun on", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}