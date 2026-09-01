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
using Zajednicki.Domen;

namespace Klijent
{
    public partial class FrmUbaciRacun : Form
    {
        RacunController controller;
        public FrmUbaciRacun()
        {
            InitializeComponent();
            controller = new RacunController(this);
            controller.Init();
            cbNacinPlacanja.DataSource = Enum.GetValues(typeof(NacinPlacanja));
            tbxPunaCena.Text = "0";
            tbxCenaSaPopustom.Text = "0";
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            controller.DodajStavku();
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            controller.ObrisiStavku();
        }

        private void btnSacuvajRacun_Click(object sender, EventArgs e)
        {
            controller.UbaciRacun();
        }

        private void cbSatovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.PopuniPanel();
        }

        private void tbxKolicina_TextChanged(object sender, EventArgs e)
        {
            controller.IzracunajCenuStavke();
        }

        private void cbKlijenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.PopuniFormuNaOsnovuKlijenta();
        }
    }
}
