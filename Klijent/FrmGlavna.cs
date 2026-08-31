namespace Klijent
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void sertifikatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ubaciSatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUbaciSat frm = new FrmUbaciSat();
            frm.ShowDialog(this);
        }

        private void ubaciKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUbaciKlijenta frm = new FrmUbaciKlijenta();
            frm.ShowDialog(this);
        }

        private void pretraziKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPretraziKlijente frm = new FrmPretraziKlijente();
            frm.ShowDialog(this);
        }
    }
}
