using Klijent.ServerKomunikacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Klijent.GUIKontroler.SertifikatKontroler
{
    public class SertifikatController
    {
        private FrmUbaciSertifikat forma;

        public SertifikatController(FrmUbaciSertifikat forma)
        {
            this.forma = forma;
        }

        public void Ubaci()
        {
            try
            {
                if (!ValidirajPodatke()) return;

                Sertifikat sertifikat = new Sertifikat()
                {
                    NazivSertifikata = forma.tbxNazivSertifikata.Text.Trim()
                };

                Communication.Instance.PosaljiZahtevBezRezultata(
                    Zajednicki.Komunikacija.Operacija.ZapamtiSertifikat, sertifikat);

                MessageBox.Show("Sistem je zapamtio sertifikat", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                OcistiFormu();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da zapamti sertifikat", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OcistiFormu()
        {
            forma.tbxNazivSertifikata.Clear();
        }

        private bool ValidirajPodatke()
        {
            if (string.IsNullOrEmpty(forma.tbxNazivSertifikata.Text))
            {
                MessageBox.Show("Polje Naziv je obavezno", "Greška");
                return false;
            }
            return true;
        }
    }
}
