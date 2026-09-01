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
    public partial class FrmIzmeniRacun : Form
    {
        RacunIzmeniController controller;
        public FrmIzmeniRacun(Racun r)
        {
            InitializeComponent();
            controller = new RacunIzmeniController(this, r);
            controller.Init();
            cbNacinPlacanja.DataSource = Enum.GetValues(typeof(NacinPlacanja));
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            controller.DodajStavku();
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            controller.ObrisiStavku();
        }

        private void btnIzmeniRacun_Click(object sender, EventArgs e)
        {
            controller.Izmeni();
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
