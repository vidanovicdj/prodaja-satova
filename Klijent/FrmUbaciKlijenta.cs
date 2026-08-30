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
    public partial class FrmUbaciKlijenta : Form
    {
        private KlijentController controller;
        public FrmUbaciKlijenta()
        {
            InitializeComponent();
            controller = new KlijentController(this);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            controller.UbaciKlijenta();
        }
    }
}
