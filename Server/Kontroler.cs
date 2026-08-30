using SistemskeOperacije;
using SistemskeOperacije.KlijentSO;
using SistemskeOperacije.ProdavacSO;
using SistemskeOperacije.SatSO;
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

        public List<TipKlijenta> VratiSveTipoveKlijenata()
        {
            OpstaSO so = new VratiListuSvihTipovaKlijenataSO();
            so.ExecuteTemplate(new TipKlijenta());
            return ((VratiListuSvihTipovaKlijenataSO)so).Rezultat;
        }
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
    }
}
