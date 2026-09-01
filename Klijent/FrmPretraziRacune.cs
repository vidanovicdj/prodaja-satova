using Klijent.GUIKontroler.RacunKontroler;
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
    public partial class FrmPretraziRacune : Form
    {
        RacunPretragaController controller;
        public FrmPretraziRacune()
        {
            InitializeComponent();
            controller = new RacunPretragaController(this);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            controller.PretraziRacune();
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            controller.PrikaziSveRacune();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            controller.PrikaziJedanRacun();
        }
    }
}
