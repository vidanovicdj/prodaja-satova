using Klijent.ServerKomunikacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.SatKontroler
{
    public class SatController
    {
        private FrmUbaciSat forma;

        public SatController(FrmUbaciSat forma)
        {
            this.forma = forma;
        }
        public void UbaciSat()
        {
            if (!ValidirajSat()) return;

            Sat sat = new Sat
            {
                Brend = forma.tbxBrend.Text.Trim(),
                NazivModela = forma.tbxNazivModela.Text.Trim(),
                SifraModela = forma.tbxSifraModela.Text.Trim(),
                TipMehanizma = (TipMehanizma)forma.cbTipMehanizma.SelectedItem,
                DimenzijeKucista = double.Parse(forma.tbxDimenzijeKucista.Text.Trim()),
                Staklo = (Staklo)forma.cbStaklo.SelectedItem,
                Materijal = forma.tbxMaterijal.Text.Trim(),
                CenaSata = double.Parse(forma.tbxCenaSata.Text.Trim()),
                KolicinaNaStanju = int.Parse(forma.tbxKolicina.Text.Trim())

            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.ZapamtiSat, sat);
                MessageBox.Show("Sistem je zapamtio sat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiFormu();
            }
            catch (IOException)
            {
                MessageBox.Show("Sistem ne može da zapamti sat.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OcistiFormu()
        {
            forma.tbxBrend.Text = "";
            forma.tbxNazivModela.Text = "";
            forma.tbxSifraModela.Text = "";
            forma.tbxDimenzijeKucista.Text = "";
            forma.tbxMaterijal.Text = "";
            forma.tbxCenaSata.Text = "";
            forma.tbxKolicina.Text = "";
            forma.cbStaklo.SelectedIndex = -1;
            forma.cbTipMehanizma.SelectedIndex = -1;
        }

        private bool ValidirajSat()
        {
            if (string.IsNullOrEmpty(forma.tbxBrend.Text))
            {
                MessageBox.Show("Polje Brend je obavezno!", "Greška");
                return false;
            }
            if (string.IsNullOrEmpty(forma.tbxNazivModela.Text))
            {
                MessageBox.Show("Polje Naziv modela je obavezno!", "Greška");
                return false;
            }
            if (string.IsNullOrEmpty(forma.tbxSifraModela.Text))
            {
                MessageBox.Show("Polje Sifra modela je obavezno!", "Greška");
                return false;
            }
            if (string.IsNullOrEmpty(forma.tbxDimenzijeKucista.Text))
            {
                MessageBox.Show("Polje Dimenzije kućišta je obavezno!", "Greška");
                return false;
            }
            if(!double.TryParse(forma.tbxDimenzijeKucista.Text, out _))
            {
                MessageBox.Show("Polje Dimenzije kućišta mora biti realan broj!", "Greška");
                return false;
            }
            if (string.IsNullOrEmpty(forma.tbxMaterijal.Text))
            {
                MessageBox.Show("Polje Materijal je obavezno!", "Greška");
                return false;
            }
            if (string.IsNullOrEmpty(forma.tbxCenaSata.Text))
            {
                MessageBox.Show("Polje Cena sata je obavezno!", "Greška");
                return false;
            }
            if (!double.TryParse(forma.tbxCenaSata.Text, out _))
            {
                MessageBox.Show("Polje Cena sata mora biti realan broj!", "Greška");
                return false;
            }
            if (string.IsNullOrEmpty(forma.tbxKolicina.Text))
            {
                MessageBox.Show("Polje Količina je obavezno!", "Greška");
                return false;
            }
            if (!int.TryParse(forma.tbxKolicina.Text, out _))
            {
                MessageBox.Show("Polje Količina mora biti ceo broj!", "Greška");
                return false;
            }
            if (forma.cbStaklo.SelectedItem == null)
            {
                MessageBox.Show("Vrsta stakla mora biti izabrana.", "Greška");
                return false;
            }
            if (forma.cbTipMehanizma.SelectedItem == null)
            {
                MessageBox.Show("Tip mehanizma mora biti izabran.", "Greška");
                return false;
            }
            return true;
        }
    }
}
