using Klijent.Exceptions;
using Klijent.ServerKomunikacija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.KlijentKontroler
{
    public class KlijentIzmeniObrisiController
    {
        private FrmIzbrisiIzmeniKlijenta forma;
        private Zajednicki.Domen.Klijent trenutni;

        public KlijentIzmeniObrisiController(FrmIzbrisiIzmeniKlijenta forma, Zajednicki.Domen.Klijent k)
        {
            this.forma = forma;
            trenutni = k;
            Init();
        }

        private void Init()
        {
            try
            {
                var tipoviKlijenata = Communication.Instance.
                    PosaljiZahtevVratiRezultat<List<TipKlijenta>>(Operacija.VratiSveTipoveKlijenata);
                
                forma.cbTipKlijenta.DataSource = new BindingList<TipKlijenta>(tipoviKlijenata);
                forma.cbTipKlijenta.DisplayMember = "RangKlijenta";
                forma.cbTipKlijenta.ValueMember = "IdTipaKlijenta";

                if(trenutni.TipKlijenta != null)
                {
                    forma.cbTipKlijenta.SelectedValue = trenutni.TipKlijenta.IdTipaKlijenta;
                }
                forma.tbxImeKlijenta.Text = trenutni.ImeKlijenta;
                forma.tbxPrezimeKlijenta.Text = trenutni.PrezimeKlijenta;
                forma.tbxBrojTelefona.Text = trenutni.BrojTelefona;
                forma.tbxEmailKlijenta.Text = trenutni.EmailKlijenta;
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Izmeni()
        {
            if (!ValidirajKlijenta()) return;

            Zajednicki.Domen.Klijent k = new Zajednicki.Domen.Klijent
            {
                IdKlijenta = trenutni.IdKlijenta,
                ImeKlijenta = forma.tbxImeKlijenta.Text.Trim(),
                PrezimeKlijenta = forma.tbxPrezimeKlijenta.Text.Trim(),
                BrojTelefona = forma.tbxBrojTelefona.Text.Trim(),
                EmailKlijenta = forma.tbxEmailKlijenta.Text.Trim(),
                TipKlijenta = (TipKlijenta)forma.cbTipKlijenta.SelectedItem
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.IzmeniKlijenta, k);
                MessageBox.Show("Sistem je zapamtio klijenta!", "Uspeh", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                forma.Close();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da izmeni klijenta.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da izmeni klijenta.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Obrisi()
        {
            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.IzbrisiKlijenta, trenutni);
                MessageBox.Show("Sistem je obrisao klijenta!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                forma.Close();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da obriše klijenta.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da obriše klijenta.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
