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
using Zajednicki.Domen;

namespace Klijent
{
    public partial class FrmIzbrisiIzmeniKlijenta : Form
    {
        KlijentIzmeniObrisiController controller;
        public FrmIzbrisiIzmeniKlijenta(Zajednicki.Domen.Klijent k)
        {
            InitializeComponent();
            controller = new KlijentIzmeniObrisiController(this, k);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            controller.Izmeni();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            controller.Obrisi();
        }
    }
}
