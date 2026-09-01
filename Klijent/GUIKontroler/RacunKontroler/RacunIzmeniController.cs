using Klijent.Exceptions;
using Klijent.ServerKomunikacija;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.RacunKontroler
{
    public class RacunIzmeniController
    {
        private FrmIzmeniRacun forma;
        private Racun trenutniRacun;

        public RacunIzmeniController(FrmIzmeniRacun forma, Racun racun)
        {
            this.forma = forma;
            trenutniRacun = racun;
            if(trenutniRacun.StavkeZaBrisanje == null)
            {
                trenutniRacun.StavkeZaBrisanje = new List<StavkaRacuna>();
            }
        }

        public void Init()
        {
            try
            {
                forma.cbProdavci.DataSource = Communication.Instance.
                    PosaljiZahtevVratiRezultat<List<Prodavac>>(Operacija.VratiListuSvihProdavaca);
                forma.cbKlijenti.DataSource = Communication.Instance.
                    PosaljiZahtevVratiRezultat<List<Zajednicki.Domen.Klijent>>(
                    Operacija.VratiListuSvihKlijenata);
                forma.cbSatovi.DataSource = Communication.Instance.
                    PosaljiZahtevVratiRezultat<List<Sat>>(Operacija.VratiListuSvihSatova);

                forma.cbProdavci.DisplayMember = "PunoIme";
                forma.cbKlijenti.DisplayMember = "PunoIme";
                forma.cbSatovi.DisplayMember = "ModelSata";

                forma.cbProdavci.Text = trenutniRacun.Prodavac.PunoIme;
                forma.cbKlijenti.Text = trenutniRacun.Klijent.PunoIme;
                forma.dtpDatumIzdavanja.Value = trenutniRacun.DatumIzdavanja;
                forma.tbxPunaCena.Text = trenutniRacun.IznosPunaCena.ToString("F2", CultureInfo.InvariantCulture);
                forma.tbxProcenatPopusta.Text = trenutniRacun.ProcenatPopusta.ToString("F2", CultureInfo.InvariantCulture);
                forma.tbxCenaSaPopustom.Text = trenutniRacun.IznosSaPopustom.ToString("F2", CultureInfo.InvariantCulture);
                forma.cbNacinPlacanja.Text = trenutniRacun.NacinPlacanja.ToString();

                forma.dgvStavke.DataSource = trenutniRacun.Stavke;

                SakrijNepotrebneKolone();
            }
            catch (ServerCommunicationException sce)
            {
                MessageBox.Show(sce.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void SakrijNepotrebneKolone()
        {
            if (forma.dgvStavke.Columns.Count == 0) return;

            foreach (var col in new[] { "IdRacuna", "RbStavkeRacuna", "NazivTabele", "Vrednosti", "Uslov", "Output", "Kriterijum", "JoinUslov", "UpdateUslov", "UslovBezAlijasa" })
            {
                if (forma.dgvStavke.Columns.Contains(col))
                {
                    forma.dgvStavke.Columns[col].Visible = false;
                }
            }

            forma.dgvStavke.Columns["Sat"].DisplayIndex = 0;
            forma.dgvStavke.Columns["JedinicnaCena"].DisplayIndex = 1;
            forma.dgvStavke.Columns["Kolicina"].DisplayIndex = 2;
            forma.dgvStavke.Columns["CenaStavke"].DisplayIndex = 3;

            forma.dgvStavke.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            forma.dgvStavke.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            forma.dgvStavke.Columns["Kolicina"].HeaderText = "Količina";
            forma.dgvStavke.Columns["JedinicnaCena"].HeaderText = "Jedinična cena";
            forma.dgvStavke.Columns["CenaStavke"].HeaderText = "Cena stavke";
        }

        public void DodajStavku()
        {
            Sat selektovanSat = (Sat)forma.cbSatovi.SelectedItem;
            if (selektovanSat == null) return;

            if (!int.TryParse(forma.tbxKolicina.Text, out int kolicina) || kolicina <= 0)
            {
                MessageBox.Show("Polje Količina mora biti ceo broj!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (kolicina > selektovanSat.KolicinaNaStanju)
            {
                MessageBox.Show("Količina zaliha ne sme spasti ispod 0! Nemate dovoljno satova na stanju.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double iznosStavke = kolicina * selektovanSat.CenaSata;

            StavkaRacuna sr = new StavkaRacuna()
            {
                RbStavkeRacuna = 0,
                IdRacuna = trenutniRacun.IdRacuna,
                Sat = selektovanSat,
                Kolicina = kolicina,
                JedinicnaCena = selektovanSat.CenaSata,
                CenaStavke = iznosStavke
            };

            trenutniRacun.Stavke.Add(sr);
            selektovanSat.KolicinaNaStanju -= 1;

            forma.dgvStavke.DataSource = null;
            forma.dgvStavke.DataSource = trenutniRacun.Stavke;

            IzracunajCenuRacuna();

            SakrijNepotrebneKolone();
            OcistiPanel();
        }

        private void OcistiPanel()
        {
            forma.cbSatovi.SelectedIndex = -1;
            forma.tbxJedinicnaCena.Clear();
            forma.tbxKolicina.Clear();
            forma.tbxCenaStavke.Clear();
        }

        private void IzracunajCenuRacuna()
        {
            if (!double.TryParse(forma.tbxProcenatPopusta.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double popust)) return;
            //if (!double.TryParse(forma.tbxPunaCena.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double punaCena)) return;
            double punaCena = 0;

            foreach (var stavka in trenutniRacun.Stavke)
            {
                punaCena += stavka.CenaStavke;
            }

            double cenaSaPopustom = punaCena * (1 - popust);

            forma.tbxPunaCena.Text = punaCena.ToString("F2", CultureInfo.InvariantCulture);
            forma.tbxCenaSaPopustom.Text = cenaSaPopustom.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void ObrisiStavku()
        {
            if (trenutniRacun.Stavke.Count == 0)
            {
                MessageBox.Show("Nema stavki za brisanje.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (forma.dgvStavke.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali stavku za brisanje", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StavkaRacuna selektovana = (StavkaRacuna)forma.dgvStavke.SelectedRows[0].DataBoundItem;

            if(selektovana.RbStavkeRacuna != 0)
            {
                trenutniRacun.StavkeZaBrisanje.Add(selektovana);
            }

            trenutniRacun.Stavke.Remove(selektovana);
            selektovana.Sat.KolicinaNaStanju += selektovana.Kolicina;

            forma.dgvStavke.DataSource = null;
            forma.dgvStavke.DataSource = trenutniRacun.Stavke;
            SakrijNepotrebneKolone();
            IzracunajCenuRacuna();
        }

        public void Izmeni()
        {
            if (!ValidirajPodatke()) return;

            Prodavac p = (Prodavac)forma.cbProdavci.SelectedItem;
            Zajednicki.Domen.Klijent kl = (Zajednicki.Domen.Klijent)forma.cbKlijenti.SelectedItem;
            DateTime datumIzdavanja = forma.dtpDatumIzdavanja.Value.Date;

            double popust = kl.TipKlijenta.Pogodnost;
            double iznosPunaCena = 0;
            foreach (StavkaRacuna s in trenutniRacun.Stavke)
            {
                iznosPunaCena += s.CenaStavke;
            }
            double iznosSaPopustom = iznosPunaCena * (1 - popust);

            Racun racun = new Racun()
            {
                IdRacuna = trenutniRacun.IdRacuna,
                Klijent = kl,
                Prodavac = p,
                DatumIzdavanja = datumIzdavanja,
                ProcenatPopusta = popust,
                IznosPunaCena = iznosPunaCena,
                IznosSaPopustom = iznosSaPopustom,
                NacinPlacanja = (NacinPlacanja)forma.cbNacinPlacanja.SelectedItem,
                Stavke = trenutniRacun.Stavke.ToList()
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.IzmeniRacun, racun);

                MessageBox.Show("Sistem je izmenio račun!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                forma.Close();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da izmeni račun.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool ValidirajPodatke()
        {
            if (trenutniRacun.Stavke.Count == 0)
            {
                MessageBox.Show("Račun mora imati bar jednu stavku!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (forma.cbProdavci.SelectedItem == null)
            {
                MessageBox.Show("Polje Prodavac je obavezno!", "Greška");
                return false;
            }
            if (forma.cbKlijenti.SelectedItem == null)
            {
                MessageBox.Show("Polje Klijent je obavezno!", "Greška");
                return false;
            }
            if (forma.cbNacinPlacanja.SelectedItem == null)
            {
                MessageBox.Show("Polje Način plaćanja je obavezno!", "Greška");
                return false;
            }
            return true;
        }

        public void PopuniPanel()
        {
            Sat trenutniSat = (Sat)forma.cbSatovi.SelectedItem;
            if (trenutniSat == null) return;

            forma.tbxJedinicnaCena.Text = trenutniSat.CenaSata.ToString("F2", CultureInfo.InvariantCulture);
            forma.tbxCenaStavke.Text = trenutniSat.CenaSata.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void IzracunajCenuStavke()
        {
            if (!int.TryParse(forma.tbxKolicina.Text, out int kolicina) || kolicina <= 0) return;
            if (!double.TryParse(forma.tbxJedinicnaCena.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double jedinicnaCena)) return;
            double cenaStavke = jedinicnaCena * kolicina;
            forma.tbxCenaStavke.Text = cenaStavke.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void PopuniFormuNaOsnovuKlijenta()
        {
            Zajednicki.Domen.Klijent izabraniKlijent = (Zajednicki.Domen.Klijent)forma.cbKlijenti.SelectedItem;
            if (izabraniKlijent == null) return;

            forma.tbxProcenatPopusta.Text = izabraniKlijent.TipKlijenta.Pogodnost.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
