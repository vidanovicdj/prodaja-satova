using Klijent.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Zajednicki.Komunikacija;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Klijent.ServerKomunikacija
{
    public class Communication
    {
        private Socket soket;
        private static Communication instance;
        private JsonNetworkSerializer helper;

        private Communication() { }

        public static Communication Instance
        {
            get 
            {
                if(instance == null)
                {
                    instance = new Communication();
                }
                return instance; 
            }
        }
        public void Connect()
        {
            if(soket == null || !soket.Connected)
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                soket.Connect("127.0.0.1", 9999);
                helper = new JsonNetworkSerializer(soket);
                Debug.WriteLine(">>>> Klijentski soket konektovan!");
            }
        }

        public void PosaljiZahtevBezRezultata(Operacija operacija, object zahtevObjekat = null)
        {
            PosaljiZahtev(operacija, zahtevObjekat);
            VratiRezultat();
        }

        public Rezultat PosaljiZahtevVratiRezultat<Rezultat>(Operacija operacija, object zahtevObjekat = null) where Rezultat : class
        {
            PosaljiZahtev(operacija, zahtevObjekat);
            return VratiRezultat<Rezultat>();
        }

        private Rezultat VratiRezultat<Rezultat>() where Rezultat : class
        {
            Odgovor odgovor = helper.Receive<Odgovor>();

            if (odgovor.Signal)
            {
                return JsonSerializer.Deserialize<Rezultat>((JsonElement)odgovor.Podaci);
            }
            else
            {
                throw new SystemOperationException(odgovor.Poruka);
            }
        }

        private void PosaljiZahtev(Operacija operacija, object objekat = null)
        {
            try
            {
                Zahtev z = new Zahtev
                {
                    Operacija = operacija,
                    Podaci = objekat
                };
                helper.Send(z);
            }
            catch (IOException ex)
            {
                MessageBox.Show("PREKINUTA KOMUNIKACIJA!");
                throw new ServerCommunicationException(ex.Message);
            }
        }

        private void VratiRezultat()
        {
            Odgovor odgovor = helper.Receive<Odgovor>();
            if (!odgovor.Signal)
            {
                throw new SystemOperationException(odgovor.Poruka);
            }
        }
        public void ZatvoriKonekciju()
        {
            try
            {
                Zahtev zahtev = new Zahtev { Operacija = Operacija.Kraj };

                helper.Send(zahtev);
                soket.Shutdown(SocketShutdown.Both);
                soket.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
