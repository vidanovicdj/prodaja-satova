using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Server
{
    public class ClientHandler
    {
        private Socket klijentSoket;
        private bool kraj = false;
        private JsonNetworkSerializer helper;
        private readonly object lockObject = new object();

        public ClientHandler(Socket klijentSoket)
        {
            this.klijentSoket = klijentSoket;
            helper = new JsonNetworkSerializer(klijentSoket);
        }

        public void ObradiZahteve()
        {
            try
            {
                while(true)
                {
                    Zahtev zahtev = helper.Receive<Zahtev>();
                    Odgovor odgovor;
                    try
                    {
                        odgovor = KreirajOdgovor(zahtev);
                    }
                    catch (Exception ex)
                    {
                        odgovor = new Odgovor();
                        odgovor.Signal = false;
                        odgovor.Poruka = ex.Message;
                    }

                    helper.Send(odgovor);

                    lock (lockObject)
                    {
                        if (kraj)
                        {
                            break;
                        }
                    }
                }
            }
            catch (IOException ex) 
            {
                Debug.WriteLine(">>>> Klijent zatvorio formu: " + ex.Message);
            }
            finally
            {
                Stop();
            }
        }

        private Odgovor KreirajOdgovor(Zahtev zahtev)
        {
            Odgovor odgovor = new Odgovor();

            switch (zahtev.Operacija)
            {
                case Operacija.Login:
                    Prodavac p = JsonSerializer.Deserialize<Prodavac>((JsonElement)zahtev.Podaci);
                    odgovor.Podaci = Kontroler.Instance.Login(p);
                    if(odgovor.Podaci == null)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Korisničko ime i/ili lozinka nisu ispravni.";
                    }
                    break;
                case Operacija.Kraj:
                    kraj = true;
                    break;
                case Operacija.ZapamtiSat:
                    Sat sat = JsonSerializer.Deserialize<Sat>((JsonElement)zahtev.Podaci);
                    Kontroler.Instance.UbaciSat(sat);
                    break;
                case Operacija.VratiListuSvihSatova:
                    odgovor.Podaci = Kontroler.Instance.VratiSveSatove();
                    if(odgovor.Podaci == null)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = " Trenutno nema ni jednog sata.";
                    }
                    break;
                case Operacija.VratiSveTipoveKlijenata:
                    odgovor.Podaci = Kontroler.Instance.VratiSveTipoveKlijenata();
                    if(odgovor.Podaci == null)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Trenutno nema ni jednog tipa klijenta.";
                    }
                    break;
                case Operacija.ZapamtiKlijenta:
                    Klijent kSave = JsonSerializer.Deserialize<Klijent>((JsonElement)zahtev.Podaci);
                    Kontroler.Instance.UbaciKlijenta(kSave);
                    break;
                case Operacija.VratiListuSvihKlijenata:
                    odgovor.Podaci = Kontroler.Instance.VratiSveKlijente();
                    if(odgovor.Podaci == null)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Trenutno nema ni jednog klijenta.";
                    }
                    break;
                case Operacija.NadjiKlijente:
                    Klijent k = JsonSerializer.Deserialize<Klijent>((JsonElement)zahtev.Podaci);
                    List<Klijent> pronadjeniKlijenti = Kontroler.Instance.NadjiKlijente(k);
                    if(pronadjeniKlijenti == null || pronadjeniKlijenti.Count == 0)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne može da pronađe klijente po zadatom kriterijumu.";
                    }
                    else
                    {
                        odgovor.Podaci = pronadjeniKlijenti;
                    }
                    break;
                case Operacija.UcitajKlijente:
                    Klijent klijent = JsonSerializer.Deserialize<Klijent>((JsonElement)zahtev.Podaci);
                    odgovor.Podaci = Kontroler.Instance.UcitajKlijenta(klijent);
                    if(odgovor.Podaci == null)
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne može da učita klijenta.";
                    }
                    break;
                case Operacija.IzmeniKlijenta:
                    Klijent kUpdate = JsonSerializer.Deserialize<Klijent>((JsonElement)zahtev.Podaci);
                    if (!Kontroler.Instance.IzmeniKlijenta(kUpdate))
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne može da izmeni klijenta.";
                    }
                    break;
                case Operacija.IzbrisiKlijenta:
                    Klijent kDelete = JsonSerializer.Deserialize<Klijent>((JsonElement)zahtev.Podaci);
                    if (!Kontroler.Instance.ObrisiKlijenta(kDelete))
                    {
                        odgovor.Signal = false;
                        odgovor.Poruka = "Sistem ne može da obriše klijenta.";
                    }
                    break;
                case Operacija.ZapamtiSertifikat:
                    Sertifikat sertifikat = JsonSerializer.Deserialize<Sertifikat>((JsonElement)zahtev.Podaci);
                    Kontroler.Instance.UbaciSertifikat(sertifikat);
                    break;

                //ovde se dodaje za svaku operaciju
            }

            return odgovor;
        }

        public void Stop()
        {
            if(klijentSoket != null)
            {
                klijentSoket.Shutdown(SocketShutdown.Both);
                klijentSoket.Dispose();
                klijentSoket = null;
                kraj = true;
                Debug.WriteLine(">>>> Ugasen klijentski soket!");
            }
        }
    }
}
