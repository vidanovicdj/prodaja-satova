using Klijent.Exceptions;
using Klijent.ServerKomunikacija;
using Klijent.Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Komunikacija;

namespace Klijent.GUIKontroler.ProdavacKontroler
{
    public class ProdavacPrijavaController
    {
        private FrmLogin FrmLogin;

        public ProdavacPrijavaController(FrmLogin login)
        {
            FrmLogin = login;
        }

        public void Login()
        {
            TextBox tbxKorisnickoIme = FrmLogin.tbxUsername;
            TextBox tbxLozinka = FrmLogin.tbxPassword;

            if (string.IsNullOrEmpty(tbxKorisnickoIme.Text))
            {
                MessageBox.Show("Unesite korisničko ime!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(tbxLozinka.Text))
            {
                MessageBox.Show("Unesite lozinku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Zajednicki.Domen.Prodavac prodavac = new Zajednicki.Domen.Prodavac
            {
                KorisnickoIme = tbxKorisnickoIme.Text,
                Lozinka = tbxLozinka.Text
            };

            try
            {
                Communication.Instance.Connect();
                prodavac = Communication.Instance.PosaljiZahtevVratiRezultat<Zajednicki.Domen.Prodavac>(Operacija.Login, prodavac);
                Session.Instance.TrenutnoPrijavljeni = prodavac;

                MessageBox.Show("Korisničko ime i lozinka su ispravni. " +
                    "Dobro došli, " + prodavac.PunoIme + "!", "Uspešna prijava",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmLogin.Hide();

                using(FrmGlavna glavna = new FrmGlavna())
                {
                    glavna.ShowDialog();
                }
            }
            catch (SystemOperationException es)
            {
                MessageBox.Show(es.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
