using SistemskeOperacije;
using SistemskeOperacije.KlijentSO;
using SistemskeOperacije.ProdavacSO;
using SistemskeOperacije.RacunSO;
using SistemskeOperacije.SatSO;
using SistemskeOperacije.SertifikatSO;
using SistemskeOperacije.TipKlijentaSO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server
{
    public class Kontroler
    {
        private static Kontroler instance;
        private static object _lock = new object();

        private Kontroler() { }
        public static Kontroler Instance
        {
            get 
            {
                if(instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Kontroler();
                        }
                    }
                }
                return instance; 
            }
        }

        /* PRODAVAC */
        public Prodavac Login(Prodavac p)
        {
            LoginSO so = new LoginSO();
            so.ExecuteTemplate(p);
            return so.Result;
        }
        public List<Prodavac> VratiSveProdavce()
        {
            OpstaSO so = new VratiListuSvihProdavacaSO();
            so.ExecuteTemplate(new Prodavac());
            return ((VratiListuSvihProdavacaSO)so).Rezultat;
        }
        
        /* SAT */
        public void UbaciSat(Sat sat)
        {
            OpstaSO so = new ZapamtiSatSO(sat);
            so.ExecuteTemplate(sat);
        }
        public List<Sat> VratiSveSatove()
        {
            OpstaSO so = new VratiListuSvihSatovaSO();
            so.ExecuteTemplate(new Sat());
            return ((VratiListuSvihSatovaSO)so).Rezultat;
        }

        /* TIP KLIJENTA */
        public List<TipKlijenta> VratiSveTipoveKlijenata()
        {
            OpstaSO so = new VratiListuSvihTipovaKlijenataSO();
            so.ExecuteTemplate(new TipKlijenta());
            return ((VratiListuSvihTipovaKlijenataSO)so).Rezultat;
        }

        /* KLIJENT */
        public void UbaciKlijenta(Klijent k)
        {
            OpstaSO so = new ZapamtiKlijentaSO(k);
            so.ExecuteTemplate(k);
        }
        public List<Klijent> VratiSveKlijente()
        {
            OpstaSO so = new VratiListuSvihKlijenataSO();
            so.ExecuteTemplate(new Klijent());
            return ((VratiListuSvihKlijenataSO)so).Rezultat;
        }
        public List<Klijent> NadjiKlijente(Klijent k)
        {
            OpstaSO so = new NadijKlijenteSO();
            so.ExecuteTemplate(k);
            return ((NadijKlijenteSO)so).Rezultat;
        }
        public Klijent UcitajKlijenta(Klijent k)
        {
            OpstaSO so = new UcitajKlijenteSO(k);
            so.ExecuteTemplate(new Klijent());
            return ((UcitajKlijenteSO)so).Rezultat;
        }
        public bool IzmeniKlijenta(Klijent k)
        {
            OpstaSO so = new IzmeniKlijentaSO(k);
            so.ExecuteTemplate(new Klijent());
            return ((IzmeniKlijentaSO)so).Rezultat;
        }
        public bool ObrisiKlijenta(Klijent k)
        {
            OpstaSO so = new ObrisiKlijentaSO(k);
            so.ExecuteTemplate(new Klijent());
            return ((ObrisiKlijentaSO)so).Rezultat;
        }

        /* SERTIFIKAT */
        public void UbaciSertifikat(Sertifikat s)
        {
            OpstaSO so = new ZapamtiSertifikatSO(s);
            so.ExecuteTemplate(s);
        }

        /* RAČUN */
        public void UbaciRacun(Racun r)
        {
            OpstaSO so = new ZapamtiRacunSO();
            so.ExecuteTemplate(r);
        }
        public List<Racun> VratiSveRacune()
        {
            OpstaSO so = new VratiListuSvihRacunaSO();
            so.ExecuteTemplate(new Racun());
            return ((VratiListuSvihRacunaSO)so).Rezultat.ToList();
        }
        public List<Racun> NadjiRacune(Racun r)
        {
            OpstaSO so = new NadjiRacuneSO();
            so.ExecuteTemplate(r);
            return ((NadjiRacuneSO)so).Rezultat;
        }
        public Racun UcitajRacun(Racun r)
        {
            OpstaSO so = new UcitajRacuneSO(r);
            so.ExecuteTemplate(new Racun());
            return ((UcitajRacuneSO)so).Rezultat;
        }
        public bool IzmeniRacun(Racun r)
        {
            OpstaSO so = new IzmeniRacunSO(r);
            so.ExecuteTemplate(new Racun());
            return ((IzmeniRacunSO)so).Rezultat;
        }
    }
}
