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
    public class KlijentPretragaController
    {
        private FrmPretraziKlijente forma;
        private BindingList<Zajednicki.Domen.Klijent> klijenti;
        public KlijentPretragaController(FrmPretraziKlijente forma)
        {
            this.forma = forma;
            Init();
            forma.dgvKlijenti.DataSource = null;
        }

        private void Init()
        {
            try
            {
                InicijalizujDgvKlijenti(
                    Communication.Instance.PosaljiZahtevVratiRezultat<List<Zajednicki.Domen.Klijent>>(
                        Operacija.VratiListuSvihKlijenata));
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InicijalizujDgvKlijenti(List<Zajednicki.Domen.Klijent> lista)
        {
            klijenti = new BindingList<Zajednicki.Domen.Klijent>(lista);
            forma.dgvKlijenti.DataSource = klijenti;

            foreach (var col in new[] { "IdKlijenta", "PunoIme", "NazivTabele", "Vrednosti", "Uslov", "Output", "Kriterijum", "JoinUslov", "UpdateUslov", "UslovBezAlijasa" })
            {
                if (forma.dgvKlijenti.Columns.Contains(col))
                {
                    forma.dgvKlijenti.Columns[col].Visible = false;
                }
            }

            if (forma.dgvKlijenti.Columns.Contains("ImeKlijenta"))
            {
                forma.dgvKlijenti.Columns["ImeKlijenta"].HeaderText = "Ime";
            }
            if (forma.dgvKlijenti.Columns.Contains("PrezimeKlijenta"))
            {
                forma.dgvKlijenti.Columns["PrezimeKlijenta"].HeaderText = "Prezime";
            }
            if (forma.dgvKlijenti.Columns.Contains("BrojTelefona"))
            {
                forma.dgvKlijenti.Columns["BrojTelefona"].HeaderText = "Broj telefona";
            }
            if (forma.dgvKlijenti.Columns.Contains("EmailKlijenta"))
            {
                forma.dgvKlijenti.Columns["EmailKlijenta"].HeaderText = "Email adresa";
            }
            if (forma.dgvKlijenti.Columns.Contains("TipKlijenta"))
            {
                forma.dgvKlijenti.Columns["TipKlijenta"].HeaderText = "Rang klijenta";
            }

        }

        public void PretraziKlijente()
        {
            if (string.IsNullOrEmpty(forma.tbxEmailPretraga.Text))
            {
                MessageBox.Show("Niste uneli kriteriterijum za pretragu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Zajednicki.Domen.Klijent kriterijumKlijent = new Zajednicki.Domen.Klijent
                {
                    EmailKlijenta = forma.tbxEmailPretraga.Text.Trim()
                };

                InicijalizujDgvKlijenti(
                    Communication.Instance.PosaljiZahtevVratiRezultat<List<Zajednicki.Domen.Klijent>>(
                        Operacija.NadjiKlijente, kriterijumKlijent));
                MessageBox.Show("Sistem je pronašao klijente po zadatom kriterijumu.",
                    "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da pronađe klijente po zadatom kriterijumu.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PrikaziKlijente()
        {
            if(forma.dgvKlijenti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati red u tabeli.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Zajednicki.Domen.Klijent k = (Zajednicki.Domen.Klijent)forma.dgvKlijenti.SelectedRows[0].DataBoundItem;
            try
            {
                k = Communication.Instance.PosaljiZahtevVratiRezultat<Zajednicki.Domen.Klijent>(
                    Operacija.UcitajKlijente, k);

                MessageBox.Show("Sistem je našao klijenta.", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                PokreniFormu(k);

                InicijalizujDgvKlijenti(
                    Communication.Instance.PosaljiZahtevVratiRezultat<List<Zajednicki.Domen.Klijent>>(
                        Operacija.VratiListuSvihKlijenata));
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da učita klijenta.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InicijalizujDgvKlijenti(
                    Communication.Instance.PosaljiZahtevVratiRezultat<List<Zajednicki.Domen.Klijent>>(
                        Operacija.VratiListuSvihKlijenata));
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da učita klijenta.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PokreniFormu(Zajednicki.Domen.Klijent k)
        {
            FrmIzbrisiIzmeniKlijenta frm = new FrmIzbrisiIzmeniKlijenta(k);
            frm.ShowDialog();
        }
    }
}
