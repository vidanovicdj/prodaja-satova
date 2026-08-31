using Klijent.GUIKontroler.SertifikatKontroler;
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
    public partial class FrmUbaciSertifikat : Form
    {
        SertifikatController controller;
        public FrmUbaciSertifikat()
        {
            InitializeComponent();
            controller = new SertifikatController(this);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            controller.Ubaci();
        }
    }
}
