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
