using Klijent.GUIKontroler.SatKontroler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zajednicki.Domen;

namespace Klijent
{
    public partial class FrmUbaciSat : Form
    {
        SatController controller;
        public FrmUbaciSat()
        {
            InitializeComponent();
            controller = new SatController(this);
            cbTipMehanizma.DataSource = Enum.GetValues(typeof(TipMehanizma));
            cbStaklo.DataSource = Enum.GetValues(typeof(Staklo));
        }

        private void lblBrend_Click(object sender, EventArgs e)
        {

        }

        private void btnUbaci_Click(object sender, EventArgs e)
        {
            controller.UbaciSat();
        }
    }
}
