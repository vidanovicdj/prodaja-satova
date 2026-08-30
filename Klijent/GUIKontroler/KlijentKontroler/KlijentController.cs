using Klijent.ServerKomunikacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.KlijentKontroler
{
    public class KlijentController
    {
        private FrmUbaciKlijenta forma;

        public KlijentController(FrmUbaciKlijenta forma)
        {
            this.forma = forma;
            Init();
        }

        private void Init()
        {
            try
            {
                var tipoviKlijenata = Communication.Instance.PosaljiZahtevVratiRezultat<List<TipKlijenta>>(Operacija.VratiSveTipoveKlijenata);
                forma.cbTipKlijenta.DataSource = tipoviKlijenata;
                forma.cbTipKlijenta.DisplayMember = "RangKlijenta";
                forma.cbTipKlijenta.ValueMember = "IdTipaKlijenta";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UbaciKlijenta()
        {
            if (!ValidirajKlijenta()) return;

            Zajednicki.Domen.Klijent k = new Zajednicki.Domen.Klijent
            {
                ImeKlijenta = forma.tbxImeKlijenta.Text.Trim(),
                PrezimeKlijenta = forma.tbxPrezimeKlijenta.Text.Trim(),
                BrojTelefona = forma.tbxBrojTelefona.Text.Trim(),
                EmailKlijenta = forma.tbxEmailKlijenta.Text.Trim(),
                TipKlijenta = (TipKlijenta)forma.cbTipKlijenta.SelectedItem
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.ZapamtiKlijenta, k);
                MessageBox.Show("Sistem je zapamtio klijenta!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiFormu();
            }
            catch (IOException)
            {
                MessageBox.Show("Sistem ne može da zapamti klijenta", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OcistiFormu()
        {
            forma.tbxImeKlijenta.Text = "";
            forma.tbxPrezimeKlijenta.Text = "";
            forma.tbxBrojTelefona.Text = "";
            forma.tbxEmailKlijenta.Text = "";
            forma.cbTipKlijenta.SelectedIndex = -1;
        }

        private bool ValidirajKlijenta()
        {
            if (string.IsNullOrEmpty(forma.tbxImeKlijenta.Text))
            {
                MessageBox.Show("Polje Ime je obavezno", "Greška");
                return false;
            }
            if (string.IsNullOrEmpty(forma.tbxPrezimeKlijenta.Text))
            {
                MessageBox.Show("Polje Prezime je obavezno", "Greška");
                return false;
            }
            if (string.IsNullOrEmpty(forma.tbxBrojTelefona.Text))
            {
                MessageBox.Show("Polje Broj telefona je obavezno", "Greška");
                return false;
            }
            if (string.IsNullOrEmpty(forma.tbxEmailKlijenta.Text))
            {
                MessageBox.Show("Polje Email je obavezno", "Greška");
                return false;
            }
            if (forma.cbTipKlijenta.SelectedItem == null)
            {
                MessageBox.Show("Tip klijenta mora biti izabran.", "Greška");
                return false;
            }
            return true;
        }
    }
}
