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

namespace Klijent.GUIKontroler.RacunKontroler
{
    public class RacunPretragaController
    {
        private FrmPretraziRacune forma;
        private BindingList<Racun> racuni;

        public RacunPretragaController(FrmPretraziRacune forma)
        {
            this.forma = forma;
            Init();
            forma.dgvRacuni.DataSource = null;
        }

        private void Init()
        {
            try
            {
                InicijalizujDgvRacuni(
                    Communication.Instance.PosaljiZahtevVratiRezultat<List<Racun>>(
                        Operacija.VratiListuSvihRacuna));
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

        private void InicijalizujDgvRacuni(List<Racun> lista)
        {
            racuni = new BindingList<Racun>(lista);
            forma.dgvRacuni.DataSource = racuni;

            foreach (var col in new[] { "IdRacuna", "Prodavac", "Klijent", "NazivTabele", "Vrednosti", "Uslov", "Output", "Kriterijum", "JoinUslov", "UpdateUslov", "UslovBezAlijasa" })
            {
                if (forma.dgvRacuni.Columns.Contains(col))
                {
                    forma.dgvRacuni.Columns[col].Visible = false;
                }
            }

            if (forma.dgvRacuni.Columns.Contains("DatumIzdavanja"))
            {
                forma.dgvRacuni.Columns["DatumIzdavanja"].HeaderText = "Datum izdavanja";
            }
            if (forma.dgvRacuni.Columns.Contains("ProcenatPopusta"))
            {
                forma.dgvRacuni.Columns["ProcenatPopusta"].HeaderText = "Popust";
            }
            if (forma.dgvRacuni.Columns.Contains("IznosPunaCena"))
            {
                forma.dgvRacuni.Columns["IznosPunaCena"].HeaderText = "Pun iznos";
            }
            if (forma.dgvRacuni.Columns.Contains("IznosSaPopustom"))
            {
                forma.dgvRacuni.Columns["IznosSaPopustom"].HeaderText = "Krajnji iznos";
            }
            if (forma.dgvRacuni.Columns.Contains("NacinPlacanja"))
            {
                forma.dgvRacuni.Columns["NacinPlacanja"].HeaderText = "Način plaćanja";
            }
        }

        public void PretraziRacune()
        {
            if (string.IsNullOrEmpty(forma.tbxKriterijum.Text))
            {
                MessageBox.Show("Niste uneli kriteriterijum za pretragu.", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Racun kriterijumRacun = new Racun()
                {
                    Klijent = new Zajednicki.Domen.Klijent
                    {
                        ImeKlijenta = forma.tbxKriterijum.Text.Trim(),
                        PrezimeKlijenta = forma.tbxKriterijum.Text.Trim()
                    }
                };
                InicijalizujDgvRacuni(
                    Communication.Instance.PosaljiZahtevVratiRezultat<List<Racun>>(
                        Operacija.NadjiRacune, kriterijumRacun));

                MessageBox.Show("Sistem je našao račune po zadatom kriterijumu.",
                    "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da pronađe račune po zadatom kriterijumu.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PrikaziJedanRacun()
        {
            if(forma.dgvRacuni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati red u tabeli.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Racun racun = (Racun)forma.dgvRacuni.SelectedRows[0].DataBoundItem;

            try
            {
                racun = Communication.Instance.PosaljiZahtevVratiRezultat<Racun>(Operacija.UcitajRacune, racun);
                
                MessageBox.Show("Sistem je našao račun.", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                PokreniFormu(racun);

                InicijalizujDgvRacuni(
                    Communication.Instance.PosaljiZahtevVratiRezultat<List<Racun>>(
                        Operacija.VratiListuSvihRacuna).ToList());
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da učita račun.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InicijalizujDgvRacuni(
                    Communication.Instance.PosaljiZahtevVratiRezultat<List<Racun>>(
                        Operacija.VratiListuSvihRacuna));
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da učita račun.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PokreniFormu(Racun r)
        {
            FrmIzmeniRacun frm = new FrmIzmeniRacun(r);
            frm.ShowDialog();
        }

        public void PrikaziSveRacune()
        {
            try
            {
                InicijalizujDgvRacuni(
                    Communication.Instance.PosaljiZahtevVratiRezultat<List<Racun>>(
                        Operacija.VratiListuSvihRacuna));
                MessageBox.Show("Sistem je pronašao račune.",
                    "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da pronađe račune.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
