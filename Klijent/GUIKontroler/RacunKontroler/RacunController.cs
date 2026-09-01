using Klijent.Exceptions;
using Klijent.ServerKomunikacija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.RacunKontroler
{
    public class RacunController
    {
        private FrmUbaciRacun forma;
        private BindingList<StavkaRacuna> stavke;
        private Racun trenutniRacun;
        public RacunController(FrmUbaciRacun forma)
        {
            this.forma = forma;
            stavke = new BindingList<StavkaRacuna>();
            trenutniRacun = new Racun();
            //Init();
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

                forma.dgvStavke.DataSource = stavke;

                SakrijNepotrebneKolone();
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

            if(!int.TryParse(forma.tbxKolicina.Text, out int kolicina) || kolicina <= 0)
            {
                MessageBox.Show("Polje Količina mora biti ceo broj!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double iznosStavke = kolicina * selektovanSat.CenaSata;

            StavkaRacuna sr = new StavkaRacuna()
            {
                Sat = selektovanSat,
                Kolicina = kolicina,
                JedinicnaCena = selektovanSat.CenaSata,
                CenaStavke = iznosStavke
            };

            stavke.Add(sr);
            IzracunajCenuRacuna();
            forma.dgvStavke.Refresh();
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

        public void ObrisiStavku()
        {
            if(stavke.Count == 0)
            {
                MessageBox.Show("Nema stavki za brisanje.", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(forma.dgvStavke.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali stavku za brisanje", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StavkaRacuna selektovana = (StavkaRacuna)forma.dgvStavke.SelectedRows[0].DataBoundItem;

            stavke.Remove(selektovana);
            forma.dgvStavke.Refresh();
            SakrijNepotrebneKolone();
        }

        public void UbaciRacun()
        {
            if (!ValidirajPodatke()) return;

            Prodavac p = (Prodavac)forma.cbProdavci.SelectedItem;
            Zajednicki.Domen.Klijent kl = (Zajednicki.Domen.Klijent)forma.cbKlijenti.SelectedItem;
            DateTime datumIzdavanja = forma.dtpDatumIzdavanja.Value.Date;

            double popust = kl.TipKlijenta.Pogodnost;
            double iznosPunaCena = 0;
            foreach (StavkaRacuna s in stavke)
            {
                iznosPunaCena += s.CenaStavke;
            }
            double iznosSaPopustom = iznosPunaCena * (1 - popust);

            Racun r = new Racun()
            {
                Klijent = kl,
                Prodavac = p,
                DatumIzdavanja = datumIzdavanja,
                ProcenatPopusta = popust,
                IznosPunaCena = iznosPunaCena,
                IznosSaPopustom = iznosSaPopustom,
                NacinPlacanja = (NacinPlacanja)forma.cbNacinPlacanja.SelectedItem,
                Stavke = stavke.ToList()
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.ZapamtiRacun, r);

                MessageBox.Show("Sistem je zapamtio račun!", "Uspeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiFormu();
            }
            catch (ServerCommunicationException)
            {
                MessageBox.Show("Sistem ne može da zapamti račun.", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OcistiFormu();
            }
            catch (Exception es)
            {
                MessageBox.Show("Sistem ne može da zapamti račun.", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OcistiFormu()
        {
            stavke.Clear();
            forma.cbProdavci.SelectedIndex = -1;
            forma.cbKlijenti.SelectedIndex = -1;
            forma.dtpDatumIzdavanja.Value = DateTime.Now;
            forma.tbxPunaCena.Clear();
            forma.tbxProcenatPopusta.Clear();
            forma.tbxCenaSaPopustom.Clear();
            forma.cbNacinPlacanja.SelectedIndex = -1;
            OcistiPanel();
        }

        private bool ValidirajPodatke()
        {
            if(stavke.Count == 0)
            {
                MessageBox.Show("Račun mora imati bar jednu stavku!", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(forma.cbProdavci.SelectedItem == null)
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
            if (!int.TryParse(forma.tbxKolicina.Text, out int kolicina) || kolicina <= 0)  return;
            if (!double.TryParse(forma.tbxJedinicnaCena.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double jedinicnaCena)) return;
            double cenaStavke = jedinicnaCena * kolicina;
            forma.tbxCenaStavke.Text = cenaStavke.ToString("F2", CultureInfo.InvariantCulture);
        }

        private void IzracunajCenuRacuna()
        {
            if (!double.TryParse(forma.tbxProcenatPopusta.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double popust)) return;
            if (!double.TryParse(forma.tbxPunaCena.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double punaCena)) return;

            foreach(var stavka in stavke)
            {
                punaCena += stavka.CenaStavke;
            }

            double cenaSaPopustom = punaCena * (1 - popust);
            
            forma.tbxPunaCena.Text = punaCena.ToString("F2", CultureInfo.InvariantCulture);
            forma.tbxCenaSaPopustom.Text = cenaSaPopustom.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void PopuniFormuNaOsnovuKlijenta()
        {
            Zajednicki.Domen.Klijent izabraniKlijent = (Zajednicki.Domen.Klijent)forma.cbKlijenti.SelectedItem;
            if (izabraniKlijent == null) return;

            forma.tbxProcenatPopusta.Text = izabraniKlijent.TipKlijenta.Pogodnost.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
