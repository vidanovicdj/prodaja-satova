using Klijent.GUIKontroler.KlijentKontroler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmPretraziKlijente : Form
    {
        KlijentPretragaController controller;
        public FrmPretraziKlijente()
        {
            InitializeComponent();
            controller = new KlijentPretragaController(this);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            controller.PretraziKlijente();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            controller.PrikaziKlijente();
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            controller.PrikaziSveKlijente();
        }

        private void FrmPretraziKlijente_Load(object sender, EventArgs e)
        {
            controller.PrikaziSveKlijente();
        }
    }
}
